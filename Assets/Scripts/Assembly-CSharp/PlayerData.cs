[global::System.Serializable]
[global::Cpp2ILInjected.Token(Token = "0x200003A")]
public class PlayerData
{
	[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public bool soundsOn;

	[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x11")]
	public bool hapticOn;

	[global::Cpp2ILInjected.Token(Token = "0x40000DD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int levelIndex;

	[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int coinCount;

	[global::Cpp2ILInjected.Token(Token = "0x600014F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE69A4", Offset = "0xFE69A4", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.soundsOn = 0x101;\n\tSystem.Object::.ctor(this);\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public PlayerData()
	{
		soundsOn = true;
		hapticOn = true;
	}
}
