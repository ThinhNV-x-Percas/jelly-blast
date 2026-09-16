using UnityEngine;

// Not recovered by the IL2Cpp rip: SDFCollider references this type, but no method bodies for
// it were exported (its logic lives in the SDFTextureGeneratorCompute compute shader, whose
// kernels were never decompiled). This stub only restores the surface SDFCollider.cs compiles
// against; SDF generation itself is not implemented.
public class SDFTextureGenerator
{
	public enum DownSampling
	{
		_1,
		_2,
		_4
	}

	public enum Precision
	{
		_16,
		_32
	}

	public RenderTexture SdfTexture { get; private set; }

	public void Update(RenderTexture output, float sourceValueThreshold, DownSampling downSampling, Precision precision)
	{
		SdfTexture = output;
	}

	public void Release()
	{
		SdfTexture = null;
	}
}
