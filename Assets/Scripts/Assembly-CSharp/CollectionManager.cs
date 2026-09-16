[global::Cpp2ILInjected.Token(Token = "0x2000048")]
public class CollectionManager : Singleton<CollectionManager>
{
	[global::Cpp2ILInjected.Token(Token = "0x4000112")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x4000113")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private Level level;

	[global::Cpp2ILInjected.Token(Token = "0x4000114")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public FluidCompute lowResCompute;

	[global::Cpp2ILInjected.Token(Token = "0x4000115")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public FluidCollectDisplay colorDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x4000116")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public FluidCollectDisplay mudDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x4000117")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public FluidCollectDisplay honeyDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x4000118")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public FluidCollectDisplay snowDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x4000119")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public SpriteCollectDisplay spriteDisplay;

	[global::Cpp2ILInjected.Token(Token = "0x6000192")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEB024", Offset = "0xFEB024", Length = "0x140")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv268 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> + 0xA48;\n\tv24 = *([302A983]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0059;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv269 = *([v28 @ X0_v35+E0]);\n\tv30 = *([v28 @ X0_v35+E0]) == 0;\n\tif (v30) goto L_0063;\nL_0019:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v124 @ X21_v12]));\nL_001D:\n\tv182 = CollectParticleData[];\n\tv183 = Il2CppMethodInfo;\n\tv268 = v175 + 0x90;\n\tv185 = new *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v185, this, *([v183 @ X24_v8 (Il2CppMethodInfo)+330]));\n\tv232 = System.Delegate::Combine(*([v268 @ X20_v3]), v185);\n\tv79 = v232 == 0;\n\tif (v79) goto L_0068;\n\tv32 = *([v232 @ X0_v29 (System.Delegate)]) != *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v32) goto L_FFFFFFFF;\n\t*([v268 @ X20_v3]) = v232;\n\tv251 = *([v232 @ X0_v29 (System.Delegate)]) == *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v251) goto L_0074;\n\tthrow System.InvalidCastException;\nL_0059:\n\t*([v84 @ X21_v7 (System.Delegate)+983]) = 1;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv118 = *([v268 @ X20_v3]);\n\tv269 = *([v118 @ X0_v24+E0]);\n\tv239 = *([v118 @ X0_v24+E0]) == 0;\n\tv120 = ~v239;\n\tif (v120) goto L_0019;\nL_0063:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v148 @ X21_v6]));\n\tv208 = v175 == 0;\n\tv177 = ~v208;\n\tif (v177) goto L_001D;\n\tthrow System.NullReferenceException;\nL_0068:\n\t*([v268 @ X20_v3]) = 0;\nL_0074:\n\tv281 = 0xF3F1B4(v268, v269, v262, v260, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100);\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_000e: Expected I, but got O
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Expected O, but got Unknown
		//IL_0050: Expected O, but got I4
		//IL_01e4: Expected O, but got I
		//IL_01fc: Expected O, but got I
		//IL_006a: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_008a: Expected O, but got I
		//IL_00d4: Expected I, but got O
		//IL_00e9: Expected O, but got I
		//IL_012e: Expected O, but got I4
		//IL_0137: Expected O, but got I4
		//IL_027a: Expected O, but got I4
		//IL_01c3: Expected O, but got I4
		//IL_01cc: Expected O, but got I4
		//IL_019b: Expected O, but got I4
		//IL_01a4: Expected O, but got I4
		nint num = 0;
		object obj = typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>) + 2632;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A983]");
		int num2 = (int)((nint)0 & (nint)1);
		bool flag = num2 == 0;
		global::System.Delegate obj2 = (global::System.Delegate)50503680;
		global::System.Delegate obj5;
		if (!flag)
		{
			object obj3 = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X0_v35+E0]");
			obj5 = (global::System.Delegate)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v28 @ X0_v35+E0]");
			bool flag2 = (nint)0 == 0;
			object obj6 = obj3;
			if (!flag2)
			{
				goto IL_00b7;
			}
		}
		else
		{
			_ = 1;
			object obj3 = (nint)0 + (nint)3216;
			object obj7 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v24+E0]");
			obj5 = (global::System.Delegate)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v118 @ X0_v24+E0]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			object obj6 = obj3;
			if (flag4)
			{
				goto IL_00b7;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj8 = default(object);
		if (obj8 == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_00c6;
		IL_00c6:
		nint num3 = 0;
		nint num4 = 0;
		obj = (nint)obj8 + 144;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X24_v8 (Il2CppMethodInfo)+330]");
		global::System.Action b = null;
		global::System.Delegate obj9 = global::System.Delegate.Combine((global::System.Delegate)obj, b);
		bool flag5 = (object)obj9 == null;
		object obj10 = 0;
		object obj11 = 0;
		obj5 = obj9;
		if (!flag5)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]");
			if ((object)obj9 == null)
			{
				obj = obj9;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]");
				bool flag6 = (object)obj9 == null;
				obj10 = 0;
				obj11 = 0;
				obj5 = obj9;
				if (flag6)
				{
					goto IL_027f;
				}
			}
			obj10 = 0;
			obj11 = 0;
			throw new global::System.InvalidCastException();
		}
		obj = 0;
		goto IL_027f;
		IL_00b7:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		goto IL_00c6;
		IL_027f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000193")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEB164", Offset = "0xFEB164", Length = "0x3D4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv28 = *([302A984]) & 1;\n\tv29 = v28 == 0;\n\tif (v29) goto L_0033;\n\tv79 = Il2CppMethodInfo + 0xC90;\n\tv32 = *([v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv34 = *([v32 @ X0_v93+E0]) == 0;\n\tif (v34) goto L_003D;\nL_001B:\n\tv78 = Singleton`1::get_Instance /* +1 sharing this address */(*([v79 @ X24_v4]));\n\tv71 = v78 == 0;\n\tv72 = ~v71;\n\tif (v72) goto L_0042;\n\tgoto L_0128;\nL_0033:\n\t*([302A984]) = 1;\n\tv79 = Il2CppMethodInfo + 0xC90;\n\tv54 = *([v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv274 = *([v54 @ X0_v89+E0]) == 0;\n\tv58 = ~v274;\n\tif (v58) goto L_001B;\nL_003D:\n\tv78 = Singleton`1::get_Instance /* +1 sharing this address */(*([v64 @ X24_v6]));\nL_0042:\n\tv85 = this + 0x28;\n\tthis.solver = *([v78 @ X0_v9+30]);\n\tv87 = 0xF3F1B4(v85, *([v78 @ X0_v9+30]), v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv143 = Singleton`1::get_Instance /* +1 sharing this address */(*([v79 @ X24_v4]));\n\tv210 = this + 0x30;\n\tthis.level = *([v143 @ X0_v13+78]);\n\tv144 = 0xF3F1B4(v210, *([v143 @ X0_v13+78]), v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv197 = this.solver;\n\tv305 = System.Collections.Generic.NullableComparer`1;\n\tv306 = Il2CppMethodInfo;\n\tv211 = this.solver + 0x260;\n\tv308 = new *([v305 @ X25_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8])();\n\tSystem.Action`2<System.Object, System.Boolean>::.ctor(v308, this, *([v306 @ X26_v4 (Il2CppMethodInfo)+340]));\n\tv313 = System.Delegate::Combine(v197.OnStartRemoveParticles, v308);\n\tv314 = v313 == 0;\n\tif (v314) goto L_007C;\n\tv231 = 0xF3F36C(v313, *([v305 @ X25_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv235 = v231 == 0;\n\tif (v235) goto L_012B;\n\tv197.OnStartRemoveParticles = v231;\n\tv232 = 0xF3F36C(v313, *([v305 @ X25_v4 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DB8]), 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv236 = v232 == 0;\n\tif (v236) goto L_012B;\n\tv145 = 0xF3F1B4(v211, v232, 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv265 = this.solver;\n\tv333 = this.solver == 0;\n\tv168 = ~v333;\n\tif (v168) goto L_0082;\n\tgoto L_0128;\nL_007C:\n\tv197.OnStartRemoveParticles = 0;\n\tv146 = 0xF3F1B4(v211, 0, 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv265 = this.solver;\nL_0082:\n\tv323 = System.Collections.Generic.NullableComparer`1;\n\tv324 = Il2CppMethodInfo;\n\tv191 = v265 + 0x268;\n\tv326 = new *([v323 @ X23_v6 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DC8])();\n\tSystem.Action`2<System.Object, UnityEngine.Vector2>::.ctor(v326, this, *([v324 @ X25_v6 (Il2CppMethodInfo)+338]));\n\tv332 = System.Delegate::Combine(v265.OnCreatePowerup, v326);\n\tv334 = v332 == 0;\n\tif (v334) goto L_00AB;\n\tv257 = 0xF3F36C(v332, *([v323 @ X23_v6 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DC8]), 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv261 = v257 == 0;\n\tif (v261) goto L_012E;\n\tv265.OnCreatePowerup = v257;\n\tv258 = 0xF3F36C(v332, *([v323 @ X23_v6 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+DC8]), 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv262 = v258 == 0;\n\tif (v262) goto L_012E;\n\tv147 = 0xF3F1B4(v191, v258, 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv202 = this.colorDisplay;\n\tv343 = this.colorDisplay == 0;\n\tv170 = ~v343;\n\tif (v170) goto L_00B3;\n\tgoto L_0128;\nL_00AB:\n\tv265.OnCreatePowerup = 0;\n\tv148 = 0xF3F1B4(v191, 0, 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv202 = this.colorDisplay;\nL_00B3:\n\tv149 = Singleton`1::get_Instance /* +1 sharing this address */(*([v79 @ X24_v4]));\n\tv150 = CollectionManager::CloneMaterialLowRes(this, *([v149 @ X0_v27+140]));\n\tUnityEngine.Renderer::set_material(v202.mr, v150);\n\tv152 = FluidCollectDisplay::Init(this.colorDisplay);\n\tv203 = this.solver;\n\tv94 = this.mudDisplay;\n\tv94.fluidType = v203.mudFluidType;\n\tv153 = Singleton`1::get_Instance /* +1 sharing this address */(*([v79 @ X24_v4]));\n\tv154 = CollectionManager::CloneMaterialLowRes(this, *([v153 @ X0_v34+128]));\n\tUnityEngine.Renderer::set_material(v94.mr, v154);\n\tv156 = FluidCollectDisplay::Init(this.mudDisplay);\n\tv205 = this.solver;\n\tv96 = this.honeyDisplay;\n\tv96.fluidType = v205.honeyFluidType;\n\tv157 = Singleton`1::get_Instance /* +1 sharing this address */(*([v79 @ X24_v4]));\n\tv158 = CollectionManager::CloneMaterialLowRes(this, *([v157 @ X0_v41+130]));\n\tUnityEngine.Renderer::set_material(v96.mr, v158);\n\tv160 = FluidCollectDisplay::Init(this.honeyDisplay);\n\tv207 = this.solver;\n\tv98 = this.snowDisplay;\n\tv98.fluidType = v207.snowFluidType;\n\tv161 = Singleton`1::get_Instance /* +1 sharing this address */(*([v79 @ X24_v4]));\n\tv162 = CollectionManager::CloneMaterialLowRes(this, *([v161 @ X0_v48+138]));\n\tUnityEngine.Renderer::set_material(v98.mr, v162);\n\tv163 = this.snowDisplay;\n\tv298 = *([v163 @ X0_v52 (FluidCollectDisplay)]);\n\tv280 = *([v298 @ X8_v18 (Il2CppClass<FluidCollectDisplay>)+178]);\n\tv290 = *([v298 @ X8_v18 (Il2CppClass<FluidCollectDisplay>)+180]);\n\t// 295 IndirectJump v280 @ X2_v12, v163 @ X0_v52 (FluidCollectDisplay), v163 @ X0_v52 (FluidCollectDisplay), v290 @ X1_v25, v280 @ X2_v12, 0, v41 @ X4, v42 @ X5, v43 @ X6, v44 @ X7, v45 @ V0, v46 @ V1, v47 @ V2, v48 @ V3, v49 @ V4, v50 @ V5, v51 @ V6, v52 @ V7\nL_0128:\n\tthrow System.NullReferenceException;\nL_012B:\n\tthrow System.InvalidCastException;\nL_012E:\n\tthrow System.InvalidCastException;\n// 196 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Init()
	{
		//IL_000e: Expected I, but got O
		//IL_00d3: Expected O, but got I
		//IL_00e3: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_005d: Expected O, but got I
		//IL_0143: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_017a: Expected O, but got I
		//IL_018c: Expected O, but got I
		//IL_01b3: Expected I, but got O
		//IL_01ca: Expected O, but got I
		//IL_02e8: Expected I, but got O
		//IL_02fd: Expected O, but got I
		//IL_042e: Expected O, but got I
		//IL_04aa: Expected O, but got I
		//IL_0526: Expected O, but got I
		//IL_05a2: Expected O, but got I
		//IL_05d4: Expected I, but got O
		//IL_05e4: Expected O, but got I
		//IL_05f4: Expected O, but got I
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A984]");
		object obj3;
		object obj;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			obj = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X0_v93+E0]");
			bool flag = (nint)0 == 0;
			obj3 = obj;
			if (!flag)
			{
				goto IL_008a;
			}
		}
		else
		{
			_ = 1;
			obj = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v89+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			obj3 = obj;
			if (flag3)
			{
				goto IL_008a;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		obj = obj3;
		goto IL_0137;
		IL_05fe:
		throw new global::System.NullReferenceException();
		IL_02da:
		nint num2 = 0;
		nint num3 = 0;
		FluidSolver fluidSolver;
		object obj5 = (nint)fluidSolver + 616;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v324 @ X25_v6 (Il2CppMethodInfo)+338]");
		global::System.Delegate b = null;
		global::System.Delegate obj6 = global::System.Delegate.Combine(fluidSolver.OnCreatePowerup, b);
		FluidCollectDisplay fluidCollectDisplay;
		if ((object)obj6 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<global::System.Collections.Generic.HashSet<int>, global::UnityEngine.Vector2> action = default(global::System.Action<global::System.Collections.Generic.HashSet<int>, global::UnityEngine.Vector2>);
			if (action != null)
			{
				fluidSolver.OnCreatePowerup = action;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				object obj7 = default(object);
				if (obj7 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					fluidCollectDisplay = colorDisplay;
					if ((object)colorDisplay != null)
					{
						goto IL_040d;
					}
					goto IL_05fe;
				}
			}
			throw new global::System.InvalidCastException();
		}
		fluidSolver.OnCreatePowerup = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		fluidCollectDisplay = colorDisplay;
		goto IL_040d;
		IL_040d:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v149 @ X0_v27+140]");
		global::UnityEngine.Material material = CloneMaterialLowRes((global::UnityEngine.Material)0);
		fluidCollectDisplay.mr.material = material;
		colorDisplay.Init();
		FluidSolver fluidSolver2 = solver;
		FluidCollectDisplay fluidCollectDisplay2 = mudDisplay;
		fluidCollectDisplay2.fluidType = fluidSolver2.mudFluidType;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X0_v34+128]");
		global::UnityEngine.Material material2 = CloneMaterialLowRes((global::UnityEngine.Material)0);
		fluidCollectDisplay2.mr.material = material2;
		mudDisplay.Init();
		FluidSolver fluidSolver3 = solver;
		FluidCollectDisplay fluidCollectDisplay3 = honeyDisplay;
		fluidCollectDisplay3.fluidType = fluidSolver3.honeyFluidType;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X0_v41+130]");
		global::UnityEngine.Material material3 = CloneMaterialLowRes((global::UnityEngine.Material)0);
		fluidCollectDisplay3.mr.material = material3;
		honeyDisplay.Init();
		FluidSolver fluidSolver4 = solver;
		FluidCollectDisplay fluidCollectDisplay4 = snowDisplay;
		fluidCollectDisplay4.fluidType = fluidSolver4.snowFluidType;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v161 @ X0_v48+138]");
		global::UnityEngine.Material material4 = CloneMaterialLowRes((global::UnityEngine.Material)0);
		fluidCollectDisplay4.mr.material = material4;
		FluidCollectDisplay fluidCollectDisplay5 = snowDisplay;
		nint num4 = (nint)fluidCollectDisplay5;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v18 (Il2CppClass<FluidCollectDisplay>)+178]");
		object obj8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v298 @ X8_v18 (Il2CppClass<FluidCollectDisplay>)+180]");
		object obj9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v280 @ X2_v12 (should have been resolved before IL gen)");
		goto IL_05fe;
		IL_008a:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj10 = default(object);
		if (obj10 != null)
		{
			goto IL_0137;
		}
		goto IL_05fe;
		IL_0137:
		object obj11 = (nint)this + 40;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v9+30]");
		solver = (FluidSolver)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj12 = (nint)this + 48;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X0_v13+78]");
		level = (Level)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		FluidSolver fluidSolver5 = solver;
		nint num5 = 0;
		nint num6 = 0;
		object obj13 = (nint)solver + 608;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X26_v4 (Il2CppMethodInfo)+340]");
		global::System.Delegate b2 = null;
		global::System.Delegate obj14 = global::System.Delegate.Combine(fluidSolver5.OnStartRemoveParticles, b2);
		if ((object)obj14 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			global::System.Action<global::System.Collections.Generic.HashSet<int>, bool> action2 = default(global::System.Action<global::System.Collections.Generic.HashSet<int>, bool>);
			if (action2 != null)
			{
				fluidSolver5.OnStartRemoveParticles = action2;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				object obj15 = default(object);
				if (obj15 != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					fluidSolver = solver;
					if ((object)solver != null)
					{
						goto IL_02da;
					}
					goto IL_05fe;
				}
			}
			throw new global::System.InvalidCastException();
		}
		fluidSolver5.OnStartRemoveParticles = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		fluidSolver = solver;
		goto IL_02da;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000194")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEB538", Offset = "0xFEB538", Length = "0x104")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0021;\n\tv25 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv26 = v25 + 0x8F0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, mat, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv48 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv49 = v48 + 0x9D8;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v49, mat, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv54 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv55 = v54 + 0x958;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, mat, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv59 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv60 = v59 + 0xB40;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, mat, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv45 = 1;\n\t*([302A985]) = v45;\nL_0021:\n\tv47 = new *([v20 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+8F0])();\n\tUnityEngine.Material::.ctor(v47, mat);\n\tv57 = this.lowResCompute;\n\tv85 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.Material::SetTexture(v47, *([v85 @ X9_v2 (System.String)+958]), v57.emissionRT);\n\tv82 = this.lowResCompute;\n\tv110 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.Material::SetTexture(v47, *([v110 @ X9_v4 (System.String)+9D8]), v82.fluidRT);\n\tv83 = this.lowResCompute;\n\tv111 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.Material::SetTexture(v47, *([v111 @ X9_v6 (System.String)+B40]), v83.rawFieldRT);\n\treturn v47;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 51 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public global::UnityEngine.Material CloneMaterialLowRes(global::UnityEngine.Material mat)
	{
		//IL_000e: Expected I, but got O
		//IL_003a: Expected O, but got I
		//IL_0070: Expected O, but got I
		//IL_00a6: Expected O, but got I
		nint num = 0;
		global::UnityEngine.Material material = new global::UnityEngine.Material(mat);
		FluidCompute fluidCompute = lowResCompute;
		string text = "Writing object reference to Id '{0}' for {1}.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X9_v2 (System.String)+958]");
		material.SetTexture((string)0, fluidCompute.emissionRT);
		FluidCompute fluidCompute2 = lowResCompute;
		string text2 = "Writing object reference to Id '{0}' for {1}.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v110 @ X9_v4 (System.String)+9D8]");
		material.SetTexture((string)0, fluidCompute2.fluidRT);
		FluidCompute fluidCompute3 = lowResCompute;
		string text3 = "Writing object reference to Id '{0}' for {1}.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X9_v6 (System.String)+B40]");
		material.SetTexture((string)0, fluidCompute3.rawFieldRT);
		return material;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000195")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEB63C", Offset = "0xFEB63C", Length = "0x304")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv363 = v214.y;\n\tv44 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_003B;\n\tv49 = Il2CppMethodInfo;\n\tv50 = v49 + 0x968;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, ids, methodInfo, v53, v54, v55, v56, v57, targetPos, v0, v58, v59, v60, v61, v62, v63);\n\tv71 = Il2CppMethodInfo;\n\tv72 = v71 + 0x970;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, ids, methodInfo, v53, v54, v55, v56, v57, targetPos, v0, v58, v59, v60, v61, v62, v63);\n\tv76 = Il2CppMethodInfo;\n\tv77 = v76 + 0x978;\n\tv78 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, ids, methodInfo, v53, v54, v55, v56, v57, targetPos, v0, v58, v59, v60, v61, v62, v63);\n\tv80 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv81 = v80 + 8;\n\tv82 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, ids, methodInfo, v53, v54, v55, v56, v57, targetPos, v0, v58, v59, v60, v61, v62, v63);\n\tv246 = Il2CppMethodInfo;\n\tv247 = v246 + 0x998;\n\tv248 = \"il2cpp_codegen_initialize_runtime_metadata\"(v247, ids, methodInfo, v53, v54, v55, v56, v57, targetPos, v0, v58, v59, v60, v61, v62, v63);\n\tv260 = Il2CppMethodInfo;\n\tv261 = v260 + 0xC28;\n\tv262 = \"il2cpp_codegen_initialize_runtime_metadata\"(v261, ids, methodInfo, v53, v54, v55, v56, v57, targetPos, v0, v58, v59, v60, v61, v62, v63);\n\tv277 = Il2CppMethodInfo;\n\tv278 = v277 + 0x50;\n\tv279 = \"il2cpp_codegen_initialize_runtime_metadata\"(v278, ids, methodInfo, v53, v54, v55, v56, v57, targetPos, v0, v58, v59, v60, v61, v62, v63);\n\tv385 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv386 = v385 + 0x1F0;\n\tv65 = \"il2cpp_codegen_initialize_runtime_metadata\"(v386, ids, methodInfo, v53, v54, v55, v56, v57, targetPos, v0, v58, v59, v60, v61, v62, v63);\n\tv67 = 1;\n\t*([302A986]) = v67;\nL_003B:\n\tv70 = new *([v44 @ X20_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+1F0])();\n\tSystem.Object::.ctor(v70);\n\tv79 = v70 == 0;\n\tif (v79) goto L_00E6;\n\t*([v70 @ X0_v3 (System.Object)+10]) = v214;\n\t*([v70 @ X0_v3 (System.Object)+14]) = v214.y;\n\tv83 = ids == 0;\n\tif (v83) goto L_00E6;\n\tv251 = Il2CppMethodInfo;\n\tv252 = Il2CppMethodInfo;\n\tv253 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv254 = Il2CppMethodInfo;\n\tv259 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(ids);\n\tv238 = v70 + 0x18;\nL_005B:\n\t;\n\tv368 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v257 @ stack_-D0_v3 (UnityEngine.Vector2), *([v251 @ X26_v4 (Il2CppMethodInfo)+970]));\n\tv387 = v368 & 1;\n\tv388 = v387 == 0;\n\tif (v388) goto L_00C9;\n\tv393 = this.solver == 0;\n\tif (v393) goto L_00E0;\n\tv401 = this.solver + 0x1F8;\n\tv334 = *([v252 @ X27_v4 (Il2CppMethodInfo)+C28]);\n\tv347 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v401, v125, &v329 @ stack_-F4_v6, *([v252 @ X27_v4 (Il2CppMethodInfo)+C28]));\n\tv482 = v347 & 1;\n\tv351 = v482 == 0;\n\tif (v351) goto L_005B;\n\tv550 = this.solver;\n\tv551 = this.solver == 0;\n\tif (v551) goto L_00E2;\n\tv557 = v550.particleTypes;\n\tv552 = v329 << 3;\n\tv325 = v550.positions + v552;\n\tv555 = v550.velocities + v552;\n\tv319 = this.colorDisplay;\n\t// 125 MakeStruct v317 @ AGGFEB7D0_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v325 @ X10_v7], [v325 @ X10_v7+4]\n\tv565 = Unity.Mathematics.float2::op_Implicit(v317);\n\t// 133 MakeStruct v315 @ AGGFEB7E8_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v555 @ X8_v20], [v555 @ X8_v20+4]\n\tv215 = Unity.Mathematics.float2::op_Implicit(v315);\n\tv244 = v215.y;\n\tv313 = *([v70 @ X0_v3 (System.Object)+18]);\n\tv571 = *([v70 @ X0_v3 (System.Object)+18]) == 0;\n\tv572 = ~v571;\n\tif (v572) goto L_00A6;\n\tv574 = new *([v253 @ X28_v4 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+8])();\n\tv199 = *([v254 @ X25_v4 (Il2CppMethodInfo)+50]);\n\tSystem.Func`1<UnityEngine.Vector2>::.ctor(v574, v70, *([v254 @ X25_v4 (Il2CppMethodInfo)+50]));\n\t*([v70 @ X0_v3 (System.Object)+18]) = v574;\n\tv579 = 0xF3F1B4(v238, v574, *([v254 @ X25_v4 (Il2CppMethodInfo)+50]), 0, 0, v55, v56, v57, v215, v215.y, v215, v215.y, 0, v61, v62, v63);\nL_00A6:\n\tv303 = v319.activeCount >= v319.maxParticles;\n\tif (v303) goto L_005B;\n\tv349 = FluidCollectDisplay::AddParticle(v319, v565, v215, *([v557 @ X10_v5 (Unity.Collections.NativeArray`1<System.Int32>)+v329 @ stack_-F4_v6*4]), 2, 0f, v313, 0);\n\tgoto L_005B;\nL_00C9:\n\tv394 = Il2CppMethodInfo;\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v257 @ stack_-D0_v3 (UnityEngine.Vector2), *([v394 @ X8_v14 (Il2CppMethodInfo)+968]));\nL_00DF:\n\treturn;\nL_00E0:\n\tv402 = new System.NullReferenceException();\n\tgoto L_00E5;\nL_00E2:\n\tv554 = new System.NullReferenceException();\n\tgoto L_00E5;\n\tv553 = new System.NullReferenceException();\nL_00E5:\n\t// 229 Interrupt\nL_00E6:\n\tv245 = new System.NullReferenceException();\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\n\tgoto L_00FA;\nL_00FA:\n\tv276 = v373 != 1;\n\tif (v276) goto L_010C;\n\tv370 = 0x274A080(v245, v373, v199, v334, 0, v55, v56, v57, v215, v363, v215, v244, 0, v61, v62, v63);\n\tv390 = 0x274A098(v370, v373, v199, v334, 0, v55, v56, v57, v215, v363, v215, v244, 0, v61, v62, v63);\n\tv399 = Il2CppMethodInfo;\n\tv373 = *([v399 @ X8_v5 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v257 @ stack_-D0_v3 (UnityEngine.Vector2), *([v399 @ X8_v5 (Il2CppMethodInfo)+968]));\n\tv378 = *([v370 @ X0_v13]) == 0;\n\tif (v378) goto L_00DF;\n\tv376 = new System.OutOfMemoryException();\nL_010C:\n\tv384 = 0xBF092C(&v207 @ stack_-108 (System.Int32), v373, v199, v334, 0, v55, v56, v57, v215, v363, v215, v244, 0, v61, v62, v63);\n\tv392 = 0x27498DC(v381, v373, v199, v334, 0, v55, v56, v57, v215, v363, v215, v244, 0, v61, v62, v63);\n\tv400 = 0xD6F8(v392, v373, v199, v334, 0, v55, v56, v57, v215, v363, v215, v244, 0, v61, v62, v63);\n\treturn;\n// 158 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void OnCreatePowerup(global::System.Collections.Generic.HashSet<int> ids, global::UnityEngine.Vector2 targetPos)
	{
		//IL_001b: Expected I, but got O
		//IL_006c: Expected I, but got O
		//IL_008e: Expected O, but got I
		//IL_042e: Expected O, but got I
		//IL_0466: Expected I4, but got O
		//IL_00cb: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_038b: Expected O, but got I
		//IL_03a3: Expected O, but got I
		//IL_0164: Unknown result type (might be due to invalid IL or missing references)
		//IL_0169: Expected O, but got Unknown
		//IL_0178: Unknown result type (might be due to invalid IL or missing references)
		//IL_017d: Expected O, but got Unknown
		//IL_0196: Expected F4, but got O
		//IL_01ab: Expected F4, but got I
		//IL_01c5: Expected F4, but got O
		//IL_01da: Expected F4, but got I
		//IL_0209: Expected O, but got I
		//IL_0243: Expected O, but got I
		global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
		float num = vector.y;
		nint num2 = 0;
		object obj = new object();
		bool flag = obj == null;
		global::System.Func<global::UnityEngine.Vector2> func = null;
		if (!flag)
		{
			_ = vector.y;
			bool flag2 = ids == null;
			func = null;
			if (!flag2)
			{
				nint num3 = 0;
				nint num4 = 0;
				nint num5 = 0;
				nint num6 = 0;
				global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = ids.GetEnumerator();
				object obj2 = (nint)obj + 24;
				global::UnityEngine.Vector2 vector3 = default(global::UnityEngine.Vector2);
				global::UnityEngine.Vector2 vector2 = vector3;
				object obj3 = default(object);
				object obj5 = default(object);
				object obj6 = default(object);
				global::System.Func<global::UnityEngine.Vector2> func3 = default(global::System.Func<global::UnityEngine.Vector2>);
				global::System.Func<global::UnityEngine.Vector2> func4 = default(global::System.Func<global::UnityEngine.Vector2>);
				float num8 = default(float);
				global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
				global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
				global::System.Func<global::UnityEngine.Vector2> func6 = default(global::System.Func<global::UnityEngine.Vector2>);
				global::System.Func<global::UnityEngine.Vector2> func2;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
					if ((int)((nint)obj3 & 1) != 0)
					{
						if ((object)solver != null)
						{
							object obj4 = (nint)solver + 504;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X27_v4 (Il2CppMethodInfo)+C28]");
							func2 = (global::System.Func<global::UnityEngine.Vector2>)0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
							if ((int)((nint)obj5 & 1) != 0)
							{
								FluidSolver fluidSolver = solver;
								global::UnityEngine.Vector2 vector4;
								nint num7;
								if ((object)solver == null)
								{
									global::System.NullReferenceException ex = new global::System.NullReferenceException();
									num7 = (nint)(&obj6);
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X27_v4 (Il2CppMethodInfo)+C28]");
									func3 = (global::System.Func<global::UnityEngine.Vector2>)0;
									vector4 = vector2;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v251 @ X26_v4 (Il2CppMethodInfo)+970]");
									func4 = (global::System.Func<global::UnityEngine.Vector2>)0;
									num8 = num;
									break;
								}
								global::Unity.Collections.NativeArray<int> particleTypes = fluidSolver.particleTypes;
								int num9 = (int)((nint)obj6 << 3);
								object obj7 = fluidSolver.positions + num9;
								object obj8 = fluidSolver.velocities + num9;
								FluidCollectDisplay fluidCollectDisplay = colorDisplay;
								float5.x = (float)obj7;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v325 @ X10_v7+4]");
								float5.y = 0f;
								global::UnityEngine.Vector2 vector5 = float5;
								float6.x = (float)obj8;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v20+4]");
								float6.y = 0f;
								vector4 = float6;
								num8 = vector4.y;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3 (System.Object)+18]");
								global::System.Func<global::UnityEngine.Vector2> func5 = (global::System.Func<global::UnityEngine.Vector2>)0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v3 (System.Object)+18]");
								bool flag3 = (nint)0 == 0;
								bool flag4 = !flag3;
								num7 = (nint)(&obj6);
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v252 @ X27_v4 (Il2CppMethodInfo)+C28]");
								func3 = (global::System.Func<global::UnityEngine.Vector2>)0;
								func4 = func6;
								if (!flag4)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X25_v4 (Il2CppMethodInfo)+50]");
									global::System.Func<global::UnityEngine.Vector2> func7 = null;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v254 @ X25_v4 (Il2CppMethodInfo)+50]");
									num7 = 0;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
									func5 = func7;
									func3 = null;
									func4 = func7;
								}
								bool flag5 = fluidCollectDisplay.activeCount >= fluidCollectDisplay.maxParticles;
								func2 = func3;
								vector2 = vector4;
								num = num8;
								if (!flag5)
								{
									global::UnityEngine.Vector2 position = vector5;
									global::UnityEngine.Vector2 vel = vector4;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X10_v5 (Unity.Collections.NativeArray`1<System.Int32>)+v329 @ stack_-F4_v6*4]");
									CollectParticleData collectParticleData = fluidCollectDisplay.AddParticle(position, vel, 0, CollectParticleMode.Shrink, 0f, func5);
									func2 = func5;
									vector2 = vector5;
									num = vector5.y;
								}
							}
							continue;
						}
						global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
						break;
					}
					nint num10 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
					return;
				}
				func2 = func3;
				int num11 = 0;
				func = func4;
				num = num8;
			}
		}
		global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
		bool flag6 = (nint)func != 1;
		global::System.NullReferenceException ex4 = ex3;
		if (!flag6)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			nint num12 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v5 (Il2CppMethodInfo)+968]");
			func = (global::System.Func<global::UnityEngine.Vector2>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj9 = default(object);
			if (obj9 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex5 = new global::System.OutOfMemoryException();
			int num11 = (int)obj9;
			ex4 = (global::System.NullReferenceException)(object)ex5;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000196")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEB984", Offset = "0xFEB984", Length = "0x5AC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_005D;\n\tv45 = CollectParticleData[];\n\tv46 = v45 + 0x990;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0x968;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv242 = Il2CppMethodInfo;\n\tv243 = v242 + 0x970;\n\tv244 = \"il2cpp_codegen_initialize_runtime_metadata\"(v243, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv249 = Il2CppMethodInfo;\n\tv250 = v249 + 0x978;\n\tv251 = \"il2cpp_codegen_initialize_runtime_metadata\"(v250, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv356 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv357 = v356 + 8;\n\tv358 = \"il2cpp_codegen_initialize_runtime_metadata\"(v357, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv377 = Il2CppMethodInfo;\n\tv378 = v377 + 0x998;\n\tv379 = \"il2cpp_codegen_initialize_runtime_metadata\"(v378, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv390 = Il2CppMethodInfo;\n\tv391 = v390 + 0x5B0;\n\tv392 = \"il2cpp_codegen_initialize_runtime_metadata\"(v391, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv408 = Il2CppMethodInfo;\n\tv409 = v408 + 0x628;\n\tv410 = \"il2cpp_codegen_initialize_runtime_metadata\"(v409, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv416 = Il2CppMethodInfo;\n\tv417 = v416 + 0xC8;\n\tv418 = \"il2cpp_codegen_initialize_runtime_metadata\"(v417, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv617 = Il2CppMethodInfo;\n\tv618 = v617 + 0xD0;\n\tv619 = \"il2cpp_codegen_initialize_runtime_metadata\"(v618, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv622 = Il2CppMethodInfo;\n\tv623 = v622 + 0x630;\n\tv624 = \"il2cpp_codegen_initialize_runtime_metadata\"(v623, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv649 = Il2CppMethodInfo;\n\tv650 = v649 + 0xC28;\n\tv651 = \"il2cpp_codegen_initialize_runtime_metadata\"(v650, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv655 = Il2CppMethodInfo;\n\tv656 = v655 + 0xC90;\n\tv657 = \"il2cpp_codegen_initialize_runtime_metadata\"(v656, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv660 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv661 = v660 + 0xA48;\n\tv662 = \"il2cpp_codegen_initialize_runtime_metadata\"(v661, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv666 = Il2CppMethodInfo;\n\tv667 = v666 + 0x58;\n\tv668 = \"il2cpp_codegen_initialize_runtime_metadata\"(v667, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv671 = Il2CppMethodInfo;\n\tv672 = v671 + 0x60;\n\tv673 = \"il2cpp_codegen_initialize_runtime_metadata\"(v672, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv714 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv715 = v714 + 0x1F8;\n\tv716 = \"il2cpp_codegen_initialize_runtime_metadata\"(v715, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv717 = Il2CppMethodInfo;\n\tv718 = v717 + 0x68;\n\tv719 = \"il2cpp_codegen_initialize_runtime_metadata\"(v718, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv721 = Il2CppMethodInfo;\n\tv722 = v721 + 0x70;\n\tv723 = \"il2cpp_codegen_initialize_runtime_metadata\"(v722, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv731 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv732 = v731 + 0x200;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v732, ids, explode, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv64 = 1;\n\t*([302A987]) = v64;\nL_005D:\n\tv69 = v365 == 0;\n\tif (v69) goto L_0199;\n\tv328 = Il2CppMethodInfo + 0x970;\n\tv77 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv79 = CollectParticleData[];\n\tv85 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v365);\nL_0072:\n\tv220 = *([v328 @ X22_v6]);\n\tv344 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v218 @ stack_-C0 (System.Int32), *([v328 @ X22_v6]));\n\tv359 = v344 & 1;\n\tv360 = v359 == 0;\n\tif (v360) goto L_015A;\n\tv381 = this.solver == 0;\n\tif (v381) goto L_018F;\n\tv393 = this.solver + 0x1F8;\n\tv394 = Il2CppMethodInfo;\n\tv201 = *([v394 @ X8_v23 (Il2CppMethodInfo)+C28]);\n\tv331 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v393, v247, &v314 @ stack_-A4_v6, *([v394 @ X8_v23 (Il2CppMethodInfo)+C28]));\n\tv411 = v331 & 1;\n\tv335 = v411 == 0;\n\tif (v335) goto L_0072;\n\tv419 = this.solver;\n\tv420 = this.solver == 0;\n\tif (v420) goto L_0191;\n\tv652 = this.level;\n\tv621 = this.level == 0;\n\tif (v621) goto L_0181;\n\tv627 = v419.particleTypes;\n\tv312 = v314 << 3;\n\tv310 = v419.velocities + v312;\n\tv630 = v419.positions + v312;\nL_0098:\n\tv543 = v652.goals;\n\tv533 = v652.goals == 0;\n\tif (v533) goto L_0183;\n\tv455 = v519 >= v543._size;\n\tif (v455) goto L_00E1;\n\tv663 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv665 = new *([v663 @ X8_v48 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+1F8])();\n\tSystem.Object::.ctor(v665);\n\tv535 = v665 == 0;\n\tif (v535) goto L_0187;\n\t*([v665 @ X0_v59 (System.Object)+10]) = v519;\n\tv544 = this.level;\n\tv536 = this.level == 0;\n\tif (v536) goto L_0189;\n\tv534 = v544.goals == 0;\n\tif (v534) goto L_0185;\n\tv728 = System.Collections.Generic.List`1<GoalData>::get_Item(v544.goals, v519);\n\tv734 = new *([v77 @ X19_v9 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+8])();\n\tv736 = Il2CppMethodInfo;\n\tSystem.Func`1<UnityEngine.Vector2>::.ctor(v734, v665, *([v736 @ X8_v53 (Il2CppMethodInfo)+58]));\n\tv752 = new *([v79 @ X28_v4 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv754 = Il2CppMethodInfo;\n\tSystem.Action::.ctor(v752, v665, *([v754 @ X8_v55 (Il2CppMethodInfo)+60]));\n\t// 216 MakeStruct v632 @ AGGFEBC54_3_v7 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v630 @ X8_v28], [v630 @ X8_v28+4]\n\t// 217 MakeStruct v631 @ AGGFEBC54_4_v7 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v310 @ X10_v8], [v310 @ X10_v8+4]\n\tCollectionManager::TryCollect(this, v728, *([v627 @ X10_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v314 @ stack_-A4_v6*4]), v632, v631, v734, v752);\n\tv519 = v519 + 1;\n\tv652 = this.level;\n\tv763 = this.level == 0;\n\tv647 = ~v763;\n\tif (v647) goto L_0098;\n\tgoto L_0181;\nL_00E1:\n\tv548 = v652.sections;\n\tv539 = v652.sections == 0;\n\tif (v539) goto L_0193;\n\tv452 = v548._size < 1;\n\tif (v452) goto L_014D;\n\tv674 = Level::GetCurrentSection(v652);\n\tv540 = v674 == 0;\n\tif (v540) goto L_0195;\n\tv517 = v674.locks;\n\tv686 = v517._size < 1;\n\tif (v686) goto L_014D;\nL_0106:\n\tv747 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv750 = new *([v747 @ X8_v38 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+200])();\n\tSystem.Object::.ctor(v750);\n\tv758 = Il2CppMethodInfo;\n\tv197 = *([v758 @ X8_v40 (Il2CppMethodInfo)+630]);\n\tv761 = System.Collections.Generic.List`1<Lock>::get_Item(v517, v451);\n\tv538 = v750 == 0;\n\tif (v538) goto L_018D;\n\tv443 = v750 + 0x10;\n\t*([v750 @ X0_v46 (System.Object)+10]) = v761;\n\tv766 = 0xF3F1B4(v443, v761, *([v758 @ X8_v40 (Il2CppMethodInfo)+630]), v508, v114, v50, v51, v52, v213, v123, v120, v117, v57, v58, v59, v60);\n\tv546 = *([v750 @ X0_v46 (System.Object)+10]);\n\tv537 = *([v750 @ X0_v46 (System.Object)+10]) == 0;\n\tif (v537) goto L_018B;\n\tv768 = new *([v77 @ X19_v9 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+8])();\n\tv769 = Il2CppMethodInfo;\n\tSystem.Func`1<UnityEngine.Vector2>::.ctor(v768, v750, *([v769 @ X8_v43 (Il2CppMethodInfo)+68]));\n\tv775 = new *([v79 @ X28_v4 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv776 = Il2CppMethod\n// ... truncated")]
	public unsafe void OnSolverStartRemoveParticles(global::System.Collections.Generic.HashSet<int> ids, bool explode)
	{
		//IL_0012: Expected O, but got I
		//IL_0020: Expected I, but got O
		//IL_002e: Expected I, but got O
		//IL_004b: Expected O, but got I4
		//IL_085d: Expected O, but got I
		//IL_086f: Expected O, but got I4
		//IL_0bb2: Expected O, but got I
		//IL_0bdb: Expected I4, but got O
		//IL_0a2c: Expected I, but got O
		//IL_0bfa: Expected I4, but got O
		//IL_0b3c: Expected O, but got I4
		//IL_0080: Expected O, but got I
		//IL_08fa: Expected I, but got O
		//IL_0159: Unknown result type (might be due to invalid IL or missing references)
		//IL_015e: Expected O, but got Unknown
		//IL_016d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0172: Expected O, but got Unknown
		//IL_01ac: Expected O, but got I
		//IL_01fc: Expected I, but got O
		//IL_077b: Expected O, but got I
		//IL_0796: Expected I, but got O
		//IL_07b1: Expected F4, but got O
		//IL_07c6: Expected F4, but got I
		//IL_07d3: Expected F4, but got O
		//IL_07e8: Expected F4, but got I
		//IL_0812: Expected O, but got I
		//IL_082a: Expected O, but got I
		//IL_083a: Expected I, but got O
		//IL_0af6: Expected I, but got O
		//IL_0993: Expected I, but got O
		//IL_0ca0: Expected I, but got O
		//IL_02e6: Expected F4, but got O
		//IL_02fb: Expected F4, but got I
		//IL_0308: Expected F4, but got O
		//IL_031d: Expected F4, but got I
		//IL_0394: Expected O, but got I
		//IL_03ac: Expected O, but got I
		//IL_0a0e: Expected I, but got O
		//IL_05b0: Expected O, but got I
		//IL_05cf: Expected O, but got I
		//IL_03fa: Expected O, but got I
		//IL_0412: Expected O, but got I
		//IL_09eb: Expected I, but got O
		//IL_064b: Expected F4, but got O
		//IL_0660: Expected F4, but got I
		//IL_066d: Expected F4, but got O
		//IL_0682: Expected F4, but got I
		//IL_06b0: Expected O, but got I
		//IL_06e9: Expected O, but got I
		//IL_0701: Expected O, but got I
		//IL_0739: Expected O, but got I
		//IL_0751: Expected O, but got I
		global::System.Collections.Generic.HashSet<int> hashSet = default(global::System.Collections.Generic.HashSet<int>);
		bool flag;
		bool flag2 = default(bool);
		if (hashSet != null)
		{
			object obj = (nint)0 + (nint)2416;
			nint num = 0;
			nint num2 = 0;
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator();
			flag = flag2;
			int num3 = default(int);
			object obj2 = num3;
			object obj3 = default(object);
			object obj5 = default(object);
			object obj6 = default(object);
			GoalData goalData2 = default(GoalData);
			global::System.Action action = default(global::System.Action);
			object obj9 = default(object);
			object obj11 = default(object);
			object obj13 = default(object);
			int num8 = default(int);
			global::System.Func<global::UnityEngine.Vector2> func = default(global::System.Func<global::UnityEngine.Vector2>);
			object obj15 = default(object);
			global::Unity.Mathematics.float2 position = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 velocity = default(global::Unity.Mathematics.float2);
			global::System.Action action4 = default(global::System.Action);
			object obj17 = default(object);
			object obj18 = default(object);
			object obj19 = default(object);
			bool flag7 = default(bool);
			object obj20 = default(object);
			global::System.Func<global::UnityEngine.Vector2> func3 = default(global::System.Func<global::UnityEngine.Vector2>);
			Lock obj21 = default(Lock);
			global::Unity.Mathematics.float2 position2 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 velocity2 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			global::System.Action action2 = default(global::System.Action);
			object obj10 = default(object);
			object obj12 = default(object);
			object obj14 = default(object);
			object obj25;
			while (true)
			{
				GoalData goalData = (GoalData)obj;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj3 & 1) == 0)
				{
					break;
				}
				Level level;
				object obj7;
				object obj8;
				GoalData goalData3;
				GoalData goalData4;
				global::System.Action action3;
				nint num5;
				if ((object)solver != null)
				{
					object obj4 = (nint)solver + 504;
					nint num4 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v23 (Il2CppMethodInfo)+C28]");
					num5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					int num6 = (int)((nint)obj5 & 1);
					bool flag3 = num6 == 0;
					flag = (byte)(&obj6) != 0;
					if (flag3)
					{
						continue;
					}
					FluidSolver fluidSolver = solver;
					if ((object)solver != null)
					{
						level = this.level;
						bool flag4 = (object)this.level == null;
						goalData = goalData2;
						if (flag4)
						{
							goto IL_08c1;
						}
						global::Unity.Collections.NativeArray<int> particleTypes = fluidSolver.particleTypes;
						int num7 = (int)((nint)obj6 << 3);
						obj7 = fluidSolver.velocities + num7;
						obj8 = fluidSolver.positions + num7;
						action = action2;
						obj9 = obj10;
						obj11 = obj12;
						obj13 = obj14;
						num8 = (int)(&obj6);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v23 (Il2CppMethodInfo)+C28]");
						func = (global::System.Func<global::UnityEngine.Vector2>)0;
						obj15 = obj2;
						goalData3 = goalData2;
						int num9 = 0;
						while (true)
						{
							global::System.Collections.Generic.List<GoalData> goals = level.goals;
							if (level.goals == null)
							{
								break;
							}
							if (num9 >= goals.Count)
							{
								goto IL_0427;
							}
							nint num10 = 0;
							object obj16 = new object();
							if (obj16 != null)
							{
								Level level2 = this.level;
								if ((object)this.level != null)
								{
									if (level2.goals != null)
									{
										goalData4 = level2.goals[num9];
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v736 @ X8_v53 (Il2CppMethodInfo)+58]");
										global::System.Func<global::UnityEngine.Vector2> func2 = null;
										nint num11 = 0;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v754 @ X8_v55 (Il2CppMethodInfo)+60]");
										action3 = null;
										nint num12 = 0;
										position.x = (float)obj8;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v28+4]");
										position.y = 0f;
										velocity.x = (float)obj7;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v8+4]");
										velocity.y = 0f;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X10_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v314 @ stack_-A4_v6*4]");
										TryCollect(goalData4, 0, position, velocity, func2, action3);
										num9++;
										level = this.level;
										bool flag5 = (object)this.level == null;
										bool flag6 = !flag5;
										action = action3;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v8+4]");
										obj9 = 0;
										obj11 = obj7;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v28+4]");
										obj13 = 0;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X10_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v314 @ stack_-A4_v6*4]");
										num8 = 0;
										func = func2;
										obj15 = obj8;
										goalData3 = goalData4;
										if (flag6)
										{
											continue;
										}
										goto IL_03e2;
									}
									goto IL_095a;
								}
								throw obj16;
							}
							throw obj16;
						}
						global::System.NullReferenceException ex = new global::System.NullReferenceException();
						action4 = action2;
						obj17 = obj10;
						obj18 = obj12;
						obj19 = obj14;
						flag7 = (byte)(&obj6) != 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v394 @ X8_v23 (Il2CppMethodInfo)+C28]");
						num5 = 0;
						obj20 = obj2;
					}
					else
					{
						global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
						action4 = action2;
						obj17 = obj10;
						obj18 = obj12;
						obj19 = obj14;
						flag7 = (byte)(&obj6) != 0;
						obj20 = obj2;
					}
				}
				else
				{
					global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
					num5 = (nint)func3;
					goalData = (GoalData)(object)obj21;
				}
				goto IL_0b0b;
				IL_095a:
				global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
				action4 = action;
				obj17 = obj9;
				obj18 = obj11;
				obj19 = obj13;
				flag7 = (byte)num8 != 0;
				num5 = (nint)func;
				obj20 = obj15;
				goalData = goalData3;
				goto IL_0b0b;
				IL_0427:
				global::System.Collections.Generic.List<LevelSection> sections = level.sections;
				int num13;
				global::System.Func<global::UnityEngine.Vector2> func4;
				if (level.sections != null)
				{
					bool flag8 = sections.Count < 1;
					action2 = action;
					obj10 = obj9;
					obj12 = obj11;
					obj14 = obj13;
					num13 = num8;
					func4 = func;
					obj2 = obj15;
					if (flag8)
					{
						goto IL_076f;
					}
					LevelSection currentSection = level.GetCurrentSection();
					if (currentSection != null)
					{
						global::System.Collections.Generic.List<Lock> locks = currentSection.locks;
						bool flag9 = locks.Count < 1;
						action2 = action;
						obj10 = obj9;
						obj12 = obj11;
						obj14 = obj13;
						num13 = num8;
						func4 = func;
						obj2 = obj15;
						if (flag9)
						{
							goto IL_076f;
						}
						action4 = action;
						obj17 = obj9;
						obj18 = obj11;
						obj19 = obj13;
						int num14 = 0;
						func3 = func;
						obj20 = obj15;
						while (true)
						{
							nint num15 = 0;
							object obj22 = new object();
							nint num16 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v758 @ X8_v40 (Il2CppMethodInfo)+630]");
							flag7 = false;
							obj21 = locks[num14];
							if (obj22 == null)
							{
								break;
							}
							object obj23 = (nint)obj22 + 16;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v46 (System.Object)+10]");
							object obj24 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X0_v46 (System.Object)+10]");
							if ((nint)0 != 0)
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v769 @ X8_v43 (Il2CppMethodInfo)+68]");
								global::System.Func<global::UnityEngine.Vector2> func5 = null;
								nint num17 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v776 @ X8_v45 (Il2CppMethodInfo)+70]");
								global::System.Action action5 = null;
								nint num18 = 0;
								position2.x = (float)obj8;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v28+4]");
								position2.y = 0f;
								velocity2.x = (float)obj7;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v8+4]");
								velocity2.y = 0f;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v546 @ X8_v42+20]");
								nint num19 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X10_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v314 @ stack_-A4_v6*4]");
								TryCollect((GoalData)num19, 0, position2, velocity2, func5, action5);
								num14++;
								bool flag10 = num14 < locks.Count;
								action2 = action5;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v8+4]");
								obj10 = 0;
								obj12 = obj7;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v28+4]");
								obj14 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X10_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v314 @ stack_-A4_v6*4]");
								num13 = 0;
								func4 = func5;
								obj2 = obj8;
								action4 = action5;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v8+4]");
								obj17 = 0;
								obj18 = obj7;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v28+4]");
								obj19 = 0;
								func3 = func5;
								obj20 = obj8;
								if (flag10)
								{
									continue;
								}
								goto IL_076f;
							}
							goto IL_09b2;
						}
						global::System.NullReferenceException ex5 = new global::System.NullReferenceException();
						num5 = (nint)func3;
						goalData = (GoalData)(object)obj21;
					}
					else
					{
						global::System.NullReferenceException ex6 = new global::System.NullReferenceException();
						action4 = action;
						obj17 = obj9;
						obj18 = obj11;
						obj19 = obj13;
						flag7 = (byte)num8 != 0;
						num5 = (nint)func;
						obj20 = obj15;
						goalData = goalData3;
					}
				}
				else
				{
					global::System.NullReferenceException ex7 = new global::System.NullReferenceException();
					action4 = action2;
					obj17 = obj10;
					obj18 = obj12;
					obj19 = obj14;
					flag7 = (byte)(&obj6) != 0;
					obj20 = obj2;
					goalData = goalData2;
				}
				goto IL_0b0b;
				IL_0b0b:
				action2 = action4;
				obj10 = obj17;
				obj12 = obj18;
				obj14 = obj19;
				flag2 = flag7;
				obj25 = num3;
				obj2 = obj20;
				num3 = 0;
				hashSet = (global::System.Collections.Generic.HashSet<int>)(object)goalData;
				goto IL_0cd6;
				IL_076f:
				obj = (nint)0 + (nint)2416;
				bool flag11 = !flag2;
				flag = (byte)num13 != 0;
				num5 = (nint)func4;
				if (!flag11)
				{
					float5.x = (float)obj8;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v28+4]");
					float5.y = 0f;
					float6.x = (float)obj7;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v8+4]");
					float6.y = 0f;
					global::Unity.Mathematics.float2 position3 = float5;
					global::Unity.Mathematics.float2 velocity3 = float6;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v627 @ X10_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v314 @ stack_-A4_v6*4]");
					AddExplodeParticle(position3, velocity3, 0);
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v8+4]");
					obj10 = 0;
					obj12 = obj7;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v28+4]");
					obj14 = 0;
					flag = (byte)num13 != 0;
					num5 = (nint)func4;
					obj2 = obj8;
				}
				continue;
				IL_08c1:
				global::System.NullReferenceException ex8 = new global::System.NullReferenceException();
				action4 = action;
				obj17 = obj9;
				obj18 = obj11;
				obj19 = obj13;
				flag7 = (byte)num8 != 0;
				num5 = (nint)func;
				obj20 = obj15;
				goalData = null;
				goto IL_0b0b;
				IL_09b2:
				global::System.NullReferenceException ex9 = new global::System.NullReferenceException();
				action4 = action;
				obj17 = obj9;
				obj18 = obj11;
				obj19 = obj13;
				flag7 = (byte)num8 != 0;
				num5 = (nint)func;
				obj20 = obj15;
				goalData = null;
				goto IL_0b0b;
				IL_03e2:
				action2 = action3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X10_v8+4]");
				obj10 = 0;
				obj12 = obj7;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v630 @ X8_v28+4]");
				obj14 = 0;
				obj2 = obj8;
				goalData = goalData4;
				goto IL_08c1;
			}
			nint num20 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v19 (Il2CppMethodInfo)+968]");
			hashSet = (global::System.Collections.Generic.HashSet<int>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			obj25 = num3;
			num3 = 0;
			goto IL_0882;
		}
		goto IL_0cd6;
		IL_0882:
		nint num21 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		GameManager gameManager = default(GameManager);
		bool flag12 = (object)gameManager == null;
		flag2 = flag;
		if (!flag12)
		{
			gameManager.CheckWinCondition();
			return;
		}
		goto IL_0cd6;
		IL_0cd6:
		global::System.NullReferenceException ex10 = new global::System.NullReferenceException();
		bool flag13 = (nint)hashSet != 1;
		global::System.NullReferenceException ex11 = ex10;
		if (!flag13)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			nint num22 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v406 @ X8_v5 (Il2CppMethodInfo)+968]");
			hashSet = (global::System.Collections.Generic.HashSet<int>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj26 = default(object);
			bool flag14 = obj26 == null;
			flag = flag2;
			int num3 = (int)obj26;
			if (flag14)
			{
				goto IL_0882;
			}
			global::System.OutOfMemoryException ex12 = new global::System.OutOfMemoryException();
			num3 = (int)obj26;
			ex11 = (global::System.NullReferenceException)(object)ex12;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000197")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEBF38", Offset = "0xFEBF38", Length = "0x1C0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv44 = goal.count < 1;\n\tif (v44) goto L_0109;\n\tv240 = goal.goalType == 4;\n\tif (v240) goto L_004C;\n\tv241 = goal.goalType == 3;\n\tif (v241) goto L_005D;\n\tv469 = goal.goalType == 0;\n\tv470 = ~v469;\n\tif (v470) goto L_FFFFFFFF;\n\tv492 = goal.fluidType != particleType;\n\tif (v492) goto L_FFFFFFFF;\n\tv186 = this.colorDisplay;\n\tgoto L_006F;\nL_004C:\n\tv272 = this.solver;\n\tv481 = v272.snowFluidType != particleType;\n\tif (v481) goto L_FFFFFFFF;\n\tv186 = this.snowDisplay;\n\tgoto L_006F;\nL_005D:\n\tv273 = this.solver;\n\tv494 = v273.mudFluidType != particleType;\n\tif (v494) goto L_FFFFFFFF;\n\tv186 = this.mudDisplay;\nL_006F:\n\tv526 = Unity.Mathematics.float2::op_Implicit(position);\n\tv176 = Unity.Mathematics.float2::op_Implicit(velocity);\n\tv204 = v186.activeCount >= v186.maxParticles;\n\tif (v204) goto L_00A9;\n\tv571 = FluidCollectDisplay::AddParticle(v186, v526, v176, particleType, 0, 0f, targetPosition, onCollected);\nL_00A9:\n\tv276 = goal.count - 1;\n\tgoal.count = v276;\n\tLevel::OnFluidCollected(this.level, particleType);\n\tgoto L_00B4;\nL_00B4:\n\tv164 = this.solver;\n\tv538 = v164.colorFluidTypes > particleType;\n\tif (v538) goto L_00D1;\n\tv551 = v164.mudFluidType != particleType;\n\tif (v551) goto L_00EA;\nL_00D1:\n\tv380 = v377 == 0;\n\tif (v380) goto L_0109;\nL_00E5:\n\tLevel::OnFluidCollected(this.level, particleType);\n\treturn;\nL_00EA:\n\tv371 = v164.snowFluidType - particleType;\n\tv365 = v371 == 0;\n\tv350 = ~v365;\n\tv304 = ~v350;\n\tif (v304) goto L_00F8;\n\tgoto L_00F8;\nL_00F8:\n\tv593 = v377 & 1;\n\tv594 = v593 == 0;\n\tv379 = ~v594;\n\tif (v379) goto L_00E5;\nL_0109:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 215 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void TryCollect(GoalData goal, int particleType, global::Unity.Mathematics.float2 position, global::Unity.Mathematics.float2 velocity, global::System.Func<global::UnityEngine.Vector2> targetPosition, global::System.Action onCollected)
	{
		if (goal.count < 1)
		{
			return;
		}
		FluidCollectDisplay fluidCollectDisplay;
		if (goal.goalType != GoalType.Snow)
		{
			if (goal.goalType != GoalType.Mud)
			{
				if (goal.goalType != GoalType.Fluid || goal.fluidType != particleType)
				{
					goto IL_01c9;
				}
				fluidCollectDisplay = colorDisplay;
			}
			else
			{
				FluidSolver fluidSolver = solver;
				if (fluidSolver.mudFluidType != particleType)
				{
					goto IL_01c9;
				}
				fluidCollectDisplay = mudDisplay;
			}
		}
		else
		{
			FluidSolver fluidSolver2 = solver;
			if (fluidSolver2.snowFluidType != particleType)
			{
				goto IL_01c9;
			}
			fluidCollectDisplay = snowDisplay;
		}
		global::UnityEngine.Vector2 position2 = position;
		global::UnityEngine.Vector2 vel = velocity;
		if (fluidCollectDisplay.activeCount < fluidCollectDisplay.maxParticles)
		{
			CollectParticleData collectParticleData = fluidCollectDisplay.AddParticle(position2, vel, particleType, default(CollectParticleMode), 0f, targetPosition, onCollected);
		}
		int count = goal.count - 1;
		goal.count = count;
		level.OnFluidCollected(particleType);
		int num = 0;
		goto IL_02e1;
		IL_02e1:
		FluidSolver fluidSolver3 = solver;
		if (fluidSolver3.colorFluidTypes > particleType || fluidSolver3.mudFluidType == particleType)
		{
			if (num == 0)
			{
				return;
			}
		}
		else
		{
			if (fluidSolver3.snowFluidType - particleType != 0)
			{
				num = 0;
			}
			if ((num & 1) == 0)
			{
				return;
			}
		}
		level.OnFluidCollected(particleType);
		return;
		IL_01c9:
		num = 1;
		goto IL_02e1;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000198")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEC100", Offset = "0xFEC100", Length = "0xF4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = this.solver;\n\tv41 = v22.colorFluidTypes <= particleType;\n\tif (v41) goto L_002C;\n\tv57 = this.colorDisplay;\n\tgoto L_003F;\nL_002C:\n\tv119 = v22.mudFluidType != particleType;\n\tif (v119) goto L_003A;\n\tv57 = this.mudDisplay;\n\tgoto L_003F;\nL_003A:\n\tv122 = v22.snowFluidType != particleType;\n\tif (v122) goto L_0087;\n\tv57 = this.snowDisplay;\nL_003F:\n\tv133 = Unity.Mathematics.float2::op_Implicit(position);\n\tv51 = Unity.Mathematics.float2::op_Implicit(velocity);\n\tv293 = v57.activeCount >= v57.maxParticles;\n\tif (v293) goto L_0087;\n\tv315 = UnityEngine.Random::Range(v57.minExplodeDuration, v57.maxExplodeDuration);\n\tv288 = FluidCollectDisplay::AddParticle(v57, v133, v51, particleType, 1, v315, 0, 0);\nL_0087:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 117 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void AddExplodeParticle(global::Unity.Mathematics.float2 position, global::Unity.Mathematics.float2 velocity, int particleType)
	{
		FluidSolver fluidSolver = solver;
		FluidCollectDisplay fluidCollectDisplay;
		if (fluidSolver.colorFluidTypes > particleType)
		{
			fluidCollectDisplay = colorDisplay;
		}
		else if (fluidSolver.mudFluidType == particleType)
		{
			fluidCollectDisplay = mudDisplay;
		}
		else
		{
			if (fluidSolver.snowFluidType != particleType)
			{
				return;
			}
			fluidCollectDisplay = snowDisplay;
		}
		global::UnityEngine.Vector2 position2 = position;
		global::UnityEngine.Vector2 vel = velocity;
		if (fluidCollectDisplay.activeCount < fluidCollectDisplay.maxParticles)
		{
			float explodeDuration = global::UnityEngine.Random.Range(fluidCollectDisplay.minExplodeDuration, fluidCollectDisplay.maxExplodeDuration);
			CollectParticleData collectParticleData = fluidCollectDisplay.AddParticle(position2, vel, particleType, CollectParticleMode.Explode, explodeDuration);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000199")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEC2C0", Offset = "0xFEC2C0", Length = "0x250")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_003C;\n\tv49 = CollectParticleData[];\n\tv50 = v49 + 0x990;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv69 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv70 = v69 + 8;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv224 = Il2CppMethodInfo;\n\tv225 = v224 + 0xC8;\n\tv226 = \"il2cpp_codegen_initialize_runtime_metadata\"(v225, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv229 = Il2CppMethodInfo;\n\tv230 = v229 + 0xD0;\n\tv231 = \"il2cpp_codegen_initialize_runtime_metadata\"(v230, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv289 = Il2CppMethodInfo;\n\tv290 = v289 + 0xC90;\n\tv291 = \"il2cpp_codegen_initialize_runtime_metadata\"(v290, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv299 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv300 = v299 + 0xA48;\n\tv301 = \"il2cpp_codegen_initialize_runtime_metadata\"(v300, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv306 = Il2CppMethodInfo;\n\tv307 = v306 + 0x78;\n\tv308 = \"il2cpp_codegen_initialize_runtime_metadata\"(v307, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv309 = Il2CppMethodInfo;\n\tv310 = v309 + 0x80;\n\tv311 = \"il2cpp_codegen_initialize_runtime_metadata\"(v310, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv312 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv313 = v312 + 0x208;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v313, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv66 = 1;\n\t*([302A988]) = v66;\nL_003C:\n\tv228 = this.level;\n\tv73 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_005B;\nL_0053:\n\tSpriteCollectDisplay::AddSprite(this.spriteDisplay, v195.sprite, pos, vel, 0.1f, v346, v196);\n\tv340 = v195.count - 1;\n\tv195.count = v340;\nL_0057:\n\tv216 = v216 + 1;\n\tv228 = this.level;\nL_005B:\n\tv209 = v228.goals;\n\tv102 = v216 >= v209._size;\n\tif (v102) goto L_00B9;\n\tv193 = new *([v73 @ X28_v2 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+208])();\n\tSystem.Object::.ctor(v193);\n\t*([v193 @ X0_v11 (System.Object)+10]) = v216;\n\tv211 = this.level;\n\tv195 = System.Collections.Generic.List`1<GoalData>::get_Item(v211.goals, v216);\n\tv325 = v195.count < 1;\n\tif (v325) goto L_0057;\n\tv103 = v195.goalType != 1;\n\tif (v103) goto L_0057;\n\tv343 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv346 = new *([v343 @ X8_v18 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+8])();\n\tv347 = Il2CppMethodInfo;\n\tSystem.Func`1<UnityEngine.Vector2>::.ctor(v346, v193, *([v347 @ X8_v20 (Il2CppMethodInfo)+78]));\n\tv352 = CollectParticleData[];\n\tv196 = new *([v352 @ X8_v22 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv355 = Il2CppMethodInfo;\n\tSystem.Action::.ctor(v196, v193, *([v355 @ X8_v24 (Il2CppMethodInfo)+80]));\n\tv356 = this.spriteDisplay == 0;\n\tv205 = ~v356;\n\tif (v205) goto L_0053;\n\tgoto L_00D5;\nL_00B9:\n\tgoto L_00BB;\n\tv302 = \"il2cpp_codegen_runtime_class_init\"(v295, v181, v170, v166, v163, v56, v57, v58, v178, v222, v175, v219, v187, v60, v61, v62);\nL_00BB:\n\tv304 = Il2CppMethodInfo;\n\tv197 = Singleton`1::get_Instance /* +1 sharing this address */(*([v304 @ X8_v11 (Il2CppMethodInfo)+C90]));\n\tGameManager::CheckWinCondition(v197);\n\treturn;\nL_00D5:\n\tthrow System.NullReferenceException;\n// 146 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnCollectIceBlock(global::UnityEngine.Vector2 pos, global::UnityEngine.Vector2 vel)
	{
		//IL_0013: Expected I, but got O
		//IL_013b: Expected I, but got O
		//IL_0170: Expected I, but got O
		Level level = this.level;
		nint num = 0;
		int num2 = 0;
		GameManager gameManager = default(GameManager);
		while (true)
		{
			global::System.Collections.Generic.List<GoalData> goals = level.goals;
			if (num2 < goals.Count)
			{
				object obj = new object();
				Level level2 = this.level;
				GoalData goalData = level2.goals[num2];
				if (goalData.count >= 1 && goalData.goalType == GoalType.Ice)
				{
					nint num3 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v20 (Il2CppMethodInfo)+78]");
					global::System.Func<global::UnityEngine.Vector2> getTargetPos = null;
					nint num4 = 0;
					nint num5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v24 (Il2CppMethodInfo)+80]");
					global::System.Action onComplete = null;
					nint num6 = 0;
					if ((object)spriteDisplay == null)
					{
						break;
					}
					spriteDisplay.AddSprite(goalData.sprite, pos, vel, 0.1f, getTargetPos, onComplete);
					int count = goalData.count - 1;
					goalData.count = count;
				}
				num2++;
				level = this.level;
				continue;
			}
			nint num7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			gameManager.CheckWinCondition();
			return;
		}
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600019A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEC518", Offset = "0xFEC518", Length = "0x278")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0039;\n\tv45 = CollectParticleData[];\n\tv46 = v45 + 0x990;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv67 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv68 = v67 + 8;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv235 = Il2CppMethodInfo;\n\tv236 = v235 + 0xC8;\n\tv237 = \"il2cpp_codegen_initialize_runtime_metadata\"(v236, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv240 = Il2CppMethodInfo;\n\tv241 = v240 + 0xD0;\n\tv242 = \"il2cpp_codegen_initialize_runtime_metadata\"(v241, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv301 = Il2CppMethodInfo;\n\tv302 = v301 + 0xC90;\n\tv303 = \"il2cpp_codegen_initialize_runtime_metadata\"(v302, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv311 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv312 = v311 + 0xA48;\n\tv313 = \"il2cpp_codegen_initialize_runtime_metadata\"(v312, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv318 = Il2CppMethodInfo;\n\tv319 = v318 + 0x88;\n\tv320 = \"il2cpp_codegen_initialize_runtime_metadata\"(v319, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv321 = Il2CppMethodInfo;\n\tv322 = v321 + 0x90;\n\tv323 = \"il2cpp_codegen_initialize_runtime_metadata\"(v322, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv324 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv325 = v324 + 0x210;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v325, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv64 = 1;\n\t*([302A989]) = v64;\nL_0039:\n\tv239 = this.level;\n\tv71 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0074;\nL_0042:\n\tv366 = System.Xml.ValidateNames;\n\tv368 = *([v366 @ X8_v22 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv369 = *([v368 @ X8_v24+B8]);\n\tv370 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv373 = new *([v370 @ X8_v26 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+8])();\n\tv374 = Il2CppMethodInfo;\n\tSystem.Func`1<UnityEngine.Vector2>::.ctor(v373, v208, *([v374 @ X8_v28 (Il2CppMethodInfo)+88]));\n\tv379 = CollectParticleData[];\n\tv205 = new *([v379 @ X8_v30 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv382 = Il2CppMethodInfo;\n\tSystem.Action::.ctor(v205, v208, *([v382 @ X8_v32 (Il2CppMethodInfo)+90]));\n\t// 107 MakeStruct v340 @ AGGFEC680_3_v4 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), [v369 @ X8_v25], [v369 @ X8_v25+4]\n\tSpriteCollectDisplay::AddSprite(this.spriteDisplay, v210.sprite, pos, v340, 0f, v373, v205);\n\tv353 = v210.count - 1;\n\tv210.count = v353;\nL_0070:\n\tv229 = v229 + 1;\n\tv239 = this.level;\nL_0074:\n\tv224 = v239.goals;\n\tv98 = v229 >= v224._size;\n\tif (v98) goto L_00C4;\n\tv208 = new *([v71 @ X28_v2 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+210])();\n\tSystem.Object::.ctor(v208);\n\t*([v208 @ X0_v11 (System.Object)+10]) = v229;\n\tv226 = this.level;\n\tv210 = System.Collections.Generic.List`1<GoalData>::get_Item(v226.goals, v229);\n\tv337 = v210.count < 1;\n\tif (v337) goto L_0070;\n\tv95 = v210.goalType != 6;\n\tif (v95) goto L_0070;\n\tgoto L_0042;\n\tv359 = System.Xml.ValidateNames;\n\tv360 = v359 + 0x98;\n\tv361 = \"il2cpp_codegen_initialize_runtime_metadata\"(v360, v184, v189, v178, v157, v52, v53, v54, v166, v232, v163, v160, v169, v58, v59, v60);\n\tv362 = 1;\n\t*([2DD4424]) = v362;\n\tgoto L_0042;\nL_00C4:\n\tgoto L_00C6;\n\tv314 = \"il2cpp_codegen_runtime_class_init\"(v307, v182, v188, v178, v157, v52, v53, v54, v166, v232, v163, v160, v169, v58, v59, v60);\nL_00C6:\n\tv316 = Il2CppMethodInfo;\n\tv211 = Singleton`1::get_Instance /* +1 sharing this address */(*([v316 @ X8_v11 (Il2CppMethodInfo)+C90]));\n\tGameManager::CheckWinCondition(v211);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 149 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnCollectOctopus(global::UnityEngine.Vector2 pos)
	{
		//IL_0013: Expected I, but got O
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_0050: Expected O, but got I
		//IL_0060: Expected I, but got O
		//IL_0095: Expected I, but got O
		//IL_00c9: Expected F4, but got O
		//IL_00de: Expected F4, but got I
		Level level = this.level;
		nint num = 0;
		int num2 = 0;
		global::UnityEngine.Vector2 vel = default(global::UnityEngine.Vector2);
		while (true)
		{
			global::System.Collections.Generic.List<GoalData> goals = level.goals;
			if (num2 < goals.Count)
			{
				object obj = new object();
				Level level2 = this.level;
				GoalData goalData = level2.goals[num2];
				if (goalData.count >= 1 && goalData.goalType == GoalType.Octopus)
				{
					nint num3 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v22 (Il2CppClass<System.Xml.ValidateNames>)+98]");
					object obj2 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v24+B8]");
					object obj3 = 0;
					nint num4 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v28 (Il2CppMethodInfo)+88]");
					global::System.Func<global::UnityEngine.Vector2> getTargetPos = null;
					nint num5 = 0;
					nint num6 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v32 (Il2CppMethodInfo)+90]");
					global::System.Action onComplete = null;
					nint num7 = 0;
					vel.x = (float)obj3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v25+4]");
					vel.y = 0f;
					spriteDisplay.AddSprite(goalData.sprite, pos, vel, 0f, getTargetPos, onComplete);
					int count = goalData.count - 1;
					goalData.count = count;
				}
				num2++;
				level = this.level;
				continue;
			}
			break;
		}
		nint num8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		GameManager gameManager = default(GameManager);
		gameManager.CheckWinCondition();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600019B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEC798", Offset = "0xFEC798", Length = "0x278")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0039;\n\tv45 = CollectParticleData[];\n\tv46 = v45 + 0x990;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv67 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv68 = v67 + 8;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv235 = Il2CppMethodInfo;\n\tv236 = v235 + 0xC8;\n\tv237 = \"il2cpp_codegen_initialize_runtime_metadata\"(v236, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv240 = Il2CppMethodInfo;\n\tv241 = v240 + 0xD0;\n\tv242 = \"il2cpp_codegen_initialize_runtime_metadata\"(v241, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv301 = Il2CppMethodInfo;\n\tv302 = v301 + 0xC90;\n\tv303 = \"il2cpp_codegen_initialize_runtime_metadata\"(v302, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv311 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv312 = v311 + 0xA48;\n\tv313 = \"il2cpp_codegen_initialize_runtime_metadata\"(v312, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv318 = Il2CppMethodInfo;\n\tv319 = v318 + 0x98;\n\tv320 = \"il2cpp_codegen_initialize_runtime_metadata\"(v319, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv321 = Il2CppMethodInfo;\n\tv322 = v321 + 0xA0;\n\tv323 = \"il2cpp_codegen_initialize_runtime_metadata\"(v322, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv324 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv325 = v324 + 0x218;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v325, methodInfo, v49, v50, v51, v52, v53, v54, pos, v0, v55, v56, v57, v58, v59, v60);\n\tv64 = 1;\n\t*([302A98A]) = v64;\nL_0039:\n\tv239 = this.level;\n\tv71 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0074;\nL_0042:\n\tv366 = System.Xml.ValidateNames;\n\tv368 = *([v366 @ X8_v22 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv369 = *([v368 @ X8_v24+B8]);\n\tv370 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv373 = new *([v370 @ X8_v26 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+8])();\n\tv374 = Il2CppMethodInfo;\n\tSystem.Func`1<UnityEngine.Vector2>::.ctor(v373, v208, *([v374 @ X8_v28 (Il2CppMethodInfo)+98]));\n\tv379 = CollectParticleData[];\n\tv205 = new *([v379 @ X8_v30 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv382 = Il2CppMethodInfo;\n\tSystem.Action::.ctor(v205, v208, *([v382 @ X8_v32 (Il2CppMethodInfo)+A0]));\n\t// 107 MakeStruct v340 @ AGGFEC900_3_v4 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), [v369 @ X8_v25], [v369 @ X8_v25+4]\n\tSpriteCollectDisplay::AddSprite(this.spriteDisplay, v210.sprite, pos, v340, 0f, v373, v205);\n\tv353 = v210.count - 1;\n\tv210.count = v353;\nL_0070:\n\tv229 = v229 + 1;\n\tv239 = this.level;\nL_0074:\n\tv224 = v239.goals;\n\tv98 = v229 >= v224._size;\n\tif (v98) goto L_00C4;\n\tv208 = new *([v71 @ X28_v2 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+218])();\n\tSystem.Object::.ctor(v208);\n\t*([v208 @ X0_v11 (System.Object)+10]) = v229;\n\tv226 = this.level;\n\tv210 = System.Collections.Generic.List`1<GoalData>::get_Item(v226.goals, v229);\n\tv337 = v210.count < 1;\n\tif (v337) goto L_0070;\n\tv95 = v210.goalType != 8;\n\tif (v95) goto L_0070;\n\tgoto L_0042;\n\tv359 = System.Xml.ValidateNames;\n\tv360 = v359 + 0x98;\n\tv361 = \"il2cpp_codegen_initialize_runtime_metadata\"(v360, v184, v189, v178, v157, v52, v53, v54, v166, v232, v163, v160, v169, v58, v59, v60);\n\tv362 = 1;\n\t*([2DD4424]) = v362;\n\tgoto L_0042;\nL_00C4:\n\tgoto L_00C6;\n\tv314 = \"il2cpp_codegen_runtime_class_init\"(v307, v182, v188, v178, v157, v52, v53, v54, v166, v232, v163, v160, v169, v58, v59, v60);\nL_00C6:\n\tv316 = Il2CppMethodInfo;\n\tv211 = Singleton`1::get_Instance /* +1 sharing this address */(*([v316 @ X8_v11 (Il2CppMethodInfo)+C90]));\n\tGameManager::CheckWinCondition(v211);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 149 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnCollectBee(global::UnityEngine.Vector2 pos)
	{
		//IL_0013: Expected I, but got O
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_0050: Expected O, but got I
		//IL_0060: Expected I, but got O
		//IL_0095: Expected I, but got O
		//IL_00c9: Expected F4, but got O
		//IL_00de: Expected F4, but got I
		Level level = this.level;
		nint num = 0;
		int num2 = 0;
		global::UnityEngine.Vector2 vel = default(global::UnityEngine.Vector2);
		while (true)
		{
			global::System.Collections.Generic.List<GoalData> goals = level.goals;
			if (num2 < goals.Count)
			{
				object obj = new object();
				Level level2 = this.level;
				GoalData goalData = level2.goals[num2];
				if (goalData.count >= 1 && goalData.goalType == GoalType.Bee)
				{
					nint num3 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v366 @ X8_v22 (Il2CppClass<System.Xml.ValidateNames>)+98]");
					object obj2 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v24+B8]");
					object obj3 = 0;
					nint num4 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v374 @ X8_v28 (Il2CppMethodInfo)+98]");
					global::System.Func<global::UnityEngine.Vector2> getTargetPos = null;
					nint num5 = 0;
					nint num6 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v382 @ X8_v32 (Il2CppMethodInfo)+A0]");
					global::System.Action onComplete = null;
					nint num7 = 0;
					vel.x = (float)obj3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v369 @ X8_v25+4]");
					vel.y = 0f;
					spriteDisplay.AddSprite(goalData.sprite, pos, vel, 0f, getTargetPos, onComplete);
					int count = goalData.count - 1;
					goalData.count = count;
				}
				num2++;
				level = this.level;
				continue;
			}
			break;
		}
		nint num8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		GameManager gameManager = default(GameManager);
		gameManager.CheckWinCondition();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600019C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFECA18", Offset = "0xFECA18", Length = "0x250")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_003C;\n\tv49 = CollectParticleData[];\n\tv50 = v49 + 0x990;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv69 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv70 = v69 + 8;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv224 = Il2CppMethodInfo;\n\tv225 = v224 + 0xC8;\n\tv226 = \"il2cpp_codegen_initialize_runtime_metadata\"(v225, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv229 = Il2CppMethodInfo;\n\tv230 = v229 + 0xD0;\n\tv231 = \"il2cpp_codegen_initialize_runtime_metadata\"(v230, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv289 = Il2CppMethodInfo;\n\tv290 = v289 + 0xC90;\n\tv291 = \"il2cpp_codegen_initialize_runtime_metadata\"(v290, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv299 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv300 = v299 + 0xA48;\n\tv301 = \"il2cpp_codegen_initialize_runtime_metadata\"(v300, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv306 = Il2CppMethodInfo;\n\tv307 = v306 + 0xA8;\n\tv308 = \"il2cpp_codegen_initialize_runtime_metadata\"(v307, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv309 = Il2CppMethodInfo;\n\tv310 = v309 + 0xB0;\n\tv311 = \"il2cpp_codegen_initialize_runtime_metadata\"(v310, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv312 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv313 = v312 + 0x220;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v313, methodInfo, v53, v54, v55, v56, v57, v58, pos, v0, vel, v2, v59, v60, v61, v62);\n\tv66 = 1;\n\t*([302A98B]) = v66;\nL_003C:\n\tv228 = this.level;\n\tv73 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_005B;\nL_0053:\n\tSpriteCollectDisplay::AddSprite(this.spriteDisplay, v195.sprite, pos, vel, 0.1f, v346, v196);\n\tv340 = v195.count - 1;\n\tv195.count = v340;\nL_0057:\n\tv216 = v216 + 1;\n\tv228 = this.level;\nL_005B:\n\tv209 = v228.goals;\n\tv102 = v216 >= v209._size;\n\tif (v102) goto L_00B9;\n\tv193 = new *([v73 @ X28_v2 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+220])();\n\tSystem.Object::.ctor(v193);\n\t*([v193 @ X0_v11 (System.Object)+10]) = v216;\n\tv211 = this.level;\n\tv195 = System.Collections.Generic.List`1<GoalData>::get_Item(v211.goals, v216);\n\tv325 = v195.count < 1;\n\tif (v325) goto L_0057;\n\tv103 = v195.goalType != 2;\n\tif (v103) goto L_0057;\n\tv343 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv346 = new *([v343 @ X8_v18 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+8])();\n\tv347 = Il2CppMethodInfo;\n\tSystem.Func`1<UnityEngine.Vector2>::.ctor(v346, v193, *([v347 @ X8_v20 (Il2CppMethodInfo)+A8]));\n\tv352 = CollectParticleData[];\n\tv196 = new *([v352 @ X8_v22 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv355 = Il2CppMethodInfo;\n\tSystem.Action::.ctor(v196, v193, *([v355 @ X8_v24 (Il2CppMethodInfo)+B0]));\n\tv356 = this.spriteDisplay == 0;\n\tv205 = ~v356;\n\tif (v205) goto L_0053;\n\tgoto L_00D5;\nL_00B9:\n\tgoto L_00BB;\n\tv302 = \"il2cpp_codegen_runtime_class_init\"(v295, v181, v170, v166, v163, v56, v57, v58, v178, v222, v175, v219, v187, v60, v61, v62);\nL_00BB:\n\tv304 = Il2CppMethodInfo;\n\tv197 = Singleton`1::get_Instance /* +1 sharing this address */(*([v304 @ X8_v11 (Il2CppMethodInfo)+C90]));\n\tGameManager::CheckWinCondition(v197);\n\treturn;\nL_00D5:\n\tthrow System.NullReferenceException;\n// 146 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnCollectStoneBlock(global::UnityEngine.Vector2 pos, global::UnityEngine.Vector2 vel)
	{
		//IL_0013: Expected I, but got O
		//IL_013b: Expected I, but got O
		//IL_0170: Expected I, but got O
		Level level = this.level;
		nint num = 0;
		int num2 = 0;
		GameManager gameManager = default(GameManager);
		while (true)
		{
			global::System.Collections.Generic.List<GoalData> goals = level.goals;
			if (num2 < goals.Count)
			{
				object obj = new object();
				Level level2 = this.level;
				GoalData goalData = level2.goals[num2];
				if (goalData.count >= 1 && goalData.goalType == GoalType.Stone)
				{
					nint num3 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v347 @ X8_v20 (Il2CppMethodInfo)+A8]");
					global::System.Func<global::UnityEngine.Vector2> getTargetPos = null;
					nint num4 = 0;
					nint num5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v24 (Il2CppMethodInfo)+B0]");
					global::System.Action onComplete = null;
					nint num6 = 0;
					if ((object)spriteDisplay == null)
					{
						break;
					}
					spriteDisplay.AddSprite(goalData.sprite, pos, vel, 0.1f, getTargetPos, onComplete);
					int count = goalData.count - 1;
					goalData.count = count;
				}
				num2++;
				level = this.level;
				continue;
			}
			nint num7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			gameManager.CheckWinCondition();
			return;
		}
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600019D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE971C", Offset = "0xFE971C", Length = "0x2DC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_003D;\n\tv41 = CollectParticleData[];\n\tv42 = v41 + 0x990;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv63 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv64 = v63 + 8;\n\tv65 = \"il2cpp_codegen_initialize_runtime_metadata\"(v64, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv216 = Il2CppMethodInfo;\n\tv217 = v216 + 0xC8;\n\tv218 = \"il2cpp_codegen_initialize_runtime_metadata\"(v217, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv221 = Il2CppMethodInfo;\n\tv222 = v221 + 0xD0;\n\tv223 = \"il2cpp_codegen_initialize_runtime_metadata\"(v222, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv274 = Il2CppMethodInfo;\n\tv275 = v274 + 0x38;\n\tv276 = \"il2cpp_codegen_initialize_runtime_metadata\"(v275, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv282 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv283 = v282 + 0xFD8;\n\tv284 = \"il2cpp_codegen_initialize_runtime_metadata\"(v283, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv289 = Il2CppMethodInfo;\n\tv290 = v289 + 0xC90;\n\tv291 = \"il2cpp_codegen_initialize_runtime_metadata\"(v290, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv292 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv293 = v292 + 0xA48;\n\tv294 = \"il2cpp_codegen_initialize_runtime_metadata\"(v293, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv295 = Il2CppMethodInfo;\n\tv296 = v295 + 0xB8;\n\tv297 = \"il2cpp_codegen_initialize_runtime_metadata\"(v296, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv298 = Il2CppMethodInfo;\n\tv299 = v298 + 0xC0;\n\tv300 = \"il2cpp_codegen_initialize_runtime_metadata\"(v299, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv301 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv302 = v301 + 0x228;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v302, methodInfo, v45, v46, v47, v48, v49, v50, pos, v0, v51, v52, v53, v54, v55, v56);\n\tv60 = 1;\n\t*([302A98C]) = v60;\nL_003D:\n\tv220 = this.level;\n\tv67 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0072;\nL_004C:\n\t// 76 MakeStruct v322 @ AGGFE9818_1_v4 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), pos @ V0 (UnityEngine.Vector2), pos.y (System.Single), 0\n\tUnityEngine.Transform::set_position(v187, v322);\n\tv359 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv362 = new *([v359 @ X8_v24 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+8])();\n\tv363 = Il2CppMethodInfo;\n\tSystem.Func`1<UnityEngine.Vector2>::.ctor(v362, v181, *([v363 @ X8_v26 (Il2CppMethodInfo)+B8]));\n\tv368 = CollectParticleData[];\n\tv371 = new *([v368 @ X8_v28 (Il2CppClass<CollectParticleData[]>)+990])();\n\tv372 = Il2CppMethodInfo;\n\tSystem.Action::.ctor(v371, v181, *([v372 @ X8_v30 (Il2CppMethodInfo)+C0]));\n\tButterfly::Init(v185, pos, v362, v371);\n\tv329 = v183.count - 1;\n\tv183.count = v329;\nL_006E:\n\tv211 = v211 + 1;\n\tv220 = this.level;\nL_0072:\n\tv203 = v220.goals;\n\tv87 = v211 >= v203._size;\n\tif (v87) goto L_00E2;\n\tv181 = new *([v67 @ X27_v2 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+228])();\n\tSystem.Object::.ctor(v181);\n\t*([v181 @ X0_v11 (System.Object)+10]) = v211;\n\tv205 = this.level;\n\tv183 = System.Collections.Generic.List`1<GoalData>::get_Item(v205.goals, v211);\n\tv314 = v183.count < 1;\n\tif (v314) goto L_006E;\n\tv88 = v183.goalType != 7;\n\tif (v88) goto L_006E;\n\tgoto L_00B4;\n\tv335 = \"il2cpp_codegen_runtime_class_init\"(v331, v165, v151, v147, v47, v48, v49, v50, v171, v214, v174, v52, v53, v54, v55, v56);\nL_00B4:\n\tv337 = Il2CppMethodInfo;\n\tv184 = Singleton`1::get_Instance /* +1 sharing this address */(*([v337 @ X8_v17 (Il2CppMethodInfo)+C90]));\n\tgoto L_00C3;\n\tv345 = \"il2cpp_codegen_runtime_class_init\"(v341, v165, v151, v147, v47, v48, v49, v50, v171, v214, v174, v52, v53, v54, v55, v56);\nL_00C3:\n\tv347 = Il2CppMethodInfo;\n\tv185 = UnityEngine.Object::Instantiate /* +1 sharing this address */(*([v184 @ X0_v18+100]), *([v347 @ X8_v22 (Il2CppMethodInfo)+38]));\n\tv350 = UnityEngine.Component::get_transform(v185);\n\tv186 = UnityEngine.Component::get_transform(this);\n\tUnityEngine.Transform::set_parent(v350, v186);\n\tv187 = UnityEngine.Component::get_transform(v185);\n\tv355 = v187 == 0;\n\tv199 = ~v355;\n\tif (v199) goto L_004C;\n\tgoto L_00FC;\nL_00E2:\n\tgoto L_00E4;\n\tv285 = \"il2cpp_codegen_runtime_class_init\"(v278, v163, v150, v147, v47, v48, v49, v50, v171, v214, v174, v52, v53, v54, v55, v56);\nL_00E4:\n\tv287 = Il2CppMethodInfo;\n\tv188 = Singleton`1::get_Instance /* +1 sharing this address */(*([v287 @ X8_v9 (Il2CppMethodInfo)+C90]));\n\tGameManager::CheckWinCondition(v188);\n\treturn;\nL_00FC:\n\tthrow System.NullReferenceException;\n// 165 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnCollectCaterpillar(global::UnityEngine.Vector2 pos)
	{
		//IL_0013: Expected I, but got O
		//IL_006f: Expected I, but got O
		//IL_00a4: Expected I, but got O
		Level level = this.level;
		nint num = 0;
		int num2 = 0;
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
		global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
		GameManager gameManager = default(GameManager);
		while (true)
		{
			global::System.Collections.Generic.List<GoalData> goals = level.goals;
			if (num2 < goals.Count)
			{
				object obj = new object();
				Level level2 = this.level;
				GoalData goalData = level2.goals[num2];
				if (goalData.count >= 1 && goalData.goalType == GoalType.Butterfly)
				{
					nint num3 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
					nint num4 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1171058 (UnityEngine.Object::Instantiate, and 1 more at this address)");
					global::UnityEngine.Transform transform = component.transform;
					global::UnityEngine.Transform parent = base.transform;
					transform.parent = parent;
					global::UnityEngine.Transform transform2 = component.transform;
					if ((object)transform2 == null)
					{
						break;
					}
					position.x = vector.x;
					position.y = pos.y;
					position.z = 0f;
					transform2.position = position;
					nint num5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X8_v26 (Il2CppMethodInfo)+B8]");
					global::System.Func<global::UnityEngine.Vector2> getTargetPos = null;
					nint num6 = 0;
					nint num7 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v372 @ X8_v30 (Il2CppMethodInfo)+C0]");
					global::System.Action onComplete = null;
					nint num8 = 0;
					((Butterfly)component).Init(pos, getTargetPos, onComplete);
					int count = goalData.count - 1;
					goalData.count = count;
				}
				num2++;
				level = this.level;
				continue;
			}
			nint num9 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
			gameManager.CheckWinCondition();
			return;
		}
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600019E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFECC78", Offset = "0xFECC78", Length = "0x268")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0028;\n\tv35 = Il2CppMethodInfo;\n\tv36 = v35 + 0x968;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv58 = Il2CppMethodInfo;\n\tv59 = v58 + 0x970;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv227 = Il2CppMethodInfo;\n\tv228 = v227 + 0x978;\n\tv229 = \"il2cpp_codegen_initialize_runtime_metadata\"(v228, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv233 = Il2CppMethodInfo;\n\tv234 = v233 + 0x998;\n\tv235 = \"il2cpp_codegen_initialize_runtime_metadata\"(v234, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv332 = Il2CppMethodInfo;\n\tv333 = v332 + 0xC28;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v333, ids, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv55 = 1;\n\t*([302A98D]) = v55;\nL_0028:\n\tv57 = v340 == 0;\n\tif (v57) goto L_00BB;\n\tv63 = Il2CppMethodInfo;\n\tv65 = Il2CppMethodInfo;\n\tv67 = Il2CppMethodInfo;\n\tv213 = Il2CppMethodInfo + 0x968;\n\tv73 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(v340);\nL_003D:\n\tv340 = *([v63 @ X23_v4 (Il2CppMethodInfo)+970]);\n\tv320 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v71 @ stack_-A8_v3 (UnityEngine.Vector2), *([v63 @ X23_v4 (Il2CppMethodInfo)+970]));\n\tv334 = v320 & 1;\n\tv335 = v334 == 0;\n\tif (v335) goto L_00A4;\n\tv350 = this.solver == 0;\n\tif (v350) goto L_00B3;\n\tv357 = this.solver + 0x1F8;\n\tv193 = *([v65 @ X24_v4 (Il2CppMethodInfo)+C28]);\n\tv305 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v357, v115, &v290 @ stack_-C4_v6, *([v65 @ X24_v4 (Il2CppMethodInfo)+C28]));\n\tv433 = v305 & 1;\n\tv309 = v433 == 0;\n\tif (v309) goto L_003D;\n\tv496 = this.solver;\n\tv497 = this.solver == 0;\n\tif (v497) goto L_00B7;\n\tv499 = v290 << 3;\n\tv498 = v496.positions + v499;\n\tv510 = v496.velocities + v499;\n\tv317 = this.honeyDisplay;\n\t// 93 MakeStruct v275 @ AGGFECDA0_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v498 @ X10_v6], [v498 @ X10_v6+4]\n\tv512 = Unity.Mathematics.float2::op_Implicit(v275);\n\t// 101 MakeStruct v269 @ AGGFECDB8_0_v5 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v510 @ X8_v15], [v510 @ X8_v15+4]\n\tv207 = Unity.Mathematics.float2::op_Implicit(v269);\n\tv181 = v207.y;\n\tv313 = this.solver;\n\tv310 = this.honeyDisplay == 0;\n\tif (v310) goto L_00B5;\n\tv259 = v317.activeCount >= v317.maxParticles;\n\tif (v259) goto L_003D;\n\tv520 = UnityEngine.Random::Range(v317.minExplodeDuration, v317.maxExplodeDuration);\n\tv307 = FluidCollectDisplay::AddParticle(this.honeyDisplay, v512, v207, v313.honeyFluidType, 1, v520, 0, 0);\n\tgoto L_003D;\nL_00A4:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v71 @ stack_-A8_v3 (UnityEngine.Vector2), *([v67 @ X22_v4 (Il2CppMethodInfo)+968]));\nL_00B2:\n\treturn;\nL_00B3:\n\tv358 = new System.NullReferenceException();\n\tgoto L_00BA;\nL_00B5:\n\tv501 = new System.NullReferenceException();\n\tgoto L_00BA;\nL_00B7:\n\tv502 = new System.NullReferenceException();\n\tgoto L_00BA;\n\tv500 = new System.NullReferenceException();\nL_00BA:\n\t// 186 Interrupt\nL_00BB:\n\tv226 = new System.NullReferenceException();\n\tgoto L_00CE;\n\tgoto L_00CE;\n\tgoto L_00CE;\n\tgoto L_00CE;\n\tgoto L_00CE;\n\tgoto L_00CE;\n\tgoto L_00CE;\n\tgoto L_00CE;\nL_00CE:\n\tv331 = v340 != 1;\n\tif (v331) goto L_00DE;\n\tv337 = 0x274A080(v226, v340, v291, v294, 0, v41, v42, v43, v207, v282, v207, v181, v520, v49, v50, v51);\n\tv354 = 0x274A098(v337, v340, v291, v294, 0, v41, v42, v43, v207, v282, v207, v181, v520, v49, v50, v51);\n\tv340 = *([v213 @ X22_v1]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v71 @ stack_-A8_v3 (UnityEngine.Vector2), *([v213 @ X22_v1]));\n\tv345 = *([v337 @ X0_v11]) == 0;\n\tif (v345) goto L_00B2;\n\tv343 = new System.OutOfMemoryException();\nL_00DE:\n\tv349 = 0xBF092C(&v199 @ stack_-D8 (System.Int32), v340, v291, v294, 0, v41, v42, v43, v207, v282, v207, v181, v520, v49, v50, v51);\n\tv356 = 0x27498DC(v346, v340, v291, v294, 0, v41, v42, v43, v207, v282, v207, v181, v520, v49, v50, v51);\n\tv432 = 0xD6F8(v356, v340, v291, v294, 0, v41, v42, v43, v207, v282, v207, v181, v520, v49, v50, v51);\n\treturn;\n// 137 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnRemoveHoney(global::System.Collections.Generic.HashSet<int> ids)
	{
		//IL_0024: Expected O, but got I
		//IL_03dd: Expected O, but got I
		//IL_02b1: Expected I, but got O
		//IL_03a2: Expected I4, but got O
		//IL_006e: Expected O, but got I
		//IL_007e: Expected O, but got I
		//IL_00ae: Expected I, but got O
		//IL_00be: Expected O, but got I
		//IL_02f5: Expected I, but got O
		//IL_0111: Unknown result type (might be due to invalid IL or missing references)
		//IL_0116: Expected O, but got Unknown
		//IL_0125: Unknown result type (might be due to invalid IL or missing references)
		//IL_012a: Expected O, but got Unknown
		//IL_0143: Expected F4, but got O
		//IL_0158: Expected F4, but got I
		//IL_0172: Expected F4, but got O
		//IL_0187: Expected F4, but got I
		//IL_01ff: Expected I, but got O
		object obj = default(object);
		global::System.Collections.Generic.HashSet<int> hashSet = default(global::System.Collections.Generic.HashSet<int>);
		if (hashSet != null)
		{
			nint num = 0;
			nint num2 = 0;
			nint num3 = 0;
			obj = (nint)0 + (nint)2408;
			global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = hashSet.GetEnumerator();
			global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
			global::UnityEngine.Vector2 vector = vector2;
			object obj2 = default(object);
			global::System.Func<global::UnityEngine.Vector2> func = default(global::System.Func<global::UnityEngine.Vector2>);
			object obj4 = default(object);
			object obj5 = default(object);
			global::System.Collections.Generic.HashSet<int> hashSet2 = default(global::System.Collections.Generic.HashSet<int>);
			global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
			global::Unity.Mathematics.float2 float6 = default(global::Unity.Mathematics.float2);
			float num7 = default(float);
			float num8 = default(float);
			global::System.Func<global::UnityEngine.Vector2> func2;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X23_v4 (Il2CppMethodInfo)+970]");
				hashSet = (global::System.Collections.Generic.HashSet<int>)0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
				if ((int)((nint)obj2 & 1) != 0)
				{
					nint num5;
					if ((object)solver != null)
					{
						object obj3 = (nint)solver + 504;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X24_v4 (Il2CppMethodInfo)+C28]");
						func = (global::System.Func<global::UnityEngine.Vector2>)0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
						int num4 = (int)((nint)obj4 & 1);
						bool flag = num4 == 0;
						num5 = (nint)obj5;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X24_v4 (Il2CppMethodInfo)+C28]");
						func2 = (global::System.Func<global::UnityEngine.Vector2>)0;
						if (!flag)
						{
							FluidSolver fluidSolver = solver;
							if ((object)solver == null)
							{
								global::System.NullReferenceException ex = new global::System.NullReferenceException();
								num5 = (nint)obj5;
								hashSet = hashSet2;
								break;
							}
							int num6 = (int)((nint)obj5 << 3);
							object obj6 = fluidSolver.positions + num6;
							object obj7 = fluidSolver.velocities + num6;
							FluidCollectDisplay fluidCollectDisplay = honeyDisplay;
							float5.x = (float)obj6;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v498 @ X10_v6+4]");
							float5.y = 0f;
							global::UnityEngine.Vector2 vector3 = float5;
							float6.x = (float)obj7;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v15+4]");
							float6.y = 0f;
							global::UnityEngine.Vector2 vector4 = float6;
							num7 = vector4.y;
							FluidSolver fluidSolver2 = solver;
							if ((object)honeyDisplay == null)
							{
								global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
								num7 = num8;
								func = func;
								vector4 = vector;
								break;
							}
							bool flag2 = fluidCollectDisplay.activeCount >= fluidCollectDisplay.maxParticles;
							num8 = num7;
							num5 = (nint)obj5;
							func2 = func;
							vector = vector4;
							if (!flag2)
							{
								float explodeDuration = global::UnityEngine.Random.Range(fluidCollectDisplay.minExplodeDuration, fluidCollectDisplay.maxExplodeDuration);
								CollectParticleData collectParticleData = honeyDisplay.AddParticle(vector3, vector4, fluidSolver2.honeyFluidType, CollectParticleMode.Explode, explodeDuration);
								num8 = vector3.y;
								num5 = 1;
								func2 = null;
								vector = vector3;
							}
						}
						continue;
					}
					global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
					num5 = (nint)obj5;
					hashSet = hashSet2;
					break;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				return;
			}
			num8 = num7;
			func2 = func;
			int num9 = 0;
		}
		global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
		bool flag3 = (nint)hashSet != 1;
		global::System.NullReferenceException ex5 = ex4;
		if (!flag3)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			hashSet = (global::System.Collections.Generic.HashSet<int>)obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj8 = default(object);
			if (obj8 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex6 = new global::System.OutOfMemoryException();
			int num9 = (int)obj8;
			ex5 = (global::System.NullReferenceException)(object)ex6;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600019F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFECEE0", Offset = "0xFECEE0", Length = "0xA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = *([302A98E]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0028;\n\tv51 = Il2CppMethodInfo + 0xC78;\n\tv24 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A40]);\n\tv26 = *([v24 @ X0_v13+E0]) == 0;\n\tif (v26) goto L_003A;\nL_001F:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v51 @ X21_v6]));\n\treturn;\nL_0028:\n\t*([v16 @ X21_v1+98E]) = 1;\n\tv51 = Il2CppMethodInfo + 0xC78;\n\tv46 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A40]);\n\tv79 = *([v46 @ X0_v10+E0]) == 0;\n\tv48 = ~v79;\n\tif (v48) goto L_001F;\nL_003A:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v64 @ X21_v2]));\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public CollectionManager()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00b0: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		object obj = 50503680;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A98E]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)3192;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A40]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X0_v13+E0]");
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
			object obj2 = (nint)0 + (nint)3192;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A40]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v10+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			if (flag3)
			{
				goto IL_0093;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
		return;
		IL_0093:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
	}
}
