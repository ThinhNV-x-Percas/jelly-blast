Shader "Custom/PowerUpParticles" {
Properties {
}
SubShader {
Tags { "RenderType" = "Opaque" }
LOD 200
Pass
{
Blend One One
ZWrite Off
ZTest Always
Cull Off
HLSLPROGRAM
#pragma vertex vert
#pragma fragment frag
#pragma multi_compile_instancing
#pragma instancing_options procedural:setup
#include "UnityCG.cginc"

struct VertexIn
{
    float4 pos : POSITION;
    float2 uv : TEXCOORD0;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct VertexOut
{
    float4 pos : SV_POSITION;
    float2 uv : TEXCOORD0;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

float _ParticleTypes[1024];
float _IsRounded[1024];
float _InnerRadii[1024];
int _Layer;

VertexOut vert(VertexIn input)
{
    VertexOut output;
    UNITY_SETUP_INSTANCE_ID(input);
    UNITY_TRANSFER_INSTANCE_ID(input, output);
    output.pos = UnityObjectToClipPos(input.pos);
    output.uv = input.uv;
    return output;
}

float4 frag(VertexOut input) : SV_TARGET
{
    UNITY_SETUP_INSTANCE_ID(input);
    uint id = min(unity_InstanceID, 1023u);
    int fluidType = (int)(_ParticleTypes[id] + 0.5);
    int layer = fluidType / 4;
    int channel = fluidType - layer * 4;
    if (layer != _Layer)
        return float4(0, 0, 0, 0);
    float2 centered = (input.uv - 0.5) * 2.0;
    float dd = length(centered);
    // The footprint must die out at 0.8 of the quad's half-extent, because that is what
    // FluidRendererBase.particleBoundsRadius (0.4 of the full quad) sizes the display quad to.
    // A falloff reaching 1.0 - as the stand-in shader had - is still at cover 0.42 where the
    // quad clips, i.e. above _AlphaThreshold (0.4): every blob on the outside of the mass was
    // sliced flat exactly where its outline should be.
    float cover = 1.0 - smoothstep(0.44, 0.8, dd);
    float innerRadius = _InnerRadii[id];
    if (innerRadius > 0.001)
        cover *= smoothstep(innerRadius * 0.6, innerRadius, dd);
    cover = saturate(cover);
    if (cover <= 0.0)
        return float4(0, 0, 0, 0);
    float4 result = float4(0, 0, 0, 0);
    if (channel == 0) result.r = cover;
    else if (channel == 1) result.g = cover;
    else if (channel == 2) result.b = cover;
    else result.a = cover;
    return result;
}
ENDHLSL
}
}
}