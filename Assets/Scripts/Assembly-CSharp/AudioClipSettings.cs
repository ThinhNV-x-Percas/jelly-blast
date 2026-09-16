[global::Cpp2ILInjected.Token(Token = "0x200003F")]
public class AudioClipSettings
{
	[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public float pitch;

	[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public float pitchVariance;

	[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float volume;

	[global::Cpp2ILInjected.Token(Token = "0x600016C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7C5C", Offset = "0xFE7C5C", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.pitch = 1f;\n\tthis.volume = 1f;\n\tSystem.Object::.ctor(this);\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public AudioClipSettings()
	{
		pitch = 1f;
		volume = 1f;
	}
}
