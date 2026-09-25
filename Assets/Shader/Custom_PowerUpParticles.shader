Shader "Custom/PowerUpParticles" {
Properties {
}
SubShader {
Tags { "RenderType" = "Opaque" }
LOD 200
Pass
{
Blend One OneMinusSrcColor
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

float _ParticleTypes[1024];
float _IsRounded[1024];
float _InnerRadii[1024];
int _Layer;

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
    int fluidType = (int)(_ParticleTypes[id] + 0.5);
    int layer = fluidType / 4;
    int channel = fluidType - layer * 4;
    if (layer != _Layer)
        return float4(0, 0, 0, 0);
    float dd = length((input.uv - 0.5) * 2.0);
    bool rounded = _IsRounded[id] > 0.0;
    float x = max(1.0 - dd, 0.0) * (rounded ? 0.5 : 0.4);
    float sq = 2.0 * x * x;
    float ease = x < 0.5 ? sq : 1.0 - 0.5 * (2.0 - 2.0 * x) * (2.0 - 2.0 * x);
    float falloff = rounded ? sq : ease * 3.0;
    float inner = smoothstep(0.0, 1.0, saturate((dd + 0.4 - _InnerRadii[id]) * 2.5));
    float cover = falloff * inner;
    float4 result = float4(0, 0, 0, 0);
    if (channel == 0) result.r = cover;
    else if (channel == 1) result.g = cover;
    else if (channel == 2) result.b = cover;
    else result.a = cover;
    return result;
}
ENDHLSL
}
}
}