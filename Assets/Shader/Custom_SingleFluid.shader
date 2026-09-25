// Reconstruction (see SpecialFluidCommon.cginc). fluid_single.mat is UIIconGenerator's colorMaterial:
// a single blob of colour-fluid drawn in _Color for the goal icons, lit like Custom/Fluid. The icon
// path samples _FluidTexArray (UIIconGenerator sets _Seed = -1); _Alpha, which the generator sets to
// 0.3, is not used as opacity so the icon stays solid.
Shader "Custom/SingleFluid" {
	Properties {
		_FluidTex ("Fluid Texture", 2D) = "white" {}
		_Color ("Color", Color) = (1,1,1,1)
		_EmissionTex ("Emission Texture", 2D) = "black" {}
		_ReflectAmount ("Reflect Amount", Range(0, 1)) = 1
		_AOStrength ("AOStrength", Range(0, 1)) = 1
		_AlphaThreshold ("Alpha Threshold", Range(0, 1)) = 1
		_LightColor ("Light Color", Color) = (1,1,1,1)
		_AmbientColor ("Ambient Color", Color) = (1,1,1,1)
		_Shininess ("Shininess", Float) = 1
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_FlipDY ("Flip DY", Float) = 1
	}

	SubShader {
		Tags { "Queue"="Transparent" "RenderType"="Transparent" "IgnoreProjector"="True" }
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

			float4 _Color;
			float _AOStrength;

			float4 frag(sf_v2f i) : SV_Target
			{
				SFSurface s = SFSample(i);
				float3 col = SFShade(s, _Color.rgb);
				// Soft darkening towards the silhouette, standing in for Custom/Fluid's reflection AO.
				col *= 1.0 - _AOStrength * 0.3 * s.rim;
				col = SFApplyEmission(col, s.screenUV);
				return float4(col, s.coverage);
			}
			ENDHLSL
		}
	}
}
