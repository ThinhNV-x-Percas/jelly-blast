[global::Cpp2ILInjected.Token(Token = "0x200000E")]
public class Menu : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400004E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.UI.Button _backBtn;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400004F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::UnityEngine.Sprite _mutedSprite;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000050")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private global::UnityEngine.Sprite _volumeSprite;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000051")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private global::UnityEngine.UI.Image _mutedBtnImg;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000052")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private global::UnityEngine.AudioSource _bgMusic;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000053")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::UnityEngine.GameObject _pages;

	[global::Cpp2ILInjected.Token(Token = "0x4000054")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private global::UnityEngine.GameObject _currentPage;

	[global::Cpp2ILInjected.Token(Token = "0x4000055")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private LogScroller _logScroller;

	[global::Cpp2ILInjected.Token(Token = "0x4000056")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private bool _muted;

	[global::Cpp2ILInjected.Token(Token = "0x4000057")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private global::System.Collections.Generic.Stack<global::UnityEngine.GameObject> _pagesStack;

	[global::Cpp2ILInjected.Token(Token = "0x6000089")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8550", Offset = "0xFD8550", Length = "0x40C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x778;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv51 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv52 = v51 + 0x9F0;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv55 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv56 = v55 + 0xA90;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv224 = System.Net.Configuration.SettingsSectionInternal;\n\tv225 = v224 + 0xAA8;\n\tv226 = \"il2cpp_codegen_initialize_runtime_metadata\"(v225, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv269 = \"l1\";\n\tv270 = v269 + 0x8E8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v270, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A8ED]) = v46;\nL_0022:\n\tv47 = 0;\n\tv50 = UnityEngine.Component::get_transform(this);\n\tv59 = UnityEngine.Transform::get_root(v50);\n\tv271 = Il2CppMethodInfo;\n\tv189 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v59, *([v271 @ X8_v12 (Il2CppMethodInfo)+778]));\n\tv283 = \"l1\";\n\tv218 = this + 0x58;\n\tthis._logScroller = *([v189 @ X0_v36+20]);\n\tv287 = 0xF3F1B4(v218, *([v189 @ X0_v36+20]), v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv293 = UnityEngine.PlayerPrefs::GetInt(*([v283 @ X21_v7 (System.String)+8E8]), 0);\n\tv150 = v293 < 0;\n\tv144 = v293 == 0;\n\tv132 = v293 ^ v293;\n\tv126 = v293 & v132;\n\tv120 = v126 < 0;\n\tv300 = v150 == v120;\n\tv109 = ~v144;\n\tv114 = v300 & v109;\n\tthis._muted = v114;\n\tv151 = v293 < 0;\n\tv145 = v293 == 0;\n\tv133 = v293 ^ v293;\n\tv127 = v293 & v133;\n\tv121 = v127 < 0;\n\tv310 = v151 == v121;\n\tv107 = ~v145;\n\tv115 = v310 & v107;\n\tv97 = ~v115;\n\tif (v97) goto L_FFFFFFFF;\n\tgoto L_0066;\nL_0066:\n\tUnityEngine.UI.Image::set_sprite(this._mutedBtnImg, *([this @ X0 (Menu)+v214 @ X8_v16 (System.Int32)]));\n\tUnityEngine.AudioSource::set_mute(this._bgMusic, this._muted);\n\tv193 = UnityEngine.GameObject::get_transform(this._pages);\n\tv499 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv500 = System.Net.Configuration.SettingsSectionInternal;\n\tv501 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv327 = UnityEngine.UIElements.EnumFieldHelpers + 0x9F0;\n\tv503 = UnityEngine.Transform::GetEnumerator(v193);\nL_0083:\n\tv548 = v87 == 0;\n\tif (v548) goto L_0175;\n\tv552 = *([v87 @ stack_-48_v6]);\n\tv587 = *([v552 @ X8_v21+12E]);\n\tv554 = *([v552 @ X8_v21+12E]) == 0;\n\tif (v554) goto L_00A6;\n\tv586 = *([v552 @ X8_v21+B0]) + 8;\nL_0091:\n\tv601 = *([v586 @ X10_v24-8]) == *([v499 @ X21_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v601) goto L_00A9;\n\tv586 = v586 + 0x10;\n\tv563 = v587 - 1;\n\tv565 = v587 != 1;\n\tif (v565) goto L_0091;\nL_00A6:\n\tv647 = 0xF7087C(v87, *([v499 @ X21_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_00AF;\nL_00A9:\n\tv644 = *([v586 @ X10_v24]) << 4;\n\tv645 = v552 + v644;\n\tv647 = v645 + 0x138;\nL_00AF:\n\t*([v647 @ X0_v49])(v650, v87, *([v647 @ X0_v49+8]), v352, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv651 = v650 & 1;\n\tv652 = v651 == 0;\n\tif (v652) goto L_010C;\n\tv638 = v87 == 0;\n\tif (v638) goto L_0177;\n\tv655 = *([v87 @ stack_-48_v6]);\n\tv689 = *([v655 @ X8_v25+12E]);\n\tv657 = *([v655 @ X8_v25+12E]) == 0;\n\tif (v657) goto L_00D7;\n\tv688 = *([v655 @ X8_v25+B0]) + 8;\nL_00C2:\n\tv703 = *([v688 @ X10_v19-8]) == *([v499 @ X21_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v703) goto L_00DA;\n\tv688 = v688 + 0x10;\n\tv665 = v689 - 1;\n\tv667 = v689 != 1;\n\tif (v667) goto L_00C2;\nL_00D7:\n\tv714 = 0xF7087C(v87, *([v499 @ X21_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_00E1;\nL_00DA:\n\tv710 = *([v688 @ X10_v19]) + 1;\n\tv711 = v710 << 4;\n\tv712 = v655 + v711;\n\tv714 = v712 + 0x138;\nL_00E1:\n\t*([v714 @ X0_v55])(v717, v87, *([v714 @ X0_v55+8]), v257, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv177 = *([v500 @ X23_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv718 = *([v717 @ X0_v57 (UnityEngine.Component)]);\n\tv719 = *([v718 @ X8_v28 (Il2CppClass<UnityEngine.Component>)+130]) < *([v177 @ X1_v24 (System.Boolean)+130]);\n\tv720 = ~v719;\n\tv728 = ~v720;\n\tif (v728) goto L_0173;\n\tv512 = *([v177 @ X1_v24 (System.Boolean)+130]) << 3;\n\tv730 = *([v718 @ X8_v28 (Il2CppClass<UnityEngine.Component>)+C8]) + v512;\n\tv518 = *([v730 @ X8_v31-8]) != v177;\n\tif (v518) goto L_0173;\n\tv540 = UnityEngine.Component::get_gameObject(v717);\n\tv542 = v540 == 0;\n\tif (v542) goto L_0179;\n\tUnityEngine.GameObject::SetActive(v540, 0);\n\tgoto L_0083;\nL_010C:\n\tv362 = &v87 @ stack_-48_v6;\n\tv318 = &v47 @ stack_-50_v1;\n\tv177 = *([v501 @ X22_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv357 = 0xF3F36C(*([v362 @ X8_v24]), *([v501 @ X22_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v352, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\t*([v318 @ X24_v7]) = v357;\n\tv360 = v357 == 0;\n\tif (v360) goto L_0140;\nL_0116:\n\tv368 = *([v357 @ X0_v28]);\n\tv466 = *([v368 @ X8_v8+12E]);\n\tv370 = *([v368 @ X8_v8+12E]) == 0;\n\tif (v370) goto L_0136;\n\tv465 = *([v368 @ X8_v8+B0]) + 8;\nL_0121:\n\tv480 = *([v465 @ X10_v9-8]) == *([v327 @ X22_v5]);\n\tif (v480) goto L_0139;\n\tv465 = v465 + 0x10;\n\tv441 = v466 - 1;\n\tv443 = v466 != 1;\n\tif (v443) goto L_0121;\nL_0136:\n\tv493 = 0xF7087C(v357, *([v327 @ X22_v5]), 0, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_013D;\nL_0139:\n\tv490 = *([v465 @ X10_v9]) << 4;\n\tv491 = v368 + v490;\n\tv493 = v491 + 0x138;\nL_013D:\n\tv177 = *([v493 @ X0_v29+8]);\n\t*([v493 @ X0_v29])(v430, v357, *([v493 @ X0_v29+8]), v257, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_0140:\n\tv433 = v219 == 0;\n\tv263 = ~v433;\n\tif (v263) goto L_017F;\n\tv146 = v95 == 6;\n\tif (v146) goto L_0154;\n\tv485 = v95 == 0;\n\tv486 = ~v485;\n\tif (v486) goto L_0172;\nL_0154:\n\tv195 = UnityEngine.GameObject::get_transform(v266._pages);\n\tv196 = UnityEngine.Transform::GetChild(v195, 0);\n\tv508 = UnityEngine.Component::get_gameObject(v196);\n\tv222 = v266 + 0x50;\n\tv266._currentPage = v508;\n\tv550 = 0xF3F1B4(v222, v508, 0, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tUnityEngine.GameObject::SetActive(v266._currentPage, 1);\nL_0172:\n\treturn;\nL_0173:\n\tv634 = new System.InvalidCastException();\n\tgoto L_017C;\nL_0175:\n\tv555 = new System.NullReferenceException();\n\tgoto L_017C;\nL_0177:\n\tv635 = new System.NullReferenceException();\n\tgoto L_017C;\nL_0179:\n\tv636 = new System.NullReferenceException();\n\tgoto L_017C;\n\tv633 = new System.NullReferenceException();\nL_017C:\n\t// 380 Interrupt\n\tthrow System.NullReferenceException;\nL_017F:\n\tv268 = new System.OutOfMemoryException();\n\tgoto L_0190;\n\tgoto L_0190;\n\tgoto L_0190;\n\tgoto L_0190;\n\tgoto L_0190;\n\tgoto L_0190;\nL_0190:\n\tv282 = v177 != 1;\n\tif (v282) goto L_01A4;\n\tv289 = 0x274A080(v268, v177, v257, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv363 = *([v289 @ X0_v24]);\n\tv296 = 0x274A098(v289, v177, v257, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv177 = *([v92 @ X22_v1]);\n\tv357 = 0xF3F36C(*([v232 @ stack_-60_v3]), *([v92 @ X22_v1]), v257, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\t*([v231 @ stack_-58_v3]) = v357;\n\tv311 = v357 == 0;\n\tv312 = ~v311;\n\tif (v312) goto L_0116;\n\tgoto L_0140;\n\tX20 = X0;\nL_01A4:\n\tv291 = 0xBF079C(&v82 @ stack_-68_v2 (System.Int32), v177, v257, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv298 = 0x27498DC(v268, v177, v257, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv307 = 0xD6F8(v298, v177, v257, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 236 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		_logScroller = base.transform.root.GetComponent<LogScroller>();
		int savedMuted = global::UnityEngine.PlayerPrefs.GetInt("Muted", 0);
		_muted = savedMuted != 0;
		_mutedBtnImg.sprite = _muted ? _mutedSprite : _volumeSprite;
		_bgMusic.mute = _muted;
		global::UnityEngine.Transform pagesTransform = _pages.transform;
		foreach (global::UnityEngine.Transform child in pagesTransform)
		{
			child.gameObject.SetActive(value: false);
		}
		if (pagesTransform.childCount == 0)
		{
			return;
		}
		_currentPage = pagesTransform.GetChild(0).gameObject;
		_currentPage.SetActive(value: true);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD7FB4", Offset = "0xFD7FB4", Length = "0x178")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0021;\n\tv23 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv24 = v23 + 0xFD8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, pageName, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv46 = Il2CppMethodInfo;\n\tv47 = v46 + 0xF58;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v47, pageName, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv89 = \" doesn't have _StencilOp property\";\n\tv90 = v89 + 0x808;\n\tv91 = \"il2cpp_codegen_initialize_runtime_metadata\"(v90, pageName, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv95 = \"DarkSalmon\";\n\tv96 = v95 + 0x8A8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v96, pageName, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A8EE]) = v43;\nL_0021:\n\tv49 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv52 = UnityEngine.GameObject::get_transform(this._pages);\n\tv94 = Menu::_FindChild(v52, v52, pageName);\n\tv97 = *([v49 @ X22_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv98 = *([v97 @ X0_v7+E0]) == 0;\n\tif (v98) goto L_005F;\n\tv128 = UnityEngine.Object::op_Inequality(v94, 0);\n\tv130 = ~v128;\n\tif (v130) goto L_0063;\nL_0034:\n\tv87 = this + 0x50;\n\tUnityEngine.GameObject::SetActive(this._currentPage, 0);\n\tv151 = Il2CppMethodInfo;\n\tSystem.Collections.Generic.Stack`1<UnityEngine.GameObject>::Push(this._pagesStack, this._currentPage);\n\tthis._currentPage = v94;\n\tv71 = 0xF3F1B4(v87, v94, *([v151 @ X8_v9 (Il2CppMethodInfo)+F58]), v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tUnityEngine.GameObject::SetActive(v94, 1);\n\tUnityEngine.UI.Selectable::set_interactable(this._backBtn, 1);\n\treturn;\nL_005F:\n\tv134 = UnityEngine.Object::op_Inequality(v94, 0);\n\tv149 = ~v134;\n\tv137 = ~v149;\n\tif (v137) goto L_0034;\nL_0063:\n\tv143 = \"DarkSalmon\";\n\tv146 = \" doesn't have _StencilOp property\";\n\tv148 = System.String::Concat(*([v143 @ X8_v5 (System.String)+8A8]), pageName, *([v146 @ X8_v7 (System.String)+808]));\n\tLogScroller::Log(this._logScroller, v148);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 79 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void NavToPage(string pageName)
	{
		global::UnityEngine.Transform transform = _pages.transform;
		global::UnityEngine.GameObject gameObject = _FindChild(transform, pageName);
		if (gameObject == null)
		{
			_logScroller.Log("Page not found: " + pageName);
			return;
		}
		_currentPage.SetActive(value: false);
		_pagesStack.Push(_currentPage);
		_currentPage = gameObject;
		gameObject.SetActive(value: true);
		_backBtn.interactable = true;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8CFC", Offset = "0xFD8CFC", Length = "0x120")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xF50;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0xF60;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv108 = \"DarkSalmon\";\n\tv109 = v108 + 0x8B0;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v109, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8EF]) = v42;\nL_001A:\n\tv43 = this._pagesStack;\n\tv59 = v43._size < 1;\n\tif (v59) goto L_0055;\n\tv106 = this + 0x50;\n\tUnityEngine.GameObject::SetActive(this._currentPage, 0);\n\tv157 = System.Collections.Generic.Stack`1<UnityEngine.GameObject>::Pop(this._pagesStack);\n\tthis._currentPage = v157;\n\tv90 = 0xF3F1B4(v106, v157, 0, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tUnityEngine.GameObject::SetActive(v157, 1);\n\tv103 = this._pagesStack;\n\tv144 = v103._size == 0;\n\tif (v144) goto L_006D;\n\treturn;\nL_0055:\n\tv111 = \"DarkSalmon\";\n\tLogScroller::Log(this._logScroller, *([v111 @ X8_v6 (System.String)+8B0]));\n\treturn;\nL_006D:\n\tUnityEngine.UI.Selectable::set_interactable(this._backBtn, 0);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 81 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnBackBtnClick()
	{
		//IL_00d6: Expected O, but got I
		//IL_0033: Expected O, but got I
		global::System.Collections.Generic.Stack<global::UnityEngine.GameObject> pagesStack = _pagesStack;
		if (pagesStack.Count >= 1)
		{
			_currentPage.SetActive(value: false);
			global::UnityEngine.GameObject gameObject = (_currentPage = _pagesStack.Pop());
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			gameObject.SetActive(value: true);
			global::System.Collections.Generic.Stack<global::UnityEngine.GameObject> pagesStack2 = _pagesStack;
			if (pagesStack2.Count == 0)
			{
				_backBtn.interactable = false;
			}
		}
		else
		{
			_logScroller.Log("No page to go back to");
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8E1C", Offset = "0xFD8E1C", Length = "0xA8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = \"l1\";\n\tgoto L_001B;\n\tv23 = \"l1\";\n\tv24 = v23 + 0x8E8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A8F0]) = v43;\nL_001B:\n\tv49 = this._muted == 0;\n\tv55 = this._muted ^ 1;\n\tthis._muted = v55;\n\tUnityEngine.PlayerPrefs::SetInt(*([v18 @ X20_v1 (System.String)+8E8]), v49);\n\tif (this._muted) goto L_FFFFFFFF;\n\tgoto L_003D;\nL_003D:\n\tUnityEngine.UI.Image::set_sprite(this._mutedBtnImg, *([this @ X0 (Menu)+v94 @ X8_v8 (System.Int32)]));\n\tUnityEngine.AudioSource::set_mute(this._bgMusic, this._muted);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 60 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnToggleMuteBtnClick()
	{
		_muted = !_muted;
		global::UnityEngine.PlayerPrefs.SetInt("Muted", _muted ? 1 : 0);
		_mutedBtnImg.sprite = _muted ? _mutedSprite : _volumeSprite;
		_bgMusic.mute = _muted;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD89B4", Offset = "0xFD89B4", Length = "0x32C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv27 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv28 = v27 + 0x9F0;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, target, name, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv51 = v50 + 0xA90;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, target, name, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv129 = System.Net.Configuration.SettingsSectionInternal;\n\tv130 = v129 + 0xAA8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v130, target, name, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv47 = 1;\n\t*([302A8F1]) = v47;\nL_001D:\n\tv48 = 0;\n\tv53 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv55 = System.Net.Configuration.SettingsSectionInternal;\n\tv57 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv431 = UnityEngine.UIElements.EnumFieldHelpers + 0x9F0;\n\tv61 = UnityEngine.Transform::GetEnumerator(target);\nL_0030:\n\tv229 = v113 == 0;\n\tif (v229) goto L_010A;\n\tv231 = *([v113 @ stack_-48_v6]);\n\tv290 = *([v231 @ X8_v16+12E]);\n\tv233 = *([v231 @ X8_v16+12E]) == 0;\n\tif (v233) goto L_0053;\n\tv289 = *([v231 @ X8_v16+B0]) + 8;\nL_003E:\n\tv295 = *([v289 @ X10_v25-8]) == *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v295) goto L_0056;\n\tv289 = v289 + 0x10;\n\tv271 = v290 - 1;\n\tv251 = v290 != 1;\n\tif (v251) goto L_003E;\nL_0053:\n\tv362 = 0xF7087C(v113, *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_005C;\nL_0056:\n\tv359 = *([v289 @ X10_v25]) << 4;\n\tv360 = v231 + v359;\n\tv362 = v360 + 0x138;\nL_005C:\n\t*([v362 @ X0_v31])(v365, v113, *([v362 @ X0_v31+8]), v414, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv366 = v365 & 1;\n\tv367 = v366 == 0;\n\tif (v367) goto L_FFFFFFFF;\n\tv346 = v113 == 0;\n\tif (v346) goto L_010C;\n\tv380 = *([v113 @ stack_-48_v6]);\n\tv572 = *([v380 @ X8_v21+12E]);\n\tv382 = *([v380 @ X8_v21+12E]) == 0;\n\tif (v382) goto L_0084;\n\tv571 = *([v380 @ X8_v21+B0]) + 8;\nL_006F:\n\tv577 = *([v571 @ X10_v20-8]) == *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v577) goto L_0087;\n\tv571 = v571 + 0x10;\n\tv509 = v572 - 1;\n\tv489 = v572 != 1;\n\tif (v489) goto L_006F;\nL_0084:\n\tv609 = 0xF7087C(v113, *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_008E;\nL_0087:\n\tv605 = *([v571 @ X10_v20]) + 1;\n\tv606 = v605 << 4;\n\tv607 = v380 + v606;\n\tv609 = v607 + 0x138;\nL_008E:\n\t*([v609 @ X0_v38])(v612, v113, *([v609 @ X0_v38+8]), v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv116 = *([v55 @ X23_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv621 = *([v612 @ X0_v40 (UnityEngine.Component)]);\n\tv622 = *([v621 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+130]) < *([v116 @ X1_v10 (System.String)+130]);\n\tv623 = ~v622;\n\tv631 = ~v623;\n\tif (v631) goto L_0108;\n\tv193 = *([v116 @ X1_v10 (System.String)+130]) << 3;\n\tv633 = *([v621 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+C8]) + v193;\n\tv197 = *([v633 @ X8_v27-8]) != v116;\n\tif (v197) goto L_0108;\n\tv637 = UnityEngine.Component::get_gameObject(v612);\n\tv347 = v637 == 0;\n\tif (v347) goto L_010E;\n\tv639 = UnityEngine.Object::get_name(v637);\n\tv221 = System.String::op_Equality(v639, name);\n\tv223 = v221 == 0;\n\tif (v223) goto L_0030;\n\tv400 = UnityEngine.Component::get_gameObject(v612);\n\tgoto L_00C5;\nL_00C5:\n\tv407 = &v113 @ stack_-48_v6;\n\tv408 = &v48 @ stack_-50_v1;\n\tv116 = *([v57 @ X22_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv433 = 0xF3F36C(*([v407 @ X8_v20]), *([v57 @ X22_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v414, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\t*([v408 @ X23_v9]) = v433;\n\tv435 = v433 == 0;\n\tif (v435) goto L_00F9;\nL_00CF:\n\tv442 = *([v433 @ X0_v19]);\n\tv593 = *([v442 @ X8_v8+12E]);\n\tv444 = *([v442 @ X8_v8+12E]) == 0;\n\tif (v444) goto L_00EF;\n\tv592 = *([v442 @ X8_v8+B0]) + 8;\nL_00DA:\n\tv598 = *([v592 @ X10_v9-8]) == *([v431 @ X22_v5]);\n\tif (v598) goto L_00F2;\n\tv592 = v592 + 0x10;\n\tv557 = v593 - 1;\n\tv537 = v593 != 1;\n\tif (v537) goto L_00DA;\nL_00EF:\n\tv618 = 0xF7087C(v433, *([v431 @ X22_v5]), 0, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_00F6;\nL_00F2:\n\tv615 = *([v592 @ X10_v9]) << 4;\n\tv616 = v442 + v615;\n\tv618 = v616 + 0x138;\nL_00F6:\n\tv116 = *([v618 @ X0_v20+8]);\n\t*([v618 @ X0_v20])(v528, v433, *([v618 @ X0_v20+8]), v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_00F9:\n\tv531 = v187 == 0;\n\tv179 = ~v531;\n\tif (v179) goto L_0114;\n\treturn v185;\nL_0108:\n\tv342 = new System.InvalidCastException();\n\tgoto L_0111;\nL_010A:\n\tv234 = new System.NullReferenceException();\n\tgoto L_0111;\nL_010C:\n\tv343 = new System.NullReferenceException();\n\tgoto L_0111;\nL_010E:\n\tv344 = new System.NullReferenceException();\n\tgoto L_0111;\n\tv341 = new System.NullReferenceException();\nL_0111:\n\t// 273 Interrupt\n\tthrow System.NullReferenceException;\nL_0114:\n\tv189 = new System.OutOfMemoryException();\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\nL_0129:\n\tv245 = v116 != 1;\n\tif (v245) goto L_013D;\n\tv276 = 0x274A080(v189, v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv439 = *([v276 @ X0_v15]);\n\tv354 = 0x274A098(v276, v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv116 = *([v173 @ X22_v2]);\n\tv433 = 0xF3F36C(*([v164 @ stack_-60_v3]), *([v173 @ X22_v2]), v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\t*([v162 @ stack_-58_v3]) = v433;\n\tv377 = v433 == 0;\n\tv378 = ~v377;\n\tif (v378) goto L_00CF;\n\tgoto L_00F9;\n\tX19 = X0;\nL_013D:\n\tv278 = 0xBF079C(&v109 @ stack_-68_v1 (System.Int32), v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv356 = 0x27498DC(v189, v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturnVal1 = 0xD6F8(v356, v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn returnVal1;\n// 175 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::UnityEngine.GameObject _FindChild(global::UnityEngine.Transform target, string name)
	{
		foreach (global::UnityEngine.Transform child in target)
		{
			if (child.gameObject.name == name)
			{
				return child.gameObject;
			}
			global::UnityEngine.GameObject found = _FindChild(child, name);
			if (found != null)
			{
				return found;
			}
		}
		return null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8CE0", Offset = "0xFD8CE0", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tLogScroller::Log(this._logScroller, text);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 10 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _LogText(string text)
	{
		_logScroller.Log(text);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD895C", Offset = "0xFD895C", Length = "0x58")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tif (this._muted) goto L_FFFFFFFF;\n\tgoto L_001E;\nL_001E:\n\tUnityEngine.UI.Image::set_sprite(this._mutedBtnImg, *([this @ X0 (Menu)+v55 @ X8_v4 (System.Int32)]));\n\tUnityEngine.AudioSource::set_mute(this._bgMusic, this._muted);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 38 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void _SetMuteBtnIcon()
	{
		_mutedBtnImg.sprite = _muted ? _mutedSprite : _volumeSprite;
		_bgMusic.mute = _muted;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000090")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8EC4", Offset = "0xFD8EC4", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xF48;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv50 = v49 + 0xAD0;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A8F2]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+AD0])();\n\tSystem.Collections.Generic.Stack`1<UnityEngine.GameObject>::.ctor(v48);\n\tv54 = this + 0x68;\n\tthis._pagesStack = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Menu()
	{
		_pagesStack = new global::System.Collections.Generic.Stack<global::UnityEngine.GameObject>();
	}
}
