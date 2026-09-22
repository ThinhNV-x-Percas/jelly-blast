Shader "Custom/Fluid"
{
    Properties
    {
        _FluidTex        ("Fluid Texture", 2D) = "white" {}
        _EmissionTex     ("Emission Texture", 2D) = "black" {}
        _RawFieldTex     ("Raw Field Texture", 2D) = "black" {}

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
                float2 uv     : TEXCOORD0;
            };

            struct v2f
            {
                float2 uv      : TEXCOORD0;
                float4 vertex  : SV_POSITION;
            };

            sampler2D _FluidTex;
            sampler2D _EmissionTex;
            sampler2D _RawFieldTex;
            float4    _FluidTex_ST;
            float     _ReflectAmount;
            float     _AOStrength;
            float     _AlphaThreshold;
            float4    _LightColor;
            float4    _AmbientColor;
            float     _Shininess;
            float     _SpecularIntensity;
            float     _FlipDY;

            v2f vert (appdata v)
            {
                v2f o;
                o.vertex = UnityObjectToClipPos(v.vertex);
                o.uv = TRANSFORM_TEX(v.uv, _FluidTex);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                fixed4 fluidCol = tex2D(_FluidTex, i.uv);
                fixed4 emitCol  = tex2D(_EmissionTex, i.uv);
                fixed4 rawCol   = tex2D(_RawFieldTex, i.uv);

                fixed3 base = fluidCol.rgb + emitCol.rgb * _ReflectAmount;
                fixed3 ao = base * _AmbientColor.rgb * (1.0 - _AOStrength * (1.0 - rawCol.r));
                fixed3 lit = ao * _LightColor.rgb;
                fixed3 spec = _SpecularIntensity * _LightColor.rgb * pow(max(0.0, 1.0 - rawCol.r), _Shininess * 10.0);

                fixed3 final = lit + spec;
                final *= (1.0 - _FlipDY * 0.5);

                return fixed4(final, fluidCol.a * _AlphaThreshold);
            }
            ENDHLSL
        }
    }
}