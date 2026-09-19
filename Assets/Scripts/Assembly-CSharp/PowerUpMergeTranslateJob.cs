[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x200007B")]
public struct PowerUpMergeTranslateJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Cpp2ILInjected.Token(Token = "0x4000233")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

	[global::Cpp2ILInjected.Token(Token = "0x4000234")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> velocities;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000235")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<int> powerUpIds;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000236")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> mergeDeltas;

	[global::Cpp2ILInjected.Token(Token = "0x4000237")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float dt;

	[global::Cpp2ILInjected.Token(Token = "0x600024A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFA32C", Offset = "0xFFA32C", Length = "0xB4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0016;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0xC60;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, i, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv42 = 1;\n\t*([302A9EC]) = v42;\nL_0016:\n\tv44 = this.powerUpIds;\n\tv46 = *([v44 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) + 1;\n\tv48 = v46 == 0;\n\tif (v48) goto L_003A;\n\tv53 = this + 0x30;\n\tv57 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::TryGetValue(v53, *([v44 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]), &v56 @ stack_-38_v3 (Unity.Mathematics.float2));\n\tv73 = ~v57;\n\tif (v73) goto L_003A;\n\tv83 = this.positions;\n\tv75 = i << 3;\n\tv85 = *([v83 @ X9_v2 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v75 @ X8_v8 (System.Int32)]) + v56;\n\t*([v83 @ X9_v2 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v75 @ X8_v8 (System.Int32)]) = v85;\n\tv59 = this.velocities;\n\t// 48 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\tv64 = v56 / v56;\n\t*([v59 @ X10_v2 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v75 @ X8_v8 (System.Int32)]) = v64;\nL_003A:\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void Execute(int i)
	{
		//IL_0011: Expected O, but got Ref
		global::Unity.Collections.NativeArray<int> nativeArray = powerUpIds;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]");
		if ((uint)((nuint)0u + (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]");
			if (mergeDeltas.TryGetValue(powerUpIds[i], out var item))
			{
				global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray2 = positions;
				int num = i << 3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X9_v2 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v75 @ X8_v8 (System.Int32)]");
				float num2 = 0f + item.x;
				global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray3 = velocities;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
				float num3 = item.x / item.x;
			}
		}
	}
}
