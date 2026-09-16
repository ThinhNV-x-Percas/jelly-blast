[global::Cpp2ILInjected.Token(Token = "0x20000A0")]
public readonly struct ParticleInitData
{
	[global::Cpp2ILInjected.Token(Token = "0x4000372")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public readonly int Index;

	[global::Cpp2ILInjected.Token(Token = "0x4000373")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
	public readonly int Id;

	[global::Cpp2ILInjected.Token(Token = "0x4000374")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
	public readonly int Local;

	[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
	[global::Cpp2ILInjected.Address(RVA = "0x1009730", Offset = "0x1009730", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.Index = index;\n\tthis.Id = id;\n\tthis.Local = local;\n\treturn;\n")]
	public ParticleInitData(int index, int id, int local)
	{
		Index = index;
		Id = id;
		Local = local;
	}
}
