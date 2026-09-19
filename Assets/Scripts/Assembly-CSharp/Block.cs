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
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00dc: Expected O, but got I
		//IL_00ec: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0157: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_018e: Expected O, but got I
		//IL_01b5: Expected I, but got O
		//IL_01c6: Expected O, but got I
		//IL_01e1: Expected I, but got O
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A970]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X0_v45+E0]");
			bool flag = (nint)0 == 0;
			object obj4 = obj2;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X0_v41+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			if (flag3)
			{
				goto IL_0093;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		goto IL_0133;
		IL_0133:
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X0_v6+30]");
		solver = (FluidSolver)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v11+28]");
		visual = (global::UnityEngine.Transform)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		FluidSolver fluidSolver = solver;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v127 @ X8_v6 (Il2CppClass<Block>)+1A0]");
		global::System.Delegate b = new global::System.Action<object, bool>(this, (global::System.IntPtr)0);
		global::System.Delegate obj9 = global::System.Delegate.Combine(fluidSolver.OnStartRemoveParticles, b);
		if ((object)obj9 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<global::System.Collections.Generic.HashSet<int>, bool> action = default(global::System.Action<global::System.Collections.Generic.HashSet<int>, bool>);
			if (action != null)
			{
				fluidSolver.OnStartRemoveParticles = action;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				object obj10 = default(object);
				if (obj10 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					return;
				}
			}
			throw new global::System.InvalidCastException();
		}
		fluidSolver.OnStartRemoveParticles = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return;
		IL_0093:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj11 = default(object);
		if (obj11 == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_0133;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000174")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE8368", Offset = "0xFE8368", Length = "0x158")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302A000;\n\tv22 = CollectParticleData[];\n\tv24 = *([302A971]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0050;\n\tv26 = *([v22 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv28 = *([v26 @ X0_v33+E0]) == 0;\n\tif (v28) goto L_0058;\nL_0017:\n\tv54 = UnityEngine.Application::get_isPlaying();\n\tv62 = ~v54;\n\tif (v62) goto L_0065;\nL_001A:\n\tv71 = this.solver;\n\tv85 = this.solver + 0x260;\n\tv87 = System.Collections.Generic.NullableComparer`1;\n\tv90 = new *([v87 @ X23_v3 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8])();\n\tv107 = this->klass;\n\tSystem.Action`2<System.Object, System.Boolean>::.ctor(v90, this, *([v107 @ X8_v9 (Il2CppClass<Block>)+1A0]));\n\tv152 = System.Delegate::Remove(v71.OnStartRemoveParticles, v90);\n\tv134 = v152 == 0;\n\tif (v134) goto L_0067;\n\tv155 = 0xF3F36C(v152, *([v87 @ X23_v3 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv157 = v155 == 0;\n\tif (v157) goto L_0076;\n\tv71.OnStartRemoveParticles = v155;\n\tv161 = 0xF3F36C(v152, *([v87 @ X23_v3 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv133 = v161 == 0;\n\tif (v133) goto L_0076;\n\tv130 = 0xF3F1B4(v85, v161, 0, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturn;\nL_0050:\n\t*([v20 @ X19_v1+971]) = 1;\n\tv48 = *([v22 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv66 = *([v48 @ X0_v12+E0]) == 0;\n\tv50 = ~v66;\n\tif (v50) goto L_0017;\nL_0058:\n\tv64 = UnityEngine.Application::get_isPlaying();\n\tv84 = ~v64;\n\tv69 = ~v84;\n\tif (v69) goto L_001A;\nL_0065:\n\treturn;\nL_0067:\n\tv71.OnStartRemoveParticles = 0;\n\tv131 = 0xF3F1B4(v85, 0, 0, 0, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturn;\nL_0076:\n\tv101 = new System.InvalidCastException();\n\tthrow System.NullReferenceException;\n// 77 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public virtual void OnDisable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_019f: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_00c1: Expected O, but got I
		//IL_00cf: Expected I, but got O
		//IL_00ea: Expected I, but got O
		object obj = 50503680;
		nint num = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A971]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X0_v33+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		if (!global::UnityEngine.Application.isPlaying)
		{
			return;
		}
		goto IL_00a1;
		IL_00a1:
		FluidSolver fluidSolver = solver;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v107 @ X8_v9 (Il2CppClass<Block>)+1A0]");
		global::System.Delegate value = new global::System.Action<object, bool>(this, (global::System.IntPtr)0);
		global::System.Delegate obj5 = global::System.Delegate.Remove(fluidSolver.OnStartRemoveParticles, value);
		if ((object)obj5 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<global::System.Collections.Generic.HashSet<int>, bool> action = default(global::System.Action<global::System.Collections.Generic.HashSet<int>, bool>);
			if (action != null)
			{
				fluidSolver.OnStartRemoveParticles = action;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				object obj6 = default(object);
				if (obj6 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					return;
				}
			}
			global::System.InvalidCastException ex = new global::System.InvalidCastException();
			throw new global::System.NullReferenceException();
		}
		fluidSolver.OnStartRemoveParticles = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return;
		IL_007f:
		if (global::UnityEngine.Application.isPlaying)
		{
			goto IL_00a1;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000175")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE84C0", Offset = "0xFE84C0", Length = "0x2A4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002F;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x968;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv69 = Il2CppMethodInfo;\n\tv70 = v69 + 0x970;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv165 = Il2CppMethodInfo;\n\tv166 = v165 + 0x978;\n\tv167 = \"il2cpp_codegen_initialize_runtime_metadata\"(v166, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv173 = Il2CppMethodInfo;\n\tv174 = v173 + 0x998;\n\tv175 = \"il2cpp_codegen_initialize_runtime_metadata\"(v174, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv233 = Il2CppMethodInfo;\n\tv234 = v233 + 0xC28;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v234, particleIds, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv63 = 1;\n\t*([302A972]) = v63;\nL_002F:\n\tv68 = v241 == 0;\n\tif (v68) goto L_00BA;\n\tv74 = Il2CppMethodInfo;\n\tv76 = Il2CppMethodInfo;\n\tv78 = Il2CppMethodInfo;\n\tv161 = Il2CppMethodInfo + 0x968;\n\tv84 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v241);\n\tgoto L_005A;\nL_004A:\n\tv419 = v403.y - *([v395 @ X8_v16+4]);\n\tv420 = v387 - *([v395 @ X8_v16]);\n\tv132 = v420 * v420;\n\tv421 = v419 * v419;\n\tv422 = v132 + v421;\n\tv205 = UnityEngine.Mathf::Sqrt(v422);\n\tv200 = v205 < 0.5f;\n\tif (v200) goto L_009C;\nL_005A:\n\tv241 = *([v74 @ X22_v4 (Il2CppMethodInfo)+970]);\n\tv221 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v82 @ stack_-C0_v5 (System.Single), *([v74 @ X22_v4 (Il2CppMethodInfo)+970]));\n\tv235 = v221 & 1;\n\tv236 = v235 == 0;\n\tif (v236) goto L_009F;\n\tv251 = this.solver == 0;\n\tif (v251) goto L_00B2;\n\tv283 = this.solver + 0x1F8;\n\tv106 = *([v76 @ X23_v4 (Il2CppMethodInfo)+C28]);\n\tv212 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v283, v170, &v190 @ stack_-A4_v7, *([v76 @ X23_v4 (Il2CppMethodInfo)+C28]));\n\tv341 = v212 & 1;\n\tv215 = v341 == 0;\n\tif (v215) goto L_005A;\n\tv383 = this.solver;\n\tv384 = this.solver == 0;\n\tif (v384) goto L_00B6;\n\tv186 = v190 << 3;\n\tv395 = v383.positions + v186;\n\tv399 = UnityEngine.Component::get_transform(this);\n\tv387 = UnityEngine.Transform::get_position(v399);\n\tv402 = UnityEngine.Component::get_transform(this);\n\tv394 = v402 == 0;\n\tif (v394) goto L_00B4;\n\tv403 = UnityEngine.Transform::get_position(v402);\n\tv90 = v403.z;\n\tv406 = *([2DD4420]) == 0;\n\tif (v406) goto L_0093;\n\tgoto L_004A;\n\tgoto L_FFFFFFFF;\nL_0093:\n\t*([2DD4420]) = 1;\n\tgoto L_004A;\n\tgoto L_004A;\nL_009C:\n\tBlock::ShatterDestroy(this);\nL_009F:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v82 @ stack_-C0_v5 (System.Single), *([v78 @ X21_v5 (Il2CppMethodInfo)+968]));\nL_00B1:\n\treturn;\nL_00B2:\n\tv284 = new System.NullReferenceException();\n\tgoto L_00B9;\nL_00B4:\n\tv391 = new System.NullReferenceException();\n\tgoto L_00B9;\nL_00B6:\n\tv392 = new System.NullReferenceException();\n\tgoto L_00B9;\n\tv390 = new System.NullReferenceException();\nL_00B9:\n\t// 185 Interrupt\nL_00BA:\n\tv164 = new System.NullReferenceException();\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\n\tgoto L_00D0;\nL_00D0:\n\tv232 = v241 != 1;\n\tif (v232) goto L_00E0;\n\tv238 = 0x274A080(v164, v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\tv280 = 0x274A098(v238, v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\tv241 = *([v161 @ X21_v2 (System.Int32)]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v82 @ stack_-C0_v5 (System.Single), *([v161 @ X21_v2 (System.Int32)]));\n\tv246 = *([v238 @ X0_v11]) == 0;\n\tif (v246) goto L_00B1;\n\tv244 = new System.OutOfMemoryException();\nL_00E0:\n\tv250 = 0xBF092C(&v150 @ stack_-C0 (System.Int32), v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\tv282 = 0x27498DC(v247, v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\tv340 = 0xD6F8(v282, v241, v191, v193, v48, v49, v50, v51, v205, v132, v90, v55, v56, v57, v58, v59);\n\treturn;\n// 127 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected unsafe virtual void CheckClear(global::System.Collections.Generic.HashSet<int> particleIds, bool explode)
	{
		//IL_00e7: Expected O, but got I
		//IL_037d: Expected O, but got I4
		//IL_03b5: Expected I4, but got O
		//IL_014d: Expected O, but got I
		//IL_01f0: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f5: Expected O, but got Unknown
		global::System.Collections.Generic.HashSet<int> hashSet = default(global::System.Collections.Generic.HashSet<int>);
		bool flag = hashSet == null;
		int num = 50503680;
		if (!flag)
		{
			nint num2 = 0;
			nint num3 = 0;
			nint num4 = 0;
			num = (int)((nint)0 + (nint)2408);
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator();
			float num6 = default(float);
			float num5 = num6;
			object obj = default(object);
			object obj2 = default(object);
			nint num7 = default(nint);
			object obj4 = default(object);
			global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
			nint num9;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X22_v4 (Il2CppMethodInfo)+970]");
				hashSet = (global::System.Collections.Generic.HashSet<int>)0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj & 1) != 0)
				{
					bool flag2;
					if ((object)solver == null)
					{
						global::System.NullReferenceException ex = new global::System.NullReferenceException();
						flag2 = obj2 != null;
						hashSet = null;
						break;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X23_v4 (Il2CppMethodInfo)+C28]");
					num7 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					int num8 = (int)((nint)obj4 & 1);
					bool flag3 = num8 == 0;
					flag2 = obj2 != null;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X23_v4 (Il2CppMethodInfo)+C28]");
					num9 = 0;
					if (flag3)
					{
						continue;
					}
					FluidSolver fluidSolver = solver;
					float z;
					float y;
					if ((object)solver == null)
					{
						global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
						z = position.z;
						flag2 = obj2 != null;
						y = position.y;
						num5 = position.x;
						hashSet = null;
						break;
					}
					int num10 = (int)((nint)obj2 << 3);
					object obj5 = fluidSolver.positions + num10;
					global::UnityEngine.Transform transform = base.transform;
					position = transform.position;
					global::UnityEngine.Transform transform2 = base.transform;
					if ((object)transform2 == null)
					{
						global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
						num7 = num7;
						break;
					}
					global::UnityEngine.Vector3 position2 = transform2.position;
					z = position2.z;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
					if ((nint)0 == 0)
					{
						_ = 1;
					}
					float num11 = position2.y;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v395 @ X8_v16+4]");
					float num12 = num11 - 0f;
					float num13 = position.x - (float)obj5;
					y = num13 * num13;
					float num14 = num12 * num12;
					float f = y + num14;
					num5 = global::UnityEngine.Mathf.Sqrt(f);
					bool flag4 = num5 < 0.5f;
					flag2 = obj2 != null;
					num9 = num7;
					if (!flag4)
					{
						continue;
					}
					ShatterDestroy();
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				return;
			}
			num9 = num7;
			int num15 = 0;
		}
		global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
		bool flag5 = (nint)hashSet != 1;
		global::System.NullReferenceException ex5 = ex4;
		if (!flag5)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			hashSet = (global::System.Collections.Generic.HashSet<int>)num;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex6 = new global::System.OutOfMemoryException();
			int num15 = (int)obj6;
			ex5 = (global::System.NullReferenceException)(object)ex6;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000176")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE8764", Offset = "0xFE8764", Length = "0x59C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_005B;\n\tv49 = CollectParticleData[];\n\tv50 = v49 + 0xCF8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv75 = Il2CppMethodInfo;\n\tv76 = v75 + 0x5F8;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv79 = Il2CppMethodInfo;\n\tv80 = v79 + 0x640;\n\tv81 = \"il2cpp_codegen_initialize_runtime_metadata\"(v80, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv320 = Il2CppMethodInfo;\n\tv321 = v320 + 0x6A8;\n\tv322 = \"il2cpp_codegen_initialize_runtime_metadata\"(v321, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv329 = Il2CppMethodInfo;\n\tv330 = v329 + 0x768;\n\tv331 = \"il2cpp_codegen_initialize_runtime_metadata\"(v330, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv420 = Il2CppMethodInfo;\n\tv421 = v420 + 0x818;\n\tv422 = \"il2cpp_codegen_initialize_runtime_metadata\"(v421, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv428 = Il2CppMethodInfo;\n\tv429 = v428 + 0x48;\n\tv430 = \"il2cpp_codegen_initialize_runtime_metadata\"(v429, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv432 = Il2CppMethodInfo;\n\tv433 = v432 + 0x50;\n\tv434 = \"il2cpp_codegen_initialize_runtime_metadata\"(v433, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv435 = Il2CppMethodInfo;\n\tv436 = v435 + 0xF8;\n\tv437 = \"il2cpp_codegen_initialize_runtime_metadata\"(v436, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv439 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv440 = v439 + 0xFD8;\n\tv441 = \"il2cpp_codegen_initialize_runtime_metadata\"(v440, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv442 = Il2CppMethodInfo;\n\tv443 = v442 + 0xC90;\n\tv444 = \"il2cpp_codegen_initialize_runtime_metadata\"(v443, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv446 = Il2CppMethodInfo;\n\tv447 = v446 + 0xC70;\n\tv448 = \"il2cpp_codegen_initialize_runtime_metadata\"(v447, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv451 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv452 = v451 + 0xA38;\n\tv453 = \"il2cpp_codegen_initialize_runtime_metadata\"(v452, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv458 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv459 = v458 + 0xA48;\n\tv460 = \"il2cpp_codegen_initialize_runtime_metadata\"(v459, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv474 = System.Net.Configuration.SettingsSectionInternal;\n\tv475 = v474 + 0xB48;\n\tv476 = \"il2cpp_codegen_initialize_runtime_metadata\"(v475, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv480 = Il2CppMethodInfo;\n\tv481 = v480 + 0xF10;\n\tv482 = \"il2cpp_codegen_initialize_runtime_metadata\"(v481, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv484 = Il2CppMethodInfo;\n\tv485 = v484 + 0xF70;\n\tv486 = \"il2cpp_codegen_initialize_runtime_metadata\"(v485, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv488 = Il2CppMethodInfo;\n\tv489 = v488 + 0xFA0;\n\tv490 = \"il2cpp_codegen_initialize_runtime_metadata\"(v489, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv492 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv493 = v492 + 0xB8;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v493, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv70 = 1;\n\t*([302A973]) = v70;\nL_005B:\n\tv74 = UnityEngine.Component::get_transform(this);\n\tv222 = UnityEngine.Transform::get_position(v74);\n\tv214 = v222.y;\n\tv207 = v222.z;\n\tgoto L_0071;\n\tv332 = System.Runtime.Serialization.ObjectHolderList;\n\tv333 = v332 + 0x538;\n\tv334 = \"il2cpp_codegen_initialize_runtime_metadata\"(v333, v84, v53, v54, v55, v56, v57, v58, v85, v323, v324, v62, v63, v64, v65, v66);\n\tv337 = 1;\n\t*([2DD4418]) = v337;\nL_0071:\n\tv338 = Il2CppMethodInfo;\n\tv339 = System.Runtime.Serialization.ObjectHolderList;\n\tv341 = *([v339 @ X8_v6 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+538]);\n\tv342 = *([v341 @ X8_v8+B8]);\n\tgoto L_008B;\n\tv423 = \"il2cpp_codegen_runtime_class_init\"(v343, v84, v53, v54, v55, v56, v57, v58, v85, v323, v324, v62, v63, v64, v65, v66);\nL_008B:\n\t// 139 MakeStruct v167 @ AGGFE8930_2_v2 (UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), [v342 @ X8_v9], [v342 @ X8_v9+4], [v342 @ X8_v9+8], [v342 @ X8_v9+C]\n\tv427 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.dust, v222, v167, *([v338 @ X21_v3 (Il2CppMethodInfo)+F8]));\n\tthis.isCleared = 1;\n\tv257 = UnityEngine.Component::get_transform(this);\n\tv438 = Il2CppMethodInfo;\n\tv258 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v257, *([v438 @ X8_v12 (Il2CppMethodInfo)+5F8]));\n\tUnityEngine.Behaviour::set_enabled(v258, 0);\n\tv259 = Block::OnClear(this);\n\tv472 = this.fragments;\n\tv455 = Il2CppMethodInfo;\nL_00B8:\n\tv88 = v316 >= v472._size;\n\tif (v88) goto L_0147;\n\tv477 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv479 = new *([v477 @ X8_v40 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B8])();\n\tSystem.Object::.ctor(v479);\n\tv491 = Il2CppMethodInfo;\n\tv261 = System.Collections.Generic.List`1<UnityEngine.Rigidbody>::get_Item(this.fragments, v316);\n\tv253 = v479 + 0x10;\n\t*([v479 @ X0_v43 (System.Object)+10]) = v261;\n\tv496 = 0xF3F1B4(v253, v261, *([v491 @ X8_v42 (Il2CppMethodInfo)+50]), 0, v55, v56, v57, v58, v222, v214, v207, v185, v181, v177, v173, v223.y);\n\tv263 = UnityEngine.Component::get_gameObject(*([v479 @ X0_v43 (System.Object)+10]));\n\tUnityEngine.GameObject::SetActive(v263, 1);\n\tv265 = UnityEngine.Component::get_transform(*([v479 @ X0_v43 (System.Object)+10]));\n\tUnityEngine.Transform::set_parent(v265, 0);\n\tv266 = UnityEngine.Component::get_transform(this);\n\tv223 = UnityEngine.Transform::get_position(v266);\n\tUnityEngine.Rigidbody::AddExplosionForce(*([v479 @ X0_v43 (System.Object)+10]), 300f, v223, 1f, 0.2f);\n\tUnityEngine.Rigidbody::set_maxAngularVelocity(*([v479 @ X0_v43 (System.Object)+10]), 1000f);\n\tv225 = UnityEngine.Random::get_onUnitSphere();\n\tv268 = UnityEngine.Random::Range(0xFFFFFFF6, 0xA);\n\tv207 = v225.z * v268;\n\tv218 = v225.y * v268;\n\tv226 = v225 * v268;\n\t// 281 MakeStruct v127 @ AGGFE8AF0_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v226 @ V0_v11 (System.Single), v218 @ V1_v8 (System.Single), v207 @ V2_v4 (System.Single)\n\tUnityEngine.Rigidbody::AddTorque(*([v479 @ X0_v43 (System.Object)+10]), v127, 1);\n\tv204 = v316 * 0x3CA3D70A;\n\tv550 = Il2CppMethodInfo;\n\tv553 = UnityEngine.Component::GetComponent /* +1 sharing this address */(*([v479 @ X0_v43 (System.Object)+10]), *([v550 @ X8_v44 (Il2CppMethodInfo)+768]));\n\tv556 = DG.Tweening.ShortcutExtensions::DOScale(v553, 0f, 1f);\n\tv557 = Il2CppMethodInfo;\n\tv560 = DG.Tweening.TweenSettingsExtensions::SetDelay /* +1 sharing this address */(v556, v204, *([v557 @ X8_v46 (Il2CppMethodInfo)+F70]));\n\tv561 = System.Net.Configuration.SettingsSectionInternal;\n\tv564 = new *([v561 @ X8_v48 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B48])();\n\tv565 = Il2CppMethodInfo;\n\tDG.Tweening.TweenCallback::.ctor(v564, v479, *([v565 @ X8_v50 (Il2CppMethodInfo)+FA0]));\n\tv270 = DG.Tweening.TweenSettingsExtensions::OnComplete /* +1 sharing this address */(v560, v564, *([v455 @ X25_v2 (Il2CppMethodInfo)+F10]));\n\tv316 = v316 + 1;\n\tv472 = this.fragments;\n\tv570 = this.fragments == 0;\n\tv293 = ~v570;\n\tif (v293) goto L_00B8;\n\tgoto L_01BA;\nL_0147:\n\tv483 = Il2CppMethodInfo;\n\tv272 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this.visual, *([v483 @ X8_v18 (Il2CppMethodInfo)+6A8]));\n\tUnityEngine.Renderer::set_enabled(v272, 0);\n\tv497 = Il2CppMethodInfo;\n\tv274 = UnityEngine.Component::GetComponen\n// ... truncated")]
	protected internal void ShatterDestroy()
	{
		//IL_052f: Expected I, but got O
		//IL_053f: Expected O, but got I
		//IL_054f: Expected O, but got I
		//IL_003e: Expected F4, but got O
		//IL_0053: Expected F4, but got I
		//IL_0068: Expected F4, but got I
		//IL_007d: Expected F4, but got I
		//IL_00ef: Expected F4, but got I
		//IL_00ff: Expected F4, but got I
		//IL_010f: Expected F4, but got I
		//IL_0117: Expected F4, but got O
		//IL_0133: Expected I, but got O
		//IL_0171: Expected O, but got I
		//IL_0465: Expected I, but got O
		//IL_0197: Expected O, but got I
		//IL_01c5: Expected O, but got I
		//IL_04cc: Expected O, but got I
		//IL_04e4: Expected O, but got I
		//IL_021e: Expected O, but got I
		//IL_023a: Expected O, but got I
		//IL_02e1: Expected O, but got I
		//IL_0341: Expected I, but got O
		//IL_03e9: Expected O, but got I4
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Vector3 position = transform.position;
		float y = position.y;
		float z = position.z;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v339 @ X8_v6 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+538]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v341 @ X8_v8+B8]");
		object obj2 = 0;
		global::UnityEngine.Quaternion quaternion = default(global::UnityEngine.Quaternion);
		quaternion.x = (float)obj2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v9+4]");
		quaternion.y = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v9+8]");
		quaternion.z = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v9+C]");
		quaternion.w = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117133C (UnityEngine.Object::Instantiate, and 1 more at this address)");
		isCleared = true;
		global::UnityEngine.Transform transform2 = base.transform;
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		global::UnityEngine.Behaviour behaviour = default(global::UnityEngine.Behaviour);
		behaviour.enabled = false;
		OnClear();
		global::System.Collections.Generic.List<global::UnityEngine.Rigidbody> list = fragments;
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v9+C]");
		float num5 = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v9+8]");
		float num6 = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v9+4]");
		float num7 = 0f;
		float num8 = (float)obj2;
		int num9 = 0;
		global::UnityEngine.Vector3 torque = default(global::UnityEngine.Vector3);
		global::UnityEngine.Transform target = default(global::UnityEngine.Transform);
		bool flag2;
		global::UnityEngine.Renderer renderer = default(global::UnityEngine.Renderer);
		FluidPhysicsCoupler fluidPhysicsCoupler = default(FluidPhysicsCoupler);
		AudioManager audioManager = default(AudioManager);
		do
		{
			if (num9 < list.Count)
			{
				object obj3 = new object();
				nint num11 = 0;
				global::UnityEngine.Rigidbody rigidbody = fragments[num9];
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v43 (System.Object)+10]");
				global::UnityEngine.GameObject gameObject = ((global::UnityEngine.Component)0).gameObject;
				gameObject.SetActive(value: true);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v43 (System.Object)+10]");
				global::UnityEngine.Transform transform3 = ((global::UnityEngine.Component)0).transform;
				transform3.parent = null;
				global::UnityEngine.Transform transform4 = base.transform;
				global::UnityEngine.Vector3 position2 = transform4.position;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v43 (System.Object)+10]");
				((global::UnityEngine.Rigidbody)0).AddExplosionForce(300f, position2, 1f, 0.2f);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v43 (System.Object)+10]");
				((global::UnityEngine.Rigidbody)0).maxAngularVelocity = 1000f;
				global::UnityEngine.Vector3 onUnitSphere = global::UnityEngine.Random.onUnitSphere;
				int num12 = global::UnityEngine.Random.Range(-10, 10);
				z = onUnitSphere.z * (float)num12;
				float y2 = onUnitSphere.y * (float)num12;
				float x = onUnitSphere.x * (float)num12;
				torque.x = x;
				torque.y = y2;
				torque.z = z;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v479 @ X0_v43 (System.Object)+10]");
				((global::UnityEngine.Rigidbody)0).AddTorque(torque, global::UnityEngine.ForceMode.Impulse);
				int num13 = num9 * 1017370378;
				nint num14 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
				global::DG.Tweening.Core.TweenerCore<global::UnityEngine.Vector3, global::UnityEngine.Vector3, global::DG.Tweening.Plugins.Options.VectorOptions> tweenerCore = global::DG.Tweening.ShortcutExtensions.DOScale(target, 0f, 1f);
				nint num15 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B1314 (DG.Tweening.TweenSettingsExtensions::SetDelay, and 1 more at this address)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v565 @ X8_v50 (Il2CppMethodInfo)+FA0]");
				global::DG.Tweening.TweenCallback tweenCallback = new global::DG.Tweening.TweenCallback(obj3, (global::System.IntPtr)0);
				nint num17 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11B0CBC (DG.Tweening.TweenSettingsExtensions::OnComplete, and 1 more at this address)");
				num9++;
				list = fragments;
				bool flag = fragments == null;
				flag2 = !flag;
				num5 = position2.z;
				num6 = 0.2f;
				num7 = 1f;
				num8 = position2.z;
				y = 1f;
				position = (global::UnityEngine.Vector3)num13;
				continue;
			}
			nint num18 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
			renderer.enabled = false;
			nint num19 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
			fluidPhysicsCoupler.RefreshBodies();
			nint num20 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			nint num21 = (nint)typeof(CollectParticleData[]);
			object settings = new object();
			_ = 1065353216;
			_ = 1065353216;
			_ = 5.2386907127815326E-11;
			audioManager.PlayClip(shatterClip, (AudioClipSettings)settings);
			nint num22 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v276 @ X0_v31+78]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v314 @ X8_v36+F8]");
			bool flag3 = ((global::System.Collections.Generic.List<object>)0).Remove(this);
			global::UnityEngine.GameObject obj6 = base.gameObject;
			global::UnityEngine.Object.Destroy(obj6);
			return;
		}
		while (flag2);
		throw new global::System.NullReferenceException();
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
