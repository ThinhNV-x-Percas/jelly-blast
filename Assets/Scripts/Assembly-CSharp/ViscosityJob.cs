[global::Unity.Burst.BurstCompile]
[global::Cpp2ILInjected.Token(Token = "0x2000077")]
public struct ViscosityJob : global::Unity.Jobs.IJobParallelFor
{
	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000218")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> predicted;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000219")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> velocities;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400021A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::Unity.Collections.NativeMultiHashMap<int, int> cellMap;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400021B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::Unity.Collections.NativeArray<int> particleTypes;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400021C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::Unity.Collections.NativeHashMap<ulong, byte> ignorePairs;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400021D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public global::Unity.Collections.NativeArray<int> powerUpIds;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x400021E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public global::Unity.Collections.NativeArray<bool> isWater;

	[global::Cpp2ILInjected.Token(Token = "0x400021F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> deltaVel;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000220")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public global::Unity.Collections.NativeArray<float> viscosityStrengths;

	[global::Cpp2ILInjected.Token(Token = "0x4000221")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public float dt;

	[global::Cpp2ILInjected.Token(Token = "0x4000222")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public int capacity;

	public float radius;

	[global::Cpp2ILInjected.Token(Token = "0x4000223")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public float waterReactionGlobal;

	[global::Unity.Collections.ReadOnly]
	[global::Cpp2ILInjected.Token(Token = "0x4000224")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public global::Unity.Collections.NativeArray<int> fishIds;

	[global::Cpp2ILInjected.Token(Token = "0x6000246")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF9C9C", Offset = "0xFF9C9C", Length = "0x4E4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv48 = System.Xml.ValidateNames;\n\tv50 = System.Runtime.Serialization.ObjectHolderList;\n\tgoto L_0033;\n\tv55 = Il2CppMethodInfo;\n\tv56 = v55 + 0xC80;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv92 = Il2CppMethodInfo;\n\tv93 = v92 + 0xCC8;\n\tv94 = \"il2cpp_codegen_initialize_runtime_metadata\"(v93, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv101 = Il2CppMethodInfo;\n\tv102 = v101 + 0xCD0;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv129 = System.Runtime.Serialization.ObjectHolderList;\n\tv130 = v129 + 0xD20;\n\tv131 = \"il2cpp_codegen_initialize_runtime_metadata\"(v130, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv157 = System.Xml.ValidateNames;\n\tv158 = v157 + 0xD40;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v158, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\n\tv75 = 1;\n\t*([302A9EA]) = v75;\nL_0033:\n\tv76 = 0;\n\tv79 = i & 0xFFFFFFFF;\n\tv80 = v79 << 3;\n\tv81 = this.predicted + v80;\n\tv85 = *([v48 @ X22_v1 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv86 = *([v85 @ X10_v1+B8]);\n\tv422 = *([v86 @ X10_v2]);\n\tv89 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv91 = *([v89 @ X0_v2+E0]) == 0;\n\tif (v91) goto L_01D3;\n\tv95 = *([v89 @ X0_v2+B8]);\n\tv132 = *([v95 @ X8_v92]);\n\tv99 = *([2DD4429]) == 0;\n\tif (v99) goto L_01DF;\nL_004A:\n\tv114 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv116 = *([v114 @ X8_v89 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv118 = *([v116 @ X0_v63+E0]) == 0;\n\tif (v118) goto L_01ED;\nL_0052:\n\tv189 = *([v81 @ X8_v4]) / v132;\n\tv143 = *([v50 @ X21_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv144 = *([v143 @ X9_v31+B8]);\n\tv183 = *([v144 @ X9_v32]);\n\tgoto L_005D;\nL_005C:\n\t*([2DD4429]) = 1;\nL_005D:\n\tv217 = UnityEngine.Mathf::Floor(v189);\n\tv226 = *([v81 @ X8_v4+4]) / v183;\n\tgoto L_0067;\n\tv229 = \"il2cpp_codegen_runtime_class_init\"(v224, i, methodInfo, v59, v60, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71);\nL_0067:\n\tv231 = Il2CppMethodInfo;\n\tv233 = UnityEngine.Mathf::Floor(v226);\n\tv236 = this.isWater;\n\tv238 = this.fishIds;\n\tv240 = *([v238 @ X10_v4 (Unity.Collections.NativeArray`1<System.Int32>)+v210 @ X25_v1 (System.Int32)*4]) + 1;\n\tv242 = v240 == 0;\n\tv245 = ~v242;\n\tv259 = v217 != 0x7F800000;\n\tif (v259) goto L_FFFFFFFF;\n\tgoto L_0093;\nL_0093:\n\tv273 = v233 != 0x7F800000;\n\tif (v273) goto L_FFFFFFFF;\n\tgoto L_009A;\nL_009A:\n\tv278 = this + 0x20;\n\tv279 = this + 0x40;\n\tv281 = *([v236 @ X10_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+v210 @ X25_v1 (System.Int32)]) | v245;\n\tgoto L_00B0;\nL_00A3:\n\tv344 = v344 + 1;\n\tv335 = v344 == 2;\n\tif (v335) goto L_01B2;\nL_00B0:\n\tv353 = v344 + v262;\n\tv355 = v353 * 0x3DCF;\n\tgoto L_00C3;\nL_00B6:\n\tv367 = v367 + 1;\n\tv384 = v367 == 2;\n\tif (v384) goto L_00A3;\nL_00C3:\n\tv397 = v367 + v276;\n\tv400 = v397 * 0x949475;\n\tv401 = v355 + v400;\n\tv403 = v401 / this.capacity;\n\tv404 = v403 * this.capacity;\n\tv405 = v401 - v404;\n\tv406 = Il2CppMethodInfo;\n\tv412 = Unity.Collections.NativeMultiHashMap`2::TryGetFirstValue /* +1 sharing this address */(v278, v405, &v409 @ stack_-A4_v3 (System.Int32), &v76 @ stack_-B0_v1, *([v406 @ X8_v23 (Il2CppMethodInfo)+CC8]));\n\tv413 = v412 == 0;\n\tv414 = ~v413;\n\tif (v414) goto L_00EF;\n\tgoto L_00B6;\n\tv773 = *([v754 @ X8_v46+C]);\n\tv746 = v770 - v540;\n\tv733 = v746 / v773;\n\tv551 = v427;\n\tv541 = *([v44 @ X19_v1 (ViscosityJob)+10]);\n\tv756 = *([v541 @ X9_v18+v551 @ X8_v42*8]);\n\tv757 = v756 - v87;\n\tv502 = v499;\n\tv758 = v757 * v581;\n\tv538 = v758 * v759;\n\tv501 = v421 + v538;\nL_00E6:\n\tv464 = Unity.Collections.NativeMultiHashMap`2::TryGetNextValue /* +1 sharing this address */(v278, &v409 @ stack_-A4_v3 (System.Int32), &v76 @ stack_-B0_v1, *([v231 @ X27_v1 (Il2CppMethodInfo)+CD0]));\n\tv571 = v464 & 1;\n\tv466 = v571 == 0;\n\tif (v466) goto L_00B6;\nL_00EF:\n\tv474 = v409 == i;\n\tif (v474) goto L_00E6;\n\tv488 = this.powerUpIds;\n\tv491 = *([v488 @ X10_v13 (Unity.Collections.NativeArray`1<System.Int32>)+v210 @ X25_v1 (System.Int32)*4]) + 1;\n\tv493 = v491 == 0;\n\tv496 = ~v493;\n\tv497 = ~v496;\n\tif (v497) goto L_FFFFFFFF;\n\tv560 = *([v488 @ X10_v13 (Unity.Collections.NativeArray`1<System.Int32>)+v409 @ stack_-A4_v3 (System.Int32)*4]) - -1;\n\tv533 = v560 == 0;\n\tgoto L_FFFFFFFF;\n\tif (v533) goto L_011D;\n\tv508 = *([v488 @ X10_v13 (Unity.Collections.NativeArray`1<System.Int32>)+v409 @ stack_-A4_v3 (System.Int32)*4]) | *([v488 @ X10_v13 (Unity.Collections.NativeArray`1<System.Int32>)+v210 @ X25_v1 (System.Int32)*4]);\n\tv545 = Unity.Collections.NativeHashMap`2<System.UInt64, System.Byte>::ContainsKey(v279, v508);\n\tv614 = v545 == 0;\n\tv549 = ~v614;\n\tif (v549) goto L_00E6;\nL_011D:\n\tv611 = v281 == 0;\n\tv612 = ~v611;\n\tif (v612) goto L_0121;\nL_0121:\n\tv617 = this.isWater;\n\tv509 = *([v236 @ X10_v3 (Unity.Collections.NativeArray`1<System.Boolean>)+v210 @ X25_v1 (System.Int32)]) != *([v617 @ X9_v14 (Unity.Collections.NativeArray`1<System.Boolean>)+v608 @ X8_v28 (System.Int32)]);\n\tif (v509) goto L_0134;\n\tgoto L_0134;\nL_0134:\n\tv498 = v608 << 3;\n\tv631 = this.predicted + v498;\n\tv634 = *([2DD4420]) == 0;\n\tif (v634) goto L_0177;\n\tv635 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv637 = *([v635 @ X8_v62 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv639 = *([v637 @ X0_v43+E0]) == 0;\n\tif (v639) goto L_0184;\nL_0144:\n\tgoto L_0145;\nL_0145:\n\tv667 = *([v631 @ X8_v29]) - *([v81 @ X8_v4]);\n\tv668 = *([v631 @ X8_v29+4]) - *([v81 @ X8_v4+4]);\n\tv669 = v667 * v667;\n\tv523 = v668 * v668;\n\tv670 = v669 + v523;\n\tv540 = UnityEngine.Mathf::Sqrt(v670);\n\tgoto L_00E6;\n\tv675 = *([v546 @ X0_v25+E0]);\n\tv676 = v675 == 0;\n\tif (v676) goto L_0188;\n\tv678 = *([2DD442E]);\n\tv679 = v678 == 0;\n\tif (v679) goto L_FFFFFFFF;\n\tv686 = *([v51 @ X21_v2]);\n\tv687 = *([v686 @ X0_v40+E0]);\n\tv688 = v687 == 0;\n\tif (v688) goto L_FFFFFFFF;\n\tv704 = *([v698 @ X0_v38+B8]);\n\tv705 = *([v704 @ X8_v55]);\n\tv706 = 0;\n\tv707 = v705 < v540;\n\tv708 = ~v707;\n\tv709 = v705 - v540;\n\tv711 = v709 == 0;\n\tv716 = ~v708;\n\tv717 = v716 | v711;\n\tif (v717) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\nL_0177:\n\t*([2DD4420]) = 1;\n\tv657 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv644 = *([v657 @ X8_v35 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv659 = *([v644 @ X0_v24+E0]) == 0;\n\tv646 = ~v659;\n\tif (v646) goto L_0144;\nL_0184:\n\tgoto L_0145;\n\tv672 = \"il2cpp_codegen_runtime_class_init\"(v671, v507, v504, v425, v305, v61, v62, v63, v630, v443, v423, v67, v68, v69, v70, v71);\n\tv661 = *([v51 @ X21_v2]);\n\tgoto L_0145;\nL_0188:\n\tv680 = \"il2cpp_codegen_runtime_class_init\"(v546, v507, v504, v425, v305, v61, v62, v63, v539, v523, v423, v67, v68, v69, v70, v71);\n\tv685 = *([2DD442E]);\n\tv695 = v685 == 0;\n\tv683 = ~v695;\n\tif (v683) goto L_FFFFFFFF;\n\tv692 = v51;\n\tv693 = \"il2cpp_codegen_initialize_runtime_metadata\"(v692, v507, v504, v425, v305, v61, v62, v63, v539, v523, v423, v67, v68, v69, v70, v71);\n\tv723 = 1;\n\t*([2DD442E]) = v723;\n\tv699 = *([v51 @ X21_v2]);\n\tv703 = *([v699 @ X0_v36+E0]);\n\tv724 = v703 == 0;\n\tv701 = ~v724;\n\tif (v701) goto L_FFFFFFFF;\n\tv722 = \"il2cpp_codegen_runtime_class_init\"(v719, v507, v504, v425, v305, v61, v62, v63, v539, v523, v423, v67, v68, v69, v70, v71);\n\tv751 = *([v51 @ X21_v2]);\n\tv755 = *([v751 @ X0_v32+B8]);\n\tv747 = *([v755 @ X8_v48]);\n\tv734 = 0;\n\tv760 = v747 < v540;\n\tv740 = ~v760;\n\tv732 = v747 - v540;\n\tv742 = v732 == 0;\n\tv761 = ~v740;\n\tv736 = v761 | v742;\n\tif (v736) goto L_FFFFFFFF;\n\tv749 = *([v765 @ X0_v27+E0]);\n\tv768 = v749 == 0;\n\tv752 = ~v768;\n\tif (v752) goto L_FFFFFFFF;\n\tv769 = \"il2cpp_codegen_runtime_class_init\"(v765, v507, v504, v425, v305, v61, v62, v63, v763, v762, v423, v67, v68, v69, v70, v71);\n\tv774 = *([v51 @ X21_v2]);\n\tv772 = *([v774 @ X8_v44+B8]);\n\tv771 = *([v772 @ X8_v45]);\n\tgoto L_FFFFFFFF;\nL_01B2:\n\tv572 = this.deltaVel;\n\tv573 = v210 << 3;\n\tv578 = v294 * v579;\n\tv580 = v578 * v581;\n\tv582 = *([v572 @ X8_v69 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v573 @ X9_v27 (System.Int32)]) + v580;\n// ... truncated")]
	public void Execute(int i)
	{
		global::Unity.Mathematics.float2 pos = predicted[i];
		global::Unity.Mathematics.float2 vel = velocities[i];
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
					float closingSpeed = global::Unity.Mathematics.math.dot(vel - velocities[neighbor], dir);
					if (closingSpeed <= 0f)
					{
						continue;
					}
					float strength = viscosityStrengths[i];
					if (isWater[i] != isWater[neighbor])
					{
						strength *= waterReactionGlobal;
					}
					impulse -= dir * (strength * q * closingSpeed * dt * 0.5f);
				}
				while (cellMap.TryGetNextValue(out neighbor, ref it));
			}
		}
		deltaVel[i] += impulse;
	}
}
