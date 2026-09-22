[global::Unity.Burst.BurstCompile(global::Unity.Burst.FloatPrecision.Low, global::Unity.Burst.FloatMode.Fast)]
[global::Cpp2ILInjected.Token(Token = "0x2000084")]
internal struct OctUF_WriteRegionJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.NativeDisableParallelForRestriction]
	[global::Cpp2ILInjected.Token(Token = "0x4000264")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<int> parent;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000265")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<byte> componentHasHead;

	[global::Cpp2ILInjected.Token(Token = "0x4000266")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<bool> regionHasHead;

	[global::Cpp2ILInjected.Token(Token = "0x6000256")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB758", Offset = "0xFFB758", Length = "0x40")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\nL_000D:\n\tv7 = *([p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]) != v32;\n\tif (v7) goto L_000D;\n\tv37 = x << 2;\n\tv71 = p + v37;\n\tv69 = *([v71 @ X8_v4]);\n\tv44 = *([v71 @ X8_v4]) == *([p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]);\n\tif (v44) goto L_002B;\nL_001C:\n\t*([v71 @ X8_v4]) = v32;\n\tv68 = v69 << 2;\n\tv71 = p + v68;\n\tv69 = *([v71 @ X8_v4]);\n\tv50 = *([v71 @ X8_v4]) != v32;\n\tif (v50) goto L_001C;\nL_002B:\n\treturn v32;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private static int Find(int x, global::Unity.Collections.NativeArray<int> p)
	{
		int root = x;
		while (p[root] != root)
		{
			root = p[root];
		}
		while (p[x] != root)
		{
			int next = p[x];
			p[x] = root;
			x = next;
		}
		return root;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000257")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB798", Offset = "0xFFB798", Length = "0x44")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv17 = OctUF_WriteRegionJob::Find(i, this.parent);\n\tv18 = this.componentHasHead;\n\tv24 = *([v18 @ X8_v1 (Unity.Collections.NativeArray`1<System.Byte>)+v17 @ X0_v2 (System.Int32)]) == 0;\n\tv29 = ~v24;\n\tv31 = this.regionHasHead;\n\t*([v31 @ X9_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) = v29;\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Execute(int i)
	{
		int root = Find(i, parent);
		regionHasHead[i] = componentHasHead[root] != 0;
	}
}
