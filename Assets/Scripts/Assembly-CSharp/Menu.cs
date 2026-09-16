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
		//IL_08d4: Expected O, but got I4
		//IL_0041: Expected O, but got I
		//IL_0053: Expected O, but got I
		//IL_0073: Expected O, but got I
		//IL_0900: Expected O, but got I
		//IL_01d2: Expected I, but got O
		//IL_01e0: Expected I, but got O
		//IL_01ee: Expected I, but got O
		//IL_01fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_0202: Expected O, but got Unknown
		//IL_0218: Expected O, but got I4
		//IL_0236: Expected O, but got I
		//IL_02cf: Expected O, but got I4
		//IL_0271: Expected O, but got I
		//IL_02e2: Expected I4, but got O
		//IL_02f0: Expected O, but got I
		//IL_02ff: Expected O, but got I
		//IL_05f0: Expected O, but got I
		//IL_0285: Expected O, but got I
		//IL_0294: Expected O, but got I
		//IL_0689: Expected O, but got I4
		//IL_0341: Expected O, but got I
		//IL_062b: Expected O, but got I
		//IL_03da: Expected O, but got I4
		//IL_0821: Expected I4, but got O
		//IL_037c: Expected O, but got I
		//IL_0839: Expected I4, but got O
		//IL_087d: Expected I4, but got O
		//IL_0755: Expected O, but got I
		//IL_069c: Expected I4, but got O
		//IL_06aa: Expected O, but got I
		//IL_06b9: Expected O, but got I
		//IL_043e: Expected I, but got O
		//IL_063f: Expected O, but got I
		//IL_064e: Expected O, but got I
		//IL_03e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ed: Expected O, but got Unknown
		//IL_040a: Expected O, but got I
		//IL_0419: Expected O, but got I
		//IL_08ac: Expected I4, but got O
		//IL_08c5: Expected I4, but got O
		//IL_04ab: Expected O, but got I
		//IL_0390: Expected O, but got I
		//IL_039f: Expected O, but got I
		//IL_0513: Expected O, but got I4
		object obj = 0;
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Transform root = transform.root;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		string text = "l1";
		object obj2 = (nint)this + 88;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X0_v36+20]");
		_logScroller = (LogScroller)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X21_v7 (System.String)+8E8]");
		int num2 = global::UnityEngine.PlayerPrefs.GetInt((string)0, 0);
		bool flag = num2 < 0;
		bool flag2 = num2 == 0;
		int num3 = num2 ^ num2;
		int num4 = num2 & num3;
		bool flag3 = num4 < 0;
		bool flag4 = flag == flag3;
		bool flag5 = !flag2;
		bool muted = flag4 && flag5;
		_muted = muted;
		bool flag6 = num2 < 0;
		bool flag7 = num2 == 0;
		int num5 = num2 ^ num2;
		int num6 = num2 & num5;
		bool flag8 = num6 < 0;
		bool flag9 = flag6 == flag8;
		bool flag10 = !flag7;
		if (flag9 && flag10)
		{
			int num7 = 40;
		}
		else
		{
			int num7 = 48;
		}
		global::UnityEngine.UI.Image mutedBtnImg = _mutedBtnImg;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Menu)+v214 @ X8_v16 (System.Int32)]");
		mutedBtnImg.sprite = (global::UnityEngine.Sprite)0;
		_bgMusic.mute = _muted;
		global::UnityEngine.Transform transform2 = _pages.transform;
		nint num8 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num9 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		nint num10 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		object obj3 = typeof(global::UnityEngine.UIElements.EnumFieldHelpers) + 2544;
		global::System.Collections.IEnumerator enumerator = transform2.GetEnumerator();
		object obj4 = 0;
		object obj5 = default(object);
		object obj14 = default(object);
		object obj16 = default(object);
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj22 = default(object);
		object obj15;
		object obj19;
		int num16;
		while (true)
		{
			object obj12;
			if (obj5 != null)
			{
				object obj6 = obj5;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v21+12E]");
				object obj7 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v21+12E]");
				if ((nint)0 == 0)
				{
					goto IL_02bc;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v552 @ X8_v21+B0]");
				object obj8 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v586 @ X10_v24-8]");
					nint num11 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X21_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num11 == 0)
					{
						break;
					}
					obj8 = (nint)obj8 + 16;
					object obj9 = (nint)obj7 - 1;
					bool flag11 = (nint)obj7 != 1;
					obj7 = obj9;
					if (flag11)
					{
						continue;
					}
					goto IL_02bc;
				}
				int num12 = obj8 << 4;
				object obj10 = (nint)obj6 + num12;
				object obj11 = (nint)obj10 + 312;
				obj12 = obj4;
				goto IL_0931;
			}
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			break;
			IL_09bf:
			int num13;
			object obj13;
			int num14;
			Menu menu;
			int num15;
			object obj17;
			object obj18;
			int num17;
			Menu menu3;
			bool flag14;
			object obj20;
			while (true)
			{
				bool flag12 = num13 == 0;
				bool flag13 = !flag12;
				obj3 = obj13;
				if (!flag13)
				{
					if (num14 == 6 || num14 == 0)
					{
						global::UnityEngine.Transform transform3 = menu._pages.transform;
						global::UnityEngine.Transform child = transform3.GetChild(0);
						global::UnityEngine.GameObject currentPage = child.gameObject;
						Menu menu2 = (Menu)((nint)menu + 80);
						menu._currentPage = currentPage;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
						menu._currentPage.SetActive(value: true);
					}
					return;
				}
				global::System.OutOfMemoryException ex2 = new global::System.OutOfMemoryException();
				if (flag14)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
					num15 = (int)obj14;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
					flag14 = (byte)(int)obj13 != 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
					obj15 = obj16;
					bool flag15 = obj16 == null;
					bool flag16 = !flag15;
					obj17 = obj15;
					obj18 = obj19;
					num16 = (int)obj14;
					num17 = 0;
					obj12 = obj20;
					menu3 = menu;
					if (flag16)
					{
						break;
					}
					num16 = (int)obj14;
					obj13 = obj13;
					num14 = 0;
					num13 = (int)obj14;
					continue;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF079C");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
				return;
			}
			goto IL_05d8;
			IL_0676:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			obj20 = 0;
			goto IL_0a13;
			IL_03c7:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			obj20 = 1;
			goto IL_0993;
			IL_0993:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v714 @ X0_v55] (should have been resolved before IL gen)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v500 @ X23_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
			flag14 = false;
			nint num18 = (nint)component;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v28 (Il2CppClass<UnityEngine.Component>)+130]");
			nint num19 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X1_v24 (System.Boolean)+130]");
			if (num19 >= 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v177 @ X1_v24 (System.Boolean)+130]");
				int num20 = (int)((nint)0 << 3);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v718 @ X8_v28 (Il2CppClass<UnityEngine.Component>)+C8]");
				object obj21 = (nint)0 + (nint)num20;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v730 @ X8_v31-8]");
				if ((nint)0 == (flag14 ? 1 : 0))
				{
					global::UnityEngine.GameObject gameObject = component.gameObject;
					if ((object)gameObject != null)
					{
						gameObject.SetActive(value: false);
						obj4 = 0;
						continue;
					}
					global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
					break;
				}
			}
			global::System.InvalidCastException ex4 = new global::System.InvalidCastException();
			break;
			IL_02bc:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			obj12 = 0;
			goto IL_0931;
			IL_0931:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v647 @ X0_v49] (should have been resolved before IL gen)");
			if ((int)((nint)obj22 & 1) != 0)
			{
				if (obj5 != null)
				{
					object obj23 = obj5;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v25+12E]");
					object obj24 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v25+12E]");
					if ((nint)0 == 0)
					{
						goto IL_03c7;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v655 @ X8_v25+B0]");
					object obj25 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v688 @ X10_v19-8]");
						nint num21 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v499 @ X21_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num21 == 0)
						{
							break;
						}
						obj25 = (nint)obj25 + 16;
						object obj26 = (nint)obj24 - 1;
						bool flag17 = (nint)obj24 != 1;
						obj24 = obj26;
						if (flag17)
						{
							continue;
						}
						goto IL_03c7;
					}
					object obj27 = obj25 + 1;
					int num22 = (int)((nint)obj27 << 4);
					object obj28 = (nint)obj23 + num22;
					object obj29 = (nint)obj28 + 312;
					obj20 = obj12;
					goto IL_0993;
				}
				global::System.NullReferenceException ex5 = new global::System.NullReferenceException();
				break;
			}
			object obj30 = obj5;
			object obj31 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v501 @ X22_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
			flag14 = false;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			obj31 = obj16;
			bool flag18 = obj16 == null;
			obj17 = obj;
			obj18 = obj5;
			num16 = 0;
			num17 = 6;
			num15 = 0;
			menu3 = this;
			obj15 = obj;
			obj19 = obj5;
			num16 = 0;
			obj13 = obj3;
			num14 = 6;
			obj20 = obj12;
			num13 = 0;
			menu = this;
			if (!flag18)
			{
				goto IL_05d8;
			}
			goto IL_09bf;
			IL_05d8:
			object obj32 = obj16;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v8+12E]");
			object obj33 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0676;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v368 @ X8_v8+B0]");
			object obj34 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v465 @ X10_v9-8]");
				if (0 == (nint)obj3)
				{
					break;
				}
				obj34 = (nint)obj34 + 16;
				object obj35 = (nint)obj33 - 1;
				bool flag19 = (nint)obj33 != 1;
				obj33 = obj35;
				if (flag19)
				{
					continue;
				}
				goto IL_0676;
			}
			int num23 = obj34 << 4;
			object obj36 = (nint)obj32 + num23;
			object obj37 = (nint)obj36 + 312;
			obj20 = obj12;
			goto IL_0a13;
			IL_0a13:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v493 @ X0_v29+8]");
			flag14 = false;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v493 @ X0_v29] (should have been resolved before IL gen)");
			obj15 = obj17;
			obj19 = obj18;
			obj13 = obj3;
			num14 = num17;
			num13 = num15;
			menu = menu3;
			goto IL_09bf;
		}
		obj15 = obj;
		obj19 = obj5;
		num16 = 0;
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD7FB4", Offset = "0xFD7FB4", Length = "0x178")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0021;\n\tv23 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv24 = v23 + 0xFD8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, pageName, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv46 = Il2CppMethodInfo;\n\tv47 = v46 + 0xF58;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v47, pageName, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv89 = \" doesn't have _StencilOp property\";\n\tv90 = v89 + 0x808;\n\tv91 = \"il2cpp_codegen_initialize_runtime_metadata\"(v90, pageName, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv95 = \"DarkSalmon\";\n\tv96 = v95 + 0x8A8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v96, pageName, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A8EE]) = v43;\nL_0021:\n\tv49 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv52 = UnityEngine.GameObject::get_transform(this._pages);\n\tv94 = Menu::_FindChild(v52, v52, pageName);\n\tv97 = *([v49 @ X22_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv98 = *([v97 @ X0_v7+E0]) == 0;\n\tif (v98) goto L_005F;\n\tv128 = UnityEngine.Object::op_Inequality(v94, 0);\n\tv130 = ~v128;\n\tif (v130) goto L_0063;\nL_0034:\n\tv87 = this + 0x50;\n\tUnityEngine.GameObject::SetActive(this._currentPage, 0);\n\tv151 = Il2CppMethodInfo;\n\tSystem.Collections.Generic.Stack`1<UnityEngine.GameObject>::Push(this._pagesStack, this._currentPage);\n\tthis._currentPage = v94;\n\tv71 = 0xF3F1B4(v87, v94, *([v151 @ X8_v9 (Il2CppMethodInfo)+F58]), v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tUnityEngine.GameObject::SetActive(v94, 1);\n\tUnityEngine.UI.Selectable::set_interactable(this._backBtn, 1);\n\treturn;\nL_005F:\n\tv134 = UnityEngine.Object::op_Inequality(v94, 0);\n\tv149 = ~v134;\n\tv137 = ~v149;\n\tif (v137) goto L_0034;\nL_0063:\n\tv143 = \"DarkSalmon\";\n\tv146 = \" doesn't have _StencilOp property\";\n\tv148 = System.String::Concat(*([v143 @ X8_v5 (System.String)+8A8]), pageName, *([v146 @ X8_v7 (System.String)+808]));\n\tLogScroller::Log(this._logScroller, v148);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 79 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void NavToPage(string pageName)
	{
		//IL_0013: Expected I, but got O
		//IL_004c: Expected O, but got I
		//IL_00a4: Expected O, but got I
		//IL_017c: Expected O, but got I
		//IL_017c: Expected O, but got I
		nint num = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::UnityEngine.Transform transform = _pages.transform;
		global::UnityEngine.GameObject gameObject = ((Menu)(object)transform)._FindChild(transform, pageName);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v49 @ X22_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X0_v7+E0]");
		if ((nint)0 != 0)
		{
			if (gameObject != null)
			{
				goto IL_0098;
			}
		}
		else if (gameObject != null)
		{
			goto IL_0098;
		}
		string text = "DarkSalmon";
		string text2 = " doesn't have _StencilOp property";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v5 (System.String)+8A8]");
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v7 (System.String)+808]");
		string text3 = (string)num2 + pageName + (string)0;
		_logScroller.Log(text3);
		return;
		IL_0098:
		object obj2 = (nint)this + 80;
		_currentPage.SetActive(value: false);
		nint num3 = 0;
		_pagesStack.Push(_currentPage);
		_currentPage = gameObject;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
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
			object obj = (nint)this + 80;
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
			string text = "DarkSalmon";
			LogScroller logScroller = _logScroller;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v111 @ X8_v6 (System.String)+8B0]");
			logScroller.Log((string)0);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8E1C", Offset = "0xFD8E1C", Length = "0xA8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = \"l1\";\n\tgoto L_001B;\n\tv23 = \"l1\";\n\tv24 = v23 + 0x8E8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A8F0]) = v43;\nL_001B:\n\tv49 = this._muted == 0;\n\tv55 = this._muted ^ 1;\n\tthis._muted = v55;\n\tUnityEngine.PlayerPrefs::SetInt(*([v18 @ X20_v1 (System.String)+8E8]), v49);\n\tif (this._muted) goto L_FFFFFFFF;\n\tgoto L_003D;\nL_003D:\n\tUnityEngine.UI.Image::set_sprite(this._mutedBtnImg, *([this @ X0 (Menu)+v94 @ X8_v8 (System.Int32)]));\n\tUnityEngine.AudioSource::set_mute(this._bgMusic, this._muted);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 60 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnToggleMuteBtnClick()
	{
		//IL_008c: Expected O, but got I
		//IL_00a8: Expected O, but got I
		string text = "l1";
		bool value = !_muted;
		int muted = (_muted ? 1 : 0) ^ 1;
		_muted = (byte)muted != 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (System.String)+8E8]");
		global::UnityEngine.PlayerPrefs.SetInt((string)0, value ? 1 : 0);
		if (!_muted)
		{
			int num = 48;
		}
		else
		{
			int num = 40;
		}
		global::UnityEngine.UI.Image mutedBtnImg = _mutedBtnImg;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Menu)+v94 @ X8_v8 (System.Int32)]");
		mutedBtnImg.sprite = (global::UnityEngine.Sprite)0;
		_bgMusic.mute = _muted;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600008D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD89B4", Offset = "0xFD89B4", Length = "0x32C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv27 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv28 = v27 + 0x9F0;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, target, name, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv51 = v50 + 0xA90;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, target, name, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv129 = System.Net.Configuration.SettingsSectionInternal;\n\tv130 = v129 + 0xAA8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v130, target, name, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv47 = 1;\n\t*([302A8F1]) = v47;\nL_001D:\n\tv48 = 0;\n\tv53 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv55 = System.Net.Configuration.SettingsSectionInternal;\n\tv57 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv431 = UnityEngine.UIElements.EnumFieldHelpers + 0x9F0;\n\tv61 = UnityEngine.Transform::GetEnumerator(target);\nL_0030:\n\tv229 = v113 == 0;\n\tif (v229) goto L_010A;\n\tv231 = *([v113 @ stack_-48_v6]);\n\tv290 = *([v231 @ X8_v16+12E]);\n\tv233 = *([v231 @ X8_v16+12E]) == 0;\n\tif (v233) goto L_0053;\n\tv289 = *([v231 @ X8_v16+B0]) + 8;\nL_003E:\n\tv295 = *([v289 @ X10_v25-8]) == *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v295) goto L_0056;\n\tv289 = v289 + 0x10;\n\tv271 = v290 - 1;\n\tv251 = v290 != 1;\n\tif (v251) goto L_003E;\nL_0053:\n\tv362 = 0xF7087C(v113, *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_005C;\nL_0056:\n\tv359 = *([v289 @ X10_v25]) << 4;\n\tv360 = v231 + v359;\n\tv362 = v360 + 0x138;\nL_005C:\n\t*([v362 @ X0_v31])(v365, v113, *([v362 @ X0_v31+8]), v414, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv366 = v365 & 1;\n\tv367 = v366 == 0;\n\tif (v367) goto L_FFFFFFFF;\n\tv346 = v113 == 0;\n\tif (v346) goto L_010C;\n\tv380 = *([v113 @ stack_-48_v6]);\n\tv572 = *([v380 @ X8_v21+12E]);\n\tv382 = *([v380 @ X8_v21+12E]) == 0;\n\tif (v382) goto L_0084;\n\tv571 = *([v380 @ X8_v21+B0]) + 8;\nL_006F:\n\tv577 = *([v571 @ X10_v20-8]) == *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v577) goto L_0087;\n\tv571 = v571 + 0x10;\n\tv509 = v572 - 1;\n\tv489 = v572 != 1;\n\tif (v489) goto L_006F;\nL_0084:\n\tv609 = 0xF7087C(v113, *([v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_008E;\nL_0087:\n\tv605 = *([v571 @ X10_v20]) + 1;\n\tv606 = v605 << 4;\n\tv607 = v380 + v606;\n\tv609 = v607 + 0x138;\nL_008E:\n\t*([v609 @ X0_v38])(v612, v113, *([v609 @ X0_v38+8]), v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv116 = *([v55 @ X23_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv621 = *([v612 @ X0_v40 (UnityEngine.Component)]);\n\tv622 = *([v621 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+130]) < *([v116 @ X1_v10 (System.String)+130]);\n\tv623 = ~v622;\n\tv631 = ~v623;\n\tif (v631) goto L_0108;\n\tv193 = *([v116 @ X1_v10 (System.String)+130]) << 3;\n\tv633 = *([v621 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+C8]) + v193;\n\tv197 = *([v633 @ X8_v27-8]) != v116;\n\tif (v197) goto L_0108;\n\tv637 = UnityEngine.Component::get_gameObject(v612);\n\tv347 = v637 == 0;\n\tif (v347) goto L_010E;\n\tv639 = UnityEngine.Object::get_name(v637);\n\tv221 = System.String::op_Equality(v639, name);\n\tv223 = v221 == 0;\n\tif (v223) goto L_0030;\n\tv400 = UnityEngine.Component::get_gameObject(v612);\n\tgoto L_00C5;\nL_00C5:\n\tv407 = &v113 @ stack_-48_v6;\n\tv408 = &v48 @ stack_-50_v1;\n\tv116 = *([v57 @ X22_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv433 = 0xF3F36C(*([v407 @ X8_v20]), *([v57 @ X22_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v414, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\t*([v408 @ X23_v9]) = v433;\n\tv435 = v433 == 0;\n\tif (v435) goto L_00F9;\nL_00CF:\n\tv442 = *([v433 @ X0_v19]);\n\tv593 = *([v442 @ X8_v8+12E]);\n\tv444 = *([v442 @ X8_v8+12E]) == 0;\n\tif (v444) goto L_00EF;\n\tv592 = *([v442 @ X8_v8+B0]) + 8;\nL_00DA:\n\tv598 = *([v592 @ X10_v9-8]) == *([v431 @ X22_v5]);\n\tif (v598) goto L_00F2;\n\tv592 = v592 + 0x10;\n\tv557 = v593 - 1;\n\tv537 = v593 != 1;\n\tif (v537) goto L_00DA;\nL_00EF:\n\tv618 = 0xF7087C(v433, *([v431 @ X22_v5]), 0, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_00F6;\nL_00F2:\n\tv615 = *([v592 @ X10_v9]) << 4;\n\tv616 = v442 + v615;\n\tv618 = v616 + 0x138;\nL_00F6:\n\tv116 = *([v618 @ X0_v20+8]);\n\t*([v618 @ X0_v20])(v528, v433, *([v618 @ X0_v20+8]), v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_00F9:\n\tv531 = v187 == 0;\n\tv179 = ~v531;\n\tif (v179) goto L_0114;\n\treturn v185;\nL_0108:\n\tv342 = new System.InvalidCastException();\n\tgoto L_0111;\nL_010A:\n\tv234 = new System.NullReferenceException();\n\tgoto L_0111;\nL_010C:\n\tv343 = new System.NullReferenceException();\n\tgoto L_0111;\nL_010E:\n\tv344 = new System.NullReferenceException();\n\tgoto L_0111;\n\tv341 = new System.NullReferenceException();\nL_0111:\n\t// 273 Interrupt\n\tthrow System.NullReferenceException;\nL_0114:\n\tv189 = new System.OutOfMemoryException();\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\n\tgoto L_0129;\nL_0129:\n\tv245 = v116 != 1;\n\tif (v245) goto L_013D;\n\tv276 = 0x274A080(v189, v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv439 = *([v276 @ X0_v15]);\n\tv354 = 0x274A098(v276, v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv116 = *([v173 @ X22_v2]);\n\tv433 = 0xF3F36C(*([v164 @ stack_-60_v3]), *([v173 @ X22_v2]), v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\t*([v162 @ stack_-58_v3]) = v433;\n\tv377 = v433 == 0;\n\tv378 = ~v377;\n\tif (v378) goto L_00CF;\n\tgoto L_00F9;\n\tX19 = X0;\nL_013D:\n\tv278 = 0xBF079C(&v109 @ stack_-68_v1 (System.Int32), v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv356 = 0x27498DC(v189, v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturnVal1 = 0xD6F8(v356, v116, v138, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn returnVal1;\n// 175 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::UnityEngine.GameObject _FindChild(global::UnityEngine.Transform target, string name)
	{
		//IL_05e5: Expected O, but got I4
		//IL_0013: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_002f: Expected I, but got O
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected O, but got Unknown
		//IL_0076: Expected O, but got I
		//IL_00b1: Expected O, but got I
		//IL_06c4: Expected O, but got I
		//IL_011e: Expected I4, but got O
		//IL_012c: Expected O, but got I
		//IL_013b: Expected O, but got I
		//IL_00c5: Expected O, but got I
		//IL_00d4: Expected O, but got I
		//IL_03d0: Expected O, but got I
		//IL_017d: Expected O, but got I
		//IL_0216: Expected O, but got I4
		//IL_07a9: Expected O, but got I
		//IL_040b: Expected O, but got I
		//IL_01b8: Expected O, but got I
		//IL_053e: Expected I4, but got O
		//IL_0272: Expected O, but got I
		//IL_027a: Expected I, but got O
		//IL_05a2: Expected I4, but got O
		//IL_0478: Expected I4, but got O
		//IL_0486: Expected O, but got I
		//IL_0495: Expected O, but got I
		//IL_0224: Unknown result type (might be due to invalid IL or missing references)
		//IL_0229: Expected O, but got Unknown
		//IL_0246: Expected O, but got I
		//IL_0255: Expected O, but got I
		//IL_041f: Expected O, but got I
		//IL_042e: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_01cc: Expected O, but got I
		//IL_01db: Expected O, but got I
		//IL_05bd: Expected I4, but got O
		//IL_05d2: Expected I4, but got O
		object obj = 0;
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		nint num3 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		object obj2 = typeof(global::UnityEngine.UIElements.EnumFieldHelpers) + 2544;
		global::System.Collections.IEnumerator enumerator = target.GetEnumerator();
		string text = name;
		object obj3 = default(object);
		string text2;
		object obj10 = default(object);
		global::UnityEngine.GameObject gameObject;
		int num8;
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		string text4;
		string text3;
		object obj20;
		object obj19;
		int num12;
		while (true)
		{
			if (obj3 != null)
			{
				object obj4 = obj3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v16+12E]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v16+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00fc;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v16+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v25-8]");
					nint num4 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num4 == 0)
					{
						break;
					}
					obj6 = (nint)obj6 + 16;
					object obj7 = (nint)obj5 - 1;
					bool flag = (nint)obj5 != 1;
					obj5 = obj7;
					if (flag)
					{
						continue;
					}
					goto IL_00fc;
				}
				int num5 = obj6 << 4;
				object obj8 = (nint)obj4 + num5;
				object obj9 = (nint)obj8 + 312;
				text2 = text;
				goto IL_0616;
			}
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			goto IL_04df;
			IL_0616:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v362 @ X0_v31] (should have been resolved before IL gen)");
			if ((int)((nint)obj10 & 1) != 0)
			{
				if (obj3 != null)
				{
					object obj11 = obj3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v21+12E]");
					object obj12 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v21+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0203;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v380 @ X8_v21+B0]");
					object obj13 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v571 @ X10_v20-8]");
						nint num6 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X21_v8 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num6 == 0)
						{
							break;
						}
						obj13 = (nint)obj13 + 16;
						object obj14 = (nint)obj12 - 1;
						bool flag2 = (nint)obj12 != 1;
						obj12 = obj14;
						if (flag2)
						{
							continue;
						}
						goto IL_0203;
					}
					object obj15 = obj13 + 1;
					int num7 = (int)((nint)obj15 << 4);
					object obj16 = (nint)obj11 + num7;
					object obj17 = (nint)obj16 + 312;
					text3 = text2;
					goto IL_0678;
				}
				global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
				goto IL_04df;
			}
			gameObject = null;
			num8 = 0;
			break;
			IL_0678:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v609 @ X0_v38] (should have been resolved before IL gen)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X23_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
			text4 = (string)0;
			nint num9 = (nint)component;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+130]");
			nint num10 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X1_v10 (System.String)+130]");
			if (num10 >= 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v116 @ X1_v10 (System.String)+130]");
				int num11 = (int)((nint)0 << 3);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v621 @ X8_v24 (Il2CppClass<UnityEngine.Component>)+C8]");
				object obj18 = (nint)0 + (nint)num11;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v27-8]");
				if (0 == (nint)text4)
				{
					global::UnityEngine.GameObject gameObject2 = component.gameObject;
					if ((object)gameObject2 != null)
					{
						string text5 = gameObject2.name;
						bool flag3 = text5 == name;
						bool flag4 = !flag3;
						text = null;
						if (!flag4)
						{
							global::UnityEngine.GameObject gameObject3 = component.gameObject;
							text2 = null;
							gameObject = gameObject3;
							num8 = 0;
							break;
						}
						continue;
					}
					global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
					goto IL_04df;
				}
			}
			global::System.InvalidCastException ex4 = new global::System.InvalidCastException();
			goto IL_04df;
			IL_04df:
			obj19 = obj;
			obj20 = obj3;
			num12 = 0;
			throw new global::System.NullReferenceException();
			IL_0203:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			text3 = (string)1;
			goto IL_0678;
			IL_00fc:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			text2 = null;
			goto IL_0616;
		}
		object obj21 = obj3;
		object obj22 = obj;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X22_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
		text4 = (string)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
		object obj23 = default(object);
		obj22 = obj23;
		bool flag5 = obj23 == null;
		object obj24 = obj;
		object obj25 = obj3;
		num12 = 0;
		text3 = text2;
		obj19 = obj;
		obj20 = obj3;
		num12 = 0;
		object obj26 = obj2;
		global::UnityEngine.GameObject result = gameObject;
		int num13 = num8;
		if (!flag5)
		{
			goto IL_03b8;
		}
		goto IL_0745;
		IL_03b8:
		object obj27 = obj23;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v8+12E]");
		object obj28 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v8+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0456;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v8+B0]");
		object obj29 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X10_v9-8]");
			if (0 == (nint)obj2)
			{
				break;
			}
			obj29 = (nint)obj29 + 16;
			object obj30 = (nint)obj28 - 1;
			bool flag6 = (nint)obj28 != 1;
			obj28 = obj30;
			if (flag6)
			{
				continue;
			}
			goto IL_0456;
		}
		int num14 = obj29 << 4;
		object obj31 = (nint)obj27 + num14;
		object obj32 = (nint)obj31 + 312;
		text3 = text2;
		goto IL_0799;
		IL_0799:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v618 @ X0_v20+8]");
		text4 = (string)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v618 @ X0_v20] (should have been resolved before IL gen)");
		obj19 = obj24;
		obj20 = obj25;
		obj26 = obj2;
		result = gameObject;
		num13 = num8;
		goto IL_0745;
		IL_0745:
		object obj33 = default(object);
		global::UnityEngine.GameObject result2 = default(global::UnityEngine.GameObject);
		while (true)
		{
			bool flag7 = num13 == 0;
			bool flag8 = !flag7;
			obj2 = obj26;
			if (!flag8)
			{
				return result;
			}
			global::System.OutOfMemoryException ex5 = new global::System.OutOfMemoryException();
			if ((nint)text4 == 1)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
				num8 = (int)obj33;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
				text4 = (string)obj26;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
				obj19 = obj23;
				bool flag9 = obj23 == null;
				bool flag10 = !flag9;
				text2 = text3;
				obj24 = obj19;
				obj25 = obj20;
				num12 = (int)obj33;
				gameObject = null;
				if (flag10)
				{
					break;
				}
				num12 = (int)obj33;
				obj26 = obj26;
				result = null;
				num13 = (int)obj33;
				continue;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF079C");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
			return result2;
		}
		goto IL_03b8;
		IL_0456:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		text3 = null;
		goto IL_0799;
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
		//IL_0055: Expected O, but got I
		if (!_muted)
		{
			int num = 48;
		}
		else
		{
			int num = 40;
		}
		global::UnityEngine.UI.Image mutedBtnImg = _mutedBtnImg;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [this @ X0 (Menu)+v55 @ X8_v4 (System.Int32)]");
		mutedBtnImg.sprite = (global::UnityEngine.Sprite)0;
		_bgMusic.mute = _muted;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000090")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8EC4", Offset = "0xFD8EC4", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xF48;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv50 = v49 + 0xAD0;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A8F2]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+AD0])();\n\tSystem.Collections.Generic.Stack`1<UnityEngine.GameObject>::.ctor(v48);\n\tv54 = this + 0x68;\n\tthis._pagesStack = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Menu()
	{
		//IL_000e: Expected I, but got O
		//IL_0031: Expected O, but got I
		nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
		global::System.Collections.Generic.Stack<global::UnityEngine.GameObject> pagesStack = new global::System.Collections.Generic.Stack<global::UnityEngine.GameObject>();
		object obj = (nint)this + 104;
		_pagesStack = pagesStack;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		base._002Ector();
	}
}
