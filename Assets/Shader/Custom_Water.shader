// Reconstruction: the exported shader was an AssetRipper dummy that returned a flat _Color, so the
// water's bounding quad rendered as a solid white rectangle. Same field sampling as Custom/SpecialFluid
// (FluidCompute packs four fluid types per raw-field layer, _FluidType comes from the property block),
// shaded as clear water: background refracted through a GrabPass, tinted, with specular, rim and
// optional rising bubbles. Property names are kept from the export so water.mat still binds.
// The original Metal program can be extracted from the iOS bundle to verify (memory note original-metal-shaders).
Shader "Custom/Water" {
	Properties {
		_RawFieldTex ("Raw Field Tex", 2DArray) = "" {}
		_FluidTex ("Fluid Texture", 2D) = "white" {}
		_ReflectAmount ("Reflect Amount", Range(0, 1)) = 1
		_Shininess ("Shininess", Float) = 0.3
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_Tint ("Tint (overall)", Color) = (1,1,1,1)
		_BubbleColor ("Bubble Colour", Color) = (1,1,1,0.9)
		_BackColor ("Liquid Colour", Color) = (0.96,0.88,0.67,1)
		_Density ("Bubbles per tile", Float) = 10
		_BubbleSize ("Bubble Radius", Float) = 0.03
		_Softness ("Edge Softness", Range(0, 1)) = 0.5
		_Speed ("Rise Speed", Float) = 0.25
		_NoiseTex ("Noise Texture", 2D) = "white" {}
		_Color ("Color", Color) = (1,1,1,0.9)
		_SizeNear ("Bubble Size (near)", Float) = 0.05
		_SizeFar ("Bubble Size (far)", Float) = 0.02
		_SpeedNear ("Rise Speed (near)", Float) = 1.2
		_SpeedFar ("Rise Speed (far)", Float) = 0.4
		_Accel ("Acceleration factor", Range(0, 3)) = 1.3
		_WiggleAmp ("Wiggle amplitude", Range(0, 0.35)) = 0.07
		_WiggleFreq ("Wiggle frequency", Range(1, 10)) = 4
		_RefractDist ("Refract Dist", Float) = 0.3
		_WaterColor ("Water Colour", Color) = (0.45, 0.78, 1, 0.35)
		_AlphaThreshold ("Alpha Threshold", Range(0, 1)) = 0.1
	}

	SubShader {
		// Drawn after the colour fluid (Transparent+1) so jelly behind the water is refracted by it.
		Tags { "Queue"="Transparent+20" "RenderType"="Transparent" "IgnoreProjector"="True" }
		LOD 200
		Cull Off
		ZWrite Off
		ZTest LEqual

		GrabPass { "_WaterGrabTex" }

		Pass {
			Blend SrcAlpha OneMinusSrcAlpha

			HLSLPROGRAM
			#pragma target 3.5
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			struct appdata {
				float4 vertex : POSITION;
			};

			struct v2f {
				float4 vertex : SV_POSITION;
				float4 screenPos : TEXCOORD0;
				float4 grabPos : TEXCOORD1;
				float3 worldPos : TEXCOORD2;
			};

			UNITY_DECLARE_TEX2DARRAY(_RawFieldTex);
			float4 _RawFieldTex_TexelSize;
			sampler2D _WaterGrabTex;
			sampler2D _NoiseTex;

			int _FluidType;
			float _Alpha;
			float _AlphaThreshold;
			float _Softness;
			float _RefractDist;
			float _ReflectAmount;
			float _Shininess;
			float _SpecularIntensity;
			float4 _Tint;
			float4 _Color;
			float4 _WaterColor;
			float4 _BubbleColor;
			float _Density;
			float _SizeNear;
			float _SizeFar;
			float _SpeedNear;
			float _SpeedFar;
			float _Accel;
			float _WiggleAmp;
			float _WiggleFreq;

			v2f vert(appdata input)
			{
				v2f output;
				output.vertex = UnityObjectToClipPos(input.vertex);
				output.screenPos = ComputeScreenPos(output.vertex);
				output.grabPos = ComputeGrabScreenPos(output.vertex);
				output.worldPos = mul(unity_ObjectToWorld, input.vertex).xyz;
				return output;
			}

			float SampleDensity(float2 uv, float layer, int channel)
			{
				float4 raw = UNITY_SAMPLE_TEX2DARRAY_LOD(_RawFieldTex, float3(uv, layer), 0.0);
				return raw[channel];
			}

			float Hash(float2 p)
			{
				return frac(sin(dot(p, float2(127.1, 311.7))) * 43758.5453);
			}

			// One layer of rising bubbles in world space; returns bubble coverage 0..1.
			float Bubbles(float2 p, float size, float speed, float seed)
			{
				float density = max(_Density, 0.001);
				float2 cellP = p * density;
				float t = _Time.y * speed * density;
				cellP.y -= t;
				float2 cell = floor(cellP);
				float2 local = frac(cellP) - 0.5;
				float rnd = Hash(cell + seed);
				if (rnd > 0.35)
					return 0.0;

				float wiggle = sin((_Time.y + rnd * 10.0) * _WiggleFreq) * _WiggleAmp;
				float2 center = float2((Hash(cell + seed + 3.1) - 0.5) * 0.6 + wiggle, (rnd - 0.175) * 1.5);
				float radius = size * density * lerp(0.6, 1.0, Hash(cell + seed + 7.3));
				float d = length(local - center);
				return 1.0 - smoothstep(radius * 0.7, radius, d);
			}

			float4 frag(v2f input) : SV_Target
			{
				float2 uv = input.screenPos.xy / input.screenPos.w;

				int layer = clamp(_FluidType / 4, 0, 7);
				int channel = clamp(_FluidType - layer * 4, 0, 3);
				float density = SampleDensity(uv, (float)layer, channel);
				if (density <= 0.001)
					discard;

				float edge = max(fwidth(density) * lerp(1.0, 3.0, _Softness), 0.004);
				float coverage = saturate(smoothstep(_AlphaThreshold - edge, _AlphaThreshold + edge, density));
				if (coverage <= 0.001)
					discard;

				// Surface normal from the field gradient: flat inside, curving at the edges.
				float2 texel = max(_RawFieldTex_TexelSize.xy, float2(1e-5, 1e-5));
				float dx = SampleDensity(uv + float2(texel.x, 0.0), (float)layer, channel)
				         - SampleDensity(uv - float2(texel.x, 0.0), (float)layer, channel);
				float dy = SampleDensity(uv + float2(0.0, texel.y), (float)layer, channel)
				         - SampleDensity(uv - float2(0.0, texel.y), (float)layer, channel);
				float rim = pow(saturate(1.0 - density), 4.0);
				float3 normal = normalize(float3(-dx, -dy, 0.25 + (1.0 - rim)));

				float2 grabUV = input.grabPos.xy / input.grabPos.w;
				grabUV += normal.xy * _RefractDist;
				float3 background = tex2D(_WaterGrabTex, grabUV).rgb;

				float3 water = lerp(background, _WaterColor.rgb, _WaterColor.a);
				water *= _Color.rgb;
				water = lerp(water, water * _Tint.rgb, _Tint.a);

				float3 lightDir = normalize(float3(-0.4, 0.6, 1.0));
				float3 halfDir = normalize(lightDir + float3(0.0, 0.0, 1.0));
				float spec = _SpecularIntensity * pow(saturate(dot(normal, halfDir)), max(1.0, _Shininess));
				water += spec;
				water += rim * lerp(0.15, 0.35, _ReflectAmount);

				float bubbles = Bubbles(input.worldPos.xy, _SizeNear, _SpeedNear * _Accel, 0.0) * 1.0
				              + Bubbles(input.worldPos.xy * 1.7, _SizeFar, _SpeedFar * _Accel, 19.0) * 0.6;
				water = lerp(water, _BubbleColor.rgb, saturate(bubbles) * _BubbleColor.a);

				float alpha = coverage * (_Alpha > 0.0 ? _Alpha : 1.0);
				return float4(water, alpha);
			}
			ENDHLSL
		}
	}
}
