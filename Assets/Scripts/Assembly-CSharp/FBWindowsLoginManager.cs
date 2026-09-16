[global::Cpp2ILInjected.Token(Token = "0x2000023")]
public class FBWindowsLoginManager : global::UnityEngine.MonoBehaviour
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000024")]
	private sealed class _003CLoadPictureFromUrl_003Ed__10 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string url;

		[global::Cpp2ILInjected.Token(Token = "0x400009B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public global::UnityEngine.UI.RawImage itemImage;

		[global::Cpp2ILInjected.Token(Token = "0x400009C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::UnityEngine.Texture2D _003CUserPicture_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::UnityEngine.WWW _003Cwww_003E5__3;

		[global::Cpp2ILInjected.Token(Token = "0x17000006")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
			[global::Cpp2ILInjected.Address(RVA = "0xFE04DC", Offset = "0xFE04DC", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000007")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
			[global::Cpp2ILInjected.Address(RVA = "0xFE0524", Offset = "0xFE0524", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0xFDF9B4", Offset = "0xFDF9B4", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CLoadPictureFromUrl_003Ed__10(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE0374", Offset = "0xFE0374", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE0378", Offset = "0xFE0378", Length = "0x164")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0018;\n\tv21 = System.Net.Configuration.SettingsSectionInternal;\n\tv22 = v21 + 0x900;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Xml.ValidateNames;\n\tv46 = v45 + 0x230;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A92E]) = v42;\nL_0018:\n\tv44 = this.<>1__state == 0;\n\tif (v44) goto L_0051;\n\tv56 = this.<>1__state != 1;\n\tif (v56) goto L_0042;\n\tv63 = this + 0x38;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tUnityEngine.WWW::LoadImageIntoTexture(this.<www>5__3, this.<UserPicture>5__2);\n\tUnityEngine.WWW::Dispose(this.<www>5__3);\n\tthis.<www>5__3 = 0;\n\tv160 = 0xF3F1B4(v63, 0, 0, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tUnityEngine.UI.RawImage::set_texture(this.itemImage, this.<UserPicture>5__2);\nL_0042:\n\tv81 = this.<>1__state == 0;\n\treturn v81;\nL_0051:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv58 = System.Net.Configuration.SettingsSectionInternal;\n\tv61 = new *([v58 @ X8_v4 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+900])();\n\tUnityEngine.Texture2D::.ctor(v61, 0x20, 0x20);\n\tv148 = this + 0x30;\n\tthis.<UserPicture>5__2 = v61;\n\tv150 = 0xF3F1B4(v148, v61, 0x20, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv152 = System.Xml.ValidateNames;\n\tv155 = new *([v152 @ X8_v6 (Il2CppClass<System.Xml.ValidateNames>)+230])();\n\tUnityEngine.WWW::.ctor(v155, this.url);\n\tv162 = this + 0x38;\n\tthis.<www>5__3 = v155;\n\tv165 = 0xF3F1B4(v162, v155, 0, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv167 = this + 0x18;\n\tthis.<>2__current = this.<www>5__3;\n\tv168 = 0xF3F1B4(v167, this.<www>5__3, 0, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tthis.<>1__state = 1;\n\tv129 = this.<>1__state == 0;\n\treturn v129;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 95 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
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
		[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
		[global::Cpp2ILInjected.Address(RVA = "0xFE04E4", Offset = "0xFE04E4", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0xBE8;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)3048;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x4000094")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x4000095")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.UI.InputField Permissions;

	[global::Cpp2ILInjected.Token(Token = "0x4000096")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.UI.RawImage UserImage;

	[global::Cpp2ILInjected.Token(Token = "0x4000097")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.UI.Text UserName;

	[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDEF18", Offset = "0xFDEF18", Length = "0x138")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv20 = *([302A927]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_004D;\n\tv22 = *([v18 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv24 = *([v22 @ X0_v34+E0]) == 0;\n\tif (v24) goto L_0055;\nL_0015:\n\tv50 = Facebook.Unity.FB::get_IsInitialized();\n\tv58 = ~v50;\n\tif (v58) goto L_005C;\nL_0018:\n\tv68 = this.Permissions;\n\tv99 = System.String::Split(v68.m_Text, 0x2C, 0);\n\tv101 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv104 = new *([v101 @ X8_v11 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CD8])();\n\tv130 = Il2CppMethodInfo;\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v104, this, *([v130 @ X8_v13 (Il2CppMethodInfo)+2B8]), 0);\n\tgoto L_003E;\n\tv136 = \"il2cpp_codegen_runtime_class_init\"(v134, v133, v132, v110, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_003E:\n\tFacebook.Unity.FB::LogInWithReadPermissions(v99, v104);\n\treturn;\nL_004D:\n\t*([v16 @ X20_v1+927]) = 1;\n\tv44 = *([v18 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv95 = *([v44 @ X0_v21+E0]) == 0;\n\tv46 = ~v95;\n\tif (v46) goto L_0015;\nL_0055:\n\tv60 = Facebook.Unity.FB::get_IsInitialized();\n\tv75 = ~v60;\n\tv66 = ~v75;\n\tif (v66) goto L_0018;\nL_005C:\n\tv85 = \"Min\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v85 @ X8_v4 (System.String)+7F8]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void LogInReadButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_0126: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_01a8: Expected O, but got I
		//IL_00e3: Expected I, but got O
		object obj = 50503680;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A927]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v34+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v21+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		if (global::Facebook.Unity.FB.IsInitialized)
		{
			goto IL_00a1;
		}
		goto IL_0188;
		IL_00a1:
		global::UnityEngine.UI.InputField permissions = Permissions;
		string[] permissions2 = permissions.text.Split(',');
		nint num2 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback = null;
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FB.LogInWithReadPermissions(permissions2, callback);
		return;
		IL_0188:
		string text = "Min";
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4 (System.String)+7F8]");
		logger.DebugWarningLog(string.Empty);
		return;
		IL_007f:
		if (global::Facebook.Unity.FB.IsInitialized)
		{
			goto IL_00a1;
		}
		goto IL_0188;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDF050", Offset = "0xFDF050", Length = "0x138")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv20 = *([302A928]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_004D;\n\tv22 = *([v18 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv24 = *([v22 @ X0_v34+E0]) == 0;\n\tif (v24) goto L_0055;\nL_0015:\n\tv50 = Facebook.Unity.FB::get_IsInitialized();\n\tv58 = ~v50;\n\tif (v58) goto L_005C;\nL_0018:\n\tv68 = this.Permissions;\n\tv99 = System.String::Split(v68.m_Text, 0x2C, 0);\n\tv101 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv104 = new *([v101 @ X8_v11 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CD8])();\n\tv130 = Il2CppMethodInfo;\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v104, this, *([v130 @ X8_v13 (Il2CppMethodInfo)+2B8]), 0);\n\tgoto L_003E;\n\tv136 = \"il2cpp_codegen_runtime_class_init\"(v134, v133, v132, v110, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_003E:\n\tFacebook.Unity.FB::LogInWithPublishPermissions(v99, v104);\n\treturn;\nL_004D:\n\t*([v16 @ X20_v1+928]) = 1;\n\tv44 = *([v18 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv95 = *([v44 @ X0_v21+E0]) == 0;\n\tv46 = ~v95;\n\tif (v46) goto L_0015;\nL_0055:\n\tv60 = Facebook.Unity.FB::get_IsInitialized();\n\tv75 = ~v60;\n\tv66 = ~v75;\n\tif (v66) goto L_0018;\nL_005C:\n\tv85 = \"Min\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v85 @ X8_v4 (System.String)+7F8]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void LogInPublishButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_0126: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_01a8: Expected O, but got I
		//IL_00e3: Expected I, but got O
		object obj = 50503680;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A928]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v34+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v21+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		if (global::Facebook.Unity.FB.IsInitialized)
		{
			goto IL_00a1;
		}
		goto IL_0188;
		IL_00a1:
		global::UnityEngine.UI.InputField permissions = Permissions;
		string[] permissions2 = permissions.text.Split(',');
		nint num2 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILoginResult> callback = null;
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FB.LogInWithPublishPermissions(permissions2, callback);
		return;
		IL_0188:
		string text = "Min";
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X8_v4 (System.String)+7F8]");
		logger.DebugWarningLog(string.Empty);
		return;
		IL_007f:
		if (global::Facebook.Unity.FB.IsInitialized)
		{
			goto IL_00a1;
		}
		goto IL_0188;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDF188", Offset = "0xFDF188", Length = "0xEC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv20 = *([302A929]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0039;\n\tv22 = *([v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv24 = *([v22 @ X0_v28+E0]) == 0;\n\tif (v24) goto L_0041;\nL_0015:\n\tv50 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv58 = ~v50;\n\tif (v58) goto L_0048;\nL_001C:\n\tgoto L_001F;\n\tv80 = \"il2cpp_codegen_runtime_class_init\"(v68, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_001F:\n\tFacebook.Unity.FB::LogOut();\n\tv98 = \"IsCyrillic\";\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v98 @ X8_v11 (System.String)+A50]));\n\treturn;\nL_0039:\n\t*([302A929]) = 1;\n\tv44 = *([v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv79 = *([v44 @ X0_v18+E0]) == 0;\n\tv46 = ~v79;\n\tif (v46) goto L_0015;\nL_0041:\n\tv60 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv77 = ~v60;\n\tv66 = ~v77;\n\tif (v66) goto L_001C;\nL_0048:\n\tv83 = \"IsCyrillic\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v83 @ X8_v4 (System.String)+A68]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 56 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void LogOutButton()
	{
		//IL_000e: Expected I, but got O
		//IL_00de: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_0160: Expected O, but got I
		//IL_00c7: Expected O, but got I
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A929]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v28+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v18+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		if (global::Facebook.Unity.FB.IsLoggedIn)
		{
			goto IL_009d;
		}
		goto IL_0140;
		IL_009d:
		global::Facebook.Unity.FB.LogOut();
		string text = "IsCyrillic";
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X8_v11 (System.String)+A50]");
		logger.DebugLog(string.Empty);
		return;
		IL_0140:
		string text2 = "IsCyrillic";
		FBWindowsLogsManager logger2 = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v83 @ X8_v4 (System.String)+A68]");
		logger2.DebugWarningLog(string.Empty);
		return;
		IL_0076:
		if (global::Facebook.Unity.FB.IsLoggedIn)
		{
			goto IL_009d;
		}
		goto IL_0140;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDF274", Offset = "0xFDF274", Length = "0x51C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0032;\n\tv27 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv28 = v27 + 0x1F0;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv50 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv51 = v50 + 0x9F0;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv179 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv180 = v179 + 0x900;\n\tv181 = \"il2cpp_codegen_initialize_runtime_metadata\"(v180, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv265 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv266 = v265 + 0xA80;\n\tv267 = \"il2cpp_codegen_initialize_runtime_metadata\"(v266, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv294 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv295 = v294 + 0xA90;\n\tv296 = \"il2cpp_codegen_initialize_runtime_metadata\"(v295, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv349 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv350 = v349 + 0xDF8;\n\tv351 = \"il2cpp_codegen_initialize_runtime_metadata\"(v350, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv388 = \"Unable to decode certificate.\";\n\tv389 = v388 + 0x8C8;\n\tv390 = \"il2cpp_codegen_initialize_runtime_metadata\"(v389, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv420 = \"DarkSalmon\";\n\tv421 = v420 + 0xE90;\n\tv422 = \"il2cpp_codegen_initialize_runtime_metadata\"(v421, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv450 = \"papayawhip\";\n\tv451 = v450 + 0x120;\n\tv452 = \"il2cpp_codegen_initialize_runtime_metadata\"(v451, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv525 = \"__sort-indicator\";\n\tv526 = v525 + 0x1C8;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v526, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A92A]) = v47;\nL_0032:\n\tv48 = 0;\n\tv53 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv56 = result->klass;\n\tv279 = result->klass->rank;\n\tv58 = *([v56 @ X8_v14 (Il2CppClass<Facebook.Unity.ILoginResult>)+12E]) == 0;\n\tif (v58) goto L_0058;\n\tv278 = *([v56 @ X8_v14 (Il2CppClass<Facebook.Unity.ILoginResult>)+B0]) + 8;\nL_0043:\n\tv284 = *([v278 @ X10_v42-8]) == *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v284) goto L_0086;\n\tv278 = v278 + 0x10;\n\tv207 = v279 - 1;\n\tv187 = v279 != 1;\n\tif (v187) goto L_0043;\nL_0058:\n\tthis = 0xF7087C(result, *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([this @ X0 (FBWindowsLoginManager)])(this, result, *([this @ X0 (FBWindowsLoginManager)+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv293 = this == 0;\n\tif (v293) goto L_0090;\nL_005F:\n\tv326 = \"DarkSalmon\";\n\tv328 = result->klass;\n\tv402 = result->klass->rank;\n\tv330 = *([v328 @ X8_v49 (Il2CppClass<Facebook.Unity.ILoginResult>)+12E]) == 0;\n\tif (v330) goto L_0083;\n\tv401 = *([v328 @ X8_v49 (Il2CppClass<Facebook.Unity.ILoginResult>)+B0]) + 8;\nL_006E:\n\tv407 = *([v401 @ X10_v37-8]) == *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v407) goto L_00E0;\n\tv401 = v401 + 0x10;\n\tv377 = v402 - 1;\n\tv357 = v402 != 1;\n\tif (v357) goto L_006E;\nL_0083:\n\tthis = 0xF7087C(result, *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00E6;\nL_0086:\n\tv299 = *([v278 @ X10_v42]) << 4;\n\tv300 = v56 + v299;\n\tthis = v300 + 0x138;\n\t*([this @ X0 (FBWindowsLoginManager)])(this, result, *([this @ X0 (FBWindowsLoginManager)+8]), v428, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv306 = this == 0;\n\tv307 = ~v306;\n\tif (v307) goto L_005F;\nL_0090:\n\tv334 = UnityEngine.UIElements.EnumFieldHelpers;\n\tthis = *([v334 @ X8_v16 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv337 = *([this @ X0 (FBWindowsLoginManager)+E0]) == 0;\n\tif (v337) goto L_00FC;\n\tv382 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv412 = ~v382;\n\tif (v412) goto L_0103;\nL_009E:\n\tgoto L_00A4;\n\tv453 = CollectParticleData[];\n\tv454 = v453 + 0x970;\n\tv455 = \"il2cpp_codegen_initialize_runtime_metadata\"(v454, v147, v86, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv457 = 1;\n\t*([2DD441D]) = v457;\nL_00A4:\n\tv458 = CollectParticleData[];\n\tv460 = *([v458 @ X8_v23 (Il2CppClass<CollectParticleData[]>)+970]);\n\tv167 = *([v460 @ X8_v25+B8]);\n\tv170 = *([v167 @ X8_v26]);\n\tv537 = \"__sort-indicator\";\n\tv150 = System.String::Concat(*([v537 @ X8_v27 (System.String)+1C8]), *([v170 @ X21_v11+28]));\n\tFBWindowsLogsManager::DebugLog(this.Logger, v150);\n\tv176 = *([v170 @ X21_v11+20]);\n\tv668 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv671 = *([v176 @ X20_v12]);\n\tv714 = *([v671 @ X8_v31+12E]);\n\tv673 = *([v671 @ X8_v31+12E]) == 0;\n\tif (v673) goto L_00DD;\n\tv713 = *([v671 @ X8_v31+B0]) + 8;\nL_00C8:\n\tv719 = *([v713 @ X10_v30-8]) == *([v668 @ X8_v29 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+900]);\n\tif (v719) goto L_0112;\n\tv713 = v713 + 0x10;\n\tv699 = v714 - 1;\n\tv679 = v714 != 1;\n\tif (v679) goto L_00C8;\nL_00DD:\n\tthis = 0xF7087C(v176, *([v668 @ X8_v29 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+900]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_0118;\nL_00E0:\n\tv425 = *([v401 @ X10_v37]) << 4;\n\tv426 = v328 + v425;\n\tthis = v426 + 0x138;\nL_00E6:\n\t*([this @ X0 (FBWindowsLoginManager)])(v433, result, *([this @ X0 (FBWindowsLoginManager)+8]), v428, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv152 = System.String::Concat(*([v326 @ X22_v11 (System.String)+E90]), v433);\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v152);\n\treturn;\nL_00FC:\n\tv414 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv443 = ~v414;\n\tv437 = ~v443;\n\tif (v437) goto L_009E;\nL_0103:\n\tv461 = \"Unable to decode certificate.\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v461 @ X8_v19 (System.String)+8C8]));\n\treturn;\nL_0112:\n\tv726 = *([v713 @ X10_v30]) << 4;\n\tv727 = v671 + v726;\n\tthis = v727 + 0x138;\nL_0118:\n\t*([this @ X0 (FBWindowsLoginManager)])(this, v176, *([this @ X0 (FBWindowsLoginManager)+8]), v225, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv750 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv751 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv752 = \"papayawhip\";\nL_0124:\n\tv792 = this == 0;\n\tif (v792) goto L_01DC;\n\tv794 = *([this @ X0 (FBWindowsLoginManager)]);\n\tv838 = *([v794 @ X8_v37+12E]);\n\tv796 = *([v794 @ X8_v37+12E]) == 0;\n\tif (v796) goto L_0147;\n\tv837 = *([v794 @ X8_v37+B0]) + 8;\nL_0132:\n\tv843 = *([v837 @ X10_v25-8]) == *([v750 @ X21_v12 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v843) goto L_014A;\n\tv837 = v837 + 0x10;\n\tv823 = v838 - 1;\n\tv803 = v838 != 1;\n\tif (v803) goto L_0132;\nL_0147:\n\tthis = 0xF7087C(this, *([v750 @ X21_v12 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_014E;\nL_014A:\n\tv855 = *([v837 @ X10_v25]) << 4;\n\tv856 = v794 + v855;\n\tthis = v856 + 0x138;\nL_014E:\n\tv250 = *([this @ X0 (FBWindowsLoginManager)+8]);\n\t*([this @ X0 (FBWindowsLoginManager)])(this, this, *([this @ X0 (FBWindowsLoginManager)+8]), v922, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv861 = this & 1;\n\tv862 = v861 == 0;\n\tif (v862) goto L_018F;\n\tv850 = this == 0;\n\tif (v850) goto L_01DE;\n\tv864 = *([this @ X0 (FBWindowsLoginManager)]);\n\tv907 = *([v864 @ X8_v41+12E]);\n\tv866 = *([v864 @ X8_v41+12E]) == 0;\n\tif (v866) goto L_0178;\n\tv906 = *([v864 @ X8_v41+B0]) + 8;\nL_0163:\n\tv912 = *([v906 @ X10_v20-8]) == *([v751 @ X22_v8 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+A80]);\n\tif (v912) goto L_\n// ... truncated")]
	private void AuthCallback(global::Facebook.Unity.ILoginResult result)
	{
		//IL_090b: Expected O, but got I4
		//IL_0013: Expected I, but got O
		//IL_001b: Expected I, but got O
		//IL_002b: Expected O, but got I
		//IL_00d6: Expected I, but got O
		//IL_0209: Expected I, but got O
		//IL_0219: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_00f6: Expected I, but got O
		//IL_0106: Expected O, but got I
		//IL_019b: Expected I, but got O
		//IL_01ae: Expected I4, but got O
		//IL_01bc: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_040a: Expected O, but got I
		//IL_0987: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_099e: Expected I, but got O
		//IL_09ae: Expected O, but got I
		//IL_09be: Expected O, but got I
		//IL_028b: Expected O, but got I
		//IL_028b: Expected O, but got I
		//IL_0386: Expected I4, but got O
		//IL_0394: Expected O, but got I
		//IL_03a3: Expected O, but got I
		//IL_02b3: Expected O, but got I
		//IL_0155: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_02c6: Expected I, but got O
		//IL_02de: Expected O, but got I
		//IL_0373: Expected I, but got O
		//IL_0a15: Expected I, but got O
		//IL_0a23: Expected I, but got O
		//IL_0319: Expected O, but got I
		//IL_0815: Expected I, but got O
		//IL_0419: Expected I4, but got O
		//IL_0427: Expected O, but got I
		//IL_0436: Expected O, but got I
		//IL_043b: Expected I, but got O
		//IL_0455: Expected O, but got I
		//IL_032d: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_04ea: Expected I, but got O
		//IL_0a6d: Expected O, but got I
		//IL_0490: Expected O, but got I
		//IL_04fd: Expected I4, but got O
		//IL_050b: Expected O, but got I
		//IL_051a: Expected O, but got I
		//IL_06c9: Expected I, but got O
		//IL_06e1: Expected O, but got I
		//IL_04a4: Expected O, but got I
		//IL_04b3: Expected O, but got I
		//IL_0776: Expected I, but got O
		//IL_0556: Expected O, but got I
		//IL_0b72: Expected O, but got I
		//IL_071c: Expected O, but got I
		//IL_05eb: Expected I, but got O
		//IL_087c: Expected I4, but got O
		//IL_0aeb: Expected O, but got I
		//IL_0591: Expected O, but got I
		//IL_08ba: Expected I4, but got O
		//IL_0789: Expected I4, but got O
		//IL_0797: Expected O, but got I
		//IL_07a6: Expected O, but got I
		//IL_0634: Expected I, but got O
		//IL_0730: Expected O, but got I
		//IL_073f: Expected O, but got I
		//IL_05fe: Expected I4, but got O
		//IL_060c: Expected O, but got I
		//IL_061b: Expected O, but got I
		//IL_08e6: Expected I4, but got O
		//IL_08fc: Expected I4, but got O
		//IL_05a5: Expected O, but got I
		//IL_05b4: Expected O, but got I
		object obj = 0;
		nint num = 0;
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v14 (Il2CppClass<Facebook.Unity.ILoginResult>)+12E]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v14 (Il2CppClass<Facebook.Unity.ILoginResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00b1;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X8_v14 (Il2CppClass<Facebook.Unity.ILoginResult>)+B0]");
		object obj3 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v278 @ X10_v42-8]");
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
			if (num3 == 0)
			{
				break;
			}
			obj3 = (nint)obj3 + 16;
			object obj4 = (nint)obj2 - 1;
			bool flag = (nint)obj2 != 1;
			obj2 = obj4;
			if (flag)
			{
				continue;
			}
			goto IL_00b1;
		}
		int num4 = (int)((nint)obj3 << 4);
		object obj5 = num2 + num4;
		FBWindowsLoginManager fBWindowsLoginManager = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [this @ X0 (FBWindowsLoginManager)] (should have been resolved before IL gen)");
		if ((object)this != null)
		{
			goto IL_00e5;
		}
		goto IL_01fb;
		IL_03ea:
		string text = "Unable to decode certificate.";
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v461 @ X8_v19 (System.String)+8C8]");
		logger.DebugWarningLog(string.Empty);
		return;
		IL_0364:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		nint num5 = unchecked((nint)0);
		goto IL_09fd;
		IL_0968:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [this @ X0 (FBWindowsLoginManager)] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X22_v11 (System.String)+E90]");
		string text2 = default(string);
		string message = string.Empty + text2;
		Logger.DebugErrorLog(message);
		return;
		IL_00e5:
		string text3 = "DarkSalmon";
		nint num6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v49 (Il2CppClass<Facebook.Unity.ILoginResult>)+12E]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v49 (Il2CppClass<Facebook.Unity.ILoginResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_018c;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v49 (Il2CppClass<Facebook.Unity.ILoginResult>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X10_v37-8]");
			nint num7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
			if (num7 == 0)
			{
				break;
			}
			obj7 = (nint)obj7 + 16;
			object obj8 = (nint)obj6 - 1;
			bool flag2 = (nint)obj6 != 1;
			obj6 = obj8;
			if (flag2)
			{
				continue;
			}
			goto IL_018c;
		}
		int num8 = (int)((nint)obj7 << 4);
		object obj9 = num6 + num8;
		fBWindowsLoginManager = null;
		goto IL_0968;
		IL_00b1:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [this @ X0 (FBWindowsLoginManager)] (should have been resolved before IL gen)");
		bool flag3 = (object)this == null;
		nint num9 = unchecked((nint)0);
		if (!flag3)
		{
			goto IL_00e5;
		}
		goto IL_01fb;
		IL_01fb:
		nint num10 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v334 @ X8_v16 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		fBWindowsLoginManager = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FBWindowsLoginManager)+E0]");
		if ((nint)0 != 0)
		{
			if (!global::Facebook.Unity.FB.IsLoggedIn)
			{
				goto IL_03ea;
			}
		}
		else if (!global::Facebook.Unity.FB.IsLoggedIn)
		{
			goto IL_03ea;
		}
		nint num11 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v458 @ X8_v23 (Il2CppClass<CollectParticleData[]>)+970]");
		object obj10 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X8_v25+B8]");
		object obj11 = 0;
		object obj12 = obj11;
		string text4 = "__sort-indicator";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v537 @ X8_v27 (System.String)+1C8]");
		string num12 = string.Empty;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X21_v11+28]");
		string message2 = num12 + string.Empty;
		Logger.DebugLog(message2);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X21_v11+20]");
		object obj13 = 0;
		nint num13 = 0;
		object obj14 = obj13;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v31+12E]");
		object obj15 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v31+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0364;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v671 @ X8_v31+B0]");
		object obj16 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v713 @ X10_v30-8]");
			nint num14 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v668 @ X8_v29 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+900]");
			if (num14 == 0)
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
			goto IL_0364;
		}
		int num15 = (int)((nint)obj16 << 4);
		object obj18 = (nint)obj14 + num15;
		fBWindowsLoginManager = null;
		num5 = unchecked((nint)0);
		goto IL_09fd;
		IL_018c:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		num9 = unchecked((nint)0);
		goto IL_0968;
		IL_09fd:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [this @ X0 (FBWindowsLoginManager)] (should have been resolved before IL gen)");
		nint num16 = 0;
		nint num17 = 0;
		string text5 = "papayawhip";
		string text7 = default(string);
		object obj23;
		int num27;
		while (true)
		{
			nint num20;
			if ((object)this != null)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v37+12E]");
				object obj19 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v37+12E]");
				if ((nint)0 == 0)
				{
					goto IL_04db;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v794 @ X8_v37+B0]");
				object obj20 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v837 @ X10_v25-8]");
					nint num18 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v750 @ X21_v12 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num18 == 0)
					{
						break;
					}
					obj20 = (nint)obj20 + 16;
					object obj21 = (nint)obj19 - 1;
					bool flag5 = (nint)obj19 != 1;
					obj19 = obj21;
					if (flag5)
					{
						continue;
					}
					goto IL_04db;
				}
				int num19 = (int)((nint)obj20 << 4);
				object obj22 = num19;
				fBWindowsLoginManager = null;
				num20 = num5;
				goto IL_0a5d;
			}
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			num5 = unchecked((nint)0);
			break;
			IL_0767:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num5 = unchecked((nint)0);
			goto IL_0b62;
			IL_0b62:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FBWindowsLoginManager)+8]");
			string text6 = string.Empty;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [this @ X0 (FBWindowsLoginManager)] (should have been resolved before IL gen)");
			object obj24;
			obj23 = obj24;
			int num22;
			int num21 = num22;
			FBWindowsLoginManager fBWindowsLoginManager3;
			FBWindowsLoginManager fBWindowsLoginManager2 = fBWindowsLoginManager3;
			int num24;
			int num23 = num24;
			goto IL_0b0e;
			IL_05dc:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num20 = unchecked((nint)0);
			goto IL_0acc;
			IL_0acc:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [this @ X0 (FBWindowsLoginManager)] (should have been resolved before IL gen)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v752 @ X23_v7 (System.String)+120]");
			string message3 = string.Empty + text7;
			Logger.DebugLog(message3);
			num5 = unchecked((nint)0);
			continue;
			IL_04db:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num20 = unchecked((nint)0);
			goto IL_0a5d;
			IL_0a5d:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (FBWindowsLoginManager)+8]");
			text6 = string.Empty;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [this @ X0 (FBWindowsLoginManager)] (should have been resolved before IL gen)");
			if (false)
			{
				if ((object)this != null)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v41+12E]");
					object obj25 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v41+12E]");
					if ((nint)0 != 0)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v864 @ X8_v41+B0]");
						object obj26 = (nint)0 + (nint)8;
						while (true)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v906 @ X10_v20-8]");
							nint num25 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v751 @ X22_v8 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+A80]");
							if (num25 == 0)
							{
								break;
							}
							obj26 = (nint)obj26 + 16;
							object obj27 = (nint)obj25 - 1;
							bool flag6 = (nint)obj25 != 1;
							obj25 = obj27;
							if (flag6)
							{
								continue;
							}
							goto IL_05dc;
						}
						int num26 = (int)((nint)obj26 << 4);
						object obj28 = num26;
						fBWindowsLoginManager = null;
						goto IL_0acc;
					}
					goto IL_05dc;
				}
				global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
				break;
			}
			object obj29 = this;
			bool flag7 = (object)this == null;
			obj24 = obj;
			num27 = 0;
			num22 = 6;
			fBWindowsLoginManager3 = this;
			num24 = 0;
			obj23 = obj;
			num27 = 0;
			num21 = 6;
			num5 = num20;
			fBWindowsLoginManager2 = this;
			num23 = 0;
			if (!flag7)
			{
				goto IL_06bb;
			}
			goto IL_0b0e;
			IL_06bb:
			nint num28 = 0;
			object obj30 = obj29;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v10+12E]");
			object obj31 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v10+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0767;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v522 @ X8_v10+B0]");
			object obj32 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v645 @ X10_v9-8]");
				nint num29 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v519 @ X8_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
				if (num29 == 0)
				{
					break;
				}
				obj32 = (nint)obj32 + 16;
				object obj33 = (nint)obj31 - 1;
				bool flag8 = (nint)obj31 != 1;
				obj31 = obj33;
				if (flag8)
				{
					continue;
				}
				goto IL_0767;
			}
			int num30 = (int)((nint)obj32 << 4);
			object obj34 = (nint)obj30 + num30;
			fBWindowsLoginManager = null;
			num5 = num20;
			goto IL_0b62;
			IL_0b0e:
			while (true)
			{
				if (num23 == 0)
				{
					if (num21 == 6 || num21 == 0)
					{
						fBWindowsLoginManager2.GetCurrentProfile();
					}
					return;
				}
				global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
				if (false)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
					num24 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
					obj29 = obj23;
					bool flag9 = obj23 == null;
					bool flag10 = !flag9;
					obj24 = obj23;
					num27 = 0;
					num22 = 0;
					num20 = num5;
					fBWindowsLoginManager3 = fBWindowsLoginManager2;
					if (flag10)
					{
						break;
					}
					num27 = 0;
					num21 = 0;
					text6 = text6;
					num23 = 0;
					continue;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0854");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
				return;
			}
			goto IL_06bb;
		}
		obj23 = obj;
		num27 = 0;
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDF790", Offset = "0xFDF790", Length = "0xE8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0020;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x2A8;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv46 = v45 + 0x1F0;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv58 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv59 = v58 + 0xCF0;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv63 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv64 = v63 + 0xB80;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v64, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A92B]) = v42;\nL_0020:\n\tv48 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = Il2CppMethodInfo;\n\tv54 = UnityEngine.UIElements.EnumFieldHelpers;\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v48 @ X8_v3 (System.String)+B80]));\n\tv62 = new *([v50 @ X20_v2 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CF0])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v62, this, *([v52 @ X21_v1 (Il2CppMethodInfo)+2A8]), 0);\n\tv99 = *([v54 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv87 = *([v99 @ X0_v6+E0]) == 0;\n\tif (v87) goto L_004A;\n\tFacebook.Unity.FB::CurrentProfile(v62);\n\treturn;\nL_004A:\n\tFacebook.Unity.FB::CurrentProfile(v62);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 47 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void GetCurrentProfile()
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
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (System.String)+B80]");
		logger.DebugLog(string.Empty);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IProfileResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v6+E0]");
		if ((nint)0 != 0)
		{
			global::Facebook.Unity.FB.CurrentProfile(callback);
		}
		else
		{
			global::Facebook.Unity.FB.CurrentProfile(callback);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDF878", Offset = "0xFDF878", Length = "0xB0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv24 = Il2CppMethodInfo;\n\tgoto L_0023;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x2B0;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv55 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv56 = v55 + 0x1F0;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv62 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv63 = v62 + 0xCD0;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv52 = 1;\n\t*([302A92C]) = v52;\nL_0023:\n\tv54 = new *([v22 @ X23_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CD0])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v54, this, *([v24 @ X22_v1 (Il2CppMethodInfo)+2B0]), 0);\n\tgoto L_003A;\n\tv68 = \"il2cpp_codegen_runtime_class_init\"(v64, v60, v59, v61, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\nL_003A:\n\tFacebook.Unity.FB::GetUserLocale(v54);\n\treturn;\n// 40 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void GetUserLocale()
	{
		//IL_000e: Expected I, but got O
		nint num = 0;
		nint num2 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ILocaleResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FB.GetUserLocale(callback);
	}

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(FBWindowsLoginManager._003CLoadPictureFromUrl_003Ed__10))]
	[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDF928", Offset = "0xFDF928", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0018;\n\tv25 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv26 = v25 + 0xA80;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, url, itemImage, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = 1;\n\t*([302A9A7]) = v44;\nL_0018:\n\tv46 = new *([v20 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+A80])();\n\tSystem.Object::.ctor(v46);\n\t*([v46 @ X0_v3 (System.Object)+10]) = 0;\n\tv50 = v46 + 0x20;\n\t*([v46 @ X0_v3 (System.Object)+20]) = url;\n\tv52 = 0xF3F1B4(v50, url, itemImage, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv54 = v46 + 0x28;\n\t*([v46 @ X0_v3 (System.Object)+28]) = itemImage;\n\tv56 = 0xF3F1B4(v54, itemImage, itemImage, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v46;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator LoadPictureFromUrl(string url, global::UnityEngine.UI.RawImage itemImage)
	{
		//IL_000e: Expected I, but got O
		//IL_0055: Expected O, but got I
		//IL_0022: Expected O, but got I
		_003CLoadPictureFromUrl_003Ed__10 stateMachine = new _003CLoadPictureFromUrl_003Ed__10(0);
		stateMachine.url = url;
		stateMachine.itemImage = itemImage;
		return stateMachine;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDF9E0", Offset = "0xFDF9E0", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsLoginManager()
	{
	}
}
