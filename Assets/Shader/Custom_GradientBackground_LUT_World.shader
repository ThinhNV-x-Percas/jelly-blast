// Reconstructed from the AssetRipper dummy export.
// The runtime (Level.UpdateBackgroundColors) provides:
//   Shader.SetGlobalTexture("_GradientTex",   generated 256x1 HSB-lerp LUT)
//   Shader.SetGlobalFloat("_GradientStartY",  world-space Y where the gradient starts)
//   Shader.SetGlobalFloat("_GradientRangeInv", 1 / (gradientEndY - gradientStartY))
// The fragment maps the quad's world-space Y through that range and samples the LUT.
Shader "Custom/GradientBackground_LUT_World" {
	// _GradientTex / _GradientStartY / _GradientRangeInv are deliberately NOT properties:
	// a declared property is serialized per material and SHADOWS Shader.SetGlobal*, which
	// made the unset material texture (white) win over the LUT and paint the sky white.
	Properties {
		_GradientInvRange ("Gradient Inv Range (edit-mode fallback)", Float) = 1
		_BackgroundBottomColor ("Bottom Color (fallback)", Color) = (0,0,0,1)
		_BackgroundTopColor ("Top Color (fallback)", Color) = (1,1,1,1)
	}
	SubShader{
		Tags { "RenderType" = "Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			// Globals pushed from C# (Level.UpdateBackgroundColors).
			sampler2D _GradientTex;
			float _GradientStartY;
			float _GradientRangeInv;

			// Material fallbacks (also used in edit mode before Level.Init runs).
			float _GradientInvRange;
			float4 _BackgroundBottomColor;
			float4 _BackgroundTopColor;

			struct appdata
			{
				float4 pos : POSITION;
			};

			struct v2f
			{
				float4 pos : SV_POSITION;
				float worldY : TEXCOORD0;
			};

			v2f vert(appdata input)
			{
				v2f output;
				output.pos = UnityObjectToClipPos(input.pos);
				float3 worldPos = mul(unity_ObjectToWorld, input.pos).xyz;
				output.worldY = worldPos.y;
				return output;
			}

			float4 frag(v2f input) : SV_TARGET
			{
				// Prefer the runtime global range; fall back to the material value in edit mode.
				float rangeInv = _GradientRangeInv;
				if (rangeInv == 0.0)
				{
					rangeInv = _GradientInvRange;
				}

				float t = saturate((input.worldY - _GradientStartY) * rangeInv);

				// The LUT is generated at runtime; before it is set the sampler returns
				// white, so also blend the material's fallback colors for edit-mode preview.
				float4 lut = tex2D(_GradientTex, float2(t, 0.5));
				float4 fallback = lerp(_BackgroundBottomColor, _BackgroundTopColor, t);
				bool lutValid = any(lut.rgb > 0.0) || lut.a > 0.0;
				return lutValid ? lut : fallback;
			}
			ENDHLSL
		}
	}
}