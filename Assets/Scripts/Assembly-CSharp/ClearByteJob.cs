[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000085")]
internal struct ClearByteJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Cpp2ILInjected.Token(Token = "0x4000267")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<byte> array;

	[global::Cpp2ILInjected.Token(Token = "0x6000258")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB7DC", Offset = "0xFFB7DC", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = this.array;\n\t*([v0 @ X8_v1 (Unity.Collections.NativeArray`1<System.Byte>)+i @ X1 (System.Int32)]) = 0;\n\treturn;\n")]
	public void Execute(int i)
	{
		global::Unity.Collections.NativeArray<byte> nativeArray = array;
		_ = 0;
	}
}
