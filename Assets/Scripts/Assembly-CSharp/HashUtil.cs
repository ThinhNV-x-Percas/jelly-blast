[global::Cpp2ILInjected.Token(Token = "0x20000D0")]
internal static class HashUtil
{
	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	[global::Cpp2ILInjected.Token(Token = "0x60003B4")]
	[global::Cpp2ILInjected.Address(RVA = "0x10163D0", Offset = "0x10163D0", Length = "0x18")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = x * 0x3DCF;\n\tv5 = y * 0x949475;\n\treturnVal1 = v1 + v5;\n\treturn returnVal1;\n// 3 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static uint Hash(int x, int y)
	{
		int num = x * 15823;
		int num2 = y * 9737333;
		return (uint)(num + num2);
	}
}
