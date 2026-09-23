// Reconstructed from the AssetRipper dummy export (which returned a flat colour).
// The mesh is generated from a path and carries no UVs, so the albedo is projected
// from world space at _TexScale - which is what _TexScale exists for.
Shader "Custom/Cliffs_Lambert"
{
    Properties
    {
        _MainTex ("Texture", 2D) = "white" {}
        _TexScale ("Tex Scale", Float) = 0.2
        _AmbientColor ("Ambient Color", Color) = (1,1,1,1)
        _LightColor ("Light Color", Color) = (1,1,1,1)
        _SpecularColor ("Specular Color", Color) = (1,1,1,1)
        _Shininess ("Shininess", Float) = 10
    }

    SubShader
    {
        Tags { "RenderType" = "Opaque" }
        LOD 200

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
            float _TexScale;
            float4 _AmbientColor;
            float4 _LightColor;
            float4 _SpecularColor;
            float _Shininess;
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
                fixed4 albedo = tex2D(_MainTex, i.worldPos.xy * _TexScale);

                float3 n = normalize(i.worldNrm);
                float3 lightDir = normalize(-_LightDirection.xyz + float3(0, 0, -1));
                float ndotl = saturate(dot(n, lightDir));

                float3 viewDir = normalize(_WorldSpaceCameraPos - i.worldPos);
                float3 halfDir = normalize(lightDir + viewDir);
                float spec = pow(saturate(dot(n, halfDir)), max(1.0, _Shininess));

                fixed3 lit = albedo.rgb * (_AmbientColor.rgb + _LightColor.rgb * ndotl)
                           + _SpecularColor.rgb * spec;
                return fixed4(lit, 1);
            }
            ENDHLSL
        }
    }
}
