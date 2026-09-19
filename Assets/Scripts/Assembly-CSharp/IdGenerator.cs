[global::Cpp2ILInjected.Token(Token = "0x20000B2")]
public static class IdGenerator
{
	[global::Cpp2ILInjected.Token(Token = "0x40003E7")]
	private static int _nextId;

	[global::Cpp2ILInjected.Token(Token = "0x6000326")]
	[global::Cpp2ILInjected.Address(RVA = "0x100D0F0", Offset = "0x100D0F0", Length = "0x4C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0013;\n\tv17 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv18 = v17 + 0x78;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv38 = 1;\n\t*([302AAB8]) = v38;\nL_0013:\n\tv39 = *([v12 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+78]);\n\treturnVal1 = System.Threading.Interlocked::Increment(*([v39 @ X8_v3+B8]));\n\treturn returnVal1;\n// 19 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static int Next()
	{
		return global::System.Threading.Interlocked.Increment(ref _nextId);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000327")]
	[global::Cpp2ILInjected.Address(RVA = "0x100A250", Offset = "0x100A250", Length = "0x4C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0013;\n\tv17 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv18 = v17 + 0x78;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv38 = 1;\n\t*([302AAB9]) = v38;\nL_0013:\n\tv39 = *([v12 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+78]);\n\tv40 = *([v39 @ X8_v3+B8]);\n\t*([v40 @ X8_v4]) = 0;\n\treturn;\n// 17 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static void Reset()
	{
		_nextId = 0;
	}
}
