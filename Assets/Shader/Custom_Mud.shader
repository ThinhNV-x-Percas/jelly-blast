// Reconstruction (see SpecialFluidCommon.cginc). Used by mud.mat and snow.mat: a flat _Color broken up
// by world-space noise (_NoiseTex, _NoiseScale, _NoiseMag), lit like the colour fluid.
Shader "Custom/Mud" {
	Properties {
		_RawFieldTex ("Raw Field Tex", 2DArray) = "" {}
		_FluidTex ("Fluid Texture", 2D) = "white" {}
		_EmissionTex ("Emission Texture", 2D) = "black" {}
		_Color ("Color", Color) = (1,1,1,1)
		_NoiseTex ("Noise Texture", 2D) = "white" {}
		_ReflectAmount ("Reflect Amount", Range(0, 1)) = 1
		_LightColor ("Light Color", Color) = (1,1,1,1)
		_AmbientColor ("Ambient Color", Color) = (1,1,1,1)
		_Shininess ("Shininess", Float) = 1
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_NoiseScale ("Noise Scale", Float) = 0.75
		_NoiseMag ("Noise Mag", Float) = 1
		_AlphaThreshold ("Alpha Threshold", Range(0, 1)) = 1
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

			sampler2D _NoiseTex;
			float4 _Color;
			float _NoiseScale;
			float _NoiseMag;

			float4 frag(sf_v2f i) : SV_Target
			{
				SFSurface s = SFSample(i);

				float2 noiseUV = (SFIsIcon() ? i.uv : i.worldPos.xy) * _NoiseScale;
				float noise = tex2D(_NoiseTex, noiseUV).r;
				float3 albedo = _Color.rgb * (1.0 + (noise - 0.5) * 0.35 * _NoiseMag);

				float3 col = SFShade(s, albedo);
				col = SFApplyEmission(col, s.screenUV);
				return float4(col, SFAlpha(s));
			}
			ENDHLSL
		}
	}
}
