[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000078")]
public struct ApplyDeltaJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Cpp2ILInjected.Token(Token = "0x4000225")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> velocities;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000226")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Cpp2ILInjected.Token(Token = "0x4000227")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<bool> isStatic;

	[global::Cpp2ILInjected.Token(Token = "0x6000247")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFA180", Offset = "0xFFA180", Length = "0x34")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = this.isStatic;\n\tv5 = *([v0 @ X9_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) == 0;\n\tif (v5) goto L_0006;\n\treturn;\nL_0006:\n\tv6 = this.velocities;\n\tv7 = i << 3;\n\tv9 = this.deltaVel;\n\tv11 = *([v6 @ X9_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]) + *([v9 @ X10_v1 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]);\n\t*([v6 @ X9_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]) = v11;\n\treturn;\n// 4 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Execute(int i)
	{
		//IL_006f: Expected O, but got I
		global::Unity.Collections.NativeArray<bool> nativeArray = isStatic;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v0 @ X9_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]");
		if ((nint)0 == 0)
		{
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray2 = velocities;
			int num = i << 3;
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray3 = deltaVel;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v6 @ X9_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]");
			nint num2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v9 @ X10_v1 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v7 @ X8_v2 (System.Int32)]");
			object obj = num2 + 0;
		}
	}
}
