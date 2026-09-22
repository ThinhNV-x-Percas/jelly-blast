[global::Cpp2ILInjected.Token(Token = "0x20000DE")]
public class UIButton : global::UnityEngine.MonoBehaviour, global::UnityEngine.EventSystems.IPointerDownHandler, global::UnityEngine.EventSystems.IEventSystemHandler, global::UnityEngine.EventSystems.IPointerClickHandler, global::UnityEngine.EventSystems.IPointerUpHandler
{
	[global::System.Serializable]
	[global::Cpp2ILInjected.Token(Token = "0x20000DF")]
	public class UIButtonClickedEvent : global::UnityEngine.Events.UnityEvent
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x101A40C", Offset = "0x101A40C", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.Events.UnityEvent::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public UIButtonClickedEvent()
		{
		}
	}

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400049C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public UIButton.UIButtonClickedEvent m_OnClick;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x400049D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public ElasticScale elasticScale;

	[global::Cpp2ILInjected.Token(Token = "0x17000047")]
	public UIButton.UIButtonClickedEvent onClick
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x101A414", Offset = "0x101A414", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn this.m_OnClick;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			return m_OnClick;
		}
		[global::Cpp2ILInjected.Token(Token = "0x60003F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x101A41C", Offset = "0x101A41C", Length = "0x8")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = this + 0x20;\n\tthis.m_OnClick = value;\n\tv3 = 0xF3F1B4(v0, value, methodInfo, v5, v6, v7, v8, v9, v10, v11, v12, v13, v14, v15, v16, v17);\n\treturn;\n")]
		set
		{
			//IL_000c: Expected O, but got I
			m_OnClick = value;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A394", Offset = "0x101A394", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Sponge+<>c__DisplayClass7_0;\n\tgoto L_0017;\n\tv23 = Sponge+<>c__DisplayClass7_0;\n\tv24 = v23 + 0x430;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAA1]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Sponge+<>c__DisplayClass7_0>)+430])();\n\tUnityEngine.Events.UnityEvent::.ctor(v45);\n\tv49 = this + 0x20;\n\tthis.m_OnClick = v45;\n\tv51 = 0xF3F1B4(v49, v45, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 29 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected UIButton()
	{
		m_OnClick = new UIButton.UIButtonClickedEvent();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003FA")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A424", Offset = "0x101A424", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Il2CppMethodInfo;\n\tgoto L_0018;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x630;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AAA2]) = v43;\nL_0018:\n\tv46 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v18 @ X21_v1 (Il2CppMethodInfo)+630]));\n\tv48 = this + 0x28;\n\tthis.elasticScale = v46;\n\tv56 = 0xF3F1B4(v48, v46, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		elasticScale = GetComponent<ElasticScale>();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003FB")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A488", Offset = "0x101A488", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	public void OnPointerClick(global::UnityEngine.EventSystems.PointerEventData eventData)
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003FC")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A48C", Offset = "0x101A48C", Length = "0xD8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = *([302AAA3]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0026;\n\tv51 = Il2CppMethodInfo + 0xC70;\n\tv24 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A38]);\n\tv26 = *([v24 @ X0_v21+E0]) == 0;\n\tif (v26) goto L_0030;\nL_0017:\n\tv70 = Singleton`1::get_Instance /* +1 sharing this address */(*([v51 @ X21_v8]));\n\tv63 = v70 == 0;\n\tv64 = ~v63;\n\tif (v64) goto L_0033;\n\tgoto L_0046;\nL_0026:\n\t*([v16 @ X21_v1+AA3]) = 1;\n\tv51 = Il2CppMethodInfo + 0xC70;\n\tv46 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A38]);\n\tv81 = *([v46 @ X0_v17+E0]) == 0;\n\tv48 = ~v81;\n\tif (v48) goto L_0017;\nL_0030:\n\tv70 = Singleton`1::get_Instance /* +1 sharing this address */(*([v58 @ X21_v5]));\nL_0033:\n\tv75 = \"focus\";\n\tAudioManager::PlayClip(v70, *([v75 @ X8_v4 (System.String)+4E0]));\n\tv88 = this.elasticScale;\n\tv88.targetScale = 0.8f;\n\treturn;\nL_0046:\n\tthrow System.NullReferenceException;\n// 45 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnPointerDown(global::UnityEngine.EventSystems.PointerEventData eventData)
	{
		AudioManager audioManager = Singleton<AudioManager>.Instance;
		if (audioManager != null)
		{
			audioManager.PlayClip("focus");
		}
		if (elasticScale != null)
		{
			elasticScale.targetScale = 0.8f;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003FD")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A564", Offset = "0x101A564", Length = "0xD0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xC70;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, eventData, methodInfo, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv47 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv48 = v47 + 0xA38;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v48, eventData, methodInfo, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv52 = \"__sort-indicator\";\n\tv53 = v52 + 0xCE8;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, eventData, methodInfo, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AAA4]) = v42;\nL_001E:\n\tTapticPlugin.TapticManager::Impact(1);\n\tv51 = this.m_OnClick == 0;\n\tif (v51) goto L_0024;\n\tUnityEngine.Events.UnityEvent::Invoke(this.m_OnClick);\nL_0024:\n\tv56 = Il2CppMethodInfo;\n\tgoto L_002D;\n\tv62 = \"il2cpp_codegen_runtime_class_init\"(v58, v55, methodInfo, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_002D:\n\tv65 = Singleton`1::get_Instance /* +1 sharing this address */(*([v56 @ X21_v1 (Il2CppMethodInfo)+C70]));\n\tv67 = \"__sort-indicator\";\n\tAudioManager::PlayClip(v65, *([v67 @ X8_v5 (System.String)+CE8]));\n\tv74 = this.elasticScale;\n\tv74.targetScale = 1f;\n\tElasticScale::Pop(v74);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 42 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnPointerUp(global::UnityEngine.EventSystems.PointerEventData eventData)
	{
		global::TapticPlugin.TapticManager.Impact(global::TapticPlugin.ImpactFeedback.Medium);
		if (m_OnClick != null)
		{
			m_OnClick.Invoke();
		}
		AudioManager audioManager = Singleton<AudioManager>.Instance;
		if (audioManager != null)
		{
			audioManager.PlayClip("focus");
		}
		if (elasticScale != null)
		{
			elasticScale.targetScale = 1f;
			elasticScale.Pop();
		}
	}
}
