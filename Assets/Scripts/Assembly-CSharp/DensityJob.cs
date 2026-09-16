[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000075")]
public struct DensityJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x40001FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> predicted;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeMultiHashMap<int, int> cellMap;

	[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> densities;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<bool> isWater;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000200")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::Unity.Collections.NativeHashMap<ulong, byte> ignorePairs;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000201")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public global::Unity.Collections.NativeArray<int> powerUpIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000202")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public float mass;

	[global::Cpp2ILInjected.Token(Token = "0x4000203")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public int capacity;

	[global::Cpp2ILInjected.Token(Token = "0x6000244")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF8FC0", Offset = "0xFF8FC0", Length = "0x50C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv48 = System.Runtime.Serialization.ObjectHolderList;\n\tgoto L_002E;\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0xC80;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, i, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69);\n\tv85 = Il2CppMethodInfo;\n\tv86 = v85 + 0xCC8;\n\tv87 = \"il2cpp_codegen_initialize_runtime_metadata\"(v86, i, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69);\n\tv94 = Il2CppMethodInfo;\n\tv95 = v94 + 0xCD0;\n\tv96 = \"il2cpp_codegen_initialize_runtime_metadata\"(v95, i, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69);\n\tv122 = System.Runtime.Serialization.ObjectHolderList;\n\tv123 = v122 + 0xD20;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v123, i, methodInfo, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69);\n\tv73 = 1;\n\t*([302A9E8]) = v73;\nL_002E:\n\tv74 = 0;\n\tv77 = i << 3;\n\tv78 = this.predicted + v77;\n\tv82 = *([v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv84 = *([v82 @ X0_v2+E0]) == 0;\n\tif (v84) goto L_01ED;\n\tv88 = *([v82 @ X0_v2+B8]);\n\tv124 = *([v88 @ X8_v100]);\n\tv92 = *([2DD4429]) == 0;\n\tif (v92) goto L_01F9;\nL_0040:\n\tv107 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv109 = *([v107 @ X8_v97 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv111 = *([v109 @ X0_v73+E0]) == 0;\n\tif (v111) goto L_0207;\nL_0048:\n\tv179 = *([v78 @ X8_v4]) / v124;\n\tv135 = *([v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv136 = *([v135 @ X9_v32+B8]);\n\tv173 = *([v136 @ X9_v33]);\n\tgoto L_0054;\nL_0052:\n\t*([2DD4429]) = 1;\nL_0054:\n\tv208 = UnityEngine.Mathf::Floor(v179);\n\tv217 = *([v78 @ X8_v4+4]) / v173;\n\tgoto L_005E;\n\tv220 = \"il2cpp_codegen_runtime_class_init\"(v215, i, methodInfo, v57, v58, v59, v60, v61, v200, v63, v64, v65, v66, v67, v68, v69);\nL_005E:\n\tv222 = Il2CppMethodInfo;\n\tv224 = UnityEngine.Mathf::Floor(v217);\n\tv239 = v208 != 0x7F800000;\n\tif (v239) goto L_FFFFFFFF;\n\tgoto L_007F;\nL_007F:\n\tv253 = v224 != 0x7F800000;\n\tif (v253) goto L_FFFFFFFF;\n\tgoto L_0086;\nL_0086:\n\tv258 = this + 0x10;\n\tv259 = this + 0x40;\n\tgoto L_009D;\nL_0090:\n\tv327 = v327 + 1;\n\tv314 = v327 == 2;\n\tif (v314) goto L_01CF;\nL_009D:\n\tv342 = v327 + v242;\n\tv344 = v342 * 0x3DCF;\n\tgoto L_00B0;\nL_00A3:\n\tv387 = v387 + 1;\n\tv370 = v387 == 2;\n\tif (v370) goto L_0090;\nL_00B0:\n\tv390 = v387 + v256;\n\tv393 = v390 * 0x949475;\n\tv394 = v344 + v393;\n\tv396 = v394 / this.capacity;\n\tv397 = v396 * this.capacity;\n\tv398 = v394 - v397;\n\tv399 = Il2CppMethodInfo;\n\tv405 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v258, v398, &v402 @ stack_-A4_v3, &v74 @ stack_-B0_v1, *([v399 @ X8_v21 (Il2CppMethodInfo)+CC8]));\n\tv406 = v405 == 0;\n\tv407 = ~v406;\n\tif (v407) goto L_00D7;\n\tgoto L_00A3;\nL_00C4:\n\tv854 = v851 - v618;\n\tv855 = *([v835 @ X8_v46+8]);\n\tv808 = v854 * v854;\n\tv829 = v854 * v808;\n\tv825 = v855 * v829;\nL_00C9:\n\tv837 = v603 * v602;\n\tv838 = v604 * v837;\n\tv411 = v411 + v838;\n\tv839 = v621 * v617;\n\tv620 = v604 * v839;\n\tv409 = v409 + v620;\nL_00D3:\n\tv465 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v258, &v402 @ stack_-A4_v3, &v74 @ stack_-B0_v1, *([v222 @ X26_v1 (Il2CppMethodInfo)+CD0]));\n\tv634 = v465 & 1;\n\tv467 = v634 == 0;\n\tif (v467) goto L_00A3;\nL_00D7:\n\tv470 = this.powerUpIds;\n\tv474 = *([v470 @ X10_v8 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) + 1;\n\tv476 = v474 == 0;\n\tv479 = ~v476;\n\tv480 = ~v479;\n\tif (v480) goto L_FFFFFFFF;\n\tv493 = *([v470 @ X10_v8 (Unity.Collections.NativeArray`1<System.Int32>)+v402 @ stack_-A4_v3*4]) - -1;\n\tv510 = v493 == 0;\n\tgoto L_FFFFFFFF;\n\tif (v510) goto L_00FF;\n\tv519 = *([v470 @ X10_v8 (Unity.Collections.NativeArray`1<System.Int32>)+v402 @ stack_-A4_v3*4]) | *([v470 @ X10_v8 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]);\n\tv524 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::ContainsKey(v259, v519);\n\tv572 = v524 == 0;\n\tv529 = ~v572;\n\tif (v529) goto L_00D3;\nL_00FF:\n\tv532 = this.isWater;\n\tv538 = *([v532 @ X9_v12 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) == 0;\n\tv543 = ~v538;\n\tv550 = *([v532 @ X9_v12 (Unity.Collections.NativeArray`1<System.Boolean>)+v530 @ X8_v25]) == 0;\n\tv556 = v543 ^ v550;\n\tv561 = v556 == 0;\n\tv568 = ~v561;\n\tv569 = ~v568;\n\tif (v569) goto L_FFFFFFFF;\n\tgoto L_012B;\nL_012B:\n\tv600 = v530 << 3;\n\tv629 = this.predicted + v600;\n\tv633 = *([2DD4420]) == 0;\n\tif (v633) goto L_01AC;\n\tv635 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv637 = *([v635 @ X8_v66 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv639 = *([v637 @ X0_v50+E0]) == 0;\n\tif (v639) goto L_01B5;\nL_0138:\n\tv603 = this.mass;\n\tv650 = *([v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv652 = *([v650 @ X0_v49+E0]) == 0;\n\tif (v652) goto L_01BD;\nL_013E:\n\tv670 = *([2DD442A]) == 0;\n\tif (v670) goto L_01C3;\nL_0140:\n\tv773 = *([v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tgoto L_0144;\nL_0144:\n\tv703 = *([v629 @ X8_v26+4]) - *([v78 @ X8_v4+4]);\n\tv705 = *([v629 @ X8_v26]) - *([v78 @ X8_v4]);\n\tv706 = v705 * v705;\n\tv707 = v703 * v703;\n\tv708 = v706 + v707;\n\tv618 = UnityEngine.Mathf::Sqrt(v708);\n\tv764 = *([v773 @ X0_v43+B8]);\n\tv726 = *([v764 @ X8_v52]) > v618;\n\tif (v726) goto L_0176;\n\tv621 = this.mass;\n\tv729 = *([2DD442B]) == 0;\n\tif (v729) goto L_0187;\nL_0160:\n\tv749 = *([v773 @ X0_v43+E0]) == 0;\n\tif (v749) goto L_018E;\nL_0162:\n\t;\n\tgoto L_00C9;\n\tgoto L_FFFFFFFF;\nL_0176:\n\tgoto L_017B;\n\tv760 = \"il2cpp_codegen_runtime_class_init\"(v694, v526, v525, v426, v294, v59, v60, v61, v714, v706, v424, v65, v66, v67, v68, v69);\n\tv763 = *([v49 @ X20_v2]);\n\tv765 = *([v763 @ X0_v42+B8]);\n\tv762 = *([v765 @ X8_v54]);\nL_017B:\n\tv766 = *([v764 @ X8_v52]) - v618;\n\tv739 = v766 * v766;\n\tv602 = *([v764 @ X8_v52+4]) * v739;\n\tv621 = this.mass;\n\tv767 = *([2DD442B]) == 0;\n\tv745 = ~v767;\n\tif (v745) goto L_0160;\nL_0187:\n\t*([2DD442B]) = 1;\n\tv773 = *([v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv804 = *([v773 @ X0_v43+E0]) == 0;\n\tv776 = ~v804;\n\tif (v776) goto L_0162;\nL_018E:\n\tv833 = *([v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv836 = *([v833 @ X0_v35+B8]);\n\tv830 = *([v836 @ X8_v48]);\n\tgoto L_00C9;\n\tgoto L_00C4;\n\tv850 = \"il2cpp_codegen_runtime_class_init\"(v846, v526, v525, v426, v294, v59, v60, v61, v845, v843, v424, v65, v66, v67, v68, v69);\n\tv856 = *([v49 @ X20_v2]);\n\tv853 = *([v856 @ X8_v44+B8]);\n\tv852 = *([v853 @ X8_v45]);\n\tgoto L_00C4;\nL_01AC:\n\t*([2DD4420]) = 1;\n\tv658 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv644 = *([v658 @ X8_v37 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv660 = *([v644 @ X0_v27+E0]) == 0;\n\tv646 = ~v660;\n\tif (v646) goto L_0138;\nL_01B5:\n\tv603 = this.mass;\n\tv664 = *([v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv676 = *([v664 @ X0_v23+E0]) == 0;\n\tv666 = ~v676;\n\tif (v666) goto L_013E;\nL_01BD:\n\tv692 = *([2DD442A]) == 0;\n\tv680 = ~v692;\n\tif (v680) goto L_0140;\nL_01C3:\n\t*([2DD442A]) = 1;\n\tv773 = *([v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tgoto L_0144;\n\tv710 = \"il2cpp_codegen_runtime_class_init\"(v709, v526, v525, v426, v294, v59, v60, v61, v566, v567, v424, v65, v66, v67, v68, v69);\n\tv696 = *([v49 @ X20_v2]);\n\tgoto L_0144;\nL_01CF:\n\tv518 = UnityEngine.Mathf::Max(v269, 1E-06f);\n\tv570 = UnityEngine.Mathf::Max(v267, 1E-06f);\n\tv576 = i << 3;\n\tv577 = this.densities + v576;\n\t*([v577 @ X8_v77]) = v518;\n\t*([v577 @ X8_v77+4]) = v570;\n\treturn;\nL_01ED:\n\tv100 = *([v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv120 = *([v100 @ X0_v66+B8]);\n\tv124 = *([v120 @ X8_v90]);\n\tv121 = *([2DD4429]) == 0;\n\tv102 = ~v121;\n\tif (v102) goto L_0040;\nL_01F9:\n\t*([2DD4429]) = 1;\n\tv146 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv126 = *([v146 @ X8_v87 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv148 = *([v126 @ X0_v64+E0]) == 0;\n\tv128 = ~v148;\n\tif (v128) goto L_0048;\nL_0207:\n\tv163 = *([2DD4429]) == 0;\n\tv180 = *([\n// ... truncated")]
	public unsafe void Execute(int i)
	{
		//IL_000e: Expected I, but got O
		//IL_0984: Expected O, but got I4
		//IL_099c: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a1: Expected O, but got Unknown
		//IL_09b1: Expected O, but got I
		//IL_0850: Expected O, but got I
		//IL_0860: Expected O, but got I
		//IL_0066: Expected I, but got O
		//IL_0076: Expected O, but got I
		//IL_0023: Expected O, but got I
		//IL_0932: Expected O, but got I
		//IL_0942: Expected O, but got I
		//IL_08b4: Expected I, but got O
		//IL_08c4: Expected O, but got I
		//IL_00c2: Expected O, but got I
		//IL_00d2: Expected O, but got I
		//IL_0a2c: Expected O, but got Ref
		//IL_0a37: Expected O, but got Ref
		//IL_0a56: Expected O, but got I8
		//IL_01bd: Expected O, but got I8
		//IL_0332: Expected O, but got I
		//IL_037b: Expected O, but got I
		//IL_01d1: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_03ba: Expected I8, but got I
		//IL_0ad0: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad5: Expected O, but got Unknown
		//IL_082d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0832: Expected O, but got Unknown
		//IL_083a: Expected O, but got F4
		//IL_06fd: Expected I, but got O
		//IL_070d: Expected O, but got I
		//IL_047b: Expected O, but got I
		//IL_042c: Expected I, but got O
		//IL_043c: Expected O, but got I
		//IL_0757: Expected O, but got I
		//IL_04e7: Expected O, but got I
		//IL_0509: Expected O, but got I
		//IL_0525: Expected O, but got I
		//IL_0534: Expected O, but got I
		//IL_0560: Expected O, but got I
		//IL_07df: Expected O, but got I
		//IL_064e: Expected O, but got I
		//IL_069e: Expected O, but got I
		//IL_06ae: Expected O, but got I
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		object obj = 0;
		int num2 = i << 3;
		object obj2 = predicted + num2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v2+E0]");
		object obj5;
		object obj6;
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v82 @ X0_v2+B8]");
			object obj4 = 0;
			obj5 = obj4;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4429]");
			bool flag = (nint)0 == 0;
			obj6 = obj4;
			if (!flag)
			{
				goto IL_0058;
			}
		}
		else
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X0_v66+B8]");
			object obj8 = 0;
			obj5 = obj8;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4429]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			obj6 = obj8;
			if (flag3)
			{
				goto IL_0058;
			}
		}
		_ = 1;
		nint num3 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v87 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
		object obj9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X0_v64+E0]");
		bool flag4 = (nint)0 == 0;
		bool flag5 = !flag4;
		obj5 = obj6;
		if (flag5)
		{
			goto IL_00a3;
		}
		goto IL_08fc;
		IL_00a3:
		float f = (float)obj2 / (float)obj5;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj10 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v135 @ X9_v32+B8]");
		object obj11 = 0;
		object obj12 = obj11;
		goto IL_09d6;
		IL_09d6:
		float num4 = global::UnityEngine.Mathf.Floor(f);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4+4]");
		float num5 = 0f / (float)obj12;
		nint num6 = 0;
		float num7 = global::UnityEngine.Mathf.Floor(num5);
		float num8 = ((num4 != float.PositiveInfinity) ? num4 : -0f);
		float num9 = ((num7 != float.PositiveInfinity) ? num5 : -0f);
		object obj13 = (object)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		global::Unity.Collections.NativeHashMap<ulong, byte> nativeParallelHashMap = (global::Unity.Collections.NativeHashMap<ulong, byte>)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 64));
		float num10 = 0f;
		float num11 = 0f;
		object obj14 = 4294967295L;
		object obj16 = default(object);
		float num21;
		float num22;
		object obj20 = default(object);
		object obj30 = default(object);
		bool flag24;
		do
		{
			float num12 = (float)obj14 + num8;
			float num13 = num12 * 2.2173E-41f;
			object obj15 = 4294967295L;
			bool flag23;
			do
			{
				float num14 = (float)obj15 + num9;
				float num15 = num14 * 1.364491E-38f;
				float num16 = num13 + num15;
				float num17 = num16 / (float)capacity;
				float num18 = num17 * (float)capacity;
				float num19 = num16 - num18;
				nint num20 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8DC8 (Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue, and 1 more at this address)");
				if (obj16 == null)
				{
					num21 = num10;
					num22 = num11;
				}
				else
				{
					bool flag16;
					do
					{
						global::Unity.Collections.NativeArray<int> nativeArray = powerUpIds;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v8 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]");
						object obj17 = (nint)0 + (nint)1;
						bool flag6;
						if (obj17 != null)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v8 (Unity.Collections.NativeArray`1<System.Int32>)+v402 @ stack_-A4_v3*4]");
							object obj18 = --1;
							flag6 = obj18 == null;
						}
						else
						{
							flag6 = true;
						}
						object obj19 = obj20;
						if (!flag6)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v8 (Unity.Collections.NativeArray`1<System.Int32>)+v402 @ stack_-A4_v3*4]");
							nint num23 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v470 @ X10_v8 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]");
							ulong key = (ulong)(num23 | 0);
							if (((global::Unity.Collections.NativeHashMap<ulong, byte>*)nativeParallelHashMap)->ContainsKey(key))
							{
								goto IL_0a71;
							}
							obj19 = obj20;
						}
						global::Unity.Collections.NativeArray<bool> nativeArray2 = isWater;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X9_v12 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]");
						bool flag7 = (nint)0 == 0;
						bool flag8 = !flag7;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X9_v12 (Unity.Collections.NativeArray`1<System.Boolean>)+v530 @ X8_v25]");
						bool flag9 = (nint)0 == 0;
						float num24 = ((!(flag8 ^ flag9)) ? 0f : 1f);
						int num25 = (int)((nint)obj19 << 3);
						object obj21 = predicted + num25;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
						if ((nint)0 != 0)
						{
							nint num26 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v635 @ X8_v66 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
							object obj22 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v637 @ X0_v50+E0]");
							if ((nint)0 != 0)
							{
								goto IL_0461;
							}
						}
						else
						{
							_ = 1;
							nint num27 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v658 @ X8_v37 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
							object obj23 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v644 @ X0_v27+E0]");
							if ((nint)0 != 0)
							{
								goto IL_0461;
							}
						}
						float num28 = mass;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						object obj24 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v664 @ X0_v23+E0]");
						bool flag10 = (nint)0 == 0;
						bool flag11 = !flag10;
						float num29 = mass;
						if (flag11)
						{
							goto IL_04aa;
						}
						goto IL_0791;
						IL_0461:
						num28 = mass;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						object obj25 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X0_v49+E0]");
						bool flag12 = (nint)0 == 0;
						num29 = mass;
						if (!flag12)
						{
							goto IL_04aa;
						}
						goto IL_0791;
						IL_04aa:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD442A]");
						bool flag13 = (nint)0 == 0;
						num29 = num28;
						if (!flag13)
						{
							goto IL_04d7;
						}
						goto IL_07c9;
						IL_068e:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						object obj26 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v833 @ X0_v35+B8]");
						object obj27 = 0;
						object obj28 = obj27;
						float num31;
						float num30 = num31;
						int num32 = 0;
						float num34;
						float num33 = num34;
						goto IL_0afa;
						IL_07c9:
						_ = 1;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						object obj29 = 0;
						num28 = num29;
						goto IL_04ec;
						IL_04d7:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						obj29 = 0;
						goto IL_04ec;
						IL_0791:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD442A]");
						bool flag14 = (nint)0 == 0;
						bool flag15 = !flag14;
						num28 = num29;
						if (flag15)
						{
							goto IL_04d7;
						}
						goto IL_07c9;
						IL_0afa:
						float num35 = num28 * num30;
						float num36 = num24 * num35;
						num11 += num36;
						float num37 = num33 * (float)num32;
						float num38 = num24 * num37;
						num10 += num38;
						goto IL_0a71;
						IL_0a71:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8E24 (Unity.Collections.NativeMultiHashMap`2::TryGetNextValue, and 1 more at this address)");
						int num39 = (int)((nint)obj30 & 1);
						flag16 = num39 == 0;
						num21 = num10;
						num22 = num11;
						continue;
						IL_04ec:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v629 @ X8_v26+4]");
						nint num40 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4+4]");
						object obj31 = num40 - 0;
						object obj32 = obj21 - obj2;
						object obj33 = (nint)obj32 * (nint)obj32;
						object obj34 = (nint)obj31 * (nint)obj31;
						float f2 = (float)obj33 + (float)obj34;
						float num41 = global::UnityEngine.Mathf.Sqrt(f2);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v43+B8]");
						object obj35 = 0;
						if (!((float)obj35 > num41))
						{
							num33 = mass;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD442B]");
							bool flag17 = (nint)0 == 0;
							num30 = 0f;
							num31 = 0f;
							num34 = mass;
							if (!flag17)
							{
								goto IL_05c9;
							}
						}
						else
						{
							float num42 = (float)obj35 - num41;
							float num43 = num42 * num42;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v764 @ X8_v52+4]");
							num30 = 0f * num43;
							num33 = mass;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD442B]");
							bool flag18 = (nint)0 == 0;
							bool flag19 = !flag18;
							num31 = num30;
							num34 = mass;
							if (flag19)
							{
								goto IL_05c9;
							}
						}
						_ = 1;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						obj29 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v43+E0]");
						bool flag20 = (nint)0 == 0;
						bool flag21 = !flag20;
						num30 = num31;
						num33 = num34;
						if (flag21)
						{
							goto IL_05fe;
						}
						goto IL_068e;
						IL_05c9:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X0_v43+E0]");
						bool flag22 = (nint)0 == 0;
						num31 = num30;
						num34 = num33;
						if (!flag22)
						{
							goto IL_05fe;
						}
						goto IL_068e;
						IL_05fe:
						num32 = 0;
						goto IL_0afa;
					}
					while (!flag16);
				}
				obj15 = (nint)obj15 + 1;
				flag23 = (nint)obj15 == 2;
				num10 = num21;
				num11 = num22;
			}
			while (!flag23);
			obj14 = (nint)obj14 + 1;
			flag24 = (nint)obj14 == 2;
			num10 = num21;
			num11 = num22;
		}
		while (!flag24);
		float num44 = global::UnityEngine.Mathf.Max(num22, 1E-06f);
		float num45 = global::UnityEngine.Mathf.Max(num21, 1E-06f);
		int num46 = i << 3;
		object obj36 = densities + num46;
		obj36 = num44;
		return;
		IL_08fc:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4429]");
		bool flag25 = (nint)0 == 0;
		float num47 = (float)obj2 / (float)obj6;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj37 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X9_v29+B8]");
		object obj38 = 0;
		if (flag25)
		{
			_ = 1;
		}
		else
		{
			obj12 = obj38;
			f = num47;
		}
		goto IL_09d6;
		IL_0058:
		nint num48 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v97 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
		object obj39 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v73+E0]");
		bool flag26 = (nint)0 == 0;
		obj6 = obj5;
		if (!flag26)
		{
			goto IL_00a3;
		}
		goto IL_08fc;
	}
}
