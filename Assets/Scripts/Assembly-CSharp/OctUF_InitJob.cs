[global::Unity.Burst.BurstCompile(global::Unity.Burst.FloatPrecision.Low, global::Unity.Burst.FloatMode.Fast)]
[global::Cpp2ILInjected.Token(Token = "0x2000081")]
internal struct OctUF_InitJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Cpp2ILInjected.Token(Token = "0x400025A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<int> parent;

	[global::Cpp2ILInjected.Token(Token = "0x6000250")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB020", Offset = "0xFFB020", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = this.parent;\n\t*([v0 @ X8_v1 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) = i;\n\treturn;\n")]
	public void Execute(int i)
	{
		global::Unity.Collections.NativeArray<int> nativeArray = parent;
	}
}
