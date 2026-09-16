Shader "Custom/Octopus" {
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
		_Color ("Color", Vector) = (1,1,1,1)
		_ReflectAmount ("Reflect Amount", Range(0, 1)) = 1
		_LightColor ("Light Color", Vector) = (1,1,1,1)
		_AmbientColor ("Ambient Color", Vector) = (1,1,1,1)
		_Shininess ("Shininess", Float) = 1
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_AlphaThreshold ("Alpha Threshold", Float) = 1
		_FlipDY ("Flip DY", Float) = 1
	}
	//DummyShaderTextExporter
	SubShader{
		Tags { "RenderType"="Opaque" }
		LOD 200

		Pass
		{
			HLSLPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			float4x4 unity_ObjectToWorld;
			float4x4 unity_MatrixVP;

			struct Vertex_Stage_Input
			{
				float4 pos : POSITION;
			};

			struct Vertex_Stage_Output
			{
				float4 pos : SV_POSITION;
			};

			Vertex_Stage_Output vert(Vertex_Stage_Input input)
			{
				Vertex_Stage_Output output;
				output.pos = mul(unity_MatrixVP, mul(unity_ObjectToWorld, input.pos));
				return output;
			}

			float4 _Color;

			float4 frag(Vertex_Stage_Output input) : SV_TARGET
			{
				return _Color; // RGBA
			}

			ENDHLSL
		}
	}
}