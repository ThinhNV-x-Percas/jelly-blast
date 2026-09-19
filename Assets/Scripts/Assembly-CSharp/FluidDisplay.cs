[global::Cpp2ILInjected.Token(Token = "0x200005A")]
public class FluidDisplay : FluidRendererBase
{
	[global::Cpp2ILInjected.Token(Token = "0x400017C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	private FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x400017D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private float fixedDeltaTime;

	[global::Cpp2ILInjected.Token(Token = "0x400017E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public float particleSize;

	[global::Cpp2ILInjected.Token(Token = "0x400017F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public int[] particleIds;

	[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF0F60", Offset = "0xFF0F60", Length = "0x26C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = CollectParticleData[];\n\tgoto L_002E;\n\tv33 = System.Collections.Generic.NullableComparer`1;\n\tv34 = v33 + 0xC48;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv58 = System.Collections.Generic.NullableComparer`1;\n\tv59 = v58 + 0xDB8;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv64 = Il2CppMethodInfo;\n\tv65 = v64 + 0x548;\n\tv66 = \"il2cpp_codegen_initialize_runtime_metadata\"(v65, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv71 = Il2CppMethodInfo;\n\tv72 = v71 + 0x550;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv78 = CollectParticleData[];\n\tv79 = v78 + 0x2D0;\n\tv80 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv85 = Il2CppMethodInfo;\n\tv86 = v85 + 0xC90;\n\tv87 = \"il2cpp_codegen_initialize_runtime_metadata\"(v86, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv89 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv90 = v89 + 0xA48;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v90, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302A9BD]) = v54;\nL_002E:\n\tv55 = Il2CppMethodInfo;\n\tFluidRendererBase::Init(this);\n\tv63 = \"SzArrayNew\"(*([v26 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+2D0]), this.maxParticles, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv69 = this + 0x80;\n\tthis.particleIds = v63;\n\tv70 = 0xF3F1B4(v69, v63, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_0041;\n\tv81 = \"il2cpp_codegen_runtime_class_init\"(v74, v67, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_0041:\n\tv84 = Singleton`1::get_Instance /* +1 sharing this address */(*([v55 @ X22_v2 (Il2CppMethodInfo)+C90]));\n\tv181 = this + 0x70;\n\tthis.solver = *([v84 @ X0_v11+30]);\n\tv95 = 0xF3F1B4(v181, *([v84 @ X0_v11+30]), v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv117 = Singleton`1::get_Instance /* +1 sharing this address */(*([v55 @ X22_v2 (Il2CppMethodInfo)+C90]));\n\tv132 = *([v117 @ X0_v21+38]);\n\tthis.fixedDeltaTime = *([v132 @ X8_v7+28]);\n\tv133 = this.solver;\n\tv221 = System.Collections.Generic.NullableComparer`1;\n\tv222 = Il2CppMethodInfo;\n\tv128 = this.solver + 0x258;\n\tv225 = new *([v221 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+C48])();\n\tSystem.Action`1<System.Object>::.ctor(v225, this, *([v222 @ X25_v5 (Il2CppMethodInfo)+548]));\n\tv231 = System.Delegate::Combine(v133.OnAddParticles, v225);\n\tv232 = v231 == 0;\n\tif (v232) goto L_00A2;\n\tv235 = 0xF3F36C(v231, *([v221 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+C48]), 0, 0, v39, v40, v41, v42, *([v132 @ X8_v7+28]), v44, v45, v46, v47, v48, v49, v50);\n\tv245 = v235 == 0;\n\tif (v245) goto L_00BC;\n\tv133.OnAddParticles = v235;\n\tv249 = 0xF3F36C(v231, *([v221 @ X24_v5 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+C48]), 0, 0, v39, v40, v41, v42, *([v132 @ X8_v7+28]), v44, v45, v46, v47, v48, v49, v50);\n\tv252 = v249 == 0;\n\tif (v252) goto L_00BC;\n\tv118 = 0xF3F1B4(v128, v249, 0, 0, v39, v40, v41, v42, *([v132 @ X8_v7+28]), v44, v45, v46, v47, v48, v49, v50);\n\tv163 = this.solver;\nL_007C:\n\tv264 = System.Collections.Generic.NullableComparer`1;\n\tv265 = Il2CppMethodInfo;\n\tv181 = v163 + 0x260;\n\tv267 = new *([v264 @ X23_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8])();\n\tSystem.Action`2<System.Object, System.Boolean>::.ctor(v267, v167, *([v265 @ X24_v9 (Il2CppMethodInfo)+550]));\n\tv155 = System.Delegate::Combine(v163.OnStartRemoveParticles, v267);\n\tv157 = v155 == 0;\n\tif (v157) goto L_00AB;\n\tv128 = *([v264 @ X23_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]);\n\tv274 = 0xF3F36C(v155, *([v264 @ X23_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v39, v40, v41, v42, *([v132 @ X8_v7+28]), v44, v45, v46, v47, v48, v49, v50);\n\tv275 = v274 == 0;\n\tif (v275) goto L_FFFFFFFF;\n\tv163.OnStartRemoveParticles = v274;\n\tv178 = 0xF3F36C(v155, *([v264 @ X23_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v39, v40, v41, v42, *([v132 @ X8_v7+28]), v44, v45, v46, v47, v48, v49, v50);\n\tv281 = v178 == 0;\n\tv180 = ~v281;\n\tif (v180) goto L_00B8;\n\tthrow System.InvalidCastException;\nL_00A2:\n\t*([v128 @ X21_v8]) = 0;\n\tv116 = 0xF3F1B4(v128, 0, 0, 0, v39, v40, v41, v42, *([v132 @ X8_v7+28]), v44, v45, v46, v47, v48, v49, v50);\n\tv163 = *([v181 @ X20_v3]);\n\tv246 = *([v181 @ X20_v3]) == 0;\n\tv120 = ~v246;\n\tif (v120) goto L_007C;\n\tthrow System.NullReferenceException;\nL_00AB:\n\t*([v181 @ X20_v3]) = 0;\nL_00B8:\n\tv199 = 0xF3F1B4(v181, v175, v170, v169, v39, v40, v41, v42, *([v132 @ X8_v7+28]), v44, v45, v46, v47, v48, v49, v50);\n\treturn;\nL_00BC:\n\tthrow System.InvalidCastException;\n// 103 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void Init()
	{
		//IL_000e: Expected I, but got O
		//IL_034f: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_006e: Expected O, but got I
		//IL_0085: Expected F4, but got I
		//IL_00a2: Expected I, but got O
		//IL_00b9: Expected O, but got I
		//IL_0103: Expected O, but got I4
		//IL_010c: Expected O, but got I4
		//IL_02d0: Expected O, but got I4
		//IL_01a6: Expected I, but got O
		//IL_01bb: Expected O, but got I
		//IL_0208: Expected O, but got I4
		//IL_0211: Expected O, but got I4
		//IL_0319: Expected O, but got I4
		//IL_022f: Expected O, but got I
		//IL_02b8: Expected O, but got I4
		//IL_02c1: Expected O, but got I4
		//IL_0290: Expected O, but got I4
		//IL_0299: Expected O, but got I4
		nint num = (nint)typeof(CollectParticleData[]);
		nint num2 = 0;
		object obj2 = null;
		object obj4 = null;
		base.Init();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		int[] array = default(int[]);
		particleIds = array;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X0_v11+30]");
		solver = (FluidSolver)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v117 @ X0_v21+38]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X8_v7+28]");
		fixedDeltaTime = 0f;
		FluidSolver fluidSolver = solver;
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v222 @ X25_v5 (Il2CppMethodInfo)+548]");
		global::System.Delegate b = new global::System.Action<object>(this, (global::System.IntPtr)0);
		global::System.Delegate obj5 = global::System.Delegate.Combine(fluidSolver.OnAddParticles, b);
		bool flag = (object)obj5 == null;
		object obj6 = 0;
		object obj7 = 0;
		FluidDisplay fluidDisplay = this;
		FluidSolver fluidSolver2;
		if (!flag)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<global::System.Collections.Generic.HashSet<int>> action = default(global::System.Action<global::System.Collections.Generic.HashSet<int>>);
			if (action != null)
			{
				fluidSolver.OnAddParticles = action;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				object obj8 = default(object);
				if (obj8 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					fluidSolver2 = solver;
					fluidDisplay = this;
					goto IL_0198;
				}
			}
			throw new global::System.InvalidCastException();
		}
		obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		fluidSolver2 = (FluidSolver)obj2;
		if (obj2 == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_0198;
		IL_0198:
		nint num6 = 0;
		obj2 = (nint)fluidSolver2 + 608;
		FluidDisplay fluidDisplay2 = fluidDisplay;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v265 @ X24_v9 (Il2CppMethodInfo)+550]");
		global::System.Delegate b2 = new global::System.Action<object, bool>(fluidDisplay2, (global::System.IntPtr)0);
		global::System.Delegate obj9 = global::System.Delegate.Combine(fluidSolver2.OnStartRemoveParticles, b2);
		bool flag2 = (object)obj9 == null;
		obj6 = 0;
		obj7 = 0;
		int num8;
		if (!flag2)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X23_v8 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]");
			obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<global::System.Collections.Generic.HashSet<int>, bool> action2 = default(global::System.Action<global::System.Collections.Generic.HashSet<int>, bool>);
			if (action2 != null)
			{
				fluidSolver2.OnStartRemoveParticles = action2;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				int num7 = default(int);
				bool flag3 = num7 == 0;
				bool flag4 = !flag3;
				obj6 = 0;
				obj7 = 0;
				num8 = num7;
				if (flag4)
				{
					goto IL_0368;
				}
			}
			obj6 = 0;
			obj7 = 0;
			throw new global::System.InvalidCastException();
		}
		obj2 = 0;
		num8 = 0;
		goto IL_0368;
		IL_0368:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF131C", Offset = "0xFF131C", Length = "0x38C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0039;\n\tv35 = System.Collections.Generic.NullableComparer`1;\n\tv36 = v35 + 0xD10;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0x968;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv162 = Il2CppMethodInfo;\n\tv163 = v162 + 0x970;\n\tv164 = \"il2cpp_codegen_initialize_runtime_metadata\"(v163, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv168 = Il2CppMethodInfo;\n\tv169 = v168 + 0x978;\n\tv170 = \"il2cpp_codegen_initialize_runtime_metadata\"(v169, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv244 = Il2CppMethodInfo;\n\tv245 = v244 + 0x998;\n\tv246 = \"il2cpp_codegen_initialize_runtime_metadata\"(v245, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv265 = Il2CppMethodInfo;\n\tv266 = v265 + 0xC30;\n\tv267 = \"il2cpp_codegen_initialize_runtime_metadata\"(v266, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv278 = Il2CppMethodInfo;\n\tv279 = v278 + 0xC90;\n\tv280 = \"il2cpp_codegen_initialize_runtime_metadata\"(v279, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv333 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv334 = v333 + 0xA48;\n\tv335 = \"il2cpp_codegen_initialize_runtime_metadata\"(v334, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv375 = Il2CppMethodInfo;\n\tv376 = v375 + 0xD30;\n\tv377 = \"il2cpp_codegen_initialize_runtime_metadata\"(v376, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv384 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv385 = v384 + 0xB68;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v385, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv55 = 1;\n\t*([302A9BE]) = v55;\nL_0039:\n\tv59 = v253 == 0;\n\tif (v59) goto L_00F0;\n\tv65 = Il2CppMethodInfo;\n\tv67 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv69 = Il2CppMethodInfo;\n\tv73 = Il2CppMethodInfo;\n\tv79 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v253);\n\tgoto L_005B;\nL_0054:\n\tv445 = v211.activeCount + 1;\n\tv211.activeCount = v445;\n\tv226 = this.activeCount + 1;\n\tthis.activeCount = v226;\nL_005B:\n\tv232 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v143 @ stack_-A8 (System.Int32), *([v65 @ X25_v4 (Il2CppMethodInfo)+970]));\n\tv247 = v232 & 1;\n\tv248 = v247 == 0;\n\tif (v248) goto L_00CB;\n\tv269 = new *([v67 @ X26_v4 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+B68])();\n\tSystem.Object::.ctor(v269);\n\tv336 = v269 == 0;\n\tif (v336) goto L_00E4;\n\tv379 = v269 + 0x18;\n\t*([v269 @ X0_v24 (System.Object)+18]) = this;\n\tv381 = 0xF3F1B4(v379, this, v131, v89, 0, v41, v42, v43, v143, v45, v46, v47, v48, v49, v50, v51);\n\tv387 = this.solver == 0;\n\tif (v387) goto L_00E6;\n\tv388 = this.solver + 0x1F8;\n\tv389 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v388, v166, *([v69 @ X27_v4 (Il2CppMethodInfo)+C30]));\n\t*([v269 @ X0_v24 (System.Object)+14]) = v389;\n\tv408 = this.solver;\n\tv403 = this.solver == 0;\n\tif (v403) goto L_00E0;\n\tv412 = v408.particleTypes;\n\t*([v269 @ X0_v24 (System.Object)+10]) = *([v412 @ X8_v19 (Unity.Collections.NativeArray`1<System.Int32>)+v389 @ X0_v32*4]);\n\tgoto L_0081;\n\tv416 = \"il2cpp_codegen_runtime_class_init\"(v413, v218, v215, v174, v81, v41, v42, v43, v140, v45, v46, v47, v48, v49, v50, v51);\nL_0081:\n\tv221 = Singleton`1::get_Instance /* +1 sharing this address */(*([v73 @ X24_v4 (Il2CppMethodInfo)+C90]));\n\tv404 = v221 == 0;\n\tif (v404) goto L_00E2;\n\tv407 = *([v221 @ X0_v37+78]);\n\tv402 = *([v221 @ X0_v37+78]) == 0;\n\tif (v402) goto L_00DE;\n\tv410 = *([v407 @ X8_v21+28]);\n\tv224 = *([v407 @ X8_v21+28]) == 0;\n\tif (v224) goto L_00E8;\n\tv185 = *([v412 @ X8_v19 (Unity.Collections.NativeArray`1<System.Int32>)+v389 @ X0_v32*4]) >= *([v410 @ X8_v22+18]);\n\tif (v185) goto L_005B;\n\tv406 = this.particleIds;\n\tv401 = this.particleIds == 0;\n\tif (v401) goto L_00EA;\n\tv183 = this.activeCount;\n\tv406[v183 @ X9_v5 (System.Int32)] = v166;\n\tv211 = this.compute;\n\tv422 = System.Collections.Generic.NullableComparer`1;\n\tv425 = new *([v422 @ X8_v26 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D10])();\n\tv426 = Il2CppMethodInfo;\n\tSystem.Action`1<ParticleInitData>::.ctor(v425, v269, *([v426 @ X8_v28 (Il2CppMethodInfo)+D30]));\n\tv405 = this.compute == 0;\n\tif (v405) goto L_00EC;\n\tv214 = v211.activeCount;\n\tFluidCompute::InitParticle(this.compute, v166, v211.activeCount);\n\tv223 = v425 == 0;\n\tif (v223) goto L_0054;\n\tParticleInitData::.ctor(&v434 @ stack_-70_v5 (ParticleInitData), v211.activeCount, v166, 0);\n\tv89 = v425.method;\n\tv425.invoke_impl(v441, v425.method_code, v434, 0, v425.method, 0, v41, v42, v43, v143, v45, v46, v47, v48, v49, v50, v51);\n\tgoto L_0054;\nL_00CB:\n\tv270 = Il2CppMethodInfo;\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v143 @ stack_-A8 (System.Int32), *([v270 @ X8_v14 (Il2CppMethodInfo)+968]));\nL_00DD:\n\treturn;\nL_00DE:\n\tv395 = new System.NullReferenceException();\n\tgoto L_00EF;\nL_00E0:\n\tv396 = new System.NullReferenceException();\n\tgoto L_00EF;\nL_00E2:\n\tv397 = new System.NullReferenceException();\n\tgoto L_00EF;\nL_00E4:\n\tthrow v269;\nL_00E6:\n\tv390 = new System.NullReferenceException();\n\tgoto L_00EF;\nL_00E8:\n\tv398 = new System.NullReferenceException();\n\tgoto L_00EF;\nL_00EA:\n\tv399 = new System.NullReferenceException();\n\tgoto L_00EF;\nL_00EC:\n\tthrow v425;\n\tv394 = new System.IndexOutOfRangeException();\nL_00EF:\n\t// 239 Interrupt\nL_00F0:\n\tv161 = new System.NullReferenceException();\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\n\tgoto L_0109;\nL_0109:\n\tv243 = v253 != 1;\n\tif (v243) goto L_011B;\n\tv250 = 0x274A080(v161, v253, v131, v89, 0, v41, v42, v43, v143, v45, v46, v47, v48, v49, v50, v51);\n\tv275 = 0x274A098(v250, v253, v131, v89, 0, v41, v42, v43, v143, v45, v46, v47, v48, v49, v50, v51);\n\tv331 = Il2CppMethodInfo;\n\tv253 = *([v331 @ X8_v5 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v143 @ stack_-A8 (System.Int32), *([v331 @ X8_v5 (Il2CppMethodInfo)+968]));\n\tv258 = *([v250 @ X0_v11]) == 0;\n\tif (v258) goto L_00DD;\n\tv256 = new System.OutOfMemoryException();\nL_011B:\n\tv264 = 0xBF092C(&v143 @ stack_-A8 (System.Int32), v253, v131, v89, 0, v41, v42, v43, v143, v45, v46, v47, v48, v49, v50, v51);\n\tv277 = 0x27498DC(v261, v253, v131, v89, 0, v41, v42, v43, v143, v45, v46, v47, v48, v49, v50, v51);\n\tv332 = 0xD6F8(v277, v253, v131, v89, 0, v41, v42, v43, v143, v45, v46, v47, v48, v49, v50, v51);\n\treturn;\n// 141 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnSolverAddParticles(global::System.Collections.Generic.HashSet<int> ids)
	{
		//IL_001a: Expected I, but got O
		//IL_049a: Expected O, but got I
		//IL_04d2: Expected I4, but got O
		//IL_00ba: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_03ab: Expected O, but got I4
		//IL_03d1: Expected O, but got I4
		//IL_0184: Expected O, but got I
		//IL_0385: Expected O, but got I4
		//IL_01b9: Expected O, but got I
		//IL_0422: Expected O, but got I4
		//IL_027e: Expected I, but got O
		global::System.Collections.Generic.HashSet<int> hashSet = default(global::System.Collections.Generic.HashSet<int>);
		if (hashSet != null)
		{
			nint num = 0;
			nint num3 = 0;
			nint num4 = 0;
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator();
			object obj = default(object);
			object obj5 = default(object);
			FluidDisplay fluidDisplay;
			int num7 = default(int);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj & 1) != 0)
				{
					object obj2 = new object();
					if (obj2 != null)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
						if ((object)solver != null)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E75E4 (Unity.Collections.NativeHashMap`2::get_Item, and 1 more at this address)");
							FluidSolver fluidSolver = solver;
							nint num6;
							if ((object)solver != null)
							{
								global::Unity.Collections.NativeArray<int> particleTypes = fluidSolver.particleTypes;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v19 (Unity.Collections.NativeArray`1<System.Int32>)+v389 @ X0_v32*4]");
								_ = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
								if (obj5 != null)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v37+78]");
									object obj6 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X0_v37+78]");
									if ((nint)0 != 0)
									{
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v21+28]");
										object obj7 = 0;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v407 @ X8_v21+28]");
										if ((nint)0 != 0)
										{
											global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X8_v19 (Unity.Collections.NativeArray`1<System.Int32>)+v389 @ X0_v32*4]");
											nint num5 = 0;
											global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X8_v22+18]");
											bool flag = num5 >= 0;
											global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v4 (Il2CppMethodInfo)+C30]");
											num6 = 0;
											if (!flag)
											{
												int[] array = particleIds;
												if (particleIds == null)
												{
													global::System.NullReferenceException ex = new global::System.NullReferenceException();
													global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v4 (Il2CppMethodInfo)+C30]");
													num6 = 0;
													fluidDisplay = (FluidDisplay)num7;
													break;
												}
												int num8 = activeCount;
												array[num8] = num7;
												FluidCompute fluidCompute = compute;
												global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v426 @ X8_v28 (Il2CppMethodInfo)+D30]");
												global::System.Action<ParticleInitData> action = new global::System.Action<ParticleInitData>(obj2, (global::System.IntPtr)0);
												nint num10 = 0;
												if ((object)compute == null)
												{
													throw action;
												}
												int num11 = fluidCompute.activeCount;
												compute.InitParticle(num7, fluidCompute.activeCount);
												bool flag2 = action == null;
												global::System.IntPtr intPtr = default(global::System.IntPtr);
												if (!flag2)
												{
													ParticleInitData particleInitData = new ParticleInitData(fluidCompute.activeCount, num7, 0);
													intPtr = action.method;
													global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v425.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
													num11 = 0;
												}
												int num12 = fluidCompute.activeCount + 1;
												fluidCompute.activeCount = num12;
												int num13 = activeCount + 1;
												activeCount = num13;
												num6 = num11;
											}
											continue;
										}
										global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
										fluidDisplay = this;
										break;
									}
									global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v4 (Il2CppMethodInfo)+C30]");
									num6 = 0;
									fluidDisplay = (FluidDisplay)num7;
									break;
								}
								global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v4 (Il2CppMethodInfo)+C30]");
								num6 = 0;
								fluidDisplay = (FluidDisplay)num7;
								break;
							}
							global::System.NullReferenceException ex5 = new global::System.NullReferenceException();
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v4 (Il2CppMethodInfo)+C30]");
							num6 = 0;
							fluidDisplay = (FluidDisplay)num7;
							break;
						}
						global::System.NullReferenceException ex6 = new global::System.NullReferenceException();
						fluidDisplay = null;
						break;
					}
					throw obj2;
				}
				nint num14 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				return;
			}
			int num15 = 0;
			hashSet = (global::System.Collections.Generic.HashSet<int>)(object)fluidDisplay;
		}
		global::System.NullReferenceException ex7 = new global::System.NullReferenceException();
		bool flag3 = (nint)hashSet != 1;
		global::System.NullReferenceException ex8 = ex7;
		if (!flag3)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			nint num16 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v331 @ X8_v5 (Il2CppMethodInfo)+968]");
			hashSet = (global::System.Collections.Generic.HashSet<int>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex9 = new global::System.OutOfMemoryException();
			int num15 = (int)obj8;
			ex8 = (global::System.NullReferenceException)(object)ex9;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF16B0", Offset = "0xFF16B0", Length = "0x178")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001B;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0x990;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, ids, explode, methodInfo, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv46 = 1;\n\t*([302A9BF]) = v46;\nL_001B:\n\tFluidCompute::RemoveParticles(this.compute, ids);\n\tv88 = this.activeCount < 1;\n\tif (v88) goto L_FFFFFFFF;\n\tgoto L_003E;\nL_0030:\n\tv260 = v260 + 1;\nL_0031:\n\tv84 = v84 + 1;\n\tv248 = v84 >= this.activeCount;\n\tif (v248) goto L_00BD;\nL_003E:\n\tv172 = this.particleIds;\n\tv161 = System.Collections.Generic.HashSet`1<System.Int32>::Contains(ids, v172[v84 @ X22_v6 (System.Int32)]);\n\tv312 = v161 == 0;\n\tv313 = ~v312;\n\tif (v313) goto L_0031;\n\tv125 = v84 == v260;\n\tif (v125) goto L_0030;\n\tv345 = v84 << 3;\n\tv58 = this.positions + v345;\n\tv69 = v260 << 3;\n\tv346 = this.positions + v69;\n\t*([v346 @ X9_v8+20]) = *([v58 @ X10_v6+20]);\n\tv76 = this.scales;\n\tv76[v260 @ X21_v9 (System.Int32)] = v76[v84 @ X22_v6 (System.Int32)];\n\tv77 = this.particleIds;\n\tv77[v260 @ X21_v9 (System.Int32)] = v77[v84 @ X22_v6 (System.Int32)];\n\tgoto L_0030;\nL_00BD:\n\tthis.activeCount = v259;\n\treturn;\n\tv159 = new System.IndexOutOfRangeException();\n\tthrow System.NullReferenceException;\n\treturn;\n// 174 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnSolverRemoveParticlesStart(global::System.Collections.Generic.HashSet<int> ids, bool explode)
	{
		//IL_00e9: Expected O, but got I
		//IL_0107: Expected O, but got I
		compute.RemoveParticles(ids);
		int num5;
		if (activeCount >= 1)
		{
			int num = 0;
			int num2 = 0;
			bool flag;
			do
			{
				int[] array = particleIds;
				if (!ids.Contains(array[num]))
				{
					if (num != num2)
					{
						int num3 = num << 3;
						object obj = (nint)positions + num3;
						int num4 = num2 << 3;
						object obj2 = (nint)positions + num4;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X10_v6+20]");
						_ = 0;
						float[] array2 = scales;
						array2[num2] = array2[num];
						int[] array3 = particleIds;
						array3[num2] = array3[num];
					}
					num2++;
				}
				num++;
				flag = num >= activeCount;
				num5 = num2;
			}
			while (!flag);
		}
		else
		{
			num5 = 0;
		}
		activeCount = num5;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF1828", Offset = "0xFF1828", Length = "0x3A4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0024;\n\tv33 = System.ComponentModel.BooleanConverter;\n\tv34 = v33 + 0xB98;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0x278;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv62 = Il2CppMethodInfo;\n\tv63 = v62 + 0xC30;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv395 = \"Hungarian\";\n\tv396 = v395 + 0x238;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v396, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302A9C0]) = v54;\nL_0024:\n\tv56 = UnityEngine.Time::get_time();\n\tv60 = this.solver;\n\tv76 = this.activeCount < 1;\n\tif (v76) goto L_017A;\n\tv399 = Il2CppMethodInfo;\n\tv402 = v56 - v60.<lastStepWallTime>k__BackingField;\n\tv404 = v402 / this.fixedDeltaTime;\n\tv408 = v404 - 1f;\n\tv409 = v408 < 0;\n\tv410 = v408 == 0;\n\tv411 = v404 ^ 1f;\n\tv412 = v404 ^ v408;\n\tv413 = v411 & v412;\n\tv414 = v413 < 0;\n\tv415 = v409 == v414;\n\tv170 = ~v410;\n\tv416 = v415 & v170;\n\tv417 = ~v416;\n\tif (v417) goto L_005C;\n\tgoto L_005C;\nL_005C:\n\tv166 = v404 >= 0;\n\tif (v166) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\nL_0066:\n\tv333 = this.particleIds;\n\tv632 = this.solver + 0x1F8;\n\tv346 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v632, v333[v199 @ X22_v8 (System.Int32)], *([v399 @ X23_v8 (Il2CppMethodInfo)+C30]));\n\tv378 = this.solver;\n\tv146 = v346 << 3;\n\tv379 = v378.positions + v146;\n\t// 133 MakeStruct v123 @ AGGFF1940_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v379 @ X8_v17], [v379 @ X8_v17+4]\n\tv174 = Unity.Mathematics.float2::op_Implicit(v123);\n\tv638 = this.positions + v203;\n\t*([v638 @ X8_v19+20]) = v174;\n\t*([v638 @ X8_v19+24]) = v174.y;\n\tv380 = this.solver;\n\tv334 = this.scales;\n\tv641 = v380.scales;\n\tv175 = this.particleSize * *([v641 @ X8_v21 (Unity.Collections.NativeArray`1<System.Single>)+v346 @ X0_v17*4]);\n\tv334[v199 @ X22_v8 (System.Int32)] = v175;\n\tv381 = this.particleIds;\n\tv335 = this.compute;\n\tv349 = System.Collections.Generic.Dictionary`2<System.Int32, System.Int32>::get_Item(v335.idToIndex, v381[v199 @ X22_v8 (System.Int32)]);\n\tv382 = this.solver;\n\tv149 = v346 << 3;\n\tv646 = v382.positionsPrev + v149;\n\t// 213 MakeStruct v113 @ AGGFF19E8_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v646 @ X8_v27], [v646 @ X8_v27+4]\n\tv176 = Unity.Mathematics.float2::op_Implicit(v113);\n\tv651 = v199 << 3;\n\tv652 = this.positions + v651;\n\tv655 = *([v652 @ X8_v29+20]) - v176;\n\tv187 = v655 * v656;\n\tv177 = v176 + v187;\n\tv150 = v199 << 3;\n\tv657 = this.interpPositions + v150;\n\t*([v657 @ X8_v30+20]) = v177;\n\tv384 = this.compute;\n\tv660 = v199 << 3;\n\tv661 = this.interpPositions + v660;\n\tv151 = v349 << 3;\n\tv662 = v384.positions + v151;\n\t*([v662 @ X9_v22+20]) = *([v661 @ X9_v21+20]);\n\tv339 = this.scales;\n\tv161 = v384.scales;\n\tv161[v349 @ X0_v20 (System.Int32)] = v339[v199 @ X22_v8 (System.Int32)];\n\tv340 = this.solver;\n\tv92 = v384.emissionColors;\n\tv153 = v346 << 4;\n\tv385 = v340.emissionColors + v153;\n\t// 338 MakeStruct v84 @ AGGFF1AD0_0_v5 (Unity.Mathematics.float4), typeof(Unity.Mathematics.float4), [v385 @ X8_v33], [v385 @ X8_v33+4], [v385 @ X8_v33+8], [v385 @ X8_v33+C]\n\tv180 = Unity.Mathematics.float4::op_Implicit(v84);\n\tv418 = v349 << 4;\n\tv674 = v384.emissionColors + v418;\n\t*([v674 @ X8_v35+20]) = v180;\n\tv92[v349 @ X0_v20 (System.Int32)].y = v180.y;\n\tv92[v349 @ X0_v20 (System.Int32)].z = v180.z;\n\tv92[v349 @ X0_v20 (System.Int32)].w = v180.w;\n\tv419 = v199 + 1;\n\tv203 = v203 + 8;\n\tv421 = v419 < this.activeCount;\n\tif (v421) goto L_0066;\nL_017A:\n\tFluidRendererBase::OnPreComputeUpdate(this);\n\tv387 = this.solver;\n\tv500 = \"Hungarian\";\n\tgoto L_0194;\nL_018B:\n\tgoto L_018E;\nL_018E:\n\tUnityEngine.Debug::Log(*([v500 @ X22_v4 (System.String)+238]));\n\tv387 = this.solver;\nL_0190:\n\tv584 = v584 + 8;\nL_0194:\n\tv573 = v573 + 1;\n\tv540 = v573 >= v387.<ActiveCount>k__BackingField;\n\tif (v540) goto L_01CC;\n\tv587 = v387.positions;\n\tv163 = *([v587 @ X9_v7 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v584 @ X20_v6 (System.Int32)]) & 0x7FFFFFFF;\n\tv589 = v163 < 0x7F800000;\n\tv590 = ~v589;\n\tv591 = v163 - 0x7F800000;\n\tv593 = v591 == 0;\n\tv598 = ~v593;\n\tv210 = v590 & v598;\n\tif (v210) goto L_018B;\n\tv601 = v587 + v584;\n\tv603 = *([v601 @ X9_v9+4]) & 0x7FFFFFFF;\n\tv604 = v603 < 0x7F800001;\n\tv605 = ~v604;\n\tif (v605) goto L_018B;\n\tgoto L_0190;\n\tv626 = \"il2cpp_codegen_runtime_class_init\"(v622, v523, v135, v38, v39, v40, v41, v42, v181, v189, v109, v89, v47, v48, v49, v50);\n\tgoto L_018E;\nL_01CC:\n\treturn;\n\tv394 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 337 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		//IL_0090: Expected O, but got F4
		//IL_009d: Expected O, but got F4
		//IL_0124: Expected O, but got I
		//IL_055c: Expected O, but got I
		//IL_0625: Unknown result type (might be due to invalid IL or missing references)
		//IL_062a: Expected O, but got Unknown
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_016b: Expected F4, but got O
		//IL_0180: Expected F4, but got I
		//IL_01a2: Expected O, but got I
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0273: Expected O, but got Unknown
		//IL_0280: Expected F4, but got O
		//IL_0295: Expected F4, but got I
		//IL_02c5: Expected O, but got I
		//IL_0322: Expected O, but got I
		//IL_0354: Expected O, but got I
		//IL_0375: Expected O, but got I
		//IL_03f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_03fa: Expected O, but got Unknown
		//IL_0407: Expected F4, but got O
		//IL_041c: Expected F4, but got I
		//IL_0431: Expected F4, but got I
		//IL_0446: Expected F4, but got I
		//IL_0479: Expected O, but got I
		float time = global::UnityEngine.Time.time;
		FluidSolver fluidSolver = solver;
		if (activeCount >= 1)
		{
			nint num = 0;
			float num2 = time - fluidSolver.lastStepWallTime;
			float num3 = num2 / fixedDeltaTime;
			float num4 = num3 - 1f;
			bool flag = num4 < 0f;
			bool flag2 = num4 == 0f;
			object obj = num3 ^ 1f;
			object obj2 = num3 ^ num4;
			int num5 = (int)((nint)obj & (nint)obj2);
			bool flag3 = num5 < 0;
			bool flag4 = flag == flag3;
			bool flag5 = !flag2;
			if (flag4 && flag5)
			{
			}
			if (num3 < 0f)
			{
			}
			int num6 = 0;
			int num7 = 0;
			object obj4 = default(object);
			global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			object obj9 = default(object);
			global::Unity.Mathematics.float4 float7 = default(global::Unity.Mathematics.float4);
			bool flag6;
			do
			{
				int[] array = particleIds;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E75E4 (Unity.Collections.NativeHashMap`2::get_Item, and 1 more at this address)");
				FluidSolver fluidSolver2 = solver;
				int num8 = (int)((nint)obj4 << 3);
				object obj5 = fluidSolver2.positions + num8;
				float5.x = (float)obj5;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v379 @ X8_v17+4]");
				float5.y = 0f;
				global::UnityEngine.Vector2 vector = float5;
				object obj6 = (nint)positions + num7;
				_ = vector.y;
				FluidSolver fluidSolver3 = solver;
				float[] array2 = scales;
				global::Unity.Collections.NativeArray<float> nativeArray = fluidSolver3.scales;
				float num9 = particleSize;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v641 @ X8_v21 (Unity.Collections.NativeArray`1<System.Single>)+v346 @ X0_v17*4]");
				float num10 = num9 * 0f;
				array2[num6] = num10;
				int[] array3 = particleIds;
				FluidCompute fluidCompute = compute;
				int num11 = fluidCompute.idToIndex[array3[num6]];
				FluidSolver fluidSolver4 = solver;
				int num12 = (int)((nint)obj4 << 3);
				object obj7 = fluidSolver4.positionsPrev + num12;
				float6.x = (float)obj7;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v646 @ X8_v27+4]");
				float6.y = 0f;
				global::UnityEngine.Vector2 vector2 = float6;
				int num13 = num6 << 3;
				object obj8 = (nint)positions + num13;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v652 @ X8_v29+20]");
				float num14 = 0f - vector2.x;
				float num15 = num14 * (float)obj9;
				float num16 = vector2.x + num15;
				int num17 = num6 << 3;
				object obj10 = (nint)interpPositions + num17;
				FluidCompute fluidCompute2 = compute;
				int num18 = num6 << 3;
				object obj11 = (nint)interpPositions + num18;
				int num19 = num11 << 3;
				object obj12 = (nint)fluidCompute2.positions + num19;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v661 @ X9_v21+20]");
				_ = 0;
				float[] array4 = scales;
				float[] array5 = fluidCompute2.scales;
				array5[num11] = array4[num6];
				FluidSolver fluidSolver5 = solver;
				global::UnityEngine.Vector4[] emissionColors = fluidCompute2.emissionColors;
				int num20 = (int)((nint)obj4 << 4);
				object obj13 = fluidSolver5.emissionColors + num20;
				float7.x = (float)obj13;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v33+4]");
				float7.y = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v33+8]");
				float7.z = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v385 @ X8_v33+C]");
				float7.w = 0f;
				global::UnityEngine.Vector4 vector3 = float7;
				int num21 = num11 << 4;
				object obj14 = (nint)fluidCompute2.emissionColors + num21;
				emissionColors[num11].y = vector3.y;
				emissionColors[num11].z = vector3.z;
				emissionColors[num11].w = vector3.w;
				int num22 = num6 + 1;
				num7 += 8;
				flag6 = num22 < activeCount;
				num6 = num22;
			}
			while (flag6);
		}
		base.OnPreComputeUpdate();
		FluidSolver fluidSolver6 = solver;
		string text = "Hungarian";
		int num23 = -1;
		int num24 = 0;
		while (true)
		{
			num23++;
			if (num23 >= fluidSolver6.ActiveCount)
			{
				break;
			}
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray2 = fluidSolver6.positions;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v587 @ X9_v7 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v584 @ X20_v6 (System.Int32)]");
			int num25 = (int)((nint)0 & (nint)int.MaxValue);
			bool flag7 = num25 < 2139095040;
			bool flag8 = !flag7;
			int num26 = num25 - 2139095040;
			bool flag9 = num26 == 0;
			bool flag10 = !flag9;
			if (!(flag8 && flag10))
			{
				object obj15 = nativeArray2 + num24;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v601 @ X9_v9+4]");
				int num27 = (int)((nint)0 & (nint)int.MaxValue);
				if (num27 < 2139095041)
				{
					goto IL_06bf;
				}
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X22_v4 (System.String)+238]");
			global::UnityEngine.Debug.Log(0);
			fluidSolver6 = solver;
			goto IL_06bf;
			IL_06bf:
			num24 += 8;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF1E60", Offset = "0xFF1E60", Length = "0x20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.particleSize = 0.2f;\n\tthis.particleBoundsRadius = 0.4f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 5 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FluidDisplay()
	{
		particleSize = 0.2f;
		particleBoundsRadius = 0.4f;
	}
}
