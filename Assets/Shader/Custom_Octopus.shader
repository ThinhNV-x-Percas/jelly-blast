// Reconstruction (see SpecialFluidCommon.cginc). Octopus blob: _Color body, a rounder head region around
// _HeadPosition (the head-particle midpoint set by Octopus.cs, radius from _BulgeScale) carrying the eyes
// decal, and soft sucker dots (_SuckerTex tiled _SuckerScale times per world unit) on the tentacles.
Shader "Custom/Octopus" {
	Properties {
		_RawFieldTex ("Raw Field Tex", 2DArray) = "" {}
		_FluidTex ("Fluid Texture", 2D) = "white" {}
		_SuckerTex ("Sucker Texture", 2D) = "white" {}
		_EmissionTex ("Emission Texture", 2D) = "black" {}
		_EyesTex ("Eyes Texture", 2D) = "white" {}
		_EyesScale ("Eyes Scale", Float) = 1
		_BulgeScale ("Bulge Scale", Float) = 1
		_Color ("Color", Color) = (1,1,1,1)
		_SuckerColor ("Color", Color) = (1,1,1,1)
		_SuckerScale ("Sucker Scale", Float) = 1
		_ReflectAmount ("Reflect Amount", Range(0, 1)) = 1
		_LightColor ("Light Color", Color) = (1,1,1,1)
		_AmbientColor ("Ambient Color", Color) = (1,1,1,1)
		_Shininess ("Shininess", Float) = 1
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_AlphaThreshold ("Alpha Threshold", Float) = 1
		_FlipDY ("Flip DY", Float) = 1
		_Alpha ("Alpha", Range(0, 1)) = 1
	}

	SubShader {
		Tags { "Queue"="Transparent+2" "RenderType"="Transparent" "IgnoreProjector"="True" }
		LOD 200
		Cull Off
		ZWrite Off
		Blend SrcAlpha OneMinusSrcAlpha

		Pass {
			HLSLPROGRAM
			#pragma target 3.5
			#pragma vertex SFVert
			#pragma fragment frag
			#include "SpecialFluidCommon.cginc"

			sampler2D _SuckerTex;
			sampler2D _EyesTex;
			float _EyesScale;
			float _BulgeScale;
			float _SuckerScale;
			float4 _Color;
			float4 _SuckerColor;
			float4 _HeadPosition;

			float4 frag(sf_v2f i) : SV_Target
			{
				SFSurface s = SFSample(i);

				float2 toHead = i.worldPos.xy - _HeadPosition.xy;
				float headRadius = 0.12 * max(_BulgeScale, 0.01);
				float head = 1.0 - smoothstep(headRadius * 0.8, headRadius * 1.3, length(toHead));

				float3 albedo = _Color.rgb * (1.0 + head * 0.08);
				float sucker = tex2D(_SuckerTex, i.worldPos.xy * _SuckerScale).a;
				albedo = lerp(albedo, _SuckerColor.rgb, sucker * (1.0 - head) * 0.85);

				float3 col = SFShade(s, albedo);

				float4 eyes = SFDecal(_EyesTex, toHead, 1.0 / max(_EyesScale, 0.01));
				col = lerp(col, eyes.rgb, eyes.a);

				col = SFApplyEmission(col, s.screenUV);
				return float4(col, SFAlpha(s));
			}
			ENDHLSL
		}
	}
}
