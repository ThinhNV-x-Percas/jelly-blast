Shader "Custom/UITransition"
{
	Properties
	{
		[PerRendererData] _MainTex ("Sprite Texture", 2D) = "white" {}
		_Color ("Tint", Color) = (1,1,1,1)

		_CircleRadius ("Circle Radius", Range(0, 1)) = 0.5
		_CircleSoftness ("Circle Softness", Range(0, 0.1)) = 0.01

		_StencilComp ("Stencil Comparison", Float) = 8
		_Stencil ("Stencil ID", Float) = 0
		_StencilOp ("Stencil Operation", Float) = 0
		_StencilWriteMask ("Stencil Write Mask", Float) = 255
		_StencilReadMask ("Stencil Read Mask", Float) = 255
		_ColorMask ("Color Mask", Float) = 15

		[Toggle(UNITY_UI_ALPHACLIP)]
		_UseUIAlphaClip ("Use Alpha Clip", Float) = 0
	}

	SubShader
	{
		Tags { "Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent" "PreviewType"="Plane" "CanUseSpriteAtlas"="True" }

		Stencil
		{
			Ref [_Stencil]
			Comp [_StencilComp]
			Pass [_StencilOp]
			ReadMask [_StencilReadMask]
			WriteMask [_StencilWriteMask]
		}

		Cull Off
		Lighting Off
		ZWrite Off
		ZTest [unity_GUIZTestMode]
		Blend SrcAlpha OneMinusSrcAlpha
		ColorMask [_ColorMask]

		Pass
		{
			HLSLPROGRAM

			#pragma vertex vert
			#pragma fragment frag

			#pragma multi_compile_local _ UNITY_UI_ALPHACLIP

			#include "UnityCG.cginc"

			struct Attributes
			{
				float4 position : POSITION;
				float2 uv : TEXCOORD0;
				float4 color : COLOR;
			};

			struct Varyings
			{
				float4 position : SV_POSITION;
				float2 uv : TEXCOORD0;
				float4 color : COLOR;
				float2 localPosition : TEXCOORD1;
			};

			sampler2D _MainTex;
			float4 _MainTex_ST;
			float4 _Color;

			float _CircleRadius;
			float _CircleSoftness;

			Varyings vert(Attributes input)
			{
				Varyings output;

				output.position = UnityObjectToClipPos(input.position);
				output.uv = TRANSFORM_TEX(input.uv, _MainTex);
				output.color = input.color * _Color;

				output.localPosition = input.position.xy;

				return output;
			}

			float4 frag(Varyings input) : SV_Target
			{
				float2 uv = input.uv;

				float2 center = float2(0.5, 0.5);
				float2 position = uv - center;

				// Correct circle aspect ratio
				float2 ddxPos = ddx(position);
				float2 ddyPos = ddy(position);

				float width = length(ddxPos);
				float height = length(ddyPos);

				float aspect = height / max(width, 0.00001);
				position.x *= aspect;

				float distanceFromCenter = length(position);

				// Inside radius = transparent
				// Outside radius = original alpha
				//
				// radius - softness : transparent
				// radius             : fully visible
				float alphaMask = smoothstep(
				_CircleRadius - _CircleSoftness,
				_CircleRadius,
				distanceFromCenter
				);

				float4 color = tex2D(_MainTex, uv) * input.color;

				// Preserve original color outside the circle
				color.a *= alphaMask;

				#ifdef UNITY_UI_ALPHACLIP
					clip(color.a - 0.001);
				#endif

				return color;
			}

			ENDHLSL
		}
	}
}