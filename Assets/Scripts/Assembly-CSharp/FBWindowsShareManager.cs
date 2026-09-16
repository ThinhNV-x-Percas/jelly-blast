[global::Cpp2ILInjected.Token(Token = "0x200002C")]
public class FBWindowsShareManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40000B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x40000B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.UI.InputField Caption;

	[global::Cpp2ILInjected.Token(Token = "0x40000B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.UI.InputField ImageFile;

	[global::Cpp2ILInjected.Token(Token = "0x40000B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.UI.InputField VideoFile;

	[global::Cpp2ILInjected.Token(Token = "0x40000B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::UnityEngine.UI.InputField TravelID;

	[global::Cpp2ILInjected.Token(Token = "0x40000B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public global::UnityEngine.UI.Toggle ShouldShowDialog;

	[global::Cpp2ILInjected.Token(Token = "0x40000BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public global::UnityEngine.UI.Button ImageUploadButton;

	[global::Cpp2ILInjected.Token(Token = "0x40000BB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public global::UnityEngine.UI.Button VideoUploadButton;

	[global::Cpp2ILInjected.Token(Token = "0x6000114")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE360C", Offset = "0xFE360C", Length = "0x234")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = CollectParticleData[];\n\tv28 = *([302A942]) & 1;\n\tv29 = v28 == 0;\n\tif (v29) goto L_003B;\n\tv30 = *([v26 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv32 = *([v30 @ X0_v57+E0]) == 0;\n\tif (v32) goto L_0043;\nL_0019:\n\tv74 = UnityEngine.Application::get_streamingAssetsPath();\n\tv77 = this.ImageFile;\n\tv67 = this.ImageFile == 0;\n\tv68 = ~v67;\n\tif (v68) goto L_0047;\n\tgoto L_00B3;\nL_003B:\n\t*([302A942]) = 1;\n\tv52 = *([v26 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv226 = *([v52 @ X0_v53+E0]) == 0;\n\tv54 = ~v226;\n\tif (v54) goto L_0019;\nL_0043:\n\tv74 = UnityEngine.Application::get_streamingAssetsPath();\n\tv77 = this.ImageFile;\nL_0047:\n\tv79 = \", R=\";\n\tv86 = System.String::Concat(v74, *([v79 @ X9_v2 (System.String)+708]), v77.m_Text);\n\tgoto L_0058;\n\tv137 = \"il2cpp_codegen_runtime_class_init\"(v131, v84, v83, v85, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_0058:\n\tv140 = System.IO.Path::GetFullPath(v86);\n\tv214 = \"Unable to decode certificate.\";\n\tv215 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.UI.Selectable::set_interactable(this.ImageUploadButton, 0);\n\tv110 = System.String::Concat(*([v214 @ X21_v6 (System.String)+820]), v140, *([v215 @ X23_v2 (System.String)+730]));\n\tFBWindowsLogsManager::DebugLog(this.Logger, v110);\n\tv124 = this.Caption;\n\tv227 = System.Net.Configuration.SettingsSectionInternal;\n\tv112 = new *([v227 @ X9_v4 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F20])();\n\tSystem.Uri::.ctor(v112, v140);\n\tv125 = this.ShouldShowDialog;\n\tv107 = this.TravelID;\n\tv229 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv230 = Il2CppMethodInfo;\n\tv237 = new *([v229 @ X10_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CE0])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v237, this, *([v230 @ X25_v1 (Il2CppMethodInfo)+2E8]), 0);\n\tgoto L_009A;\n\tv244 = \"il2cpp_codegen_runtime_class_init\"(v242, v240, v239, v241, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_009A:\n\tv166 = v125.m_IsOn == 0;\n\tv151 = ~v166;\n\tFacebook.Unity.FB::UploadImageToMediaLibrary(v124.m_Text, v112, v151, v107.m_Text, v237);\n\treturn;\nL_00B3:\n\tthrow System.NullReferenceException;\n// 134 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Button_UploadImage()
	{
		//IL_000e: Expected I, but got O
		//IL_00ce: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_0142: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_01d5: Expected I, but got O
		//IL_0214: Expected I, but got O
		nint num = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A942]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v57+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v53+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		string streamingAssetsPath = global::UnityEngine.Application.streamingAssetsPath;
		global::UnityEngine.UI.InputField imageFile = ImageFile;
		goto IL_011b;
		IL_011b:
		string text = ", R=";
		string text2 = streamingAssetsPath;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X9_v2 (System.String)+708]");
		string path = text2 + (string)0 + imageFile.text;
		string fullPath = global::System.IO.Path.GetFullPath(path);
		string text3 = "Unable to decode certificate.";
		string text4 = "Writing object reference to Id '{0}' for {1}.";
		ImageUploadButton.interactable = false;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X21_v6 (System.String)+820]");
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X23_v2 (System.String)+730]");
		string message = (string)num2 + fullPath + (string)0;
		Logger.DebugLog(message);
		global::UnityEngine.UI.InputField caption = Caption;
		nint num3 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		global::System.Uri imageUri = new global::System.Uri(fullPath);
		global::UnityEngine.UI.Toggle shouldShowDialog = ShouldShowDialog;
		global::UnityEngine.UI.InputField travelID = TravelID;
		nint num4 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num5 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		bool flag = !shouldShowDialog.isOn;
		bool shouldLaunchMediaDialog = !flag;
		global::Facebook.Unity.FB.UploadImageToMediaLibrary(caption.text, imageUri, shouldLaunchMediaDialog, travelID.text, callback);
		return;
		IL_0076:
		streamingAssetsPath = global::UnityEngine.Application.streamingAssetsPath;
		imageFile = ImageFile;
		if ((object)ImageFile == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_011b;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000115")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE3840", Offset = "0xFE3840", Length = "0x234")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = CollectParticleData[];\n\tv28 = *([302A943]) & 1;\n\tv29 = v28 == 0;\n\tif (v29) goto L_003B;\n\tv30 = *([v26 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv32 = *([v30 @ X0_v57+E0]) == 0;\n\tif (v32) goto L_0043;\nL_0019:\n\tv74 = UnityEngine.Application::get_streamingAssetsPath();\n\tv77 = this.VideoFile;\n\tv67 = this.VideoFile == 0;\n\tv68 = ~v67;\n\tif (v68) goto L_0047;\n\tgoto L_00B3;\nL_003B:\n\t*([302A943]) = 1;\n\tv52 = *([v26 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv226 = *([v52 @ X0_v53+E0]) == 0;\n\tv54 = ~v226;\n\tif (v54) goto L_0019;\nL_0043:\n\tv74 = UnityEngine.Application::get_streamingAssetsPath();\n\tv77 = this.VideoFile;\nL_0047:\n\tv79 = \", R=\";\n\tv86 = System.String::Concat(v74, *([v79 @ X9_v2 (System.String)+708]), v77.m_Text);\n\tgoto L_0058;\n\tv137 = \"il2cpp_codegen_runtime_class_init\"(v131, v84, v83, v85, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_0058:\n\tv140 = System.IO.Path::GetFullPath(v86);\n\tv214 = \"Unable to decode certificate.\";\n\tv215 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.UI.Selectable::set_interactable(this.VideoUploadButton, 0);\n\tv110 = System.String::Concat(*([v214 @ X21_v6 (System.String)+828]), v140, *([v215 @ X23_v2 (System.String)+730]));\n\tFBWindowsLogsManager::DebugLog(this.Logger, v110);\n\tv124 = this.Caption;\n\tv227 = System.Net.Configuration.SettingsSectionInternal;\n\tv112 = new *([v227 @ X9_v4 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F20])();\n\tSystem.Uri::.ctor(v112, v140);\n\tv125 = this.ShouldShowDialog;\n\tv107 = this.TravelID;\n\tv229 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv230 = Il2CppMethodInfo;\n\tv237 = new *([v229 @ X10_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CE0])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v237, this, *([v230 @ X25_v1 (Il2CppMethodInfo)+2F0]), 0);\n\tgoto L_009A;\n\tv244 = \"il2cpp_codegen_runtime_class_init\"(v242, v240, v239, v241, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_009A:\n\tv166 = v125.m_IsOn == 0;\n\tv151 = ~v166;\n\tFacebook.Unity.FB::UploadVideoToMediaLibrary(v124.m_Text, v112, v151, v107.m_Text, v237);\n\treturn;\nL_00B3:\n\tthrow System.NullReferenceException;\n// 134 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Button_UploadVideo()
	{
		//IL_000e: Expected I, but got O
		//IL_00ce: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_0142: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_01d5: Expected I, but got O
		//IL_0214: Expected I, but got O
		nint num = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A943]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X0_v57+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v53+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		string streamingAssetsPath = global::UnityEngine.Application.streamingAssetsPath;
		global::UnityEngine.UI.InputField videoFile = VideoFile;
		goto IL_011b;
		IL_011b:
		string text = ", R=";
		string text2 = streamingAssetsPath;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X9_v2 (System.String)+708]");
		string path = text2 + (string)0 + videoFile.text;
		string fullPath = global::System.IO.Path.GetFullPath(path);
		string text3 = "Unable to decode certificate.";
		string text4 = "Writing object reference to Id '{0}' for {1}.";
		VideoUploadButton.interactable = false;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X21_v6 (System.String)+828]");
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X23_v2 (System.String)+730]");
		string message = (string)num2 + fullPath + (string)0;
		Logger.DebugLog(message);
		global::UnityEngine.UI.InputField caption = Caption;
		nint num3 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		global::System.Uri videoUri = new global::System.Uri(fullPath);
		global::UnityEngine.UI.Toggle shouldShowDialog = ShouldShowDialog;
		global::UnityEngine.UI.InputField travelID = TravelID;
		nint num4 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num5 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IMediaUploadResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		bool flag = !shouldShowDialog.isOn;
		bool shouldLaunchMediaDialog = !flag;
		global::Facebook.Unity.FB.UploadVideoToMediaLibrary(caption.text, videoUri, shouldLaunchMediaDialog, travelID.text, callback);
		return;
		IL_0076:
		streamingAssetsPath = global::UnityEngine.Application.streamingAssetsPath;
		videoFile = VideoFile;
		if ((object)VideoFile == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_011b;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000116")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE3A74", Offset = "0xFE3A74", Length = "0x284")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0025;\n\tv27 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv28 = v27 + 0xC28;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv50 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv51 = v50 + 0xDF8;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv166 = \"Hungarian\";\n\tv167 = v166 + 0x420;\n\tv168 = \"il2cpp_codegen_initialize_runtime_metadata\"(v167, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv169 = \"Hungarian\";\n\tv170 = v169 + 0x418;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v170, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A944]) = v47;\nL_0025:\n\tUnityEngine.UI.Selectable::set_interactable(this.ImageUploadButton, 1);\n\tv171 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv173 = result->klass;\n\tv278 = result->klass->rank;\n\tv175 = *([v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]) == 0;\n\tif (v175) goto L_004B;\n\tv277 = *([v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]) + 8;\nL_0036:\n\tv283 = *([v277 @ X10_v26-8]) == *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v283) goto L_004E;\n\tv277 = v277 + 0x10;\n\tv263 = v278 - 1;\n\tv243 = v278 != 1;\n\tif (v243) goto L_0036;\nL_004B:\n\tv307 = 0xF7087C(result, *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_0054;\nL_004E:\n\tv290 = *([v277 @ X10_v26]) << 4;\n\tv291 = v173 + v290;\n\tv307 = v291 + 0x138;\nL_0054:\n\t*([v307 @ X0_v5])(v312, result, *([v307 @ X0_v5+8]), v441, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv313 = result->klass;\n\tv413 = result->klass->rank;\n\tv315 = v312 == 0;\n\tif (v315) goto L_007D;\n\tv316 = \"Hungarian\";\n\tv318 = *([v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]) == 0;\n\tif (v318) goto L_007B;\n\tv391 = *([v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]) + 8;\nL_0066:\n\tv397 = *([v391 @ X10_v21-8]) == *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v397) goto L_00A1;\n\tv391 = v391 + 0x10;\n\tv348 = v413 - 1;\n\tv328 = v413 != 1;\n\tif (v328) goto L_0066;\nL_007B:\n\tv430 = 0xF7087C(result, *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 2, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00A8;\nL_007D:\n\tv319 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv322 = *([v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]) == 0;\n\tif (v322) goto L_009E;\n\tv412 = *([v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]) + 8;\nL_0089:\n\tv418 = *([v412 @ X10_v9-8]) == *([v319 @ X10_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+C28]);\n\tif (v418) goto L_00F5;\n\tv412 = v412 + 0x10;\n\tv377 = v413 - 1;\n\tv357 = v413 != 1;\n\tif (v357) goto L_0089;\nL_009E:\n\tv442 = 0xF7087C(result, *([v319 @ X10_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+C28]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00FB;\nL_00A1:\n\tv425 = *([v391 @ X10_v21]) + 2;\n\tv426 = v425 << 4;\n\tv427 = v313 + v426;\n\tv430 = v427 + 0x138;\nL_00A8:\n\t*([v430 @ X0_v17])(v434, result, *([v430 @ X0_v17+8]), v441, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv146 = System.String::Concat(*([v316 @ X23_v3 (System.String)+418]), v434);\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v146);\n\tv453 = result->klass;\n\tv480 = result->klass->rank;\n\tv455 = *([v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]) == 0;\n\tif (v455) goto L_00D4;\n\tv126 = *([v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]) + 8;\nL_00BF:\n\tv102 = *([v126 @ X10_v16-8]) == *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v102) goto L_00DE;\n\tv126 = v126 + 0x10;\n\tv468 = v480 - 1;\n\tv458 = v480 != 1;\n\tif (v458) goto L_00BF;\nL_00D4:\n\tv470 = 0xF7087C(result, *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([v470 @ X0_v26])(v489, result, *([v470 @ X0_v26+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv483 = this.Logger == 0;\n\tv153 = ~v483;\n\tif (v153) goto L_00F2;\n\tgoto L_0111;\nL_00DE:\n\tv66 = *([v126 @ X10_v16]) << 4;\n\tv485 = v453 + v66;\n\tv486 = v485 + 0x138;\n\t*([v486 @ X0_v29])(v489, result, *([v486 @ X0_v29+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_00F2:\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v489);\n\treturn;\nL_00F5:\n\tv438 = *([v412 @ X10_v9]) << 4;\n\tv439 = v313 + v438;\n\tv442 = v439 + 0x138;\nL_00FB:\n\t*([v442 @ X0_v8])(v447, result, *([v442 @ X0_v8+8]), v441, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv448 = \"Hungarian\";\n\tv149 = System.String::Concat(*([v448 @ X8_v10 (System.String)+420]), v447);\n\tFBWindowsLogsManager::DebugLog(this.Logger, v149);\n\treturn;\nL_0111:\n\tthrow System.NullReferenceException;\n// 174 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void CallbackUploadImage(global::Facebook.Unity.IMediaUploadResult result)
	{
		//IL_0028: Expected I, but got O
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d9: Expected O, but got I4
		//IL_0469: Expected I, but got O
		//IL_0479: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_01cc: Expected I, but got O
		//IL_0265: Expected O, but got I4
		//IL_00ec: Expected I4, but got O
		//IL_00fa: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_0112: Expected O, but got I4
		//IL_053e: Expected O, but got I
		//IL_0207: Expected O, but got I
		//IL_01b9: Expected O, but got I4
		//IL_008f: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_04e1: Expected O, but got I
		//IL_015b: Expected O, but got I
		//IL_03f3: Expected I4, but got O
		//IL_0401: Expected O, but got I
		//IL_0410: Expected O, but got I
		//IL_02c0: Expected I, but got O
		//IL_02d0: Expected O, but got I
		//IL_021b: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0295: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_030b: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_03a8: Expected I4, but got O
		//IL_03b6: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_032e: Expected O, but got I
		ImageUploadButton.interactable = true;
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c6;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X10_v26-8]");
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
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
			goto IL_00c6;
		}
		int num4 = obj2 << 4;
		object obj4 = num2 + num4;
		object obj5 = (nint)obj4 + 312;
		object obj6 = 0;
		goto IL_0457;
		IL_0356:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v470 @ X0_v26] (should have been resolved before IL gen)");
		if ((object)Logger == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_03d5;
		IL_01a6:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		obj6 = 2;
		goto IL_04c2;
		IL_04c2:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ X0_v17] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X23_v3 (System.String)+418]");
		string text = default(string);
		string message = (string)0 + text;
		Logger.DebugErrorLog(message);
		nint num5 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0356;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v16-8]");
			nint num6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
			if (num6 == 0)
			{
				break;
			}
			obj8 = (nint)obj8 + 16;
			object obj9 = (nint)obj7 - 1;
			bool flag2 = (nint)obj7 != 1;
			obj7 = obj9;
			if (flag2)
			{
				continue;
			}
			goto IL_0356;
		}
		int num7 = obj8 << 4;
		object obj10 = num5 + num7;
		object obj11 = (nint)obj10 + 312;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v486 @ X0_v29] (should have been resolved before IL gen)");
		goto IL_03d5;
		IL_03d5:
		string message2 = default(string);
		Logger.DebugErrorLog(message2);
		return;
		IL_00c6:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		obj6 = 0;
		goto IL_0457;
		IL_0457:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ X0_v5] (should have been resolved before IL gen)");
		nint num8 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		object obj12 = 0;
		object obj13 = default(object);
		if (obj13 != null)
		{
			string text2 = "Hungarian";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01a6;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]");
			object obj14 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X10_v21-8]");
				nint num9 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
				if (num9 == 0)
				{
					break;
				}
				obj14 = (nint)obj14 + 16;
				object obj15 = (nint)obj12 - 1;
				bool flag3 = (nint)obj12 != 1;
				obj12 = obj15;
				if (flag3)
				{
					continue;
				}
				goto IL_01a6;
			}
			object obj16 = obj14 + 2;
			int num10 = (int)((nint)obj16 << 4);
			object obj17 = num8 + num10;
			object obj18 = (nint)obj17 + 312;
			goto IL_04c2;
		}
		nint num11 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0252;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X10_v9-8]");
			nint num12 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X10_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+C28]");
			if (num12 == 0)
			{
				break;
			}
			obj19 = (nint)obj19 + 16;
			object obj20 = (nint)obj12 - 1;
			bool flag4 = (nint)obj12 != 1;
			obj12 = obj20;
			if (flag4)
			{
				continue;
			}
			goto IL_0252;
		}
		int num13 = obj19 << 4;
		object obj21 = num8 + num13;
		object obj22 = (nint)obj21 + 312;
		goto IL_0516;
		IL_0516:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v442 @ X0_v8] (should have been resolved before IL gen)");
		string text3 = "Hungarian";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v10 (System.String)+420]");
		string text4 = default(string);
		string message3 = (string)0 + text4;
		Logger.DebugLog(message3);
		return;
		IL_0252:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		obj6 = 0;
		goto IL_0516;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000117")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE3CF8", Offset = "0xFE3CF8", Length = "0x284")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0025;\n\tv27 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv28 = v27 + 0xC28;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv50 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv51 = v50 + 0xDF8;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv166 = \"Unable to decode certificate.\";\n\tv167 = v166 + 0xD48;\n\tv168 = \"il2cpp_codegen_initialize_runtime_metadata\"(v167, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv169 = \"Unable to decode certificate.\";\n\tv170 = v169 + 0xD40;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v170, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A945]) = v47;\nL_0025:\n\tUnityEngine.UI.Selectable::set_interactable(this.VideoUploadButton, 1);\n\tv171 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv173 = result->klass;\n\tv278 = result->klass->rank;\n\tv175 = *([v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]) == 0;\n\tif (v175) goto L_004B;\n\tv277 = *([v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]) + 8;\nL_0036:\n\tv283 = *([v277 @ X10_v26-8]) == *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v283) goto L_004E;\n\tv277 = v277 + 0x10;\n\tv263 = v278 - 1;\n\tv243 = v278 != 1;\n\tif (v243) goto L_0036;\nL_004B:\n\tv307 = 0xF7087C(result, *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_0054;\nL_004E:\n\tv290 = *([v277 @ X10_v26]) << 4;\n\tv291 = v173 + v290;\n\tv307 = v291 + 0x138;\nL_0054:\n\t*([v307 @ X0_v5])(v312, result, *([v307 @ X0_v5+8]), v441, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv313 = result->klass;\n\tv413 = result->klass->rank;\n\tv315 = v312 == 0;\n\tif (v315) goto L_007D;\n\tv316 = \"Unable to decode certificate.\";\n\tv318 = *([v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]) == 0;\n\tif (v318) goto L_007B;\n\tv391 = *([v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]) + 8;\nL_0066:\n\tv397 = *([v391 @ X10_v21-8]) == *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v397) goto L_00A1;\n\tv391 = v391 + 0x10;\n\tv348 = v413 - 1;\n\tv328 = v413 != 1;\n\tif (v328) goto L_0066;\nL_007B:\n\tv430 = 0xF7087C(result, *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 2, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00A8;\nL_007D:\n\tv319 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv322 = *([v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]) == 0;\n\tif (v322) goto L_009E;\n\tv412 = *([v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]) + 8;\nL_0089:\n\tv418 = *([v412 @ X10_v9-8]) == *([v319 @ X10_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+C28]);\n\tif (v418) goto L_00F5;\n\tv412 = v412 + 0x10;\n\tv377 = v413 - 1;\n\tv357 = v413 != 1;\n\tif (v357) goto L_0089;\nL_009E:\n\tv442 = 0xF7087C(result, *([v319 @ X10_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+C28]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00FB;\nL_00A1:\n\tv425 = *([v391 @ X10_v21]) + 2;\n\tv426 = v425 << 4;\n\tv427 = v313 + v426;\n\tv430 = v427 + 0x138;\nL_00A8:\n\t*([v430 @ X0_v17])(v434, result, *([v430 @ X0_v17+8]), v441, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv146 = System.String::Concat(*([v316 @ X23_v3 (System.String)+D40]), v434);\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v146);\n\tv453 = result->klass;\n\tv480 = result->klass->rank;\n\tv455 = *([v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]) == 0;\n\tif (v455) goto L_00D4;\n\tv126 = *([v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]) + 8;\nL_00BF:\n\tv102 = *([v126 @ X10_v16-8]) == *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v102) goto L_00DE;\n\tv126 = v126 + 0x10;\n\tv468 = v480 - 1;\n\tv458 = v480 != 1;\n\tif (v458) goto L_00BF;\nL_00D4:\n\tv470 = 0xF7087C(result, *([v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([v470 @ X0_v26])(v489, result, *([v470 @ X0_v26+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv483 = this.Logger == 0;\n\tv153 = ~v483;\n\tif (v153) goto L_00F2;\n\tgoto L_0111;\nL_00DE:\n\tv66 = *([v126 @ X10_v16]) << 4;\n\tv485 = v453 + v66;\n\tv486 = v485 + 0x138;\n\t*([v486 @ X0_v29])(v489, result, *([v486 @ X0_v29+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_00F2:\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v489);\n\treturn;\nL_00F5:\n\tv438 = *([v412 @ X10_v9]) << 4;\n\tv439 = v313 + v438;\n\tv442 = v439 + 0x138;\nL_00FB:\n\t*([v442 @ X0_v8])(v447, result, *([v442 @ X0_v8+8]), v441, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv448 = \"Unable to decode certificate.\";\n\tv149 = System.String::Concat(*([v448 @ X8_v10 (System.String)+D48]), v447);\n\tFBWindowsLogsManager::DebugLog(this.Logger, v149);\n\treturn;\nL_0111:\n\tthrow System.NullReferenceException;\n// 174 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void CallbackUploadVideo(global::Facebook.Unity.IMediaUploadResult result)
	{
		//IL_0028: Expected I, but got O
		//IL_0030: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_00d9: Expected O, but got I4
		//IL_0469: Expected I, but got O
		//IL_0479: Expected O, but got I
		//IL_007b: Expected O, but got I
		//IL_01cc: Expected I, but got O
		//IL_0265: Expected O, but got I4
		//IL_00ec: Expected I4, but got O
		//IL_00fa: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_0112: Expected O, but got I4
		//IL_053e: Expected O, but got I
		//IL_0207: Expected O, but got I
		//IL_01b9: Expected O, but got I4
		//IL_008f: Expected O, but got I
		//IL_009e: Expected O, but got I
		//IL_04e1: Expected O, but got I
		//IL_015b: Expected O, but got I
		//IL_03f3: Expected I4, but got O
		//IL_0401: Expected O, but got I
		//IL_0410: Expected O, but got I
		//IL_02c0: Expected I, but got O
		//IL_02d0: Expected O, but got I
		//IL_021b: Expected O, but got I
		//IL_022a: Expected O, but got I
		//IL_0273: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_0295: Expected O, but got I
		//IL_02a4: Expected O, but got I
		//IL_030b: Expected O, but got I
		//IL_016f: Expected O, but got I
		//IL_017e: Expected O, but got I
		//IL_03a8: Expected I4, but got O
		//IL_03b6: Expected O, but got I
		//IL_03c5: Expected O, but got I
		//IL_031f: Expected O, but got I
		//IL_032e: Expected O, but got I
		VideoUploadButton.interactable = true;
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00c6;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v173 @ X8_v4 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X10_v26-8]");
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
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
			goto IL_00c6;
		}
		int num4 = obj2 << 4;
		object obj4 = num2 + num4;
		object obj5 = (nint)obj4 + 312;
		object obj6 = 0;
		goto IL_0457;
		IL_0356:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v470 @ X0_v26] (should have been resolved before IL gen)");
		if ((object)Logger == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_03d5;
		IL_01a6:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		obj6 = 2;
		goto IL_04c2;
		IL_04c2:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v430 @ X0_v17] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v316 @ X23_v3 (System.String)+D40]");
		string text = default(string);
		string message = (string)0 + text;
		Logger.DebugErrorLog(message);
		nint num5 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0356;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v453 @ X8_v15 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X10_v16-8]");
			nint num6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
			if (num6 == 0)
			{
				break;
			}
			obj8 = (nint)obj8 + 16;
			object obj9 = (nint)obj7 - 1;
			bool flag2 = (nint)obj7 != 1;
			obj7 = obj9;
			if (flag2)
			{
				continue;
			}
			goto IL_0356;
		}
		int num7 = obj8 << 4;
		object obj10 = num5 + num7;
		object obj11 = (nint)obj10 + 312;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v486 @ X0_v29] (should have been resolved before IL gen)");
		goto IL_03d5;
		IL_03d5:
		string message2 = default(string);
		Logger.DebugErrorLog(message2);
		return;
		IL_00c6:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		obj6 = 0;
		goto IL_0457;
		IL_0457:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v307 @ X0_v5] (should have been resolved before IL gen)");
		nint num8 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		object obj12 = 0;
		object obj13 = default(object);
		if (obj13 != null)
		{
			string text2 = "Unable to decode certificate.";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_01a6;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]");
			object obj14 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v391 @ X10_v21-8]");
				nint num9 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v171 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
				if (num9 == 0)
				{
					break;
				}
				obj14 = (nint)obj14 + 16;
				object obj15 = (nint)obj12 - 1;
				bool flag3 = (nint)obj12 != 1;
				obj12 = obj15;
				if (flag3)
				{
					continue;
				}
				goto IL_01a6;
			}
			object obj16 = obj14 + 2;
			int num10 = (int)((nint)obj16 << 4);
			object obj17 = num8 + num10;
			object obj18 = (nint)obj17 + 312;
			goto IL_04c2;
		}
		nint num11 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0252;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v313 @ X8_v7 (Il2CppClass<Facebook.Unity.IMediaUploadResult>)+B0]");
		object obj19 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v412 @ X10_v9-8]");
			nint num12 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v319 @ X10_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+C28]");
			if (num12 == 0)
			{
				break;
			}
			obj19 = (nint)obj19 + 16;
			object obj20 = (nint)obj12 - 1;
			bool flag4 = (nint)obj12 != 1;
			obj12 = obj20;
			if (flag4)
			{
				continue;
			}
			goto IL_0252;
		}
		int num13 = obj19 << 4;
		object obj21 = num8 + num13;
		object obj22 = (nint)obj21 + 312;
		goto IL_0516;
		IL_0516:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v442 @ X0_v8] (should have been resolved before IL gen)");
		string text3 = "Unable to decode certificate.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v448 @ X8_v10 (System.String)+D48]");
		string text4 = default(string);
		string message3 = (string)0 + text4;
		Logger.DebugLog(message3);
		return;
		IL_0252:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		obj6 = 0;
		goto IL_0516;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000118")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE3F7C", Offset = "0xFE3F7C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsShareManager()
	{
	}
}
