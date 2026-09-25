// Reconstruction: the export was an AssetRipper dummy returning a flat colour. Used by the rejected-tap
// splash (fever splash.prefab). splash.anim drives _Interpolator 0 -> 1 over ~0.28 s and _Range 0.4 -> 0.6;
// the texture (splash ring 1.png) stores the normalised radius in R and the disc in A. The ring's outer
// edge travels outwards with _Interpolator, _Range is its thickness, and it fades out as it expands.
Shader "Custom/FeverSplash" {
	Properties {
		_Color ("Tint Color", Color) = (0.5,0.5,0.5,0.5)
		_Range ("Range", Range(0, 1)) = 0.5
		_Interpolator ("Interpolator", Range(0, 1)) = 0
		_MainTex ("Particle Texture", 2D) = "white" {}
		_InvFade ("Soft Particles Factor", Range(0.01, 3)) = 1
	}

	SubShader {
		Tags { "Queue"="Transparent+30" "RenderType"="Transparent" "IgnoreProjector"="True" "PreviewType"="Plane" }
		LOD 200
		Cull Off
		ZWrite Off
		Lighting Off
		Blend SrcAlpha OneMinusSrcAlpha

		Pass {
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			struct appdata {
				float4 vertex : POSITION;
				float4 color : COLOR;
				float2 uv : TEXCOORD0;
			};

			struct v2f {
				float4 vertex : SV_POSITION;
				float4 color : COLOR;
				float2 uv : TEXCOORD0;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float4 _Color;
			float _Range;
			float _Interpolator;

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = UnityObjectToClipPos(v.vertex);
				o.color = v.color;
				o.uv = TRANSFORM_TEX(v.uv, _MainTex);
				return o;
			}

			float4 frag(v2f i) : SV_Target
			{
				float4 tex = tex2D(_MainTex, i.uv);
				float radius = tex.r;

				float outer = _Interpolator;
				float inner = _Interpolator - max(_Range, 0.001);
				float soft = 0.05;
				float band = smoothstep(inner - soft, inner + soft, radius) * (1.0 - smoothstep(outer - soft, outer + soft, radius));

				float4 col = 2.0 * _Color; // built-in quad has no vertex colours
				col.a *= band * tex.a * (1.0 - _Interpolator);
				return saturate(col);
			}
			ENDHLSL
		}
	}
}
