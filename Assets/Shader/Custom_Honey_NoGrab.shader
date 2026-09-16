Shader "Custom/Honey_NoGrab" {
	Properties {
		_RawFieldTex ("Raw Field Tex", 2DArray) = "" {}
		_EmissionTex ("Emission Texture", 2D) = "black" {}
		_FluidTex ("Fluid Texture", 2D) = "white" {}
		_ReflectAmount ("Reflect Amount", Range(0, 1)) = 1
		_Shininess ("Shininess", Float) = 0.3
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_LightColor ("Light Color", Vector) = (1,1,1,1)
		_AmbientColor ("Ambient Color", Vector) = (1,1,1,1)
		_NoiseTex ("Noise Texture", 2D) = "white" {}
		_NoiseScale ("Noise Scale", Float) = 0.75
		_NoiseMag ("Noise Mag", Float) = 1
		_Color ("Color", Vector) = (1,1,1,0.9)
		_AlphaThreshold ("Alpha Threshold", Range(0, 1)) = 1
		_FlipDY ("Flip DY", Float) = 1
		_RimPower ("Rim Power", Float) = 1
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