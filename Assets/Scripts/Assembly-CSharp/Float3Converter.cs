[global::Cpp2ILInjected.Token(Token = "0x20000B8")]
public class Float3Converter : FloatConverter<global::Unity.Mathematics.float3>
{
	[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
	protected override int ComponentCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x600033D")]
		[global::Cpp2ILInjected.Address(RVA = "0x100EFBC", Offset = "0x100EFBC", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn 3;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			return 3;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600033E")]
	[global::Cpp2ILInjected.Address(RVA = "0x100EFC4", Offset = "0x100EFC4", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn x;\n")]
	protected override global::Unity.Mathematics.float3 CreateInstance(float x, float y, float z = 0f)
	{
		//IL_0005: Expected O, but got F4
		return (global::Unity.Mathematics.float3)x;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600033F")]
	[global::Cpp2ILInjected.Address(RVA = "0x100EFC8", Offset = "0x100EFC8", Length = "0x54")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001F;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x840;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AABB]) = v43;\nL_001F:\n\tFloatConverter`1<Unity.Mathematics.float3>::.ctor(this);\n\treturn;\n// 25 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Float3Converter()
	{
	}
}
