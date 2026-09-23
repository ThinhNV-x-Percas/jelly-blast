Shader "Custom/Fluid"
{
    Properties
    {
        _FluidTex        ("Fluid Texture", 2D) = "white" {}
        _EmissionTex     ("Emission Texture", 2D) = "black" {}

        _ReflectAmount   ("Reflect Amount", Range(0,1)) = 1
        _AOStrength      ("AO Strength", Range(0,1)) = 1
        _AlphaThreshold  ("Alpha Threshold", Range(0,1)) = 1
        _LightColor      ("Light Color", Color) = (1,1,1,1)
        _AmbientColor    ("Ambient Color", Color) = (1,1,1,1)
        _Shininess       ("Shininess", Float) = 1
        _SpecularIntensity("Specular Intensity", Range(0,1)) = 1
        _FlipDY          ("Flip DY", Float) = 1
    }

    SubShader
    {
        Tags
        {
            "Queue"          = "Transparent+1"
            "RenderType"     = "Transparent"
            "IgnoreProjector" = "True"
        }
        LOD 200
        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha
        Cull Off

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
            };

            struct v2f
            {
                float4 screenPos : TEXCOORD0;
                float4 vertex    : SV_POSITION;
            };

            sampler2D _FluidTex;
            sampler2D _EmissionTex;
            float4    _FluidTex_TexelSize;
            float     _ReflectAmount;
            float     _AOStrength;
            float     _AlphaThreshold;
            float4    _LightColor;
            float4    _AmbientColor;
            float     _Shininess;
            float     _SpecularIntensity;
            float     _FlipDY;
            float4    _LightDirection;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                // The fluid field is rendered by FluidCompute through the main camera,
                // so it is a screen-space texture - the quad's own UVs do not address it.
                o.screenPos = ComputeScreenPos(o.vertex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float2 uv = i.screenPos.xy / i.screenPos.w;

                fixed4 fluidCol = tex2D(_FluidTex, uv);
                fixed4 emitCol  = tex2D(_EmissionTex, uv);

                // FluidCS writes the merged metaball field into alpha; threshold it into a surface.
                // The raw field is ~1/3 of screen resolution, so widen the edge to hide its steps.
                float edge = fwidth(fluidCol.a) * 1.5 + 0.02;
                float coverage = smoothstep(_AlphaThreshold - edge, _AlphaThreshold + edge, fluidCol.a);
                clip(coverage - 0.001);

                // Field gradient stands in for the surface normal.
                float2 texel = _FluidTex_TexelSize.xy;
                float dx = tex2D(_FluidTex, uv + float2(texel.x, 0)).a - tex2D(_FluidTex, uv - float2(texel.x, 0)).a;
                float dy = tex2D(_FluidTex, uv + float2(0, texel.y)).a - tex2D(_FluidTex, uv - float2(0, texel.y)).a;
                float3 normal = normalize(float3(-dx, -dy * _FlipDY, 0.35));

                float ndotl = saturate(dot(normal, normalize(-_LightDirection.xyz + float3(0, 0, -1))));

                // Shade by brightness only - the level's own colours must survive.
                float shade = lerp(1.0 - _AOStrength * 0.4, 1.0, ndotl);
                float spec = _SpecularIntensity * pow(ndotl, max(1.0, _Shininess));

                fixed3 final = fluidCol.rgb * shade
                             + _LightColor.rgb * spec
                             + emitCol.rgb * _ReflectAmount;
                return fixed4(final, coverage);
            }
            ENDHLSL
        }
    }
}
