// Power-up blob shader (powerup 0/1/2.mat). Rebuilt on SpecialFluidCommon.cginc.
// The power-up art (_DetailTex) is a full-colour image laid over the blob's bounding box: SpecialFluid.cs
// feeds that box every frame as _ViewportPos (centre) / _ViewportSize (extent, viewport units), and
// PowerUp.RotateBlob spins it through _Rotation (turns) when power-ups merge. The previous
// reconstruction sampled the art in screen space and only kept its red channel, so the pattern slid
// under a moving power-up and the white-tinted power-ups (1 and 2) rendered as flat white.
Shader "Custom/SpecialFluid"
{
    Properties
    {
        _RawFieldTex ("Raw Field", 2DArray) = "" {}
        _FluidTex ("Merged Fluid", 2D) = "black" {}
        _EmissionTex ("Emission Texture", 2D) = "black" {}
        _DetailTex ("Detail", 2D) = "white" {}
        [MainColor] _Color ("Tint", Color) = (1,1,1,1)
        _DetailTexScale ("Detail Scale", Float) = 1
        _AlphaThreshold ("Alpha Threshold", Range(0,1)) = 0.1
        _Alpha ("Alpha", Range(0,1)) = 1
        _ReflectAmount ("Reflection", Range(0,1)) = 0.75
        _Shininess ("Shininess", Float) = 90
        _SpecularIntensity ("Specular Intensity", Range(0,1)) = 1
        _LightColor ("Light Color", Color) = (1,1,1,1)
        _AmbientColor ("Ambient Color", Color) = (1,1,1,1)
        _FlipDY ("Flip DY", Float) = 1
    }

    SubShader
    {
        Tags { "Queue"="Transparent+10" "RenderType"="Transparent" "IgnoreProjector"="True" }
        LOD 200
        Cull Off
        ZWrite Off
        ZTest LEqual
        Blend SrcAlpha OneMinusSrcAlpha

        Pass
        {
            HLSLPROGRAM
            #pragma target 3.5
            #pragma vertex SFVert
            #pragma fragment frag
            #include "SpecialFluidCommon.cginc"

            sampler2D _DetailTex;
            float4 _Color;
            float _DetailTexScale;
            float4 _ViewportPos;
            float4 _ViewportSize;
            float _Rotation;

            float4 frag(sf_v2f i) : SV_Target
            {
                SFSurface s = SFSample(i);

                // Square box around the blob centre, in screen-aspect-corrected viewport units.
                float aspect = _ScreenParams.x / _ScreenParams.y;
                float2 offset = (s.screenUV - _ViewportPos.xy) * float2(aspect, 1.0);
                float boxSize = max(max(_ViewportSize.x * aspect, _ViewportSize.y), 1e-4);
                float2 local = SFToLocal(offset, _Rotation * 6.2831853);
                float2 detailUV = local / (boxSize * max(_DetailTexScale, 1e-3)) + 0.5;
                float3 detail = tex2D(_DetailTex, detailUV).rgb;

                float3 col = SFShade(s, _Color.rgb * detail);
                col = SFApplyEmission(col, s.screenUV);
                return float4(col, SFAlpha(s));
            }
            ENDHLSL
        }
    }
}
