Shader "Custom/Water" {
	Properties {
		_RawFieldTex ("Raw Field Tex", 2DArray) = "" {}
		_FluidTex ("Fluid Texture", 2D) = "white" {}
		_ReflectAmount ("Reflect Amount", Range(0, 1)) = 1
		_Shininess ("Shininess", Float) = 0.3
		_SpecularIntensity ("Specular Intensity", Range(0, 1)) = 1
		_Tint ("Tint (overall)", Vector) = (1,1,1,1)
		_BubbleColor ("Bubble Colour", Vector) = (1,1,1,0.9)
		_BackColor ("Liquid Colour", Vector) = (0.96,0.88,0.67,1)
		_Density ("Bubbles per tile", Float) = 10
		_BubbleSize ("Bubble Radius", Float) = 0.03
		_Softness ("Edge Softness", Range(0, 1)) = 0.5
		_Speed ("Rise Speed", Float) = 0.25
		_NoiseTex ("Noise Texture", 2D) = "white" {}
		_Color ("Color", Vector) = (1,1,1,0.9)
		_SizeNear ("Bubble Size (near)", Float) = 0.05
		_SizeFar ("Bubble Size (far)", Float) = 0.02
		_SpeedNear ("Rise Speed (near)", Float) = 1.2
		_SpeedFar ("Rise Speed (far)", Float) = 0.4
		_Accel ("Acceleration factor", Range(0, 3)) = 1.3
		_WiggleAmp ("Wiggle amplitude", Range(0, 0.35)) = 0.07
		_WiggleFreq ("Wiggle frequency", Range(1, 10)) = 4
		_RefractDist ("Refract Dist", Float) = 0.3
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