[global::Cpp2ILInjected.Token(Token = "0x20000D6")]
public class Stone : Block
{
	[global::Cpp2ILInjected.Token(Token = "0x400047C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private bool wasTouch;

	[global::Cpp2ILInjected.Token(Token = "0x60003CA")]
	[global::Cpp2ILInjected.Address(RVA = "0x1017CA4", Offset = "0x1017CA4", Length = "0x1DC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0021;\n\tv25 = System.Collections.Generic.NullableComparer`1;\n\tv26 = v25 + 0xDD8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Collections.Generic.NullableComparer`1;\n\tv50 = v49 + 0xDC0;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv54 = Il2CppMethodInfo;\n\tv55 = v54 + 0xC0;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv90 = Il2CppMethodInfo;\n\tv91 = v90 + 0xB8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA95]) = v46;\nL_0021:\n\tBlock::OnEnable(this);\n\tv52 = this.solver;\n\tv57 = System.Collections.Generic.NullableComparer`1;\n\tv59 = Il2CppMethodInfo;\n\tv114 = this.solver + 0x270;\n\tv64 = new *([v57 @ X23_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DD8])();\n\tSystem.Action`2<System.Boolean, UnityEngine.Vector2>::.ctor(v64, this, *([v59 @ X24_v4 (Il2CppMethodInfo)+C0]));\n\tv129 = System.Delegate::Combine(v52.OnRemoveRegionStart, v64);\n\tv130 = v129 == 0;\n\tif (v130) goto L_0079;\n\tv170 = 0xF3F36C(v129, *([v57 @ X23_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DD8]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv172 = v170 == 0;\n\tif (v172) goto L_0091;\n\tv52.OnRemoveRegionStart = v170;\n\tv176 = 0xF3F36C(v129, *([v57 @ X23_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DD8]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv181 = v176 == 0;\n\tif (v181) goto L_0091;\n\tv81 = 0xF3F1B4(v114, v176, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv113 = this.solver;\nL_004B:\n\tv190 = System.Collections.Generic.NullableComparer`1;\n\tv191 = Il2CppMethodInfo;\n\tv114 = v113 + 0x278;\n\tv193 = new *([v190 @ X23_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DC0])();\n\tSystem.Action`2<System.Object, System.Int32>::.ctor(v193, this, *([v191 @ X24_v7 (Il2CppMethodInfo)+B8]));\n\tv109 = System.Delegate::Combine(v113.OnRemoveRegionComplete, v193);\n\tv111 = v109 == 0;\n\tif (v111) goto L_0082;\n\tv199 = 0xF3F36C(v109, *([v190 @ X23_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DC0]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv201 = v199 == 0;\n\tif (v201) goto L_0094;\n\tv113.OnRemoveRegionComplete = v199;\n\tv200 = 0xF3F36C(v109, *([v190 @ X23_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DC0]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv156 = v200 == 0;\n\tif (v156) goto L_0094;\n\tv153 = 0xF3F1B4(v114, v200, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\nL_0079:\n\tv52.OnRemoveRegionStart = 0;\n\tv80 = 0xF3F1B4(v114, 0, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv113 = this.solver;\n\tv173 = this.solver == 0;\n\tv83 = ~v173;\n\tif (v83) goto L_004B;\n\tthrow System.NullReferenceException;\nL_0082:\n\t*([v114 @ X20_v2 (System.Int32)]) = 0;\n\tv126 = 0xF3F1B4(v114, 0, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\nL_0091:\n\tthrow System.InvalidCastException;\nL_0094:\n\tthrow System.InvalidCastException;\n// 87 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnEnable()
	{
		//IL_0013: Expected I, but got O
		//IL_00fb: Expected I, but got O
		base.OnEnable();
		FluidSolver fluidSolver = solver;
		nint num = (nint)typeof(global::System.Collections.Generic.NullableComparer<>);
		nint num2 = 0;
		int num3 = (int)((nint)solver + 624);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4 (Il2CppMethodInfo)+C0]");
		global::System.Action<bool, global::UnityEngine.Vector2> b = new global::System.Action<bool, global::UnityEngine.Vector2>(this, (global::System.IntPtr)0);
		global::System.Delegate obj = global::System.Delegate.Combine(fluidSolver.OnRemoveRegionStart, b);
		FluidSolver fluidSolver2;
		if ((object)obj != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<bool, global::UnityEngine.Vector2> action = default(global::System.Action<bool, global::UnityEngine.Vector2>);
			if (action != null)
			{
				fluidSolver.OnRemoveRegionStart = action;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				object obj2 = default(object);
				if (obj2 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					fluidSolver2 = solver;
					goto IL_00ed;
				}
			}
			throw new global::System.InvalidCastException();
		}
		fluidSolver.OnRemoveRegionStart = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		fluidSolver2 = solver;
		if ((object)solver == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_00ed;
		IL_00ed:
		nint num4 = (nint)typeof(global::System.Collections.Generic.NullableComparer<>);
		nint num5 = 0;
		num3 = (int)((nint)fluidSolver2 + 632);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X24_v7 (Il2CppMethodInfo)+B8]");
		global::System.Delegate b2 = new global::System.Action<object, int>(this, (global::System.IntPtr)0);
		global::System.Delegate obj3 = global::System.Delegate.Combine(fluidSolver2.OnRemoveRegionComplete, b2);
		if ((object)obj3 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<global::System.Collections.Generic.HashSet<int>, int> action2 = default(global::System.Action<global::System.Collections.Generic.HashSet<int>, int>);
			if (action2 != null)
			{
				fluidSolver2.OnRemoveRegionComplete = action2;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				object obj4 = default(object);
				if (obj4 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					return;
				}
			}
			throw new global::System.InvalidCastException();
		}
		num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003CB")]
	[global::Cpp2ILInjected.Address(RVA = "0x1017E80", Offset = "0x1017E80", Length = "0x1DC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0021;\n\tv25 = System.Collections.Generic.NullableComparer`1;\n\tv26 = v25 + 0xDD8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Collections.Generic.NullableComparer`1;\n\tv50 = v49 + 0xDC0;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv54 = Il2CppMethodInfo;\n\tv55 = v54 + 0xC0;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv90 = Il2CppMethodInfo;\n\tv91 = v90 + 0xB8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v91, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA96]) = v46;\nL_0021:\n\tBlock::OnDisable(this);\n\tv52 = this.solver;\n\tv57 = System.Collections.Generic.NullableComparer`1;\n\tv59 = Il2CppMethodInfo;\n\tv114 = this.solver + 0x270;\n\tv64 = new *([v57 @ X23_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DD8])();\n\tSystem.Action`2<System.Boolean, UnityEngine.Vector2>::.ctor(v64, this, *([v59 @ X24_v4 (Il2CppMethodInfo)+C0]));\n\tv129 = System.Delegate::Remove(v52.OnRemoveRegionStart, v64);\n\tv130 = v129 == 0;\n\tif (v130) goto L_0079;\n\tv170 = 0xF3F36C(v129, *([v57 @ X23_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DD8]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv172 = v170 == 0;\n\tif (v172) goto L_0091;\n\tv52.OnRemoveRegionStart = v170;\n\tv176 = 0xF3F36C(v129, *([v57 @ X23_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DD8]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv181 = v176 == 0;\n\tif (v181) goto L_0091;\n\tv81 = 0xF3F1B4(v114, v176, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv113 = this.solver;\nL_004B:\n\tv190 = System.Collections.Generic.NullableComparer`1;\n\tv191 = Il2CppMethodInfo;\n\tv114 = v113 + 0x278;\n\tv193 = new *([v190 @ X23_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DC0])();\n\tSystem.Action`2<System.Object, System.Int32>::.ctor(v193, this, *([v191 @ X24_v7 (Il2CppMethodInfo)+B8]));\n\tv109 = System.Delegate::Remove(v113.OnRemoveRegionComplete, v193);\n\tv111 = v109 == 0;\n\tif (v111) goto L_0082;\n\tv199 = 0xF3F36C(v109, *([v190 @ X23_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DC0]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv201 = v199 == 0;\n\tif (v201) goto L_0094;\n\tv113.OnRemoveRegionComplete = v199;\n\tv200 = 0xF3F36C(v109, *([v190 @ X23_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DC0]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv156 = v200 == 0;\n\tif (v156) goto L_0094;\n\tv153 = 0xF3F1B4(v114, v200, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\nL_0079:\n\tv52.OnRemoveRegionStart = 0;\n\tv80 = 0xF3F1B4(v114, 0, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv113 = this.solver;\n\tv173 = this.solver == 0;\n\tv83 = ~v173;\n\tif (v83) goto L_004B;\n\tthrow System.NullReferenceException;\nL_0082:\n\t*([v114 @ X20_v2 (System.Int32)]) = 0;\n\tv126 = 0xF3F1B4(v114, 0, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\nL_0091:\n\tthrow System.InvalidCastException;\nL_0094:\n\tthrow System.InvalidCastException;\n// 87 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnDisable()
	{
		//IL_0013: Expected I, but got O
		//IL_00fb: Expected I, but got O
		base.OnDisable();
		FluidSolver fluidSolver = solver;
		nint num = (nint)typeof(global::System.Collections.Generic.NullableComparer<>);
		nint num2 = 0;
		int num3 = (int)((nint)solver + 624);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X24_v4 (Il2CppMethodInfo)+C0]");
		global::System.Action<bool, global::UnityEngine.Vector2> value = new global::System.Action<bool, global::UnityEngine.Vector2>(this, (global::System.IntPtr)0);
		global::System.Delegate obj = global::System.Delegate.Remove(fluidSolver.OnRemoveRegionStart, value);
		FluidSolver fluidSolver2;
		if ((object)obj != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<bool, global::UnityEngine.Vector2> action = default(global::System.Action<bool, global::UnityEngine.Vector2>);
			if (action != null)
			{
				fluidSolver.OnRemoveRegionStart = action;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				object obj2 = default(object);
				if (obj2 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					fluidSolver2 = solver;
					goto IL_00ed;
				}
			}
			throw new global::System.InvalidCastException();
		}
		fluidSolver.OnRemoveRegionStart = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		fluidSolver2 = solver;
		if ((object)solver == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_00ed;
		IL_00ed:
		nint num4 = (nint)typeof(global::System.Collections.Generic.NullableComparer<>);
		nint num5 = 0;
		num3 = (int)((nint)fluidSolver2 + 632);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v191 @ X24_v7 (Il2CppMethodInfo)+B8]");
		global::System.Delegate value2 = new global::System.Action<object, int>(this, (global::System.IntPtr)0);
		global::System.Delegate obj3 = global::System.Delegate.Remove(fluidSolver2.OnRemoveRegionComplete, value2);
		if ((object)obj3 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<global::System.Collections.Generic.HashSet<int>, int> action2 = default(global::System.Action<global::System.Collections.Generic.HashSet<int>, int>);
			if (action2 != null)
			{
				fluidSolver2.OnRemoveRegionComplete = action2;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				object obj4 = default(object);
				if (obj4 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					return;
				}
			}
			throw new global::System.InvalidCastException();
		}
		num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003CC")]
	[global::Cpp2ILInjected.Address(RVA = "0x101805C", Offset = "0x101805C", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.wasTouch = 1;\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void RemoveRegionStarted(bool a, global::UnityEngine.Vector2 wpos)
	{
		wasTouch = true;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003CD")]
	[global::Cpp2ILInjected.Address(RVA = "0x1018068", Offset = "0x1018068", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.wasTouch = 0;\n\treturn;\n")]
	private void RemoveRegion(global::System.Collections.Generic.HashSet<int> particleId, int regionId)
	{
		wasTouch = false;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003CE")]
	[global::Cpp2ILInjected.Address(RVA = "0x1018070", Offset = "0x1018070", Length = "0x2B0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002E;\n\tv39 = Il2CppMethodInfo;\n\tv40 = v39 + 0x968;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, particleIds, explode, methodInfo, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv67 = Il2CppMethodInfo;\n\tv68 = v67 + 0x970;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, particleIds, explode, methodInfo, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv204 = Il2CppMethodInfo;\n\tv205 = v204 + 0x978;\n\tv206 = \"il2cpp_codegen_initialize_runtime_metadata\"(v205, particleIds, explode, methodInfo, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv297 = Il2CppMethodInfo;\n\tv298 = v297 + 0x998;\n\tv299 = \"il2cpp_codegen_initialize_runtime_metadata\"(v298, particleIds, explode, methodInfo, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv307 = Il2CppMethodInfo;\n\tv308 = v307 + 0xC28;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v308, particleIds, explode, methodInfo, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv59 = 1;\n\t*([302AA97]) = v59;\nL_002E:\n\tv65 = ~this.wasTouch;\n\tv66 = ~v65;\n\tif (v66) goto L_00B2;\n\tv70 = v285 == 0;\n\tif (v70) goto L_00BB;\n\tv213 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v285);\n\tv304 = Il2CppMethodInfo;\n\tv305 = Il2CppMethodInfo;\n\tgoto L_005A;\nL_004A:\n\tv416 = v400.y - *([v392 @ X8_v22+4]);\n\tv417 = v384 - *([v392 @ X8_v22]);\n\tv240 = v417 * v417;\n\tv418 = v416 * v416;\n\tv419 = v240 + v418;\n\tv338 = UnityEngine.Mathf::Sqrt(v419);\n\tv333 = v338 < 0.5f;\n\tif (v333) goto L_009D;\nL_005A:\n\tv285 = *([v304 @ X21_v5 (Il2CppMethodInfo)+970]);\n\tv354 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v211 @ stack_-B0_v5 (System.Single), *([v304 @ X21_v5 (Il2CppMethodInfo)+970]));\n\tv357 = v354 & 1;\n\tv358 = v357 == 0;\n\tif (v358) goto L_009E;\n\tv366 = this.solver == 0;\n\tif (v366) goto L_00B3;\n\tv376 = this.solver + 0x1F8;\n\tv223 = *([v305 @ X22_v4 (Il2CppMethodInfo)+C28]);\n\tv345 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v376, v302, &v323 @ stack_-94_v7, *([v305 @ X22_v4 (Il2CppMethodInfo)+C28]));\n\tv379 = v345 & 1;\n\tv348 = v379 == 0;\n\tif (v348) goto L_005A;\n\tv380 = this.solver;\n\tv381 = this.solver == 0;\n\tif (v381) goto L_00B7;\n\tv319 = v323 << 3;\n\tv392 = v380.positions + v319;\n\tv396 = UnityEngine.Component::get_transform(this);\n\tv384 = UnityEngine.Transform::get_position(v396);\n\tv399 = UnityEngine.Component::get_transform(this);\n\tv391 = v399 == 0;\n\tif (v391) goto L_00B5;\n\tv400 = UnityEngine.Transform::get_position(v399);\n\tv216 = v400.z;\n\tv403 = *([2DD4420]) == 0;\n\tif (v403) goto L_0093;\n\tgoto L_004A;\n\tgoto L_FFFFFFFF;\nL_0093:\n\t*([2DD4420]) = 1;\n\tgoto L_004A;\n\tgoto L_004A;\nL_009D:\n\tBlock::ShatterDestroy(this);\nL_009E:\n\tv372 = Il2CppMethodInfo;\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v211 @ stack_-B0_v5 (System.Single), *([v372 @ X8_v16 (Il2CppMethodInfo)+968]));\nL_00B2:\n\treturn;\nL_00B3:\n\tv377 = new System.NullReferenceException();\n\tgoto L_00BA;\nL_00B5:\n\tv388 = new System.NullReferenceException();\n\tgoto L_00BA;\nL_00B7:\n\tv389 = new System.NullReferenceException();\n\tgoto L_00BA;\n\tv387 = new System.NullReferenceException();\nL_00BA:\n\t// 186 Interrupt\nL_00BB:\n\tv251 = new System.NullReferenceException();\n\tgoto L_00D1;\n\tgoto L_00D1;\n\tgoto L_00D1;\n\tgoto L_00D1;\n\tgoto L_00D1;\n\tgoto L_00D1;\n\tgoto L_00D1;\n\tgoto L_00D1;\n\tgoto L_00D1;\n\tgoto L_00D1;\n\tgoto L_00D1;\nL_00D1:\n\tv73 = v285 != 1;\n\tif (v73) goto L_00E3;\n\tv360 = 0x274A080(v251, v285, v324, v326, v44, v45, v46, v47, v338, v240, v216, v51, v52, v53, v54, v55);\n\tv373 = 0x274A098(v360, v285, v324, v326, v44, v45, v46, v47, v338, v240, v216, v51, v52, v53, v54, v55);\n\tv378 = Il2CppMethodInfo;\n\tv285 = *([v378 @ X8_v7 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v211 @ stack_-B0_v5 (System.Single), *([v378 @ X8_v7 (Il2CppMethodInfo)+968]));\n\tv178 = *([v360 @ X0_v12]) == 0;\n\tif (v178) goto L_00B2;\n\tv362 = new System.OutOfMemoryException();\nL_00E3:\n\tv365 = 0xBF092C(&v169 @ stack_-B0 (System.Int32), v285, v324, v326, v44, v45, v46, v47, v338, v240, v216, v51, v52, v53, v54, v55);\n\tv375 = 0x27498DC(v294, v285, v324, v326, v44, v45, v46, v47, v338, v240, v216, v51, v52, v53, v54, v55);\n\tv287 = 0xD6F8(v375, v285, v324, v326, v44, v45, v46, v47, v338, v240, v216, v51, v52, v53, v54, v55);\n\treturn;\n// 127 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected unsafe override void CheckClear(global::System.Collections.Generic.HashSet<int> particleIds, bool explode)
	{
		//IL_00f2: Expected O, but got I
		//IL_039c: Expected O, but got I
		//IL_03d4: Expected I4, but got O
		//IL_0158: Expected O, but got I
		//IL_01fb: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		if (wasTouch)
		{
			return;
		}
		global::System.Collections.Generic.HashSet<int> hashSet = default(global::System.Collections.Generic.HashSet<int>);
		if (hashSet != null)
		{
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator();
			nint num = 0;
			nint num2 = 0;
			float num4 = default(float);
			float num3 = num4;
			object obj = default(object);
			object obj2 = default(object);
			nint num5 = default(nint);
			object obj4 = default(object);
			global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
			nint num7;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X21_v5 (Il2CppMethodInfo)+970]");
				hashSet = (global::System.Collections.Generic.HashSet<int>)0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj & 1) != 0)
				{
					bool flag;
					if ((object)solver == null)
					{
						global::System.NullReferenceException ex = new global::System.NullReferenceException();
						flag = (byte)(&obj2) != 0;
						hashSet = null;
						break;
					}
					object obj3 = (nint)solver + 504;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X22_v4 (Il2CppMethodInfo)+C28]");
					num5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					int num6 = (int)((nint)obj4 & 1);
					bool flag2 = num6 == 0;
					flag = (byte)(&obj2) != 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v305 @ X22_v4 (Il2CppMethodInfo)+C28]");
					num7 = 0;
					if (flag2)
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
						flag = (byte)(&obj2) != 0;
						y = position.y;
						num3 = position.x;
						hashSet = null;
						break;
					}
					int num8 = (int)((nint)obj2 << 3);
					object obj5 = fluidSolver.positions + num8;
					global::UnityEngine.Transform transform = base.transform;
					position = transform.position;
					global::UnityEngine.Transform transform2 = base.transform;
					if ((object)transform2 == null)
					{
						global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
						num5 = num5;
						break;
					}
					global::UnityEngine.Vector3 position2 = transform2.position;
					z = position2.z;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
					if ((nint)0 == 0)
					{
						_ = 1;
					}
					float num9 = position2.y;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v392 @ X8_v22+4]");
					float num10 = num9 - 0f;
					float num11 = position.x - (float)obj5;
					y = num11 * num11;
					float num12 = num10 * num10;
					float f = y + num12;
					num3 = global::UnityEngine.Mathf.Sqrt(f);
					bool flag3 = num3 < 0.5f;
					flag = (byte)(&obj2) != 0;
					num7 = num5;
					if (!flag3)
					{
						continue;
					}
					ShatterDestroy();
				}
				nint num13 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				return;
			}
			num7 = num5;
			int num14 = 0;
		}
		global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
		bool flag4 = (nint)hashSet != 1;
		global::System.NullReferenceException ex5 = ex4;
		if (!flag4)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			nint num15 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v378 @ X8_v7 (Il2CppMethodInfo)+968]");
			hashSet = (global::System.Collections.Generic.HashSet<int>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj6 = default(object);
			if (obj6 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex6 = new global::System.OutOfMemoryException();
			int num14 = (int)obj6;
			ex5 = (global::System.NullReferenceException)(object)ex6;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003CF")]
	[global::Cpp2ILInjected.Address(RVA = "0x1018320", Offset = "0x1018320", Length = "0xF0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0x720;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv55 = Il2CppMethodInfo;\n\tv56 = v55 + 0xC80;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv62 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv63 = v62 + 0xA40;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302AA98]) = v48;\nL_001E:\n\tv49 = Il2CppMethodInfo;\n\tgoto L_0027;\n\tv58 = \"il2cpp_codegen_runtime_class_init\"(v51, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0027:\n\tv61 = Singleton`1::get_Instance /* +1 sharing this address */(*([v49 @ X21_v2 (Il2CppMethodInfo)+C80]));\n\tv67 = UnityEngine.Component::get_transform(this);\n\tv69 = Il2CppMethodInfo;\n\tv72 = UnityEngine.Transform::get_position(v67);\n\tv88 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v69 @ X21_v5 (Il2CppMethodInfo)+720]));\n\tv83 = UnityEngine.Rigidbody2D::get_velocity(v88);\n\t// 79 MakeStruct v99 @ AGG1018408_1_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v72 @ V0_v2 (UnityEngine.Vector3), v72.y (System.Single)\n\tCollectionManager::OnCollectStoneBlock(v61, v99, v83);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 59 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnClear()
	{
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::UnityEngine.Transform transform = base.transform;
		nint num2 = 0;
		global::UnityEngine.Vector3 position = transform.position;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		global::UnityEngine.Rigidbody2D rigidbody2D = default(global::UnityEngine.Rigidbody2D);
		global::UnityEngine.Vector2 velocity = rigidbody2D.velocity;
		global::UnityEngine.Vector2 pos = default(global::UnityEngine.Vector2);
		pos.x = position.x;
		pos.y = position.y;
		CollectionManager collectionManager = default(CollectionManager);
		collectionManager.OnCollectStoneBlock(pos, velocity);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003D0")]
	[global::Cpp2ILInjected.Address(RVA = "0x1018410", Offset = "0x1018410", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tBlock::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Stone()
	{
	}
}
