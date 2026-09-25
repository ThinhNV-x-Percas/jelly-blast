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

            float4 frag (v2f i) : SV_Target
            {
                float2 uv = i.screenPos.xy / i.screenPos.w;
                float4 fluid = tex2D(_FluidTex, uv);

                float edge = pow(1.0 - fluid.a, 4.0) * 180.0;
                float3 n = float3(-ddx(fluid.a) * edge, ddy(fluid.a) * _FlipDY * edge, -0.01);
                float invLen = rsqrt(dot(n, n));
                n *= invLen;
                float fresnel = 1.0 - invLen * 0.01;

                float3 halfDir = normalize(-_LightDirection.xyz + float3(0.0, 0.0, -1.0));
                float spec = pow(saturate(dot(n, halfDir)), _Shininess) * _SpecularIntensity;
                float diffuse = saturate(dot(n, -_LightDirection.xyz));
                float3 light = _LightColor.rgb * diffuse + _AmbientColor.rgb;

                float t = saturate((fluid.a - (_AlphaThreshold - 0.02)) * 25.0);
                float coverage = t * t * (3.0 - 2.0 * t);

                float3 col = fluid.rgb * coverage * light + spec;
                float3 reflTint = (col - 0.04) * _ReflectAmount + 0.04;

                float4 refl = tex2D(_FluidTex, uv + n.xy * 0.03);
                float3 reflCol = refl.rgb * refl.a * fresnel * reflTint;
                float ao = 1.0 - _AOStrength * refl.a * fresnel;
                float reflMask = (1.0 - ao) * _ReflectAmount * _ReflectAmount + ao;
                col = col * ao + reflCol * min(reflMask * reflMask, 1.0);

                float3 emi = tex2D(_EmissionTex, uv).xyw;
                float flash = emi.x >= emi.y ? 1.0 : 0.0;
                col *= flash * emi.z + 1.0;
                col = lerp(col, flash, emi.z * 0.6);

                return float4(col, coverage);
            }
            ENDHLSL
        }
    }
}
