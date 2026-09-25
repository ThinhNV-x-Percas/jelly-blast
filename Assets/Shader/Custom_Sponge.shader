// Reconstruction (see SpecialFluidCommon.cginc). Sponge blob: _Color body with pores from two noise
// textures (_NoiseTex/_NoiseTex2, tiling from their material scale) shaded towards _HoleColor, pore edge
// sharpness from _Falloff, and the eyes decal (_EyesTex, size = its material scale in world units).
// Sponge.cs feeds the body frame: _SpongePosition = viewport position of the blob midpoint,
// _SpongeRotation.x = accumulated spin in radians. The export had no field inputs, so _RawFieldTex and
// _EmissionTex are declared here and bound in sponge.mat.
Shader "Custom/Sponge" {
	Properties {
		_RawFieldTex ("Raw Field Tex", 2DArray) = "" {}
		_EmissionTex ("Emission Texture", 2D) = "black" {}
		_FluidTex ("Fluid Texture", 2D) = "white" {}
		_Color ("Color", Color) = (1,1,1,1)
		_HoleColor ("Color", Color) = (1,1,1,1)
		_NoiseTex ("Noise Texture", 2D) = "white" {}
		_NoiseTex2 ("Noise Texture 2", 2D) = "white" {}
		_ReflectAmount ("Reflect Amount", Float) = 1
		_LightColor ("Light Color", Color) = (1,1,1,1)
		_AmbientColor ("Ambient Color", Color) = (1,1,1,1)
		_Shininess ("Shininess", Float) = 1
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_EyesTex ("Eyes Texture", 2D) = "white" {}
		_Falloff ("Falloff", Float) = 3
		_AlphaThreshold ("Alpha Threshold", Range(0, 1)) = 0.2
		_FlipDY ("Flip DY", Float) = 1
		_Alpha ("Alpha", Range(0, 1)) = 1
		_SpongePosition ("Sponge Position (viewport)", Vector) = (0.5, 0.5, 0, 0)
		_SpongeRotation ("Sponge Rotation", Vector) = (0, 0, 0, 0)
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
			sampler2D _NoiseTex2;
			sampler2D _EyesTex;
			float4 _NoiseTex_ST;
			float4 _NoiseTex2_ST;
			float4 _EyesTex_ST;
			float4 _Color;
			float4 _HoleColor;
			float _Falloff;
			float4 _SpongePosition;
			float4 _SpongeRotation;

			float4 frag(sf_v2f i) : SV_Target
			{
				SFSurface s = SFSample(i);

				// Viewport -> world for the orthographic game camera.
				float2 centre = _WorldSpaceCameraPos.xy + (_SpongePosition.xy - 0.5) * 2.0 * unity_OrthoParams.xy;
				float2 local = SFToLocal(i.worldPos.xy - centre, _SpongeRotation.x);

				float n1 = tex2D(_NoiseTex, local / max(_NoiseTex_ST.xy, 1e-3)).r;
				float n2 = tex2D(_NoiseTex2, local / max(_NoiseTex2_ST.xy, 1e-3)).r;
				float pore = saturate((0.42 - n1 * 0.7 - n2 * 0.3) * max(_Falloff, 0.01) * 4.0 + 0.5);

				float3 albedo = lerp(_Color.rgb, _HoleColor.rgb, pore);
				float3 col = SFShade(s, albedo);
				col *= 1.0 - pore * 0.25;

				float4 eyes = SFDecal(_EyesTex, local, _EyesTex_ST.xy);
				col = lerp(col, eyes.rgb, eyes.a);

				col = SFApplyEmission(col, s.screenUV);
				return float4(col, SFAlpha(s));
			}
			ENDHLSL
		}
	}
}
