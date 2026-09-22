[global::Cpp2ILInjected.Token(Token = "0x200000D")]
public class MainPage : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400004C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private Menu _menu;

	[global::Cpp2ILInjected.Token(Token = "0x400004D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private LogScroller _logScroller;

	[global::Cpp2ILInjected.Token(Token = "0x6000080")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD7C38", Offset = "0xFD7C38", Length = "0x1A0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0025;\n\tv21 = CollectParticleData[];\n\tv22 = v21 + 0xB30;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv46 = Il2CppMethodInfo;\n\tv47 = v46 + 0x778;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v47, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv50 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv51 = v50 + 0x1F0;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv80 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv81 = v80 + 0x118;\n\tv82 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv83 = Il2CppMethodInfo;\n\tv84 = v83 + 0x118;\n\tv85 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv119 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv120 = v119 + 0x240;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v120, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8E7]) = v42;\nL_0025:\n\tv45 = UnityEngine.Component::get_transform(this);\n\tv54 = UnityEngine.Transform::get_root(v45);\n\tv86 = Il2CppMethodInfo;\n\tv65 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v54, *([v86 @ X8_v4 (Il2CppMethodInfo)+778]));\n\tv78 = this + 0x28;\n\tthis._logScroller = *([v65 @ X0_v7+20]);\n\tv124 = 0xF3F1B4(v78, *([v65 @ X0_v7+20]), v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tgoto L_0042;\n\tv128 = \"il2cpp_codegen_runtime_class_init\"(v125, v62, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0042:\n\tv66 = UnityEngine.Application::get_identifier();\n\tv131 = UnityEngine.UIElements.EnumFieldHelpers;\n\tLogScroller::Log(this._logScroller, v66);\n\tv133 = *([v131 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv134 = *([v133 @ X0_v15+E0]) == 0;\n\tif (v134) goto L_005D;\n\tv136 = Facebook.Unity.FB::get_IsInitialized();\n\tv139 = v136 == 0;\n\tif (v139) goto L_0065;\nL_005A:\n\treturn;\nL_005D:\n\tv141 = Facebook.Unity.FB::get_IsInitialized();\n\tv146 = v141 == 0;\n\tv142 = ~v146;\n\tif (v142) goto L_005A;\nL_0065:\n\tv147 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tLogScroller::Log(this._logScroller, *([v147 @ X8_v8 (System.String)+240]));\n\tv150 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv153 = new *([v150 @ X8_v10 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+118])();\n\tv155 = Il2CppMethodInfo;\n\tFacebook.Unity.InitDelegate::.ctor(v153, this, *([v155 @ X8_v12 (Il2CppMethodInfo)+118]));\n\tgoto L_0085;\n\tv162 = \"il2cpp_codegen_runtime_class_init\"(v160, v158, v157, v159, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0085:\n\tFacebook.Unity.FB::Init(v153, 0, 0);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 81 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		_logScroller = base.transform.root.GetComponent<LogScroller>();
		_logScroller.Log(global::UnityEngine.Application.identifier);
		if (global::Facebook.Unity.FB.IsInitialized)
		{
			return;
		}
		_logScroller.Log("Calling FB.Init");
		global::Facebook.Unity.FB.Init(_OnInitComplete, null, null);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000081")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD7DF4", Offset = "0xFD7DF4", Length = "0xF8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = 0x302A000;\n\tv14 = *([302A8E8]) & 1;\n\tv15 = v14 == 0;\n\tif (v15) goto L_0033;\n\tv18 = *([2DD441D]) == 0;\n\tif (v18) goto L_003D;\nL_0010:\n\tv45 = CollectParticleData[];\n\tv47 = *([v45 @ X8_v17 (Il2CppClass<CollectParticleData[]>)+970]);\n\tv48 = *([v47 @ X8_v19+B8]);\n\tv60 = *([v48 @ X8_v20]);\n\tv50 = *([v48 @ X8_v20]) == 0;\n\tif (v50) goto L_0049;\nL_0017:\n\tv67 = \"Cannot load image: download failed\";\n\tv69 = *([v60 @ X0_v16]);\n\t*([v69 @ X8_v15+168])(v72, v60, *([v69 @ X8_v15+170]), v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36);\n\tv76 = System.String::Concat(*([v67 @ X20_v8 (System.String)+E28]), v72);\n\tLogScroller::Log(this._logScroller, v76);\n\treturn;\nL_0033:\n\t*([v12 @ X20_v1+8E8]) = 1;\n\tv89 = *([2DD441D]) == 0;\n\tv40 = ~v89;\n\tif (v40) goto L_0010;\nL_003D:\n\t*([2DD441D]) = 1;\n\tv84 = CollectParticleData[];\n\tv86 = *([v84 @ X8_v8 (Il2CppClass<CollectParticleData[]>)+970]);\n\tv65 = *([v86 @ X8_v10+B8]);\n\tv60 = *([v65 @ X8_v11]);\n\tv87 = *([v65 @ X8_v11]) == 0;\n\tv63 = ~v87;\n\tif (v63) goto L_0017;\nL_0049:\n\tv93 = \"Cannot load image: download failed\";\n\tLogScroller::Log(this._logScroller, *([v93 @ X8_v4 (System.String)+E20]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 50 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnLogAcessTokenBtnClick()
	{
		global::Facebook.Unity.AccessToken accessToken = global::Facebook.Unity.AccessToken.CurrentAccessToken;
		if (accessToken != null)
		{
			_logScroller.Log("Access token: " + accessToken.TokenString);
		}
		else
		{
			_logScroller.Log("No access token");
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000082")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD7EEC", Offset = "0xFD7EEC", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv21 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv22 = v21 + 0xCE8;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0x108;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv56 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv57 = v56 + 0xB68;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8E9]) = v42;\nL_001D:\n\tv48 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = Il2CppMethodInfo;\n\tLogScroller::Log(this._logScroller, *([v48 @ X8_v3 (System.String)+B68]));\n\tv59 = new *([v50 @ X20_v2 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CE8])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v59, this, *([v52 @ X21_v1 (Il2CppMethodInfo)+108]), 0);\n\tFacebook.Unity.FBGamingServices::GetPayload(v59);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnLogPayloadBtnClick()
	{
		_logScroller.Log("Calling FBGamingServices.GetPayload");
		global::Facebook.Unity.FBGamingServices.GetPayload(_OnGetPayload);
	}

	private void _OnGetPayload(global::Facebook.Unity.IPayloadResult result)
	{
		if (result.Error != null)
		{
			_logScroller.Log("GetPayload error: " + result.Error);
			return;
		}
		_logScroller.Log("GetPayload success: " + result.RawResult);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000083")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD7F98", Offset = "0xFD7F98", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tMenu::NavToPage(this._menu, pageName);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 10 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnNavBtnClick(string pageName)
	{
		_menu.NavToPage(pageName);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000084")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD7DD8", Offset = "0xFD7DD8", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tLogScroller::Log(this._logScroller, text);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 10 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _LogText(string text)
	{
		_logScroller.Log(text);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000085")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD812C", Offset = "0xFD812C", Length = "0x12C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv20 = *([302A8EA]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0046;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv24 = *([v22 @ X0_v33+E0]) == 0;\n\tif (v24) goto L_004E;\nL_0015:\n\tv50 = Facebook.Unity.FB::get_IsInitialized();\n\tv66 = this._logScroller;\n\tv60 = ~v50;\n\tif (v60) goto L_0056;\nL_001C:\n\tv81 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tLogScroller::Log(v66, *([v81 @ X8_v11 (System.String)+238]));\n\tv100 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv103 = new *([v100 @ X8_v13 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CC0])();\n\tv107 = Il2CppMethodInfo;\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v103, this, *([v107 @ X8_v15 (Il2CppMethodInfo)+110]), 0);\n\tFacebook.Unity.FBGamingServices::InitCloudGame(v103);\n\treturn;\nL_0046:\n\t*([v16 @ X20_v1+8EA]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv105 = *([v44 @ X0_v24+E0]) == 0;\n\tv46 = ~v105;\n\tif (v46) goto L_0015;\nL_004E:\n\tv62 = Facebook.Unity.FB::get_IsInitialized();\n\tv66 = this._logScroller;\n\tv77 = ~v62;\n\tv69 = ~v77;\n\tif (v69) goto L_001C;\nL_0056:\n\tv88 = \"DarkSalmon\";\n\tLogScroller::Log(v73, *([v88 @ X8_v4 (System.String)+838]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 65 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _OnInitComplete()
	{
		if (global::Facebook.Unity.FB.IsInitialized)
		{
			_logScroller.Log("FB.Init complete, calling FBGamingServices.InitCloudGame");
			global::Facebook.Unity.FBGamingServices.InitCloudGame(_OnInitCloud);
		}
		else
		{
			_logScroller.Log("FB.Init failed");
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000086")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8258", Offset = "0xFD8258", Length = "0x208")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv23 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv24 = v23 + 0xDF8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, result, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = \"Hungarian\";\n\tv46 = v45 + 0x608;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, result, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv161 = \"DarkSalmon\";\n\tv162 = v161 + 0x8A0;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v162, result, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A8EB]) = v43;\nL_001D:\n\tv48 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv51 = result->klass;\n\tv203 = result->klass->rank;\n\tv53 = *([v51 @ X8_v4 (Il2CppClass<Facebook.Unity.IInitCloudGameResult>)+12E]) == 0;\n\tif (v53) goto L_0040;\n\tv202 = *([v51 @ X8_v4 (Il2CppClass<Facebook.Unity.IInitCloudGameResult>)+B0]) + 8;\nL_002B:\n\tv208 = *([v202 @ X10_v19-8]) == *([v48 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v208) goto L_004A;\n\tv202 = v202 + 0x10;\n\tv188 = v203 - 1;\n\tv168 = v203 != 1;\n\tif (v168) goto L_002B;\nL_0040:\n\tv191 = 0xF7087C(result, *([v48 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\t*([v191 @ X0_v28])(v216, result, *([v191 @ X0_v28+8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv217 = v216 == 0;\n\tv218 = ~v217;\n\tif (v218) goto L_0098;\n\tgoto L_0055;\nL_004A:\n\tv259 = *([v202 @ X10_v19]) << 4;\n\tv260 = v51 + v259;\n\tv261 = v260 + 0x138;\n\t*([v261 @ X0_v31])(v265, result, *([v261 @ X0_v31+8]), v67, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv266 = v265 == 0;\n\tv267 = ~v266;\n\tif (v267) goto L_0098;\nL_0055:\n\tv341 = result->klass;\n\tv396 = result->klass->rank;\n\tv343 = *([v341 @ X8_v13 (Il2CppClass<Facebook.Unity.IInitCloudGameResult>)+12E]) == 0;\n\tif (v343) goto L_0075;\n\tv303 = *([v341 @ X8_v13 (Il2CppClass<Facebook.Unity.IInitCloudGameResult>)+B0]) + 8;\nL_0060:\n\tv291 = *([v303 @ X10_v14-8]) == *([v48 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v291) goto L_008C;\n\tv303 = v303 + 0x10;\n\tv371 = v396 - 1;\n\tv361 = v396 != 1;\n\tif (v361) goto L_0060;\nL_0075:\n\tv373 = 0xF7087C(result, *([v48 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 1, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\t*([v373 @ X0_v21])(v313, result, *([v373 @ X0_v21+8]), 1, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv316 = v313 == 0;\n\tif (v316) goto L_0098;\nL_007F:\n\tv423 = \"Hungarian\";\n\tLogScroller::Log(this._logScroller, *([v423 @ X8_v15 (System.String)+608]));\n\treturn;\nL_008C:\n\tv306 = *([v303 @ X10_v14]) + 1;\n\tv271 = v306 << 4;\n\tv417 = v341 + v271;\n\tv418 = v417 + 0x138;\n\t*([v418 @ X0_v24])(v312, result, *([v418 @ X0_v24+8]), v67, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv420 = v312 == 0;\n\tv315 = ~v420;\n\tif (v315) goto L_007F;\nL_0098:\n\tv321 = result->klass;\n\tv383 = result->klass->rank;\n\tv323 = *([v321 @ X8_v6 (Il2CppClass<Facebook.Unity.IInitCloudGameResult>)+12E]) == 0;\n\tif (v323) goto L_00B8;\n\tv128 = *([v321 @ X8_v6 (Il2CppClass<Facebook.Unity.IInitCloudGameResult>)+B0]) + 8;\nL_00A3:\n\tv104 = *([v128 @ X10_v7-8]) == *([v48 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v104) goto L_00C2;\n\tv128 = v128 + 0x10;\n\tv356 = v383 - 1;\n\tv346 = v383 != 1;\n\tif (v346) goto L_00A3;\nL_00B8:\n\tv358 = 0xF7087C(result, *([v48 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\t*([v358 @ X0_v11])(v406, result, *([v358 @ X0_v11+8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv386 = v406 == 0;\n\tv149 = ~v386;\n\tif (v149) goto L_00CB;\n\tgoto L_00E2;\nL_00C2:\n\tv63 = *([v128 @ X10_v7]) << 4;\n\tv400 = v321 + v63;\n\tv401 = v400 + 0x138;\n\t*([v401 @ X0_v14])(v406, result, *([v401 @ X0_v14+8]), v403, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_00CB:\n\tv409 = \"DarkSalmon\";\n\tv156 = *([v406 @ X0_v5]);\n\t*([v156 @ X8_v8+168])(v411, v406, *([v156 @ X8_v8+170]), v403, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv414 = System.String::Concat(*([v409 @ X20_v3 (System.String)+8A0]), v411);\n\tLogScroller::Log(this._logScroller, v414);\n\treturn;\nL_00E2:\n\tthrow System.NullReferenceException;\n// 137 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _OnInitCloud(global::Facebook.Unity.IInitCloudGameResult result)
	{
		if (result.Error != null)
		{
			_logScroller.Log("InitCloudGame error: " + result.Error);
			return;
		}
		_logScroller.Log("InitCloudGame success: " + result.RawResult);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000087")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8460", Offset = "0xFD8460", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public MainPage()
	{
	}
}
