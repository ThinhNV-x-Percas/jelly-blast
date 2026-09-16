[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x200007A")]
public struct BlobCohesionJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400022C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> positions;

	[global::Cpp2ILInjected.Token(Token = "0x400022D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400022E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<int> blobIds;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400022F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> blobMidpoints;

	[global::Cpp2ILInjected.Token(Token = "0x4000230")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float cohesionRadius;

	[global::Cpp2ILInjected.Token(Token = "0x4000231")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float springStrength;

	[global::Cpp2ILInjected.Token(Token = "0x4000232")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float dt;

	[global::Cpp2ILInjected.Token(Token = "0x6000249")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFA1F4", Offset = "0xFFA1F4", Length = "0x138")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0xC68;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, index, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv46 = 1;\n\t*([302A9EB]) = v46;\nL_0017:\n\tv47 = this.blobIds;\n\tv49 = *([v47 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+index @ X1 (System.Int32)*4]) + 1;\n\tv51 = v49 == 0;\n\tif (v51) goto L_006C;\n\tv57 = this + 0x30;\n\tv59 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::get_Item(v57, *([v47 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+index @ X1 (System.Int32)*4]));\n\tv127 = this.positions;\n\tv131 = *([2DD4420]) == 0;\n\tif (v131) goto L_0073;\n\tv100 = v59 - *([v127 @ X8_v7 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]);\n\tgoto L_0034;\nL_0034:\n\tv154 = v100 * v100;\n\t// 53 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv106 = UnityEngine.Mathf::Sqrt(v154);\n\tv164 = v106 == 0;\n\tv169 = ~v164;\n\tv71 = ~v169;\n\tif (v71) goto L_FFFFFFFF;\n\tv170 = v106 < this.cohesionRadius;\n\tv95 = ~v170;\n\tv172 = v106 - this.cohesionRadius;\n\tv88 = v172 == 0;\n\tgoto L_0053;\nL_0053:\n\tv183 = ~v95;\n\tv74 = v183 | v88;\n\tif (v74) goto L_006C;\n\t// 86 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv69 = v100 / v38;\n\tv113 = this.deltaVel;\n\tv66 = index << 3;\n\tv186 = v69 * v187;\n\tv188 = v186 * v129;\n\tv189 = v188 * v190;\n\tv105 = *([v113 @ X8_v15 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v66 @ X9_v2 (System.Int32)]) + v189;\n\t*([v113 @ X8_v15 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v66 @ X9_v2 (System.Int32)]) = v105;\nL_006C:\n\treturn;\nL_0073:\n\t*([2DD4420]) = 1;\n\tv100 = v59 - *([v127 @ X8_v7 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]);\n\tgoto L_0034;\n\tv149 = \"il2cpp_codegen_runtime_class_init\"(v155, v48, v58, v31, v32, v33, v34, v35, v147, v126, v38, v39, v40, v41, v42, v43);\n\tgoto L_0034;\n\treturn;\n// 79 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void Execute(int index)
	{
		//IL_0011: Expected O, but got Ref
		global::Unity.Collections.NativeArray<int> nativeArray = blobIds;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+index @ X1 (System.Int32)*4]");
		if ((uint)((nuint)0u + (nuint)1u) != 0)
		{
			global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = blobMidpoints;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X8_v3 (Unity.Collections.NativeArray`1<System.Int32>)+index @ X1 (System.Int32)*4]");
			global::Unity.Mathematics.float2 float5 = nativeParallelHashMap[nativeArray[index]];
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray2 = positions;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
			float num2;
			if ((nint)0 != 0)
			{
				float num = float5.x;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]");
				num2 = num - 0f;
			}
			else
			{
				_ = 1;
				float num3 = float5.x;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v7 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+index @ X1 (System.Int32)*8]");
				num2 = num3 - 0f;
			}
			float f = num2 * num2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			float num4 = global::UnityEngine.Mathf.Sqrt(f);
			bool flag2;
			bool flag3;
			if (num4 != 0f)
			{
				bool flag = num4 < cohesionRadius;
				flag2 = !flag;
				float num5 = num4 - cohesionRadius;
				flag3 = num5 == 0f;
			}
			else
			{
				flag3 = false;
				flag2 = false;
			}
			bool flag4 = !flag2;
			if (!(flag4 || flag3))
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
				object obj = default(object);
				float num6 = num2 / (float)obj;
				global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray3 = deltaVel;
				int num7 = index << 3;
				object obj2 = default(object);
				float num8 = num6 * (float)obj2;
				object obj3 = default(object);
				float num9 = num8 * (float)obj3;
				object obj4 = default(object);
				float num10 = num9 * (float)obj4;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v113 @ X8_v15 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v66 @ X9_v2 (System.Int32)]");
				float num11 = 0f + num10;
			}
		}
	}
}
