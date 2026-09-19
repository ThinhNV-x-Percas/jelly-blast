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

	public float radius;

	[global::Cpp2ILInjected.Token(Token = "0x6000245")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF94CC", Offset = "0xFF94CC", Length = "0x7D0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv48 = System.Xml.ValidateNames;\n\tv50 = System.Runtime.Serialization.ObjectHolderList;\n\tgoto L_0033;\n\tv55 = Il2CppMethodInfo;\n\tv56 = v55 + 0xC80;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv100 = Il2CppMethodInfo;\n\tv101 = v100 + 0xCC8;\n\tv102 = \"il2cpp_codegen_initialize_runtime_metadata\"(v101, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv113 = Il2CppMethodInfo;\n\tv114 = v113 + 0xCD0;\n\tv115 = \"il2cpp_codegen_initialize_runtime_metadata\"(v114, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv125 = System.Runtime.Serialization.ObjectHolderList;\n\tv126 = v125 + 0xD20;\n\tv127 = \"il2cpp_codegen_initialize_runtime_metadata\"(v126, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv146 = System.Xml.ValidateNames;\n\tv147 = v146 + 0xD40;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v147, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv75 = 1;\n\t*([302A9E9]) = v75;\nL_0033:\n\tv76 = 0;\n\tv78 = this.predicted;\n\tv79 = i & 0xFFFFFFFF;\n\tv80 = v79 << 3;\n\tv84 = this.densities + v80;\n\tv93 = *([v48 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv94 = *([v93 @ X8_v7+B8]);\n\tv436 = *([v94 @ X8_v8]);\n\tv104 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tgoto L_0050;\n\tv103 = \"il2cpp_codegen_runtime_class_init\"(v96, i, methodInfo, v59, v60, v61, v62, v63, v90, v65, v66, v67, v68, v69, v70, v71);\n\tv105 = *([v51 @ X21_v2]);\nL_0050:\n\tv108 = *([v104 @ X0_v3+B8]);\n\tv112 = *([2DD4429]) == 0;\n\tif (v112) goto L_0063;\n\tv117 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv119 = *([v117 @ X8_v131 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv121 = *([v119 @ X0_v90+E0]) == 0;\n\tif (v121) goto L_FFFFFFFF;\n\tgoto L_0078;\nL_0063:\n\t*([2DD4429]) = 1;\n\tv143 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv131 = *([v143 @ X8_v126 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv145 = *([v131 @ X0_v88+E0]) == 0;\n\tv133 = ~v145;\n\tif (v133) goto L_FFFFFFFF;\nL_0078:\n\tv177 = UnityEngine.Mathf::Max(*([v84 @ X8_v5]), v172);\n\tv182 = *([v78 @ X8_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v80 @ X9_v1 (System.Int32)]) / *([v108 @ X8_v10]);\n\tv183 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv184 = *([v183 @ X9_v2+B8]);\n\tgoto L_0087;\n\tv189 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv190 = v189 + 0x918;\n\tv191 = \"il2cpp_codegen_initialize_runtime_metadata\"(v190, i, methodInfo, v59, v60, v61, v62, v63, v181, v65, v66, v67, v68, v69, v70, v71);\n\tv194 = 1;\n\t*([2DD4429]) = v194;\nL_0087:\n\tv195 = UnityEngine.Mathf::Max(*([v84 @ X8_v5+4]), v172);\n\tv198 = UnityEngine.Mathf::Floor(v182);\n\tv203 = v187 / *([v184 @ X9_v3]);\n\tgoto L_0094;\n\tv206 = \"il2cpp_codegen_runtime_class_init\"(v201, i, methodInfo, v59, v60, v61, v62, v63, v181, v65, v66, v67, v68, v69, v70, v71);\nL_0094:\n\tv208 = Il2CppMethodInfo;\n\tv216 = UnityEngine.Mathf::Floor(v203);\n\tv219 = this.isWater;\n\tv221 = this.fishIds;\n\tv223 = *([v221 @ X10_v2 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) + 1;\n\tv225 = v223 == 0;\n\tv228 = ~v225;\n\tv242 = v198 != 0x7F800000;\n\tif (v242) goto L_FFFFFFFF;\n\tgoto L_00C6;\nL_00C6:\n\tv256 = v216 != 0x7F800000;\n\tif (v256) goto L_FFFFFFFF;\n\tgoto L_00CD;\nL_00CD:\n\tv261 = this + 0x20;\n\tv262 = this + 0x50;\n\tv264 = *([v219 @ X10_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) | v228;\n\tgoto L_00E6;\nL_00D9:\n\tv330 = v330 + 1;\n\tv345 = v330 == 2;\n\tif (v345) goto L_032C;\nL_00E6:\n\tv361 = v330 + v245;\n\tv363 = v361 * 0x3DCF;\n\tgoto L_00F9;\nL_00EC:\n\tv382 = v382 + 1;\n\tv402 = v382 == 2;\n\tif (v402) goto L_00D9;\nL_00F9:\n\tv415 = v382 + v259;\n\tv418 = v415 * 0x949475;\n\tv419 = v363 + v418;\n\tv421 = v419 / this.capacity;\n\tv422 = v421 * this.capacity;\n\tv423 = v419 - v422;\n\tv424 = Il2CppMethodInfo;\n\tv430 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v261, v423, &v427 @ stack_-AC_v3 (System.Int32), &v76 @ stack_-B8_v1, *([v424 @ X8_v30 (Il2CppMethodInfo)+CC8]));\n\tv431 = v430 == 0;\n\tv432 = ~v431;\n\tif (v432) goto L_0121;\n\tgoto L_00EC;\nL_010E:\n\tv972 = v600 * v973;\n\tv975 = this.honeyRepelStr;\nL_0111:\n\tv1042 = v580 * v741;\n\tv601 = v1042 * v739;\n\tv537 = v436 - v601;\nL_0118:\n\tv502 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v261, &v427 @ stack_-AC_v3 (System.Int32), &v76 @ stack_-B8_v1, *([v208 @ X27_v1 (Il2CppMethodInfo)+CD0]));\n\tv731 = v502 & 1;\n\tv504 = v731 == 0;\n\tif (v504) goto L_00EC;\nL_0121:\n\tv512 = v427 == i;\n\tif (v512) goto L_0118;\n\tv526 = this.powerUpIds;\n\tv529 = *([v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) + 1;\n\tv531 = v529 == 0;\n\tv534 = ~v531;\n\tv535 = ~v534;\n\tif (v535) goto L_FFFFFFFF;\n\tv720 = *([v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]) - -1;\n\tv648 = v720 == 0;\n\tgoto L_FFFFFFFF;\n\tif (v648) goto L_014F;\n\tv564 = *([v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]) | *([v526 @ X10_v11 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]);\n\tv690 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::ContainsKey(v262, v564);\n\tv774 = v690 == 0;\n\tv698 = ~v774;\n\tif (v698) goto L_0118;\nL_014F:\n\tv771 = v264 == 0;\n\tv772 = ~v771;\n\tif (v772) goto L_0153;\nL_0153:\n\tv777 = this.isWater;\n\tv566 = *([v219 @ X10_v1 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) != *([v777 @ X9_v15 (Unity.Collections.NativeArray`1<System.Boolean>)+v768 @ X8_v35 (System.Int32)]);\n\tif (v566) goto L_0165;\n\tgoto L_0165;\nL_0165:\n\tv595 = this.predicted;\n\tv792 = *([2DD4420]) == 0;\n\tif (v792) goto L_0204;\n\tv793 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv795 = *([v793 @ X8_v109 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv797 = *([v795 @ X0_v75+E0]) == 0;\n\tif (v797) goto L_020D;\nL_0170:\n\tv691 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tgoto L_0175;\nL_0175:\n\tv581 = *([v595 @ X9_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v768 @ X8_v35 (System.Int32)*8]) - *([v78 @ X8_v3 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v80 @ X9_v1 (System.Int32)]);\n\tv826 = v581 * v581;\n\t// 375 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv926 = UnityEngine.Mathf::Sqrt(v826);\n\tv706 = *([v691 @ X0_v27+B8]);\n\tv568 = v926 >= *([v706 @ X8_v45]);\n\tif (v568) goto L_0118;\n\tv834 = v926 < 0;\n\tv835 = v926 == 0;\n\tv837 = v926 ^ v926;\n\tv838 = v926 & v837;\n\tv839 = v838 < 0;\n\t// 399 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv582 = v581 / v456;\n\tv840 = v834 == v839;\n\tv841 = ~v840;\n\tv842 = v841 | v835;\n\tv565 = ~v842;\n\tif (v565) goto L_FFFFFFFF;\n\tgoto L_019A;\nL_019A:\n\tv845 = this.isHoneyCoated;\n\tv856 = *([v845 @ X9_v18 (Unity.Collections.NativeArray`1<System.Boolean>)+i @ X1 (System.Int32)]) != *([v845 @ X9_v18 (Unity.Collections.NativeArray`1<System.Boolean>)+v427 @ stack_-AC_v3 (System.Int32)]);\n\tif (v856) goto L_0216;\n\tv857 = this.particleTypes;\n\tv867 = *([v857 @ X9_v21 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) != *([v857 @ X9_v21 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]);\n\tif (v867) goto L_0228;\n\tv868 = this.clumpIds;\n\tv878 = *([v868 @ X9_v23 (Unity.Collections.NativeArray`1<System.Int32>)+i @ X1 (System.Int32)*4]) != *([v868 @ X9_v23 (Unity.Collections.NativeArray`1<System.Int32>)+v427 @ stack_-AC_v3 (System.Int32)*4]);\n\tif (v878) goto L_0257;\n\tv550 = v427 << 3;\n\tv884 = this.densities + v550;\n\tv889 = *([v691 @ X0_v27+E0]) == 0;\n\tif (v889) goto L_028D;\n\tv899 = *([2DD442C]) == 0;\n\tif (v899) goto L_0295;\nL_01D8:\n\tv1175 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv935 = *([v1175 @ X0_v67+E0]) == 0;\n\tif (v935) goto L_029D;\nL_01DC:\n\tv986 = *([v1175 @ X0_v67+B8]);\n\tv998 = *([v986 @ X\n// ... truncated")]
	public void Execute(int i)
	{
		global::Unity.Mathematics.float2 pos = predicted[i];
		global::Unity.Mathematics.float2 d = densities[i];
		float pressure = pressureMultiplier * (d.x - targetDensity);
		float nearPressure = nearPressureMultipliers[i] * d.y;
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
					if (neighbor == i)
					{
						continue;
					}
					int myPowerUpId = powerUpIds[i];
					int neighborPowerUpId = powerUpIds[neighbor];
					if (myPowerUpId != -1 && neighborPowerUpId != -1)
					{
						ulong key2 = (ulong)(uint)(myPowerUpId | neighborPowerUpId);
						if (ignorePairs.ContainsKey(key2))
						{
							continue;
						}
					}
					global::Unity.Mathematics.float2 offset = predicted[neighbor] - pos;
					float dist = global::UnityEngine.Mathf.Sqrt(offset.x * offset.x + offset.y * offset.y);
					if (dist <= 0f || dist >= radius)
					{
						continue;
					}
					float q = 1f - dist / radius;
					global::Unity.Mathematics.float2 dir = offset / dist;
					if (isWater[i] == isWater[neighbor])
					{
						global::Unity.Mathematics.float2 dn = densities[neighbor];
						float neighborPressure = pressureMultiplier * (dn.x - targetDensity);
						float neighborNearPressure = nearPressureMultipliers[neighbor] * dn.y;
						float avgPressure = (pressure + neighborPressure) * 0.5f;
						float avgNearPressure = (nearPressure + neighborNearPressure) * 0.5f;
						float displacement = dt * (avgPressure * q + avgNearPressure * q * q);
						impulse -= dir * (displacement * 0.5f);
					}
					else
					{
						impulse -= dir * (waterReactionGlobal * q * dt * 0.5f);
					}
					if (particleTypes[i] != particleTypes[neighbor])
					{
						impulse -= dir * (interFluidRepelStr * q * dt);
					}
					if (isHoneyCoated[i] != isHoneyCoated[neighbor])
					{
						impulse -= dir * (honeyRepelStr * q * dt);
					}
					int myClumpId = clumpIds[i];
					int neighborClumpId = clumpIds[neighbor];
					if (myClumpId != -1 && neighborClumpId != -1 && myClumpId != neighborClumpId)
					{
						impulse -= dir * (clumpRepelStrength * q * dt);
					}
				}
				while (cellMap.TryGetNextValue(out neighbor, ref it));
			}
		}
		deltaVel[i] += impulse;
	}
}
