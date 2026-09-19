[global::Cpp2ILInjected.Token(Token = "0x20000E9")]
public class FailScreen : Viewport
{
[global::Cpp2ILInjected.Token(Token = "0x40004D9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public TextPopEffect titleTextEffect;

	[global::Cpp2ILInjected.Token(Token = "0x6000433")]
	[global::Cpp2ILInjected.Address(RVA = "0x101DDAC", Offset = "0x101DDAC", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv24 = v23 + 0xAD8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAD9]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+AD8])();\n\tSystem.Object::.ctor(v45);\n\t*([v45 @ X0_v3 (System.Object)+10]) = 0;\n\tv49 = v45 + 0x20;\n\t*([v45 @ X0_v3 (System.Object)+20]) = this;\n\tv51 = 0xF3F1B4(v49, this, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv61 = UnityEngine.MonoBehaviour::StartCoroutine(this, v45);\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal override void OnStartShow()
	{
		global::UnityEngine.Coroutine coroutine = StartCoroutine(HandleStartShow());
	}

	private global::System.Collections.IEnumerator HandleStartShow()
	{
		titleTextEffect.gameObject.SetActive(false);
		yield return new global::UnityEngine.WaitForSeconds(0.1f);
		AudioManager.Instance.PlayClip("cp420");
		PlayerData playerData = ApplicationManager.appData.playerData;
		if (playerData.hapticOn)
		{
			global::TapticPlugin.TapticManager.Impact(global::TapticPlugin.ImpactFeedback.Heavy);
		}
		titleTextEffect.gameObject.SetActive(true);
		titleTextEffect.StartTransition();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000435")]
	[global::Cpp2ILInjected.Address(RVA = "0x101DED0", Offset = "0x101DED0", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Xml.ValidateNames;\n\tv20 = *([302AADA]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0023;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0033;\nL_001D:\n\tViewport::.ctor(this);\n\treturn;\nL_0023:\n\t*([v16 @ X20_v1+ADA]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv62 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v62;\n\tif (v46) goto L_001D;\nL_0033:\n\tViewport::.ctor(this);\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FailScreen()
	{
	}
}
