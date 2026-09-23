using UnityEngine;

// The rip exported no bodies for this type (its work lived in the
// SDFTextureGeneratorCompute asset, which was never decompiled), and the stub that stood in
// simply handed the white mask back - so FluidPhysicsCoupler.SampleSDF read a coverage mask
// as if it were a distance field and the fluid fell straight through the level.
//
// Rebuilt on the CPU with an 8SSEDT signed distance transform. It runs once per level load.
// The stored value is the signed distance in texels divided by the texture height, because
// SampleSDF multiplies by (halfBounds.y * 2) - so the product is the distance in world units.
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

	private const float Far = 1e7f;

	public RenderTexture SdfTexture { get; private set; }

	public void Update(RenderTexture output, float sourceValueThreshold, DownSampling downSampling, Precision precision)
	{
		SdfTexture = output;

		if (output == null)
		{
			return;
		}

		int width = output.width;
		int height = output.height;

		RenderTexture previous = RenderTexture.active;
		RenderTexture.active = output;

		Texture2D readback = new Texture2D(width, height, TextureFormat.RGBAFloat, mipChain: false, linear: true);
		readback.ReadPixels(new Rect(0f, 0f, width, height), 0, 0);
		readback.Apply();
		RenderTexture.active = previous;

		Color[] pixels = readback.GetPixels();
		float[] signedDistance = BuildSignedDistance(pixels, width, height, sourceValueThreshold);

		float invHeight = 1f / height;
		for (int i = 0; i < pixels.Length; i++)
		{
			float v = signedDistance[i] * invHeight;
			pixels[i] = new Color(v, v, v, 1f);
		}

		readback.SetPixels(pixels);
		readback.Apply();
		Graphics.Blit(readback, output);
		Object.DestroyImmediate(readback);
	}

	public void Release()
	{
		SdfTexture = null;
	}

	// 8SSEDT: two sweeps per region, each pixel carrying the offset to its nearest
	// opposite-region pixel. Exact enough for collision and O(n) rather than O(n * radius).
	private static float[] BuildSignedDistance(Color[] pixels, int width, int height, float threshold)
	{
		int count = width * height;
		float[] insideX = new float[count];
		float[] insideY = new float[count];
		float[] outsideX = new float[count];
		float[] outsideY = new float[count];

		for (int i = 0; i < count; i++)
		{
			bool solid = pixels[i].r >= threshold || pixels[i].a >= threshold;

			// insideGrid is seeded on solid pixels, outsideGrid on free ones.
			insideX[i] = solid ? 0f : Far;
			insideY[i] = solid ? 0f : Far;
			outsideX[i] = solid ? Far : 0f;
			outsideY[i] = solid ? Far : 0f;
		}

		Sweep(insideX, insideY, width, height);
		Sweep(outsideX, outsideY, width, height);

		float[] result = new float[count];
		for (int i = 0; i < count; i++)
		{
			float distToSolid = Mathf.Sqrt(insideX[i] * insideX[i] + insideY[i] * insideY[i]);
			float distToFree = Mathf.Sqrt(outsideX[i] * outsideX[i] + outsideY[i] * outsideY[i]);
			result[i] = distToSolid - distToFree;
		}

		return result;
	}

	private static void Sweep(float[] dx, float[] dy, int width, int height)
	{
		for (int y = 0; y < height; y++)
		{
			for (int x = 0; x < width; x++)
			{
				Compare(dx, dy, width, height, x, y, -1, 0);
				Compare(dx, dy, width, height, x, y, 0, -1);
				Compare(dx, dy, width, height, x, y, -1, -1);
				Compare(dx, dy, width, height, x, y, 1, -1);
			}

			for (int x = width - 1; x >= 0; x--)
			{
				Compare(dx, dy, width, height, x, y, 1, 0);
			}
		}

		for (int y = height - 1; y >= 0; y--)
		{
			for (int x = width - 1; x >= 0; x--)
			{
				Compare(dx, dy, width, height, x, y, 1, 0);
				Compare(dx, dy, width, height, x, y, 0, 1);
				Compare(dx, dy, width, height, x, y, -1, 1);
				Compare(dx, dy, width, height, x, y, 1, 1);
			}

			for (int x = 0; x < width; x++)
			{
				Compare(dx, dy, width, height, x, y, -1, 0);
			}
		}
	}

	private static void Compare(float[] dx, float[] dy, int width, int height, int x, int y, int offsetX, int offsetY)
	{
		int nx = x + offsetX;
		int ny = y + offsetY;
		if (nx < 0 || ny < 0 || nx >= width || ny >= height)
		{
			return;
		}

		int here = y * width + x;
		int there = ny * width + nx;

		float candidateX = dx[there] + offsetX;
		float candidateY = dy[there] + offsetY;

		if (candidateX * candidateX + candidateY * candidateY < dx[here] * dx[here] + dy[here] * dy[here])
		{
			dx[here] = candidateX;
			dy[here] = candidateY;
		}
	}
}
