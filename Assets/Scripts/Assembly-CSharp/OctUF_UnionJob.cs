[global::Unity.Burst.BurstCompile(global::Unity.Burst.FloatPrecision.Low, global::Unity.Burst.FloatMode.Fast)]
[global::Cpp2ILInjected.Token(Token = "0x2000082")]
internal struct OctUF_UnionJob : global::Unity.Jobs.IJob
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400025B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> pos;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400025C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<int> octopusIds;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400025D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeMultiHashMap<int, int> cellMap;

	[global::Unity.Collections.NativeDisableParallelForRestriction]
	[global::Cpp2ILInjected.Token(Token = "0x400025E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<int> parent;

	[global::Cpp2ILInjected.Token(Token = "0x400025F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public int capacity;

	[global::Cpp2ILInjected.Token(Token = "0x4000260")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public int count;

	[global::Cpp2ILInjected.Token(Token = "0x6000251")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB02C", Offset = "0xFFB02C", Length = "0x40")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\nL_000D:\n\tv7 = *([p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]) != v32;\n\tif (v7) goto L_000D;\n\tv37 = x << 2;\n\tv71 = p + v37;\n\tv69 = *([v71 @ X8_v4]);\n\tv44 = *([v71 @ X8_v4]) == *([p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]);\n\tif (v44) goto L_002B;\nL_001C:\n\t*([v71 @ X8_v4]) = v32;\n\tv68 = v69 << 2;\n\tv71 = p + v68;\n\tv69 = *([v71 @ X8_v4]);\n\tv50 = *([v71 @ X8_v4]) != v32;\n\tif (v50) goto L_001C;\nL_002B:\n\treturn v32;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private static int Find(int x, global::Unity.Collections.NativeArray<int> p)
	{
		//IL_002b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0030: Expected O, but got Unknown
		//IL_0038: Expected I4, but got O
		//IL_0064: Expected O, but got I4
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		//IL_007f: Expected O, but got Unknown
		//IL_0087: Expected I4, but got O
		int num = x;
		int num2 = default(int);
		num = num2;
		bool flag;
		do
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]");
			flag = (nint)0 != num;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]");
			num = 0;
		}
		while (flag);
		int num3 = x << 2;
		object obj = p + num3;
		int num4 = (int)obj;
		object obj2 = obj;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [p @ X1 (Unity.Collections.NativeArray`1<System.Int32>)+v32 @ X9_v2 (System.Int32)*4]");
		if (obj2 != null)
		{
			do
			{
				obj = num;
				int num5 = num4 << 2;
				obj = p + num5;
				num4 = (int)obj;
			}
			while ((nint)obj != num);
		}
		return num;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000252")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB06C", Offset = "0xFFB06C", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\nL_0010:\n\tv75 = OctUF_UnionJob::Find(v67, v73);\n\tv79 = OctUF_UnionJob::Find(b, p);\n\tv84 = v75 == v79;\n\tif (v84) goto L_0048;\n\tv63 = v75 - v79;\n\tv60 = v63 < 0;\n\tv57 = v63 == 0;\n\tv54 = v75 ^ v79;\n\tv51 = v75 ^ v63;\n\tv48 = v54 & v51;\n\tv45 = v48 < 0;\n\tv90 = v60 == v45;\n\tv39 = ~v57;\n\tv91 = v90 & v39;\n\tv92 = ~v91;\n\tif (v92) goto L_0032;\n\tgoto L_0032;\nL_0032:\n\tv103 = v60 == v45;\n\tv42 = ~v103;\n\tv36 = ~v42;\n\tif (v36) goto L_FFFFFFFF;\n\tgoto L_003A;\nL_003A:\n\t*([p @ X2 (Unity.Collections.NativeArray`1<System.Int32>)+v33 @ X8_v2 (System.Int32)*4]) = v30;\n\tgoto L_0010;\nL_0048:\n\treturn;\n// 48 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private static void Union(int a, int b, global::Unity.Collections.NativeArray<int> p)
	{
		global::Unity.Collections.NativeArray<int> p2 = p;
		int x = default(int);
		while (true)
		{
			int num = Find(x, p2);
			int num2 = Find(b, p);
			if (num != num2)
			{
				int num3 = num - num2;
				bool flag = num3 < 0;
				bool flag2 = num3 == 0;
				int num4 = num ^ num2;
				int num5 = num ^ num3;
				int num6 = num4 & num5;
				bool flag3 = num6 < 0;
				bool flag4 = flag == flag3;
				bool flag5 = !flag2;
				if (flag4 && flag5)
				{
				}
				if (flag != flag3)
				{
					int num7 = num;
				}
				else
				{
					int num7 = num2;
				}
				p2 = p;
				continue;
			}
			break;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000253")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFB0EC", Offset = "0xFFB0EC", Length = "0x5E8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0024;\n\tv41 = Il2CppMethodInfo;\n\tv42 = v41 + 0xCC8;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv77 = Il2CppMethodInfo;\n\tv78 = v77 + 0xCD0;\n\tv79 = \"il2cpp_codegen_initialize_runtime_metadata\"(v78, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv195 = System.Runtime.Serialization.ObjectHolderList;\n\tv196 = v195 + 0xD20;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v196, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv62 = 1;\n\t*([302A9F1]) = v62;\nL_0024:\n\tv63 = 0;\n\tv177 = this.count;\n\tv76 = this.count < 1;\n\tif (v76) goto L_029C;\n\tv81 = System.Runtime.Serialization.ObjectHolderList;\n\tv83 = Il2CppMethodInfo;\n\tv85 = this + 0x20;\n\tv87 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_004C;\nL_003E:\n\tv177 = this.count;\nL_0040:\n\tv230 = v230 + 1;\n\tv103 = v230 >= v177;\n\tif (v103) goto L_029C;\nL_004C:\n\tv234 = this.octopusIds;\n\tv235 = *([v234 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]) + 1;\n\tv237 = v235 == 0;\n\tif (v237) goto L_0040;\n\tv241 = v230 << 3;\n\tv242 = this.pos + v241;\n\tv245 = *([v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv247 = *([v245 @ X0_v5+E0]) == 0;\n\tif (v247) goto L_0268;\n\tv291 = *([v245 @ X0_v5+B8]);\n\tv359 = *([v291 @ X8_v107]);\n\tv294 = *([2DD4429]) == 0;\n\tif (v294) goto L_0272;\nL_0062:\n\tv304 = *([v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv306 = *([v304 @ X0_v86+E0]) == 0;\n\tif (v306) goto L_027A;\nL_0067:\n\tv323 = *([v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv324 = *([v323 @ X9_v44+B8]);\n\tv357 = *([v324 @ X9_v45]);\n\tgoto L_006F;\nL_006F:\n\tgoto L_0070;\nL_0070:\n\tv372 = *([v242 @ X8_v8]) / v359;\n\tv373 = UnityEngine.Mathf::Floor(v372);\n\tv377 = *([v242 @ X8_v8+4]) / v357;\n\tv271 = UnityEngine.Mathf::Floor(v377);\n\tv392 = v373 != 0x7F800000;\n\tif (v392) goto L_FFFFFFFF;\n\tgoto L_008B;\nL_008B:\n\tv398 = v377 * 0x949475;\n\tv260 = v271 != 0x7F800000;\n\tif (v260) goto L_FFFFFFFF;\n\tgoto L_009D;\nL_009D:\n\tv413 = v410 + 0xFF6B6B8B;\n\tv414 = v410 + 0x949475;\n\tgoto L_00B0;\nL_00A4:\n\tv439 = v439 + 1;\n\tv282 = v439 == 2;\n\tif (v282) goto L_003E;\nL_00B0:\n\tv446 = v439 + v395;\n\tv259 = v446 * 0x3DCF;\n\tv449 = v413 + v259;\n\tv451 = v449 / this.capacity;\n\tv452 = v451 * this.capacity;\n\tv453 = v449 - v452;\n\tv454 = Il2CppMethodInfo;\n\tv461 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v85, v453, &v458 @ stack_-84_v5 (System.Int32), &v63 @ stack_-90_v1, *([v454 @ X8_v34 (Il2CppMethodInfo)+CC8]));\n\tv462 = v461 == 0;\n\tv463 = ~v462;\n\tif (v463) goto L_00F1;\nL_00C4:\n\tv513 = v410 + v259;\n\tv515 = v513 / this.capacity;\n\tv516 = v515 * this.capacity;\n\tv517 = v513 - v516;\n\tv518 = Il2CppMethodInfo;\n\tv525 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v85, v517, &v458 @ stack_-84_v5 (System.Int32), &v63 @ stack_-90_v1, *([v518 @ X8_v56 (Il2CppMethodInfo)+CC8]));\n\tv560 = v525 == 0;\n\tv561 = ~v560;\n\tif (v561) goto L_0172;\nL_00D4:\n\tv658 = v414 + v259;\n\tv660 = v658 / this.capacity;\n\tv661 = v660 * this.capacity;\n\tv662 = v658 - v661;\n\tv663 = Il2CppMethodInfo;\n\tv669 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v85, v662, &v458 @ stack_-84_v5 (System.Int32), &v63 @ stack_-90_v1, *([v663 @ X8_v78 (Il2CppMethodInfo)+CC8]));\n\tv708 = v669 == 0;\n\tv709 = ~v708;\n\tif (v709) goto L_01F3;\n\tgoto L_00A4;\nL_00E8:\n\tv507 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v85, &v458 @ stack_-84_v5 (System.Int32), &v63 @ stack_-90_v1, *([v83 @ X26_v3 (Il2CppMethodInfo)+CD0]));\n\tv707 = v507 & 1;\n\tv509 = v707 == 0;\n\tif (v509) goto L_00C4;\nL_00F1:\n\tv555 = v230 == v458;\n\tif (v555) goto L_00E8;\n\tv563 = this.octopusIds;\n\tv574 = *([v563 @ X9_v16 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]) != *([v234 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]);\n\tif (v574) goto L_00E8;\n\tv591 = v458 << 3;\n\tv704 = this.pos + v591;\n\tv706 = *([2DD4420]) == 0;\n\tif (v706) goto L_0156;\n\tv757 = *([v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv759 = *([v757 @ X0_v37+E0]) == 0;\n\tif (v759) goto L_015D;\nL_0111:\n\tv603 = *([v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tgoto L_0115;\nL_0115:\n\tv907 = *([v704 @ X8_v39+4]) - *([v242 @ X8_v8+4]);\n\tv908 = *([v704 @ X8_v39]) - *([v242 @ X8_v8]);\n\tv909 = v908 * v908;\n\tv910 = v907 * v907;\n\tv911 = v909 + v910;\n\tv588 = UnityEngine.Mathf::Sqrt(v911);\n\tv606 = *([v603 @ X0_v34+B8]);\n\tv575 = v588 >= *([v606 @ X8_v47]);\n\tif (v575) goto L_00E8;\n\tv607 = this.parent;\n\tv987 = *([v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]);\nL_0135:\n\tv974 = *([v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v987 @ X10_v11*4]) != v987;\n\tif (v974) goto L_0135;\n\tv1054 = *([v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]);\nL_013A:\n\tv1055 = *([v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v1054 @ X10_v15*4]);\n\tv576 = *([v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v1054 @ X10_v15*4]) != v1054;\n\tif (v576) goto L_013A;\n\tv597 = v987 == *([v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v1054 @ X10_v15*4]);\n\tif (v597) goto L_00E8;\n\t*([v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v1055 @ X10_v16*4]) = v987;\n\tgoto L_00E8;\nL_0156:\n\t*([2DD4420]) = 1;\n\tv825 = *([v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv838 = *([v825 @ X0_v33+E0]) == 0;\n\tv827 = ~v838;\n\tif (v827) goto L_0111;\nL_015D:\n\tv603 = *([v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tgoto L_0115;\n\tv913 = \"il2cpp_codegen_runtime_class_init\"(v912, v530, v529, v527, v456, v48, v49, v50, v538, v537, v271, v54, v55, v56, v57, v58);\n\tv901 = *([v82 @ X23_v4]);\n\tgoto L_0115;\nL_0169:\n\tv652 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v85, &v458 @ stack_-84_v5 (System.Int32), &v63 @ stack_-90_v1, *([v83 @ X26_v3 (Il2CppMethodInfo)+CD0]));\n\tv823 = v652 & 1;\n\tv654 = v823 == 0;\n\tif (v654) goto L_00D4;\nL_0172:\n\tv699 = v230 == v458;\n\tif (v699) goto L_0169;\n\tv711 = this.octopusIds;\n\tv722 = *([v711 @ X9_v25 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]) != *([v234 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]);\n\tif (v722) goto L_0169;\n\tv739 = v458 << 3;\n\tv820 = this.pos + v739;\n\tv822 = *([2DD4420]) == 0;\n\tif (v822) goto L_01D7;\n\tv895 = *([v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv897 = *([v895 @ X0_v57+E0]) == 0;\n\tif (v897) goto L_01DE;\nL_0192:\n\tv751 = *([v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tgoto L_0196;\nL_0196:\n\tv947 = *([v820 @ X8_v61+4]) - *([v242 @ X8_v8+4]);\n\tv948 = *([v820 @ X8_v61]) - *([v242 @ X8_v8]);\n\tv949 = v948 * v948;\n\tv950 = v947 * v947;\n\tv951 = v949 + v950;\n\tv736 = UnityEngine.Mathf::Sqrt(v951);\n\tv754 = *([v751 @ X0_v54+B8]);\n\tv723 = v736 >= *([v754 @ X8_v69]);\n\tif (v723) goto L_0169;\n\tv755 = this.parent;\n\tv1032 = *([v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]);\nL_01B6:\n\tv1023 = *([v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1032 @ X10_v23*4]) != v1032;\n\tif (v1023) goto L_01B6;\n\tv1101 = *([v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]);\nL_01BB:\n\tv1102 = *([v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1101 @ X10_v27*4]);\n\tv724 = *([v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1101 @ X10_v27*4]) != v1101;\n\tif (v724) goto L_01BB;\n\tv745 = v1032 == *([v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1101 @ X10_v27*4]);\n\tif (v7\n// ... truncated")]
	public unsafe void Execute()
	{
		//IL_0caf: Expected O, but got I4
		//IL_0013: Expected I, but got O
		//IL_0024: Expected O, but got Ref
		//IL_0032: Expected I, but got O
		//IL_0081: Expected O, but got I
		//IL_00b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bb: Expected O, but got Unknown
		//IL_00cb: Expected O, but got I
		//IL_0b84: Expected O, but got I
		//IL_0b94: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0100: Expected O, but got I
		//IL_0c32: Expected O, but got I
		//IL_0c42: Expected O, but got I
		//IL_0bea: Expected O, but got I
		//IL_0182: Expected O, but got I
		//IL_0192: Expected O, but got I
		//IL_0d64: Expected O, but got I8
		//IL_04ac: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b1: Expected O, but got Unknown
		//IL_063d: Expected O, but got I
		//IL_051b: Expected O, but got I
		//IL_04e6: Expected O, but got I
		//IL_0725: Unknown result type (might be due to invalid IL or missing references)
		//IL_072a: Expected O, but got Unknown
		//IL_0260: Expected O, but got I
		//IL_053d: Expected O, but got I
		//IL_0559: Expected O, but got I
		//IL_0568: Expected O, but got I
		//IL_0594: Expected O, but got I
		//IL_067d: Expected O, but got I
		//IL_08b6: Expected O, but got I
		//IL_0794: Expected O, but got I
		//IL_075f: Expected O, but got I
		//IL_099e: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a3: Expected O, but got Unknown
		//IL_05cf: Expected O, but got I
		//IL_07b6: Expected O, but got I
		//IL_07d2: Expected O, but got I
		//IL_07e1: Expected O, but got I
		//IL_080d: Expected O, but got I
		//IL_08f6: Expected O, but got I
		//IL_0b2f: Expected O, but got I
		//IL_0d92: Expected O, but got I
		//IL_0a0d: Expected O, but got I
		//IL_09d8: Expected O, but got I
		//IL_0848: Expected O, but got I
		//IL_0a2f: Expected O, but got I
		//IL_0a4b: Expected O, but got I
		//IL_0a5a: Expected O, but got I
		//IL_0a86: Expected O, but got I
		//IL_0b6f: Expected O, but got I
		//IL_05ec: Expected O, but got I
		//IL_0e10: Expected O, but got I
		//IL_0db0: Expected O, but got I
		//IL_0dd9: Expected O, but got I
		//IL_0ac1: Expected O, but got I
		//IL_0865: Expected O, but got I
		//IL_0e8e: Expected O, but got I
		//IL_0e2e: Expected O, but got I
		//IL_0e57: Expected O, but got I
		//IL_0ade: Expected O, but got I
		//IL_0eac: Expected O, but got I
		//IL_0ed5: Expected O, but got I
		object obj = 0;
		int num = count;
		if (count < 1)
		{
			return;
		}
		nint num3 = 0;
		object obj2 = (object)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 32));
		int num5 = 48054272;
		int num6 = 0;
		object obj17 = default(object);
		int num23 = default(int);
		object obj28 = default(object);
		object obj32 = default(object);
		object obj33 = default(object);
		object obj47 = default(object);
		object obj48 = default(object);
		object obj62 = default(object);
		do
		{
			global::Unity.Collections.NativeArray<int> nativeArray = octopusIds;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]");
			object obj3 = (nint)0 + (nint)1;
			object obj4;
			object obj7;
			object obj8;
			if (obj3 != null)
			{
				int num7 = num6 << 3;
				obj4 = pos + num7;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v5+E0]");
				if ((nint)0 != 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v245 @ X0_v5+B8]");
					object obj6 = 0;
					obj7 = obj6;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4429]");
					bool flag = (nint)0 == 0;
					obj8 = obj6;
					if (!flag)
					{
						goto IL_0135;
					}
				}
				else
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
					object obj9 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X0_v19+B8]");
					object obj10 = 0;
					obj7 = obj10;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X24_v5 (System.Int32)+429]");
					bool flag2 = (nint)0 == 0;
					bool flag3 = !flag2;
					obj8 = obj10;
					if (flag3)
					{
						goto IL_0135;
					}
				}
				_ = 1;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
				object obj11 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v317 @ X0_v17+E0]");
				bool flag4 = (nint)0 == 0;
				bool flag5 = !flag4;
				obj7 = obj8;
				if (flag5)
				{
					goto IL_0172;
				}
				goto IL_0c22;
			}
			goto IL_0cd8;
			IL_0172:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj12 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v323 @ X9_v44+B8]");
			object obj13 = 0;
			object obj14 = obj13;
			object obj15 = obj13;
			obj8 = obj7;
			goto IL_01b4;
			IL_0cd8:
			num6++;
			continue;
			IL_01b4:
			float f = (float)obj4 / (float)obj7;
			float num8 = global::UnityEngine.Mathf.Floor(f);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8+4]");
			float num9 = 0f / (float)obj14;
			float num10 = global::UnityEngine.Mathf.Floor(num9);
			float num11 = ((num8 != float.PositiveInfinity) ? num8 : -0f);
			float num12 = num9 * 1.364491E-38f;
			float num13 = ((num10 != float.PositiveInfinity) ? num12 : -0f);
			float num14 = num13 + -3.1292697E+38f;
			float num15 = num13 + 1.364491E-38f;
			object obj16 = 4294967295L;
			do
			{
				float num16 = (float)obj16 + num11;
				float num17 = num16 * 2.2173E-41f;
				float num18 = num14 + num17;
				float num19 = num18 / (float)capacity;
				float num20 = num19 * (float)capacity;
				float num21 = num18 - num20;
				nint num22 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8DC8 (Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue, and 1 more at this address)");
				if (obj17 != null)
				{
					do
					{
						object obj18;
						object obj21;
						if (num6 != num23)
						{
							global::Unity.Collections.NativeArray<int> nativeArray2 = octopusIds;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X9_v16 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]");
							nint num24 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]");
							if (num24 == 0)
							{
								int num25 = num23 << 3;
								obj18 = pos + num25;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
								if ((nint)0 != 0)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
									object obj19 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v757 @ X0_v37+E0]");
									if ((nint)0 != 0)
									{
										goto IL_050b;
									}
								}
								else
								{
									_ = 1;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
									object obj20 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v825 @ X0_v33+E0]");
									if ((nint)0 != 0)
									{
										goto IL_050b;
									}
								}
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
								obj21 = 0;
								goto IL_0520;
							}
						}
						goto IL_0409;
						IL_0409:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8E24 (Unity.Collections.NativeMultiHashMap`2::TryGetNextValue, and 1 more at this address)");
						continue;
						IL_050b:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						obj21 = 0;
						goto IL_0520;
						IL_0520:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v704 @ X8_v39+4]");
						nint num26 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8+4]");
						object obj22 = num26 - 0;
						object obj23 = obj18 - obj4;
						object obj24 = (nint)obj23 * (nint)obj23;
						object obj25 = (nint)obj22 * (nint)obj22;
						float f2 = (float)obj24 + (float)obj25;
						float num27 = global::UnityEngine.Mathf.Sqrt(f2);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v603 @ X0_v34+B8]");
						object obj26 = 0;
						if (num27 < (float)obj26)
						{
							global::Unity.Collections.NativeArray<int> nativeArray3 = parent;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]");
							object obj27 = 0;
							obj27 = obj28;
							bool flag6;
							do
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v987 @ X10_v11*4]");
								flag6 = 0 != (nint)obj27;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v987 @ X10_v11*4]");
								obj27 = 0;
							}
							while (flag6);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]");
							object obj29 = 0;
							obj29 = obj28;
							bool flag7;
							do
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v1054 @ X10_v15*4]");
								object obj30 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v1054 @ X10_v15*4]");
								flag7 = 0 != (nint)obj29;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v1054 @ X10_v15*4]");
								obj29 = 0;
							}
							while (flag7);
							object obj31 = obj27;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v607 @ X8_v48 (Unity.Collections.NativeArray`1<System.Int32>)+v1054 @ X10_v15*4]");
							if (obj31 == null)
							{
							}
						}
						goto IL_0409;
					}
					while ((int)((nint)obj32 & 1) != 0);
				}
				float num28 = num13 + num17;
				float num29 = num28 / (float)capacity;
				float num30 = num29 * (float)capacity;
				float num31 = num28 - num30;
				nint num32 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8DC8 (Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue, and 1 more at this address)");
				if (obj33 != null)
				{
					do
					{
						object obj34;
						object obj37;
						if (num6 != num23)
						{
							global::Unity.Collections.NativeArray<int> nativeArray4 = octopusIds;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v711 @ X9_v25 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]");
							nint num33 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]");
							if (num33 == 0)
							{
								int num34 = num23 << 3;
								obj34 = pos + num34;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
								if ((nint)0 != 0)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
									object obj35 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v895 @ X0_v57+E0]");
									if ((nint)0 != 0)
									{
										goto IL_0784;
									}
								}
								else
								{
									_ = 1;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
									object obj36 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v920 @ X0_v53+E0]");
									if ((nint)0 != 0)
									{
										goto IL_0784;
									}
								}
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
								obj37 = 0;
								goto IL_0799;
							}
						}
						goto IL_0682;
						IL_0682:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8E24 (Unity.Collections.NativeMultiHashMap`2::TryGetNextValue, and 1 more at this address)");
						continue;
						IL_0784:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						obj37 = 0;
						goto IL_0799;
						IL_0799:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X8_v61+4]");
						nint num35 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8+4]");
						object obj38 = num35 - 0;
						object obj39 = obj34 - obj4;
						object obj40 = (nint)obj39 * (nint)obj39;
						object obj41 = (nint)obj38 * (nint)obj38;
						float f3 = (float)obj40 + (float)obj41;
						float num36 = global::UnityEngine.Mathf.Sqrt(f3);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X0_v54+B8]");
						object obj42 = 0;
						if (num36 < (float)obj42)
						{
							global::Unity.Collections.NativeArray<int> nativeArray5 = parent;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]");
							object obj43 = 0;
							obj43 = obj28;
							bool flag8;
							do
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1032 @ X10_v23*4]");
								flag8 = 0 != (nint)obj43;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1032 @ X10_v23*4]");
								obj43 = 0;
							}
							while (flag8);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]");
							object obj44 = 0;
							obj44 = obj28;
							bool flag9;
							do
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1101 @ X10_v27*4]");
								object obj45 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1101 @ X10_v27*4]");
								flag9 = 0 != (nint)obj44;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1101 @ X10_v27*4]");
								obj44 = 0;
							}
							while (flag9);
							object obj46 = obj43;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v755 @ X8_v70 (Unity.Collections.NativeArray`1<System.Int32>)+v1101 @ X10_v27*4]");
							if (obj46 == null)
							{
							}
						}
						goto IL_0682;
					}
					while ((int)((nint)obj47 & 1) != 0);
				}
				float num37 = num15 + num17;
				float num38 = num37 / (float)capacity;
				float num39 = num38 * (float)capacity;
				float num40 = num37 - num39;
				nint num41 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8DC8 (Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue, and 1 more at this address)");
				if (obj48 != null)
				{
					do
					{
						object obj49;
						object obj52;
						if (num6 != num23)
						{
							global::Unity.Collections.NativeArray<int> nativeArray6 = octopusIds;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v849 @ X9_v34 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]");
							nint num42 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X9_v3 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]");
							if (num42 == 0)
							{
								int num43 = num23 << 3;
								obj49 = pos + num43;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
								if ((nint)0 != 0)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
									object obj50 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v935 @ X0_v77+E0]");
									if ((nint)0 != 0)
									{
										goto IL_09fd;
									}
								}
								else
								{
									_ = 1;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
									object obj51 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v957 @ X0_v73+E0]");
									if ((nint)0 != 0)
									{
										goto IL_09fd;
									}
								}
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
								obj52 = 0;
								goto IL_0a12;
							}
						}
						goto IL_08fb;
						IL_08fb:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8E24 (Unity.Collections.NativeMultiHashMap`2::TryGetNextValue, and 1 more at this address)");
						continue;
						IL_09fd:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						obj52 = 0;
						goto IL_0a12;
						IL_0a12:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v915 @ X8_v83+4]");
						nint num44 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v242 @ X8_v8+4]");
						object obj53 = num44 - 0;
						object obj54 = obj49 - obj4;
						object obj55 = (nint)obj54 * (nint)obj54;
						object obj56 = (nint)obj53 * (nint)obj53;
						float f4 = (float)obj55 + (float)obj56;
						float num45 = global::UnityEngine.Mathf.Sqrt(f4);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v889 @ X0_v74+B8]");
						object obj57 = 0;
						if (num45 < (float)obj57)
						{
							global::Unity.Collections.NativeArray<int> nativeArray7 = parent;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v92 (Unity.Collections.NativeArray`1<System.Int32>)+v230 @ X22_v4 (System.Int32)*4]");
							object obj58 = 0;
							obj58 = obj28;
							bool flag10;
							do
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v92 (Unity.Collections.NativeArray`1<System.Int32>)+v1079 @ X10_v35*4]");
								flag10 = 0 != (nint)obj58;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v92 (Unity.Collections.NativeArray`1<System.Int32>)+v1079 @ X10_v35*4]");
								obj58 = 0;
							}
							while (flag10);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v92 (Unity.Collections.NativeArray`1<System.Int32>)+v458 @ stack_-84_v5 (System.Int32)*4]");
							object obj59 = 0;
							obj59 = obj28;
							bool flag11;
							do
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v92 (Unity.Collections.NativeArray`1<System.Int32>)+v1125 @ X10_v39*4]");
								object obj60 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v92 (Unity.Collections.NativeArray`1<System.Int32>)+v1125 @ X10_v39*4]");
								flag11 = 0 != (nint)obj59;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v92 (Unity.Collections.NativeArray`1<System.Int32>)+v1125 @ X10_v39*4]");
								obj59 = 0;
							}
							while (flag11);
							object obj61 = obj58;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v893 @ X8_v92 (Unity.Collections.NativeArray`1<System.Int32>)+v1125 @ X10_v39*4]");
							if (obj61 == null)
							{
							}
						}
						goto IL_08fb;
					}
					while ((int)((nint)obj62 & 1) != 0);
				}
				obj16 = (nint)obj16 + 1;
			}
			while ((nint)obj16 != 2);
			num = count;
			num5 = 48054272;
			goto IL_0cd8;
			IL_0c22:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj63 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X9_v7+B8]");
			object obj64 = 0;
			obj14 = obj64;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X24_v5 (System.Int32)+429]");
			bool flag12 = (nint)0 == 0;
			bool flag13 = !flag12;
			obj7 = obj8;
			obj15 = obj64;
			if (!flag13)
			{
				_ = 1;
				obj14 = obj15;
				obj7 = obj8;
			}
			goto IL_01b4;
			IL_0135:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
			object obj65 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X0_v86+E0]");
			bool flag14 = (nint)0 == 0;
			obj8 = obj7;
			if (!flag14)
			{
				goto IL_0172;
			}
			goto IL_0c22;
		}
		while (num6 < num);
	}
}
