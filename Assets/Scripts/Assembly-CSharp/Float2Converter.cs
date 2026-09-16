[global::Cpp2ILInjected.Token(Token = "0x20000B7")]
public class Float2Converter : FloatConverter<global::Unity.Mathematics.float2>
{
	[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
	protected override int ComponentCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x600033A")]
		[global::Cpp2ILInjected.Address(RVA = "0x100EF5C", Offset = "0x100EF5C", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn 2;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			return 2;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600033B")]
	[global::Cpp2ILInjected.Address(RVA = "0x100EF64", Offset = "0x100EF64", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn x;\n")]
	protected override global::Unity.Mathematics.float2 CreateInstance(float x, float y, float z = 0f)
	{
		//IL_0005: Expected O, but got F4
		return (global::Unity.Mathematics.float2)x;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600033C")]
	[global::Cpp2ILInjected.Address(RVA = "0x100EF68", Offset = "0x100EF68", Length = "0x54")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001F;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x838;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AABA]) = v43;\nL_001F:\n\tFloatConverter`1<Unity.Mathematics.float2>::.ctor(this);\n\treturn;\n// 25 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Float2Converter()
	{
	}
}
