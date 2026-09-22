[global::Cpp2ILInjected.Token(Token = "0x20000F0")]
public class LevelCompleteScreen : Viewport
{
[global::Cpp2ILInjected.Token(Token = "0x40004F2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public UIButton nextButton;

	[global::Cpp2ILInjected.Token(Token = "0x40004F3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public ElasticScale dialog;

	[global::Cpp2ILInjected.Token(Token = "0x40004F4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public global::TMPro.TextMeshProUGUI coinsCollectedText;

	[global::Cpp2ILInjected.Token(Token = "0x40004F5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public global::TMPro.TextMeshProUGUI levelText;

	[global::Cpp2ILInjected.Token(Token = "0x40004F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float conversionDuration;

	[global::Cpp2ILInjected.Token(Token = "0x6000454")]
	[global::Cpp2ILInjected.Address(RVA = "0x101F2D0", Offset = "0x101F2D0", Length = "0x118")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001C;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xF50;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv46 = System.Net.Configuration.SettingsSectionInternal;\n\tv47 = v46 + 0xE60;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v47, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv50 = \"IsCyrillic\";\n\tv51 = v50 + 0x7E8;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AAE5]) = v42;\nL_001C:\n\tv45 = ApplicationManager::get_appData();\n\tv52 = v45.playerData;\n\tv90 = \"IsCyrillic\";\n\tv85 = v52.levelIndex + 1;\n\tv94 = System.Int32::ToString(&v85 @ X8_v6 (System.Int32));\n\tv77 = System.String::Concat(*([v90 @ X21_v2 (System.String)+7E8]), v94);\n\tv78 = TMPro.TMP_Text::set_text(this.levelText, v77);\n\tv86 = this.nextButton;\n\tv121 = System.Net.Configuration.SettingsSectionInternal;\n\tv122 = Il2CppMethodInfo;\n\tv79 = new *([v121 @ X9_v3 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+E60])();\n\tUnityEngine.Events.UnityAction::.ctor(v79, this, *([v122 @ X22_v2 (Il2CppMethodInfo)+F50]));\n\tUnityEngine.Events.UnityEvent::AddListener(v86.m_OnClick, v79);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 57 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		PlayerData playerData = ApplicationManager.appData.playerData;
		levelText.text = "Level " + (playerData.levelIndex + 1);
		nextButton.m_OnClick.AddListener(OnNextButtonClicked);
	}

	private void OnNextButtonClicked()
	{
		Hide();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000455")]
	[global::Cpp2ILInjected.Address(RVA = "0x101F3E8", Offset = "0x101F3E8", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0017;\n\tv23 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv24 = v23 + 0x170;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAE6]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+170])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv61 = UnityEngine.MonoBehaviour::StartCoroutine(this, v45);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal override void OnStartShow()
	{
		global::UnityEngine.Coroutine coroutine = StartCoroutine(HandleStartShow());
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000456")]
	[global::Cpp2ILInjected.Address(RVA = "0x101F468", Offset = "0x101F468", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0017;\n\tv23 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv24 = v23 + 0x170;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAE6]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+170])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn v45;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::System.Collections.IEnumerator HandleStartShow()
	{
		dialog.gameObject.SetActive(false);
		nextButton.gameObject.SetActive(false);
		coinsCollectedText.gameObject.SetActive(false);
		yield return new global::UnityEngine.WaitForSeconds(0.5f);
		AudioManager.Instance.PlayClip("__sort-indicator");
		dialog.gameObject.SetActive(true);
		dialog.SetScale(0f);
		dialog.Pop();
		yield return new global::UnityEngine.WaitForSeconds(0.3f);
		coinsCollectedText.gameObject.SetActive(true);
		global::ElasticScale coinsScale = coinsCollectedText.GetComponent<global::ElasticScale>();
		coinsScale.SetScale(0f);
		coinsScale.Pop();
		nextButton.gameObject.SetActive(true);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000457")]
	[global::Cpp2ILInjected.Address(RVA = "0x101F50C", Offset = "0x101F50C", Length = "0x98")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Xml.ValidateNames;\n\tv20 = T & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0025;\n\tthis.conversionDuration = 1f;\n\tv23 = *([v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv25 = *([v23 @ X0_v10+E0]) == 0;\n\tif (v25) goto L_0037;\nL_001F:\n\tViewport::.ctor(this);\n\treturn;\nL_0025:\n\t*([302AAE7]) = 1;\n\tthis.conversionDuration = 1f;\n\tv45 = *([v18 @ X20_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv64 = *([v45 @ X0_v7+E0]) == 0;\n\tv47 = ~v64;\n\tif (v47) goto L_001F;\nL_0037:\n\tViewport::.ctor(this);\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public LevelCompleteScreen()
	{
		conversionDuration = 1f;
	}
}
