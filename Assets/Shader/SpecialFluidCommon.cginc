// Shared code for the special-fluid shaders (mud/snow, honey, bee, caterpillar, octopus, sponge).
// Reconstruction: the exported shaders were AssetRipper dummies that returned a flat colour, so each
// special fluid drew its bounding quad as a solid rectangle. Lighting follows Custom/Fluid (rebuilt
// from the original Metal program): screen-space normal from the field's derivatives, weighted by
// (1 - a)^4, key light from _LightDirection, Blinn specular, smoothstep coverage around
// _AlphaThreshold, and the white power-up flash from _EmissionTex.
//
// Field source:
//  - in game: FluidCompute's raw-field array, sampled in screen space; four fluid types per layer,
//    this renderer's type comes from _FluidType (set by SpecialFluid through the property block);
//  - UI icons: UIIconGenerator draws a quad with _Seed = -1 and _FluidTexArray (a blob texture),
//    sampled with the quad's own uv.
#ifndef SPECIAL_FLUID_COMMON_INCLUDED
#define SPECIAL_FLUID_COMMON_INCLUDED

#include "UnityCG.cginc"

UNITY_DECLARE_TEX2DARRAY(_RawFieldTex);
UNITY_DECLARE_TEX2DARRAY(_FluidTexArray);
sampler2D _EmissionTex;

int _FluidType;
float _Seed;
float _Alpha;
float _AlphaThreshold;
float _ReflectAmount;
float _Shininess;
float _SpecularIntensity;
float _FlipDY;
float4 _LightColor;
float4 _AmbientColor;
float4 _LightDirection;

struct sf_appdata
{
    float4 vertex : POSITION;
    float2 uv : TEXCOORD0;
};

struct sf_v2f
{
    float4 vertex : SV_POSITION;
    float4 screenPos : TEXCOORD0;
    float3 worldPos : TEXCOORD1;
    float2 uv : TEXCOORD2;
};

struct SFSurface
{
    float2 screenUV;
    float density;
    float coverage;
    float3 normal;   // faces the camera (-z), like Custom/Fluid
    float rim;       // (1 - density)^4: 0 inside, 1 at the silhouette
};

sf_v2f SFVert(sf_appdata v)
{
    sf_v2f o;
    o.vertex = UnityObjectToClipPos(v.vertex);
    o.screenPos = ComputeScreenPos(o.vertex);
    o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
    o.uv = v.uv;
    return o;
}

bool SFIsIcon()
{
    return _Seed < 0.0;
}

float SFSampleDensity(float2 screenUV, float2 quadUV)
{
    int layer = clamp(_FluidType / 4, 0, 7);
    int channel = clamp(_FluidType - layer * 4, 0, 3);
    float4 raw;
    if (SFIsIcon())
        raw = UNITY_SAMPLE_TEX2DARRAY_LOD(_FluidTexArray, float3(quadUV, (float)layer), 0.0);
    else
        raw = UNITY_SAMPLE_TEX2DARRAY_LOD(_RawFieldTex, float3(screenUV, (float)layer), 0.0);
    return raw[channel];
}

// Samples the field and discards pixels outside the fluid.
SFSurface SFSample(sf_v2f i)
{
    SFSurface s;
    s.screenUV = i.screenPos.xy / i.screenPos.w;
    s.density = SFSampleDensity(s.screenUV, i.uv);

    float t = saturate((s.density - (_AlphaThreshold - 0.02)) * 25.0);
    s.coverage = t * t * (3.0 - 2.0 * t);
    if (s.coverage <= 0.001)
        discard;

    s.rim = pow(saturate(1.0 - s.density), 4.0);
    float edge = s.rim * 180.0;
    float3 n = float3(-ddx(s.density) * edge, ddy(s.density) * _FlipDY * edge, -0.01);
    s.normal = normalize(n);
    return s;
}

float3 SFLightDir()
{
    float3 l = _LightDirection.xyz;
    return dot(l, l) > 1e-6 ? normalize(l) : normalize(float3(0.4, -0.6, 1.0));
}

// Diffuse + ambient on the albedo, plus specular.
float3 SFShade(SFSurface s, float3 albedo)
{
    float3 lightDir = SFLightDir();
    float diffuse = saturate(dot(s.normal, -lightDir));
    float3 halfDir = normalize(-lightDir + float3(0.0, 0.0, -1.0));
    float spec = pow(saturate(dot(s.normal, halfDir)), max(_Shininess, 1.0)) * _SpecularIntensity;

    float3 col = albedo * (_LightColor.rgb * diffuse + _AmbientColor.rgb);
    // Glossy edge: the silhouette picks up a little of the light colour, scaled by _ReflectAmount.
    col = lerp(col, col + _LightColor.rgb * 0.25, s.rim * _ReflectAmount);
    return col + spec * _LightColor.rgb;
}

// White flash written by FluidCompute's emission pass (power-up charge / detonation highlight).
float3 SFApplyEmission(float3 col, float2 screenUV)
{
    if (SFIsIcon())
        return col;
    float3 emi = tex2D(_EmissionTex, screenUV).xyw;
    float flash = emi.x >= emi.y ? 1.0 : 0.0;
    col *= flash * emi.z + 1.0;
    return lerp(col, flash, emi.z * 0.6);
}

float SFAlpha(SFSurface s)
{
    return s.coverage * _Alpha;
}

// Rotates a 2D offset by -angle (world -> body space).
float2 SFToLocal(float2 offset, float angle)
{
    float c = cos(angle);
    float sn = sin(angle);
    return float2(c * offset.x + sn * offset.y, -sn * offset.x + c * offset.y);
}

// Samples an RGBA decal (eyes etc.) centred at 'offset' (body space, world units); returns rgb + mask.
float4 SFDecal(sampler2D tex, float2 localOffset, float2 size)
{
    float2 uv = localOffset / max(size, float2(1e-4, 1e-4)) + 0.5;
    if (any(uv < 0.0) || any(uv > 1.0))
        return float4(0.0, 0.0, 0.0, 0.0);
    return tex2D(tex, uv);
}

#endif
