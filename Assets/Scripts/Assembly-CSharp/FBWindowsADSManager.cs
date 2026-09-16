[global::Cpp2ILInjected.Token(Token = "0x2000019")]
public class FBWindowsADSManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400007B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x400007C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.UI.InputField InputInterstitialAd;

	[global::Cpp2ILInjected.Token(Token = "0x400007D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.UI.InputField InputRewardedVideo;

	[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC40C", Offset = "0xFDC40C", Length = "0x130")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0026;\n\tv29 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv30 = v29 + 0x1F0;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv52 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv53 = v52 + 0xD18;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0xBC0;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv61 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv62 = v61 + 0xA58;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv75 = \"IsCyrillic\";\n\tv76 = v75 + 0x9C0;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv49 = 1;\n\t*([302A90E]) = v49;\nL_0026:\n\tv51 = new *([v24 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+A58])();\n\tSystem.Object::.ctor(v51);\n\tv65 = v51 + 0x10;\n\t*([v51 @ X0_v3 (System.Object)+10]) = this;\n\tv67 = 0xF3F1B4(v65, this, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv78 = v51 + 0x18;\n\t*([v51 @ X0_v3 (System.Object)+18]) = placementID;\n\tv79 = 0xF3F1B4(v78, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv108 = \"IsCyrillic\";\n\tv110 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv112 = Il2CppMethodInfo;\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v108 @ X8_v3 (System.String)+9C0]));\n\tv119 = new *([v110 @ X20_v2 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+D18])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v119, v51, *([v112 @ X22_v3 (Il2CppMethodInfo)+BC0]), 0);\n\tgoto L_005D;\n\tv125 = \"il2cpp_codegen_runtime_class_init\"(v123, v122, v121, v85, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\nL_005D:\n\tFacebook.Unity.FB::LoadRewardedVideo(*([v51 @ X0_v3 (System.Object)+18]), v119);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 58 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void LoadRewardedVideo(string placementID)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0068: Expected I, but got O
		//IL_0085: Expected O, but got I
		//IL_00b3: Expected O, but got I
		nint num = (nint)typeof(global::Facebook.Unity.AsyncRequestString._003CStart_003Ed__9);
		object obj = new object();
		object obj2 = (nint)obj + 16;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)obj + 24;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		string text = "IsCyrillic";
		nint num2 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num3 = 0;
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v3 (System.String)+9C0]");
		logger.DebugLog((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		global::Facebook.Unity.FB.LoadRewardedVideo((string)0, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC544", Offset = "0xFDC544", Length = "0x130")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0026;\n\tv29 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv30 = v29 + 0x1F0;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv52 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv53 = v52 + 0xD18;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0xBC8;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv61 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv62 = v61 + 0xA60;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv75 = \"Scrollbar Horizontal\";\n\tv76 = v75 + 0x340;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv49 = 1;\n\t*([302A90F]) = v49;\nL_0026:\n\tv51 = new *([v24 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+A60])();\n\tSystem.Object::.ctor(v51);\n\tv65 = v51 + 0x10;\n\t*([v51 @ X0_v3 (System.Object)+10]) = this;\n\tv67 = 0xF3F1B4(v65, this, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv78 = v51 + 0x18;\n\t*([v51 @ X0_v3 (System.Object)+18]) = placementID;\n\tv79 = 0xF3F1B4(v78, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv108 = \"Scrollbar Horizontal\";\n\tv110 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv112 = Il2CppMethodInfo;\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v108 @ X8_v3 (System.String)+340]));\n\tv119 = new *([v110 @ X20_v2 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+D18])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v119, v51, *([v112 @ X22_v3 (Il2CppMethodInfo)+BC8]), 0);\n\tgoto L_005D;\n\tv125 = \"il2cpp_codegen_runtime_class_init\"(v123, v122, v121, v85, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\nL_005D:\n\tFacebook.Unity.FB::ShowRewardedVideo(*([v51 @ X0_v3 (System.Object)+18]), v119);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 58 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ShowRewardedVideo(string placementID)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0068: Expected I, but got O
		//IL_0085: Expected O, but got I
		//IL_00b3: Expected O, but got I
		nint num = (nint)typeof(global::Facebook.Unity.AsyncRequestString._003CStart_003Ed__9);
		object obj = new object();
		object obj2 = (nint)obj + 16;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)obj + 24;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		string text = "Scrollbar Horizontal";
		nint num2 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num3 = 0;
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v3 (System.String)+340]");
		logger.DebugLog((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IRewardedVideoResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		global::Facebook.Unity.FB.ShowRewardedVideo((string)0, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC67C", Offset = "0xFDC67C", Length = "0x130")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0026;\n\tv29 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv30 = v29 + 0x1F0;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv52 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv53 = v52 + 0xCC8;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0xBD0;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv61 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv62 = v61 + 0xA68;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv75 = \"IsCyrillic\";\n\tv76 = v75 + 0x9A0;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv49 = 1;\n\t*([302A910]) = v49;\nL_0026:\n\tv51 = new *([v24 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+A68])();\n\tSystem.Object::.ctor(v51);\n\tv65 = v51 + 0x10;\n\t*([v51 @ X0_v3 (System.Object)+10]) = this;\n\tv67 = 0xF3F1B4(v65, this, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv78 = v51 + 0x18;\n\t*([v51 @ X0_v3 (System.Object)+18]) = placementID;\n\tv79 = 0xF3F1B4(v78, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv108 = \"IsCyrillic\";\n\tv110 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv112 = Il2CppMethodInfo;\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v108 @ X8_v3 (System.String)+9A0]));\n\tv119 = new *([v110 @ X20_v2 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CC8])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v119, v51, *([v112 @ X22_v3 (Il2CppMethodInfo)+BD0]), 0);\n\tgoto L_005D;\n\tv125 = \"il2cpp_codegen_runtime_class_init\"(v123, v122, v121, v85, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\nL_005D:\n\tFacebook.Unity.FB::LoadInterstitialAd(*([v51 @ X0_v3 (System.Object)+18]), v119);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 58 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void LoadInterstitialAd(string placementID)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0068: Expected I, but got O
		//IL_0085: Expected O, but got I
		//IL_00b3: Expected O, but got I
		nint num = (nint)typeof(global::Facebook.Unity.AsyncRequestString._003CStart_003Ed__9);
		object obj = new object();
		object obj2 = (nint)obj + 16;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)obj + 24;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		string text = "IsCyrillic";
		nint num2 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num3 = 0;
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v3 (System.String)+9A0]");
		logger.DebugLog((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		global::Facebook.Unity.FB.LoadInterstitialAd((string)0, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC7B4", Offset = "0xFDC7B4", Length = "0x130")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0026;\n\tv29 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv30 = v29 + 0x1F0;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv52 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv53 = v52 + 0xCC8;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0xBD8;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv61 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv62 = v61 + 0xA70;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv75 = \"Scrollbar Horizontal\";\n\tv76 = v75 + 0x338;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv49 = 1;\n\t*([302A911]) = v49;\nL_0026:\n\tv51 = new *([v24 @ X22_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+A70])();\n\tSystem.Object::.ctor(v51);\n\tv65 = v51 + 0x10;\n\t*([v51 @ X0_v3 (System.Object)+10]) = this;\n\tv67 = 0xF3F1B4(v65, this, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv78 = v51 + 0x18;\n\t*([v51 @ X0_v3 (System.Object)+18]) = placementID;\n\tv79 = 0xF3F1B4(v78, placementID, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv108 = \"Scrollbar Horizontal\";\n\tv110 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv112 = Il2CppMethodInfo;\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v108 @ X8_v3 (System.String)+338]));\n\tv119 = new *([v110 @ X20_v2 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CC8])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v119, v51, *([v112 @ X22_v3 (Il2CppMethodInfo)+BD8]), 0);\n\tgoto L_005D;\n\tv125 = \"il2cpp_codegen_runtime_class_init\"(v123, v122, v121, v85, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\nL_005D:\n\tFacebook.Unity.FB::ShowInterstitialAd(*([v51 @ X0_v3 (System.Object)+18]), v119);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 58 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ShowInterstitialAd(string placementID)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0068: Expected I, but got O
		//IL_0085: Expected O, but got I
		//IL_00b3: Expected O, but got I
		nint num = (nint)typeof(global::Facebook.Unity.AsyncRequestString._003CStart_003Ed__9);
		object obj = new object();
		object obj2 = (nint)obj + 16;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)obj + 24;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		string text = "Scrollbar Horizontal";
		nint num2 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num3 = 0;
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v108 @ X8_v3 (System.String)+338]");
		logger.DebugLog((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IInterstitialAdResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		global::Facebook.Unity.FB.ShowInterstitialAd((string)0, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC8EC", Offset = "0xFDC8EC", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0012;\n\tv17 = \"Parent table name is missing in relation '{0}'.\";\n\tv18 = v17 + 0x208;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A912]) = v37;\nL_0012:\n\tv38 = this.InputInterstitialAd;\n\tv42 = System.String::IsNullOrEmpty(v38.m_Text);\n\tv53 = v42 == 0;\n\tif (v53) goto L_0028;\n\tv74 = \"Parent table name is missing in relation '{0}'.\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v74 @ X8_v6 (System.String)+208]));\n\treturn;\nL_0028:\n\tv50 = this.InputInterstitialAd;\n\tFBWindowsADSManager::LoadInterstitialAd(this, v50.m_Text);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnButtonLoadInterstitialAd()
	{
		//IL_0054: Expected O, but got I
		global::UnityEngine.UI.InputField inputInterstitialAd = InputInterstitialAd;
		if (string.IsNullOrEmpty(inputInterstitialAd.text))
		{
			string text = "Parent table name is missing in relation '{0}'.";
			FBWindowsLogsManager logger = Logger;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6 (System.String)+208]");
			logger.DebugWarningLog((string)0);
		}
		else
		{
			global::UnityEngine.UI.InputField inputInterstitialAd2 = InputInterstitialAd;
			LoadInterstitialAd(inputInterstitialAd2.text);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDCA44", Offset = "0xFDCA44", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0012;\n\tv17 = \"Parent table name is missing in relation '{0}'.\";\n\tv18 = v17 + 0x208;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A913]) = v37;\nL_0012:\n\tv38 = this.InputInterstitialAd;\n\tv42 = System.String::IsNullOrEmpty(v38.m_Text);\n\tv53 = v42 == 0;\n\tif (v53) goto L_0028;\n\tv74 = \"Parent table name is missing in relation '{0}'.\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v74 @ X8_v6 (System.String)+208]));\n\treturn;\nL_0028:\n\tv50 = this.InputInterstitialAd;\n\tFBWindowsADSManager::ShowInterstitialAd(this, v50.m_Text);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnButtonShowInterstitialAd()
	{
		//IL_0054: Expected O, but got I
		global::UnityEngine.UI.InputField inputInterstitialAd = InputInterstitialAd;
		if (string.IsNullOrEmpty(inputInterstitialAd.text))
		{
			string text = "Parent table name is missing in relation '{0}'.";
			FBWindowsLogsManager logger = Logger;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6 (System.String)+208]");
			logger.DebugWarningLog((string)0);
		}
		else
		{
			global::UnityEngine.UI.InputField inputInterstitialAd2 = InputInterstitialAd;
			ShowInterstitialAd(inputInterstitialAd2.text);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDCACC", Offset = "0xFDCACC", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0012;\n\tv17 = \"Parent table name is missing in relation '{0}'.\";\n\tv18 = v17 + 0x210;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A914]) = v37;\nL_0012:\n\tv38 = this.InputRewardedVideo;\n\tv42 = System.String::IsNullOrEmpty(v38.m_Text);\n\tv53 = v42 == 0;\n\tif (v53) goto L_0028;\n\tv74 = \"Parent table name is missing in relation '{0}'.\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v74 @ X8_v6 (System.String)+210]));\n\treturn;\nL_0028:\n\tv50 = this.InputRewardedVideo;\n\tFBWindowsADSManager::LoadRewardedVideo(this, v50.m_Text);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnButtonLoadRewardedVideo()
	{
		//IL_0054: Expected O, but got I
		global::UnityEngine.UI.InputField inputRewardedVideo = InputRewardedVideo;
		if (string.IsNullOrEmpty(inputRewardedVideo.text))
		{
			string text = "Parent table name is missing in relation '{0}'.";
			FBWindowsLogsManager logger = Logger;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6 (System.String)+210]");
			logger.DebugWarningLog((string)0);
		}
		else
		{
			global::UnityEngine.UI.InputField inputRewardedVideo2 = InputRewardedVideo;
			LoadRewardedVideo(inputRewardedVideo2.text);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDCB54", Offset = "0xFDCB54", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0012;\n\tv17 = \"Parent table name is missing in relation '{0}'.\";\n\tv18 = v17 + 0x210;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A915]) = v37;\nL_0012:\n\tv38 = this.InputRewardedVideo;\n\tv42 = System.String::IsNullOrEmpty(v38.m_Text);\n\tv53 = v42 == 0;\n\tif (v53) goto L_0028;\n\tv74 = \"Parent table name is missing in relation '{0}'.\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v74 @ X8_v6 (System.String)+210]));\n\treturn;\nL_0028:\n\tv50 = this.InputRewardedVideo;\n\tFBWindowsADSManager::ShowRewardedVideo(this, v50.m_Text);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnButtonShowRewardedVideo()
	{
		//IL_0054: Expected O, but got I
		global::UnityEngine.UI.InputField inputRewardedVideo = InputRewardedVideo;
		if (string.IsNullOrEmpty(inputRewardedVideo.text))
		{
			string text = "Parent table name is missing in relation '{0}'.";
			FBWindowsLogsManager logger = Logger;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v74 @ X8_v6 (System.String)+210]");
			logger.DebugWarningLog((string)0);
		}
		else
		{
			global::UnityEngine.UI.InputField inputRewardedVideo2 = InputRewardedVideo;
			ShowRewardedVideo(inputRewardedVideo2.text);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDCBDC", Offset = "0xFDCBDC", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsADSManager()
	{
	}
}
