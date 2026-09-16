[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
public class LevelFailedScreen : Viewport
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000F3")]
	private sealed class _003CHandleStartShow_003Ed__3 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40004FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x4000500")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public LevelFailedScreen _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000467")]
			[global::Cpp2ILInjected.Address(RVA = "0x10201F0", Offset = "0x10201F0", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000469")]
			[global::Cpp2ILInjected.Address(RVA = "0x1020238", Offset = "0x1020238", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000464")]
		[global::Cpp2ILInjected.Address(RVA = "0x101FEEC", Offset = "0x101FEEC", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandleStartShow_003Ed__3(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000465")]
		[global::Cpp2ILInjected.Address(RVA = "0x1020040", Offset = "0x1020040", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000466")]
		[global::Cpp2ILInjected.Address(RVA = "0x1020044", Offset = "0x1020044", Length = "0x1AC")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xC70;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv46 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv47 = v46 + 0xA38;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v47, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv61 = System.Xml.ValidateNames;\n\tv62 = v61 + 0x258;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv148 = \"__sort-indicator\";\n\tv149 = v148 + 0x9E8;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v149, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AAEE]) = v42;\nL_001E:\n\tv44 = this.<>4__this;\n\tv45 = this.<>1__state == 0;\n\tif (v45) goto L_0071;\n\tv58 = this.<>1__state != 1;\n\tif (v58) goto L_0062;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tgoto L_0036;\n\tv150 = \"il2cpp_codegen_runtime_class_init\"(v67, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0036:\n\tv152 = Il2CppMethodInfo;\n\tv129 = Singleton`1::get_Instance /* +1 sharing this address */(*([v152 @ X8_v15 (Il2CppMethodInfo)+C70]));\n\tv194 = \"__sort-indicator\";\n\tAudioManager::PlayClip(v129, *([v194 @ X8_v17 (System.String)+9E8]));\n\tv131 = UnityEngine.Component::get_gameObject(v44.retryButton);\n\tUnityEngine.GameObject::SetActive(v131, 1);\n\tv146 = v44.retryButton;\n\tElasticScale::SetScale(v146.elasticScale, 0f);\n\tv82 = v44.retryButton;\n\tElasticScale::Pop(v82.elasticScale);\nL_0062:\n\tv87 = this.<>1__state == 0;\n\treturn v87;\nL_0071:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv133 = UnityEngine.Component::get_gameObject(v44.retryButton);\n\tUnityEngine.GameObject::SetActive(v133, 0);\n\tv196 = System.Xml.ValidateNames;\n\tv199 = new *([v196 @ X8_v5 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v199, 0.1f);\n\tv204 = this + 0x18;\n\tthis.<>2__current = v199;\n\tv206 = 0xF3F1B4(v204, v199, 0, v26, v27, v28, v29, v30, 0x3DCCCCCD, v32, v33, v34, v35, v36, v37, v38);\n\tthis.<>1__state = 1;\n\tv176 = this.<>1__state == 0;\n\treturn v176;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 114 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_0137: Expected I, but got O
			//IL_0157: Expected O, but got I
			//IL_006a: Expected O, but got I
			LevelFailedScreen levelFailedScreen = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					nint num = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
					string text = "__sort-indicator";
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X8_v17 (System.String)+9E8]");
					AudioManager audioManager = default(AudioManager);
					audioManager.PlayClip((string)0);
					global::UnityEngine.GameObject gameObject = levelFailedScreen.retryButton.gameObject;
					gameObject.SetActive(value: true);
					UIButton retryButton = levelFailedScreen.retryButton;
					retryButton.elasticScale.SetScale(0f);
					UIButton retryButton2 = levelFailedScreen.retryButton;
					retryButton2.elasticScale.Pop();
				}
				return _003C_003E1__state == 0;
			}
			_003C_003E1__state = -1;
			global::UnityEngine.GameObject gameObject2 = levelFailedScreen.retryButton.gameObject;
			gameObject2.SetActive(value: false);
			nint num2 = (nint)typeof(global::System.Xml.ValidateNames);
			global::UnityEngine.WaitForSeconds waitForSeconds = new global::UnityEngine.WaitForSeconds(0.1f);
			object obj = (nint)this + 24;
			_003C_003E2__current = waitForSeconds;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			_003C_003E1__state = 1;
			return _003C_003E1__state == 0;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000468")]
		[global::Cpp2ILInjected.Address(RVA = "0x10201F8", Offset = "0x10201F8", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0x130;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 3888;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)304;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x40004FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public UIButton retryButton;

	[global::Cpp2ILInjected.Token(Token = "0x600045F")]
	[global::Cpp2ILInjected.Address(RVA = "0x101FD58", Offset = "0x101FD58", Length = "0x9C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xF58;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Net.Configuration.SettingsSectionInternal;\n\tv46 = v45 + 0xE60;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AAEA]) = v42;\nL_0017:\n\tv43 = this.retryButton;\n\tv47 = System.Net.Configuration.SettingsSectionInternal;\n\tv49 = Il2CppMethodInfo;\n\tv53 = new *([v47 @ X9_v2 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+E60])();\n\tUnityEngine.Events.UnityAction::.ctor(v53, this, *([v49 @ X22_v2 (Il2CppMethodInfo)+F58]));\n\tUnityEngine.Events.UnityEvent::AddListener(v43.m_OnClick, v53);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		//IL_0013: Expected I, but got O
		UIButton uIButton = retryButton;
		nint num = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X22_v2 (Il2CppMethodInfo)+F58]");
		global::UnityEngine.Events.UnityAction call = new global::UnityEngine.Events.UnityAction(this, (global::System.IntPtr)0);
		uIButton.m_OnClick.AddListener(call);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000460")]
	[global::Cpp2ILInjected.Address(RVA = "0x101FDF4", Offset = "0x101FDF4", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0017;\n\tv23 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv24 = v23 + 0x178;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAEB]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+178])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv61 = UnityEngine.MonoBehaviour::StartCoroutine(this, v45);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal override void OnStartShow()
	{
		//IL_000e: Expected I, but got O
		//IL_0041: Expected O, but got I
		nint num = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
		object obj = new object();
		_ = 0;
		object obj2 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)obj);
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(LevelFailedScreen._003CHandleStartShow_003Ed__3))]
	[global::Cpp2ILInjected.Token(Token = "0x6000461")]
	[global::Cpp2ILInjected.Address(RVA = "0x101FE74", Offset = "0x101FE74", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0017;\n\tv23 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv24 = v23 + 0x178;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAEB]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+178])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator HandleStartShow()
	{
		//IL_000e: Expected I, but got O
		//IL_0037: Expected O, but got I
		nint num = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
		object obj = new object();
		_ = 0;
		object obj2 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000462")]
	[global::Cpp2ILInjected.Address(RVA = "0x101FF18", Offset = "0x101FF18", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Xml.ValidateNames;\n\tv20 = *([302AAEC]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0023;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0033;\nL_001D:\n\tViewport::.ctor(this);\n\treturn;\nL_0023:\n\t*([v16 @ X20_v1+AEC]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv62 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v62;\n\tif (v46) goto L_001D;\nL_0033:\n\tViewport::.ctor(this);\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public LevelFailedScreen()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_005a: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AAEC]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v10+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v7+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		base._002Ector();
		return;
		IL_007f:
		base._002Ector();
	}
}
