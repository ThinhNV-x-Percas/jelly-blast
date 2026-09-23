// Reconstructed from the AssetRipper dummy export (which returned a flat _MainTex sample).
// The original almost certainly refracted through a GrabPass; _RefractDist survives as the
// only evidence of it. Rendered here as transparent rim-lit glass so the tube reads as glass
// and stays behind the fluid (queue Transparent < the fluid's Transparent+1).
Shader "Custom/Glass2"
{
    Properties
    {
        [NoScaleOffset] _MainTex ("Texture", 2D) = "white" {}
        _RefractDist ("Refract Dist", Float) = 0.3
        _RimPower ("Rim Power", Float) = 3
        _GlassColor ("Glass Color", Color) = (0.72, 0.87, 1, 0.18)
    }

    SubShader
    {
        Tags { "Queue" = "Transparent" "RenderType" = "Transparent" "IgnoreProjector" = "True" }
        LOD 200
        ZWrite Off
        Blend SrcAlpha OneMinusSrcAlpha
        Cull Back

        Pass
        {
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag
            #include "UnityCG.cginc"

            struct appdata
            {
                float4 vertex : POSITION;
                float3 normal : NORMAL;
            };

            struct v2f
            {
                float4 pos      : SV_POSITION;
                float3 worldPos : TEXCOORD0;
                float3 worldNrm : TEXCOORD1;
            };

            sampler2D _MainTex;
            float _RefractDist;
            float _RimPower;
            float4 _GlassColor;
            float4 _LightDirection;

            v2f vert (appdata v)
            {
                v2f o;
                o.pos = UnityObjectToClipPos(v.vertex);
                o.worldPos = mul(unity_ObjectToWorld, v.vertex).xyz;
                o.worldNrm = UnityObjectToWorldNormal(v.normal);
                return o;
            }

            fixed4 frag (v2f i) : SV_Target
            {
                float3 n = normalize(i.worldNrm);
                float3 viewDir = normalize(_WorldSpaceCameraPos - i.worldPos);

                float rim = pow(saturate(1.0 - abs(dot(n, viewDir))), max(0.01, _RimPower));
                float ndotl = saturate(dot(n, normalize(-_LightDirection.xyz + float3(0, 0, -1))));

                // _RefractDist only shifts where the surface tint is sampled; without a
                // GrabPass there is nothing behind to bend, so it modulates the tint instead.
                float3 tint = _GlassColor.rgb * (1.0 + _RefractDist * (ndotl - 0.5));
                float alpha = saturate(_GlassColor.a + rim);

                return fixed4(tint + rim.xxx * 0.6, alpha);
            }
            ENDHLSL
        }
    }
}
