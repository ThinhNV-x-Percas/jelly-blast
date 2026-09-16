Shader "Custom/Ice" {
	Properties {
		_ReflTex ("Reflection", 2D) = "white" {}
		_Color ("Tint & Alpha", Vector) = (1,1,1,1)
		_AmbientColor ("Ambient Color", Vector) = (0.2,0.2,0.2,1)
		_LightColor ("Key Light Color", Vector) = (1,1,1,1)
		_SpecColor ("Specular Color", Vector) = (1,1,1,1)
		_Shininess ("Specular Power (4-256)", Range(4, 256)) = 64
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
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
	Fallback "Diffuse"
}