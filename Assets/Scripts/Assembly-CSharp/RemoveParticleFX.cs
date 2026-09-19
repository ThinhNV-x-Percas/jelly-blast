[global::Cpp2ILInjected.Token(Token = "0x20000C9")]
public class RemoveParticleFX : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000455")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x4000456")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.ParticleSystem cloudParticles;

	[global::Cpp2ILInjected.Token(Token = "0x4000457")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.ParticleSystem sparkleParticles;

	[global::Cpp2ILInjected.Token(Token = "0x4000458")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.GameObject[] powerUpExplosionPrefabs;

	[global::Cpp2ILInjected.Token(Token = "0x6000398")]
	[global::Cpp2ILInjected.Address(RVA = "0x1014848", Offset = "0x1014848", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Il2CppMethodInfo;\n\tgoto L_0018;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x7B8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA81]) = v43;\nL_0018:\n\tv46 = UnityEngine.Component::GetComponentInParent /* +1 sharing this address */(this, *([v18 @ X21_v1 (Il2CppMethodInfo)+7B8]));\n\tv48 = this + 0x20;\n\tthis.solver = v46;\n\tv56 = 0xF3F1B4(v48, v46, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_0021: Expected O, but got I
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111CB34 (UnityEngine.Component::GetComponentInParent, and 1 more at this address)");
		FluidSolver fluidSolver = default(FluidSolver);
		solver = fluidSolver;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000399")]
	[global::Cpp2ILInjected.Address(RVA = "0x10148AC", Offset = "0x10148AC", Length = "0x1D0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001F;\n\tv25 = System.Collections.Generic.NullableComparer`1;\n\tv26 = v25 + 0xD28;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Collections.Generic.NullableComparer`1;\n\tv50 = v49 + 0xDB8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv85 = Il2CppMethodInfo;\n\tv86 = v85 + 0xD48;\n\tv87 = \"il2cpp_codegen_initialize_runtime_metadata\"(v86, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv123 = Il2CppMethodInfo;\n\tv124 = v123 + 0xD50;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v124, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA82]) = v46;\nL_001F:\n\tv47 = this.solver;\n\tv52 = System.Collections.Generic.NullableComparer`1;\n\tv54 = Il2CppMethodInfo;\n\tv110 = this.solver + 0x260;\n\tv59 = new *([v52 @ X23_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8])();\n\tSystem.Action`2<System.Object, System.Boolean>::.ctor(v59, this, *([v54 @ X24_v4 (Il2CppMethodInfo)+D50]));\n\tv127 = System.Delegate::Combine(v47.OnStartRemoveParticles, v59);\n\tv128 = v127 == 0;\n\tif (v128) goto L_0076;\n\tv168 = 0xF3F36C(v127, *([v52 @ X23_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv170 = v168 == 0;\n\tif (v170) goto L_008E;\n\tv47.OnStartRemoveParticles = v168;\n\tv174 = 0xF3F36C(v127, *([v52 @ X23_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv179 = v174 == 0;\n\tif (v179) goto L_008E;\n\tv76 = 0xF3F1B4(v110, v174, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv109 = this.solver;\nL_0048:\n\tv188 = System.Collections.Generic.NullableComparer`1;\n\tv189 = Il2CppMethodInfo;\n\tv110 = v109 + 0x280;\n\tv191 = new *([v188 @ X23_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D28])();\n\tSystem.Action`1<System.Object>::.ctor(v191, this, *([v189 @ X24_v7 (Il2CppMethodInfo)+D48]));\n\tv105 = System.Delegate::Combine(v109.OnDetonatePowerUp, v191);\n\tv107 = v105 == 0;\n\tif (v107) goto L_007F;\n\tv197 = 0xF3F36C(v105, *([v188 @ X23_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D28]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv199 = v197 == 0;\n\tif (v199) goto L_0091;\n\tv109.OnDetonatePowerUp = v197;\n\tv198 = 0xF3F36C(v105, *([v188 @ X23_v7 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D28]), 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv154 = v198 == 0;\n\tif (v154) goto L_0091;\n\tv151 = 0xF3F1B4(v110, v198, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\nL_0076:\n\tv47.OnStartRemoveParticles = 0;\n\tv75 = 0xF3F1B4(v110, 0, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv109 = this.solver;\n\tv171 = this.solver == 0;\n\tv78 = ~v171;\n\tif (v78) goto L_0048;\n\tthrow System.NullReferenceException;\nL_007F:\n\t*([v110 @ X20_v2 (System.Int32)]) = 0;\n\tv122 = 0xF3F1B4(v110, 0, 0, 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\nL_008E:\n\tthrow System.InvalidCastException;\nL_0091:\n\tthrow System.InvalidCastException;\n// 85 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		//IL_0013: Expected I, but got O
		//IL_00fb: Expected I, but got O
		FluidSolver fluidSolver = solver;
		nint num2 = 0;
		int num3 = (int)((nint)solver + 608);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X24_v4 (Il2CppMethodInfo)+D50]");
		global::System.Delegate b = new global::System.Action<object, bool>(this, (global::System.IntPtr)0);
		global::System.Delegate obj = global::System.Delegate.Combine(fluidSolver.OnStartRemoveParticles, b);
		FluidSolver fluidSolver2;
		if ((object)obj != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<global::System.Collections.Generic.HashSet<int>, bool> action = default(global::System.Action<global::System.Collections.Generic.HashSet<int>, bool>);
			if (action != null)
			{
				fluidSolver.OnStartRemoveParticles = action;
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
		fluidSolver.OnStartRemoveParticles = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		fluidSolver2 = solver;
		if ((object)solver == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_00ed;
		IL_00ed:
		nint num5 = 0;
		num3 = (int)((nint)fluidSolver2 + 640);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X24_v7 (Il2CppMethodInfo)+D48]");
		global::System.Delegate b2 = new global::System.Action<object>(this, (global::System.IntPtr)0);
		global::System.Delegate obj3 = global::System.Delegate.Combine(fluidSolver2.OnDetonatePowerUp, b2);
		if ((object)obj3 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<PowerUp> action2 = default(global::System.Action<PowerUp>);
			if (action2 != null)
			{
				fluidSolver2.OnDetonatePowerUp = action2;
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

	[global::Cpp2ILInjected.Token(Token = "0x600039A")]
	[global::Cpp2ILInjected.Address(RVA = "0x1014A7C", Offset = "0x1014A7C", Length = "0x620")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv32 = &v33 @ stack_-10_v2;\n\tgoto L_0031;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x968;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, ids, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv65 = Il2CppMethodInfo;\n\tv66 = v65 + 0x970;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, ids, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv264 = Il2CppMethodInfo;\n\tv265 = v264 + 0x978;\n\tv266 = \"il2cpp_codegen_initialize_runtime_metadata\"(v265, ids, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv277 = Il2CppMethodInfo;\n\tv278 = v277 + 0x998;\n\tv279 = \"il2cpp_codegen_initialize_runtime_metadata\"(v278, ids, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv442 = Il2CppMethodInfo;\n\tv443 = v442 + 0xC28;\n\tv444 = \"il2cpp_codegen_initialize_runtime_metadata\"(v443, ids, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv461 = Il2CppMethodInfo;\n\tv462 = v461 + 0xC90;\n\tv463 = \"il2cpp_codegen_initialize_runtime_metadata\"(v462, ids, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv473 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv474 = v473 + 0xA48;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v474, ids, explode, methodInfo, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv63 = 1;\n\t*([302AA83]) = v63;\nL_0031:\n\t*([v32 @ X29_v1-90]) = 0;\n\t*([v32 @ X29_v1-88]) = 0;\n\t*([v32 @ X29_v1-80]) = 0;\n\t*([v32 @ X29_v1-94]) = 0;\n\t*([v32 @ X29_v1-A8]) = 0;\n\t*([v32 @ X29_v1-A0]) = 0;\n\tv64 = v449 == 0;\n\tif (v64) goto L_01CA;\n\tv70 = Il2CppMethodInfo;\n\tv72 = Il2CppMethodInfo;\n\tv76 = Il2CppMethodInfo;\n\tv82 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v449);\n\t*([v32 @ X29_v1-90]) = v80;\n\t*([v32 @ X29_v1-80]) = v148;\n\tv269 = &v33 @ stack_-10_v2 - 0x90;\n\t*([v32 @ X29_v1-B8]) = 0;\n\t*([v32 @ X29_v1-B0]) = v269;\n\tv270 = System.Xml.ValidateNames;\n\t// 85 NotImplemented \"Instruction DUP not yet implemented.\"\n\t// 94 NotImplemented \"Instruction DUP not yet implemented.\"\nL_0060:\n\tv248 = *([v70 @ X23_v4 (Il2CppMethodInfo)+970]);\n\tv429 = &v33 @ stack_-10_v2 - 0x90;\n\tv430 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(v429, *([v70 @ X23_v4 (Il2CppMethodInfo)+970]));\n\tv445 = v430 & 1;\n\tv446 = v445 == 0;\n\tif (v446) goto L_018F;\n\tv464 = this.solver == 0;\n\tif (v464) goto L_01A6;\n\tv475 = this.solver + 0x1F8;\n\tv222 = *([v72 @ X24_v4 (Il2CppMethodInfo)+C28]);\n\tv397 = &v33 @ stack_-10_v2 - 0x94;\n\tv413 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v475, *([v32 @ X29_v1-80]), v397, *([v72 @ X24_v4 (Il2CppMethodInfo)+C28]));\n\tv566 = v413 & 1;\n\tv417 = v566 == 0;\n\tif (v417) goto L_0060;\n\tv639 = this.solver;\n\tv640 = this.solver == 0;\n\tif (v640) goto L_01A8;\n\tv394 = *([v32 @ X29_v1-94]);\n\tv756 = v639.powerUpIds;\n\tv418 = *([v756 @ X8_v23 (Unity.Collections.NativeArray`1<System.Int32>)+v394 @ X9_v5*4]) + 1;\n\tv388 = v418 == 0;\n\tv379 = ~v388;\n\tif (v379) goto L_0060;\n\tv758 = UnityEngine.Component::get_transform(this);\n\tv748 = this.solver;\n\tv736 = this.solver == 0;\n\tif (v736) goto L_01BC;\n\tv682 = *([v32 @ X29_v1-94]) << 3;\n\tv760 = v748.positions + v682;\n\t// 140 MakeStruct v372 @ AGG1014C34_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v760 @ X8_v27], [v760 @ X8_v27+4]\n\tv699 = Unity.Mathematics.float2::op_Implicit(v372);\n\tgoto L_0099;\n\tv767 = v262;\n\tv768 = \"il2cpp_codegen_initialize_runtime_metadata\"(v767, v707, v397, v401, v48, v49, v50, v51, v699, v677, v364, v345, v56, v57, v58, v59);\n\tv770 = 1;\n\t*([2DD4422]) = v770;\nL_0099:\n\tv730 = v758 == 0;\n\tif (v730) goto L_01B0;\n\tv771 = *([v270 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv772 = *([v771 @ X8_v30+B8]);\n\tv777 = *([v772 @ X8_v31+58]) * 0;\n\tv779 = *([v772 @ X8_v31+54]) * 5f;\n\tv698 = v699 + v779;\n\t// 169 MakeStruct v361 @ AGG1014C94_1_v5 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v698 @ V0_v13 (System.Single), v777 @ V0_v10, v780 @ V1.S1\n\tUnityEngine.Transform::set_position(v758, v361);\n\tv749 = this.solver;\n\tv737 = this.solver == 0;\n\tif (v737) goto L_01BE;\n\tv693 = *([v32 @ X29_v1-94]);\n\tv782 = v749.particleTypes;\n\tgoto L_00B7;\n\tv786 = \"il2cpp_codegen_runtime_class_init\"(v783, v706, v397, v401, v48, v49, v50, v51, v698, v676, v670, v345, v56, v57, v58, v59);\nL_00B7:\n\t;\n\tv789 = Singleton`1::get_Instance /* +1 sharing this address */(*([v76 @ X26_v4 (Il2CppMethodInfo)+C90]));\n\tv729 = v789 == 0;\n\tif (v729) goto L_01AE;\n\tv745 = *([v789 @ X0_v39+78]);\n\tv731 = *([v789 @ X0_v39+78]) == 0;\n\tif (v731) goto L_01B2;\n\tv742 = *([v745 @ X8_v35+28]);\n\tv733 = *([v745 @ X8_v35+28]) == 0;\n\tif (v733) goto L_01B6;\n\tv791 = Singleton`1::get_Instance /* +1 sharing this address */(*([v76 @ X26_v4 (Il2CppMethodInfo)+C90]));\n\tv728 = v791 == 0;\n\tif (v728) goto L_01AC;\n\tv746 = *([v791 @ X0_v44+78]);\n\tv734 = *([v791 @ X0_v44+78]) == 0;\n\tif (v734) goto L_01B8;\n\tv741 = *([v746 @ X8_v37+28]);\n\tv727 = *([v746 @ X8_v37+28]) == 0;\n\tif (v727) goto L_01AA;\n\tv792 = *([v782 @ X8_v33 (Unity.Collections.NativeArray`1<System.Int32>)+v693 @ X9_v7*4]) / *([v742 @ X8_v36+18]);\n\tv732 = v792 * *([v742 @ X8_v36+18]);\n\tv695 = *([v782 @ X8_v33 (Unity.Collections.NativeArray`1<System.Int32>)+v693 @ X9_v7*4]) - v732;\n\tv793 = v695 < *([v741 @ X8_v38+18]);\n\tv687 = ~v793;\n\tif (v687) goto L_01B4;\n\tv683 = v695 << 4;\n\tv752 = *([v746 @ X8_v37+28]) + v683;\n\tv703 = UnityEngine.Random::get_value();\n\tv798 = 0 - *([v752 @ X8_v39+20]);\n\tv799 = v798 * v196;\n\tv681 = *([v752 @ X8_v39+20]) + v799;\n\tv684 = v703 >= 1f;\n\tif (v684) goto L_0122;\n\tv739 = this.cloudParticles == 0;\n\tif (v739) goto L_01C4;\n\tv812 = UnityEngine.ParticleSystem::get_main(this.cloudParticles);\n\t*([v32 @ X29_v1-A0]) = v812;\n\t// 254 MakeStruct v658 @ AGG1014D6C_0_v6 (UnityEngine.Color), typeof(UnityEngine.Color), v681 @ V1_v12 (UnityEngine.Gradient), v815 @ V0.S1, v816 @ V0.S2, v817 @ V0.S3\n\tv820 = UnityEngine.ParticleSystem+MinMaxGradient::op_Implicit(v658);\n\tv80 = v820.m_Mode;\n\tv827 = &v33 @ stack_-10_v2 - 0xA0;\n\tUnityEngine.ParticleSystem+MainModule::set_startColor(v827, &v80 @ stack_-100_v3 (UnityEngine.ParticleSystemGradientMode));\n\tv738 = this.cloudParticles == 0;\n\tif (v738) goto L_01C2;\n\tUnityEngine.ParticleSystem::Emit(this.cloudParticles, 1);\nL_0122:\n\tv810 = UnityEngine.Component::get_transform(this);\n\tv747 = this.solver;\n\tv735 = this.solver == 0;\n\tif (v735) goto L_01BA;\n\tv377 = *([v32 @ X29_v1-94]) << 3;\n\tv822 = v747.positions + v377;\n\t// 302 MakeStruct v295 @ AGG1014DD8_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v822 @ X8_v43], [v822 @ X8_v43+4]\n\tv701 = Unity.Mathematics.float2::op_Implicit(v295);\n\tgoto L_013B;\n\tv831 = v262;\n\tv832 = \"il2cpp_codegen_initialize_runtime_metadata\"(v831, v708, v398, v401, v48, v49, v50, v51, v701, v679, v671, v346, v56, v57, v58, v59);\n\tv834 = 1;\n\t*([2DD4422]) = v834;\nL_013B:\n\tv419 = v810 == 0;\n\tif (v419) goto L_01C0;\n\tv835 = *([v270 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv424 = *([v835 @ X8_v46+B8]);\n\tv839 = *([v424 @ X8_v47+58]) * 0;\n\tv842 = *([v424 @ X8_v47+54]) * 5f;\n\tv843 = v701 + v842;\n\t// 331 MakeStruct v291 @ AGG1014E38_1_v5 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v843 @ V0_v23 (System.Single), v839 @ V0_v20, v780 @ V1.S1\n\tUnityEngine.Transform::set_position(v810, v291);\n\tv402 = UnityEngine.Random::get_value();\n\tv380 = v402 >= 0x3DCCCCCD;\n\tif (v380) goto L_0060;\n\tv740 = this.sparkleParticles == 0;\n\tif (v740) goto L_01C6;\n\tv848 = UnityEngine.ParticleSystem::get_main(this.sparkleParticles);\n\t*([v32 @ X29_v1-A8]) = v848;\n\tv851 = 0 - v681;\n\tv853 = v851 * 0;\n\tv854 = v681 + v853;\n\t// 364 MakeStruct v289 @ AGG1014E90_0_v5 (UnityEngine.Color), typeof(UnityEngine.Color), v854 @ V0_v28 (System.Single), v815 @ V0.S1, v816 @ V0.S2, v817 @ V0.S3\n\tv858 = UnityEngine.ParticleSystem+MinMaxGradient::op_Implicit(v289);\n\tv80 = v858.m_Mode;\n\tv860 = &v33 @ stack_-10_v2 - 0xA8;\n\tUnityEngine.ParticleSystem+MainModule::set_startColor(v860, &v80 @ stack_-100_v3 (UnityEngine.Pa\n// ... truncated")]
	public unsafe void OnRemoveParticles(global::System.Collections.Generic.HashSet<int> ids, bool explode)
	{
		//IL_0046: Expected O, but got I
		//IL_005f: Expected I, but got O
		//IL_0ed4: Expected O, but got I
		//IL_0e46: Expected O, but got I
		//IL_0e55: Expected O, but got I
		//IL_0955: Expected O, but got I
		//IL_0db7: Expected O, but got I
		//IL_09a4: Expected F4, but got I
		//IL_09ac: Expected O, but got Ref
		//IL_00b9: Expected O, but got I
		//IL_015f: Expected O, but got I
		//IL_0183: Expected O, but got I
		//IL_0212: Unknown result type (might be due to invalid IL or missing references)
		//IL_0217: Expected O, but got Unknown
		//IL_0226: Expected F4, but got O
		//IL_023b: Expected F4, but got I
		//IL_025d: Expected O, but got I
		//IL_026d: Expected O, but got I
		//IL_0284: Expected O, but got I
		//IL_02cb: Expected F4, but got O
		//IL_02d8: Expected F4, but got O
		//IL_031e: Expected O, but got I
		//IL_0369: Expected O, but got I
		//IL_0abb: Expected O, but got F4
		//IL_039e: Expected O, but got I
		//IL_03fc: Expected O, but got I
		//IL_0431: Expected O, but got I
		//IL_09f8: Expected O, but got I
		//IL_0473: Expected O, but got I
		//IL_0489: Expected O, but got I
		//IL_049f: Expected O, but got I
		//IL_04f3: Expected O, but got I
		//IL_0534: Unknown result type (might be due to invalid IL or missing references)
		//IL_0539: Expected O, but got Unknown
		//IL_055d: Expected O, but got I
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f3: Expected O, but got Unknown
		//IL_0700: Expected F4, but got O
		//IL_0715: Expected F4, but got I
		//IL_0cf0: Expected F4, but got I
		//IL_0cf8: Expected O, but got Ref
		//IL_05cb: Expected F4, but got O
		//IL_05d8: Expected F4, but got O
		//IL_05e5: Expected F4, but got O
		//IL_05f2: Expected F4, but got O
		//IL_0621: Expected O, but got I
		//IL_062e: Expected O, but got Ref
		//IL_0737: Expected O, but got I
		//IL_0747: Expected O, but got I
		//IL_075d: Expected O, but got I
		//IL_07a3: Expected F4, but got O
		//IL_07b0: Expected F4, but got O
		//IL_0c78: Expected O, but got I
		//IL_0c8d: Expected O, but got F4
		//IL_07f8: Expected O, but got I4
		//IL_0693: Expected F4, but got I
		//IL_0d16: Expected O, but got I
		//IL_0892: Expected F4, but got O
		//IL_089f: Expected F4, but got O
		//IL_08ac: Expected F4, but got O
		//IL_08db: Expected O, but got I
		//IL_08e8: Expected O, but got Ref
		//IL_093b: Expected F4, but got I
		object obj2 = default(object);
		object obj = obj2;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		_ = 0;
		global::System.Collections.Generic.HashSet<int> hashSet = default(global::System.Collections.Generic.HashSet<int>);
		if (hashSet != null)
		{
			nint num = 0;
			nint num2 = 0;
			nint num3 = 0;
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator();
			_ = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			object obj5 = default(object);
			object obj4 = obj5;
			float num5 = 0f;
			global::UnityEngine.ParticleSystem.MinMaxGradient minMaxGradient;
			object obj7 = default(object);
			nint num6 = default(nint);
			object obj9 = default(object);
			global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
			object obj15 = default(object);
			float num11 = default(float);
			global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
			object obj16 = default(object);
			object obj18 = default(object);
			object obj21 = default(object);
			object obj28 = default(object);
			object obj29 = default(object);
			global::UnityEngine.Gradient gradient2 = default(global::UnityEngine.Gradient);
			bool flag7 = default(bool);
			float num18 = default(float);
			object obj31 = default(object);
			object obj33 = default(object);
			global::UnityEngine.ParticleSystem.MinMaxGradient minMaxGradient2 = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
			global::UnityEngine.ParticleSystemGradientMode mode = default(global::UnityEngine.ParticleSystemGradientMode);
			global::UnityEngine.Color color = default(global::UnityEngine.Color);
			object obj34 = default(object);
			global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			global::UnityEngine.Vector3 position2 = default(global::UnityEngine.Vector3);
			global::UnityEngine.Color color2 = default(global::UnityEngine.Color);
			global::UnityEngine.ParticleSystem.MinMaxGradient minMaxGradient3 = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
			nint num8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X23_v4 (Il2CppMethodInfo)+970]");
				minMaxGradient = (global::UnityEngine.ParticleSystem.MinMaxGradient)0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj7 & 1) != 0)
				{
					object obj30;
					object obj32;
					bool flag3;
					if ((object)solver != null)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X24_v4 (Il2CppMethodInfo)+C28]");
						num6 = 0;
						bool flag = (byte)((nint)obj2 - 148) != 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
						int num7 = (int)((nint)obj9 & 1);
						bool flag2 = num7 == 0;
						flag3 = flag;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v72 @ X24_v4 (Il2CppMethodInfo)+C28]");
						num8 = 0;
						if (flag2)
						{
							continue;
						}
						FluidSolver fluidSolver = solver;
						if ((object)solver != null)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-94]");
							object obj10 = 0;
							global::Unity.Collections.NativeArray<int> powerUpIds = fluidSolver.powerUpIds;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v756 @ X8_v23 (Unity.Collections.NativeArray`1<System.Int32>)+v394 @ X9_v5*4]");
							object obj11 = (nint)0 + (nint)1;
							bool flag4 = obj11 == null;
							bool flag5 = !flag4;
							flag3 = flag;
							num8 = num6;
							if (flag5)
							{
								continue;
							}
							global::UnityEngine.Transform transform = base.transform;
							FluidSolver fluidSolver2 = solver;
							if ((object)solver != null)
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-94]");
								int num9 = (int)((nint)0 << 3);
								object obj12 = fluidSolver2.positions + num9;
								float5.x = (float)obj12;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v760 @ X8_v27+4]");
								float5.y = 0f;
								global::UnityEngine.Vector2 vector = float5;
								if ((object)transform != null)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
									object obj13 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v771 @ X8_v30+B8]");
									object obj14 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v31+58]");
									obj15 = (nint)0 * (nint)0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v772 @ X8_v31+54]");
									float num10 = 0f * 5f;
									num11 = (position.x = vector.x + num10);
									position.y = (float)obj15;
									position.z = (float)obj16;
									transform.position = position;
									FluidSolver fluidSolver3 = solver;
									if ((object)solver != null)
									{
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-94]");
										object obj17 = 0;
										global::Unity.Collections.NativeArray<int> particleTypes = fluidSolver3.particleTypes;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
										if (obj18 != null)
										{
											global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v39+78]");
											object obj19 = 0;
											global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v789 @ X0_v39+78]");
											if ((nint)0 != 0)
											{
												global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v35+28]");
												object obj20 = 0;
												global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v745 @ X8_v35+28]");
												if ((nint)0 != 0)
												{
													global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
													if (obj21 != null)
													{
														global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v44+78]");
														object obj22 = 0;
														global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v791 @ X0_v44+78]");
														if ((nint)0 != 0)
														{
															global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v37+28]");
															object obj23 = 0;
															global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v37+28]");
															if ((nint)0 != 0)
															{
																global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v33 (Unity.Collections.NativeArray`1<System.Int32>)+v693 @ X9_v7*4]");
																nint num12 = 0;
																global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v36+18]");
																object obj24 = num12 / 0;
																nint num13 = (nint)obj24;
																global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v742 @ X8_v36+18]");
																object obj25 = num13 * 0;
																global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v782 @ X8_v33 (Unity.Collections.NativeArray`1<System.Int32>)+v693 @ X9_v7*4]");
																object obj26 = -(nint)obj25;
																global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v741 @ X8_v38+18]");
																if ((nint)obj26 < 0)
																{
																	int num14 = (int)((nint)obj26 << 4);
																	global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v746 @ X8_v37+28]");
																	object obj27 = (nint)0 + (nint)num14;
																	float value = global::UnityEngine.Random.value;
																	float num15 = 0f;
																	global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v39+20]");
																	float num16 = num15 - 0f;
																	float num17 = num16 * (float)obj5;
																	global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v39+20]");
																	global::UnityEngine.Gradient gradient = (global::UnityEngine.Gradient)(0 + num17);
																	bool flag6 = !(value < 1f);
																	global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v39+20]");
																	obj28 = 0;
																	obj29 = obj5;
																	gradient2 = gradient;
																	flag7 = flag;
																	num18 = value;
																	if (!flag6)
																	{
																		if ((object)cloudParticles == null)
																		{
																			global::System.NullReferenceException ex = new global::System.NullReferenceException();
																			obj30 = obj31;
																			obj32 = obj33;
																			obj5 = minMaxGradient2.m_GradientMax;
																			flag3 = false;
																			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v73 (UnityEngine.ParticleSystem+MinMaxGradient)+20]");
																			num5 = 0f;
																			minMaxGradient = (global::UnityEngine.ParticleSystem.MinMaxGradient)(&mode);
																			break;
																		}
																		global::UnityEngine.ParticleSystem.MainModule main = cloudParticles.main;
																		color.r = (float)gradient;
																		color.g = (float)obj34;
																		color.b = (float)obj33;
																		color.a = (float)obj31;
																		minMaxGradient2 = color;
																		mode = minMaxGradient2.m_Mode;
																		global::UnityEngine.ParticleSystem.MainModule mainModule = (global::UnityEngine.ParticleSystem.MainModule)((nint)obj2 - 160);
																		mainModule.startColor = (global::UnityEngine.ParticleSystem.MinMaxGradient)(&mode);
																		if ((object)cloudParticles == null)
																		{
																			global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
																			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v39+20]");
																			obj30 = 0;
																			obj32 = obj5;
																			obj5 = vector2.y;
																			flag3 = flag;
																			num5 = vector2.x;
																			minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
																			break;
																		}
																		cloudParticles.Emit(1);
																		obj28 = obj31;
																		obj29 = obj33;
																		gradient2 = minMaxGradient2.m_GradientMax;
																		flag7 = false;
																		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v820 @ X0_v73 (UnityEngine.ParticleSystem+MinMaxGradient)+20]");
																		num18 = 0f;
																	}
																	global::UnityEngine.Transform transform2 = base.transform;
																	FluidSolver fluidSolver4 = solver;
																	if ((object)solver != null)
																	{
																		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-94]");
																		int num19 = (int)((nint)0 << 3);
																		object obj35 = fluidSolver4.positions + num19;
																		float6.x = (float)obj35;
																		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v822 @ X8_v43+4]");
																		float6.y = 0f;
																		vector2 = float6;
																		if ((object)transform2 != null)
																		{
																			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v270 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
																			object obj36 = 0;
																			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v835 @ X8_v46+B8]");
																			object obj37 = 0;
																			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v47+58]");
																			object obj38 = (nint)0 * (nint)0;
																			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v424 @ X8_v47+54]");
																			float num20 = 0f * 5f;
																			float x = vector2.x + num20;
																			position2.x = x;
																			position2.y = (float)obj38;
																			position2.z = (float)obj16;
																			transform2.position = position2;
																			num5 = global::UnityEngine.Random.value;
																			bool flag8 = !(num5 < 0.1f);
																			obj30 = obj28;
																			obj32 = obj16;
																			obj4 = 1036831949;
																			flag3 = flag7;
																			num8 = num6;
																			if (!flag8)
																			{
																				if ((object)sparkleParticles == null)
																				{
																					global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
																					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X8_v39+20]");
																					obj30 = 0;
																					obj32 = obj5;
																					obj5 = gradient;
																					flag3 = flag;
																					num5 = value;
																					minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
																					break;
																				}
																				global::UnityEngine.ParticleSystem.MainModule main2 = sparkleParticles.main;
																				float num21 = 0f - (float)gradient;
																				float num22 = num21 * 0f;
																				float r = (float)gradient + num22;
																				color2.r = r;
																				color2.g = (float)obj34;
																				color2.b = (float)obj33;
																				color2.a = (float)obj31;
																				minMaxGradient3 = color2;
																				mode = minMaxGradient3.m_Mode;
																				global::UnityEngine.ParticleSystem.MainModule mainModule2 = (global::UnityEngine.ParticleSystem.MainModule)((nint)obj2 - 168);
																				mainModule2.startColor = (global::UnityEngine.ParticleSystem.MinMaxGradient)(&mode);
																				sparkleParticles.Emit(1);
																				obj30 = obj31;
																				obj32 = obj33;
																				obj4 = minMaxGradient3.m_GradientMax;
																				flag3 = false;
																				num8 = num6;
																				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v63 (UnityEngine.ParticleSystem+MinMaxGradient)+20]");
																				num5 = 0f;
																			}
																			continue;
																		}
																		global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
																		obj32 = obj16;
																		obj5 = obj15;
																		flag3 = flag;
																		num5 = num11;
																		minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
																		break;
																	}
																	global::System.NullReferenceException ex5 = new global::System.NullReferenceException();
																	obj32 = obj16;
																	obj5 = obj15;
																	flag3 = flag;
																	num5 = num11;
																	minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
																	break;
																}
																global::System.IndexOutOfRangeException ex6 = new global::System.IndexOutOfRangeException();
																obj32 = obj16;
																obj5 = obj15;
																flag3 = flag;
																num5 = num11;
																minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
																break;
															}
															global::System.NullReferenceException ex7 = new global::System.NullReferenceException();
															obj5 = obj4;
															flag3 = flag;
															global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X29_v1-80]");
															minMaxGradient = (global::UnityEngine.ParticleSystem.MinMaxGradient)0;
															break;
														}
														global::System.NullReferenceException ex8 = new global::System.NullReferenceException();
														obj32 = obj16;
														obj5 = obj15;
														flag3 = flag;
														num5 = num11;
														minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
														break;
													}
													global::System.NullReferenceException ex9 = new global::System.NullReferenceException();
													obj32 = obj16;
													obj5 = obj15;
													flag3 = flag;
													num5 = num11;
													minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
													break;
												}
												global::System.NullReferenceException ex10 = new global::System.NullReferenceException();
												obj32 = obj16;
												obj5 = obj15;
												flag3 = flag;
												num5 = num11;
												minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
												break;
											}
											global::System.NullReferenceException ex11 = new global::System.NullReferenceException();
											obj5 = vector.y;
											flag3 = flag;
											num5 = vector.x;
											minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
											break;
										}
										global::System.NullReferenceException ex12 = new global::System.NullReferenceException();
										obj32 = obj16;
										obj5 = obj15;
										flag3 = flag;
										num5 = num11;
										minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
										break;
									}
									global::System.NullReferenceException ex13 = new global::System.NullReferenceException();
									obj5 = obj4;
									flag3 = flag;
									minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
									break;
								}
								global::System.NullReferenceException ex14 = new global::System.NullReferenceException();
								obj32 = obj16;
								obj5 = obj15;
								flag3 = flag;
								num5 = num11;
								minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
								break;
							}
							global::System.NullReferenceException ex15 = new global::System.NullReferenceException();
							obj30 = obj28;
							obj32 = obj29;
							obj5 = gradient2;
							flag3 = flag7;
							num5 = num18;
							minMaxGradient = default(global::UnityEngine.ParticleSystem.MinMaxGradient);
							break;
						}
						global::System.NullReferenceException ex16 = new global::System.NullReferenceException();
						obj5 = obj4;
						num6 = num6;
						break;
					}
					global::System.NullReferenceException ex17 = new global::System.NullReferenceException();
					obj30 = obj31;
					obj32 = obj33;
					obj5 = minMaxGradient3.m_GradientMax;
					flag3 = false;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v858 @ X0_v63 (UnityEngine.ParticleSystem+MinMaxGradient)+20]");
					num5 = 0f;
					minMaxGradient = (global::UnityEngine.ParticleSystem.MinMaxGradient)(&mode);
					break;
				}
				nint num23 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				return;
			}
			num8 = num6;
			hashSet = (global::System.Collections.Generic.HashSet<int>)minMaxGradient;
		}
		global::System.NullReferenceException ex18 = new global::System.NullReferenceException();
		bool flag9 = (nint)hashSet != 1;
		global::System.NullReferenceException ex19 = ex18;
		if (!flag9)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			nint num24 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v564 @ X8_v5 (Il2CppMethodInfo)+968]");
			hashSet = (global::System.Collections.Generic.HashSet<int>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj40 = default(object);
			if (obj40 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex20 = new global::System.OutOfMemoryException();
			ex19 = (global::System.NullReferenceException)(object)ex20;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600039B")]
	[global::Cpp2ILInjected.Address(RVA = "0x101509C", Offset = "0x101509C", Length = "0x194")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001C;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0x58;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, powerUp, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv49 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv50 = v49 + 0xFD8;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, powerUp, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302AA84]) = v47;\nL_001C:\n\tv51 = this.powerUpExplosionPrefabs;\n\tv95 = powerUp.mergeIndex;\n\tv65 = powerUp.mergeIndex >= v51.Length;\n\tif (v65) goto L_0094;\n\tv180 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv181 = *([v180 @ X21_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv182 = *([v181 @ X0_v7+E0]) == 0;\n\tif (v182) goto L_0087;\n\tv163 = UnityEngine.Object::op_Inequality(v51[v95 @ X9_v3 (System.Int32)], 0);\n\tv166 = ~v163;\n\tif (v166) goto L_0094;\nL_0049:\n\tgoto L_004B;\n\tv239 = \"il2cpp_codegen_runtime_class_init\"(v234, v231, v56, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_004B:\n\tv241 = Il2CppMethodInfo;\n\tv97 = UnityEngine.Object::Instantiate /* +1 sharing this address */(v51[v95 @ X9_v3 (System.Int32)], *([v241 @ X8_v10 (Il2CppMethodInfo)+58]));\n\tv243 = UnityEngine.GameObject::get_transform(v97);\n\tgoto L_0063;\n\tv247 = System.Xml.ValidateNames;\n\tv248 = v247 + 0xD0;\n\tv249 = \"il2cpp_codegen_initialize_runtime_metadata\"(v248, v59, v56, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv250 = 1;\n\t*([2DD4422]) = v250;\nL_0063:\n\tv251 = System.Xml.ValidateNames;\n\tv253 = *([v251 @ X8_v14 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv219 = *([v253 @ X8_v16+B8]);\n\tv256 = *([v219 @ X8_v17+5C]) * 4f;\n\tv260 = *([v219 @ X8_v17+54]) * 0;\n\tv261 = powerUp.position + v260;\n\t// 115 MakeStruct v190 @ AGG10151D8_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v261 @ V0_v5 (System.Single), v262 @ V0.S1, v256 @ V0_v2 (System.Single)\n\tUnityEngine.Transform::set_position(v243, v190);\n\tUnityEngine.Object::Destroy(v97, 1f);\n\treturn;\nL_0087:\n\tv162 = UnityEngine.Object::op_Inequality(v51[v95 @ X9_v3 (System.Int32)], 0);\n\tv238 = ~v162;\n\tv165 = ~v238;\n\tif (v165) goto L_0049;\nL_0094:\n\treturn;\n\tv113 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 103 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnDetonatePowerUp(PowerUp powerUp)
	{
		//IL_0055: Expected I, but got O
		//IL_0065: Expected O, but got I
		//IL_00f4: Expected I, but got O
		//IL_0104: Expected O, but got I
		//IL_0114: Expected O, but got I
		//IL_0142: Expected O, but got I
		//IL_0175: Expected F4, but got O
		global::UnityEngine.GameObject[] array = powerUpExplosionPrefabs;
		int mergeIndex = powerUp.mergeIndex;
		if (powerUp.mergeIndex >= array.Length)
		{
			return;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X21_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v181 @ X0_v7+E0]");
		if ((nint)0 != 0)
		{
			if (!(array[mergeIndex] != null))
			{
				return;
			}
		}
		else if (!(array[mergeIndex] != null))
		{
			return;
		}
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1171058 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		global::UnityEngine.GameObject gameObject = default(global::UnityEngine.GameObject);
		global::UnityEngine.Transform transform = gameObject.transform;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X8_v14 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v253 @ X8_v16+B8]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v17+5C]");
		float z = 0f * 4f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v219 @ X8_v17+54]");
		object obj4 = (nint)0 * (nint)0;
		float x = powerUp.position.x + (float)obj4;
		global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
		position.x = x;
		object obj5 = default(object);
		position.y = (float)obj5;
		position.z = z;
		transform.position = position;
		global::UnityEngine.Object.Destroy(gameObject, 1f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600039C")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015230", Offset = "0x1015230", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public RemoveParticleFX()
	{
	}
}
