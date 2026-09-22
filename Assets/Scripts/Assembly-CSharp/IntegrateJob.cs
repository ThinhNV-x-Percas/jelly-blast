[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000079")]
public struct IntegrateJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Cpp2ILInjected.Token(Token = "0x4000228")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

	[global::Cpp2ILInjected.Token(Token = "0x4000229")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> velocities;

	[global::Cpp2ILInjected.Token(Token = "0x400022A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<bool> isStatic;

	[global::Cpp2ILInjected.Token(Token = "0x400022B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float dt;

	[global::Cpp2ILInjected.Token(Token = "0x6000248")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFA1B4", Offset = "0xFFA1B4", Length = "0x40")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = this.isStatic;\n\tv5 = *([v0 @ X9_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) == 0;\n\tif (v5) goto L_0006;\n\treturn;\nL_0006:\n\tv6 = this.velocities;\n\tv7 = i << 3;\n\tv8 = this.positions;\n\tv12 = *([v6 @ X9_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]) * v13;\n\tv14 = *([v8 @ X10_v1 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]) + v12;\n\t*([v8 @ X10_v1 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]) = v14;\n\t*([v6 @ X9_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]) = *([v6 @ X9_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]);\n\treturn;\n// 5 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Execute(int i)
	{
		if (!isStatic[i])
		{
			positions[i] += velocities[i] * dt;
		}
	}
}
