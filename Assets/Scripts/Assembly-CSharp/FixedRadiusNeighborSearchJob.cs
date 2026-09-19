[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000074")]
public struct FixedRadiusNeighborSearchJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

	[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public float cellSize;

	[global::Cpp2ILInjected.Token(Token = "0x40001FA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int capacity;

	[global::Cpp2ILInjected.Token(Token = "0x40001FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public global::Unity.Collections.NativeMultiHashMap<int, int>.ParallelWriter cellMap;

	[global::Cpp2ILInjected.Token(Token = "0x6000243")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF8E38", Offset = "0xFF8E38", Length = "0x188")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0x430;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, index, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv46 = 1;\n\t*([302A9E7]) = v46;\nL_0017:\n\tv47 = this.positions;\n\tv51 = 0x2DD4000;\n\tv53 = *([2DD4429]) == 0;\n\tif (v53) goto L_0032;\n\tv54 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv56 = *([v54 @ X22_v8 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv58 = *([v56 @ X0_v19+E0]) == 0;\n\tif (v58) goto L_003C;\nL_0025:\n\tv89 = this.cellSize;\n\tv107 = Il2CppMethodInfo + 0x430;\n\tgoto L_004B;\n\tgoto L_FFFFFFFF;\nL_0032:\n\t*([v51 @ X21_v2+429]) = 1;\n\tv83 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv65 = *([v83 @ X22_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv84 = *([v65 @ X0_v16+E0]) == 0;\n\tv67 = ~v84;\n\tif (v67) goto L_0025;\nL_003C:\n\tv89 = this.cellSize;\n\tv138 = *([v51 @ X21_v2+429]) == 0;\n\tif (v138) goto L_0071;\n\tv107 = Il2CppMethodInfo + 0x430;\n\tgoto L_004B;\nL_004B:\n\tv114 = *([v47 @ X8_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]) / this.cellSize;\n\t// 76 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\t// 78 NotImplemented \"Instruction DUP not yet implemented.\"\n\t// 79 NotImplemented \"Instruction FCMEQ not yet implemented.\"\n\t// 80 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\tv118 = v114 * 7.326691259334284E-306d;\n\t// 85 NotImplemented \"Instruction BIT not yet implemented.\"\n\t// 86 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv120 = v89 + v118;\n\tv123 = v120 / this.capacity;\n\tv124 = v123 * this.capacity;\n\tv125 = v120 - v124;\n\tv126 = this + 0x18;\n\tUnity.Collections.NativeMultiHashMap`2+ParallelWriter::Add /* +1 sharing this address */(v126, v125, index, *([v107 @ X21_v3]));\n\treturn;\nL_0071:\n\t*([v51 @ X21_v2+429]) = 1;\n\tv107 = Il2CppMethodInfo + 0x430;\n\tgoto L_004B;\n\tgoto L_FFFFFFFF;\n\treturn;\n// 74 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void Execute(int index)
	{
		//IL_0160: Expected O, but got I4
		//IL_008c: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_005e: Expected O, but got I
		//IL_0013: Expected I, but got O
		//IL_0023: Expected O, but got I
		//IL_0239: Expected O, but got Ref
		//IL_0133: Expected O, but got I
		//IL_0107: Expected O, but got I
		global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray = positions;
		object obj = 48054272;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4429]");
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X22_v8 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X0_v19+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0048;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X22_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X0_v16+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0048;
			}
		}
		float num3 = cellSize;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X21_v2+429]");
		object obj4;
		if ((nint)0 != 0)
		{
			obj4 = (nint)0 + (nint)1072;
		}
		else
		{
			_ = 1;
			obj4 = (nint)0 + (nint)1072;
		}
		goto IL_0185;
		IL_0048:
		num3 = cellSize;
		obj4 = (nint)0 + (nint)1072;
		goto IL_0185;
		IL_0185:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]");
		float num4 = 0f / cellSize;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMEQ not yet implemented.\"");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		double num5 = (double)num4 * 7.326691259334284E-306;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		double num6 = (double)num3 + num5;
		double num7 = num6 / (double)capacity;
		double num8 = num7 * (double)capacity;
		double num9 = num6 - num8;
		object obj5 = (object)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 24));
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1830BA0 (Unity.Collections.NativeMultiHashMap`2+ParallelWriter::Add, and 1 more at this address)");
	}
}
