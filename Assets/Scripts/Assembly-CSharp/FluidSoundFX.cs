[global::Cpp2ILInjected.Token(Token = "0x20000A2")]
public class FluidSoundFX : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.Header("Audio")]
	[global::Cpp2ILInjected.Token(Token = "0x4000377")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.AudioClip clip;

	[global::UnityEngine.Range(0f, 1f)]
	[global::Cpp2ILInjected.Token(Token = "0x4000378")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float masterVolume;

	[global::UnityEngine.Range(0f, 2f)]
	[global::Cpp2ILInjected.Token(Token = "0x4000379")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float pitch;

	[global::UnityEngine.Range(0f, 1f)]
	[global::Cpp2ILInjected.Token(Token = "0x400037A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float pitchVariance;

	[global::UnityEngine.Header("Braking-impulse filter")]
	[global::Cpp2ILInjected.Token(Token = "0x400037B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float minBrakingImpulse;

	[global::Cpp2ILInjected.Token(Token = "0x400037C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float maxBrakingImpulse;

	[global::UnityEngine.Range(0f, 1f)]
	[global::Cpp2ILInjected.Token(Token = "0x400037D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float smoothing;

	[global::Cpp2ILInjected.Token(Token = "0x400037E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private FluidSolver solver;

	[global::Cpp2ILInjected.Token(Token = "0x400037F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::Unity.Mathematics.float2[] smoothedVel;

	[global::Cpp2ILInjected.Token(Token = "0x4000380")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private float loudest;

	[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
	[global::Cpp2ILInjected.Address(RVA = "0x100973C", Offset = "0x100973C", Length = "0x140")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv268 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression> + 0xA48;\n\tv24 = *([302AA43]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_0059;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv28 = *([v22 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv269 = *([v28 @ X0_v35+E0]);\n\tv30 = *([v28 @ X0_v35+E0]) == 0;\n\tif (v30) goto L_0063;\nL_0019:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v124 @ X21_v12]));\nL_001D:\n\tv182 = CollectParticleData[];\n\tv183 = Il2CppMethodInfo;\n\tv268 = v175 + 0x90;\n\tv185 = new *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v185, this, *([v183 @ X24_v8 (Il2CppMethodInfo)+590]));\n\tv232 = System.Delegate::Combine(*([v268 @ X20_v3]), v185);\n\tv79 = v232 == 0;\n\tif (v79) goto L_0068;\n\tv32 = *([v232 @ X0_v29 (System.Delegate)]) != *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v32) goto L_FFFFFFFF;\n\t*([v268 @ X20_v3]) = v232;\n\tv251 = *([v232 @ X0_v29 (System.Delegate)]) == *([v182 @ X23_v8 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v251) goto L_0074;\n\tthrow System.InvalidCastException;\nL_0059:\n\t*([v84 @ X21_v7 (System.Delegate)+A43]) = 1;\n\tv124 = Il2CppMethodInfo + 0xC90;\n\tv118 = *([v268 @ X20_v3]);\n\tv269 = *([v118 @ X0_v24+E0]);\n\tv239 = *([v118 @ X0_v24+E0]) == 0;\n\tv120 = ~v239;\n\tif (v120) goto L_0019;\nL_0063:\n\tv175 = Singleton`1::get_Instance /* +1 sharing this address */(*([v148 @ X21_v6]));\n\tv208 = v175 == 0;\n\tv177 = ~v208;\n\tif (v177) goto L_001D;\n\tthrow System.NullReferenceException;\nL_0068:\n\t*([v268 @ X20_v3]) = 0;\nL_0074:\n\tv281 = 0xF3F1B4(v268, v269, v262, v260, v89, v90, v91, v92, v93, v94, v95, v96, v97, v98, v99, v100);\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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
		object obj = typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>) + 2632;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA43]");
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
		nint num3 = (nint)typeof(CollectParticleData[]);
		nint num4 = 0;
		obj = (nint)obj8 + 144;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v183 @ X24_v8 (Il2CppMethodInfo)+590]");
		global::System.Action b = new global::System.Action(this, (global::System.IntPtr)0);
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

	[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
	[global::Cpp2ILInjected.Address(RVA = "0x100987C", Offset = "0x100987C", Length = "0x1B4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = 0x302A000;\n\tv26 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv28 = *([302AA44]) & 1;\n\tv29 = v28 == 0;\n\tif (v29) goto L_0030;\n\tv59 = Il2CppMethodInfo + 0xC90;\n\tv32 = *([v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv34 = *([v32 @ X0_v45+E0]) == 0;\n\tif (v34) goto L_003A;\nL_001B:\n\tv78 = Singleton`1::get_Instance /* +1 sharing this address */(*([v59 @ X21_v10]));\n\tv71 = v78 == 0;\n\tv72 = ~v71;\n\tif (v72) goto L_003F;\n\tgoto L_0098;\nL_0030:\n\t*([v24 @ X21_v1+A44]) = 1;\n\tv59 = Il2CppMethodInfo + 0xC90;\n\tv54 = *([v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]);\n\tv198 = *([v54 @ X0_v41+E0]) == 0;\n\tv56 = ~v198;\n\tif (v56) goto L_001B;\nL_003A:\n\tv78 = Singleton`1::get_Instance /* +1 sharing this address */(*([v66 @ X21_v7]));\nL_003F:\n\tv85 = this + 0x40;\n\tthis.solver = *([v78 @ X0_v6+30]);\n\tv87 = 0xF3F1B4(v85, *([v78 @ X0_v6+30]), v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv146 = this.solver;\n\tv192 = CollectParticleData[];\n\tv193 = Il2CppMethodInfo;\n\tv149 = this.solver + 0x470;\n\tv195 = new *([v192 @ X24_v3 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v195, this, *([v193 @ X25_v3 (Il2CppMethodInfo)+588]));\n\tv183 = System.Delegate::Combine(v146.OnStep, v195);\n\tv185 = v183 == 0;\n\tif (v185) goto L_0090;\n\tv155 = *([v183 @ X0_v12 (System.Delegate)]) != *([v192 @ X24_v3 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v155) goto L_009A;\n\tv146.OnStep = v183;\n\tv93 = *([v183 @ X0_v12 (System.Delegate)]) != *([v192 @ X24_v3 (Il2CppClass<CollectParticleData[]>)+990]);\n\tif (v93) goto L_009A;\n\tv138 = 0xF3F1B4(v149, v183, 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv244 = this.solver;\nL_007A:\n\tv261 = CollectParticleData[];\n\tv264 = \"SzArrayNew\"(*([v261 @ X9_v4 (Il2CppClass<CollectParticleData[]>)+718]), v244.maxParticles, 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv265 = this + 0x48;\n\tthis.smoothedVel = v264;\n\tv238 = 0xF3F1B4(v265, v264, 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\treturn;\nL_0090:\n\tv146.OnStep = 0;\n\tv137 = 0xF3F1B4(v149, v183, 0, 0, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52);\n\tv244 = this.solver;\n\tv256 = this.solver == 0;\n\tv140 = ~v256;\n\tif (v140) goto L_007A;\nL_0098:\n\tthrow System.NullReferenceException;\nL_009A:\n\tthrow System.InvalidCastException;\n// 102 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnInit()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00dc: Expected O, but got I
		//IL_00ec: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_013f: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_0178: Expected I, but got O
		//IL_018f: Expected O, but got I
		//IL_0260: Expected I, but got O
		//IL_0276: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA44]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)3216;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X0_v45+E0]");
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
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A48]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X0_v41+E0]");
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
		IL_0252:
		nint num2 = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		global::Unity.Mathematics.float2[] array = default(global::Unity.Mathematics.float2[]);
		smoothedVel = array;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return;
		IL_02d8:
		throw new global::System.NullReferenceException();
		IL_0133:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v6+30]");
		solver = (FluidSolver)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		FluidSolver fluidSolver = solver;
		nint num3 = (nint)typeof(CollectParticleData[]);
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v193 @ X25_v3 (Il2CppMethodInfo)+588]");
		global::System.Action b = new global::System.Action(this, (global::System.IntPtr)0);
		global::System.Delegate obj9 = global::System.Delegate.Combine(fluidSolver.OnStep, b);
		FluidSolver fluidSolver2;
		if ((object)obj9 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X24_v3 (Il2CppClass<CollectParticleData[]>)+990]");
			if ((object)obj9 == null)
			{
				fluidSolver.OnStep = (global::System.Action)obj9;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v192 @ X24_v3 (Il2CppClass<CollectParticleData[]>)+990]");
				if ((object)obj9 == null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					fluidSolver2 = solver;
					goto IL_0252;
				}
			}
			throw new global::System.InvalidCastException();
		}
		fluidSolver.OnStep = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		fluidSolver2 = solver;
		if ((object)solver != null)
		{
			goto IL_0252;
		}
		goto IL_02d8;
		IL_0093:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		object obj10 = default(object);
		if (obj10 != null)
		{
			goto IL_0133;
		}
		goto IL_02d8;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
	[global::Cpp2ILInjected.Address(RVA = "0x1009A30", Offset = "0x1009A30", Length = "0x1D0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv197 = this.solver;\n\tv37 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_002C;\nL_001E:\n\tv157 = v157 + 1;\n\tv197 = this.solver;\nL_002C:\n\tv101 = v157 >= v197.maxParticles;\n\tif (v101) goto L_0110;\n\tv91 = UnityEngine.Random::get_value();\n\tv134 = v91 < 0.25f;\n\tif (v134) goto L_001E;\n\tv86 = this.solver;\n\tv342 = v86.powerUpIds;\n\tv337 = *([v342 @ X8_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v157 @ X21_v4 (System.Int32)*4]) + 1;\n\tv129 = v337 == 0;\n\tv102 = ~v129;\n\tif (v102) goto L_001E;\n\tv260 = this.smoothedVel;\n\tv82 = v157 << 3;\n\tv77 = this.smoothedVel + v82;\n\tv87 = v86.velocities;\n\tv67 = *([v87 @ X9_v5 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v82 @ X10_v5 (System.Int32)]) - *([v77 @ X11_v4+20]);\n\tv346 = v67 * v347;\n\tv62 = *([v77 @ X11_v4+20]) + v346;\n\tv58 = v62 - *([v77 @ X11_v4+20]);\n\t// 95 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv103 = *([v77 @ X11_v4+20]) >= 0;\n\tif (v103) goto L_0092;\n\tv351 = *([2DD4420]) == 0;\n\tif (v351) goto L_007A;\n\tv357 = *([v37 @ X20_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv359 = *([v357 @ X0_v15+E0]) == 0;\n\tif (v359) goto L_0081;\nL_0073:\n\tv260 = this.smoothedVel;\n\tv368 = this.smoothedVel == 0;\n\tv163 = ~v368;\n\tif (v163) goto L_0084;\n\tgoto L_0111;\nL_007A:\n\t*([2DD4420]) = 1;\n\tv363 = *([v37 @ X20_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv372 = *([v363 @ X0_v13+E0]) == 0;\n\tv365 = ~v372;\n\tif (v365) goto L_0073;\nL_0081:\n\tv260 = this.smoothedVel;\nL_0084:\n\tv390 = v58 * v58;\n\t// 133 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv220 = UnityEngine.Mathf::Sqrt(v390);\nL_0092:\n\tv314 = v157 << 3;\n\tv340 = v260 + v314;\n\t*([v340 @ X8_v10+20]) = v62;\n\tv330 = v220 < this.minBrakingImpulse;\n\tif (v330) goto L_001E;\n\tv373 = v220 - this.minBrakingImpulse;\n\tv374 = this.maxBrakingImpulse - this.minBrakingImpulse;\n\tv454 = v373 / v374;\n\tv377 = v454 & 0x7FFFFFFF;\n\tv378 = v377 < 0x7F800000;\n\tv379 = ~v378;\n\tv380 = v377 - 0x7F800000;\n\tv382 = v380 == 0;\n\tv387 = ~v379;\n\tv388 = v387 | v382;\n\tv389 = ~v388;\n\tif (v389) goto L_FFFFFFFF;\n\tv393 = v454 - 1f;\n\tv409 = v393 < 0;\n\tv408 = v393 == 0;\n\tv396 = v454 ^ 1f;\n\tv397 = v454 ^ v393;\n\tv398 = v396 & v397;\n\tv404 = v398 < 0;\n\tgoto L_00C2;\nL_00C2:\n\tv412 = v409 == v404;\n\tv312 = ~v408;\n\tv413 = v412 & v312;\n\tv414 = ~v413;\n\tif (v414) goto L_00CC;\n\tgoto L_00CC;\nL_00CC:\n\tv341 = v454 & 0x7FFFFFFF;\n\tv419 = v341 < 0x7F800000;\n\tv420 = ~v419;\n\tv421 = v341 - 0x7F800000;\n\tv423 = v421 == 0;\n\tv428 = ~v420;\n\tv429 = v428 | v423;\n\tv430 = ~v429;\n\tif (v430) goto L_FFFFFFFF;\n\tv449 = v454 < 0;\n\tgoto L_00E9;\nL_00E9:\n\tv313 = ~v449;\n\tif (v313) goto L_00F0;\n\tgoto L_00F0;\nL_00F0:\n\tv318 = this.masterVolume * v454;\n\tv319 = v318 <= this.loudest;\n\tif (v319) goto L_001E;\n\tthis.loudest = v318;\n\tgoto L_001E;\nL_0110:\n\treturn;\nL_0111:\n\tv171 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n// 177 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnFluidStep()
	{
		//IL_001d: Expected I, but got O
		//IL_00c6: Expected O, but got I
		//IL_011b: Expected O, but got I
		//IL_0145: Expected O, but got I
		//IL_0154: Expected O, but got I
		//IL_016a: Expected O, but got I
		//IL_0180: Expected O, but got I
		//IL_02ea: Expected O, but got I
		//IL_034b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected I4, but got Unknown
		//IL_0264: Expected O, but got I
		//IL_01f0: Expected O, but got I
		//IL_03f8: Expected O, but got F4
		//IL_0405: Expected O, but got F4
		//IL_04f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f9: Expected I4, but got Unknown
		FluidSolver fluidSolver = solver;
		int num2 = 0;
		object obj5 = default(object);
		while (true)
		{
			if (num2 >= fluidSolver.maxParticles)
			{
				return;
			}
			float value = global::UnityEngine.Random.value;
			if (value < 0.25f)
			{
				goto IL_002b;
			}
			FluidSolver fluidSolver2 = solver;
			global::Unity.Collections.NativeArray<int> powerUpIds = fluidSolver2.powerUpIds;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v6 (Unity.Collections.NativeArray`1<System.Int32>)+v157 @ X21_v4 (System.Int32)*4]");
			object obj = (nint)0 + (nint)1;
			if (obj != null)
			{
				goto IL_002b;
			}
			global::Unity.Mathematics.float2[] array = smoothedVel;
			int num3 = num2 << 3;
			object obj2 = (nint)smoothedVel + num3;
			global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> velocities = fluidSolver2.velocities;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X9_v5 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v82 @ X10_v5 (System.Int32)]");
			nint num4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X11_v4+20]");
			object obj3 = num4 - 0;
			object obj4 = (nint)obj3 * (nint)obj5;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X11_v4+20]");
			object obj6 = 0 + (nint)obj4;
			nint num5 = (nint)obj6;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X11_v4+20]");
			object obj7 = num5 - 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X11_v4+20]");
			bool flag = (nint)0 >= (nint)0;
			float num6 = 0f;
			if (!flag)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4420]");
				if ((nint)0 != 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X20_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
					object obj8 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v357 @ X0_v15+E0]");
					if ((nint)0 != 0)
					{
						goto IL_0215;
					}
				}
				else
				{
					_ = 1;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v37 @ X20_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
					object obj9 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v363 @ X0_v13+E0]");
					if ((nint)0 != 0)
					{
						goto IL_0215;
					}
				}
				array = smoothedVel;
				goto IL_02a3;
			}
			goto IL_02ce;
			IL_02ce:
			int num7 = num2 << 3;
			object obj10 = (nint)array + num7;
			if (!(num6 < minBrakingImpulse))
			{
				float num8 = num6 - minBrakingImpulse;
				float num9 = maxBrakingImpulse - minBrakingImpulse;
				float num10 = num8 / num9;
				int num11 = num10 & 0x7FFFFFFF;
				bool flag2 = num11 < 2139095040;
				bool flag3 = !flag2;
				int num12 = num11 - 2139095040;
				bool flag4 = num12 == 0;
				bool flag5 = !flag3;
				bool flag6;
				bool flag7;
				bool flag8;
				if (flag5 || flag4)
				{
					float num13 = num10 - 1f;
					flag6 = num13 < 0f;
					flag7 = num13 == 0f;
					object obj11 = num10 ^ 1f;
					object obj12 = num10 ^ num13;
					int num14 = (int)((nint)obj11 & (nint)obj12);
					flag8 = num14 < 0;
				}
				else
				{
					flag8 = false;
					flag7 = false;
					flag6 = false;
				}
				bool flag9 = flag6 == flag8;
				bool flag10 = !flag7;
				if (flag9 && flag10)
				{
					num10 = 1f;
				}
				int num15 = num10 & 0x7FFFFFFF;
				bool flag11 = num15 < 2139095040;
				bool flag12 = !flag11;
				int num16 = num15 - 2139095040;
				bool flag13 = num16 == 0;
				bool flag14 = !flag12;
				if (!(flag14 || flag13) || num10 < 0f)
				{
					num10 = 0f;
				}
				float num17 = masterVolume * num10;
				if (num17 > loudest)
				{
					loudest = num17;
				}
			}
			goto IL_002b;
			IL_002b:
			num2++;
			fluidSolver = solver;
			continue;
			IL_02a3:
			float f = (float)obj7 * (float)obj7;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			num6 = global::UnityEngine.Mathf.Sqrt(f);
			goto IL_02ce;
			IL_0215:
			array = smoothedVel;
			if (smoothedVel == null)
			{
				break;
			}
			goto IL_02a3;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		throw new global::System.IndexOutOfRangeException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
	[global::Cpp2ILInjected.Address(RVA = "0x1009C00", Offset = "0x1009C00", Length = "0xE8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0026;\n\tv21 = CollectParticleData[];\n\tv22 = v21 + 0xCF8;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv56 = Il2CppMethodInfo;\n\tv57 = v56 + 0xC70;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv94 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv95 = v94 + 0xA38;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v95, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AA45]) = v42;\nL_0026:\n\tv55 = this.loudest <= 0;\n\tif (v55) goto L_0052;\n\tv61 = Il2CppMethodInfo;\n\tv63 = CollectParticleData[];\n\tgoto L_0035;\n\tv96 = \"il2cpp_codegen_runtime_class_init\"(v65, methodInfo, v25, v26, v27, v28, v29, v30, v43, v32, v33, v34, v35, v36, v37, v38);\nL_0035:\n\tv99 = Singleton`1::get_Instance /* +1 sharing this address */(*([v61 @ X20_v4 (Il2CppMethodInfo)+C70]));\n\tv118 = new *([v63 @ X22_v3 (Il2CppClass<CollectParticleData[]>)+CF8])();\n\tAudioClipSettings::.ctor(v118);\n\tv119 = v118 == 0;\n\tif (v119) goto L_0053;\n\tv118.volume = this.loudest;\n\tv118.pitch = this.pitch;\n\tv84 = v99 == 0;\n\tif (v84) goto L_0053;\n\tAudioManager::PlayClip(v99, this.clip, v118);\n\tthis.loudest = 0f;\nL_0052:\n\treturn;\nL_0053:\n\tthrow v118;\n// 54 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Update()
	{
		//IL_0019: Expected I, but got O
		if (!(loudest > 0f))
		{
			return;
		}
		nint num = 0;
		nint num2 = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		AudioClipSettings audioClipSettings = new AudioClipSettings();
		if (audioClipSettings != null)
		{
			audioClipSettings.volume = loudest;
			audioClipSettings.pitch = pitch;
			AudioManager audioManager = default(AudioManager);
			if ((object)audioManager != null)
			{
				audioManager.PlayClip(clip, audioClipSettings);
				loudest = 0f;
				return;
			}
		}
		throw audioClipSettings;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
	[global::Cpp2ILInjected.Address(RVA = "0x1009CE8", Offset = "0x1009CE8", Length = "0x20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.masterVolume = *([2875A40]);\n\tthis.maxBrakingImpulse = 3.0517585585698725E-05d;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 5 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FluidSoundFX()
	{
		//IL_0018: Expected F4, but got I
		base._002Ector();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2875A40]");
		masterVolume = 0f;
		maxBrakingImpulse = 20f;
		smoothing = 0.5f;
	}
}
