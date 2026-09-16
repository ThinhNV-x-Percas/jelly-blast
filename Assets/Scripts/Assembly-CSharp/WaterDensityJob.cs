[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x200007E")]
public struct WaterDensityJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000247")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> predicted;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000248")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeMultiHashMap<int, int> cellMap;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000249")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeArray<bool> isWater;

	[global::Cpp2ILInjected.Token(Token = "0x400024A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<float> waterDensities;

	[global::Cpp2ILInjected.Token(Token = "0x400024B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float mass;

	[global::Cpp2ILInjected.Token(Token = "0x400024C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public int capacity;

	[global::Cpp2ILInjected.Token(Token = "0x600024D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFA66C", Offset = "0xFFA66C", Length = "0x3D4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv44 = System.Runtime.Serialization.ObjectHolderList;\n\tgoto L_0029;\n\tv49 = Il2CppMethodInfo;\n\tv50 = v49 + 0xCC8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, i, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv80 = Il2CppMethodInfo;\n\tv81 = v80 + 0xCD0;\n\tv82 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, i, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv89 = System.Runtime.Serialization.ObjectHolderList;\n\tv90 = v89 + 0xD20;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v90, i, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\n\tv69 = 1;\n\t*([302A9EF]) = v69;\nL_0029:\n\tv70 = 0;\n\tv73 = i << 3;\n\tv74 = this.predicted + v73;\n\tv77 = *([v44 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv79 = *([v77 @ X0_v2+E0]) == 0;\n\tif (v79) goto L_015B;\n\tv83 = *([v77 @ X0_v2+B8]);\n\tv117 = *([v83 @ X8_v71]);\n\tv87 = *([2DD4429]) == 0;\n\tif (v87) goto L_0167;\nL_003A:\n\tv101 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv178 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv103 = *([v101 @ X21_v9 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv105 = *([v103 @ X0_v59+E0]) == 0;\n\tif (v105) goto L_0175;\nL_0041:\n\tv171 = *([v74 @ X8_v4]) / v117;\n\tv128 = *([v44 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv129 = *([v128 @ X9_v24+B8]);\n\tv166 = *([v129 @ X9_v25]);\n\tgoto L_004C;\nL_004B:\n\t*([2DD4429]) = 1;\nL_004C:\n\tv199 = UnityEngine.Mathf::Floor(v171);\n\tv206 = *([v74 @ X8_v4+4]) / v166;\n\tgoto L_0054;\n\tv209 = \"il2cpp_codegen_runtime_class_init\"(v204, i, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65);\nL_0054:\n\tv211 = Il2CppMethodInfo;\n\tv216 = UnityEngine.Mathf::Floor(v206);\n\tv230 = v199 != 0x7F800000;\n\tif (v230) goto L_FFFFFFFF;\n\tgoto L_0077;\nL_0077:\n\tv244 = v216 != 0x7F800000;\n\tif (v244) goto L_FFFFFFFF;\n\tgoto L_007E;\nL_007E:\n\tv249 = this + 0x10;\n\tgoto L_0093;\nL_0086:\n\tv302 = v302 + 1;\n\tv287 = v302 == 2;\n\tif (v287) goto L_0143;\nL_0093:\n\tv315 = v302 + v233;\n\tv305 = v315 * 0x3DCF;\n\tgoto L_00A4;\nL_0098:\n\tv326 = v326 + 1;\n\tv336 = v326 == 2;\n\tif (v336) goto L_0086;\nL_00A4:\n\tv354 = v326 + v247;\n\tv357 = v354 * 0x949475;\n\tv358 = v305 + v357;\n\tv297 = v358 / this.capacity;\n\tv360 = v297 * this.capacity;\n\tv361 = v358 - v360;\n\tv362 = Il2CppMethodInfo;\n\tv368 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v249, v361, &v365 @ stack_-94_v3, &v70 @ stack_-A0_v1, *([v362 @ X8_v19 (Il2CppMethodInfo)+CC8]));\n\tv369 = v368 == 0;\n\tv370 = ~v369;\n\tif (v370) goto L_00C7;\n\tgoto L_0098;\n\tv616 = v613 - v439;\n\tv617 = *([v601 @ X8_v37+4]);\n\tv595 = v616 * v616;\n\tv592 = v617 * v595;\n\tv458 = v460 * v456;\n\tv462 = v409 + v458;\nL_00C2:\n\tv412 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v249, &v365 @ stack_-94_v3, &v70 @ stack_-A0_v1, *([v211 @ X25_v1 (Il2CppMethodInfo)+CD0]));\n\tv479 = v412 & 1;\n\tv414 = v479 == 0;\n\tif (v414) goto L_0098;\nL_00C7:\n\tv418 = this.isWater;\n\tv420 = *([v418 @ X9_v11 (Unity.Collections.NativeArray`1<System.Boolean>)+v365 @ stack_-94_v3]) == 0;\n\tif (v420) goto L_00C2;\n\tv431 = v365 << 3;\n\tv432 = this.predicted + v431;\n\tv436 = *([2DD4420]) == 0;\n\tif (v436) goto L_010C;\n\tv474 = *([v178 @ X21_v7]);\n\tv476 = *([v474 @ X0_v41+E0]) == 0;\n\tif (v476) goto L_0117;\nL_00DA:\n\tgoto L_00DB;\nL_00DB:\n\tv521 = *([v432 @ X8_v24+4]) - *([v74 @ X8_v4+4]);\n\tv522 = *([v432 @ X8_v24]) - *([v74 @ X8_v4]);\n\tv457 = v522 * v522;\n\tv523 = v521 * v521;\n\tv524 = v457 + v523;\n\tv439 = UnityEngine.Mathf::Sqrt(v524);\n\tgoto L_00C2;\n\tv460 = *([v40 @ X19_v1 (WaterDensityJob)+40]);\n\tv529 = *([v465 @ X0_v23+E0]);\n\tv530 = v529 == 0;\n\tif (v530) goto L_011B;\n\tv531 = *([2DD442A]);\n\tv532 = v531 == 0;\n\tif (v532) goto L_FFFFFFFF;\n\tv539 = *([v45 @ X20_v2]);\n\tv540 = *([v539 @ X0_v38+E0]);\n\tv541 = v540 == 0;\n\tif (v541) goto L_FFFFFFFF;\n\tv554 = *([v548 @ X0_v36+B8]);\n\tv555 = *([v554 @ X8_v44]);\n\tv556 = 0;\n\tv568 = v555 <= v439;\n\tif (v568) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\nL_010C:\n\t*([2DD4420]) = 1;\n\tv501 = *([v178 @ X21_v7]);\n\tv513 = *([v501 @ X0_v22+E0]) == 0;\n\tv503 = ~v513;\n\tif (v503) goto L_00DA;\nL_0117:\n\tgoto L_00DB;\n\tv526 = \"il2cpp_codegen_runtime_class_init\"(v525, v383, v381, v377, v270, v55, v56, v57, v403, v401, v60, v61, v62, v63, v64, v65);\n\tv515 = *([v45 @ X20_v2]);\n\tgoto L_00DB;\nL_011B:\n\tv533 = \"il2cpp_codegen_runtime_class_init\"(v465, v383, v381, v377, v270, v55, v56, v57, v459, v457, v60, v61, v62, v63, v64, v65);\n\tv538 = *([2DD442A]);\n\tv547 = v538 == 0;\n\tv536 = ~v547;\n\tif (v536) goto L_FFFFFFFF;\n\tv545 = v45;\n\tv546 = \"il2cpp_codegen_initialize_runtime_metadata\"(v545, v383, v381, v377, v270, v55, v56, v57, v459, v457, v60, v61, v62, v63, v64, v65);\n\t*([2DD442A]) = v253;\n\tv549 = *([v45 @ X20_v2]);\n\tv553 = *([v549 @ X0_v34+E0]);\n\tv573 = v553 == 0;\n\tv551 = ~v573;\n\tif (v551) goto L_FFFFFFFF;\n\tv572 = \"il2cpp_codegen_runtime_class_init\"(v569, v383, v381, v377, v270, v55, v56, v57, v459, v457, v60, v61, v62, v63, v64, v65);\n\tv599 = *([v45 @ X20_v2]);\n\tv602 = *([v599 @ X0_v30+B8]);\n\tv596 = *([v602 @ X8_v39]);\n\tv593 = 0;\n\tv575 = v596 <= v439;\n\tif (v575) goto L_FFFFFFFF;\n\tv597 = *([v608 @ X0_v25+E0]);\n\tv611 = v597 == 0;\n\tv600 = ~v611;\n\tif (v600) goto L_FFFFFFFF;\n\tv612 = \"il2cpp_codegen_runtime_class_init\"(v608, v383, v381, v377, v270, v55, v56, v57, v607, v606, v60, v61, v62, v63, v64, v65);\n\tv618 = *([v45 @ X20_v2]);\n\tv615 = *([v618 @ X8_v35+B8]);\n\tv614 = *([v615 @ X8_v36]);\n\tgoto L_FFFFFFFF;\nL_0143:\n\tv480 = this.waterDensities;\n\t*([v480 @ X8_v52 (Unity.Collections.NativeArray`1<System.Single>)+i @ X1 (System.Int32)*4]) = v307;\n\treturn;\nL_015B:\n\tv96 = *([v44 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv114 = *([v96 @ X0_v52+B8]);\n\tv117 = *([v114 @ X8_v63]);\n\tv115 = *([2DD4429]) == 0;\n\tv98 = ~v115;\n\tif (v98) goto L_003A;\nL_0167:\n\t*([2DD4429]) = 1;\n\tv140 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv178 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv119 = *([v140 @ X21_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv141 = *([v119 @ X0_v50+E0]) == 0;\n\tv121 = ~v141;\n\tif (v121) goto L_0041;\nL_0175:\n\tv156 = *([2DD4429]) == 0;\n\tv172 = *([v74 @ X8_v4]) / v133;\n\tv202 = *([v44 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv169 = *([v202 @ X9_v21+B8]);\n\tv203 = ~v156;\n\tv175 = ~v203;\n\tif (v175) goto L_004B;\n\tgoto L_004C;\n\treturn;\n// 211 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void Execute(int i)
	{
		//IL_000e: Expected I, but got O
		//IL_0577: Expected O, but got I4
		//IL_058f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0594: Expected O, but got Unknown
		//IL_05a4: Expected O, but got I
		//IL_041f: Expected O, but got I
		//IL_042f: Expected O, but got I
		//IL_0066: Expected I, but got O
		//IL_0075: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Expected O, but got Unknown
		//IL_008a: Expected O, but got I
		//IL_0023: Expected O, but got I
		//IL_051d: Expected O, but got I
		//IL_052d: Expected O, but got I
		//IL_0483: Expected I, but got O
		//IL_0492: Unknown result type (might be due to invalid IL or missing references)
		//IL_0497: Expected O, but got Unknown
		//IL_04a7: Expected O, but got I
		//IL_00de: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_061f: Expected O, but got Ref
		//IL_062c: Expected O, but got I8
		//IL_01d1: Expected O, but got I8
		//IL_01e5: Expected O, but got I
		//IL_02f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fb: Expected O, but got Unknown
		//IL_0180: Expected O, but got I
		//IL_036f: Expected O, but got I
		//IL_039a: Expected O, but got I
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		object obj = 0;
		int num2 = i << 3;
		object obj2 = predicted + num2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v2+E0]");
		object obj5;
		object obj6;
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X0_v2+B8]");
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
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v52+B8]");
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
		object obj9 = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 2328;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v140 @ X21_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
		object obj10 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v119 @ X0_v50+E0]");
		bool flag4 = (nint)0 == 0;
		bool flag5 = !flag4;
		obj5 = obj6;
		object obj11 = obj9;
		if (flag5)
		{
			goto IL_00bf;
		}
		goto IL_04e7;
		IL_00bf:
		float f = (float)obj2 / (float)obj5;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj12 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X9_v24+B8]");
		object obj13 = 0;
		object obj14 = obj13;
		goto IL_05c9;
		IL_05c9:
		float num4 = global::UnityEngine.Mathf.Floor(f);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+4]");
		float num5 = 0f / (float)obj14;
		nint num6 = 0;
		float num7 = global::UnityEngine.Mathf.Floor(num5);
		float num8 = ((num4 != float.PositiveInfinity) ? num4 : -0f);
		float num9 = ((num7 != float.PositiveInfinity) ? num5 : -0f);
		object obj15 = (object)global::System.Runtime.CompilerServices.Unsafe.AsPointer(ref global::System.Runtime.CompilerServices.Unsafe.AddByteOffset(ref this, 16));
		object obj16 = 4294967295L;
		int num10 = 0;
		object obj18 = default(object);
		object obj19 = default(object);
		object obj26 = default(object);
		bool flag8;
		do
		{
			float num11 = (float)obj16 + num8;
			float num12 = num11 * 2.2173E-41f;
			object obj17 = 4294967295L;
			int num20;
			bool flag7;
			do
			{
				float num13 = (float)obj17 + num9;
				float num14 = num13 * 1.364491E-38f;
				float num15 = num12 + num14;
				float num16 = num15 / (float)capacity;
				float num17 = num16 * (float)capacity;
				float num18 = num15 - num17;
				nint num19 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8DC8 (Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue, and 1 more at this address)");
				if (obj18 == null)
				{
					num20 = num10;
				}
				else
				{
					bool flag6;
					do
					{
						global::Unity.Collections.NativeArray<bool> nativeArray = isWater;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v418 @ X9_v11 (Unity.Collections.NativeArray`1<System.Boolean>)+v365 @ stack_-94_v3]");
						if ((nint)0 != 0)
						{
							int num21 = (int)((nint)obj19 << 3);
							object obj20 = predicted + num21;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
							if ((nint)0 != 0)
							{
								object obj21 = obj9;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v474 @ X0_v41+E0]");
								if ((nint)0 == 0)
								{
								}
							}
							else
							{
								_ = 1;
								object obj22 = obj9;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X0_v22+E0]");
								if ((nint)0 != 0)
								{
								}
							}
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v432 @ X8_v24+4]");
							nint num22 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v4+4]");
							object obj23 = num22 - 0;
							object obj24 = obj20 - obj2;
							int num23 = (int)((nint)obj24 * (nint)obj24);
							object obj25 = (nint)obj23 * (nint)obj23;
							float f2 = (float)num23 + (float)obj25;
							float num24 = global::UnityEngine.Mathf.Sqrt(f2);
						}
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E8E24 (Unity.Collections.NativeMultiHashMap`2::TryGetNextValue, and 1 more at this address)");
						int num25 = (int)((nint)obj26 & 1);
						flag6 = num25 == 0;
						num20 = num10;
					}
					while (!flag6);
				}
				obj17 = (nint)obj17 + 1;
				flag7 = (nint)obj17 == 2;
				num10 = num20;
			}
			while (!flag7);
			obj16 = (nint)obj16 + 1;
			flag8 = (nint)obj16 == 2;
			num10 = num20;
		}
		while (!flag8);
		global::Unity.Collections.NativeArray<float> nativeArray2 = waterDensities;
		return;
		IL_04e7:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4429]");
		bool flag9 = (nint)0 == 0;
		float num26 = (float)obj2 / (float)obj6;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj27 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X9_v21+B8]");
		object obj28 = 0;
		if (flag9)
		{
			_ = 1;
		}
		else
		{
			obj14 = obj28;
			f = num26;
			obj9 = obj11;
		}
		goto IL_05c9;
		IL_0058:
		nint num27 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		obj9 = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 2328;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X21_v9 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
		object obj29 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v59+E0]");
		bool flag10 = (nint)0 == 0;
		obj6 = obj5;
		obj11 = obj9;
		if (!flag10)
		{
			goto IL_00bf;
		}
		goto IL_04e7;
	}
}
