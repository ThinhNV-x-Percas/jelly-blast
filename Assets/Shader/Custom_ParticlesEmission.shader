Shader "Custom/ParticlesEmission" {
Properties {
}
SubShader {
Tags { "RenderType" = "Opaque" }
LOD 200
Pass
{
Blend One One
ZWrite Off
ZTest Always
Cull Off
HLSLPROGRAM
#pragma vertex vert
#pragma fragment frag
#pragma multi_compile_instancing
#pragma instancing_options procedural:setup
#include "UnityCG.cginc"

struct VertexIn
{
    float4 pos : POSITION;
    float2 uv : TEXCOORD0;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

struct VertexOut
{
    float4 pos : SV_POSITION;
    float2 uv : TEXCOORD0;
    UNITY_VERTEX_INPUT_INSTANCE_ID
};

float4 _EmissionColors[1024];

VertexOut vert(VertexIn input)
{
    VertexOut output;
    UNITY_SETUP_INSTANCE_ID(input);
    UNITY_TRANSFER_INSTANCE_ID(input, output);
    output.pos = UnityObjectToClipPos(input.pos);
    output.uv = input.uv;
    return output;
}

float4 frag(VertexOut input) : SV_TARGET
{
    UNITY_SETUP_INSTANCE_ID(input);
    uint id = min(unity_InstanceID, 1023u);
    float4 emission = _EmissionColors[id];
    if (emission.a <= 0.0 && emission.r + emission.g + emission.b <= 0.0)
        return float4(0, 0, 0, 0);
    float dd = length((input.uv - 0.5) * 2.0);
    float cover = 1.0 - smoothstep(0.0, 1.0, dd);
    return float4(emission.rgb * cover, emission.a * cover);
}
ENDHLSL
}
}
}