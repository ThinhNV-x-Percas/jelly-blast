[global::Cpp2ILInjected.Token(Token = "0x2000012")]
public class SavePage : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000065")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.UI.Button _saveLogBtn;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000066")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::UnityEngine.UI.InputField _customInputField;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000067")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private global::UnityEngine.UI.Button _appendDataBtn;

	[global::Cpp2ILInjected.Token(Token = "0x4000068")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private string LOGS_FOLDER_PATH;

	[global::Cpp2ILInjected.Token(Token = "0x4000069")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private string PLAYER_PREFS_PATH;

	[global::Cpp2ILInjected.Token(Token = "0x400006A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private string SAVE_FILE_PATH;

	[global::Cpp2ILInjected.Token(Token = "0x400006B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private LogScroller _logScroller;

	[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDB218", Offset = "0xFDB218", Length = "0x160")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0024;\n\tv27 = CollectParticleData[];\n\tv28 = v27 + 0xB30;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv59 = Il2CppMethodInfo;\n\tv60 = v59 + 0x778;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv66 = \", R=\";\n\tv67 = v66 + 0x788;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv73 = \", R=\";\n\tv74 = v73 + 0x748;\n\tv75 = \"il2cpp_codegen_initialize_runtime_metadata\"(v74, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv80 = \"x-cp50227\";\n\tv81 = v80 + 0x5F8;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302A901]) = v48;\nL_0024:\n\tv49 = \"x-cp50227\";\n\tv51 = \", R=\";\n\tv53 = \", R=\";\n\tgoto L_0031;\n\tv62 = \"il2cpp_codegen_runtime_class_init\"(v55, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0031:\n\tv65 = UnityEngine.Application::get_persistentDataPath();\n\tv72 = System.String::Format(*([v49 @ X23_v1 (System.String)+5F8]), v65);\n\tv78 = this + 0x38;\n\tthis.LOGS_FOLDER_PATH = v72;\n\tv79 = 0xF3F1B4(v78, v72, 0, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv83 = UnityEngine.Application::get_identifier();\n\tv87 = System.String::Format(*([v51 @ X21_v1 (System.String)+748]), v83);\n\tv90 = this + 0x40;\n\tthis.PLAYER_PREFS_PATH = v87;\n\tv91 = 0xF3F1B4(v90, v87, 0, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv93 = UnityEngine.Application::get_persistentDataPath();\n\tv96 = System.String::Concat(v93, *([v53 @ X20_v2 (System.String)+788]));\n\tv99 = this + 0x48;\n\tthis.SAVE_FILE_PATH = v96;\n\tv100 = 0xF3F1B4(v99, v96, 0, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv103 = UnityEngine.Component::get_transform(this);\n\tv106 = UnityEngine.Transform::get_root(v103);\n\tv117 = Il2CppMethodInfo;\n\tv110 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v106, *([v117 @ X8_v5 (Il2CppMethodInfo)+778]));\n\tv140 = this + 0x50;\n\tthis._logScroller = *([v110 @ X0_v29+20]);\n\tv129 = 0xF3F1B4(v140, *([v110 @ X0_v29+20]), 0, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 64 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		LOGS_FOLDER_PATH = string.Format("{0}/Logs", global::UnityEngine.Application.persistentDataPath);
		PLAYER_PREFS_PATH = string.Format("PlayerPrefs_{0}", global::UnityEngine.Application.identifier);
		SAVE_FILE_PATH = global::UnityEngine.Application.persistentDataPath + "/save.txt";
		_logScroller = base.transform.root.GetComponent<LogScroller>();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDB378", Offset = "0xFDB378", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = \"l1\";\n\tv20 = \"l1\";\n\tgoto L_001B;\n\tv25 = \"l1\";\n\tv26 = v25 + 0x8E8;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = \"l1\";\n\tv51 = v50 + 0x8F0;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A902]) = v46;\nL_001B:\n\tv47 = *([v18 @ X22_v1 (System.String)+8E8]);\n\tv49 = UnityEngine.PlayerPrefs::GetInt(*([v18 @ X22_v1 (System.String)+8E8]));\n\tv47 = System.Int32::ToString(&v49 @ X0_v3 (System.Int32));\n\tv47 = *([v20 @ X20_v1 (System.String)+8F0]);\n\tv47 = System.String::Concat(v47, v47);\n\tLogScroller::Log(this._logScroller, v47);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnLogPlayerPrefsBtnClick()
	{
		int value = global::UnityEngine.PlayerPrefs.GetInt(PLAYER_PREFS_PATH);
		_logScroller.Log(PLAYER_PREFS_PATH + ": " + value);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDB424", Offset = "0xFDB424", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = \"Parent table name is missing in relation '{0}'.\";\n\tgoto L_001A;\n\tv23 = \"Parent table name is missing in relation '{0}'.\";\n\tv24 = v23 + 0x1E0;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A903]) = v43;\nL_001A:\n\tv48 = System.String::Concat(*([v18 @ X21_v1 (System.String)+1E0]), this.PLAYER_PREFS_PATH);\n\tLogScroller::Log(this._logScroller, v48);\n\tUnityEngine.PlayerPrefs::Save();\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnSavePlayerPrefsBtnClick()
	{
		_logScroller.Log("Saving PlayerPrefs: " + PLAYER_PREFS_PATH);
		global::UnityEngine.PlayerPrefs.Save();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDB49C", Offset = "0xFDB49C", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv17 = \"<'width'>\";\n\tv18 = v17 + 0xC20;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A904]) = v37;\nL_0015:\n\tSystem.IO.Directory::Delete(this.LOGS_FOLDER_PATH, 1);\n\tv43 = \"<'width'>\";\n\tLogScroller::Log(this._logScroller, *([v43 @ X8_v3 (System.String)+C20]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 25 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnDeleteLogFilesBtnClick()
	{
		global::System.IO.Directory.Delete(LOGS_FOLDER_PATH, recursive: true);
		_logScroller.Log("Deleted log files");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDB500", Offset = "0xFDB500", Length = "0x250")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0023;\n\tv25 = System.ComponentModel.BooleanConverter;\n\tv26 = v25 + 0xB60;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv50 = v49 + 0x1B8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv58 = \"x-cp50227\";\n\tv59 = v58 + 0x618;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv66 = \"Parent table name is missing in relation '{0}'.\";\n\tv67 = v66 + 0xF88;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv77 = \"IsCyrillic\";\n\tv78 = v77 + 0xA88;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v78, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A905]) = v46;\nL_0023:\n\tv48 = this._logScroller == 0;\n\tif (v48) goto L_00AA;\n\tv52 = \"Parent table name is missing in relation '{0}'.\";\n\tLogScroller::Log(this._logScroller, *([v52 @ X8_v5 (System.String)+F88]));\n\tv63 = System.IO.Directory::Exists(this.LOGS_FOLDER_PATH);\n\tv70 = v63 == 0;\n\tv71 = ~v70;\n\tif (v71) goto L_0035;\n\tv81 = System.IO.Directory::CreateDirectory(this.LOGS_FOLDER_PATH);\nL_0035:\n\tv84 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv86 = \"x-cp50227\";\n\tgoto L_0041;\n\tv127 = \"il2cpp_codegen_runtime_class_init\"(v89, v82, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_0041:\n\tv130 = System.DateTimeOffset::get_Now();\n\tv135 = System.DateTimeOffset::ToUnixTimeSeconds(&v130 @ X0_v18 (System.DateTimeOffset));\n\tthis = *([v84 @ X22_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+1B8]);\n\tv139 = \"il2cpp_vm_object_box\"(*([v84 @ X22_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+1B8]), &v135 @ X0_v20 (System.Int64), v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv141 = System.String::Format(*([v86 @ X21_v2 (System.String)+618]), this.LOGS_FOLDER_PATH, v139);\n\tv121 = this._logScroller;\n\tv118 = this._logScroller == 0;\n\tif (v118) goto L_006D;\n\tSystem.IO.File::AppendAllLines(v141, v121.texts);\n\tv170 = \"IsCyrillic\";\n\tv173 = System.String::Concat(*([v170 @ X8_v9 (System.String)+A88]), v141);\n\tv119 = this._logScroller == 0;\n\tif (v119) goto L_006F;\n\tLogScroller::Log(this._logScroller, v173);\n\treturn;\nL_006D:\n\tv114 = new System.NullReferenceException();\n\tgoto L_00B3;\nL_006F:\n\tv114 = new System.NullReferenceException();\n\tgoto L_00B3;\n\tgoto L_0073;\n\tgoto L_0073;\nL_0073:\n\tX20 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_00B6;\n\tX0 = X20;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x108;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\tX1 = *([X8]);\n\tX0 = 0xF3F978(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_00AB;\n\tX20 = *([X20]);\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_00AA;\n\tX19 = *([X19+50]);\n\tX8 = *([X20]);\n\tX9 = *([X8+188]);\n\tX1 = *([X8+190]);\n\tX0 = X20;\n\tX9(X0, X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x880;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX1 = X20;\n\tX2 = 0;\n\tX0 = System.String::Concat(X0, X1, X2);\n\tif (TEMP) goto L_00AA;\n\tX1 = X0;\n\tX0 = X19;\n\tLogScroller::Log(X0, X1, X2);\n\tX29 = stack[50];\n\tX30 = stack[58];\n\tX20 = stack[40];\n\tX19 = stack[48];\n\tX22 = stack[30];\n\tX21 = stack[38];\n\tX24 = stack[20];\n\tX23 = stack[28];\n\t// 168 ShiftStack 96\n\treturn;\nL_00AA:\n\tthrow System.NullReferenceException;\nL_00AB:\n\t;\n\tv72 = *([v20 @ X20_v1]);\n\t*([v65 @ X0_v10]) = v72;\n\tv74 = 0x2C72000 + 0x398;\n\tv76 = 0x274A0EC(v65, v74, 0, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_00B3:\n\t// 179 Interrupt\n\tthis = 0x274A098(v114, v110, v95, v93, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_00B6:\n\t;\n\tthis = 0x27498DC(v114, v110, v95, v93, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tthis = 0xD6F8(this, v110, v95, v93, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnSaveLogsBtnClick()
	{
		if (_logScroller == null)
		{
			throw new global::System.NullReferenceException();
		}
		_logScroller.Log("Saving logs...");
		if (!global::System.IO.Directory.Exists(LOGS_FOLDER_PATH))
		{
			global::System.IO.Directory.CreateDirectory(LOGS_FOLDER_PATH);
		}
		long timestamp = global::System.DateTimeOffset.Now.ToUnixTimeSeconds();
		string path = string.Format("{0}/log_{1}.txt", LOGS_FOLDER_PATH, timestamp);
		global::System.IO.File.AppendAllLines(path, _logScroller.texts);
		_logScroller.Log("Saved logs to " + path);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDB750", Offset = "0xFDB750", Length = "0x1D8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001C;\n\tv17 = Il2CppFieldInfo;\n\tv18 = v17 + 0xAB0;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv41 = \"<'width'>\";\n\tv42 = v41 + 0xEE0;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv48 = \"<'width'>\";\n\tv49 = v48 + 0xED8;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v49, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv55 = Il2CppFieldInfo;\n\tv56 = v55 + 0x960;\n\tv36 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv38 = 1;\n\t*([302A906]) = v38;\nL_001C:\n\tv40 = this._logScroller == 0;\n\tif (v40) goto L_0086;\n\tv44 = \"<'width'>\";\n\tv77 = *([v44 @ X8_v5 (System.String)+EE0]);\n\tLogScroller::Log(this._logScroller, *([v44 @ X8_v5 (System.String)+EE0]));\n\tv51 = this._customInputField;\n\tv52 = this._customInputField == 0;\n\tif (v52) goto L_004A;\n\tv57 = Il2CppFieldInfo;\n\tv63 = System.String::Concat(v51.m_Text, *([v57 @ X9_v2 (Il2CppFieldInfo)+AB0]));\n\tSystem.IO.File::AppendAllText(this.SAVE_FILE_PATH, v63);\n\tv83 = this._customInputField == 0;\n\tif (v83) goto L_004C;\n\tv94 = Il2CppFieldInfo;\n\tUnityEngine.UI.InputField::set_text(this._customInputField, *([v94 @ X8_v8 (Il2CppFieldInfo)+960]));\n\tv99 = \"<'width'>\";\n\tv102 = System.String::Concat(*([v99 @ X8_v10 (System.String)+ED8]), this.SAVE_FILE_PATH);\n\tv84 = this._logScroller == 0;\n\tif (v84) goto L_004E;\n\tLogScroller::Log(this._logScroller, v102);\n\treturn;\nL_004A:\n\tv79 = new System.NullReferenceException();\n\tgoto L_008F;\nL_004C:\n\tv79 = new System.NullReferenceException();\n\tgoto L_008F;\nL_004E:\n\tv79 = new System.NullReferenceException();\n\tgoto L_008F;\n\tgoto L_0053;\n\tgoto L_0053;\n\tgoto L_0053;\nL_0053:\n\tX20 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0092;\n\tX0 = X20;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x108;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\tX1 = *([X8]);\n\tX0 = 0xF3F978(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_0087;\n\tX20 = *([X20]);\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_0086;\n\tX19 = *([X19+50]);\n\tX8 = *([X20]);\n\tX9 = *([X8+188]);\n\tX1 = *([X8+190]);\n\tX0 = X20;\n\tX9(X0, X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x840;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX1 = X20;\n\tX2 = 0;\n\tX0 = System.String::Concat(X0, X1, X2);\n\tif (TEMP) goto L_0086;\n\tX1 = X0;\n\tX0 = X19;\n\tX29 = stack[10];\n\tX30 = stack[18];\n\tX20 = stack[0];\n\tX19 = stack[8];\n\t// 131 ShiftStack 32\n\tLogScroller::Log(X0, X1, X2);\n\treturn;\nL_0086:\n\tthrow System.NullReferenceException;\nL_0087:\n\t;\n\tv65 = *([v12 @ X20_v1]);\n\t*([v54 @ X0_v10]) = v65;\n\tv67 = 0x2C72000 + 0x398;\n\tv69 = 0x274A0EC(v54, v67, 0, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\nL_008F:\n\t// 143 Interrupt\n\tv90 = 0x274A098(v79, v77, v73, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\nL_0092:\n\t;\n\tv93 = 0x27498DC(v79, v77, v73, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv98 = 0xD6F8(v93, v77, v73, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\treturn;\n// 48 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnAppendSaveFileBtnClick()
	{
		if (_logScroller == null)
		{
			throw new global::System.NullReferenceException();
		}
		_logScroller.Log("Appending custom data to save file");
		if (_customInputField == null)
		{
			return;
		}
		global::System.IO.File.AppendAllText(SAVE_FILE_PATH, _customInputField.text);
		_customInputField.text = string.Empty;
		_logScroller.Log("Appended to " + SAVE_FILE_PATH);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDB928", Offset = "0xFDB928", Length = "0x60")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0014;\n\tv17 = \"Parent table name is missing in relation '{0}'.\";\n\tv18 = v17 + 0xF60;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A907]) = v37;\nL_0014:\n\tSystem.IO.File::Delete(this.SAVE_FILE_PATH);\n\tv42 = \"Parent table name is missing in relation '{0}'.\";\n\tLogScroller::Log(this._logScroller, *([v42 @ X8_v3 (System.String)+F60]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 24 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnDeleteSaveFileBtnClick()
	{
		global::System.IO.File.Delete(SAVE_FILE_PATH);
		_logScroller.Log("Deleted save file");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDB988", Offset = "0xFDB988", Length = "0x1F4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv21 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv22 = v21 + 0x1A8;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = Il2CppFieldInfo;\n\tv46 = v45 + 0xAB0;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv52 = \"Parent table name is missing in relation '{0}'.\";\n\tv53 = v52 + 0xF68;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv60 = \"IsCyrillic\";\n\tv61 = v60 + 0x9C8;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v61, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A908]) = v42;\nL_001E:\n\tv44 = this._logScroller == 0;\n\tif (v44) goto L_008A;\n\tv48 = \"IsCyrillic\";\n\tLogScroller::Log(this._logScroller, *([v48 @ X8_v5 (System.String)+9C8]));\n\tv57 = System.IO.File::ReadAllLines(this.SAVE_FILE_PATH);\n\tv63 = v57 == 0;\n\tif (v63) goto L_004D;\n\tv69 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv72 = v57.Length;\n\tv76 = \"il2cpp_vm_object_box\"(*([v69 @ X8_v7 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+1A8]), &v72 @ X9_v2, v80, v78, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv100 = Il2CppFieldInfo;\n\tv105 = System.String::Join(*([v100 @ X8_v9 (Il2CppFieldInfo)+AB0]), v57);\n\tv108 = \"Parent table name is missing in relation '{0}'.\";\n\tv111 = System.String::Format(*([v108 @ X8_v11 (System.String)+F68]), v76, v105);\n\tv94 = this._logScroller == 0;\n\tif (v94) goto L_004F;\n\tLogScroller::Log(this._logScroller, v111);\n\treturn;\nL_004D:\n\tv91 = new System.NullReferenceException();\n\tgoto L_0093;\nL_004F:\n\tv91 = new System.NullReferenceException();\n\tgoto L_0093;\n\tgoto L_0055;\n\tgoto L_0055;\n\tgoto L_0055;\n\tgoto L_0055;\nL_0055:\n\tX20 = X0;\n\tC = X1 < 1;\n\tC = ~C;\n\tTEMP1 = X1 - 1;\n\tN = TEMP1 < 0;\n\tTEMP2 = X1 ^ 1;\n\tTEMP3 = X1 ^ TEMP1;\n\tTEMP4 = TEMP2 & TEMP3;\n\tV = TEMP4 < 0;\n\tTEMPCOND = ~Z;\n\tif (TEMPCOND) goto L_0096;\n\tX0 = X20;\n\tX0 = 0x274A080(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x108;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX8 = *([X20]);\n\tX1 = *([X8]);\n\tX0 = 0xF3F978(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_008B;\n\tX20 = *([X20]);\n\tX0 = 0x274A098(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tif (TEMP) goto L_008A;\n\tX19 = *([X19+50]);\n\tX8 = *([X20]);\n\tX9 = *([X8+188]);\n\tX1 = *([X8+190]);\n\tX0 = X20;\n\tX9(X0, X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX20 = X0;\n\tX0 = X0 + 0x870;\n\tX0 = 0xF3F22C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX1 = X20;\n\tX2 = 0;\n\tX0 = System.String::Concat(X0, X1, X2);\n\tif (TEMP) goto L_008A;\n\tX1 = X0;\n\tX0 = X19;\n\tLogScroller::Log(X0, X1, X2);\n\tX29 = stack[30];\n\tX30 = stack[38];\n\tX20 = stack[20];\n\tX19 = stack[28];\n\tX22 = stack[10];\n\tX21 = stack[18];\n\t// 136 ShiftStack 64\n\treturn;\nL_008A:\n\tthrow System.NullReferenceException;\nL_008B:\n\t;\n\tv64 = *([v16 @ X20_v1]);\n\t*([v59 @ X0_v10]) = v64;\n\tv66 = 0x2C72000 + 0x398;\n\tv68 = 0x274A0EC(v59, v66, 0, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0093:\n\t// 147 Interrupt\n\tv99 = 0x274A098(v91, v89, v105, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0096:\n\t;\n\tv107 = 0x27498DC(v91, v89, v105, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv112 = 0xD6F8(v107, v89, v105, 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\treturn;\n// 54 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnLogSaveFileBtnClick()
	{
		if (_logScroller == null)
		{
			throw new global::System.NullReferenceException();
		}
		_logScroller.Log("Reading save file");
		string[] array = global::System.IO.File.ReadAllLines(SAVE_FILE_PATH);
		if (array != null)
		{
			string joined = string.Join("\n", array);
			_logScroller.Log(string.Format("{0} lines: {1}", array.Length, joined));
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDBB7C", Offset = "0xFDBB7C", Length = "0x6C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = \"Parent table name is missing in relation '{0}'.\";\n\tgoto L_001A;\n\tv23 = \"Parent table name is missing in relation '{0}'.\";\n\tv24 = v23 + 0xF70;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A909]) = v43;\nL_001A:\n\tv48 = System.String::Concat(*([v18 @ X21_v1 (System.String)+F70]), this.SAVE_FILE_PATH);\n\tLogScroller::Log(this._logScroller, v48);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnLogSaveFilePathBtnClick()
	{
		_logScroller.Log("Save file path: " + SAVE_FILE_PATH);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDBBE8", Offset = "0xFDBBE8", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SavePage()
	{
	}
}
