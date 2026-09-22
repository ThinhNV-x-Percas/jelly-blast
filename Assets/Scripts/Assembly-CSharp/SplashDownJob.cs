[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000080")]
public struct SplashDownJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000253")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> predicted;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000254")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<bool> isWater;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000255")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeMultiHashMap<int, int> cellMap;

	[global::Cpp2ILInjected.Token(Token = "0x4000256")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Cpp2ILInjected.Token(Token = "0x4000257")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float splashDownStrength;

	[global::Cpp2ILInjected.Token(Token = "0x4000258")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public int capacity;

	[global::Cpp2ILInjected.Token(Token = "0x4000259")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float dt;

	public float radius;

	[global::Cpp2ILInjected.Token(Token = "0x600024F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFFAAA4", Offset = "0xFFAAA4", Length = "0x57C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0027;\n\tv47 = Il2CppMethodInfo;\n\tv48 = v47 + 0xCC8;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v48, i, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv74 = Il2CppMethodInfo;\n\tv75 = v74 + 0xCD0;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, i, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv215 = System.Runtime.Serialization.ObjectHolderList;\n\tv216 = v215 + 0xD20;\n\tv65 = \"il2cpp_codegen_initialize_runtime_metadata\"(v216, i, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\n\tv67 = 1;\n\t*([302A9F0]) = v67;\nL_0027:\n\tv68 = 0;\n\tv70 = this.isWater;\n\tv73 = *([v70 @ X8_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) == 0;\n\tif (v73) goto L_01E2;\n\tv77 = System.Runtime.Serialization.ObjectHolderList;\n\tv81 = i << 3;\n\tv82 = this.predicted + v81;\n\tv85 = *([v77 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv87 = *([v85 @ X0_v3+E0]) == 0;\n\tif (v87) goto L_01E4;\n\tv217 = *([v85 @ X0_v3+B8]);\n\tv248 = *([v217 @ X8_v97]);\n\tv221 = *([2DD4429]) == 0;\n\tif (v221) goto L_01F0;\nL_0040:\n\tv233 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv302 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv235 = *([v233 @ X20_v10 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv237 = *([v235 @ X0_v90+E0]) == 0;\n\tif (v237) goto L_01FE;\nL_0047:\n\tv294 = *([v82 @ X8_v7]) / v248;\n\tv260 = *([v77 @ X23_v3 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv261 = *([v260 @ X9_v35+B8]);\n\tv290 = *([v261 @ X9_v36]);\n\tgoto L_0052;\nL_0051:\n\t*([2DD4429]) = 1;\nL_0052:\n\tv322 = UnityEngine.Mathf::Floor(v294);\n\tv329 = *([v82 @ X8_v7+4]) / v290;\n\tgoto L_005A;\n\tv332 = \"il2cpp_codegen_runtime_class_init\"(v327, i, methodInfo, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63);\nL_005A:\n\tv334 = Il2CppMethodInfo;\n\tv335 = Il2CppMethodInfo;\n\tv336 = UnityEngine.Mathf::Floor(v329);\n\tv351 = v322 != 0x7F800000;\n\tif (v351) goto L_FFFFFFFF;\n\tgoto L_0075;\nL_0075:\n\tv356 = v329 * 0x949475;\n\tv194 = this + 0x20;\n\tv132 = v336 != 0x7F800000;\n\tif (v132) goto L_FFFFFFFF;\n\tgoto L_0086;\nL_0086:\n\tv369 = v368 - 0x949000;\n\tv370 = v369 - 0x475;\n\tv371 = v368 + 0x949475;\n\tgoto L_009E;\nL_0092:\n\tv382 = v382 + 1;\n\tv392 = v382 == 2;\n\tif (v392) goto L_01BA;\nL_009E:\n\tv411 = v382 + v129;\n\tv125 = v411 * 0x3DCF;\n\tv414 = v370 + v125;\n\tv416 = v414 / this.capacity;\n\tv417 = v416 * this.capacity;\n\tv418 = v414 - v417;\n\tv424 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v194, v418, &v421 @ stack_-94_v3, &v68 @ stack_-A0_v1, *([v334 @ X24_v3 (Il2CppMethodInfo)+CC8]));\n\tv425 = v424 == 0;\n\tv426 = ~v425;\n\tif (v426) goto L_00D8;\nL_00B0:\n\tv474 = v368 + v125;\n\tv476 = v474 / this.capacity;\n\tv477 = v476 * this.capacity;\n\tv478 = v474 - v477;\n\tv484 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v194, v478, &v421 @ stack_-94_v3, &v68 @ stack_-A0_v1, *([v334 @ X24_v3 (Il2CppMethodInfo)+CC8]));\n\tv513 = v484 == 0;\n\tv514 = ~v513;\n\tif (v514) goto L_0126;\nL_00BE:\n\tv593 = v371 + v125;\n\tv162 = v593 / this.capacity;\n\tv595 = v162 * this.capacity;\n\tv596 = v593 - v595;\n\tv601 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v194, v596, &v421 @ stack_-94_v3, &v68 @ stack_-A0_v1, *([v334 @ X24_v3 (Il2CppMethodInfo)+CC8]));\n\tv636 = v601 == 0;\n\tv637 = ~v636;\n\tif (v637) goto L_0174;\n\tgoto L_0092;\n\tv531 = v854 - v535;\n\tv533 = v531 / v854;\n\tv536 = v503 + v533;\nL_00CF:\n\t;\n\tv468 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v194, &v421 @ stack_-94_v3, &v68 @ stack_-A0_v1, *([v335 @ X25_v3 (Il2CppMethodInfo)+CD0]));\n\tv635 = v468 & 1;\n\tv470 = v635 == 0;\n\tif (v470) goto L_00B0;\nL_00D8:\n\tv509 = this.isWater;\n\tv511 = *([v509 @ X9_v12 (Unity.Collections.NativeArray`1<System.Boolean>)+v421 @ stack_-94_v3]) == 0;\n\tv512 = ~v511;\n\tif (v512) goto L_00CF;\n\tv516 = v421 << 3;\n\tv517 = this.predicted + v516;\n\tv521 = *([2DD4420]) == 0;\n\tif (v521) goto L_010B;\n\tv630 = *([v302 @ X20_v8]);\n\tv632 = *([v630 @ X0_v28+E0]) == 0;\n\tif (v632) goto L_0116;\nL_00EC:\n\tgoto L_00ED;\nL_00ED:\n\tv747 = *([v517 @ X8_v23+4]) - *([v82 @ X8_v7+4]);\n\tv748 = *([v517 @ X8_v23]) - *([v82 @ X8_v7]);\n\tv532 = v748 * v748;\n\tv749 = v747 * v747;\n\tv750 = v532 + v749;\n\tv535 = UnityEngine.Mathf::Sqrt(v750);\n\tgoto L_00CF;\n\tv830 = *([v539 @ X0_v23+E0]);\n\tv831 = v830 == 0;\n\tv541 = ~v831;\n\tif (v541) goto L_FFFFFFFF;\n\tv853 = \"il2cpp_codegen_runtime_class_init\"(v539, v490, v489, v487, v419, v53, v54, v55, v534, v532, v58, v59, v60, v61, v62, v63);\n\tv873 = *([v78 @ X23_v4]);\n\tv856 = *([v873 @ X8_v32+B8]);\n\tv855 = *([v856 @ X8_v33]);\n\tgoto L_FFFFFFFF;\nL_010B:\n\t*([2DD4420]) = 1;\n\tv670 = *([v302 @ X20_v8]);\n\tv682 = *([v670 @ X0_v22+E0]) == 0;\n\tv672 = ~v682;\n\tif (v672) goto L_00EC;\nL_0116:\n\tgoto L_00ED;\n\tv752 = \"il2cpp_codegen_runtime_class_init\"(v751, v490, v489, v487, v419, v53, v54, v55, v500, v499, v58, v59, v60, v61, v62, v63);\n\tv741 = *([v78 @ X23_v4]);\n\tgoto L_00ED;\n\tv654 = v876 - v658;\n\tv656 = v654 / v876;\n\tv659 = v620 + v656;\nL_011D:\n\t;\n\tv587 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v194, &v421 @ stack_-94_v3, &v68 @ stack_-A0_v1, *([v335 @ X25_v3 (Il2CppMethodInfo)+CD0]));\n\tv739 = v587 & 1;\n\tv589 = v739 == 0;\n\tif (v589) goto L_00BE;\nL_0126:\n\tv626 = this.isWater;\n\tv628 = *([v626 @ X9_v19 (Unity.Collections.NativeArray`1<System.Boolean>)+v421 @ stack_-94_v3]) == 0;\n\tv629 = ~v628;\n\tif (v629) goto L_011D;\n\tv639 = v421 << 3;\n\tv640 = this.predicted + v639;\n\tv644 = *([2DD4420]) == 0;\n\tif (v644) goto L_0159;\n\tv734 = *([v302 @ X20_v8]);\n\tv736 = *([v734 @ X0_v50+E0]) == 0;\n\tif (v736) goto L_0164;\nL_013A:\n\tgoto L_013B;\nL_013B:\n\tv823 = *([v640 @ X8_v44+4]) - *([v82 @ X8_v7+4]);\n\tv824 = *([v640 @ X8_v44]) - *([v82 @ X8_v7]);\n\tv655 = v824 * v824;\n\tv825 = v823 * v823;\n\tv826 = v655 + v825;\n\tv658 = UnityEngine.Mathf::Sqrt(v826);\n\tgoto L_011D;\n\tv871 = *([v662 @ X0_v45+E0]);\n\tv872 = v871 == 0;\n\tv664 = ~v872;\n\tif (v664) goto L_FFFFFFFF;\n\tv875 = \"il2cpp_codegen_runtime_class_init\"(v662, v607, v606, v604, v479, v53, v54, v55, v657, v655, v58, v59, v60, v61, v62, v63);\n\tv881 = *([v78 @ X23_v4]);\n\tv878 = *([v881 @ X8_v53+B8]);\n\tv877 = *([v878 @ X8_v54]);\n\tgoto L_FFFFFFFF;\nL_0159:\n\t*([2DD4420]) = 1;\n\tv795 = *([v302 @ X20_v8]);\n\tv807 = *([v795 @ X0_v44+E0]) == 0;\n\tv797 = ~v807;\n\tif (v797) goto L_013A;\nL_0164:\n\tgoto L_013B;\n\tv828 = \"il2cpp_codegen_runtime_class_init\"(v827, v607, v606, v604, v479, v53, v54, v55, v617, v616, v58, v59, v60, v61, v62, v63);\n\tv817 = *([v78 @ X23_v4]);\n\tgoto L_013B;\n\tv779 = v883 - v783;\n\tv781 = v779 / v883;\n\tv784 = v719 + v781;\nL_016B:\n\t;\n\tv724 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v194, &v421 @ stack_-94_v3, &v68 @ stack_-A0_v1, *([v335 @ X25_v3 (Il2CppMethodInfo)+CD0]));\n\tv815 = v724 & 1;\n\tv726 = v815 == 0;\n\tif (v726) goto L_0092;\nL_0174:\n\tv730 = this.isWater;\n\tv732 = *([v730 @ X9_v26 (Unity.Collections.NativeArray`1<System.Boolean>)+v421 @ stack_-94_v3]) == 0;\n\tv733 = ~v732;\n\tif (v733) goto L_016B;\n\tv764 = v421 << 3;\n\tv765 = this.predicted + v764;\n\tv769 = *([2DD4420]) == 0;\n\tif (v769) goto L_01A7;\n\tv810 = *([v302 @ X20_v8]);\n\tv812 = *([v810 @ X0_v72+E0]) == 0;\n\tif (v812) goto L_01B2;\nL_0188:\n\tgoto L_0189;\nL_0189:\n\tv864 = *([v765 @ X8_v65+4]) - *([v82 @ X8_v7+4]);\n\tv865 = *([v765 @ X8_v65]) - *([v82 @ X8_v7]);\n\tv780 = v865 * v865;\n\tv866 = v864 * v864;\n\tv867 = v780 + v866;\n\tv783 = UnityEngine.Mathf::Sqrt(v867);\n\tgoto L_016B;\n\tv879 = *([v787 @ X0_v67+E0]);\n\tv880 = v879 == 0;\n\tv789 = ~v880;\n\tif (v789) goto L_FFFFFFFF;\n\tv882 = \"il2cpp_codegen_runtime_class_init\"(v787, v693, v691, v687, v121, v53, v54, v55, v782, v780, v58, v59, v60, v61, v62, v63);\n\tv886 = *([v78 @ X23_v4]);\n\tv885 = *([v886 @ X8_v74+B8]);\n\tv884 = *([v885 @ X8_v75]);\n\tgoto L_FFFFFFFF;\nL_01A7:\n\t*([2DD4420]) = 1;\n\tv839 = *([v302 @ X20_v8]);\n\tv851 = *([v839 @ X0_v66+E0]) == 0;\n\tv841 = ~v851;\n\tif (v841) goto L_0188;\nL_01B2:\n\tgoto L_0189;\n\tv869 = \"il2cpp_codegen_run\n// ... truncated")]
	public void Execute(int i)
	{
		if (!isWater[i])
		{
			return;
		}
		global::Unity.Mathematics.float2 pos = predicted[i];
		int gridX = (int)global::UnityEngine.Mathf.Floor(pos.x / radius);
		int gridY = (int)global::UnityEngine.Mathf.Floor(pos.y / radius);
		global::Unity.Mathematics.float2 impulse = default(global::Unity.Mathematics.float2);
		for (int dy = 0; dy < 2; dy++)
		{
			int hashY = (gridY + dy) * 0x3DCF;
			for (int dx = 0; dx < 2; dx++)
			{
				int key = (hashY + (gridX + dx) * 0x949475) % capacity;
				if (!cellMap.TryGetFirstValue(key, out int neighbor, out var it))
				{
					continue;
				}
				do
				{
					if (neighbor == i || isWater[neighbor])
					{
						continue;
					}
					global::Unity.Mathematics.float2 offset = predicted[neighbor] - pos;
					float dist = global::UnityEngine.Mathf.Sqrt(offset.x * offset.x + offset.y * offset.y);
					if (dist <= 0f || dist >= radius)
					{
						continue;
					}
					float q = 1f - dist / radius;
					global::Unity.Mathematics.float2 dir = offset / dist;
					impulse -= dir * (splashDownStrength * q * dt);
				}
				while (cellMap.TryGetNextValue(out neighbor, ref it));
			}
		}
		deltaVel[i] += impulse;
	}
}
