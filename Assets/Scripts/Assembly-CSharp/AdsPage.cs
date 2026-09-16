[global::Cpp2ILInjected.Token(Token = "0x200000B")]
public class AdsPage : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000045")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private LogScroller _logScroller;

	[global::Cpp2ILInjected.Token(Token = "0x4000046")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private string INTERSTITIAL_PLACEMENT_ID;

	[global::Cpp2ILInjected.Token(Token = "0x4000047")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private string VIDEO_PLACEMENT_ID;

	[global::Cpp2ILInjected.Token(Token = "0x6000071")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6C40", Offset = "0xFD6C40", Length = "0x7C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0014;\n\tv17 = Il2CppMethodInfo;\n\tv18 = v17 + 0x778;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A8DA]) = v37;\nL_0014:\n\tv40 = UnityEngine.Component::get_transform(this);\n\tv43 = UnityEngine.Transform::get_root(v40);\n\tv54 = Il2CppMethodInfo;\n\tv47 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v43, *([v54 @ X8_v4 (Il2CppMethodInfo)+778]));\n\tv69 = this + 0x20;\n\tthis._logScroller = *([v47 @ X0_v7+20]);\n\tv60 = 0xF3F1B4(v69, *([v47 @ X0_v7+20]), v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_0038: Expected O, but got I
		//IL_004a: Expected O, but got I
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Transform root = transform.root;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		object obj = (nint)this + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+20]");
		_logScroller = (LogScroller)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000072")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6CBC", Offset = "0xFD6CBC", Length = "0xB4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x940;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv46 = v45 + 0xCC8;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv56 = \"IsCyrillic\";\n\tv57 = v56 + 0x9A8;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8DB]) = v42;\nL_001D:\n\tv48 = \"IsCyrillic\";\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = Il2CppMethodInfo;\n\tLogScroller::Log(this._logScroller, *([v48 @ X8_v3 (System.String)+9A8]));\n\tv60 = new *([v50 @ X21_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CC8])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v60, this, *([v52 @ X22_v1 (Il2CppMethodInfo)+940]), 0);\n\tFacebook.Unity.FBGamingServices::LoadInterstitialAd(this.INTERSTITIAL_PLACEMENT_ID, v60);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 37 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnLoadInterstitialBtnClick()
	{
		//IL_001c: Expected I, but got O
		//IL_0039: Expected O, but got I
		string text = "IsCyrillic";
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = 0;
		LogScroller logScroller = _logScroller;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (System.String)+9A8]");
		logScroller.Log((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FBGamingServices.LoadInterstitialAd(INTERSTITIAL_PLACEMENT_ID, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000073")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6D8C", Offset = "0xFD6D8C", Length = "0xB4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x948;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv46 = v45 + 0xD18;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv56 = \"IsCyrillic\";\n\tv57 = v56 + 0x9D0;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8DC]) = v42;\nL_001D:\n\tv48 = \"IsCyrillic\";\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = Il2CppMethodInfo;\n\tLogScroller::Log(this._logScroller, *([v48 @ X8_v3 (System.String)+9D0]));\n\tv60 = new *([v50 @ X21_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+D18])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v60, this, *([v52 @ X22_v1 (Il2CppMethodInfo)+948]), 0);\n\tFacebook.Unity.FBGamingServices::LoadRewardedVideo(this.VIDEO_PLACEMENT_ID, v60);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 37 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnLoadVideoBtnClick()
	{
		//IL_001c: Expected I, but got O
		//IL_0039: Expected O, but got I
		string text = "IsCyrillic";
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = 0;
		LogScroller logScroller = _logScroller;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (System.String)+9D0]");
		logScroller.Log((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FBGamingServices.LoadRewardedVideo(VIDEO_PLACEMENT_ID, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000074")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6E40", Offset = "0xFD6E40", Length = "0xB4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x950;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv46 = v45 + 0xCC8;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv56 = \"Unable to decode certificate.\";\n\tv57 = v56 + 0xD68;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8DD]) = v42;\nL_001D:\n\tv48 = \"Unable to decode certificate.\";\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = Il2CppMethodInfo;\n\tLogScroller::Log(this._logScroller, *([v48 @ X8_v3 (System.String)+D68]));\n\tv60 = new *([v50 @ X21_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CC8])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v60, this, *([v52 @ X22_v1 (Il2CppMethodInfo)+950]), 0);\n\tFacebook.Unity.FBGamingServices::ShowInterstitialAd(this.INTERSTITIAL_PLACEMENT_ID, v60);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 37 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnViewInterstitialBtnClick()
	{
		//IL_001c: Expected I, but got O
		//IL_0039: Expected O, but got I
		string text = "Unable to decode certificate.";
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = 0;
		LogScroller logScroller = _logScroller;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (System.String)+D68]");
		logScroller.Log((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FBGamingServices.ShowInterstitialAd(INTERSTITIAL_PLACEMENT_ID, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000075")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6EF4", Offset = "0xFD6EF4", Length = "0xB4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x958;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv46 = v45 + 0xD18;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv56 = \"Unable to decode certificate.\";\n\tv57 = v56 + 0xD70;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8DE]) = v42;\nL_001D:\n\tv48 = \"Unable to decode certificate.\";\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = Il2CppMethodInfo;\n\tLogScroller::Log(this._logScroller, *([v48 @ X8_v3 (System.String)+D70]));\n\tv60 = new *([v50 @ X21_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+D18])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v60, this, *([v52 @ X22_v1 (Il2CppMethodInfo)+958]), 0);\n\tFacebook.Unity.FBGamingServices::ShowRewardedVideo(this.VIDEO_PLACEMENT_ID, v60);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 37 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnViewVideoBtnClick()
	{
		//IL_001c: Expected I, but got O
		//IL_0039: Expected O, but got I
		string text = "Unable to decode certificate.";
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = 0;
		LogScroller logScroller = _logScroller;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (System.String)+D70]");
		logScroller.Log((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FBGamingServices.ShowRewardedVideo(VIDEO_PLACEMENT_ID, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000076")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6D70", Offset = "0xFD6D70", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tLogScroller::Log(this._logScroller, text);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 10 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _LogText(string text)
	{
		_logScroller.Log(text);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000077")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6FA8", Offset = "0xFD6FA8", Length = "0x74")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = \", R=\";\n\tgoto L_0018;\n\tv23 = \", R=\";\n\tv24 = v23 + 0xCC0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A8DF]) = v43;\nL_0018:\n\tv46 = this + 0x28;\n\tthis.INTERSTITIAL_PLACEMENT_ID = *([v18 @ X20_v1 (System.String)+CC0]);\n\tv47 = 0xF3F1B4(v46, *([v18 @ X20_v1 (System.String)+CC0]), v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv50 = this + 0x30;\n\tthis.VIDEO_PLACEMENT_ID = *([v18 @ X20_v1 (System.String)+CC0]);\n\tv51 = 0xF3F1B4(v50, *([v18 @ X20_v1 (System.String)+CC0]), v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public AdsPage()
	{
		//IL_0021: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_0049: Expected O, but got I
		//IL_005b: Expected O, but got I
		base._002Ector();
		string text = ", R=";
		object obj = (nint)this + 40;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (System.String)+CC0]");
		INTERSTITIAL_PLACEMENT_ID = (string)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj2 = (nint)this + 48;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (System.String)+CC0]");
		VIDEO_PLACEMENT_ID = (string)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}
}
