[global::Cpp2ILInjected.Token(Token = "0x2000034")]
public class GameBehaviour : global::UnityEngine.MonoBehaviour
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000035")]
	private sealed class _003CIntroSequence_003Ed__3 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public GameBehaviour _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600013A")]
			[global::Cpp2ILInjected.Address(RVA = "0xFE5FF8", Offset = "0xFE5FF8", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600013C")]
			[global::Cpp2ILInjected.Address(RVA = "0xFE6040", Offset = "0xFE6040", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE5D64", Offset = "0xFE5D64", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CIntroSequence_003Ed__3(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE5D9C", Offset = "0xFE5D9C", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE5DA0", Offset = "0xFE5DA0", Length = "0x258")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0019;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xF88;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv59 = System.Xml.ValidateNames;\n\tv60 = v59 + 0x258;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A959]) = v46;\nL_0019:\n\tv47 = v43.<>1__state;\n\tv48 = v43.<>1__state < 3;\n\tv49 = ~v48;\n\tv50 = v43.<>1__state - 3;\n\tv52 = v50 == 0;\n\tv57 = ~v52;\n\tv58 = v49 & v57;\n\tif (v58) goto L_00C2;\n\tv63 = 0x2875000 + 0x8D0;\n\tv66 = *([v63 @ X9_v2 (System.Int32)+v47 @ X8_v3 (System.Int32)]) << 2;\n\tv67 = 0xFE5E0C + v66;\n\t// 45 IndirectJump v67 @ X10_v2 (System.Int32), v43 @ X0_v1 (GameBehaviour+<IntroSequence>d__3), v43 @ X0_v1 (GameBehaviour+<IntroSequence>d__3), methodInfo @ X1 (Il2CppMethodInfo), v29 @ X2, v30 @ X3, v31 @ X4, v32 @ X5, v33 @ X6, v34 @ X7, v35 @ V0, v36 @ V1, v37 @ V2, v38 @ V3, v39 @ V4, v40 @ V5, v41 @ V6, v42 @ V7\n\tX8 = 0xFFFFFFFF;\n\t*([X19+10]) = X8;\n\tif (TEMP) goto L_00C3;\n\tX0 = *([X20+28]);\n\tif (TEMP) goto L_00C3;\n\tV0 = 0;\n\tX1 = 0;\n\tUnityEngine.CanvasGroup::set_alpha(X0, V0, X1);\n\tX8 = X8 + 0x258;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tV0 = 0.5f;\n\tX1 = 0;\n\tUnityEngine.WaitForSeconds::.ctor(X0, V0, X1);\n\tX19 = X19 + 0x18;\n\t*([X19]) = X20;\n\tX0 = X19;\n\tX1 = X20;\n\tX0 = 0xF3F1B4(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX0 = 1;\n\t*([X19-8]) = X0;\n\tX29 = stack[30];\n\tX30 = stack[38];\n\tX20 = stack[20];\n\tX19 = stack[28];\n\tX22 = stack[10];\n\tX21 = stack[18];\n\tV9 = stack[0];\n\tV8 = stack[8];\n\t// 79 ShiftStack 64\n\treturn X0;\n\tX8 = 0xFFFFFFFF;\n\t*([X19+10]) = X8;\n\tif (TEMP) goto L_00C3;\n\tX0 = *([X20+20]);\n\tV0 = 0;\n\tV1 = 0.5f;\n\tV2 = 0.5f;\n\tX1 = 0;\n\tX2 = 0;\n\t// 91 MakeStruct AGGFE5E9C_1, typeof(UnityEngine.Vector2), V0, V1\n\tX0 = DG.Tweening.DOTweenModuleUI::DOAnchorMin(X0, AGGFE5E9C_1, V2, X1, X2);\n\tX21 = X21 + 0xF88;\n\tX2 = *([X21]);\n\tX1 = 0x1B;\n\tX0 = DG.Tweening.TweenSettingsExtensions::SetEase /* +1 sharing this address */(X0, X1, X2);\n\tX0 = *([X20+20]);\n\tV0 = 1f;\n\tV1 = 0.5f;\n\tV2 = 0.5f;\n\tX1 = 0;\n\tX2 = 0;\n\t// 104 MakeStruct AGGFE5ECC_1, typeof(UnityEngine.Vector2), V0, V1\n\tX0 = DG.Tweening.DOTweenModuleUI::DOAnchorMax(X0, AGGFE5ECC_1, V2, X1, X2);\n\tX2 = *([X21]);\n\tX1 = 0x1B;\n\tX0 = DG.Tweening.TweenSettingsExtensions::SetEase /* +1 sharing this address */(X0, X1, X2);\n\tX8 = X8 + 0x258;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tV0 = 2f;\n\tX1 = 0;\n\tUnityEngine.WaitForSeconds::.ctor(X0, V0, X1);\n\tX19 = X19 + 0x18;\n\t*([X19]) = X20;\n\tX0 = X19;\n\tX1 = X20;\n\tX0 = 0xF3F1B4(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = 2;\n\tgoto L_00A3;\n\tX8 = 0xFFFFFFFF;\n\t*([X19+10]) = X8;\n\tif (TEMP) goto L_00C3;\n\tX0 = *([X20+20]);\n\tX8 = 0xCCCD;\n\tX8 = X8 | 0x3ECC0000;\n\tV8 = X8;\n\tV0 = 0;\n\tV1 = 1.5f;\n\tV2 = V8;\n\tX1 = 0;\n\tX2 = 0;\n\t// 137 MakeStruct AGGFE5F44_1, typeof(UnityEngine.Vector2), V0, V1\n\tX0 = DG.Tweening.DOTweenModuleUI::DOAnchorMin(X0, AGGFE5F44_1, V2, X1, X2);\n\tX21 = X21 + 0xF88;\n\tX2 = *([X21]);\n\tX1 = 0x1A;\n\tX0 = DG.Tweening.TweenSettingsExtensions::SetEase /* +1 sharing this address */(X0, X1, X2);\n\tX0 = *([X20+20]);\n\tV0 = 1f;\n\tV1 = 1.5f;\n\tV2 = V8;\n\tX1 = 0;\n\tX2 = 0;\n\t// 150 MakeStruct AGGFE5F74_1, typeof(UnityEngine.Vector2), V0, V1\n\tX0 = DG.Tweening.DOTweenModuleUI::DOAnchorMax(X0, AGGFE5F74_1, V2, X1, X2);\n\tX2 = *([X21]);\n\tX1 = 0x1A;\n\tX0 = DG.Tweening.TweenSettingsExtensions::SetEase /* +1 sharing this address */(X0, X1, X2);\n\tX1 = 0;\n\tX0 = DG.Tweening.TweenExtensions::WaitForCompletion(X0, X1);\n\tX1 = X0;\n\tX19 = X19 + 0x18;\n\t*([X19]) = X0;\n\tX0 = X19;\n\tX0 = 0xF3F1B4(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = 3;\nL_00A3:\n\t*([X19-8]) = X8;\n\tX0 = 1;\n\tX29 = stack[30];\n\tX30 = stack[38];\n\tX20 = stack[20];\n\tX19 = stack[28];\n\tX22 = stack[10];\n\tX21 = stack[18];\n\tV9 = stack[0];\n\tV8 = stack[8];\n\t// 173 ShiftStack 64\n\treturn X0;\n\tX8 = 0xFFFFFFFF;\n\t*([X19+10]) = X8;\n\tif (TEMP) goto L_00C3;\n\tX0 = *([X20+28]);\n\tV0 = 1f;\n\tV1 = 0.5f;\n\tX1 = 0;\n\tX0 = DG.Tweening.DOTweenModuleUI::DOFade(X0, V0, V1, X1);\nL_00C2:\n\treturn 0;\nL_00C3:\n\tX0 = NullReferenceException /* throw helper */(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\treturn X0;\n// 44 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			int num = _003C_003E1__state;
			bool flag = _003C_003E1__state < 3;
			bool flag2 = !flag;
			int num2 = _003C_003E1__state - 3;
			bool flag3 = num2 == 0;
			bool flag4 = !flag3;
			if (!(flag2 && flag4))
			{
				int num3 = 42422272 + 2256;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X9_v2 (System.Int32)+v47 @ X8_v3 (System.Int32)]");
				int num4 = (int)((nint)0 << 2);
				int num5 = 16670220 + num4;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v67 @ X10_v2 (System.Int32) (should have been resolved before IL gen)");
			}
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE6000", Offset = "0xFE6000", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xE38;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 3888;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3640;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.RectTransform startBanner;

	[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.CanvasGroup objectiveBanner;

	[global::Cpp2ILInjected.Token(Token = "0x6000133")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5C6C", Offset = "0xFE5C6C", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xC98;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A958]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+C98])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv61 = UnityEngine.MonoBehaviour::StartCoroutine(this, v45);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		//IL_000e: Expected I, but got O
		//IL_0041: Expected O, but got I
		nint num = (nint)typeof(global::Facebook.Unity.AsyncRequestString._003CStart_003Ed__9);
		object obj = new object();
		_ = 0;
		object obj2 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)obj);
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(GameBehaviour._003CIntroSequence_003Ed__3))]
	[global::Cpp2ILInjected.Token(Token = "0x6000134")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5CEC", Offset = "0xFE5CEC", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xC98;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A958]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+C98])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator IntroSequence()
	{
		//IL_000e: Expected I, but got O
		//IL_0037: Expected O, but got I
		nint num = (nint)typeof(global::Facebook.Unity.AsyncRequestString._003CStart_003Ed__9);
		object obj = new object();
		_ = 0;
		object obj2 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000135")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5D90", Offset = "0xFE5D90", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	private void Update()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000136")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5D94", Offset = "0xFE5D94", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public GameBehaviour()
	{
	}
}
