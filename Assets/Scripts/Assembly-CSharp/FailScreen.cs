[global::Cpp2ILInjected.Token(Token = "0x20000E9")]
public class FailScreen : Viewport
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20000EA")]
	private sealed class _003CHandleStartShow_003Ed__2 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40004DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40004DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40004DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public FailScreen _003C_003E4__this;

		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000439")]
			[global::Cpp2ILInjected.Address(RVA = "0x101E154", Offset = "0x101E154", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600043B")]
			[global::Cpp2ILInjected.Address(RVA = "0x101E19C", Offset = "0x101E19C", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000436")]
		[global::Cpp2ILInjected.Address(RVA = "0x101DEA4", Offset = "0x101DEA4", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CHandleStartShow_003Ed__2(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000437")]
		[global::Cpp2ILInjected.Address(RVA = "0x101DF58", Offset = "0x101DF58", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000438")]
		[global::Cpp2ILInjected.Address(RVA = "0x101DF5C", Offset = "0x101DF5C", Length = "0x1AC")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xC70;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv46 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv47 = v46 + 0xA38;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v47, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv61 = System.Xml.ValidateNames;\n\tv62 = v61 + 0x258;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv144 = \"cp420\";\n\tv145 = v144 + 0xDD0;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v145, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AADB]) = v42;\nL_001E:\n\tv44 = this.<>4__this;\n\tv45 = this.<>1__state == 0;\n\tif (v45) goto L_0071;\n\tv58 = this.<>1__state != 1;\n\tif (v58) goto L_0062;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tgoto L_0036;\n\tv146 = \"il2cpp_codegen_runtime_class_init\"(v67, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0036:\n\tv148 = Il2CppMethodInfo;\n\tv125 = Singleton`1::get_Instance /* +1 sharing this address */(*([v148 @ X8_v15 (Il2CppMethodInfo)+C70]));\n\tv190 = \"cp420\";\n\tAudioManager::PlayClip(v125, *([v190 @ X8_v17 (System.String)+DD0]));\n\tv126 = ApplicationManager::get_appData();\n\tv142 = v126.playerData;\n\tv204 = ~v142.hapticOn;\n\tif (v204) goto L_0053;\n\tv207 = 0x1E1AC(2, *([v190 @ X8_v17 (System.String)+DD0]), 0, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0053:\n\tv129 = UnityEngine.Component::get_gameObject(v44.titleTextEffect);\n\tUnityEngine.GameObject::SetActive(v129, 1);\n\tTextPopEffect::StartTransition(v44.titleTextEffect);\nL_0062:\n\tv85 = this.<>1__state == 0;\n\treturn v85;\nL_0071:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv130 = UnityEngine.Component::get_gameObject(v44.titleTextEffect);\n\tUnityEngine.GameObject::SetActive(v130, 0);\n\tv193 = System.Xml.ValidateNames;\n\tv196 = new *([v193 @ X8_v5 (Il2CppClass<System.Xml.ValidateNames>)+258])();\n\tUnityEngine.WaitForSeconds::.ctor(v196, 0.1f);\n\tv201 = this + 0x18;\n\tthis.<>2__current = v196;\n\tv203 = 0xF3F1B4(v201, v196, 0, v26, v27, v28, v29, v30, 0x3DCCCCCD, v32, v33, v34, v35, v36, v37, v38);\n\tthis.<>1__state = 1;\n\tv172 = this.<>1__state == 0;\n\treturn v172;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 112 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_014d: Expected I, but got O
			//IL_016d: Expected O, but got I
			//IL_006a: Expected O, but got I
			FailScreen failScreen = _003C_003E4__this;
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					_003C_003E1__state = -1;
					nint num = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
					string text = "cp420";
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X8_v17 (System.String)+DD0]");
					AudioManager audioManager = default(AudioManager);
					audioManager.PlayClip((string)0);
					ApplicationData appData = ApplicationManager.appData;
					PlayerData playerData = appData.playerData;
					if (playerData.hapticOn)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1E1AC");
					}
					global::UnityEngine.GameObject gameObject = failScreen.titleTextEffect.gameObject;
					gameObject.SetActive(value: true);
					failScreen.titleTextEffect.StartTransition();
				}
				return _003C_003E1__state == 0;
			}
			_003C_003E1__state = -1;
			global::UnityEngine.GameObject gameObject2 = failScreen.titleTextEffect.gameObject;
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
		[global::Cpp2ILInjected.Token(Token = "0x600043A")]
		[global::Cpp2ILInjected.Address(RVA = "0x101E15C", Offset = "0x101E15C", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xCB0;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 3888;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3248;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x40004D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TextPopEffect titleTextEffect;

	[global::Cpp2ILInjected.Token(Token = "0x6000433")]
	[global::Cpp2ILInjected.Address(RVA = "0x101DDAC", Offset = "0x101DDAC", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xAD8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAD9]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+AD8])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv61 = UnityEngine.MonoBehaviour::StartCoroutine(this, v45);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal override void OnStartShow()
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

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(FailScreen._003CHandleStartShow_003Ed__2))]
	[global::Cpp2ILInjected.Token(Token = "0x6000434")]
	[global::Cpp2ILInjected.Address(RVA = "0x101DE2C", Offset = "0x101DE2C", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xAD8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAD9]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+AD8])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator HandleStartShow()
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

	[global::Cpp2ILInjected.Token(Token = "0x6000435")]
	[global::Cpp2ILInjected.Address(RVA = "0x101DED0", Offset = "0x101DED0", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Xml.ValidateNames;\n\tv20 = *([302AADA]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0023;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0033;\nL_001D:\n\tViewport::.ctor(this);\n\treturn;\nL_0023:\n\t*([v16 @ X20_v1+ADA]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv62 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v62;\n\tif (v46) goto L_001D;\nL_0033:\n\tViewport::.ctor(this);\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FailScreen()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_005a: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AADA]");
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
