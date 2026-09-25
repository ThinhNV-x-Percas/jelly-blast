// Reconstruction (see SpecialFluidCommon.cginc). The bee blob is textured in body space: the body
// frame follows the blob's centre (_Position) and accumulated spin (_Rotation.y, radians), both set by
// RotatingSpecialFluid. bee tex.png packs R = body profile, G = stripe mask, B = wing mask;
// the eyes decal (_EyesTex) sits at the body centre.
Shader "Custom/Bee" {
	Properties {
		_RawFieldTex ("Raw Field Tex", 2DArray) = "" {}
		_FluidTex ("Fluid Texture", 2D) = "white" {}
		_EmissionTex ("Emission Texture", 2D) = "black" {}
		_DetailTex ("Detail Tex", 2D) = "white" {}
		_DetailTexScale ("Detail Tex Scale", Float) = 1
		_DetailTexMag ("Detail Tex Magnitude", Float) = 1
		_DetailTexProfileMag ("Detail Tex Profile Magnitude", Float) = 1
		_EyesTex ("Eyes Texture", 2D) = "white" {}
		_EyesScale ("Eyes Scale", Float) = 1
		_Color1 ("Color1", Color) = (1,1,1,1)
		_Color2 ("Color2", Color) = (1,1,1,1)
		_WingColor ("Wing Color", Color) = (1,1,1,1)
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

			sampler2D _DetailTex;
			sampler2D _EyesTex;
			float _DetailTexScale;
			float _DetailTexMag;
			float _DetailTexProfileMag;
			float _EyesScale;
			float4 _Color1;
			float4 _Color2;
			float4 _WingColor;
			float4 _Position;
			float4 _Rotation;

			float4 frag(sf_v2f i) : SV_Target
			{
				SFSurface s = SFSample(i);

				float2 local = SFToLocal(i.worldPos.xy - _Position.xy, _Rotation.y);
				float2 detailUV = local * _DetailTexScale * 0.5 + 0.5;
				float4 detail = tex2D(_DetailTex, saturate(detailUV));

				float3 albedo = lerp(_Color1.rgb, _Color2.rgb, detail.g);
				// Profile channel darkens the body towards its outline for a rounder read.
				albedo *= lerp(1.0, detail.r, saturate(_DetailTexProfileMag * 0.1));
				albedo = lerp(albedo, _WingColor.rgb, detail.b * _WingColor.a);

				float3 col = SFShade(s, albedo);

				float4 eyes = SFDecal(_EyesTex, local, 1.0 / max(_EyesScale, 0.01));
				col = lerp(col, eyes.rgb, eyes.a);

				col = SFApplyEmission(col, s.screenUV);
				return float4(col, SFAlpha(s));
			}
			ENDHLSL
		}
	}
}
