[global::Cpp2ILInjected.Token(Token = "0x2000042")]
public abstract class Block : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	protected internal FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	protected global::UnityEngine.Transform visual;

	[global::Cpp2ILInjected.Token(Token = "0x40000F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public bool isCleared;

	[global::Cpp2ILInjected.Token(Token = "0x40000F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::System.Collections.Generic.List<global::UnityEngine.Rigidbody> fragments;

	[global::Cpp2ILInjected.Token(Token = "0x40000F8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::UnityEngine.ParticleSystem dust;

	[global::Cpp2ILInjected.Token(Token = "0x40000F9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public global::UnityEngine.AudioClip shatterClip;

	[global::Cpp2ILInjected.Token(Token = "0x6000173")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE81BC", Offset = "0xFE81BC", Length = "0x1AC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302A000;\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv24 = *([302A970]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_002B;\n\tv55 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv30 = *([v28 @ X0_v45+E0]) == 0;\n\tif (v30) goto L_0035;\nL_0019:\n\tv74 = Singleton`1::get_Instance /* +1 sharing this address */(*([v55 @ X21_v13]));\n\tv67 = v74 == 0;\n\tv68 = ~v67;\n\tif (v68) goto L_0038;\n\tgoto L_0087;\nL_002B:\n\t*([v20 @ X21_v1+970]) = 1;\n\tv55 = Il2CppMethodInfo + 0xC90;\n\tv50 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv106 = *([v50 @ X0_v41+E0]) == 0;\n\tv52 = ~v106;\n\tif (v52) goto L_0019;\nL_0035:\n\tv74 = Singleton`1::get_Instance /* +1 sharing this address */(*([v62 @ X21_v10]));\nL_0038:\n\tv79 = Il2CppMethodInfo;\n\tv83 = this + 0x20;\n\tthis.solver = *([v74 @ X0_v6+30]);\n\tv84 = 0xF3F1B4(v83, *([v74 @ X0_v6+30]), v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv92 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v79 @ X20_v5 (Il2CppMethodInfo)+678]));\n\tv98 = this + 0x28;\n\tthis.visual = *([v92 @ X0_v11+28]);\n\tv93 = 0xF3F1B4(v98, *([v92 @ X0_v11+28]), v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv100 = this.solver;\n\tv172 = System.Collections.Generic.NullableComparer`1;\n\tv125 = this.solver + 0x260;\n\tv175 = new *([v172 @ X23_v2 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8])();\n\tv127 = this->klass;\n\tSystem.Action`2<System.Object, System.Boolean>::.ctor(v175, this, *([v127 @ X8_v6 (Il2CppClass<Block>)+1A0]));\n\tv180 = System.Delegate::Combine(v100.OnStartRemoveParticles, v175);\n\tv158 = v180 == 0;\n\tif (v158) goto L_007A;\n\tv119 = 0xF3F36C(v180, *([v172 @ X23_v2 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv122 = v119 == 0;\n\tif (v122) goto L_008A;\n\tv100.OnStartRemoveParticles = v119;\n\tv120 = 0xF3F36C(v180, *([v172 @ X23_v2 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv123 = v120 == 0;\n\tif (v123) goto L_008A;\n\tv155 = 0xF3F1B4(v125, v120, 0, 0, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\treturn;\nL_007A:\n\tv100.OnStartRemoveParticles = 0;\n\tv156 = 0xF3F1B4(v125, 0, 0, 0, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\treturn;\nL_0087:\n\tthrow System.NullReferenceException;\nL_008A:\n\tthrow System.InvalidCastException;\n// 88 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public virtual void OnEnable()
	{
		solver = Singleton<GameManager>.Instance.solver;
		visual = GetComponent<InterpolateChild>().visual;
		solver.OnStartRemoveParticles += CheckClear;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000174")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE8368", Offset = "0xFE8368", Length = "0x158")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302A000;\n\tv22 = CollectParticleData[];\n\tv24 = *([302A971]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0050;\n\tv26 = *([v22 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv28 = *([v26 @ X0_v33+E0]) == 0;\n\tif (v28) goto L_0058;\nL_0017:\n\tv54 = UnityEngine.Application::get_isPlaying();\n\tv62 = ~v54;\n\tif (v62) goto L_0065;\nL_001A:\n\tv71 = this.solver;\n\tv85 = this.solver + 0x260;\n\tv87 = System.Collections.Generic.NullableComparer`1;\n\tv90 = new *([v87 @ X23_v3 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8])();\n\tv107 = this->klass;\n\tSystem.Action`2<System.Object, System.Boolean>::.ctor(v90, this, *([v107 @ X8_v9 (Il2CppClass<Block>)+1A0]));\n\tv152 = System.Delegate::Remove(v71.OnStartRemoveParticles, v90);\n\tv134 = v152 == 0;\n\tif (v134) goto L_0067;\n\tv155 = 0xF3F36C(v152, *([v87 @ X23_v3 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv157 = v155 == 0;\n\tif (v157) goto L_0076;\n\tv71.OnStartRemoveParticles = v155;\n\tv161 = 0xF3F36C(v152, *([v87 @ X23_v3 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv133 = v161 == 0;\n\tif (v133) goto L_0076;\n\tv130 = 0xF3F1B4(v85, v161, 0, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturn;\nL_0050:\n\t*([v20 @ X19_v1+971]) = 1;\n\tv48 = *([v22 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv66 = *([v48 @ X0_v12+E0]) == 0;\n\tv50 = ~v66;\n\tif (v50) goto L_0017;\nL_0058:\n\tv64 = UnityEngine.Application::get_isPlaying();\n\tv84 = ~v64;\n\tv69 = ~v84;\n\tif (v69) goto L_001A;\nL_0065:\n\treturn;\nL_0067:\n\tv71.OnStartRemoveParticles = 0;\n\tv131 = 0xF3F1B4(v85, 0, 0, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturn;\nL_0076:\n\tv101 = new System.InvalidCastException();\n\tthrow System.NullReferenceException;\n// 77 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public virtual void OnDisable()
	{
		if (!global::UnityEngine.Application.isPlaying)
		{
			return;
		}
		solver.OnStartRemoveParticles -= CheckClear;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000175")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE84C0", Offset = "0xFE84C0", Length = "0x2A4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002F;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x968;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv69 = Il2CppMethodInfo;\n\tv70 = v69 + 0x970;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv165 = Il2CppMethodInfo;\n\tv166 = v165 + 0x978;\n\tv167 = \"il2cpp_codegen_initialize_runtime_metadata\"(v166, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv173 = Il2CppMethodInfo;\n\tv174 = v173 + 0x998;\n\tv175 = \"il2cpp_codegen_initialize_runtime_metadata\"(v174, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv233 = Il2CppMethodInfo;\n\tv234 = v233 + 0xC28;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v234, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv63 = 1;\n\t*([302A972]) = v63;\nL_002F:\n\tv68 = v241 == 0;\n\tif (v68) goto L_00BA;\n\tv74 = Il2CppMethodInfo;\n\tv76 = Il2CppMethodInfo;\n\tv78 = Il2CppMethodInfo;\n\tv161 = Il2CppMethodInfo + 0x968;\n\tv84 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v241);\n\tgoto L_005A;\nL_004A:\n\tv419 = v403.y - *([v395 @ X8_v16+4]);\n\tv420 = v387 - *([v395 @ X8_v16]);\n\tv132 = v420 * v420;\n\tv421 = v419 * v419;\n\tv422 = v132 + v421;\n\tv205 = UnityEngine.Mathf::Sqrt(v422);\n\tv200 = v205 < 0.5f;\n\tif (v200) goto L_009C;\nL_005A:\n\tv241 = *([v74 @ X22_v4 (Il2CppMethodInfo)+970]);\n\tv221 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v82 @ stack_-C0_v5 (System.Single), *([v74 @ X22_v4 (Il2CppMethodInfo)+970]));\n\tv235 = v221 & 1;\n\tv236 = v235 == 0;\n\tif (v236) goto L_009F;\n\tv251 = this.solver == 0;\n\tif (v251) goto L_00B2;\n\tv283 = this.solver + 0x1F8;\n\tv106 = *([v76 @ X23_v4 (Il2CppMethodInfo)+C28]);\n\tv212 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v283, v170, &v190 @ stack_-A4_v7, *([v76 @ X23_v4 (Il2CppMethodInfo)+C28]));\n\tv341 = v212 & 1;\n\tv215 = v341 == 0;\n\tif (v215) goto L_005A;\n\tv383 = this.solver;\n\tv384 = this.solver == 0;\n\tif (v384) goto L_00B6;\n\tv186 = v190 << 3;\n\tv395 = v383.positions + v186;\n\tv399 = UnityEngine.Component::get_transform(this);\n\tv387 = UnityEngine.Transform::get_position(v399);\n\tv402 = UnityEngine.Component::get_transform(this);\n\tv394 = v402 == 0;\n\tif (v394) goto L_00B4;\n\tv403 = UnityEngine.Transform::get_position(v402);\n\tv90 = v403.z;\n\tv406 = *([2DD4420]) == 0;\n\tif (v406) goto L_0093;\n\tgoto L_004A;\n\tgoto L_FFFFFFFF;\nL_0093:\n\t*([2DD4420]) = 1;\n\tgoto L_004A;\n\tgoto L_004A;\nL_009C:\n\tBlock::ShatterDestroy(this);\nL_009F:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v82 @ stack_-C0_v5 (System.Single), *([v78 @ X21_v5 (Il2CppMethodInfo)+968]));\nL_00B1:\n\treturn;\nL_00B2:\n\tv284 = new System.NullReferenceException();\n\tgoto L_00B9;\nL_00B4:\n\tv391 = new System.NullReferenceException();\n\tgoto L_00B9;\nL_00B6:\n\tv392 = new System.NullReferenceException();\n\tgoto L_00B9;\n\tv390 = new System.NullReferenceException();\nL_00B9:\n\t// 185 Interrupt\nL_00BA:\n\tv164 = new System.NullReferenceException();\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\nL_00D0:\n\tv232 = v241 != 1;\n\tif (v232) goto L_00E0;\n\tv238 = 0x274A080(v164, v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\tv280 = 0x274A098(v238, v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\tv241 = *([v161 @ X21_v2 (System.Int32)]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v82 @ stack_-C0_v5 (System.Single), *([v161 @ X21_v2 (System.Int32)]));\n\tv246 = *([v238 @ X0_v11]) == 0;\n\tif (v246) goto L_00B1;\n\tv244 = new System.OutOfMemoryException();\nL_00E0:\n\tv250 = 0xBF092C(&v150 @ stack_-C0 (System.Int32), v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\tv282 = 0x27498DC(v247, v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\tv340 = 0xD6F8(v282, v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\treturn;\n// 127 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected virtual void CheckClear(global::System.Collections.Generic.HashSet<int> particleIds, bool explode)
	{
		if (particleIds == null)
		{
			return;
		}
		foreach (int particleId in particleIds)
		{
			if (solver == null)
			{
				throw new global::System.NullReferenceException();
			}
			if (!solver.idToIndex.TryGetValue(particleId, out int index))
			{
				continue;
			}
			global::Unity.Mathematics.float2 particlePos = solver.positions[index];
			global::UnityEngine.Vector3 position = base.transform.position;
			float dx = position.x - particlePos.x;
			float dy = position.y - particlePos.y;
			float dist = global::UnityEngine.Mathf.Sqrt(dx * dx + dy * dy);
			if (dist < 0.5f)
			{
				ShatterDestroy();
				return;
			}
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000176")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE8764", Offset = "0xFE8764", Length = "0x59C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_005B;\n\tv49 = CollectParticleData[];\n\tv50 = v49 + 0xCF8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv75 = Il2CppMethodInfo;\n\tv76 = v75 + 0x5F8;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv79 = Il2CppMethodInfo;\n\tv80 = v79 + 0x640;\n\tv81 = \"il2cpp_codegen_initialize_runtime_metadata\"(v80, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv320 = Il2CppMethodInfo;\n\tv321 = v320 + 0x6A8;\n\tv322 = \"il2cpp_codegen_initialize_runtime_metadata\"(v321, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv329 = Il2CppMethodInfo;\n\tv330 = v329 + 0x768;\n\tv331 = \"il2cpp_codegen_initialize_runtime_metadata\"(v330, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv420 = Il2CppMethodInfo;\n\tv421 = v420 + 0x818;\n\tv422 = \"il2cpp_codegen_initialize_runtime_metadata\"(v421, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv428 = Il2CppMethodInfo;\n\tv429 = v428 + 0x48;\n\tv430 = \"il2cpp_codegen_initialize_runtime_metadata\"(v429, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv432 = Il2CppMethodInfo;\n\tv433 = v432 + 0x50;\n\tv434 = \"il2cpp_codegen_initialize_runtime_metadata\"(v433, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv435 = Il2CppMethodInfo;\n\tv436 = v435 + 0xF8;\n\tv437 = \"il2cpp_codegen_initialize_runtime_metadata\"(v436, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv439 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv440 = v439 + 0xFD8;\n\tv441 = \"il2cpp_codegen_initialize_runtime_metadata\"(v440, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv442 = Il2CppMethodInfo;\n\tv443 = v442 + 0xC90;\n\tv444 = \"il2cpp_codegen_initialize_runtime_metadata\"(v443, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv446 = Il2CppMethodInfo;\n\tv447 = v446 + 0xC70;\n\tv448 = \"il2cpp_codegen_initialize_runtime_metadata\"(v447, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv451 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv452 = v451 + 0xA38;\n\tv453 = \"il2cpp_codegen_initialize_runtime_metadata\"(v452, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv458 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv459 = v458 + 0xA48;\n\tv460 = \"il2cpp_codegen_initialize_runtime_metadata\"(v459, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv474 = System.Net.Configuration.SettingsSectionInternal;\n\tv475 = v474 + 0xB48;\n\tv476 = \"il2cpp_codegen_initialize_runtime_metadata\"(v475, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv480 = Il2CppMethodInfo;\n\tv481 = v480 + 0xF10;\n\tv482 = \"il2cpp_codegen_initialize_runtime_metadata\"(v481, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv484 = Il2CppMethodInfo;\n\tv485 = v484 + 0xF70;\n\tv486 = \"il2cpp_codegen_initialize_runtime_metadata\"(v485, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv488 = Il2CppMethodInfo;\n\tv489 = v488 + 0xFA0;\n\tv490 = \"il2cpp_codegen_initialize_runtime_metadata\"(v489, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv492 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv493 = v492 + 0xB8;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v493, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv70 = 1;\n\t*([302A973]) = v70;\nL_005B:\n\tv74 = UnityEngine.Component::get_transform(this);\n\tv222 = UnityEngine.Transform::get_position(v74);\n\tv214 = v222.y;\n\tv207 = v222.z;\n\tgoto L_0071;\n\tv332 = System.Runtime.Serialization.ObjectHolderList;\n\tv333 = v332 + 0x538;\n\tv334 = \"il2cpp_codegen_initialize_runtime_metadata\"(v333, v84, v53, v54, v55, v56, v57, v58, v85, v323, v324, v62, v63, v64, v65, v66);\n\tv337 = 1;\n\t*([2DD4418]) = v337;\nL_0071:\n\tv338 = Il2CppMethodInfo;\n\tv339 = System.Runtime.Serialization.ObjectHolderList;\n\tv341 = *([v339 @ X8_v6 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+538]);\n\tv342 = *([v341 @ X8_v8+B8]);\n\tgoto L_008B;\n\tv423 = \"il2cpp_codegen_runtime_class_init\"(v343, v84, v53, v54, v55, v56, v57, v58, v85, v323, v324, v62, v63, v64, v65, v66);\nL_008B:\n\t// 139 MakeStruct v167 @ AGGFE8930_2_v2 (UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), [v342 @ X8_v9], [v342 @ X8_v9+4], [v342 @ X8_v9+8], [v342 @ X8_v9+C]\n\tv427 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.dust, v222, v167, *([v338 @ X21_v3 (Il2CppMethodInfo)+F8]));\n\tthis.isCleared = 1;\n\tv257 = UnityEngine.Component::get_transform(this);\n\tv438 = Il2CppMethodInfo;\n\tv258 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v257, *([v438 @ X8_v12 (Il2CppMethodInfo)+5F8]));\n\tUnityEngine.Behaviour::set_enabled(v258, 0);\n\tv259 = Block::OnClear(this);\n\tv472 = this.fragments;\n\tv455 = Il2CppMethodInfo;\nL_00B8:\n\tv88 = v316 >= v472._size;\n\tif (v88) goto L_0147;\n\tv477 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv479 = new *([v477 @ X8_v40 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B8])();\n\tSystem.Object::.ctor(v479);\n\tv491 = Il2CppMethodInfo;\n\tv261 = System.Collections.Generic.List`1<UnityEngine.Rigidbody>::get_Item(this.fragments, v316);\n\tv253 = v479 + 0x10;\n\t*([v479 @ X0_v43 (System.Object)+10]) = v261;\n\tv496 = 0xF3F1B4(v253, v261, *([v491 @ X8_v42 (Il2CppMethodInfo)+50]), 0, v55, v56, v57, v58, v222, v214, v207, v185, v181, v177, v173, v223.y);\n\tv263 = UnityEngine.Component::get_gameObject(*([v479 @ X0_v43 (System.Object)+10]));\n\tUnityEngine.GameObject::SetActive(v263, 1);\n\tv265 = UnityEngine.Component::get_transform(*([v479 @ X0_v43 (System.Object)+10]));\n\tUnityEngine.Transform::set_parent(v265, 0);\n\tv266 = UnityEngine.Component::get_transform(this);\n\tv223 = UnityEngine.Transform::get_position(v266);\n\tUnityEngine.Rigidbody::AddExplosionForce(*([v479 @ X0_v43 (System.Object)+10]), 300f, v223, 1f, 0.2f);\n\tUnityEngine.Rigidbody::set_maxAngularVelocity(*([v479 @ X0_v43 (System.Object)+10]), 1000f);\n\tv225 = UnityEngine.Random::get_onUnitSphere();\n\tv268 = UnityEngine.Random::Range(0xFFFFFFF6, 0xA);\n\tv207 = v225.z * v268;\n\tv218 = v225.y * v268;\n\tv226 = v225 * v268;\n\t// 281 MakeStruct v127 @ AGGFE8AF0_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v226 @ V0_v11 (System.Single), v218 @ V1_v8 (System.Single), v207 @ V2_v4 (System.Single)\n\tUnityEngine.Rigidbody::AddTorque(*([v479 @ X0_v43 (System.Object)+10]), v127, 1);\n\tv204 = v316 * 0x3CA3D70A;\n\tv550 = Il2CppMethodInfo;\n\tv553 = UnityEngine.Component::GetComponent /* +1 sharing this address */(*([v479 @ X0_v43 (System.Object)+10]), *([v550 @ X8_v44 (Il2CppMethodInfo)+768]));\n\tv556 = DG.Tweening.ShortcutExtensions::DOScale(v553, 0f, 1f);\n\tv557 = Il2CppMethodInfo;\n\tv560 = DG.Tweening.TweenSettingsExtensions::SetDelay /* +1 sharing this address */(v556, v204, *([v557 @ X8_v46 (Il2CppMethodInfo)+F70]));\n\tv561 = System.Net.Configuration.SettingsSectionInternal;\n\tv564 = new *([v561 @ X8_v48 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B48])();\n\tv565 = Il2CppMethodInfo;\n\tDG.Tweening.TweenCallback::.ctor(v564, v479, *([v565 @ X8_v50 (Il2CppMethodInfo)+FA0]));\n\tv270 = DG.Tweening.TweenSettingsExtensions::OnComplete /* +1 sharing this address */(v560, v564, *([v455 @ X25_v2 (Il2CppMethodInfo)+F10]));\n\tv316 = v316 + 1;\n\tv472 = this.fragments;\n\tv570 = this.fragments == 0;\n\tv293 = ~v570;\n\tif (v293) goto L_00B8;\n\tgoto L_01BA;\nL_0147:\n\tv483 = Il2CppMethodInfo;\n\tv272 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this.visual, *([v483 @ X8_v18 (Il2CppMethodInfo)+6A8]));\n\tUnityEngine.Renderer::set_enabled(v272, 0);\n\tv497 = Il2CppMethodInfo;\n\tv274 = UnityEngine.Component::GetComponen\n// ... truncated")]
	protected internal void ShatterDestroy()
	{
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Object.Instantiate(dust, transform.position, global::UnityEngine.Quaternion.identity);
		isCleared = true;
		global::UnityEngine.Collider2D collider = GetComponent<global::UnityEngine.Collider2D>();
		if (collider != null)
		{
			collider.enabled = false;
		}
		OnClear();
		for (int i = 0; i < fragments.Count; i++)
		{
			global::UnityEngine.Rigidbody rigidbody = fragments[i];
			global::UnityEngine.GameObject gameObject = rigidbody.gameObject;
			gameObject.SetActive(value: true);
			rigidbody.transform.parent = null;
			global::UnityEngine.Vector3 position = transform.position;
			rigidbody.AddExplosionForce(300f, position, 1f, 0.2f);
			rigidbody.maxAngularVelocity = 1000f;
			global::UnityEngine.Vector3 onUnitSphere = global::UnityEngine.Random.onUnitSphere;
			int torqueScale = global::UnityEngine.Random.Range(-10, 10);
			global::UnityEngine.Vector3 torque = onUnitSphere * torqueScale;
			rigidbody.AddTorque(torque, global::UnityEngine.ForceMode.Impulse);
			float delay = i * 0.02f;
			global::UnityEngine.Rigidbody capturedRigidbody = rigidbody;
			var tween = global::DG.Tweening.TweenSettingsExtensions.SetDelay(global::DG.Tweening.ShortcutExtensions.DOScale(rigidbody.transform, 0f, 1f), delay);
			global::DG.Tweening.TweenSettingsExtensions.OnComplete(tween, delegate
			{
				global::UnityEngine.Object.Destroy(capturedRigidbody.gameObject);
			});
		}
		global::UnityEngine.Renderer renderer = visual.GetComponent<global::UnityEngine.Renderer>();
		if (renderer != null)
		{
			renderer.enabled = false;
		}
		Singleton<GameManager>.Instance.coupler.RefreshBodies();
		Singleton<AudioManager>.Instance.PlayClip(shatterClip, new AudioClipSettings { pitchVariance = 0.2f, volume = 0.1f });
		Singleton<GameManager>.Instance.level.blocks.Remove(this);
		global::UnityEngine.Object.Destroy(base.gameObject);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000177")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE8D08", Offset = "0xFE8D08", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tBlock::ShatterDestroy(this);\n\treturn;\n")]
	public void OnPowerUpHit()
	{
		ShatterDestroy();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000178")]
	public abstract void OnClear();

	[global::Cpp2ILInjected.Token(Token = "0x6000179")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE8D0C", Offset = "0xFE8D0C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal Block()
	{
	}
}
