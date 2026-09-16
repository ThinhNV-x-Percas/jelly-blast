[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.CanvasGroup))]
[global::Cpp2ILInjected.Token(Token = "0x2000006")]
public class Viewport : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x2000007")]
	public enum TransitionType
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		Scale = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		Slide = 1
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000024")]
	private static global::System.Collections.Generic.Dictionary<global::System.Type, Viewport> m_Viewports;

	[global::Cpp2ILInjected.Token(Token = "0x4000025")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public EasingFunction.Ease ease;

	[global::Cpp2ILInjected.Token(Token = "0x4000026")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public bool ShouldAnimate;

	[global::Cpp2ILInjected.Token(Token = "0x4000027")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.RectTransform main;

	[global::Cpp2ILInjected.Token(Token = "0x4000028")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float mainTransitionScaleDelta;

	[global::Cpp2ILInjected.Token(Token = "0x4000029")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private float transitionFadeRange;

	[global::Cpp2ILInjected.Token(Token = "0x400002A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Viewport.TransitionType transitionType;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400002B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	protected bool m_VisibleAtStart;

	[global::Cpp2ILInjected.Token(Token = "0x400002C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D")]
	private bool m_IsShow;

	[global::Cpp2ILInjected.Token(Token = "0x400002D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private global::BFS.Essential.Tween m_TShowHide;

	[global::Cpp2ILInjected.Token(Token = "0x400002E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::UnityEngine.CanvasGroup m_CanvasGroup;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x400002F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float interp;

	[global::Cpp2ILInjected.Token(Token = "0x17000002")]
	public global::UnityEngine.CanvasGroup CanvasGroup
	{
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0xFD5238", Offset = "0xFD5238", Length = "0xE8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302A8CE]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_002E;\n\tv85 = this + 0x48;\n\tv25 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv27 = *([v25 @ X0_v23+E0]) == 0;\n\tif (v27) goto L_003B;\nL_001A:\n\tv59 = UnityEngine.Object::op_Equality(v48, 0);\n\tv69 = ~v59;\n\tv70 = ~v69;\n\tif (v70) goto L_003E;\nL_0026:\n\treturn *([v85 @ X20_v7]);\nL_002E:\n\t*([v16 @ X20_v1+8CE]) = 1;\n\tv85 = this + 0x48;\n\tv47 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv77 = *([v47 @ X0_v17+E0]) == 0;\n\tv51 = ~v77;\n\tif (v51) goto L_001A;\nL_003B:\n\tv74 = UnityEngine.Object::op_Equality(v61, 0);\n\tv83 = ~v74;\n\tif (v83) goto L_0026;\nL_003E:\n\tv100 = Il2CppMethodInfo;\n\tv104 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v100 @ X8_v3 (Il2CppMethodInfo)+610]));\n\tthis.m_CanvasGroup = v104;\n\tv125 = 0xF3F1B4(v99, v104, v93, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\treturn *([v99 @ X20_v2]);\n// 52 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected I, but got O
			//IL_0101: Expected O, but got I
			//IL_0111: Expected O, but got I
			//IL_00d4: Expected O, but got I4
			//IL_0056: Expected O, but got I
			//IL_0066: Expected O, but got I
			//IL_018c: Expected O, but got I4
			object obj = 50503680;
			nint num = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A8CE]");
			object obj2;
			global::UnityEngine.Object canvasGroup;
			global::UnityEngine.Object canvasGroup2;
			object obj4;
			if ((uint)((nuint)0u & (nuint)1u) != 0)
			{
				obj2 = (nint)this + 72;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X0_v23+E0]");
				bool flag = (nint)0 == 0;
				canvasGroup = m_CanvasGroup;
				canvasGroup2 = m_CanvasGroup;
				obj4 = obj2;
				if (!flag)
				{
					goto IL_00a7;
				}
			}
			else
			{
				_ = 1;
				obj2 = (nint)this + 72;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v17+E0]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				canvasGroup = m_CanvasGroup;
				canvasGroup2 = m_CanvasGroup;
				obj4 = obj2;
				if (flag3)
				{
					goto IL_00a7;
				}
			}
			bool flag4 = canvasGroup2 == null;
			bool flag5 = !flag4;
			obj2 = obj4;
			object obj6 = 0;
			if (flag5)
			{
				goto IL_00ea;
			}
			goto IL_019a;
			IL_00ea:
			return (global::UnityEngine.CanvasGroup)obj2;
			IL_019a:
			nint num2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
			global::UnityEngine.CanvasGroup canvasGroup3 = default(global::UnityEngine.CanvasGroup);
			m_CanvasGroup = canvasGroup3;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			return (global::UnityEngine.CanvasGroup)obj4;
			IL_00a7:
			bool flag6 = canvasGroup == null;
			bool flag7 = !flag6;
			bool flag8 = !flag7;
			obj6 = 0;
			obj4 = obj2;
			if (!flag8)
			{
				goto IL_00ea;
			}
			goto IL_019a;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x17000003")]
	public bool IsShow
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000050")]
		[global::Cpp2ILInjected.Address(RVA = "0xFD5320", Offset = "0xFD5320", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.m_IsShow;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			return IsShow;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600004E")]
	[global::Cpp2ILInjected.Address(RVA = "0x11CDAA4", Offset = "0x11CDAA4", Length = "0xF4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0019;\n\tgoto L_0019;\nL_0019:\n\tv43 = System.Xml.ValidateNames;\n\tv62 = *([v43 @ X20_v6 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tgoto L_0022;\n\tv60 = \"il2cpp_codegen_runtime_class_init\"(v54, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36);\n\tv63 = *([v52 @ X20_v5]);\nL_0022:\n\tv66 = *([v62 @ X0_v1+B8]);\n\tgoto L_0030;\n\tv78 = \"il2cpp_codegen_runtime_class_init\"(v72, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36);\nL_0030:\n\tv82 = System.Type::GetTypeFromHandle(Il2CppClass<t>);\n\tv91 = System.Collections.Generic.Dictionary`2<System.Object, System.Object>::get_Item(*([v66 @ X8_v3]), v82);\n\treturnVal2 = UnityEngine.Component::GetComponent(v91);\n\treturn returnVal2;\n\tv85 = 0xF705D0(methodInfo, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36);\n\tv99 = System.Xml.ValidateNames;\n\tv62 = *([v99 @ X20_v8 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tgoto L_0022;\n\tgoto L_FFFFFFFF;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 61 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static t GetViewport<t>() where t : Viewport
	{
		//IL_0018: Expected I, but got O
		//IL_0028: Expected O, but got I
		//IL_00a6: Expected O, but got I
		nint num = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X20_v6 (Il2CppClass<System.Xml.ValidateNames>)+198]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+B8]");
		object obj2 = 0;
		global::System.Type typeFromHandle = typeof(t);
		global::UnityEngine.Component component = (global::UnityEngine.Component)((global::System.Collections.Generic.Dictionary<object, object>)obj2)[(object)typeFromHandle];
		return component.GetComponent<t>();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000051")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5328", Offset = "0xFD5328", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	protected virtual void OnStartHide()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000052")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD532C", Offset = "0xFD532C", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	protected virtual void OnEndHide()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000053")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5330", Offset = "0xFD5330", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	protected internal virtual void OnStartShow()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000054")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5334", Offset = "0xFD5334", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	protected virtual void OnEndShow()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000055")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5338", Offset = "0xFD5338", Length = "0x4C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = this + 0x40;\n\tv13 = this.m_TShowHide;\n\tv14 = this.m_TShowHide == 0;\n\tif (v14) goto L_001F;\n\tv15 = *([v13 @ X0_v1 (BFS.Essential.Tween)]);\n\tv19 = BFS.Essential.Tween::Kill(this.m_TShowHide, 0);\n\tthis.m_TShowHide = 0;\n\tv39 = 0xF3F1B4(v12, 0, *([v15 @ X8_v1 (Il2CppClass<BFS.Essential.Tween>)+1B0]), v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32);\n\treturn;\nL_001F:\n\treturn;\n// 22 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void StopFadeTask()
	{
		//IL_000c: Expected O, but got I
		//IL_003d: Expected I, but got O
		object obj = (nint)this + 64;
		global::BFS.Essential.Tween tShowHide = m_TShowHide;
		if (m_TShowHide != null)
		{
			nint num = (nint)tShowHide;
			m_TShowHide.Kill();
			m_TShowHide = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000056")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5384", Offset = "0xFD5384", Length = "0x46C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv36 = Sponge+<>c__DisplayClass7_0;\n\tgoto L_0035;\n\tv41 = System.Collections.Generic.NullableComparer`1;\n\tv42 = v41 + 0xD40;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, on, callback, methodInfo, v45, v46, v47, v48, duration, v49, v50, v51, v52, v53, v54, v55);\n\tv62 = CollectParticleData[];\n\tv63 = v62 + 0x990;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, on, callback, methodInfo, v45, v46, v47, v48, duration, v49, v50, v51, v52, v53, v54, v55);\n\tv67 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv68 = v67 + 0x2E8;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, on, callback, methodInfo, v45, v46, v47, v48, duration, v49, v50, v51, v52, v53, v54, v55);\n\tv71 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv72 = v71 + 0xFD8;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, on, callback, methodInfo, v45, v46, v47, v48, duration, v49, v50, v51, v52, v53, v54, v55);\n\tv256 = Il2CppMethodInfo;\n\tv257 = v256 + 0x5E0;\n\tv258 = \"il2cpp_codegen_initialize_runtime_metadata\"(v257, on, callback, methodInfo, v45, v46, v47, v48, duration, v49, v50, v51, v52, v53, v54, v55);\n\tv263 = Il2CppMethodInfo;\n\tv264 = v263 + 0x5E8;\n\tv265 = \"il2cpp_codegen_initialize_runtime_metadata\"(v264, on, callback, methodInfo, v45, v46, v47, v48, duration, v49, v50, v51, v52, v53, v54, v55);\n\tv340 = Il2CppMethodInfo;\n\tv341 = v340 + 0x5F0;\n\tv342 = \"il2cpp_codegen_initialize_runtime_metadata\"(v341, on, callback, methodInfo, v45, v46, v47, v48, duration, v49, v50, v51, v52, v53, v54, v55);\n\tv369 = Sponge+<>c__DisplayClass7_0;\n\tv370 = v369 + 0x6A0;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v370, on, callback, methodInfo, v45, v46, v47, v48, duration, v49, v50, v51, v52, v53, v54, v55);\n\tv59 = 1;\n\t*([302A8CF]) = v59;\nL_0035:\n\tv61 = new *([v36 @ X23_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+6A0])();\n\tSystem.Object::.ctor(v61);\n\tv75 = v61 + 0x10;\n\t*([v61 @ X0_v3 (System.Object)+10]) = this;\n\tv77 = 0xF3F1B4(v75, this, v192, methodInfo, v45, v46, v47, v48, duration, v49, v106, v96, v82, v53, v54, v55);\n\tv260 = v61 + 0x20;\n\t*([v61 @ X0_v3 (System.Object)+20]) = v192;\n\t*([v61 @ X0_v3 (System.Object)+18]) = on;\n\tv262 = 0xF3F1B4(v260, v192, v192, methodInfo, v45, v46, v47, v48, duration, v49, v106, v96, v82, v53, v54, v55);\n\tv249 = this + 0x40;\n\tv267 = this.m_TShowHide;\n\tv268 = this.m_TShowHide == 0;\n\tif (v268) goto L_0055;\n\tv343 = *([v267 @ X0_v12 (BFS.Essential.Tween)]);\n\tv347 = BFS.Essential.Tween::Kill(this.m_TShowHide, 0);\n\tthis.m_TShowHide = 0;\n\tv350 = 0xF3F1B4(v249, 0, *([v343 @ X8_v31 (Il2CppClass<BFS.Essential.Tween>)+1B0]), methodInfo, v45, v46, v47, v48, duration, v49, v106, v96, v82, v53, v54, v55);\nL_0055:\n\tthis.m_IsShow = *([v61 @ X0_v3 (System.Object)+18]);\n\tv356 = this->klass;\n\tif (*([v61 @ X0_v3 (System.Object)+18])) goto L_FFFFFFFF;\n\tgoto L_006B;\nL_006B:\n\tif (*([v61 @ X0_v3 (System.Object)+18])) goto L_FFFFFFFF;\n\tgoto L_0073;\nL_0073:\n\t*([v356 @ X9_v3 (Il2CppClass<Viewport>)+v378 @ X10_v4 (System.Int32)])(v380, this, *([v356 @ X9_v3 (Il2CppClass<Viewport>)+v373 @ X8_v7 (System.Int32)]), *([v343 @ X8_v31 (Il2CppClass<BFS.Essential.Tween>)+1B0]), methodInfo, v45, v46, v47, v48, duration, v49, v106, v96, v82, v53, v54, v55);\n\tv134 = *([v61 @ X0_v3 (System.Object)+18]) != 0;\n\tif (v134) goto L_FFFFFFFF;\n\tgoto L_0087;\nL_0087:\n\tv384 = ~this.ShouldAnimate;\n\tif (v384) goto L_00E4;\n\tv385 = System.Collections.Generic.NullableComparer`1;\n\tv386 = Il2CppMethodInfo;\n\tv388 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv389 = Il2CppMethodInfo;\n\tv133 = *([v61 @ X0_v3 (System.Object)+18]) != 0;\n\tif (v133) goto L_FFFFFFFF;\n\tgoto L_00A1;\nL_00A1:\n\tv395 = new *([v385 @ X9_v10 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D40])();\n\tSystem.Action`1<System.Single>::.ctor(v395, v61, *([v386 @ X22_v6 (Il2CppMethodInfo)+5E0]));\n\tv419 = BFS.Essential.MyTween::DoFloat(v124, v130, duration, v395);\n\tv209 = new *([v388 @ X23_v5 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+2E8])();\n\tSystem.Func`2<System.Single, System.Single>::.ctor(v209, v61, *([v389 @ X24_v3 (Il2CppMethodInfo)+5E8]));\n\tv439 = CollectParticleData[];\n\tv440 = Il2CppMethodInfo;\n\tv444 = BFS.Essential.Tween::SetInterpolator(v419, v209);\n\tv210 = new *([v439 @ X23_v7 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v210, v61, *([v440 @ X24_v5 (Il2CppMethodInfo)+5F0]));\n\tv321 = *([v444 @ X0_v52 (BFS.Essential.Tween)]);\n\tv461 = BFS.Essential.Tween::OnComplete(v444, v210);\n\tthis.m_TShowHide = v461;\n\tv315 = 0xF3F1B4(v249, v461, *([v321 @ X8_v28 (Il2CppClass<BFS.Essential.Tween>)+180]), 0, v45, v46, v47, v48, v124, v130, duration, v96, v82, v53, v54, v55);\n\treturn;\nL_00E4:\n\tv211 = Viewport::get_CanvasGroup(this);\n\tv245 = 1f - v130;\n\tv397 = v245 / this.transitionFadeRange;\n\tv399 = 1f - v397;\n\tv402 = v399 - 1f;\n\tv403 = v402 < 0;\n\tv404 = v402 == 0;\n\tv405 = v399 ^ 1f;\n\tv406 = v399 ^ v402;\n\tv407 = v405 & v406;\n\tv408 = v407 < 0;\n\tv409 = v403 == v408;\n\tv99 = ~v404;\n\tv102 = v409 & v99;\n\tv410 = ~v102;\n\tif (v410) goto L_FFFFFFFF;\n\tgoto L_0108;\nL_0108:\n\tv135 = v399 >= 0;\n\tif (v135) goto L_FFFFFFFF;\n\tgoto L_010F;\nL_010F:\n\tUnityEngine.CanvasGroup::set_alpha(v211, v119);\n\tv434 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv436 = *([v434 @ X8_v9 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv438 = *([v436 @ X0_v18+E0]) == 0;\n\tif (v438) goto L_0121;\n\tv448 = UnityEngine.Object::op_Implicit(this.main);\n\tv450 = ~v448;\n\tv451 = ~v450;\n\tif (v451) goto L_0129;\n\tgoto L_018E;\nL_0121:\n\tv454 = UnityEngine.Object::op_Implicit(this.main);\n\tv457 = ~v454;\n\tif (v457) goto L_018E;\nL_0129:\n\tv169 = this.transitionType == 1;\n\tif (v169) goto L_0168;\n\tv508 = this.transitionType == 0;\n\tv499 = ~v508;\n\tif (v499) goto L_018E;\n\tv513 = UnityEngine.Component::get_transform(this.main);\n\tgoto L_0144;\n\tv530 = System.Xml.ValidateNames;\n\tv531 = v530 + 0xD0;\n\tv532 = \"il2cpp_codegen_initialize_runtime_metadata\"(v531, v207, v192, methodInfo, v45, v46, v47, v48, v116, v109, v50, v51, v52, v53, v54, v55);\n\tv533 = 1;\n\t*([2DD441A]) = v533;\nL_0144:\n\tv541 = System.Xml.ValidateNames;\n\tv543 = *([v541 @ X8_v22 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv501 = *([v543 @ X8_v24+B8]);\n\tv552 = -v245;\n\tv473 = *([v61 @ X0_v3 (System.Object)+18]) != 0;\n\tif (v473) goto L_015B;\n\tgoto L_015B;\nL_015B:\n\tv554 = this.mainTransitionScaleDelta * v552;\n\tv96 = v554 + 1f;\n\tv106 = *([v501 @ X8_v25+14]) * v96;\n\tv112 = *([v501 @ X8_v25+10]) * v96;\n\tv119 = *([v501 @ X8_v25+C]) * v96;\n\t// 357 MakeStruct v463 @ AGGFD56FC_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v119 @ V0_v8 (System.Single), v112 @ V1_v4 (System.Single), v106 @ V2_v2 (System.Single)\n\tUnityEngine.Transform::set_localScale(v513, v463);\n\tgoto L_018E;\nL_0168:\n\tthis.interp = v245;\n\tv117 = UnityEngine.RectTransform::get_rect(this.main);\n\tv106 = v117.m_Width;\n\tv96 = v117.m_Height;\n\tv520 = 1f - v245;\n\tv521 = v520 * v117.m_Width;\n\tv246 = -v521;\n\tv524 = UnityEngine.RectTransform::get_offsetMin(this.main);\n\t// 383 MakeStruct v92 @ AGGFD5744_1_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v246 @ V8_v7 (System.Single), v524.y (System.Single)\n\tUnityEngine.RectTransform::set_offsetMin(this.main, v92);\n\tv551 = UnityEngine.RectTransform::get_offsetMin(this.main);\n\tv112 = v551.y;\n\t// 395 MakeStruct v465 @ AGGFD5768_1_v3 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v246 @ V8_v7 (System.Single), v551.y (System.Single)\n\tUnityEngine.RectTransform::set_offsetMax(this.main, v465);\nL_018E:\n\tv503 = this->klass;\n\tv507 = *([v61 @ X0_v3 (System.Object)+18]) != 0;\n\tif (v507) goto L_FFFFFFFF;\n\tgoto L_01A2;\nL_01A2:\n\tv136 = *([v61 @ X0_v3 (System.Object)+18]) != 0;\n\tif (v136) goto L_FFFFFFFF;\n\tgoto L_01AB;\nL_01AB:\n\t*([v503 @ X9_v6 (Il2CppClass<Viewport>)+v525 @ X10_v8 (System.Int32)])(v528, this, *([v503 @ X9_v6 (Il2CppClass<Viewport>)+v511 @ X8_v15 (System.Int32)]), *([v343 @ X8_v31 (Il2CppClass<BFS.Essential.Tween>)+1B0]), methodInfo, v45, v46, v47, v48, v119, v112, v106, v96, *([v501 @ X8_v25+C]), v53, v54, v55);\n\tv234 = *([v61 @ X0_v3 (System.Object)+20]);\n\tv529 = *([v61 @ X0_v3 (System.Object)+20]) == 0;\n\tif (v529) goto L_01B5;\n\n// ... truncated")]
	private void ShowHide(bool on, float duration, global::System.Action callback)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0062: Expected O, but got I
		//IL_00d0: Expected I, but got O
		//IL_0093: Expected I, but got O
		//IL_02b7: Expected O, but got F4
		//IL_02c4: Expected O, but got F4
		//IL_0148: Expected I, but got O
		//IL_015c: Expected I, but got O
		//IL_06f9: Expected I, but got O
		//IL_0709: Expected O, but got I
		//IL_01d3: Expected I, but got O
		//IL_0211: Expected I, but got O
		//IL_058d: Expected I, but got O
		//IL_080f: Expected O, but got I
		//IL_0427: Expected I, but got O
		//IL_0437: Expected O, but got I
		//IL_0447: Expected O, but got I
		nint num = (nint)typeof(Sponge._003C_003Ec__DisplayClass7_0);
		object obj = new object();
		object obj2 = (nint)obj + 16;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj4 = (nint)this + 64;
		global::BFS.Essential.Tween tShowHide = m_TShowHide;
		if (m_TShowHide != null)
		{
			nint num2 = (nint)tShowHide;
			m_TShowHide.Kill();
			m_TShowHide = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
		m_IsShow = false;
		nint num3 = (nint)this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
		if ((nint)0 == 0)
		{
			int num4 = 384;
		}
		else
		{
			int num4 = 416;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
		if ((nint)0 == 0)
		{
			int num5 = 376;
		}
		else
		{
			int num5 = 408;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v356 @ X9_v3 (Il2CppClass<Viewport>)+v378 @ X10_v4 (System.Int32)] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
		float num6 = (((nint)0 != 0) ? 1f : 0f);
		if (ShouldAnimate)
		{
			nint num7 = (nint)typeof(global::System.Collections.Generic.NullableComparer<>);
			nint num8 = 0;
			nint num9 = (nint)typeof(global::System.Func<global::UnityEngine.UIElements.ValidateCommandEvent>);
			nint num10 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
			float start = (((nint)0 != 0) ? 0f : 1f);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X22_v6 (Il2CppMethodInfo)+5E0]");
			global::System.Action<float> callback2 = new global::System.Action<float>(obj, (global::System.IntPtr)0);
			global::BFS.Essential.Tween tween = global::BFS.Essential.MyTween.DoFloat(start, num6, duration, callback2);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X24_v3 (Il2CppMethodInfo)+5E8]");
			global::System.Func<float, float> interpolator = new global::System.Func<float, float>(obj, (global::System.IntPtr)0);
			nint num11 = (nint)typeof(CollectParticleData[]);
			nint num12 = 0;
			global::BFS.Essential.Tween tween2 = tween.SetInterpolator(interpolator);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v440 @ X24_v5 (Il2CppMethodInfo)+5F0]");
			global::System.Action callback3 = new global::System.Action(obj, (global::System.IntPtr)0);
			nint num13 = (nint)tween2;
			global::BFS.Essential.Tween tShowHide2 = tween2.OnComplete(callback3);
			m_TShowHide = tShowHide2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			return;
		}
		global::UnityEngine.CanvasGroup canvasGroup = CanvasGroup;
		float num14 = 1f - num6;
		float num15 = num14 / transitionFadeRange;
		float num16 = 1f - num15;
		float num17 = num16 - 1f;
		bool flag = num17 < 0f;
		bool flag2 = num17 == 0f;
		object obj5 = num16 ^ 1f;
		object obj6 = num16 ^ num17;
		int num18 = (int)((nint)obj5 & (nint)obj6);
		bool flag3 = num18 < 0;
		bool flag4 = flag == flag3;
		bool flag5 = !flag2;
		float num19 = ((!(flag4 && flag5)) ? num16 : 1f);
		float alpha = ((!(num16 < 0f)) ? num19 : 0f);
		canvasGroup.alpha = alpha;
		nint num20 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v434 @ X8_v9 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v436 @ X0_v18+E0]");
		if ((nint)0 != 0)
		{
			if ((bool)main)
			{
				goto IL_03bc;
			}
		}
		else if ((bool)main)
		{
			goto IL_03bc;
		}
		goto IL_0588;
		IL_0588:
		nint num21 = (nint)this;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
		if ((nint)0 == 0)
		{
			int num22 = 400;
		}
		else
		{
			int num22 = 432;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
		if ((nint)0 == 0)
		{
			int num23 = 392;
		}
		else
		{
			int num23 = 424;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v503 @ X9_v6 (Il2CppClass<Viewport>)+v525 @ X10_v8 (System.Int32)] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+20]");
		object obj8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+20]");
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v234 @ X8_v16+18] (should have been resolved before IL gen)");
		}
		global::UnityEngine.GameObject gameObject = base.gameObject;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
		gameObject.SetActive(value: false);
		return;
		IL_03bc:
		if (transitionType != Viewport.TransitionType.Slide)
		{
			if (transitionType == Viewport.TransitionType.Scale)
			{
				global::UnityEngine.Transform transform = main.transform;
				nint num24 = (nint)typeof(global::System.Xml.ValidateNames);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X8_v22 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
				object obj9 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v543 @ X8_v24+B8]");
				object obj10 = 0;
				float num25 = 0f - num14;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v3 (System.Object)+18]");
				if ((nint)0 == 0)
				{
					num25 = num14;
				}
				float num26 = mainTransitionScaleDelta * num25;
				float num27 = num26 + 1f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v25+14]");
				float z = 0f * num27;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v25+10]");
				num19 = 0f * num27;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X8_v25+C]");
				alpha = 0f * num27;
				global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
				localScale.x = alpha;
				localScale.y = num19;
				localScale.z = z;
				transform.localScale = localScale;
			}
		}
		else
		{
			interp = num14;
			global::UnityEngine.Rect rect = main.rect;
			float z = rect.m_Width;
			float num27 = rect.m_Height;
			float num28 = 1f - num14;
			float num29 = num28 * rect.m_Width;
			float num30 = 0f - num29;
			global::UnityEngine.Vector2 offsetMin = main.offsetMin;
			global::UnityEngine.Vector2 offsetMin2 = default(global::UnityEngine.Vector2);
			offsetMin2.x = num30;
			offsetMin2.y = offsetMin.y;
			main.offsetMin = offsetMin2;
			global::UnityEngine.Vector2 offsetMin3 = main.offsetMin;
			num19 = offsetMin3.y;
			global::UnityEngine.Vector2 offsetMax = default(global::UnityEngine.Vector2);
			offsetMax.x = num30;
			offsetMax.y = offsetMin3.y;
			main.offsetMax = offsetMax;
			alpha = num30;
		}
		goto IL_0588;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000057")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD57F8", Offset = "0xFD57F8", Length = "0x4C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv14 = Viewport::get_CanvasGroup(this);\n\tUnityEngine.CanvasGroup::set_interactable(v14, on);\n\tv24 = Viewport::get_CanvasGroup(this);\n\tUnityEngine.CanvasGroup::set_blocksRaycasts(v24, on);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 22 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnOffCanvasGroup(bool on)
	{
		global::UnityEngine.CanvasGroup canvasGroup = CanvasGroup;
		canvasGroup.interactable = on;
		global::UnityEngine.CanvasGroup canvasGroup2 = CanvasGroup;
		canvasGroup2.blocksRaycasts = on;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000058")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5844", Offset = "0xFD5844", Length = "0xA0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = ~this.m_IsShow;\n\tif (v16) goto L_0017;\n\treturn;\nL_0017:\n\tv29 = UnityEngine.Component::get_gameObject(this);\n\tUnityEngine.GameObject::SetActive(v29, 1);\n\tv62 = Viewport::get_CanvasGroup(this);\n\tUnityEngine.CanvasGroup::set_interactable(v62, 1);\n\tv63 = Viewport::get_CanvasGroup(this);\n\tUnityEngine.CanvasGroup::set_blocksRaycasts(v63, 1);\n\tViewport::ShowHide(this, 1, duration, callback);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 45 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Show(float duration = 0.3f, global::System.Action callback = null)
	{
		if (!IsShow)
		{
			global::UnityEngine.GameObject gameObject = base.gameObject;
			gameObject.SetActive(value: true);
			global::UnityEngine.CanvasGroup canvasGroup = CanvasGroup;
			canvasGroup.interactable = true;
			global::UnityEngine.CanvasGroup canvasGroup2 = CanvasGroup;
			canvasGroup2.blocksRaycasts = true;
			ShowHide(on: true, duration, callback);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000059")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD58E4", Offset = "0xFD58E4", Length = "0x84")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = ~this.m_IsShow;\n\tif (v16) goto L_002F;\n\tv22 = Viewport::get_CanvasGroup(this);\n\tUnityEngine.CanvasGroup::set_interactable(v22, 0);\n\tv60 = Viewport::get_CanvasGroup(this);\n\tUnityEngine.CanvasGroup::set_blocksRaycasts(v60, 0);\n\tViewport::ShowHide(this, 0, duration, callback);\n\treturn;\nL_002F:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Hide(float duration = 0.3f, global::System.Action callback = null)
	{
		if (IsShow)
		{
			global::UnityEngine.CanvasGroup canvasGroup = CanvasGroup;
			canvasGroup.interactable = false;
			global::UnityEngine.CanvasGroup canvasGroup2 = CanvasGroup;
			canvasGroup2.blocksRaycasts = false;
			ShowHide(on: false, duration, callback);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600005A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5968", Offset = "0xFD5968", Length = "0xF4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Xml.ValidateNames;\n\tv20 = *([302A8D0]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0034;\n\tv43 = *([v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv24 = *([v43 @ X0_v19+E0]) == 0;\n\tif (v24) goto L_003B;\nL_0014:\n\tv49 = *([v43 @ X0_v19+B8]);\n\tv74 = *([v49 @ X8_v14]);\n\tv71 = System.Object::GetType(this);\nL_001C:\n\t;\n\tSystem.Collections.Generic.Dictionary`2<System.Object, System.Object>::Add(v74, v71, this);\n\tv90 = ~this.m_VisibleAtStart;\n\tif (v90) goto L_0046;\n\treturn;\nL_0034:\n\t*([302A8D0]) = 1;\n\tv43 = *([v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv69 = *([v43 @ X0_v19+E0]) == 0;\n\tv46 = ~v69;\n\tif (v46) goto L_0014;\nL_003B:\n\tv62 = *([v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv63 = *([v62 @ X0_v7+B8]);\n\tv74 = *([v63 @ X8_v6]);\n\tv71 = System.Object::GetType(this);\n\tv88 = *([v63 @ X8_v6]) == 0;\n\tv73 = ~v88;\n\tif (v73) goto L_001C;\n\tthrow System.NullReferenceException;\nL_0046:\n\tthis.m_IsShow = 1;\n\tViewport::Hide(this, 0f, 0);\n\treturn;\n// 52 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal virtual void Awake()
	{
		//IL_000e: Expected I, but got O
		//IL_00de: Expected O, but got I
		//IL_0086: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_011e: Expected O, but got I
		//IL_012e: Expected O, but got I
		nint num = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A8D0]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v19+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v19+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v7+B8]");
		object obj3 = 0;
		object obj4 = obj3;
		global::System.Type type = GetType();
		if (obj3 == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_009d;
		IL_0076:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X0_v19+B8]");
		object obj5 = 0;
		obj4 = obj5;
		type = GetType();
		goto IL_009d;
		IL_009d:
		((global::System.Collections.Generic.Dictionary<object, object>)obj4).Add((object)type, (object)this);
		if (!m_VisibleAtStart)
		{
			m_IsShow = true;
			Hide(0f);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600005B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5A5C", Offset = "0xFD5A5C", Length = "0xC8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xFE8;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv49 = System.Xml.ValidateNames;\n\tv50 = v49 + 0x198;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8D1]) = v42;\nL_0017:\n\tv43 = System.Xml.ValidateNames;\n\tv46 = this + 0x40;\n\tv47 = this.m_TShowHide;\n\tv48 = this.m_TShowHide == 0;\n\tif (v48) goto L_0027;\n\tv51 = *([v47 @ X0_v2 (BFS.Essential.Tween)]);\n\tv55 = BFS.Essential.Tween::Kill(this.m_TShowHide, 0);\n\tthis.m_TShowHide = 0;\n\tv58 = 0xF3F1B4(v46, 0, *([v51 @ X8_v9 (Il2CppClass<BFS.Essential.Tween>)+1B0]), v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0027:\n\tv70 = *([v43 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tgoto L_002E;\n\tv69 = \"il2cpp_codegen_runtime_class_init\"(v65, v59, v60, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv71 = *([v44 @ X21_v2]);\nL_002E:\n\tv72 = *([v70 @ X0_v5+B8]);\n\tv76 = System.Object::GetType(this);\n\tv89 = System.Collections.Generic.Dictionary`2<System.Object, System.Object>::Remove(*([v72 @ X8_v5]), v76);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected virtual void OnDestroy()
	{
		//IL_0069: Expected I, but got O
		//IL_0075: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_000d: Expected I, but got O
		nint num = (nint)typeof(global::System.Xml.ValidateNames);
		object obj = (nint)this + 64;
		global::BFS.Essential.Tween tShowHide = m_TShowHide;
		if (m_TShowHide != null)
		{
			nint num2 = (nint)tShowHide;
			m_TShowHide.Kill();
			m_TShowHide = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v5+B8]");
		object obj3 = 0;
		global::System.Type type = GetType();
		bool flag = ((global::System.Collections.Generic.Dictionary<object, object>)obj3).Remove((object)type);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600005C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5B24", Offset = "0xFD5B24", Length = "0x28")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.ease = 5;\n\tthis.ShouldAnimate = 1;\n\tthis.mainTransitionScaleDelta = 0.0004882813636868377d;\n\tthis.m_IsShow = 1;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 5 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Viewport()
	{
		ease = EasingFunction.Ease.EaseInOutCubic;
		ShouldAnimate = true;
		mainTransitionScaleDelta = 0.25f;
		transitionFadeRange = 0.75f;
		m_IsShow = true;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600005D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5B4C", Offset = "0xFD5B4C", Length = "0x9C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv20 = System.Xml.ValidateNames;\n\tgoto L_0020;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xFD8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv51 = v50 + 0x770;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv55 = System.Xml.ValidateNames;\n\tv56 = v55 + 0x198;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv47 = 1;\n\t*([302A8D2]) = v47;\nL_0020:\n\tv49 = new *([v16 @ X22_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+770])();\n\tSystem.Collections.Generic.Dictionary`2<System.Object, System.Object>::.ctor(v49);\n\tv57 = *([v20 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv58 = *([v57 @ X8_v3+B8]);\n\t*([v58 @ X8_v4]) = v49;\n\tv59 = *([v20 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv68 = 0xF3F1B4(*([v59 @ X8_v5+B8]), v49, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 29 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	static Viewport()
	{
		//IL_000e: Expected I, but got O
		//IL_001d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_0065: Expected O, but got I
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = (nint)typeof(global::System.Xml.ValidateNames);
		object obj = new global::System.Collections.Generic.Dictionary<object, object>();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+B8]");
		object obj3 = 0;
		obj3 = obj;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}
}
