[global::Cpp2ILInjected.Token(Token = "0x2000027")]
public class FBWindowsPurchaseManager : global::UnityEngine.MonoBehaviour
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x200002A")]
	private sealed class _003CLoadPictureFromUrl_003Ed__6 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x40000AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x40000AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x40000AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string url;

		[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public global::UnityEngine.UI.RawImage itemImage;

		[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::UnityEngine.Texture2D _003CUserPicture_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::UnityEngine.WWW _003Cwww_003E5__3;

		[global::Cpp2ILInjected.Token(Token = "0x17000008")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600010B")]
			[global::Cpp2ILInjected.Address(RVA = "0xFE2D40", Offset = "0xFE2D40", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000009")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600010D")]
			[global::Cpp2ILInjected.Address(RVA = "0xFE2D88", Offset = "0xFE2D88", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE1348", Offset = "0xFE1348", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CLoadPictureFromUrl_003Ed__6(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE2BD8", Offset = "0xFE2BD8", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE2BDC", Offset = "0xFE2BDC", Length = "0x164")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0018;\n\tv21 = System.Net.Configuration.SettingsSectionInternal;\n\tv22 = v21 + 0x900;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Xml.ValidateNames;\n\tv46 = v45 + 0x230;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A93C]) = v42;\nL_0018:\n\tv44 = this.<>1__state == 0;\n\tif (v44) goto L_0051;\n\tv56 = this.<>1__state != 1;\n\tif (v56) goto L_0042;\n\tv63 = this + 0x38;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tUnityEngine.WWW::LoadImageIntoTexture(this.<www>5__3, this.<UserPicture>5__2);\n\tUnityEngine.WWW::Dispose(this.<www>5__3);\n\tthis.<www>5__3 = 0;\n\tv160 = 0xF3F1B4(v63, 0, 0, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tUnityEngine.UI.RawImage::set_texture(this.itemImage, this.<UserPicture>5__2);\nL_0042:\n\tv81 = this.<>1__state == 0;\n\treturn v81;\nL_0051:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv58 = System.Net.Configuration.SettingsSectionInternal;\n\tv61 = new *([v58 @ X8_v4 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+900])();\n\tUnityEngine.Texture2D::.ctor(v61, 0x20, 0x20);\n\tv148 = this + 0x30;\n\tthis.<UserPicture>5__2 = v61;\n\tv150 = 0xF3F1B4(v148, v61, 0x20, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv152 = System.Xml.ValidateNames;\n\tv155 = new *([v152 @ X8_v6 (Il2CppClass<System.Xml.ValidateNames>)+230])();\n\tUnityEngine.WWW::.ctor(v155, this.url);\n\tv162 = this + 0x38;\n\tthis.<www>5__3 = v155;\n\tv165 = 0xF3F1B4(v162, v155, 0, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv167 = this + 0x18;\n\tthis.<>2__current = this.<www>5__3;\n\tv168 = 0xF3F1B4(v167, this.<www>5__3, 0, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tthis.<>1__state = 1;\n\tv129 = this.<>1__state == 0;\n\treturn v129;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 95 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_00bf: Expected I, but got O
			//IL_00e4: Expected O, but got I
			//IL_0106: Expected I, but got O
			//IL_0127: Expected O, but got I
			//IL_014c: Expected O, but got I
			//IL_0033: Expected O, but got I
			if (_003C_003E1__state != 0)
			{
				if (_003C_003E1__state == 1)
				{
					object obj = this;
					_003C_003E1__state = -1;
					_003Cwww_003E5__3.LoadImageIntoTexture(_003CUserPicture_003E5__2);
					_003Cwww_003E5__3.Dispose();
					_003Cwww_003E5__3 = null;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					itemImage.texture = _003CUserPicture_003E5__2;
				}
				return _003C_003E1__state == 0;
			}
			_003C_003E1__state = -1;
			nint num = 0;
			global::UnityEngine.Texture2D texture2D = new global::UnityEngine.Texture2D(32, 32);
			object obj2 = this;
			_003CUserPicture_003E5__2 = texture2D;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			nint num2 = 0;
			global::UnityEngine.WWW wWW = new global::UnityEngine.WWW(url);
			object obj3 = this;
			_003Cwww_003E5__3 = wWW;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			object obj4 = this;
			_003C_003E2__current = _003Cwww_003E5__3;
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
		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE2D48", Offset = "0xFE2D48", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xC08;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3080;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.GameObject ProductGameObject;

	[global::Cpp2ILInjected.Token(Token = "0x40000A3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.Transform CatalogPanelTarnsform;

	[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.Transform PurchasesPanelTarnsform;

	[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE06BC", Offset = "0xFE06BC", Length = "0x154")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv20 = *([302A935]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_004A;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv24 = *([v22 @ X0_v36+E0]) == 0;\n\tif (v24) goto L_0052;\nL_0015:\n\tv50 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv66 = this.Logger;\n\tv60 = ~v50;\n\tif (v60) goto L_005A;\nL_001C:\n\tv81 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tFBWindowsLogsManager::DebugLog(v66, *([v81 @ X8_v11 (System.String)+9E8]));\n\tv100 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv103 = new *([v100 @ X8_v13 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+C90])();\n\tv107 = Il2CppMethodInfo;\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v103, this, *([v107 @ X8_v15 (Il2CppMethodInfo)+2C0]), 0);\n\tv142 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv127 = *([v142 @ X0_v28+E0]) == 0;\n\tif (v127) goto L_0070;\n\tFacebook.Unity.FB::GetCatalog(v103);\n\treturn;\nL_004A:\n\t*([v16 @ X20_v1+935]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv105 = *([v44 @ X0_v24+E0]) == 0;\n\tv46 = ~v105;\n\tif (v46) goto L_0015;\nL_0052:\n\tv62 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv66 = this.Logger;\n\tv77 = ~v62;\n\tv69 = ~v77;\n\tif (v69) goto L_001C;\nL_005A:\n\tv88 = \"IsCyrillic\";\n\tFBWindowsLogsManager::DebugWarningLog(v73, *([v88 @ X8_v4 (System.String)+A68]));\n\treturn;\nL_0070:\n\tFacebook.Unity.FB::GetCatalog(v103);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 76 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void GetCatalogButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_0150: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_01e4: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_00e1: Expected I, but got O
		//IL_010b: Expected O, but got I
		object obj = 50503680;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A935]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v36+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v24+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		bool isLoggedIn = global::Facebook.Unity.FB.IsLoggedIn;
		FBWindowsLogsManager logger = Logger;
		bool flag = !isLoggedIn;
		bool flag2 = !flag;
		FBWindowsLogsManager logger2 = Logger;
		if (flag2)
		{
			goto IL_00b5;
		}
		goto IL_01c6;
		IL_00b5:
		string text = "Expected ComplexType. Schema was not generated using this tool.";
		FBWindowsLogsManager fBWindowsLogsManager = logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X8_v11 (System.String)+9E8]");
		fBWindowsLogsManager.DebugLog(string.Empty);
		nint num2 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ICatalogResult> callback = null;
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v28+E0]");
		if ((nint)0 != 0)
		{
			global::Facebook.Unity.FB.GetCatalog(callback);
		}
		else
		{
			global::Facebook.Unity.FB.GetCatalog(callback);
		}
		return;
		IL_01c6:
		string text2 = "IsCyrillic";
		FBWindowsLogsManager fBWindowsLogsManager2 = logger2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (System.String)+A68]");
		fBWindowsLogsManager2.DebugWarningLog(string.Empty);
		return;
		IL_007f:
		bool isLoggedIn2 = global::Facebook.Unity.FB.IsLoggedIn;
		logger = Logger;
		bool flag3 = !isLoggedIn2;
		logger2 = Logger;
		if (!flag3)
		{
			goto IL_00b5;
		}
		goto IL_01c6;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE0810", Offset = "0xFE0810", Length = "0xAA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0055;\n\tv35 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv36 = v35 + 0x1F0;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0xB10;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv265 = Il2CppMethodInfo;\n\tv266 = v265 + 0xB20;\n\tv267 = \"il2cpp_codegen_initialize_runtime_metadata\"(v266, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv335 = Il2CppMethodInfo;\n\tv336 = v335 + 0xB28;\n\tv337 = \"il2cpp_codegen_initialize_runtime_metadata\"(v336, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv557 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv558 = v557 + 0x868;\n\tv559 = \"il2cpp_codegen_initialize_runtime_metadata\"(v558, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv603 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv604 = v603 + 0x9F0;\n\tv605 = \"il2cpp_codegen_initialize_runtime_metadata\"(v604, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv705 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv706 = v705 + 0x8C0;\n\tv707 = \"il2cpp_codegen_initialize_runtime_metadata\"(v706, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv729 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv730 = v729 + 0xA40;\n\tv731 = \"il2cpp_codegen_initialize_runtime_metadata\"(v730, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv758 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv759 = v758 + 0xA90;\n\tv760 = \"il2cpp_codegen_initialize_runtime_metadata\"(v759, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv769 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv770 = v769 + 0xDF8;\n\tv771 = \"il2cpp_codegen_initialize_runtime_metadata\"(v770, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv780 = Il2CppMethodInfo;\n\tv781 = v780 + 0xA8;\n\tv782 = \"il2cpp_codegen_initialize_runtime_metadata\"(v781, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv843 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv844 = v843 + 0xFD8;\n\tv845 = \"il2cpp_codegen_initialize_runtime_metadata\"(v844, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv946 = System.Net.Configuration.SettingsSectionInternal;\n\tv947 = v946 + 0xAA8;\n\tv948 = \"il2cpp_codegen_initialize_runtime_metadata\"(v947, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1031 = Il2CppMethodInfo;\n\tv1032 = v1031 + 0xBF0;\n\tv1033 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1032, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1152 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv1153 = v1152 + 0xA88;\n\tv1154 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1153, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1202 = System.Net.Configuration.SettingsSectionInternal;\n\tv1203 = v1202 + 0xE60;\n\tv1204 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1203, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1208 = Il2CppFieldInfo;\n\tv1209 = v1208 + 0xAB0;\n\tv1210 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1209, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1213 = \"IsCyrillic\";\n\tv1214 = v1213 + 0xA68;\n\tv1215 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1214, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1223 = \"Parent table name is missing in relation '{0}'.\";\n\tv1224 = v1223 + 0x3D8;\n\tv1225 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1224, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1255 = Il2CppFieldInfo;\n\tv1256 = v1255 + 0x960;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1256, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv55 = 1;\n\t*([302A9A9]) = v55;\nL_0055:\n\tv57 = 0;\n\tv63 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv65 = System.Net.Configuration.SettingsSectionInternal;\n\tv69 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv71 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv220 = \"IsCyrillic\" + 0xA68;\n\tv76 = UnityEngine.Transform::GetEnumerator(this.CatalogPanelTarnsform);\n\tgoto L_0072;\nL_0070:\n\tUnityEngine.Object::Destroy(v1206);\nL_0072:\n\tv377 = v208 == 0;\n\tif (v377) goto L_0371;\n\tv561 = *([v208 @ stack_-68_v11]);\n\tv719 = *([v561 @ X8_v20+12E]);\n\tv563 = *([v561 @ X8_v20+12E]) == 0;\n\tif (v563) goto L_0095;\n\tv718 = *([v561 @ X8_v20+B0]) + 8;\nL_0080:\n\tv724 = *([v718 @ X10_v74-8]) == *([v63 @ X28_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v724) goto L_0098;\n\tv718 = v718 + 0x10;\n\tv631 = v719 - 1;\n\tv611 = v719 != 1;\n\tif (v611) goto L_0080;\nL_0095:\n\tv737 = 0xF7087C(v208, *([v63 @ X28_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, v900, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tgoto L_009E;\nL_0098:\n\tv734 = *([v718 @ X10_v74]) << 4;\n\tv735 = v561 + v734;\n\tv737 = v735 + 0x138;\nL_009E:\n\t*([v737 @ X0_v36])(v740, v208, *([v737 @ X0_v36+8]), v1168, v900, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv741 = v740 & 1;\n\tv742 = v741 == 0;\n\tif (v742) goto L_00FC;\n\tv525 = v208 == 0;\n\tif (v525) goto L_0373;\n\tv773 = *([v208 @ stack_-68_v11]);\n\tv857 = *([v773 @ X8_v98+12E]);\n\tv775 = *([v773 @ X8_v98+12E]) == 0;\n\tif (v775) goto L_00C6;\n\tv856 = *([v773 @ X8_v98+B0]) + 8;\nL_00B1:\n\tv862 = *([v856 @ X10_v69-8]) == *([v63 @ X28_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v862) goto L_00C9;\n\tv856 = v856 + 0x10;\n\tv808 = v857 - 1;\n\tv788 = v857 != 1;\n\tif (v788) goto L_00B1;\nL_00C6:\n\tv955 = 0xF7087C(v208, *([v63 @ X28_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, v900, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tgoto L_00D0;\nL_00C9:\n\tv951 = *([v856 @ X10_v69]) + 1;\n\tv952 = v951 << 4;\n\tv953 = v773 + v952;\n\tv955 = v953 + 0x138;\nL_00D0:\n\t*([v955 @ X0_v157])(v958, v208, *([v955 @ X0_v157+8]), v1168, v900, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv524 = v958 == 0;\n\tif (v524) goto L_0375;\n\tv478 = *([v65 @ X22_v12 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv1034 = *([v958 @ X0_v159 (UnityEngine.Component)]);\n\tv1035 = *([v1034 @ X8_v101 (Il2CppClass<UnityEngine.Component>)+130]) < *([v478 @ X1_v65 (System.String)+130]);\n\tv1036 = ~v1035;\n\tv1044 = ~v1036;\n\tif (v1044) goto L_036F;\n\tv341 = *([v478 @ X1_v65 (System.String)+130]) << 3;\n\tv1156 = *([v1034 @ X8_v101 (Il2CppClass<UnityEngine.Component>)+C8]) + v341;\n\tv345 = *([v1156 @ X8_v104-8]) != v478;\n\tif (v345) goto L_036F;\n\tv1206 = UnityEngine.Component::get_gameObject(v958);\n\tgoto L_0070;\n\tv1216 = \"il2cpp_codegen_runtime_class_init\"(v1211, v1205, v343, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tgoto L_0070;\nL_00FC:\n\tv761 = &v208 @ stack_-68_v11;\n\tv90 = &v57 @ stack_-70_v1;\n\tv677 = *([v69 @ X27_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv764 = 0xF3F36C(*([v761 @ X8_v23]), *([v69 @ X27_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v1168, v900, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\t*([v90 @ X24_v11]) = v764;\n\tv776 = v764 == 0;\n\tif (v776) goto L_FFFFFFFF;\nL_0106:\n\tv814 = *([v764 @ X0_v40]);\n\tv970 = *([v814 @ X8_v94+12E]);\n\tv816 = *([v814 @ X8_v94+12E]) == 0;\n\tif (v816) goto L_0126;\n\tv969 = *([v814 @ X8_v94+B0]) + 8;\nL_0111:\n\tv975 = *([v969 @ X10_v62-8]) == *([v69 @ X27_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tif (v975) goto L_0129;\n\tv969 = v969 + 0x10;\n\tv892 = v970 - 1;\n\tv872 = v970 != 1;\n\tif (v872) goto L_0111;\nL_0126:\n\tv1050 = 0xF7087C(v764, *([v69 @ X27_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelp\n// ... truncated")]
	private void ProcessGetCatalog(global::Facebook.Unity.ICatalogResult result)
	{
		//IL_126a: Expected O, but got I4
		//IL_0013: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_002f: Expected I, but got O
		//IL_003d: Expected I, but got O
		//IL_0047: Unknown result type (might be due to invalid IL or missing references)
		//IL_004c: Expected O, but got Unknown
		//IL_00a3: Expected O, but got I
		//IL_0138: Expected I, but got O
		//IL_00de: Expected O, but got I
		//IL_035d: Expected O, but got I
		//IL_014b: Expected I4, but got O
		//IL_0159: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_03a4: Expected O, but got I
		//IL_00f2: Expected O, but got I
		//IL_0101: Expected O, but got I
		//IL_0439: Expected I, but got O
		//IL_01a2: Expected O, but got I
		//IL_137b: Expected O, but got I
		//IL_03df: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_044c: Expected I4, but got O
		//IL_045a: Expected O, but got I
		//IL_0469: Expected O, but got I
		//IL_03f3: Expected O, but got I
		//IL_0402: Expected O, but got I
		//IL_028f: Expected O, but got I
		//IL_0297: Expected I, but got O
		//IL_0249: Unknown result type (might be due to invalid IL or missing references)
		//IL_024e: Expected O, but got Unknown
		//IL_026b: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_01f1: Expected O, but got I
		//IL_0200: Expected O, but got I
		//IL_0304: Expected O, but got I
		object obj = 0;
		nint num = 0;
		nint num2 = 0;
		nint num3 = 0;
		nint num4 = 0;
		object obj2 = "IsCyrillic" + 2664;
		global::System.Collections.IEnumerator enumerator = CatalogPanelTarnsform.GetEnumerator();
		object obj3 = default(object);
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj12 = default(object);
		object obj22 = default(object);
		while (true)
		{
			if (obj3 != null)
			{
				object obj4 = obj3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v20+12E]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v20+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0129;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v561 @ X8_v20+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X10_v74-8]");
					nint num5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X28_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num5 == 0)
					{
						break;
					}
					obj6 = (nint)obj6 + 16;
					object obj7 = (nint)obj5 - 1;
					bool flag = (nint)obj5 != 1;
					obj5 = obj7;
					if (flag)
					{
						continue;
					}
					goto IL_0129;
				}
				int num6 = obj6 << 4;
				object obj8 = (nint)obj4 + num6;
				object obj9 = (nint)obj8 + 312;
				goto IL_129b;
			}
			throw new global::System.NullReferenceException();
			IL_0228:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			nint num7 = 1;
			goto IL_12fd;
			IL_136b:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1050 @ X0_v150+8]");
			string text = string.Empty;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1050 @ X0_v150] (should have been resolved before IL gen)");
			break;
			IL_042a:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num7 = unchecked((nint)0);
			goto IL_136b;
			IL_12fd:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v955 @ X0_v157] (should have been resolved before IL gen)");
			if ((object)component != null)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X22_v12 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
				string text2 = string.Empty;
				nint num8 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v101 (Il2CppClass<UnityEngine.Component>)+130]");
				nint num9 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X1_v65 (System.String)+130]");
				if (num9 >= 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v478 @ X1_v65 (System.String)+130]");
					int num10 = (int)((nint)0 << 3);
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1034 @ X8_v101 (Il2CppClass<UnityEngine.Component>)+C8]");
					object obj10 = (nint)0 + (nint)num10;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1156 @ X8_v104-8]");
					if (0 == (nint)text2)
					{
						global::UnityEngine.GameObject obj11 = component.gameObject;
						global::UnityEngine.Object.Destroy(obj11);
						continue;
					}
				}
				throw new global::System.InvalidCastException();
			}
			throw new global::System.NullReferenceException();
			IL_0129:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num7 = unchecked((nint)0);
			goto IL_129b;
			IL_129b:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v737 @ X0_v36] (should have been resolved before IL gen)");
			if ((int)((nint)obj12 & 1) != 0)
			{
				if (obj3 != null)
				{
					object obj13 = obj3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v98+12E]");
					object obj14 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v98+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0228;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v773 @ X8_v98+B0]");
					object obj15 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v856 @ X10_v69-8]");
						nint num11 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X28_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num11 == 0)
						{
							break;
						}
						obj15 = (nint)obj15 + 16;
						object obj16 = (nint)obj14 - 1;
						bool flag2 = (nint)obj14 != 1;
						obj14 = obj16;
						if (flag2)
						{
							continue;
						}
						goto IL_0228;
					}
					object obj17 = obj15 + 1;
					int num12 = (int)((nint)obj17 << 4);
					object obj18 = (nint)obj13 + num12;
					object obj19 = (nint)obj18 + 312;
					goto IL_12fd;
				}
				throw new global::System.NullReferenceException();
			}
			object obj20 = obj3;
			object obj21 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
			text = string.Empty;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			obj21 = obj22;
			if (obj22 == null)
			{
				break;
			}
			object obj23 = obj22;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v94+12E]");
			object obj24 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v94+12E]");
			if ((nint)0 == 0)
			{
				goto IL_042a;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v814 @ X8_v94+B0]");
			object obj25 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v969 @ X10_v62-8]");
				nint num13 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
				if (num13 == 0)
				{
					break;
				}
				obj25 = (nint)obj25 + 16;
				object obj26 = (nint)obj24 - 1;
				bool flag3 = (nint)obj24 != 1;
				obj24 = obj26;
				if (flag3)
				{
					continue;
				}
				goto IL_042a;
			}
			int num14 = obj25 << 4;
			object obj27 = (nint)obj23 + num14;
			object obj28 = (nint)obj27 + 312;
			goto IL_136b;
		}
		object obj29 = obj3;
		int num15 = 0;
		throw new global::System.OutOfMemoryException();
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(FBWindowsPurchaseManager._003CLoadPictureFromUrl_003Ed__6))]
	[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE12BC", Offset = "0xFE12BC", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0018;\n\tv25 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv26 = v25 + 0xA98;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, url, itemImage, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = 1;\n\t*([302A9AA]) = v44;\nL_0018:\n\tv46 = new *([v20 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+A98])();\n\tSystem.Object::.ctor(v46);\n\t*([v46 @ X0_v3 (System.Object)+10]) = 0;\n\tv50 = v46 + 0x20;\n\t*([v46 @ X0_v3 (System.Object)+20]) = url;\n\tv52 = 0xF3F1B4(v50, url, itemImage, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv54 = v46 + 0x28;\n\t*([v46 @ X0_v3 (System.Object)+28]) = itemImage;\n\tv56 = 0xF3F1B4(v54, itemImage, itemImage, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v46;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator LoadPictureFromUrl(string url, global::UnityEngine.UI.RawImage itemImage)
	{
		//IL_000e: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_0022: Expected O, but got I
		_003CLoadPictureFromUrl_003Ed__6 stateMachine = new _003CLoadPictureFromUrl_003Ed__6(0);
		stateMachine.url = url;
		stateMachine.itemImage = itemImage;
		return stateMachine;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE1374", Offset = "0xFE1374", Length = "0x9E4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_004F;\n\tv27 = CollectParticleData[];\n\tv28 = v27 + 0xFF8;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv52 = System.ComponentModel.BooleanConverter;\n\tv53 = v52 + 0xB30;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv789 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv790 = v789 + 0xDA0;\n\tv791 = \"il2cpp_codegen_initialize_runtime_metadata\"(v790, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv792 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv793 = v792 + 0xDF8;\n\tv794 = \"il2cpp_codegen_initialize_runtime_metadata\"(v793, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv856 = \"Parent table name is missing in relation '{0}'.\";\n\tv857 = v856 + 0x548;\n\tv858 = \"il2cpp_codegen_initialize_runtime_metadata\"(v857, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv888 = \"DarkSalmon\";\n\tv889 = v888 + 0x540;\n\tv890 = \"il2cpp_codegen_initialize_runtime_metadata\"(v889, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv912 = \"Hungarian\";\n\tv913 = v912 + 0xFE8;\n\tv914 = \"il2cpp_codegen_initialize_runtime_metadata\"(v913, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv941 = \"Parent table name is missing in relation '{0}'.\";\n\tv942 = v941 + 0x560;\n\tv943 = \"il2cpp_codegen_initialize_runtime_metadata\"(v942, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv949 = \"Parent table name is missing in relation '{0}'.\";\n\tv950 = v949 + 0x100;\n\tv951 = \"il2cpp_codegen_initialize_runtime_metadata\"(v950, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv982 = \"Parent table name is missing in relation '{0}'.\";\n\tv983 = v982 + 0x578;\n\tv984 = \"il2cpp_codegen_initialize_runtime_metadata\"(v983, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv1011 = \", R=\";\n\tv1012 = v1011 + 0x118;\n\tv1013 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1012, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv1049 = \"Scrollbar Horizontal\";\n\tv1050 = v1049 + 0x378;\n\tv1051 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1050, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv1052 = \"Parent table name is missing in relation '{0}'.\";\n\tv1053 = v1052 + 0xF0;\n\tv1054 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1053, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv1061 = \"Parent table name is missing in relation '{0}'.\";\n\tv1062 = v1061 + 0x558;\n\tv1063 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1062, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv1064 = \"Parent table name is missing in relation '{0}'.\";\n\tv1065 = v1064 + 0x410;\n\tv1066 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1065, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv1069 = \"Parent table name is missing in relation '{0}'.\";\n\tv1070 = v1069 + 0x588;\n\tv1071 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1070, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv1076 = \"Parent table name is missing in relation '{0}'.\";\n\tv1077 = v1076 + 0x538;\n\tv1078 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1077, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv1094 = \"Parent table name is missing in relation '{0}'.\";\n\tv1095 = v1094 + 0x3F8;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1095, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A936]) = v47;\nL_004F:\n\tv55 = \"Parent table name is missing in relation '{0}'.\";\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v55 @ X8_v4 (System.String)+538]));\n\tv795 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv797 = result->klass;\n\tv902 = result->klass->rank;\n\tv799 = *([v797 @ X8_v6 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]) == 0;\n\tif (v799) goto L_0078;\n\tv901 = *([v797 @ X8_v6 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]) + 8;\nL_0063:\n\tv907 = *([v901 @ X10_v85-8]) == *([v795 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v907) goto L_007B;\n\tv901 = v901 + 0x10;\n\tv884 = v902 - 1;\n\tv864 = v902 != 1;\n\tif (v864) goto L_0063;\nL_0078:\n\tv932 = 0xF7087C(result, *([v795 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_007E;\nL_007B:\n\tv917 = *([v901 @ X10_v85]) << 4;\n\tv55 = v797 + v917;\n\tv932 = v55 + 0x138;\nL_007E:\n\tv55 = *([v932 @ X0_v5]);\n\t*([v932 @ X0_v5])(v937, result, *([v932 @ X0_v5+8]), v1020, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv938 = result->klass;\n\tv1007 = result->klass->rank;\n\tv940 = v937 == 0;\n\tif (v940) goto L_00AF;\n\tv945 = *([v938 @ X8_v9 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]) == 0;\n\tif (v945) goto L_00A6;\n\tv525 = *([v938 @ X8_v9 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]) + 8;\nL_0091:\n\tv365 = *([v525 @ X10_v80-8]) == *([v795 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v365) goto L_00DA;\n\tv525 = v525 + 0x10;\n\tv964 = v1007 - 1;\n\tv954 = v1007 != 1;\n\tif (v954) goto L_0091;\nL_00A6:\n\tv966 = 0xF7087C(result, *([v795 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([v966 @ X0_v157])(v1033, result, *([v966 @ X0_v157+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv997 = this.Logger == 0;\n\tv692 = ~v997;\n\tif (v692) goto L_00E5;\n\tgoto L_03F4;\nL_00AF:\n\tv946 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv948 = *([v938 @ X8_v9 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]) == 0;\n\tif (v948) goto L_00D0;\n\tv526 = *([v938 @ X8_v9 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]) + 8;\nL_00BB:\n\tv366 = *([v526 @ X10_v74-8]) == *([v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]);\n\tif (v366) goto L_00E8;\n\tv526 = v526 + 0x10;\n\tv979 = v1007 - 1;\n\tv969 = v1007 != 1;\n\tif (v969) goto L_00BB;\nL_00D0:\n\tv981 = 0xF7087C(result, *([v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv55 = *([v981 @ X0_v148]);\n\t*([v981 @ X0_v148])(v1044, result, *([v981 @ X0_v148+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv1010 = v1044 == 0;\n\tv693 = ~v1010;\n\tif (v693) goto L_00F2;\n\tgoto L_03F4;\nL_00DA:\n\tv107 = *([v525 @ X10_v80]) << 4;\n\tv55 = v938 + v107;\n\tv1016 = v55 + 0x138;\n\t*([v1016 @ X0_v160])(v1033, result, *([v1016 @ X0_v160+8]), v1020, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_00E5:\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v1033);\n\tgoto L_03E9;\nL_00E8:\n\tv108 = *([v526 @ X10_v74]) << 4;\n\tv55 = v938 + v108;\n\tv1040 = v55 + 0x138;\n\tv55 = *([v1040 @ X0_v151]);\n\t*([v1040 @ X0_v151])(v1044, result, *([v1040 @ X0_v151+8]), v1020, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_00F2:\n\tv55 = \"Parent table name is missing in relation '{0}'.\";\n\tv652 = System.String::Concat(*([v55 @ X8_v4 (System.String)+3F8]), *([v1044 @ X0_v10+30]));\n\tFBWindowsLogsManager::DebugLog(this.Logger, v652);\n\tv1067 = \", R=\";\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v1067 @ X22_v6 (System.String)+118]));\n\tv1073 = result->klass;\n\tv1105 = result->klass->rank;\n\tv1075 = *([v1073 @ X8_v14 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]) == 0;\n\tif (v1075) goto L_0125;\n\tv529 = *([v1073 @ X8_v14 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]) + 8;\nL_0110:\n\tv369 = *([v529 @ X10_v69-8]) == *([v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]);\n\tif (v369) goto L_012F;\n\tv529 = v529 + 0x10;\n\tv1091 = v1105 - 1;\n\tv1\n// ... truncated")]
	private void ProcessPurchase(global::Facebook.Unity.IPurchaseResult result)
	{
		//IL_0025: Expected O, but got I
		//IL_0038: Expected I, but got O
		//IL_0040: Expected I, but got O
		//IL_0050: Expected O, but got I
		//IL_00e5: Expected I, but got O
		//IL_13f9: Expected I, but got O
		//IL_1409: Expected O, but got I
		//IL_008b: Expected O, but got I
		//IL_01f6: Expected I, but got O
		//IL_00f8: Expected I4, but got O
		//IL_0106: Expected O, but got I
		//IL_0115: Expected O, but got I
		//IL_037c: Expected O, but got I
		//IL_037c: Expected O, but got I
		//IL_0231: Expected O, but got I
		//IL_01d5: Expected I, but got O
		//IL_009f: Expected O, but got I
		//IL_00ae: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_03b9: Expected O, but got I
		//IL_03c1: Expected I, but got O
		//IL_03d1: Expected O, but got I
		//IL_0322: Expected I4, but got O
		//IL_0330: Expected O, but got I
		//IL_033f: Expected O, but got I
		//IL_0245: Expected O, but got I
		//IL_0254: Expected O, but got I
		//IL_02d3: Expected I4, but got O
		//IL_02e1: Expected O, but got I
		//IL_02f0: Expected O, but got I
		//IL_0508: Expected O, but got I
		//IL_0508: Expected O, but got I
		//IL_040c: Expected O, but got I
		//IL_0169: Expected O, but got I
		//IL_0178: Expected O, but got I
		//IL_0528: Expected I, but got O
		//IL_0538: Expected O, but got I
		//IL_04ae: Expected I4, but got O
		//IL_04bc: Expected O, but got I
		//IL_04cb: Expected O, but got I
		//IL_0573: Expected O, but got I
		//IL_0420: Expected O, but got I
		//IL_042f: Expected O, but got I
		//IL_0689: Expected O, but got I
		//IL_06a9: Expected I, but got O
		//IL_06b9: Expected O, but got I
		//IL_0615: Expected I4, but got O
		//IL_0623: Expected O, but got I
		//IL_0632: Expected O, but got I
		//IL_0587: Expected O, but got I
		//IL_0596: Expected O, but got I
		//IL_07f0: Expected O, but got I
		//IL_07f0: Expected O, but got I
		//IL_06f4: Expected O, but got I
		//IL_0810: Expected I, but got O
		//IL_0820: Expected O, but got I
		//IL_0796: Expected I4, but got O
		//IL_07a4: Expected O, but got I
		//IL_07b3: Expected O, but got I
		//IL_0957: Expected O, but got I
		//IL_0957: Expected O, but got I
		//IL_085b: Expected O, but got I
		//IL_0708: Expected O, but got I
		//IL_0717: Expected O, but got I
		//IL_0977: Expected I, but got O
		//IL_0987: Expected O, but got I
		//IL_08fd: Expected I4, but got O
		//IL_090b: Expected O, but got I
		//IL_091a: Expected O, but got I
		//IL_0abe: Expected O, but got I
		//IL_0abe: Expected O, but got I
		//IL_09c2: Expected O, but got I
		//IL_086f: Expected O, but got I
		//IL_087e: Expected O, but got I
		//IL_0ade: Expected I, but got O
		//IL_0aee: Expected O, but got I
		//IL_0a64: Expected I4, but got O
		//IL_0a72: Expected O, but got I
		//IL_0a81: Expected O, but got I
		//IL_0c25: Expected O, but got I
		//IL_0c25: Expected O, but got I
		//IL_0b29: Expected O, but got I
		//IL_09d6: Expected O, but got I
		//IL_09e5: Expected O, but got I
		//IL_0c45: Expected I, but got O
		//IL_0c55: Expected O, but got I
		//IL_0bcb: Expected I4, but got O
		//IL_0bd9: Expected O, but got I
		//IL_0be8: Expected O, but got I
		//IL_0d76: Expected O, but got I
		//IL_0c90: Expected O, but got I
		//IL_0b3d: Expected O, but got I
		//IL_0b4c: Expected O, but got I
		//IL_0da1: Expected O, but got I
		//IL_0da1: Expected O, but got I
		//IL_0dc1: Expected I, but got O
		//IL_0dd1: Expected O, but got I
		//IL_0d32: Expected I4, but got O
		//IL_0d40: Expected O, but got I
		//IL_0d4f: Expected O, but got I
		//IL_0ca4: Expected O, but got I
		//IL_0cb3: Expected O, but got I
		//IL_0ef2: Expected O, but got I
		//IL_0e0c: Expected O, but got I
		//IL_0f1d: Expected O, but got I
		//IL_0f1d: Expected O, but got I
		//IL_0f3d: Expected I, but got O
		//IL_0f4d: Expected O, but got I
		//IL_0eae: Expected I4, but got O
		//IL_0ebc: Expected O, but got I
		//IL_0ecb: Expected O, but got I
		//IL_0e20: Expected O, but got I
		//IL_0e2f: Expected O, but got I
		//IL_106e: Expected O, but got I
		//IL_0f88: Expected O, but got I
		//IL_109e: Expected O, but got I
		//IL_10be: Expected I, but got O
		//IL_10ce: Expected O, but got I
		//IL_102a: Expected I4, but got O
		//IL_1038: Expected O, but got I
		//IL_1047: Expected O, but got I
		//IL_0f9c: Expected O, but got I
		//IL_0fab: Expected O, but got I
		//IL_1205: Expected O, but got I
		//IL_1205: Expected O, but got I
		//IL_1109: Expected O, but got I
		//IL_1225: Expected I, but got O
		//IL_1235: Expected O, but got I
		//IL_11ab: Expected I4, but got O
		//IL_11b9: Expected O, but got I
		//IL_11c8: Expected O, but got I
		//IL_136c: Expected O, but got I
		//IL_136c: Expected O, but got I
		//IL_1270: Expected O, but got I
		//IL_111d: Expected O, but got I
		//IL_112c: Expected O, but got I
		//IL_13a1: Expected O, but got I
		//IL_1312: Expected I4, but got O
		//IL_1320: Expected O, but got I
		//IL_132f: Expected O, but got I
		//IL_1284: Expected O, but got I
		//IL_1293: Expected O, but got I
		string text = "Parent table name is missing in relation '{0}'.";
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+538]");
		logger.DebugLog(string.Empty);
		nint num = 0;
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v6 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v6 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00d6;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v797 @ X8_v6 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v901 @ X10_v85-8]");
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
			if (num3 == 0)
			{
				break;
			}
			obj2 = (nint)obj2 + 16;
			object obj3 = (nint)obj - 1;
			bool flag = (nint)obj != 1;
			obj = obj3;
			if (flag)
			{
				continue;
			}
			goto IL_00d6;
		}
		int num4 = obj2 << 4;
		text = (string)(num2 + num4);
		object obj4 = (nint)text + 312;
		goto IL_13df;
		IL_07ca:
		text = "DarkSalmon";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+540]");
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1217 @ X0_v27+10]");
		string message = (string)num5 + string.Empty;
		Logger.DebugLog(message);
		nint num6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v30 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v30 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_08a6;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v30 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj6 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v538 @ X10_v54-8]");
			nint num7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num7 == 0)
			{
				break;
			}
			obj6 = (nint)obj6 + 16;
			object obj7 = (nint)obj5 - 1;
			bool flag2 = (nint)obj5 != 1;
			obj5 = obj7;
			if (flag2)
			{
				continue;
			}
			goto IL_08a6;
		}
		int num8 = obj6 << 4;
		text = (string)(num6 + num8);
		object obj8 = (nint)text + 312;
		text = (string)obj8;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1258 @ X0_v122] (should have been resolved before IL gen)");
		goto IL_0931;
		IL_0ee2:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v678 @ X0_v47+40]");
		text = string.Empty;
		text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+560]");
		nint num9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+18]");
		string message2 = (string)num9 + string.Empty;
		Logger.DebugLog(message2);
		nint num10 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1444 @ X8_v52 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1444 @ X8_v52 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0fd3;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1444 @ X8_v52 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj10 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X10_v29-8]");
			nint num11 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num11 == 0)
			{
				break;
			}
			obj10 = (nint)obj10 + 16;
			object obj11 = (nint)obj9 - 1;
			bool flag3 = (nint)obj9 != 1;
			obj9 = obj11;
			if (flag3)
			{
				continue;
			}
			goto IL_0fd3;
		}
		int num12 = obj10 << 4;
		text = (string)(num10 + num12);
		object obj12 = (nint)text + 312;
		text = (string)obj12;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1477 @ X0_v87] (should have been resolved before IL gen)");
		goto IL_105e;
		IL_0fd3:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj13 = default(object);
		text = (string)obj13;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1461 @ X0_v84] (should have been resolved before IL gen)");
		object obj14 = default(object);
		if (obj14 != null)
		{
			goto IL_105e;
		}
		goto IL_13ad;
		IL_11df:
		text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+588]");
		nint num13 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1538 @ X0_v59+50]");
		string message3 = (string)num13 + string.Empty;
		Logger.DebugLog(message3);
		nint num14 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v64 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj15 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v64 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_12bb;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1546 @ X8_v64 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v559 @ X10_v19-8]");
			nint num15 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num15 == 0)
			{
				break;
			}
			obj16 = (nint)obj16 + 16;
			object obj17 = (nint)obj15 - 1;
			bool flag4 = (nint)obj15 != 1;
			obj15 = obj17;
			if (flag4)
			{
				continue;
			}
			goto IL_12bb;
		}
		int num16 = obj16 << 4;
		text = (string)(num14 + num16);
		object obj18 = (nint)text + 312;
		text = (string)obj18;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1579 @ X0_v72] (should have been resolved before IL gen)");
		goto IL_1346;
		IL_00d6:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		nint num17 = unchecked((nint)0);
		goto IL_13df;
		IL_13df:
		text = (string)obj4;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v932 @ X0_v5] (should have been resolved before IL gen)");
		nint num18 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X8_v9 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj19 = 0;
		object obj20 = default(object);
		if (obj20 != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X8_v9 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01a0;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X8_v9 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
			object obj21 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v525 @ X10_v80-8]");
				nint num19 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v795 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
				if (num19 == 0)
				{
					break;
				}
				obj21 = (nint)obj21 + 16;
				object obj22 = (nint)obj19 - 1;
				bool flag5 = (nint)obj19 != 1;
				obj19 = obj22;
				if (flag5)
				{
					continue;
				}
				goto IL_01a0;
			}
			int num20 = obj21 << 4;
			text = (string)(num18 + num20);
			object obj23 = (nint)text + 312;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1016 @ X0_v160] (should have been resolved before IL gen)");
			goto IL_02ff;
		}
		nint num21 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X8_v9 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_027c;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v938 @ X8_v9 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v526 @ X10_v74-8]");
			nint num22 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num22 == 0)
			{
				break;
			}
			obj24 = (nint)obj24 + 16;
			object obj25 = (nint)obj19 - 1;
			bool flag6 = (nint)obj19 != 1;
			obj19 = obj25;
			if (flag6)
			{
				continue;
			}
			goto IL_027c;
		}
		int num23 = obj24 << 4;
		text = (string)(num18 + num23);
		object obj26 = (nint)text + 312;
		text = (string)obj26;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1040 @ X0_v151] (should have been resolved before IL gen)");
		goto IL_0356;
		IL_08a6:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj27 = default(object);
		text = (string)obj27;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1242 @ X0_v119] (should have been resolved before IL gen)");
		object obj28 = default(object);
		if (obj28 != null)
		{
			goto IL_0931;
		}
		goto IL_13ad;
		IL_0d66:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v674 @ X0_v43+40]");
		text = string.Empty;
		text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+558]");
		nint num24 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+10]");
		string message4 = (string)num24 + string.Empty;
		Logger.DebugLog(message4);
		nint num25 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v47 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj29 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v47 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0e57;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1402 @ X8_v47 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v550 @ X10_v34-8]");
			nint num26 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num26 == 0)
			{
				break;
			}
			obj30 = (nint)obj30 + 16;
			object obj31 = (nint)obj29 - 1;
			bool flag7 = (nint)obj29 != 1;
			obj29 = obj31;
			if (flag7)
			{
				continue;
			}
			goto IL_0e57;
		}
		int num27 = obj30 << 4;
		text = (string)(num25 + num27);
		object obj32 = (nint)text + 312;
		text = (string)obj32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1435 @ X0_v94] (should have been resolved before IL gen)");
		goto IL_0ee2;
		IL_105e:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1481 @ X0_v51+48]");
		string text2 = default(global::System.DateTime).ToString();
		text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+578]");
		string message5 = string.Empty + text2;
		Logger.DebugLog(message5);
		nint num28 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v60 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj33 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v60 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_1154;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1501 @ X8_v60 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj34 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X10_v24-8]");
			nint num29 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num29 == 0)
			{
				break;
			}
			obj34 = (nint)obj34 + 16;
			object obj35 = (nint)obj33 - 1;
			bool flag8 = (nint)obj33 != 1;
			obj33 = obj35;
			if (flag8)
			{
				continue;
			}
			goto IL_1154;
		}
		int num30 = obj34 << 4;
		text = (string)(num28 + num30);
		object obj36 = (nint)text + 312;
		text = (string)obj36;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1534 @ X0_v79] (should have been resolved before IL gen)");
		goto IL_11df;
		IL_0931:
		text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+100]");
		nint num31 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1262 @ X0_v31+28]");
		string message6 = (string)num31 + string.Empty;
		Logger.DebugLog(message6);
		nint num32 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v34 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj37 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v34 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0a0d;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1270 @ X8_v34 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj38 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v541 @ X10_v49-8]");
			nint num33 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num33 == 0)
			{
				break;
			}
			obj38 = (nint)obj38 + 16;
			object obj39 = (nint)obj37 - 1;
			bool flag9 = (nint)obj37 != 1;
			obj37 = obj39;
			if (flag9)
			{
				continue;
			}
			goto IL_0a0d;
		}
		int num34 = obj38 << 4;
		text = (string)(num32 + num34);
		object obj40 = (nint)text + 312;
		text = (string)obj40;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1303 @ X0_v115] (should have been resolved before IL gen)");
		goto IL_0a98;
		IL_13ad:
		throw new global::System.NullReferenceException();
		IL_027c:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj41 = default(object);
		text = (string)obj41;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v981 @ X0_v148] (should have been resolved before IL gen)");
		object obj42 = default(object);
		if (obj42 != null)
		{
			goto IL_0356;
		}
		goto IL_13ad;
		IL_0356:
		text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+3F8]");
		nint num35 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1044 @ X0_v10+30]");
		string message7 = (string)num35 + string.Empty;
		Logger.DebugLog(message7);
		string text3 = ", R=";
		FBWindowsLogsManager logger2 = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X22_v6 (System.String)+118]");
		logger2.DebugLog(string.Empty);
		nint num36 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X8_v14 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj43 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X8_v14 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0457;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1073 @ X8_v14 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj44 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X10_v69-8]");
			nint num37 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num37 == 0)
			{
				break;
			}
			obj44 = (nint)obj44 + 16;
			object obj45 = (nint)obj43 - 1;
			bool flag10 = (nint)obj43 != 1;
			obj43 = obj45;
			if (flag10)
			{
				continue;
			}
			goto IL_0457;
		}
		int num38 = obj44 << 4;
		text = (string)(num36 + num38);
		object obj46 = (nint)text + 312;
		text = (string)obj46;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1111 @ X0_v144] (should have been resolved before IL gen)");
		goto IL_04e2;
		IL_0a0d:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj47 = default(object);
		text = (string)obj47;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1287 @ X0_v112] (should have been resolved before IL gen)");
		object obj48 = default(object);
		if (obj48 != null)
		{
			goto IL_0a98;
		}
		goto IL_13ad;
		IL_0a98:
		text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+F0]");
		nint num39 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X0_v35+20]");
		string message8 = (string)num39 + string.Empty;
		Logger.DebugLog(message8);
		nint num40 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X8_v38 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj49 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X8_v38 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0b74;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1315 @ X8_v38 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj50 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v544 @ X10_v44-8]");
			nint num41 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num41 == 0)
			{
				break;
			}
			obj50 = (nint)obj50 + 16;
			object obj51 = (nint)obj49 - 1;
			bool flag11 = (nint)obj49 != 1;
			obj49 = obj51;
			if (flag11)
			{
				continue;
			}
			goto IL_0b74;
		}
		int num42 = obj50 << 4;
		text = (string)(num40 + num42);
		object obj52 = (nint)text + 312;
		text = (string)obj52;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1348 @ X0_v108] (should have been resolved before IL gen)");
		goto IL_0bff;
		IL_13a6:
		GetPurchases();
		return;
		IL_12bb:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj53 = default(object);
		text = (string)obj53;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1563 @ X0_v69] (should have been resolved before IL gen)");
		object obj54 = default(object);
		if (obj54 != null)
		{
			goto IL_1346;
		}
		goto IL_13ad;
		IL_0457:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj55 = default(object);
		text = (string)obj55;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1093 @ X0_v141] (should have been resolved before IL gen)");
		object obj56 = default(object);
		if (obj56 != null)
		{
			goto IL_04e2;
		}
		goto IL_13ad;
		IL_04e2:
		text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+410]");
		nint num43 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1115 @ X0_v15+30]");
		string message9 = (string)num43 + string.Empty;
		Logger.DebugLog(message9);
		nint num44 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X8_v18 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj57 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X8_v18 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05be;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1123 @ X8_v18 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj58 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v532 @ X10_v64-8]");
			nint num45 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num45 == 0)
			{
				break;
			}
			obj58 = (nint)obj58 + 16;
			object obj59 = (nint)obj57 - 1;
			bool flag12 = (nint)obj57 != 1;
			obj57 = obj59;
			if (flag12)
			{
				continue;
			}
			goto IL_05be;
		}
		int num46 = obj58 << 4;
		text = (string)(num44 + num46);
		object obj60 = (nint)text + 312;
		text = (string)obj60;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1156 @ X0_v137] (should have been resolved before IL gen)");
		goto IL_0649;
		IL_02ff:
		string message10 = default(string);
		Logger.DebugErrorLog(message10);
		goto IL_13a6;
		IL_01a0:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v966 @ X0_v157] (should have been resolved before IL gen)");
		bool flag13 = (object)Logger == null;
		bool flag14 = !flag13;
		num17 = unchecked((nint)0);
		if (flag14)
		{
			goto IL_02ff;
		}
		goto IL_13ad;
		IL_0cdb:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj61 = default(object);
		text = (string)obj61;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1377 @ X0_v98] (should have been resolved before IL gen)");
		object obj62 = default(object);
		if (obj62 != null)
		{
			goto IL_0d66;
		}
		goto IL_13ad;
		IL_1346:
		text = "Scrollbar Horizontal";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+378]");
		nint num47 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1583 @ X0_v63+58]");
		string message11 = (string)num47 + string.Empty;
		Logger.DebugLog(message11);
		FBWindowsLogsManager logger3 = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1067 @ X22_v6 (System.String)+118]");
		logger3.DebugLog(string.Empty);
		goto IL_13a6;
		IL_05be:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj63 = default(object);
		text = (string)obj63;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1140 @ X0_v134] (should have been resolved before IL gen)");
		object obj64 = default(object);
		if (obj64 != null)
		{
			goto IL_0649;
		}
		goto IL_13ad;
		IL_0649:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1160 @ X0_v19+18]");
		string text4 = false.ToString();
		text = "Hungarian";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+FE8]");
		string message12 = string.Empty + text4;
		Logger.DebugLog(message12);
		nint num48 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v26 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj65 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v26 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_073f;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1180 @ X8_v26 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj66 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v535 @ X10_v59-8]");
			nint num49 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num49 == 0)
			{
				break;
			}
			obj66 = (nint)obj66 + 16;
			object obj67 = (nint)obj65 - 1;
			bool flag15 = (nint)obj65 != 1;
			obj65 = obj67;
			if (flag15)
			{
				continue;
			}
			goto IL_073f;
		}
		int num50 = obj66 << 4;
		text = (string)(num48 + num50);
		object obj68 = (nint)text + 312;
		text = (string)obj68;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1213 @ X0_v129] (should have been resolved before IL gen)");
		goto IL_07ca;
		IL_0b74:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj69 = default(object);
		text = (string)obj69;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1332 @ X0_v105] (should have been resolved before IL gen)");
		object obj70 = default(object);
		if (obj70 != null)
		{
			goto IL_0bff;
		}
		goto IL_13ad;
		IL_0bff:
		text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (System.String)+548]");
		nint num51 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1352 @ X0_v39+38]");
		string message13 = (string)num51 + string.Empty;
		Logger.DebugLog(message13);
		nint num52 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1360 @ X8_v42 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		object obj71 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1360 @ X8_v42 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0cdb;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1360 @ X8_v42 (Il2CppClass<Facebook.Unity.IPurchaseResult>)+B0]");
		object obj72 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X10_v39-8]");
			nint num53 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v946 @ X23_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DA0]");
			if (num53 == 0)
			{
				break;
			}
			obj72 = (nint)obj72 + 16;
			object obj73 = (nint)obj71 - 1;
			bool flag16 = (nint)obj71 != 1;
			obj71 = obj73;
			if (flag16)
			{
				continue;
			}
			goto IL_0cdb;
		}
		int num54 = obj72 << 4;
		text = (string)(num52 + num54);
		object obj74 = (nint)text + 312;
		text = (string)obj74;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1393 @ X0_v101] (should have been resolved before IL gen)");
		goto IL_0d66;
		IL_0e57:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj75 = default(object);
		text = (string)obj75;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1419 @ X0_v91] (should have been resolved before IL gen)");
		object obj76 = default(object);
		if (obj76 != null)
		{
			goto IL_0ee2;
		}
		goto IL_13ad;
		IL_1154:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj77 = default(object);
		text = (string)obj77;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1518 @ X0_v76] (should have been resolved before IL gen)");
		object obj78 = default(object);
		if (obj78 != null)
		{
			goto IL_11df;
		}
		goto IL_13ad;
		IL_073f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj79 = default(object);
		text = (string)obj79;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1197 @ X0_v126] (should have been resolved before IL gen)");
		object obj80 = default(object);
		if (obj80 != null)
		{
			goto IL_07ca;
		}
		goto IL_13ad;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000100")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE1D58", Offset = "0xFE1D58", Length = "0xE8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0020;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x2D0;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv46 = v45 + 0x1F0;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv58 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv59 = v58 + 0xD00;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv63 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv64 = v63 + 0xB88;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v64, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A937]) = v42;\nL_0020:\n\tv48 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = Il2CppMethodInfo;\n\tv54 = UnityEngine.UIElements.EnumFieldHelpers;\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v48 @ X8_v3 (System.String)+B88]));\n\tv62 = new *([v50 @ X20_v2 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+D00])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v62, this, *([v52 @ X21_v1 (Il2CppMethodInfo)+2D0]), 0);\n\tv99 = *([v54 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv87 = *([v99 @ X0_v6+E0]) == 0;\n\tif (v87) goto L_004A;\n\tFacebook.Unity.FB::GetPurchases(v62);\n\treturn;\nL_004A:\n\tFacebook.Unity.FB::GetPurchases(v62);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 47 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void GetPurchases()
	{
		//IL_001c: Expected I, but got O
		//IL_0030: Expected I, but got O
		//IL_0047: Expected O, but got I
		//IL_006b: Expected O, but got I
		string text = "Expected ComplexType. Schema was not generated using this tool.";
		nint num = 0;
		nint num2 = 0;
		nint num3 = 0;
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (System.String)+B88]");
		logger.DebugLog(string.Empty);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchasesResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v6+E0]");
		if ((nint)0 != 0)
		{
			global::Facebook.Unity.FB.GetPurchases(callback);
		}
		else
		{
			global::Facebook.Unity.FB.GetPurchases(callback);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000101")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE1E40", Offset = "0xFE1E40", Length = "0xA20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0052;\n\tv35 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv36 = v35 + 0x1F0;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv60 = Il2CppMethodInfo;\n\tv61 = v60 + 0xB10;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv296 = Il2CppMethodInfo;\n\tv297 = v296 + 0xB28;\n\tv298 = \"il2cpp_codegen_initialize_runtime_metadata\"(v297, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv341 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv342 = v341 + 0x9F0;\n\tv343 = \"il2cpp_codegen_initialize_runtime_metadata\"(v342, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv454 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv455 = v454 + 0x8C8;\n\tv456 = \"il2cpp_codegen_initialize_runtime_metadata\"(v455, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv462 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv463 = v462 + 0xA48;\n\tv464 = \"il2cpp_codegen_initialize_runtime_metadata\"(v463, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv505 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv506 = v505 + 0xA90;\n\tv507 = \"il2cpp_codegen_initialize_runtime_metadata\"(v506, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv688 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv689 = v688 + 0xDA8;\n\tv690 = \"il2cpp_codegen_initialize_runtime_metadata\"(v689, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv705 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv706 = v705 + 0xDF8;\n\tv707 = \"il2cpp_codegen_initialize_runtime_metadata\"(v706, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv721 = Il2CppMethodInfo;\n\tv722 = v721 + 0xA8;\n\tv723 = \"il2cpp_codegen_initialize_runtime_metadata\"(v722, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv775 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv776 = v775 + 0xFD8;\n\tv777 = \"il2cpp_codegen_initialize_runtime_metadata\"(v776, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv879 = System.Net.Configuration.SettingsSectionInternal;\n\tv880 = v879 + 0xAA8;\n\tv881 = \"il2cpp_codegen_initialize_runtime_metadata\"(v880, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1029 = Il2CppMethodInfo;\n\tv1030 = v1029 + 0xBF8;\n\tv1031 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1030, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1144 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv1145 = v1144 + 0xA90;\n\tv1146 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1145, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1173 = System.Net.Configuration.SettingsSectionInternal;\n\tv1174 = v1173 + 0xE60;\n\tv1175 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1174, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1187 = Il2CppFieldInfo;\n\tv1188 = v1187 + 0xAB0;\n\tv1189 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1188, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1194 = \"Parent table name is missing in relation '{0}'.\";\n\tv1195 = v1194 + 0x3E0;\n\tv1196 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1195, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1199 = \"IsCyrillic\";\n\tv1200 = v1199 + 0xA68;\n\tv1201 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1200, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1209 = \"Min\";\n\tv1210 = v1209 + 0x6B8;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1210, result, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv55 = 1;\n\t*([302A938]) = v55;\nL_0052:\n\tv57 = 0;\n\tv63 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv65 = System.Net.Configuration.SettingsSectionInternal;\n\tv69 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv71 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv74 = UnityEngine.Transform::GetEnumerator(this.PurchasesPanelTarnsform);\n\tgoto L_006D;\nL_006B:\n\tUnityEngine.Object::Destroy(v1191);\nL_006D:\n\tv383 = v228 == 0;\n\tif (v383) goto L_036D;\n\tv458 = *([v228 @ stack_-68_v9]);\n\tv519 = *([v458 @ X8_v23+12E]);\n\tv460 = *([v458 @ X8_v23+12E]) == 0;\n\tif (v460) goto L_0090;\n\tv518 = *([v458 @ X8_v23+B0]) + 8;\nL_0076:\n\t;\n\tv524 = *([v518 @ X10_v78-8]) == *([v63 @ X25_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v524) goto L_0092;\n\tv518 = v518 + 0x10;\n\tv490 = v519 - 1;\n\tv470 = v519 != 1;\n\tif (v470) goto L_0076;\nL_0090:\n\tv696 = 0xF7087C(v228, *([v63 @ X25_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, v390, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tgoto L_0096;\nL_0092:\n\t;\n\tv693 = *([v518 @ X10_v78]) << 4;\n\tv694 = v458 + v693;\n\tv696 = v694 + 0x138;\nL_0096:\n\t;\n\tv232 = *([v696 @ X0_v34+8]);\n\t*([v696 @ X0_v34])(v699, v228, *([v696 @ X0_v34+8]), v396, v390, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv700 = v699 & 1;\n\tv701 = v700 == 0;\n\tif (v701) goto L_00F7;\n\tv655 = v228 == 0;\n\tif (v655) goto L_036F;\n\tv725 = *([v228 @ stack_-68_v9]);\n\tv893 = *([v725 @ X8_v96+12E]);\n\tv727 = *([v725 @ X8_v96+12E]) == 0;\n\tif (v727) goto L_00C1;\n\tv892 = *([v725 @ X8_v96+B0]) + 8;\nL_00A7:\n\t;\n\tv898 = *([v892 @ X10_v73-8]) == *([v63 @ X25_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v898) goto L_00C3;\n\tv892 = v892 + 0x10;\n\tv803 = v893 - 1;\n\tv783 = v893 != 1;\n\tif (v783) goto L_00A7;\nL_00C1:\n\tv1038 = 0xF7087C(v228, *([v63 @ X25_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, v390, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tgoto L_00C8;\nL_00C3:\n\t;\n\tv1034 = *([v892 @ X10_v73]) + 1;\n\tv1035 = v1034 << 4;\n\tv1036 = v725 + v1035;\n\tv1038 = v1036 + 0x138;\nL_00C8:\n\t;\n\t*([v1038 @ X0_v144])(v1041, v228, *([v1038 @ X0_v144+8]), v106, v390, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv654 = v1041 == 0;\n\tif (v654) goto L_0371;\n\tv232 = *([v65 @ X22_v10 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv1147 = *([v1041 @ X0_v146 (UnityEngine.Component)]);\n\tv1148 = *([v1147 @ X8_v99 (Il2CppClass<UnityEngine.Component>)+130]) < *([v232 @ X1_v13 (System.String)+130]);\n\tv1149 = ~v1148;\n\tv1157 = ~v1149;\n\tif (v1157) goto L_036B;\n\tv347 = *([v232 @ X1_v13 (System.String)+130]) << 3;\n\tv1177 = *([v1147 @ X8_v99 (Il2CppClass<UnityEngine.Component>)+C8]) + v347;\n\tv351 = *([v1177 @ X8_v102-8]) != v232;\n\tif (v351) goto L_036B;\n\tv1191 = UnityEngine.Component::get_gameObject(v1041);\n\tgoto L_006B;\n\tv1202 = \"il2cpp_codegen_runtime_class_init\"(v1197, v1190, v349, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tgoto L_006B;\nL_00F7:\n\tv708 = &v228 @ stack_-68_v9;\n\tv95 = &v57 @ stack_-70_v1;\n\tv232 = *([v69 @ X27_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv711 = 0xF3F36C(*([v708 @ X8_v26]), *([v69 @ X27_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v396, v390, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\t*([v95 @ X24_v10]) = v711;\n\tv728 = v711 == 0;\n\tif (v728) goto L_FFFFFFFF;\nL_0101:\n\tv809 = *([v711 @ X0_v38]);\n\tv1053 = *([v809 @ X8_v92+12E]);\n\tv811 = *([v809 @ X8_v92+12E]) == 0;\n\tif (v811) goto L_0121;\n\tv1052 = *([v809 @ X8_v92+B0]) + 8;\nL_0107:\n\t;\n\tv1058 = *([v1052 @ X10_v66-8]) == *([v69 @ X27_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tif (v1058) goto L_0124;\n\tv1052 = v1052 + 0x10;\n\tv928 = v1053 - 1;\n\tv908 = v1053 != 1;\n\tif (v908) goto L_0107;\nL_0121:\n\tv1163 = 0xF7087C(v711, *([v69 @ X27_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), 0, v390, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tgoto L_0128;\nL_0124:\n\tv1160 = *([v1052 @ X10_v66]) << 4;\n\tv1161 = v809 + v1160;\n\tv1163 = \n// ... truncated")]
	private void processPurchases(global::Facebook.Unity.IPurchasesResult result)
	{
		//IL_1416: Expected O, but got I4
		//IL_0013: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_002f: Expected I, but got O
		//IL_003d: Expected I, but got O
		//IL_0097: Expected O, but got I
		//IL_012d: Expected I, but got O
		//IL_1459: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_036a: Expected O, but got I
		//IL_0141: Expected I4, but got O
		//IL_014f: Expected O, but got I
		//IL_015e: Expected O, but got I
		//IL_03b1: Expected O, but got I
		//IL_00e7: Expected O, but got I
		//IL_00f6: Expected O, but got I
		//IL_0446: Expected I, but got O
		//IL_01a1: Expected O, but got I
		//IL_153d: Expected O, but got I
		//IL_03ec: Expected O, but got I
		//IL_01dd: Expected O, but got I
		//IL_0459: Expected I4, but got O
		//IL_0467: Expected O, but got I
		//IL_0476: Expected O, but got I
		//IL_0400: Expected O, but got I
		//IL_040f: Expected O, but got I
		//IL_0298: Expected O, but got I
		//IL_02a0: Expected I, but got O
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_024f: Expected O, but got Unknown
		//IL_026c: Expected O, but got I
		//IL_027b: Expected O, but got I
		//IL_1193: Expected O, but got I4
		//IL_01f1: Expected O, but got I
		//IL_0200: Expected O, but got I
		//IL_0310: Expected O, but got I
		object obj = 0;
		nint num = 0;
		nint num2 = 0;
		nint num3 = 0;
		nint num4 = 0;
		global::System.Collections.IEnumerator enumerator = PurchasesPanelTarnsform.GetEnumerator();
		object obj2 = default(object);
		nint num8 = default(nint);
		object obj10 = default(object);
		object obj20 = default(object);
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj30 = default(object);
		while (true)
		{
			nint num7;
			if (obj2 != null)
			{
				object obj3 = obj2;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v23+12E]");
				object obj4 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v23+12E]");
				if ((nint)0 == 0)
				{
					goto IL_011e;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v23+B0]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v518 @ X10_v78-8]");
					nint num5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X25_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num5 == 0)
					{
						break;
					}
					obj5 = (nint)obj5 + 16;
					object obj6 = (nint)obj4 - 1;
					bool flag = (nint)obj4 != 1;
					obj4 = obj6;
					if (flag)
					{
						continue;
					}
					goto IL_011e;
				}
				int num6 = obj5 << 4;
				object obj7 = (nint)obj3 + num6;
				object obj8 = (nint)obj7 + 312;
				num7 = num8;
				goto IL_1448;
			}
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			object obj9 = obj2;
			int num9 = 0;
			break;
			IL_14e5:
			obj9 = obj2;
			num9 = 0;
			throw new global::System.OutOfMemoryException();
			IL_0437:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num7 = unchecked((nint)0);
			goto IL_152d;
			IL_152d:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1163 @ X0_v137+8]");
			string text = string.Empty;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1163 @ X0_v137] (should have been resolved before IL gen)");
			goto IL_14e5;
			IL_0228:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num8 = 1;
			goto IL_14bc;
			IL_011e:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num7 = unchecked((nint)0);
			goto IL_1448;
			IL_1448:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v696 @ X0_v34+8]");
			text = string.Empty;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v696 @ X0_v34] (should have been resolved before IL gen)");
			if ((int)((nint)obj10 & 1) != 0)
			{
				if (obj2 != null)
				{
					object obj11 = obj2;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v96+12E]");
					object obj12 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v96+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0228;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v725 @ X8_v96+B0]");
					object obj13 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v892 @ X10_v73-8]");
						nint num10 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v63 @ X25_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num10 == 0)
						{
							break;
						}
						obj13 = (nint)obj13 + 16;
						object obj14 = (nint)obj12 - 1;
						bool flag2 = (nint)obj12 != 1;
						obj12 = obj14;
						if (flag2)
						{
							continue;
						}
						goto IL_0228;
					}
					object obj15 = obj13 + 1;
					int num11 = (int)((nint)obj15 << 4);
					object obj16 = (nint)obj11 + num11;
					object obj17 = (nint)obj16 + 312;
					num8 = num7;
					goto IL_14bc;
				}
				global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
				obj9 = obj2;
				num9 = 0;
				break;
			}
			object obj18 = obj2;
			object obj19 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
			text = string.Empty;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			obj19 = obj20;
			if (obj20 == null)
			{
				goto IL_14e5;
			}
			object obj21 = obj20;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v92+12E]");
			object obj22 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v92+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0437;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v809 @ X8_v92+B0]");
			object obj23 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1052 @ X10_v66-8]");
				nint num12 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X27_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
				if (num12 == 0)
				{
					break;
				}
				obj23 = (nint)obj23 + 16;
				object obj24 = (nint)obj22 - 1;
				bool flag3 = (nint)obj22 != 1;
				obj22 = obj24;
				if (flag3)
				{
					continue;
				}
				goto IL_0437;
			}
			int num13 = obj23 << 4;
			object obj25 = (nint)obj21 + num13;
			object obj26 = (nint)obj25 + 312;
			goto IL_152d;
			IL_14bc:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1038 @ X0_v144] (should have been resolved before IL gen)");
			if ((object)component != null)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X22_v10 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
				text = string.Empty;
				nint num14 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1147 @ X8_v99 (Il2CppClass<UnityEngine.Component>)+130]");
				nint num15 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X1_v13 (System.String)+130]");
				if (num15 >= 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X1_v13 (System.String)+130]");
					int num16 = (int)((nint)0 << 3);
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1147 @ X8_v99 (Il2CppClass<UnityEngine.Component>)+C8]");
					object obj27 = (nint)0 + (nint)num16;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1177 @ X8_v102-8]");
					if (0 == (nint)text)
					{
						global::UnityEngine.GameObject obj28 = component.gameObject;
						global::UnityEngine.Object.Destroy(obj28);
						continue;
					}
				}
				global::System.InvalidCastException ex3 = new global::System.InvalidCastException();
				object obj29 = 0;
				obj9 = obj30;
				num9 = 0;
			}
			else
			{
				global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
				obj9 = obj2;
				num9 = 0;
			}
			break;
		}
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000102")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE2868", Offset = "0xFE2868", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsPurchaseManager()
	{
	}
}
