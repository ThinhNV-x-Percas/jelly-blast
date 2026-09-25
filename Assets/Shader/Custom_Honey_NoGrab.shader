// Reconstruction (see SpecialFluidCommon.cginc). Honey coating drawn over honey-coated jelly: a
// translucent amber layer (_Color.a) with light noise, a denser rim (_RimPower) and a sharp highlight.
// "NoGrab": no refraction pass, the jelly underneath simply shows through the alpha.
Shader "Custom/Honey_NoGrab" {
	Properties {
		_RawFieldTex ("Raw Field Tex", 2DArray) = "" {}
		_EmissionTex ("Emission Texture", 2D) = "black" {}
		_FluidTex ("Fluid Texture", 2D) = "white" {}
		_ReflectAmount ("Reflect Amount", Range(0, 1)) = 1
		_Shininess ("Shininess", Float) = 0.3
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_LightColor ("Light Color", Color) = (1,1,1,1)
		_AmbientColor ("Ambient Color", Color) = (1,1,1,1)
		_NoiseTex ("Noise Texture", 2D) = "white" {}
		_NoiseScale ("Noise Scale", Float) = 0.75
		_NoiseMag ("Noise Mag", Float) = 1
		_Color ("Color", Color) = (1,1,1,0.9)
		_AlphaThreshold ("Alpha Threshold", Range(0, 1)) = 1
		_FlipDY ("Flip DY", Float) = 1
		_RimPower ("Rim Power", Float) = 1
		_Alpha ("Alpha", Range(0, 1)) = 1
	}

	SubShader {
		// After the colour fluid (Transparent+1) so the coating sits on top of the jelly it covers.
		Tags { "Queue"="Transparent+3" "RenderType"="Transparent" "IgnoreProjector"="True" }
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
			float _RimPower;

			float4 frag(sf_v2f i) : SV_Target
			{
				SFSurface s = SFSample(i);

				float2 noiseUV = (SFIsIcon() ? i.uv : i.worldPos.xy) * _NoiseScale;
				float noise = tex2D(_NoiseTex, noiseUV + _Time.x * 0.05).r;
				float3 albedo = _Color.rgb * (1.0 + (noise - 0.5) * _NoiseMag);

				float3 col = SFShade(s, albedo);
				col = SFApplyEmission(col, s.screenUV);

				// Thicker, more saturated honey towards the edge of the coating.
				float edgeDensity = pow(saturate(1.0 - s.density), max(_RimPower, 0.01));
				float opacity = saturate(_Color.a + edgeDensity * (1.0 - _Color.a));
				return float4(col, SFAlpha(s) * opacity);
			}
			ENDHLSL
		}
	}
}
