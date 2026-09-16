[global::Cpp2ILInjected.Token(Token = "0x2000015")]
public class Utility
{
	[global::System.Runtime.CompilerServices.CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x2000016")]
	private sealed class _003CGetTexture_003Ed__1 : global::System.Collections.Generic.IEnumerator<object>, global::System.Collections.IEnumerator, global::System.IDisposable
	{
		[global::Cpp2ILInjected.Token(Token = "0x400006F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private int _003C_003E1__state;

		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object _003C_003E2__current;

		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public string id;

		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public global::System.Action<global::UnityEngine.Texture> callback;

		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public string url;

		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::UnityEngine.Networking.UnityWebRequest _003Cwww_003E5__2;

		[global::Cpp2ILInjected.Token(Token = "0x17000004")]
		object global::System.Collections.Generic.IEnumerator<object>.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
			[global::Cpp2ILInjected.Address(RVA = "0xFDBF2C", Offset = "0xFDBF2C", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000005")]
		object global::System.Collections.IEnumerator.Current
		{
			[global::System.Diagnostics.DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
			[global::Cpp2ILInjected.Address(RVA = "0xFDBF74", Offset = "0xFDBF74", Length = "0x8")]
			[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.<>2__current;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
			get
			{
				return _003C_003E2__current;
			}
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
		[global::Cpp2ILInjected.Address(RVA = "0xFDBC40", Offset = "0xFDBC40", Length = "0x2C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\tthis.<>1__state = <>1__state;\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public _003CGetTexture_003Ed__1(int _003C_003E1__state)
		{
			this._003C_003E1__state = _003C_003E1__state;
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
		[global::Cpp2ILInjected.Address(RVA = "0xFDBD10", Offset = "0xFDBD10", Length = "0x4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
		void global::System.IDisposable.Dispose()
		{
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
		[global::Cpp2ILInjected.Address(RVA = "0xFDBD14", Offset = "0xFDBD14", Length = "0x218")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv21 = System.ComponentModel.BooleanConverter;\n\tv22 = v21 + 0xB98;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0xB30;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0xB38;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv152 = System.Net.Configuration.SettingsSectionInternal;\n\tv153 = v152 + 0xF78;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v153, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A90B]) = v42;\nL_0022:\n\tv48 = this.<>1__state == 1;\n\tif (v48) goto L_0063;\n\tv56 = this.<>1__state == 0;\n\tv57 = ~v56;\n\tif (v57) goto L_00BE;\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv65 = System.Net.Configuration.SettingsSectionInternal;\n\tv155 = *([v65 @ X20_v5 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]);\n\tgoto L_0036;\n\tv154 = \"il2cpp_codegen_runtime_class_init\"(v67, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv156 = *([v66 @ X20_v6]);\nL_0036:\n\tv147 = *([v155 @ X0_v19+B8]);\n\tv208 = Il2CppMethodInfo;\n\tv209 = System.Collections.Generic.Dictionary`2<System.Object, System.Object>::ContainsKey(*([v147 @ X8_v14]), this.id);\n\tv210 = ~v209;\n\tif (v210) goto L_008B;\n\tv119 = this.callback;\n\tv227 = *([v65 @ X20_v5 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]);\n\tgoto L_0049;\n\tv226 = \"il2cpp_codegen_runtime_class_init\"(v213, v127, v122, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv228 = *([v66 @ X20_v6]);\nL_0049:\n\tv148 = *([v227 @ X0_v32+B8]);\n\tv129 = System.Collections.Generic.Dictionary`2<System.Object, System.Object>::get_Item(*([v148 @ X8_v18]), this.id);\n\tv119.invoke_impl(v238, v119.method_code, v129, v119.method, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\treturn 0;\nL_0063:\n\tthis.<>1__state = 0xFFFFFFFF;\n\tv108 = UnityEngine.Networking.UnityWebRequest::get_responseCode(this.<www>5__2);\n\tv72 = v108 != 0xC8;\n\tif (v72) goto L_00A9;\n\tv130 = UnityEngine.Networking.DownloadHandlerTexture::GetContent(this.<www>5__2);\n\tv144 = this.callback;\n\tv144.invoke_impl(v221, v144.method_code, v130, v144.method, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\treturn 0;\nL_008B:\n\tv219 = UnityEngine.Networking.UnityWebRequestTexture::GetTexture(this.url);\n\tv150 = this + 0x38;\n\tthis.<www>5__2 = v219;\n\tv231 = 0xF3F1B4(v150, v219, *([v208 @ X8_v15 (Il2CppMethodInfo)+B30]), v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv236 = UnityEngine.Networking.UnityWebRequest::SendWebRequest(this.<www>5__2);\n\tv239 = this + 0x18;\n\tthis.<>2__current = v236;\n\tv241 = 0xF3F1B4(v239, v236, *([v208 @ X8_v15 (Il2CppMethodInfo)+B30]), v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tthis.<>1__state = 1;\n\treturn 1;\nL_00A9:\n\tv212 = UnityEngine.Networking.UnityWebRequest::get_error(this.<www>5__2);\n\tgoto L_00B5;\n\tv232 = \"il2cpp_codegen_runtime_class_init\"(v224, v211, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_00B5:\n\tUnityEngine.Debug::Log(v212);\nL_00BE:\n\treturn 0;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 128 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private bool MoveNext()
		{
			//IL_0048: Expected I, but got O
			//IL_0058: Expected O, but got I
			//IL_0214: Expected O, but got I
			//IL_015f: Expected O, but got I
			//IL_0193: Expected O, but got I
			//IL_00a9: Expected O, but got I
			//IL_0229: Expected O, but got I
			if (_003C_003E1__state != 1)
			{
				if (_003C_003E1__state == 0)
				{
					_003C_003E1__state = -1;
					nint num = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X20_v5 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]");
					object obj = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v19+B8]");
					object obj2 = 0;
					nint num2 = 0;
					if (((global::System.Collections.Generic.Dictionary<object, object>)obj2).ContainsKey((object)id))
					{
						global::System.Action<global::UnityEngine.Texture> action = callback;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X20_v5 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]");
						object obj3 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v227 @ X0_v32+B8]");
						object obj4 = 0;
						object obj5 = ((global::System.Collections.Generic.Dictionary<object, object>)obj4)[(object)id];
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v119.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
						return false;
					}
					global::UnityEngine.Networking.UnityWebRequest texture = global::UnityEngine.Networking.UnityWebRequestTexture.GetTexture(url);
					object obj6 = (nint)this + 56;
					_003Cwww_003E5__2 = texture;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					global::UnityEngine.Networking.UnityWebRequestAsyncOperation unityWebRequestAsyncOperation = _003Cwww_003E5__2.SendWebRequest();
					object obj7 = (nint)this + 24;
					_003C_003E2__current = unityWebRequestAsyncOperation;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
					_003C_003E1__state = 1;
					return true;
				}
			}
			else
			{
				_003C_003E1__state = -1;
				long responseCode = _003Cwww_003E5__2.responseCode;
				if (responseCode == 200)
				{
					global::UnityEngine.Texture2D content = global::UnityEngine.Networking.DownloadHandlerTexture.GetContent(_003Cwww_003E5__2);
					global::System.Action<global::UnityEngine.Texture> action2 = callback;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v144.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
					return false;
				}
				string error = _003Cwww_003E5__2.error;
				global::UnityEngine.Debug.Log(error);
			}
			return false;
		}

		bool global::System.Collections.IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[global::System.Diagnostics.DebuggerHidden]
		[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
		[global::Cpp2ILInjected.Address(RVA = "0xFDBF34", Offset = "0xFDBF34", Length = "0x40")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = Facebook.Unity.Windows.IWindowsFacebook + 0xF30;\n\tv11 = 0xF3F22C(v10, methodInfo, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tv27 = new v11();\n\tSystem.NotSupportedException::.ctor(v27);\n\tv31 = Il2CppMethodInfo + 0x480;\n\tv32 = 0xF3F22C(v31, 0, v13, v14, v15, v16, v17, v18, v19, v20, v21, v22, v23, v24, v25, v26);\n\tthrow v27;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		void global::System.Collections.IEnumerator.Reset()
		{
			//IL_000f: Unknown result type (might be due to invalid IL or missing references)
			//IL_0014: Expected O, but got Unknown
			//IL_0039: Expected O, but got I
			object obj = typeof(global::Facebook.Unity.Windows.IWindowsFacebook) + 3888;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			global::System.NotSupportedException ex = new global::System.NotSupportedException();
			object obj2 = (nint)0 + (nint)1152;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F22C");
			throw ex;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x400006E")]
	private static global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Texture> _textures;

	[global::System.Runtime.CompilerServices.IteratorStateMachine(typeof(Utility._003CGetTexture_003Ed__1))]
	[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD65A8", Offset = "0xFD65A8", Length = "0xA8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = Sponge+<>c__DisplayClass7_0;\n\tgoto L_001B;\n\tv31 = Sponge+<>c__DisplayClass7_0;\n\tv32 = v31 + 0x568;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, url, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv49 = 1;\n\t*([302A9A6]) = v49;\nL_001B:\n\tv51 = new *([v26 @ X23_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+568])();\n\tSystem.Object::.ctor(v51);\n\t*([v51 @ X0_v3 (System.Object)+10]) = 0;\n\tv55 = v51 + 0x20;\n\t*([v51 @ X0_v3 (System.Object)+20]) = id;\n\tv57 = 0xF3F1B4(v55, id, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv59 = v51 + 0x30;\n\t*([v51 @ X0_v3 (System.Object)+30]) = url;\n\tv61 = 0xF3F1B4(v59, url, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv63 = v51 + 0x28;\n\t*([v51 @ X0_v3 (System.Object)+28]) = callback;\n\tv65 = 0xF3F1B4(v63, callback, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturn v51;\n// 38 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static global::System.Collections.IEnumerator GetTexture(string id, string url, global::System.Action<global::UnityEngine.Texture> callback)
	{
		//IL_000e: Expected I, but got O
		//IL_0078: Expected O, but got I
		//IL_0022: Expected O, but got I
		//IL_0040: Expected O, but got I
		nint num = (nint)typeof(Sponge._003C_003Ec__DisplayClass7_0);
		object obj = new object();
		_ = 0;
		object obj2 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)obj + 48;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj4 = (nint)obj + 40;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return (global::System.Collections.IEnumerator)obj;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDBC6C", Offset = "0xFDBC6C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Utility()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDBC74", Offset = "0xFDBC74", Length = "0x9C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv20 = System.Net.Configuration.SettingsSectionInternal;\n\tgoto L_0020;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xB28;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv51 = v50 + 0x638;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv55 = System.Net.Configuration.SettingsSectionInternal;\n\tv56 = v55 + 0xF78;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv47 = 1;\n\t*([302A90A]) = v47;\nL_0020:\n\tv49 = new *([v16 @ X22_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+638])();\n\tSystem.Collections.Generic.Dictionary`2<System.Object, System.Object>::.ctor(v49);\n\tv57 = *([v20 @ X20_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]);\n\tv58 = *([v57 @ X8_v3+B8]);\n\t*([v58 @ X8_v4]) = v49;\n\tv59 = *([v20 @ X20_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]);\n\tv68 = 0xF3F1B4(*([v59 @ X8_v5+B8]), v49, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 29 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	static Utility()
	{
		//IL_000e: Expected I, but got O
		//IL_001d: Expected I, but got O
		//IL_003d: Expected O, but got I
		//IL_004d: Expected O, but got I
		//IL_0065: Expected O, but got I
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		object obj = new global::System.Collections.Generic.Dictionary<object, object>();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X20_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v3+B8]");
		object obj3 = 0;
		obj3 = obj;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v20 @ X20_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}
}
