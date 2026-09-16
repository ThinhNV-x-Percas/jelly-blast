[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000072")]
public struct ClearDeltaJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Cpp2ILInjected.Token(Token = "0x40001F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Cpp2ILInjected.Token(Token = "0x6000241")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF8CFC", Offset = "0xFF8CFC", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = System.Xml.ValidateNames;\n\tgoto L_0017;\n\tv25 = System.Xml.ValidateNames;\n\tv26 = v25 + 0xD40;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, index, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302A9E5]) = v44;\nL_0017:\n\tv45 = *([v20 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv46 = *([v45 @ X8_v3+B8]);\n\tv48 = this.deltaVel;\n\t*([v48 @ X9_v1 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]) = *([v46 @ X8_v4]);\n\treturn;\n// 24 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Execute(int index)
	{
		//IL_000e: Expected I, but got O
		//IL_0023: Expected O, but got I
		//IL_0033: Expected O, but got I
		nint num = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+D40]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X8_v3+B8]");
		object obj2 = 0;
		global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray = deltaVel;
	}
}
