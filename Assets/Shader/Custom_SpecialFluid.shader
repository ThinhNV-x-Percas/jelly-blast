Shader "Custom/SpecialFluid"
{
    Properties
    {
        _RawFieldTex ("Raw Field", 2DArray) = "" {}
        _FluidTex ("Merged Fluid", 2D) = "black" {}
        _DetailTex ("Detail", 2D) = "white" {}
        [MainColor] _Color ("Tint", Color) = (1,1,1,1)
        _DetailTexScale ("Detail Scale", Float) = 1
        _AlphaThreshold ("Alpha Threshold", Range(0,1)) = 0.1
        _Alpha ("Alpha", Range(0,1)) = 1
        _ReflectAmount ("Reflection", Range(0,1)) = 0.75
        _Shininess ("Shininess", Float) = 90
        _SpecularIntensity ("Specular Intensity", Range(0,1)) = 1
        _LightColor ("Light Color", Color) = (1,1,1,1)
        _AmbientColor ("Ambient Color", Color) = (1,1,1,1)
    }

    SubShader
    {
        Tags { "Queue"="Transparent+10" "RenderType"="Transparent" "IgnoreProjector"="True" }
        LOD 200
        Cull Off
        ZWrite Off
        ZTest LEqual
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            HLSLPROGRAM
            #pragma target 3.5
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float2 uv : TEXCOORD0;
            };

            struct v2f
            {
                float4 vertex : SV_POSITION;
                float4 screenPos : TEXCOORD0;
                float2 uv : TEXCOORD1;
            };

            UNITY_DECLARE_TEX2DARRAY(_RawFieldTex);
            sampler2D _FluidTex;
            sampler2D _DetailTex;
            float4 _FluidTex_TexelSize;
            float _DetailTexScale;
            float _AlphaThreshold;
            float _Alpha;
            float _ReflectAmount;
            float _Shininess;
            float _SpecularIntensity;
            float4 _LightColor;
            float4 _AmbientColor;
            float4 _Color;
            int _FluidType;

            v2f vert(appdata input)
            {
                v2f output;
                output.vertex = UnityObjectToClipPos(input.vertex);
                output.screenPos = ComputeScreenPos(output.vertex);
                output.uv = input.uv;
                return output;
            }

            float4 frag(v2f input) : SV_Target
            {
                float2 uv = input.screenPos.xy / input.screenPos.w;

                // FluidCompute packs four fluid types into each raw-field layer.
                int layer = clamp(_FluidType / 4, 0, 7);
                int channel = clamp(_FluidType - layer * 4, 0, 3);
                float4 raw = UNITY_SAMPLE_TEX2DARRAY_LOD(_RawFieldTex, float3(uv, (float)layer), 0.0);
                // The merged field only contains the public colour-fluid layers. A SpecialFluid
                // must never fall back to that field, otherwise a different fluid can make it
                // appear in the wrong place.
                float density = raw[channel];
                if (density <= 0.001)
                    discard;

                float edge = max(fwidth(density) * 1.5, 0.004);
                float coverage = smoothstep(_AlphaThreshold - edge, _AlphaThreshold + edge, density);
                coverage = saturate(coverage);
                if (coverage <= 0.001)
                    discard;

                float detail = saturate(tex2D(_DetailTex, uv * _DetailTexScale).r);
                float3 baseColor = _Color.rgb * lerp(0.82, 1.08, detail);
                float3 shaded = baseColor * lerp(_AmbientColor.rgb, 1.0, 0.45);

                float2 texel = max(_FluidTex_TexelSize.xy, float2(1e-5, 1e-5));
                float dx = tex2D(_FluidTex, uv + float2(texel.x, 0.0)).a
                         - tex2D(_FluidTex, uv - float2(texel.x, 0.0)).a;
                float dy = tex2D(_FluidTex, uv + float2(0.0, texel.y)).a
                         - tex2D(_FluidTex, uv - float2(0.0, texel.y)).a;
                float3 normal = normalize(float3(-dx, -dy, 0.35));
                float spec = _SpecularIntensity * pow(saturate(normal.z), max(1.0, _Shininess));

                float3 finalColor = shaded + _LightColor.rgb * spec * _ReflectAmount;
                return float4(finalColor, coverage * _Alpha);
            }
            ENDHLSL
        }
    }
}