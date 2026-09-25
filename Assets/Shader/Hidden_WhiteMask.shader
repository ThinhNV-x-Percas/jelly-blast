// Replacement shader used by SDFCollider to capture every collider mesh on the collision layers as a
// white mask, which is then turned into the fluid's signed distance field. Rewritten from the AssetRipper
// dummy (which already returned white) to not cull back faces: floor meshes built from colliders can face
// either way, and a culled floor would silently vanish from the SDF.
Shader "Hidden/WhiteMask" {
	SubShader {
		Tags { "RenderType"="Opaque" }
		Cull Off
		ZWrite Off
		ZTest Always

		Pass {
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag
			#include "UnityCG.cginc"

			float4 vert(float4 vertex : POSITION) : SV_POSITION
			{
				return UnityObjectToClipPos(vertex);
			}

			float4 frag() : SV_Target
			{
				return float4(1.0, 1.0, 1.0, 1.0);
			}
			ENDHLSL
		}
	}
}
