[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000076")]
public struct PressureJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000204")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> predicted;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000205")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> densities;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000206")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeMultiHashMap<int, int> cellMap;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000207")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<int> particleTypes;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000208")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::Unity.Collections.NativeArray<bool> isHoneyCoated;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000209")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public global::Unity.Collections.NativeHashMap<ulong, byte> ignorePairs;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400020A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public global::Unity.Collections.NativeArray<int> powerUpIds;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400020B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public global::Unity.Collections.NativeArray<bool> isWater;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400020C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public global::Unity.Collections.NativeArray<int> clumpIds;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400020D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public global::Unity.Collections.NativeArray<int> fishIds;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400020E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public global::Unity.Collections.NativeArray<float> nearPressureMultipliers;

	[global::Cpp2ILInjected.Token(Token = "0x400020F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Cpp2ILInjected.Token(Token = "0x4000210")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	public float interFluidRepelStr;

	[global::Cpp2ILInjected.Token(Token = "0x4000211")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public float honeyRepelStr;

	[global::Cpp2ILInjected.Token(Token = "0x4000212")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public float clumpRepelStrength;

	[global::Cpp2ILInjected.Token(Token = "0x4000213")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xCC")]
	public float waterReactionGlobal;

	[global::Cpp2ILInjected.Token(Token = "0x4000214")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public float pressureMultiplier;

	[global::Cpp2ILInjected.Token(Token = "0x4000215")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD4")]
	public float targetDensity;

	[global::Cpp2ILInjected.Token(Token = "0x4000216")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public float dt;

	[global::Cpp2ILInjected.Token(Token = "0x4000217")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	public int capacity;

	[global::Cpp2ILInjected.Token(Token = "0x6000245")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF94CC", Offset = "0xFF94CC", Length = "0x7D0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv48 = System.Xml.ValidateNames;\n\tv50 = System.Runtime.Serialization.ObjectHolderList;\n\tgoto L_0033;\n\tv55 = Il2CppMethodInfo;\n\tv56 = v55 + 0xC80;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv100 = Il2CppMethodInfo;\n\tv101 = v100 + 0xCC8;\n\tv102 = \"il2cpp_codegen_initialize_runtime_metadata\"(v101, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv113 = Il2CppMethodInfo;\n\tv114 = v113 + 0xCD0;\n\tv115 = \"il2cpp_codegen_initialize_runtime_metadata\"(v114, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv125 = System.Runtime.Serialization.ObjectHolderList;\n\tv126 = v125 + 0xD20;\n\tv127 = \"il2cpp_codegen_initialize_runtime_metadata\"(v126, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv146 = System.Xml.ValidateNames;\n\tv147 = v146 + 0xD40;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v147, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv75 = 1;\n\t*([302A9E9]) = v75;\nL_0033:\n\tv76 = 0;\n\tv78 = this.predicted;\n\tv79 = i & 0xFFFFFFFF;\n\tv80 = v79 << 3;\n\tv84 = this.densities + v80;\n\tv93 = *([v48 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv94 = *([v93 @ X8_v7+B8]);\n\tv436 = *([v94 @ X8_v8]);\n\tv104 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tgoto L_0050;\n\tv103 = \"il2cpp_codegen_runtime_class_init\"(v96, i, methodInfo, v59, v60, v61, v62, v63, v90, v65, v66, v67, v68, v69, v70, v71);\n\tv105 = *([v51 @ X21_v2]);\nL_0050:\n\tv108 = *([v104 @ X0_v3+B8]);\n\tv112 = *([2DD4429]) == 0;\n\tif (v112) goto L_0063;\n\tv117 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv119 = *([v117 @ X8_v131 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv121 = *([v119 @ X0_v90+E0]) == 0;\n\tif (v121) goto L_FFFFFFFF;\n\tgoto L_0078;\nL_0063:\n\t*([2DD4429]) = 1;\n\tv143 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv131 = *([v143 @ X8_v126 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv145 = *([v131 @ X0_v88+E0]) == 0;\n\tv133 = ~v145;\n\tif (v133) goto L_FFFFFFFF;\nL_0078:\n\tv177 = UnityEngine.Mathf::Max(*([v84 @ X8_v5]), v172);\n\tv182 = *([v78 @ X8_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v80 @ X9_v1 (System.Int32)]) / *([v108 @ X8_v10]);\n\tv183 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv184 = *([v183 @ X9_v2+B8]);\n\tgoto L_0087;\n\tv189 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv190 = v189 + 0x918;\n\tv191 = \"il2cpp_codegen_initialize_runtime_metadata\"(v190, i, methodInfo, v59, v60, v61, v62, v63, v181, v65, v66, v67, v68, v69, v70, v71);\n\tv194 = 1;\n\t*([2DD4429]) = v194;\nL_0087:\n\tv195 = UnityEngine.Mathf::Max(*([v84 @ X8_v5+4]), v172);\n\tv198 = UnityEngine.Mathf::Floor(v182);\n\tv203 = v187 / *([v184 @ X9_v3]);\n\tgoto L_0094;\n\tv206 = \"il2cpp_codegen_runtime_class_init\"(v201, i, methodInfo, v59, v60, v61, v62, v63, v181, v65, v66, v67, v68, v69, v70, v71);\nL_0094:\n\tv208 = Il2CppMethodInfo;\n\tv216 = UnityEngine.Mathf::Floor(v203);\n\tv219 = this.isWater;\n\tv221 = this.fishIds;\n\tv223 = *([v221 @ X10_v2 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) + 1;\n\tv225 = v223 == 0;\n\tv228 = ~v225;\n\tv242 = v198 != 0x7F800000;\n\tif (v242) goto L_FFFFFFFF;\n\tgoto L_00C6;\nL_00C6:\n\tv256 = v216 != 0x7F800000;\n\tif (v256) goto L_FFFFFFFF;\n\tgoto L_00CD;\nL_00CD:\n\tv261 = this + 0x20;\n\tv262 = this + 0x50;\n\tv264 = *([v219 @ X10_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) | v228;\n\tgoto L_00E6;\nL_00D9:\n\tv330 = v330 + 1;\n\tv345 = v330 == 2;\n\tif (v345) goto L_032C;\nL_00E6:\n\tv361 = v330 + v245;\n\tv363 = v361 * 0x3DCF;\n\tgoto L_00F9;\nL_00EC:\n\tv382 = v382 + 1;\n\tv402 = v382 == 2;\n\tif (v402) goto L_00D9;\nL_00F9:\n\tv415 = v382 + v259;\n\tv418 = v415 * 0x949475;\n\tv419 = v363 + v418;\n\tv421 = v419 / this.capacity;\n\tv422 = v421 * this.capacity;\n\tv423 = v419 - v422;\n\tv424 = Il2CppMethodInfo;\n\tv430 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v261, v423, &v427 @ stack_-AC_v3 (System.Int32), &v76 @ stack_-B8_v1, *([v424 @ X8_v30 (Il2CppMethodInfo)+CC8]));\n\tv431 = v430 == 0;\n\tv432 = ~v431;\n\tif (v432) goto L_0121;\n\tgoto L_00EC;\nL_010E:\n\tv972 = v600 * v973;\n\tv975 = this.honeyRepelStr;\nL_0111:\n\tv1042 = v580 * v741;\n\tv601 = v1042 * v739;\n\tv537 = v436 - v601;\nL_0118:\n\tv502 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v261, &v427 @ stack_-AC_v3 (System.Int32), &v76 @ stack_-B8_v1, *([v208 @ X27_v1 (Il2CppMethodInfo)+CD0]));\n\tv731 = v502 & 1;\n\tv504 = v731 == 0;\n\tif (v504) goto L_00EC;\nL_0121:\n\tv512 = v427 == i;\n\tif (v512) goto L_0118;\n\tv526 = this.powerUpIds;\n\tv529 = *([v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) + 1;\n\tv531 = v529 == 0;\n\tv534 = ~v531;\n\tv535 = ~v534;\n\tif (v535) goto L_FFFFFFFF;\n\tv720 = *([v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]) - -1;\n\tv648 = v720 == 0;\n\tgoto L_FFFFFFFF;\n\tif (v648) goto L_014F;\n\tv564 = *([v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]) | *([v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]);\n\tv690 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::ContainsKey(v262, v564);\n\tv774 = v690 == 0;\n\tv698 = ~v774;\n\tif (v698) goto L_0118;\nL_014F:\n\tv771 = v264 == 0;\n\tv772 = ~v771;\n\tif (v772) goto L_0153;\nL_0153:\n\tv777 = this.isWater;\n\tv566 = *([v219 @ X10_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) != *([v777 @ X9_v15 (Unity.Collections.NativeArray`1<System.Boolean>)+v768 @ X8_v35 (System.Int32)]);\n\tif (v566) goto L_0165;\n\tgoto L_0165;\nL_0165:\n\tv595 = this.predicted;\n\tv792 = *([2DD4420]) == 0;\n\tif (v792) goto L_0204;\n\tv793 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv795 = *([v793 @ X8_v109 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv797 = *([v795 @ X0_v75+E0]) == 0;\n\tif (v797) goto L_020D;\nL_0170:\n\tv691 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tgoto L_0175;\nL_0175:\n\tv581 = *([v595 @ X9_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v768 @ X8_v35 (System.Int32)*8]) - *([v78 @ X8_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v80 @ X9_v1 (System.Int32)]);\n\tv826 = v581 * v581;\n\t// 375 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv926 = UnityEngine.Mathf::Sqrt(v826);\n\tv706 = *([v691 @ X0_v27+B8]);\n\tv568 = v926 >= *([v706 @ X8_v45]);\n\tif (v568) goto L_0118;\n\tv834 = v926 < 0;\n\tv835 = v926 == 0;\n\tv837 = v926 ^ v926;\n\tv838 = v926 & v837;\n\tv839 = v838 < 0;\n\t// 399 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv582 = v581 / v456;\n\tv840 = v834 == v839;\n\tv841 = ~v840;\n\tv842 = v841 | v835;\n\tv565 = ~v842;\n\tif (v565) goto L_FFFFFFFF;\n\tgoto L_019A;\nL_019A:\n\tv845 = this.isHoneyCoated;\n\tv856 = *([v845 @ X9_v18 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) != *([v845 @ X9_v18 (Unity.Collections.NativeArray`1<System.Boolean>)+v427 @ stack_-AC_v3 (System.Int32)]);\n\tif (v856) goto L_0216;\n\tv857 = this.particleTypes;\n\tv867 = *([v857 @ X9_v21 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) != *([v857 @ X9_v21 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]);\n\tif (v867) goto L_0228;\n\tv868 = this.clumpIds;\n\tv878 = *([v868 @ X9_v23 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) != *([v868 @ X9_v23 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]);\n\tif (v878) goto L_0257;\n\tv550 = v427 << 3;\n\tv884 = this.densities + v550;\n\tv889 = *([v691 @ X0_v27+E0]) == 0;\n\tif (v889) goto L_028D;\n\tv899 = *([2DD442C]) == 0;\n\tif (v899) goto L_0295;\nL_01D8:\n\tv1175 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv935 = *([v1175 @ X0_v67+E0]) == 0;\n\tif (v935) goto L_029D;\nL_01DC:\n\tv986 = *([v1175 @ X0_v67+B8]);\n\tv998 = *([v986 @ X\n// ... truncated")]
	public unsafe void Execute(int i)
	{
		//IL_000e: Expected I, but got O
		//IL_001c: Expected I, but got O
		//IL_0a43: Expected O, but got I4
		//IL_0a5f: Expected I4, but got I8
		//IL_0a77: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected O, but got Unknown
		//IL_0a8c: Expected O, but got I
		//IL_0a9c: Expected O, but got I
		//IL_0aa4: Expected F8, but got O
		//IL_0ab4: Expected O, but got I
		//IL_0dc2: Expected O, but got I
		//IL_0098: Expected I, but got O
		//IL_00a8: Expected O, but got I
		//IL_002f: Expected I, but got O
		//IL_003f: Expected O, but got I
		//IL_0ac6: Expected F4, but got O
		//IL_0af1: Expected O, but got I
		//IL_0b01: Expected O, but got I
		//IL_0b1b: Expected F4, but got I
		//IL_0135: Expected O, but got I
		//IL_0b6d: Expected O, but got Ref
		//IL_0b78: Expected O, but got Ref
		//IL_0b9a: Expected O, but got I8
		//IL_020f: Expected O, but got I8
		//IL_0223: Expected O, but got I
		//IL_0365: Expected O, but got I
		//IL_01b6: Expected O, but got I
		//IL_03ae: Expected O, but got I
		//IL_0e13: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Expected O, but got Unknown
		//IL_0e27: Expected O, but got I
		//IL_03ed: Expected I8, but got I
		//IL_07b6: Expected I, but got O
		//IL_07c6: Expected O, but got I
		//IL_048d: Expected O, but got I
		//IL_0448: Expected I, but got O
		//IL_0458: Expected O, but got I
		//IL_04e7: Expected O, but got I
		//IL_0806: Expected O, but got I
		//IL_0537: Expected O, but got F4
		//IL_0540: Unknown result type (might be due to invalid IL or missing references)
		//IL_0545: Expected I4, but got Unknown
		//IL_0655: Unknown result type (might be due to invalid IL or missing references)
		//IL_065a: Expected O, but got Unknown
		//IL_06b4: Expected O, but got I
		//IL_093a: Expected O, but got I
		//IL_094a: Expected O, but got I
		//IL_08f2: Expected O, but got I
		//IL_06f1: Expected O, but got I
		//IL_099b: Expected O, but got I
		//IL_077c: Expected O, but got I
		//IL_0caa: Expected F4, but got O
		//IL_0cc4: Expected F4, but got I
		nint num = (nint)typeof(global::System.Xml.ValidateNames);
		nint num2 = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		object obj = 0;
		global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray = predicted;
		int num3 = (int)(i & 0xFFFFFFFFL);
		int num4 = num3 << 3;
		object obj2 = densities + num4;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+D40]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X8_v7+B8]");
		object obj4 = 0;
		double num5 = (double)obj4;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v104 @ X0_v3+B8]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4429]");
		int num7;
		int num8;
		if ((nint)0 != 0)
		{
			nint num6 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X8_v131 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
			object obj7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v90+E0]");
			bool flag = (nint)0 == 0;
			num7 = 897988541;
			num8 = 897988541;
			if (!flag)
			{
				goto IL_0076;
			}
		}
		else
		{
			_ = 1;
			nint num9 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v126 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
			object obj8 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v88+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			num7 = 897988541;
			num8 = 897988541;
			if (flag3)
			{
				goto IL_0076;
			}
		}
		float b = num8;
		goto IL_0ab9;
		IL_0ab9:
		float num10 = global::UnityEngine.Mathf.Max((float)obj2, b);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v80 @ X9_v1 (System.Int32)]");
		float f = 0f / (float)obj6;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X9_v2+B8]");
		object obj10 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v5+4]");
		float num11 = global::UnityEngine.Mathf.Max(0f, b);
		float num12 = global::UnityEngine.Mathf.Floor(f);
		object obj11 = default(object);
		float num13 = (float)obj11 / (float)obj10;
		nint num14 = 0;
		float num15 = global::UnityEngine.Mathf.Floor(num13);
		global::Unity.Collections.NativeArray<bool> nativeArray2 = isWater;
		global::Unity.Collections.NativeArray<int> nativeArray3 = fishIds;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X10_v2 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]");
		object obj12 = (nint)0 + (nint)1;
		bool flag4 = obj12 == null;
		bool flag5 = !flag4;
		float num16 = ((num12 != float.PositiveInfinity) ? num12 : -0f);
		float num17 = ((num15 != float.PositiveInfinity) ? num13 : -0f);
		object obj13 = (object)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 32));
		global::Unity.Collections.NativeHashMap<ulong, byte> nativeParallelHashMap = (global::Unity.Collections.NativeHashMap<ulong, byte>)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 80));
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]");
		int num18 = (int)((nint)0 | (nint)(flag5 ? 1 : 0));
		object obj14 = 4294967295L;
		object obj16 = default(object);
		double num28;
		double num30 = default(double);
		int num31 = default(int);
		float num37 = default(float);
		object obj23 = default(object);
		object obj25 = default(object);
		double num39 = default(double);
		object obj33 = default(object);
		object obj34 = default(object);
		bool flag23;
		do
		{
			float num19 = (float)obj14 + num16;
			float num20 = num19 * 2.2173E-41f;
			object obj15 = 4294967295L;
			double num29;
			bool flag22;
			do
			{
				float num21 = (float)obj15 + num17;
				float num22 = num21 * 1.364491E-38f;
				float num23 = num20 + num22;
				float num24 = num23 / (float)capacity;
				float num25 = num24 * (float)capacity;
				float num26 = num23 - num25;
				nint num27 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8DC8 (Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue, and 1 more at this address)");
				if (obj16 == null)
				{
					num28 = num5;
					num29 = num30;
				}
				else
				{
					bool flag21;
					do
					{
						object obj21;
						if (num31 != i)
						{
							global::Unity.Collections.NativeArray<int> nativeArray4 = powerUpIds;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]");
							object obj17 = (nint)0 + (nint)1;
							bool flag6;
							if (obj17 != null)
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]");
								object obj18 = --1;
								flag6 = obj18 == null;
							}
							else
							{
								flag6 = true;
							}
							int num32 = num31;
							if (!flag6)
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]");
								nint num33 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]");
								ulong key = (ulong)(num33 | 0);
								if (((global::Unity.Collections.NativeHashMap<ulong, byte>*)nativeParallelHashMap)->ContainsKey(key))
								{
									goto IL_0b9f;
								}
								num32 = num31;
							}
							if (num18 != 0)
							{
								global::Unity.Collections.NativeArray<bool> nativeArray5 = isWater;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X10_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]");
								nint num34 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v777 @ X9_v15 (Unity.Collections.NativeArray`1<System.Boolean>)+v768 @ X8_v35 (System.Int32)]");
								if (num34 == 0)
								{
								}
								global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray6 = predicted;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
								if ((nint)0 != 0)
								{
									nint num35 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v793 @ X8_v109 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
									object obj19 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X0_v75+E0]");
									if ((nint)0 != 0)
									{
										goto IL_047d;
									}
								}
								else
								{
									_ = 1;
									nint num36 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v815 @ X8_v41 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
									object obj20 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v802 @ X0_v26+E0]");
									if ((nint)0 != 0)
									{
										goto IL_047d;
									}
								}
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
								obj21 = 0;
								goto IL_0492;
							}
							object obj22 = num37 * (nint)obj23;
							object obj24 = (nint)obj22 * (nint)obj25;
							double num38 = num5 - (double)obj24;
							num5 = num38;
							num30 = num39;
						}
						goto IL_0b9f;
						IL_0747:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X0_v67+E0]");
						if ((nint)0 != 0)
						{
							goto IL_076c;
						}
						goto IL_0c9c;
						IL_0492:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v595 @ X9_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v768 @ X8_v35 (System.Int32)*8]");
						float num40 = 0f;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v80 @ X9_v1 (System.Int32)]");
						float num41 = num40 - 0f;
						float f2 = num41 * num41;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
						float num42 = global::UnityEngine.Mathf.Sqrt(f2);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v27+B8]");
						object obj26 = 0;
						double num45;
						object obj28;
						float num50;
						object obj29;
						if (num42 < (float)obj26)
						{
							bool flag7 = num42 < 0f;
							bool flag8 = num42 == 0f;
							object obj27 = num42 ^ num42;
							int num43 = num42 & (nint)obj27;
							bool flag9 = num43 < 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
							double num44 = (double)num41 / num30;
							bool flag10 = flag7 == flag9;
							bool flag11 = !flag10;
							num45 = ((!(flag11 || flag8)) ? num44 : (1.0 / 128.0));
							global::Unity.Collections.NativeArray<bool> nativeArray7 = isHoneyCoated;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X9_v18 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]");
							nint num46 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v845 @ X9_v18 (Unity.Collections.NativeArray`1<System.Boolean>)+v427 @ stack_-AC_v3 (System.Int32)]");
							if (num46 == 0)
							{
								global::Unity.Collections.NativeArray<int> nativeArray8 = particleTypes;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X9_v21 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]");
								nint num47 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v857 @ X9_v21 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]");
								if (num47 == 0)
								{
									global::Unity.Collections.NativeArray<int> nativeArray9 = clumpIds;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X9_v23 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]");
									nint num48 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v868 @ X9_v23 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]");
									if (num48 == 0)
									{
										int num49 = num31 << 3;
										obj28 = densities + num49;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v27+E0]");
										if ((nint)0 != 0)
										{
											global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD442C]");
											if ((nint)0 != 0)
											{
												goto IL_06a4;
											}
										}
										else
										{
											global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD442C]");
											if ((nint)0 != 0)
											{
												goto IL_06a4;
											}
										}
										_ = 1;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
										obj29 = 0;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X0_v67+E0]");
										bool flag12 = (nint)0 == 0;
										bool flag13 = !flag12;
										num50 = num42;
										if (flag13)
										{
											goto IL_06e1;
										}
										goto IL_092a;
									}
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v27+E0]");
									if ((nint)0 == 0)
									{
									}
								}
								else
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v27+E0]");
									if ((nint)0 == 0)
									{
									}
								}
							}
							else
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v691 @ X0_v27+E0]");
								if ((nint)0 == 0)
								{
								}
							}
						}
						goto IL_0b9f;
						IL_06a4:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						obj29 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X0_v67+E0]");
						bool flag14 = (nint)0 == 0;
						num50 = num42;
						if (!flag14)
						{
							goto IL_06e1;
						}
						goto IL_092a;
						IL_047d:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						obj21 = 0;
						goto IL_0492;
						IL_0d45:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD442D]");
						bool flag15 = (nint)0 == 0;
						bool flag16 = !flag15;
						float num51;
						num50 = num51;
						object obj30;
						obj29 = obj30;
						if (flag16)
						{
							goto IL_0747;
						}
						goto IL_0985;
						IL_06e1:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X0_v67+B8]");
						object obj31 = 0;
						bool flag17 = !((float)obj31 < num50);
						num51 = num50;
						obj30 = obj29;
						if (!flag17)
						{
							goto IL_0722;
						}
						goto IL_0d45;
						IL_092a:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						obj29 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X0_v67+B8]");
						object obj32 = 0;
						bool flag18 = (float)obj32 < num42;
						num50 = num42;
						num51 = num42;
						obj30 = obj29;
						if (flag18)
						{
							goto IL_0722;
						}
						goto IL_0d45;
						IL_0722:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD442D]");
						if ((nint)0 != 0)
						{
							goto IL_0747;
						}
						goto IL_0985;
						IL_0985:
						_ = 1;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
						obj29 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X0_v67+E0]");
						bool flag19 = (nint)0 == 0;
						bool flag20 = !flag19;
						num50 = num42;
						if (flag20)
						{
							goto IL_076c;
						}
						goto IL_0c9c;
						IL_0c9c:
						float num52 = global::UnityEngine.Mathf.Max((float)obj28, 1E-06f);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X9_v26+4]");
						float num53 = global::UnityEngine.Mathf.Max(0f, 1E-06f);
						double num54 = num45 * (double)obj33;
						double num55 = num54 * (double)obj25;
						num30 = num5 + num55;
						double num56 = num54 * (double)obj23;
						num5 = num30 + num56;
						goto IL_0b9f;
						IL_0b9f:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8E24 (Unity.Collections.NativeMultiHashMap`2::TryGetNextValue, and 1 more at this address)");
						int num57 = (int)((nint)obj34 & 1);
						flag21 = num57 == 0;
						num28 = num5;
						num29 = num30;
						continue;
						IL_076c:
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1175 @ X0_v67+B8]");
						object obj35 = 0;
						if (!((float)obj35 < num50))
						{
						}
						goto IL_0c9c;
					}
					while (!flag21);
				}
				obj15 = (nint)obj15 + 1;
				flag22 = (nint)obj15 == 2;
				num5 = num28;
				num30 = num29;
			}
			while (!flag22);
			obj14 = (nint)obj14 + 1;
			flag23 = (nint)obj14 == 2;
			num5 = num28;
			num30 = num29;
		}
		while (!flag23);
		global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray10 = deltaVel;
		int num58 = i << 3;
		double num59 = num28 * (double)obj25;
		double num60 = num59 * (double)obj23;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v734 @ X8_v116 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v735 @ X9_v45 (System.Int32)]");
		double num61 = 0.0 + num60;
		return;
		IL_0076:
		b = num7;
		goto IL_0ab9;
	}
}
