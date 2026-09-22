[global::Cpp2ILInjected.Token(Token = "0x200006E")]
public class FixedFluid : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x200006F")]
	public enum SpecialFluidType
	{
		[global::Cpp2ILInjected.Token(Token = "0x40001EB")]
		Default = 0,
		[global::Cpp2ILInjected.Token(Token = "0x40001EC")]
		Mud = 1,
		[global::Cpp2ILInjected.Token(Token = "0x40001ED")]
		Water = 2,
		[global::Cpp2ILInjected.Token(Token = "0x40001EE")]
		Snow = 3
	}

	[global::Cpp2ILInjected.Token(Token = "0x40001E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FixedFluid.SpecialFluidType type;

	[global::Cpp2ILInjected.Token(Token = "0x40001E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int colorIdx;

	[global::Cpp2ILInjected.Token(Token = "0x40001E7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float width;

	[global::Cpp2ILInjected.Token(Token = "0x40001E8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float height;

	[global::Cpp2ILInjected.Token(Token = "0x40001E9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool isHoneyCoated;

	[global::Cpp2ILInjected.Token(Token = "0x600023A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF85C0", Offset = "0xFF85C0", Length = "0x140")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv268 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> + 0xA48;\n\tv24 = *([302A9E1]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0059;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv269 = *([v28 @ X0_v35+E0]);\n\tv30 = *([v28 @ X0_v35+E0]) == 0;\n\tif (v30) goto L_0063;\nL_0019:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v124 @ X21_v12]));\nL_001D:\n\tv182 = CollectParticleData[];\n\tv183 = Il2CppMethodInfo;\n\tv268 = v175 + 0x90;\n\tv185 = new *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v185, this, *([v183 @ X24_v8 (Il2CppMethodInfo)+538]));\n\tv232 = System.Delegate::Combine(*([v268 @ X20_v3]), v185);\n\tv79 = v232 == 0;\n\tif (v79) goto L_0068;\n\tv32 = *([v232 @ X0_v29 (System.Delegate)]) != *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v32) goto L_FFFFFFFF;\n\t*([v268 @ X20_v3]) = v232;\n\tv251 = *([v232 @ X0_v29 (System.Delegate)]) == *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v251) goto L_0074;\n\tthrow System.InvalidCastException;\nL_0059:\n\t*([v84 @ X21_v7 (System.Delegate)+9E1]) = 1;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv118 = *([v268 @ X20_v3]);\n\tv269 = *([v118 @ X0_v24+E0]);\n\tv239 = *([v118 @ X0_v24+E0]) == 0;\n\tv120 = ~v239;\n\tif (v120) goto L_0019;\nL_0063:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v148 @ X21_v6]));\n\tv208 = v175 == 0;\n\tv177 = ~v208;\n\tif (v177) goto L_001D;\n\tthrow System.NullReferenceException;\nL_0068:\n\t*([v268 @ X20_v3]) = 0;\nL_0074:\n\tv281 = 0xF3F1B4(v268, v269, v262, v260, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100);\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		Singleton<GameManager>.Instance.OnInit += OnInit;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600023B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF8700", Offset = "0xFF8700", Length = "0x420")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv38 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0030;\n\tv43 = System.Collections.Generic.NullableComparer`1;\n\tv44 = v43 + 0xD10;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv67 = Il2CppMethodInfo;\n\tv68 = v67 + 0xC90;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv72 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv73 = v72 + 0xA48;\n\tv74 = \"il2cpp_codegen_initialize_runtime_metadata\"(v73, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv76 = Il2CppMethodInfo;\n\tv77 = v76 + 0xD20;\n\tv78 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv210 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv211 = v210 + 0xB38;\n\tv212 = \"il2cpp_codegen_initialize_runtime_metadata\"(v211, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv256 = CollectParticleData[];\n\tv257 = v256 + 0x718;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v257, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv64 = 1;\n\t*([302A9E2]) = v64;\nL_0030:\n\tv66 = new *([v38 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B38])();\n\tSystem.Object::.ctor(v66);\n\tv81 = Il2CppMethodInfo;\n\tv84 = v66 + 0x18;\n\t*([v66 @ X0_v3 (System.Object)+18]) = this;\n\tv86 = 0xF3F1B4(v84, this, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tgoto L_0046;\n\tv258 = \"il2cpp_codegen_runtime_class_init\"(v213, v85, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\nL_0046:\n\tv186 = Singleton`1::get_Instance /* +1 sharing this address */(*([v81 @ X23_v3 (Il2CppMethodInfo)+C90]));\n\tv208 = v66 + 0x10;\n\t*([v66 @ X0_v3 (System.Object)+10]) = *([v186 @ X0_v16+30]);\n\tv187 = 0xF3F1B4(v208, *([v186 @ X0_v16+30]), v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv203 = *([v66 @ X0_v3 (System.Object)+10]);\n\tv337 = this.height * this.width;\n\tv340 = v337 * *([v203 @ X8_v6+54]);\n\tv342 = *([v203 @ X8_v6+50]) * 0.25f;\n\tv344 = *([v203 @ X8_v6+70]) & 0x7FFFFFFF;\n\tv346 = v344 < 0x7F800000;\n\tv347 = ~v346;\n\tv348 = v344 - 0x7F800000;\n\tv350 = v348 == 0;\n\tv357 = ~v347;\n\tv358 = v357 | v350;\n\tv359 = ~v358;\n\tif (v359) goto L_FFFFFFFF;\n\tv362 = *([v203 @ X8_v6+70]) - 0x358637BD;\n\tv378 = v362 < 0;\n\tgoto L_007D;\nL_007D:\n\tv381 = ~v378;\n\tif (v381) goto L_FFFFFFFF;\n\tgoto L_0083;\nL_0083:\n\tv101 = v340 * v342;\n\tgoto L_008E;\n\tv389 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv390 = v389 + 0x918;\n\tv391 = \"il2cpp_codegen_initialize_runtime_metadata\"(v390, v181, v47, v48, v49, v50, v51, v52, v340, v342, v165, v119, v57, v58, v59, v60);\n\tv394 = 1;\n\t*([2DD4428]) = v394;\nL_008E:\n\tv395 = CollectParticleData[];\n\tv109 = v101 / v384;\n\tgoto L_0099;\n\tv403 = \"il2cpp_codegen_runtime_class_init\"(v399, v181, v47, v48, v49, v50, v51, v52, v340, v342, v165, v119, v57, v58, v59, v60);\nL_0099:\n\tv169 = UnityEngine.Mathf::Ceil(v109);\n\tv408 = v109 - 1;\n\tv409 = v408 < 0;\n\tv410 = v408 == 0;\n\tv411 = v109 ^ 1;\n\tv412 = v109 ^ v408;\n\tv413 = v411 & v412;\n\tv414 = v413 < 0;\n\tv415 = v409 == v414;\n\tv105 = ~v410;\n\tv416 = v415 & v105;\n\tv417 = ~v416;\n\tif (v417) goto L_FFFFFFFF;\n\tgoto L_00B1;\nL_00B1:\n\tv153 = v169 - 0x7F800000;\n\tv143 = v153 == 0;\n\tv116 = ~v143;\n\tv111 = ~v116;\n\tif (v111) goto L_FFFFFFFF;\n\tgoto L_00C1;\nL_00C1:\n\tv425 = \"SzArrayNew\"(*([v395 @ X20_v7 (Il2CppClass<CollectParticleData[]>)+718]), v103, v47, v48, v49, v50, v51, v52, v169, 0x7F800000, *([v203 @ X8_v6+70]), 0x358637BD, v57, v58, v59, v60);\n\tv188 = UnityEngine.Component::get_transform(this);\n\tv170 = UnityEngine.Transform::get_position(v188);\n\tv189 = UnityEngine.Component::get_transform(this);\n\tv239 = UnityEngine.Transform::get_position(v189);\n\tv164 = v239.z;\n\tv193 = v425 == 0;\n\tif (v193) goto L_01AF;\n\tv94 = v425 + 0x24;\nL_00DE:\n\tv454 = this.width * -0.5f;\n\tv455 = this.width * 0.5f;\n\tv457 = UnityEngine.Random::Range(v454, v455);\n\tv459 = this.height * -0.5f;\n\tv173 = this.height * 0.5f;\n\tv168 = UnityEngine.Random::Range(v459, v173);\n\tv171 = v239.y + v168;\n\tv176 = v170 + v457;\n\t*([v94 @ X26_v4-4]) = v176;\n\t*([v94 @ X26_v4]) = v171;\n\tv97 = v97 + 1;\n\tv94 = v94 + 8;\n\tv432 = v103 != v97;\n\tif (v432) goto L_00DE;\n\tv328 = this.type;\n\tv462 = this.type < 3;\n\tv159 = ~v462;\n\tv154 = this.type - 3;\n\tv144 = v154 == 0;\n\tv463 = ~v144;\n\tv117 = v159 & v463;\n\tif (v117) goto L_014C;\n\tv311 = 0x2875000 + 0xA00;\n\tv274 = *([v311 @ X9_v6 (System.Int32)+v328 @ X8_v20 (FixedFluid+SpecialFluidType)]) << 2;\n\tv280 = 0xFF8978 + v274;\n\t// 279 IndirectJump v280 @ X10_v2 (System.Int32), 0, 0, 0, v47 @ X2, v48 @ X3, v49 @ X4, v50 @ X5, v51 @ X6, v52 @ X7, v171 @ V0_v18 (System.Single), v176 @ V1_v19 (System.Single), v164 @ V2_v6 (System.Single), 897988541, v57 @ V4, v58 @ V5, v59 @ V6, v60 @ V7\n\tX0 = *([X24]);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_011E;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_011E:\n\tX0 = *([X23]);\n\tX0 = Singleton`1::get_Instance /* +1 sharing this address */(X0);\n\tif (TEMP) goto L_FFFFFFFF;\n\tX22 = *([X0+30]);\n\tX19 = *([X19+24]);\n\tX8 = X8 + 0xD10;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX23 = X0;\n\tX8 = X8 + 0xD20;\n\tX2 = *([X8]);\n\tX1 = X21;\n\tX3 = 0;\n\tSystem.Action`1<ParticleInitData>::.ctor(X0, X1, X2, X3);\n\tif (TEMP) goto L_FFFFFFFF;\n\tX0 = X22;\n\tX1 = X20;\n\tX2 = X19;\n\tX3 = X23;\n\tX29 = stack[70];\n\tX30 = stack[78];\n\tX20 = stack[60];\n\tX19 = stack[68];\n\tX22 = stack[50];\n\tX21 = stack[58];\n\tX24 = stack[40];\n\tX23 = stack[48];\n\tX26 = stack[30];\n\tX25 = stack[38];\n\tV9 = stack[20];\n\tV8 = stack[28];\n\tV11 = stack[10];\n\tV10 = stack[18];\n\tV13 = stack[0];\n\tV12 = stack[8];\n\t// 325 ShiftStack 128\n\tX0 = FluidSolver::AddParticles(X0, X1, X2, X3, X4);\n\treturn;\nL_014C:\n\tgoto L_014F;\n\tv469 = \"il2cpp_codegen_runtime_class_init\"(v466, v180, v47, v48, v49, v50, v51, v52, v171, v176, v164, v119, v57, v58, v59, v60);\nL_014F:\n\tv190 = Singleton`1::get_Instance /* +1 sharing this address */(*([v81 @ X23_v3 (Il2CppMethodInfo)+C90]));\n\tv323 = FluidSolver::AddMud(*([v190 @ X0_v35+30]), v425);\n\treturn;\n\tX0 = *([X24]);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_016F;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_016F:\n\tX0 = *([X23]);\n\tX0 = Singleton`1::get_Instance /* +1 sharing this address */(X0);\n\tif (TEMP) goto L_FFFFFFFF;\n\tX0 = *([X0+30]);\n\tif (TEMP) goto L_FFFFFFFF;\n\tX1 = X20;\n\tX29 = stack[70];\n\tX30 = stack[78];\n\tX20 = stack[60];\n\tX19 = stack[68];\n\tX22 = stack[50];\n\tX21 = stack[58];\n\tX24 = stack[40];\n\tX23 = stack[48];\n\tX26 = stack[30];\n\tX25 = stack[38];\n\tV9 = stack[20];\n\tV8 = stack[28];\n\tV11 = stack[10];\n\tV10 = stack[18];\n\tV13 = stack[0];\n\tV12 = stack[8];\n\t// 391 ShiftStack 128\n\tX0 = FluidSolver::AddWaterParticles(X0, X1, X2);\n\treturn;\n\tX0 = *([X24]);\n\tX8 = *([X0+E0]);\n\tTEMP = ~TEMP;\n\tif (TEMP) goto L_0190;\n\tX0 = 0xF3F368(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\nL_0190:\n\tX0 = *([X23]);\n\tX0 = Singleton`1::get_Instance /* +1 sharing this address */(X0);\n\tif (TEMP) goto L_FFFFFFFF;\n\tX0 = *([X0+30]);\n\tif (TEMP) goto L_FFFFFFFF;\n\tX1 = X20;\n\tX29 = stack[70];\n\tX30 = stack[78];\n\tX20 = stack[60];\n\tX19 = stack[68];\n\tX22 = stack[50];\n\tX21 = stack[58];\n\tX24 = stack[40];\n\tX23 = stack[48];\n\tX26 = stack[30];\n\tX25 = stack[38];\n\tV9 = stack[20];\n\tV8 = stack[28];\n\tV11 = stack[10];\n\tV10 = stack[18];\n\tV13 = stack[0];\n\tV12 = stack[8];\n\t// 424 ShiftStack 128\n\tX0 = FluidSolver::AddSnow(X0, X1, X2);\n\treturn;\n\tv185 = new System.IndexOutOfRangeException();\n\tthrow System.NullReferenceException;\nL_01AF:\n\tv251 = this.width * -0.5f;\n\tv253 = this.width * 0.5f;\n\tv255 = UnityEngine.Random::Range(v251, v253);\n\tv262 = this.height * -0.5f;\n\tv263 = this.height * 0.5f;\n\tv265 = UnityEngine.Random::Range(v262, v263);\n\tthrow System.NullReferenceException;\n// 207 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnInit()
	{
		FluidSolver solver = Singleton<GameManager>.Instance.solver;
		float area = width * height;
		float particleCountF = area * solver.targetDensity * solver.nearPressureMultiplier * 0.25f / solver.particleMass;
		int count = global::UnityEngine.Mathf.CeilToInt(particleCountF);
		global::UnityEngine.Vector3 position = base.transform.position;
		global::Unity.Mathematics.float2[] positions = new global::Unity.Mathematics.float2[count];
		for (int i = 0; i < count; i++)
		{
			float x = position.x + global::UnityEngine.Random.Range(width * -0.5f, width * 0.5f);
			float y = position.y + global::UnityEngine.Random.Range(height * -0.5f, height * 0.5f);
			positions[i] = new global::Unity.Mathematics.float2(x, y);
		}
		switch (type)
		{
		case FixedFluid.SpecialFluidType.Mud:
			solver.AddMud(positions);
			break;
		case FixedFluid.SpecialFluidType.Water:
			solver.AddWaterParticles(positions);
			break;
		case FixedFluid.SpecialFluidType.Snow:
			solver.AddSnow(positions);
			break;
		default:
			solver.AddParticles(positions, 0, OnParticleInit);
			break;
		}
	}

	private void OnParticleInit(ParticleInitData ctx)
	{
		if (isHoneyCoated)
		{
			Singleton<GameManager>.Instance.solver.isHoneyCoated[ctx.Index] = true;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600023C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF8B28", Offset = "0xFF8B28", Length = "0xDC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0014;\n\tv17 = Il2CppMethodInfo;\n\tv18 = v17 + 0x690;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A9E3]) = v37;\nL_0014:\n\tv40 = UnityEngine.Component::get_transform(this);\n\tv43 = UnityEngine.Transform::get_parent(v40);\n\tv137 = Il2CppMethodInfo;\n\tv95 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v43, *([v137 @ X8_v5 (Il2CppMethodInfo)+690]));\n\tv60 = this.colorIdx << 4;\n\tv184 = *([v95 @ X0_v9+28]) + v60;\n\tv57 = *([v184 @ X8_v8+20]);\n\tv55 = *([v184 @ X8_v8+24]);\n\tv53 = *([v184 @ X8_v8+28]);\n\tv189 = this.type != 2;\n\tif (v189) goto L_0046;\n\tgoto L_0046;\nL_0046:\n\tv192 = this.type != 2;\n\tif (v192) goto L_004C;\n\tgoto L_004C;\nL_004C:\n\tv49 = this.type != 2;\n\tif (v49) goto L_0053;\n\tgoto L_0053;\nL_0053:\n\t// 83 MakeStruct v46 @ AGGFF8BC8_0_v3 (UnityEngine.Color), typeof(UnityEngine.Color), v57 @ V0_v4 (System.Single), v55 @ V1_v4 (System.Single), v53 @ V2_v4 (System.Single), 0.5f\n\tUnityEngine.Gizmos::set_color(v46);\n\tv96 = UnityEngine.Component::get_transform(this);\n\tv159 = UnityEngine.Transform::get_position(v96);\n\t// 104 MakeStruct v140 @ AGGFF8BF8_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), this.width (System.Single), this.height (System.Single), 0\n\tUnityEngine.Gizmos::DrawCube(v159, v140);\n\treturn;\n\tv106 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 76 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnDrawGizmos()
	{
		//IL_0051: Expected O, but got I
		//IL_0061: Expected F4, but got I
		//IL_0071: Expected F4, but got I
		//IL_0081: Expected F4, but got I
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Transform parent = transform.parent;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		int num2 = colorIdx << 4;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X0_v9+28]");
		object obj = (nint)0 + (nint)num2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+20]");
		float r = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+24]");
		float g = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X8_v8+28]");
		float b = 0f;
		if (type == FixedFluid.SpecialFluidType.Water)
		{
			r = 0.5f;
		}
		if (type == FixedFluid.SpecialFluidType.Water)
		{
			g = 0.5f;
		}
		if (type == FixedFluid.SpecialFluidType.Water)
		{
			b = 0.5f;
		}
		global::UnityEngine.Color color = default(global::UnityEngine.Color);
		color.r = r;
		color.g = g;
		color.b = b;
		color.a = 0.5f;
		global::UnityEngine.Gizmos.color = color;
		global::UnityEngine.Transform transform2 = base.transform;
		global::UnityEngine.Vector3 position = transform2.position;
		global::UnityEngine.Vector3 size = default(global::UnityEngine.Vector3);
		size.x = width;
		size.y = height;
		size.z = 0f;
		global::UnityEngine.Gizmos.DrawCube(position, size);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600023D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF8C04", Offset = "0xFF8C04", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.width = 0f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FixedFluid()
	{
		width = 0f;
	}
}
