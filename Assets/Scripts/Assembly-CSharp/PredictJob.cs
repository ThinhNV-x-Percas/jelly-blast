[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000073")]
public struct PredictJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Cpp2ILInjected.Token(Token = "0x40001F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

	[global::Cpp2ILInjected.Token(Token = "0x40001F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> velocities;

	[global::Cpp2ILInjected.Token(Token = "0x40001F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> predicted;

	[global::Cpp2ILInjected.Token(Token = "0x40001F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> gravities;

	[global::Cpp2ILInjected.Token(Token = "0x40001F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::Unity.Collections.NativeArray<bool> isStatic;

	[global::Cpp2ILInjected.Token(Token = "0x40001F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float dt;

	[global::Cpp2ILInjected.Token(Token = "0x6000242")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF8D60", Offset = "0xFF8D60", Length = "0xD8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv23 = System.Xml.ValidateNames;\n\tv24 = v23 + 0xD40;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, i, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302A9E6]) = v42;\nL_0015:\n\tv43 = this.isStatic;\n\tv46 = *([v43 @ X9_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) == 0;\n\tif (v46) goto L_002E;\n\tv47 = System.Xml.ValidateNames;\n\tv49 = *([v47 @ X9_v5 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv50 = *([v49 @ X9_v7+B8]);\n\tv52 = this.velocities;\n\tv53 = i << 3;\n\t*([v52 @ X10_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v53 @ X8_v5 (System.Int32)]) = *([v50 @ X9_v8]);\n\tv54 = this.positions;\n\tv56 = this.predicted;\n\t*([v56 @ X10_v4 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v53 @ X8_v5 (System.Int32)]) = *([v54 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v53 @ X8_v5 (System.Int32)]);\n\treturn;\nL_002E:\n\tv63 = this.velocities;\n\tv64 = i << 3;\n\tv65 = this.gravities;\n\tv69 = *([v65 @ X10_v1 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X8_v4 (System.Int32)]) * v70;\n\tv71 = *([v63 @ X9_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X8_v4 (System.Int32)]) + v69;\n\t*([v63 @ X9_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X8_v4 (System.Int32)]) = v71;\n\tv72 = this.positions;\n\tv74 = this.predicted;\n\tv76 = v71 * v77;\n\tv78 = *([v72 @ X9_v4 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X8_v4 (System.Int32)]) + v76;\n\t*([v74 @ X10_v2 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X8_v4 (System.Int32)]) = v78;\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Execute(int i)
	{
		//IL_00aa: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_00e8: Expected O, but got I
		//IL_00fe: Expected O, but got I
		//IL_0013: Expected I, but got O
		//IL_0023: Expected O, but got I
		//IL_0033: Expected O, but got I
		global::Unity.Collections.NativeArray<bool> nativeArray = isStatic;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X9_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]");
		if ((nint)0 != 0)
		{
			nint num = (nint)typeof(global::System.Xml.ValidateNames);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v5 (Il2CppClass<System.Xml.ValidateNames>)+D40]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X9_v7+B8]");
			object obj2 = 0;
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray2 = velocities;
			int num2 = i << 3;
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray3 = positions;
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray4 = predicted;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X9_v10 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v53 @ X8_v5 (System.Int32)]");
			_ = 0;
		}
		else
		{
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray5 = velocities;
			int num3 = i << 3;
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray6 = gravities;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X10_v1 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X8_v4 (System.Int32)]");
			object obj4 = default(object);
			object obj3 = 0 * (nint)obj4;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X8_v4 (System.Int32)]");
			object obj5 = 0 + (nint)obj3;
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray7 = positions;
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray8 = predicted;
			object obj7 = default(object);
			object obj6 = (nint)obj5 * (nint)obj7;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X9_v4 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v64 @ X8_v4 (System.Int32)]");
			object obj8 = 0 + (nint)obj6;
		}
	}
}
