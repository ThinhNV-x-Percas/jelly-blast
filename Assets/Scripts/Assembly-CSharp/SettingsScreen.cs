[global::Cpp2ILInjected.Token(Token = "0x20000F6")]
public class SettingsScreen : Viewport
{
	[global::Cpp2ILInjected.Token(Token = "0x4000509")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public UIButton backButton;

	[global::Cpp2ILInjected.Token(Token = "0x400050A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public UIButton hapticButton;

	[global::Cpp2ILInjected.Token(Token = "0x400050B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private UIButtonStyler hapticButtonStyler;

	[global::Cpp2ILInjected.Token(Token = "0x400050C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public UIButton soundsButton;

	[global::Cpp2ILInjected.Token(Token = "0x400050D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	private UIButtonStyler soundsButtonStyler;

	[global::Cpp2ILInjected.Token(Token = "0x400050E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public UIButton resetButton;

	[global::Cpp2ILInjected.Token(Token = "0x400050F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public UIButtonStyle onButtonStyle;

	[global::Cpp2ILInjected.Token(Token = "0x4000510")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public UIButtonStyle offButtonStyle;

	[global::Cpp2ILInjected.Token(Token = "0x6000475")]
	[global::Cpp2ILInjected.Address(RVA = "0x1020A28", Offset = "0x1020A28", Length = "0x2C8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0039;\n\tv29 = CollectParticleData[];\n\tv30 = v29 + 0x990;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0xB20;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv114 = Il2CppMethodInfo;\n\tv115 = v114 + 0xB28;\n\tv116 = \"il2cpp_codegen_initialize_runtime_metadata\"(v115, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv120 = Il2CppMethodInfo;\n\tv121 = v120 + 0x770;\n\tv122 = \"il2cpp_codegen_initialize_runtime_metadata\"(v121, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv153 = Il2CppMethodInfo;\n\tv154 = v153 + 0x6C8;\n\tv155 = \"il2cpp_codegen_initialize_runtime_metadata\"(v154, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv158 = Il2CppMethodInfo;\n\tv159 = v158 + 0x6D0;\n\tv160 = \"il2cpp_codegen_initialize_runtime_metadata\"(v159, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv164 = Il2CppMethodInfo;\n\tv165 = v164 + 0x6D8;\n\tv166 = \"il2cpp_codegen_initialize_runtime_metadata\"(v165, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv167 = Il2CppMethodInfo;\n\tv168 = v167 + 0x6E0;\n\tv169 = \"il2cpp_codegen_initialize_runtime_metadata\"(v168, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv173 = Il2CppMethodInfo;\n\tv174 = v173 + 0xC60;\n\tv175 = \"il2cpp_codegen_initialize_runtime_metadata\"(v174, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv179 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv180 = v179 + 0xA30;\n\tv181 = \"il2cpp_codegen_initialize_runtime_metadata\"(v180, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv185 = System.Net.Configuration.SettingsSectionInternal;\n\tv186 = v185 + 0xE60;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v186, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AAF4]) = v50;\nL_0039:\n\tv56 = Il2CppMethodInfo;\n\tv59 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this.hapticButton, *([v56 @ X21_v2 (Il2CppMethodInfo)+770]));\n\tv108 = this + 0x68;\n\tthis.hapticButtonStyler = v59;\n\tv119 = 0xF3F1B4(v108, v59, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv157 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this.soundsButton, *([v56 @ X21_v2 (Il2CppMethodInfo)+770]));\n\tv109 = this + 0x78;\n\tthis.soundsButtonStyler = v157;\n\tv163 = 0xF3F1B4(v109, v157, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv171 = Il2CppMethodInfo;\n\tv172 = UnityEngine.Component::get_gameObject(this.resetButton);\n\tgoto L_005F;\n\tv182 = \"il2cpp_codegen_runtime_class_init\"(v176, v77, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_005F:\n\tv89 = Singleton`1::get_Instance /* +1 sharing this address */(*([v171 @ X21_v4 (Il2CppMethodInfo)+C60]));\n\tUnityEngine.GameObject::SetActive(v172, *([v89 @ X0_v17+28]));\n\tv105 = this.resetButton;\n\tv187 = System.Net.Configuration.SettingsSectionInternal;\n\tv188 = Il2CppMethodInfo;\n\tv91 = new *([v187 @ X22_v4 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+E60])();\n\tUnityEngine.Events.UnityAction::.ctor(v91, this, *([v188 @ X23_v2 (Il2CppMethodInfo)+6C8]));\n\tUnityEngine.Events.UnityEvent::AddListener(v105.m_OnClick, v91);\n\tv106 = this.backButton;\n\tv190 = Il2CppMethodInfo;\n\tv93 = new *([v187 @ X22_v4 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+E60])();\n\tUnityEngine.Events.UnityAction::.ctor(v93, this, *([v190 @ X23_v4 (Il2CppMethodInfo)+6D0]));\n\tv192 = CollectParticleData[];\n\tv194 = Il2CppMethodInfo;\n\tv196 = Il2CppMethodInfo;\n\tv198 = Il2CppMethodInfo;\n\tv200 = Il2CppMethodInfo;\n\tUnityEngine.Events.UnityEvent::AddListener(v106.m_OnClick, v93);\n\tv207 = new *([v192 @ X24_v1 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v207, 0, *([v194 @ X22_v6 (Il2CppMethodInfo)+B20]));\n\tv213 = new *([v192 @ X24_v1 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v213, this, *([v196 @ X25_v1 (Il2CppMethodInfo)+6D8]));\n\tSettingsScreen::AddButtonListener(v213, this.hapticButton, v207, v213);\n\tv223 = new *([v192 @ X24_v1 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v223, 0, *([v198 @ X26_v1 (Il2CppMethodInfo)+B28]));\n\tv229 = new *([v192 @ X24_v1 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v229, this, *([v200 @ X23_v6 (Il2CppMethodInfo)+6E0]));\n\tSettingsScreen::AddButtonListener(v229, this.soundsButton, v223, v229);\n\tSettingsScreen::UpdateAllVisuals(this);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 127 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		//IL_0021: Expected O, but got I
		//IL_0050: Expected O, but got I
		//IL_00c4: Expected I, but got O
		//IL_0137: Expected I, but got O
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		UIButtonStyler uIButtonStyler = default(UIButtonStyler);
		hapticButtonStyler = uIButtonStyler;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		UIButtonStyler uIButtonStyler2 = default(UIButtonStyler);
		soundsButtonStyler = uIButtonStyler2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		nint num2 = 0;
		global::UnityEngine.GameObject gameObject = resetButton.gameObject;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v89 @ X0_v17+28]");
		gameObject.SetActive(value: false);
		UIButton uIButton = resetButton;
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X23_v2 (Il2CppMethodInfo)+6C8]");
		global::UnityEngine.Events.UnityAction call = new global::UnityEngine.Events.UnityAction(this, (global::System.IntPtr)0);
		uIButton.m_OnClick.AddListener(call);
		UIButton uIButton2 = backButton;
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v190 @ X23_v4 (Il2CppMethodInfo)+6D0]");
		global::UnityEngine.Events.UnityAction call2 = new global::UnityEngine.Events.UnityAction(this, (global::System.IntPtr)0);
		nint num6 = (nint)typeof(CollectParticleData[]);
		nint num7 = 0;
		nint num8 = 0;
		nint num9 = 0;
		nint num10 = 0;
		uIButton2.m_OnClick.AddListener(call2);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v194 @ X22_v6 (Il2CppMethodInfo)+B20]");
		global::System.Action toggleAction = new global::System.Action(null, (global::System.IntPtr)0);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v196 @ X25_v1 (Il2CppMethodInfo)+6D8]");
		global::System.Action action = new global::System.Action(this, (global::System.IntPtr)0);
		((SettingsScreen)(object)action).AddButtonListener(hapticButton, toggleAction, action);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v198 @ X26_v1 (Il2CppMethodInfo)+B28]");
		global::System.Action toggleAction2 = new global::System.Action(null, (global::System.IntPtr)0);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X23_v6 (Il2CppMethodInfo)+6E0]");
		global::System.Action action2 = new global::System.Action(this, (global::System.IntPtr)0);
		((SettingsScreen)(object)action2).AddButtonListener(soundsButton, toggleAction2, action2);
		UpdateAllVisuals();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000476")]
	[global::Cpp2ILInjected.Address(RVA = "0x1020CF0", Offset = "0x1020CF0", Length = "0xF4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0021;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x8B0;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, button, toggleAction, updateVisualAction, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv53 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv54 = v53 + 0xCD0;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, button, toggleAction, updateVisualAction, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv58 = System.Net.Configuration.SettingsSectionInternal;\n\tv59 = v58 + 0xE60;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, button, toggleAction, updateVisualAction, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv50 = 1;\n\t*([302AAF5]) = v50;\nL_0021:\n\tv52 = new *([v26 @ X23_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+CD0])();\n\tSystem.Object::.ctor(v52);\n\tv62 = v52 + 0x10;\n\t*([v52 @ X0_v3 (System.Object)+10]) = toggleAction;\n\tv64 = 0xF3F1B4(v62, toggleAction, toggleAction, updateVisualAction, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv88 = v52 + 0x18;\n\t*([v52 @ X0_v3 (System.Object)+18]) = updateVisualAction;\n\tv73 = 0xF3F1B4(v88, updateVisualAction, toggleAction, updateVisualAction, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv114 = System.Net.Configuration.SettingsSectionInternal;\n\tv115 = Il2CppMethodInfo;\n\tv74 = new *([v114 @ X8_v4 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+E60])();\n\tUnityEngine.Events.UnityAction::.ctor(v74, v52, *([v115 @ X21_v3 (Il2CppMethodInfo)+8B0]));\n\tUnityEngine.Events.UnityEvent::AddListener(button.m_OnClick, v74);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 52 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void AddButtonListener(UIButton button, global::System.Action toggleAction, global::System.Action updateVisualAction)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_0040: Expected O, but got I
		//IL_0062: Expected I, but got O
		object obj = new object();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X21_v3 (Il2CppMethodInfo)+8B0]");
		global::UnityEngine.Events.UnityAction call = new global::UnityEngine.Events.UnityAction(obj, (global::System.IntPtr)0);
		button.m_OnClick.AddListener(call);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000477")]
	[global::Cpp2ILInjected.Address(RVA = "0x1020DE4", Offset = "0x1020DE4", Length = "0xC4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0014;\n\tv17 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv18 = v17 + 0xE48;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302AB3B]) = v37;\nL_0014:\n\tv40 = ApplicationManager::get_appData();\n\tv42 = v40.playerData;\n\tv64 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tSettingsScreen::UpdateButtonVisual(this, this.hapticButton, *([v64 @ X9_v2 (System.String)+E48]), v42.hapticOn);\n\tgoto L_002E;\n\tv91 = \"Scrollbar Horizontal\";\n\tv92 = v91 + 0x4C8;\n\tv93 = \"il2cpp_codegen_initialize_runtime_metadata\"(v92, v45, v47, v49, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv95 = 1;\n\t*([302AB3C]) = v95;\nL_002E:\n\tv54 = ApplicationManager::get_appData();\n\tv60 = v54.playerData;\n\tv97 = \"Scrollbar Horizontal\";\n\tSettingsScreen::UpdateButtonVisual(this, this.soundsButton, *([v97 @ X9_v4 (System.String)+4C8]), v60.soundsOn);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 44 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void UpdateAllVisuals()
	{
		//IL_0041: Expected O, but got I
		//IL_0082: Expected O, but got I
		ApplicationData appData = ApplicationManager.appData;
		PlayerData playerData = appData.playerData;
		string text = "Expected ComplexType. Schema was not generated using this tool.";
		UIButton button = hapticButton;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X9_v2 (System.String)+E48]");
		UpdateButtonVisual(button, (string)0, playerData.hapticOn);
		ApplicationData appData2 = ApplicationManager.appData;
		PlayerData playerData2 = appData2.playerData;
		string text2 = "Scrollbar Horizontal";
		UIButton button2 = soundsButton;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X9_v4 (System.String)+4C8]");
		UpdateButtonVisual(button2, (string)0, playerData2.soundsOn);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000478")]
	[global::Cpp2ILInjected.Address(RVA = "0x1020EB0", Offset = "0x1020EB0", Length = "0x70")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0014;\n\tv17 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv18 = v17 + 0xE48;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302AB3B]) = v37;\nL_0014:\n\tv40 = ApplicationManager::get_appData();\n\tv42 = v40.playerData;\n\tv47 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tSettingsScreen::UpdateButtonVisual(this, this.hapticButton, *([v47 @ X9_v1 (System.String)+E48]), v42.hapticOn);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void UpdateHapticVisual()
	{
		//IL_0041: Expected O, but got I
		ApplicationData appData = ApplicationManager.appData;
		PlayerData playerData = appData.playerData;
		string text = "Expected ComplexType. Schema was not generated using this tool.";
		UIButton button = hapticButton;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v1 (System.String)+E48]");
		UpdateButtonVisual(button, (string)0, playerData.hapticOn);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000479")]
	[global::Cpp2ILInjected.Address(RVA = "0x1020F20", Offset = "0x1020F20", Length = "0x70")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0014;\n\tv17 = \"Scrollbar Horizontal\";\n\tv18 = v17 + 0x4C8;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302AB3C]) = v37;\nL_0014:\n\tv40 = ApplicationManager::get_appData();\n\tv42 = v40.playerData;\n\tv47 = \"Scrollbar Horizontal\";\n\tSettingsScreen::UpdateButtonVisual(this, this.soundsButton, *([v47 @ X9_v1 (System.String)+4C8]), v42.soundsOn);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void UpdateSoundsVisual()
	{
		//IL_0041: Expected O, but got I
		ApplicationData appData = ApplicationManager.appData;
		PlayerData playerData = appData.playerData;
		string text = "Scrollbar Horizontal";
		UIButton button = soundsButton;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v1 (System.String)+4C8]");
		UpdateButtonVisual(button, (string)0, playerData.soundsOn);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600047A")]
	[global::Cpp2ILInjected.Address(RVA = "0x1020F90", Offset = "0x1020F90", Length = "0x1C8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0026;\n\tv35 = Il2CppMethodInfo;\n\tv36 = v35 + 0x798;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, button, label, isOn, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv55 = \", R=\";\n\tv56 = v55 + 0xEF8;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, button, label, isOn, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv162 = \"Min\";\n\tv163 = v162 + 0x9C0;\n\tv164 = \"il2cpp_codegen_initialize_runtime_metadata\"(v163, button, label, isOn, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv166 = \"Min\";\n\tv167 = v166 + 0x998;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v167, button, label, isOn, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv53 = 1;\n\t*([302AAF6]) = v53;\nL_0026:\n\tv58 = Il2CppMethodInfo;\n\tv60 = \", R=\";\n\tv63 = \"Min\" + 0x9C0;\n\tv65 = \"Min\" + 0x998;\n\tv68 = UnityEngine.Component::GetComponentInChildren /* +1 sharing this address */(button, *([v58 @ X8_v4 (Il2CppMethodInfo)+798]));\n\tv103 = isOn == 0;\n\tv84 = ~v103;\n\tv80 = ~v84;\n\tif (v80) goto L_FFFFFFFF;\n\tgoto L_0046;\nL_0046:\n\tv129 = System.String::Concat(label, *([v60 @ X23_v3 (System.String)+EF8]), *([v149 @ X8_v6]));\n\tv150 = *([v68 @ X0_v5]);\n\t*([v150 @ X8_v7+558])(v235, v68, v129, *([v150 @ X8_v7+560]), 0, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv131 = UnityEngine.Component::get_gameObject(this.hapticButton);\n\tv236 = UnityEngine.GameObject::get_activeInHierarchy(v131);\n\tv237 = ~v236;\n\tif (v237) goto L_007E;\n\tv132 = ApplicationManager::get_appData();\n\tv151 = v132.playerData;\n\tif (v151.hapticOn) goto L_FFFFFFFF;\n\tgoto L_0079;\nL_0079:\n\tUIButtonStyler::SetStyle(this.hapticButtonStyler, *([this @ X0 (SettingsScreen)+v254 @ X8_v18 (System.Int32)]));\nL_007E:\n\tv134 = UnityEngine.Component::get_gameObject(this.soundsButton);\n\tv210 = UnityEngine.GameObject::get_activeInHierarchy(v134);\n\tv212 = ~v210;\n\tif (v212) goto L_00BC;\n\tv135 = ApplicationManager::get_appData();\n\tv153 = v135.playerData;\n\tif (v153.soundsOn) goto L_FFFFFFFF;\n\tgoto L_00AF;\nL_00AF:\n\tUIButtonStyler::SetStyle(this.soundsButtonStyler, *([this @ X0 (SettingsScreen)+v214 @ X8_v12 (System.Int32)]));\n\treturn;\nL_00BC:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 141 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void UpdateButtonVisual(UIButton button, string label, bool isOn)
	{
		//IL_001e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0023: Expected O, but got Unknown
		//IL_002d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0032: Expected O, but got Unknown
		//IL_01cc: Expected O, but got I
		//IL_01ec: Expected O, but got I
		//IL_0208: Expected O, but got I
		nint num = 0;
		string text = ", R=";
		object obj = "Min" + 2496;
		object obj2 = "Min" + 2456;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C900 (UnityEngine.Component::GetComponentInChildren, and 1 more at this address)");
		object obj3 = ((!isOn) ? obj2 : obj);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X23_v3 (System.String)+EF8]");
		string text2 = label + (string)0 + (string)obj3;
		object obj5 = default(object);
		object obj4 = obj5;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v150 @ X8_v7+558] (should have been resolved before IL gen)");
		global::UnityEngine.GameObject gameObject = hapticButton.gameObject;
		if (gameObject.activeInHierarchy)
		{
			ApplicationData appData = ApplicationManager.appData;
			PlayerData playerData = appData.playerData;
			if (!playerData.hapticOn)
			{
				int num2 = 144;
			}
			else
			{
				int num2 = 136;
			}
			UIButtonStyler uIButtonStyler = hapticButtonStyler;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SettingsScreen)+v254 @ X8_v18 (System.Int32)]");
			uIButtonStyler.SetStyle((UIButtonStyle)0);
		}
		global::UnityEngine.GameObject gameObject2 = soundsButton.gameObject;
		if (gameObject2.activeInHierarchy)
		{
			ApplicationData appData2 = ApplicationManager.appData;
			PlayerData playerData2 = appData2.playerData;
			if (!playerData2.soundsOn)
			{
				int num3 = 144;
			}
			else
			{
				int num3 = 136;
			}
			UIButtonStyler uIButtonStyler2 = soundsButtonStyler;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (SettingsScreen)+v214 @ X8_v12 (System.Int32)]");
			uIButtonStyler2.SetStyle((UIButtonStyle)0);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600047B")]
	[global::Cpp2ILInjected.Address(RVA = "0x1021158", Offset = "0x1021158", Length = "0x110")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = 0x302A000;\n\tv12 = System.Xml.ValidateNames;\n\tv14 = *([302AAF7]) & 1;\n\tv15 = v14 == 0;\n\tif (v15) goto L_0026;\n\tv45 = Il2CppMethodInfo + 0xCD8;\n\tv18 = *([v12 @ X19_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv20 = *([v18 @ X0_v31+E0]) == 0;\n\tif (v20) goto L_0030;\nL_0014:\n\tv64 = Viewport::GetViewport /* +1 sharing this address */(*([v45 @ X20_v10]));\n\tv57 = v64 == 0;\n\tv58 = ~v57;\n\tif (v58) goto L_0038;\n\tgoto L_0056;\nL_0026:\n\t*([v10 @ X20_v1+AF7]) = 1;\n\tv45 = Il2CppMethodInfo + 0xCD8;\n\tv40 = *([v12 @ X19_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv97 = *([v40 @ X0_v27+E0]) == 0;\n\tv42 = ~v97;\n\tif (v42) goto L_0014;\nL_0030:\n\tv64 = Viewport::GetViewport /* +1 sharing this address */(*([v52 @ X20_v7]));\nL_0038:\n\tViewport::Show(v64, 0.3f, 0);\n\tv82 = ApplicationManager::get_appData();\n\tv115 = Il2CppMethodInfo;\n\tApplicationData::ClearPlayerData(v82);\n\tgoto L_004A;\n\tv119 = \"il2cpp_codegen_runtime_class_init\"(v116, v79, v73, v26, v27, v28, v29, v30, v71, v32, v33, v34, v35, v36, v37, v38);\nL_004A:\n\tv83 = Singleton`1::get_Instance /* +1 sharing this address */(*([v115 @ X19_v4 (Il2CppMethodInfo)+C60]));\n\tApplicationManager::LoadScene(v83, 0);\n\treturn;\nL_0056:\n\tthrow System.NullReferenceException;\n// 57 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ResetGameData()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00dc: Expected O, but got I
		//IL_00ec: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AAF7]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)3288;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X0_v31+E0]");
			bool flag = (nint)0 == 0;
			object obj4 = obj2;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)3288;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v27+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			if (flag3)
			{
				goto IL_0093;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11CDAA4 (Viewport::GetViewport, and 1 more at this address)");
		goto IL_0133;
		IL_0133:
		Viewport viewport = default(Viewport);
		viewport.Show();
		ApplicationData appData = ApplicationManager.appData;
		nint num2 = 0;
		appData.ClearPlayerData();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		ApplicationManager applicationManager = default(ApplicationManager);
		applicationManager.LoadScene(0);
		return;
		IL_0093:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11CDAA4 (Viewport::GetViewport, and 1 more at this address)");
		if ((object)viewport == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_0133;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600047C")]
	[global::Cpp2ILInjected.Address(RVA = "0x1021268", Offset = "0x1021268", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Xml.ValidateNames;\n\tv20 = *([302AAF8]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0023;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0033;\nL_001D:\n\tViewport::.ctor(this);\n\treturn;\nL_0023:\n\t*([v16 @ X20_v1+AF8]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv62 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v62;\n\tif (v46) goto L_001D;\nL_0033:\n\tViewport::.ctor(this);\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SettingsScreen()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_005a: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AAF8]");
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
