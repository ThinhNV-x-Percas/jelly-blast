[global::Cpp2ILInjected.Token(Token = "0x2000021")]
public class FBWindowsGraphAPIManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400008D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x400008E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.UI.InputField QueryText;

	[global::Cpp2ILInjected.Token(Token = "0x400008F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.UI.Dropdown QueryType;

	[global::Cpp2ILInjected.Token(Token = "0x4000090")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.UI.InputField GraphAPIVersionText;

	[global::Cpp2ILInjected.Token(Token = "0x4000091")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::UnityEngine.UI.Text GraphAPIVersion;

	[global::Cpp2ILInjected.Token(Token = "0x4000092")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::System.Collections.Generic.IDictionary<string, string> formData;

	[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDE6C8", Offset = "0xFDE6C8", Length = "0x58")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv17 = \"system.security.cryptography.des\";\n\tv18 = v17 + 0xC48;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A920]) = v37;\nL_0015:\n\tv40 = \"system.security.cryptography.des\";\n\tUnityEngine.UI.InputField::set_text(this.GraphAPIVersionText, *([v40 @ X8_v3 (System.String)+C48]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 23 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		//IL_0025: Expected O, but got I
		string text = "system.security.cryptography.des";
		global::UnityEngine.UI.InputField graphAPIVersionText = GraphAPIVersionText;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3 (System.String)+C48]");
		graphAPIVersionText.text = (string)0;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDE720", Offset = "0xFDE720", Length = "0x110")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv20 = *([302A921]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0043;\n\tv74 = this.GraphAPIVersion;\n\tv23 = *([v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv25 = *([v23 @ X0_v28+E0]) == 0;\n\tif (v25) goto L_FFFFFFFF;\nL_0018:\n\tgoto L_0019;\nL_0019:\n\tv76 = Il2CppFieldInfo;\n\tv78 = Il2CppFieldInfo;\n\tv93 = *([v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tgoto L_0024;\n\tv92 = \"il2cpp_codegen_runtime_class_init\"(v80, methodInfo, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv94 = *([v19 @ X20_v2]);\nL_0024:\n\tv95 = *([v93 @ X0_v19+B8]);\n\tv100 = System.String::Concat(*([v76 @ X21_v5 (Il2CppFieldInfo)+DE8]), *([v95 @ X8_v10+20]), *([v78 @ X22_v1 (Il2CppFieldInfo)+AC0]));\n\tv105 = *([v74 @ X19_v5 (UnityEngine.UI.Text)]);\n\tv106 = *([v105 @ X8_v11 (Il2CppClass<UnityEngine.UI.Text>)+5E8]);\n\tv107 = *([v105 @ X8_v11 (Il2CppClass<UnityEngine.UI.Text>)+5F0]);\n\t// 56 IndirectJump v106 @ X3_v2, v74 @ X19_v5 (UnityEngine.UI.Text), v74 @ X19_v5 (UnityEngine.UI.Text), v100 @ X0_v21 (System.String), v107 @ X2_v2, v106 @ X3_v2, v32 @ X4, v33 @ X5, v34 @ X6, v35 @ X7, v36 @ V0, v37 @ V1, v38 @ V2, v39 @ V3, v40 @ V4, v41 @ V5, v42 @ V6, v43 @ V7\nL_0043:\n\t*([v16 @ X21_v1+921]) = 1;\n\tv74 = this.GraphAPIVersion;\n\tv45 = *([v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv102 = *([v45 @ X0_v16+E0]) == 0;\n\tv47 = ~v102;\n\tif (v47) goto L_0018;\n\tgoto L_0019;\n\tv86 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv87 = v86 + 0x1F0;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, methodInfo, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv70 = 1;\n\t*([2DD441E]) = v70;\n\tgoto L_0019;\n\tthrow System.NullReferenceException;\n\treturn;\n// 51 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnEnable()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_010b: Expected O, but got I
		//IL_0064: Expected O, but got I
		//IL_00b4: Expected O, but got I
		//IL_0162: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_018b: Expected O, but got I
		//IL_00c1: Expected I, but got O
		//IL_00d1: Expected O, but got I
		//IL_00e1: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A921]");
		if ((int)((nint)0 & (nint)1) == 0)
		{
			goto IL_00eb;
		}
		global::UnityEngine.UI.Text text = GraphAPIVersion;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v28+E0]");
		bool flag = (nint)0 == 0;
		global::UnityEngine.UI.Text graphAPIVersion = GraphAPIVersion;
		if (!flag)
		{
			goto IL_0098;
		}
		goto IL_0145;
		IL_0145:
		text = graphAPIVersion;
		goto IL_0098;
		IL_0098:
		nint num2 = 0;
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v93 @ X0_v19+B8]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v76 @ X21_v5 (Il2CppFieldInfo)+DE8]");
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v95 @ X8_v10+20]");
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X22_v1 (Il2CppFieldInfo)+AC0]");
		string text2 = (string)num4 + (string)num5 + (string)0;
		nint num6 = (nint)text;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v11 (Il2CppClass<UnityEngine.UI.Text>)+5E8]");
		object obj5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v105 @ X8_v11 (Il2CppClass<UnityEngine.UI.Text>)+5F0]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v106 @ X3_v2 (should have been resolved before IL gen)");
		goto IL_00eb;
		IL_00eb:
		_ = 1;
		text = GraphAPIVersion;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v16+E0]");
		bool flag2 = (nint)0 == 0;
		bool flag3 = !flag2;
		graphAPIVersion = GraphAPIVersion;
		if (flag3)
		{
			goto IL_0098;
		}
		goto IL_0145;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDE830", Offset = "0xFDE830", Length = "0x1FC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302A000;\n\tv23 = 0x2E14000 + 0xB38;\n\tv24 = System.Net.Configuration.SettingsSectionInternal;\n\tv26 = *([302A922]) & 1;\n\tv27 = v26 == 0;\n\tif (v27) goto L_003B;\n\tv56 = *([v23 @ X22_v2 (System.Int32)]);\n\tv29 = *([v24 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B78]);\n\tv31 = *([v29 @ X0_v54+E0]) == 0;\n\tif (v31) goto L_0045;\nL_001B:\n\tv60 = System.Type::GetTypeFromHandle(v56);\n\tv80 = this.QueryType;\n\tv71 = this.QueryType == 0;\n\tv72 = ~v71;\n\tif (v72) goto L_004B;\n\tgoto L_00A2;\nL_003B:\n\t*([v20 @ X20_v1+922]) = 1;\n\tv56 = *([v23 @ X22_v2 (System.Int32)]);\n\tv51 = *([v24 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B78]);\n\tv227 = *([v51 @ X0_v49+E0]) == 0;\n\tv53 = ~v227;\n\tif (v53) goto L_001B;\nL_0045:\n\tv75 = System.Type::GetTypeFromHandle(v64);\n\tv80 = this.QueryType;\nL_004B:\n\tv88 = UnityEngine.UI.Dropdown::get_options(v80);\n\tv143 = this.QueryType;\n\tv131 = System.Collections.Generic.List`1<UnityEngine.UI.Dropdown+OptionData>::get_Item(v88, v143.m_Value);\n\tgoto L_0064;\n\tv228 = \"il2cpp_codegen_runtime_class_init\"(v223, v127, v120, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\nL_0064:\n\tv132 = System.Enum::Parse(v85, v131.m_Text);\n\tv231 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv129 = *([v231 @ X8_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+770]);\n\tv233 = *([v132 @ X0_v11 (System.Object)]);\n\tv94 = *([v233 @ X8_v11 (Il2CppClass<System.Object>)+40]) != *([v129 @ X1_v7+40]);\n\tif (v94) goto L_00A3;\n\tv133 = \"il2cpp_vm_object_unbox\"(v132, v129, 0, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\n\tv145 = this.QueryText;\n\tv235 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv236 = Il2CppMethodInfo;\n\tv243 = new *([v235 @ X9_v6 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CB0])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v243, this, *([v236 @ X23_v1 (Il2CppMethodInfo)+290]), 0);\n\tgoto L_00A0;\n\tv251 = \"il2cpp_codegen_runtime_class_init\"(v249, v246, v245, v247, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49);\nL_00A0:\n\tFacebook.Unity.FB::API(v145.m_Text, *([v133 @ X0_v12]), v243, this.formData);\n\treturn;\nL_00A2:\n\tv147 = new System.NullReferenceException();\nL_00A3:\n\tthrow System.InvalidCastException;\n// 118 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void GraphAPI()
	{
		//IL_0009: Expected O, but got I4
		//IL_0026: Expected I, but got O
		//IL_00fa: Expected O, but got I4
		//IL_010a: Expected O, but got I
		//IL_0134: Expected O, but got I4
		//IL_0061: Expected O, but got I4
		//IL_0071: Expected O, but got I
		//IL_0090: Expected O, but got I4
		//IL_01d0: Expected I, but got O
		//IL_01e0: Expected O, but got I
		//IL_01e8: Expected I, but got O
		//IL_023e: Expected I, but got O
		//IL_0279: Expected I4, but got O
		object obj = 50503680;
		int num = 48316416 + 2872;
		nint num2 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A922]");
		global::System.RuntimeTypeHandle handle;
		global::System.RuntimeTypeHandle handle2;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			handle = (global::System.RuntimeTypeHandle)num;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B78]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v29 @ X0_v54+E0]");
			bool flag = (nint)0 == 0;
			handle2 = (global::System.RuntimeTypeHandle)num;
			if (!flag)
			{
				goto IL_009e;
			}
		}
		else
		{
			_ = 1;
			handle = (global::System.RuntimeTypeHandle)num;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X21_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+B78]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v49+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			handle2 = (global::System.RuntimeTypeHandle)num;
			if (flag3)
			{
				goto IL_009e;
			}
		}
		global::System.Type typeFromHandle = global::System.Type.GetTypeFromHandle(handle2);
		global::UnityEngine.UI.Dropdown queryType = QueryType;
		global::System.Type enumType = typeFromHandle;
		goto IL_016b;
		IL_0288:
		throw new global::System.InvalidCastException();
		IL_016b:
		global::System.Collections.Generic.List<global::UnityEngine.UI.Dropdown.OptionData> options = queryType.options;
		global::UnityEngine.UI.Dropdown queryType2 = QueryType;
		global::UnityEngine.UI.Dropdown.OptionData optionData = options[queryType2.value];
		object obj4 = global::System.Enum.Parse(enumType, optionData.text);
		nint num3 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v9 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+770]");
		object obj5 = 0;
		nint num4 = (nint)obj4;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v233 @ X8_v11 (Il2CppClass<System.Object>)+40]");
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v129 @ X1_v7+40]");
		if (num5 == 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_unbox\"");
			global::UnityEngine.UI.InputField queryText = QueryText;
			nint num6 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
			nint num7 = 0;
			global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGraphResult> callback = null;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
			object obj6 = default(object);
			global::Facebook.Unity.FB.API(queryText.text, (global::Facebook.Unity.HttpMethod)obj6, callback, formData);
			return;
		}
		goto IL_0288;
		IL_009e:
		global::System.Type typeFromHandle2 = global::System.Type.GetTypeFromHandle(handle);
		queryType = QueryType;
		bool flag4 = (object)QueryType == null;
		bool flag5 = !flag4;
		enumType = typeFromHandle2;
		if (flag5)
		{
			goto IL_016b;
		}
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		goto IL_0288;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDEA2C", Offset = "0xFDEA2C", Length = "0x100")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tv21 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv22 = v21 + 0x1F0;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = Il2CppFieldInfo;\n\tv46 = v45 + 0x960;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A923]) = v42;\nL_0017:\n\tv43 = this.GraphAPIVersionText;\n\tv47 = Il2CppFieldInfo;\n\tv52 = System.String::op_Inequality(v43.m_Text, *([v47 @ X9_v2 (Il2CppFieldInfo)+960]));\n\tv63 = ~v52;\n\tif (v63) goto L_0041;\n\tv61 = this.GraphAPIVersionText;\n\tv97 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv98 = *([v97 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv100 = *([v98 @ X0_v8+E0]) == 0;\n\tif (v100) goto L_0046;\n\tv103 = *([2DD441F]) == 0;\n\tif (v103) goto L_004D;\nL_0030:\n\tv124 = *([v97 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tgoto L_0035;\nL_0035:\n\tv132 = *([v124 @ X0_v18+B8]) + 0x20;\n\t*([v132 @ X0_v20]) = v61.m_Text;\n\tv71 = 0xF3F1B4(v132, v61.m_Text, 0, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0041:\n\tFBWindowsGraphAPIManager::OnEnable(this);\n\treturn;\nL_0046:\n\tv122 = *([2DD441F]) == 0;\n\tv109 = ~v122;\n\tif (v109) goto L_0030;\nL_004D:\n\t*([2DD441F]) = 1;\n\tv124 = *([v97 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tgoto L_0035;\n\tv134 = \"il2cpp_codegen_runtime_class_init\"(v133, v50, v51, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv126 = *([v67 @ X21_v4]);\n\tgoto L_0035;\n\tthrow System.NullReferenceException;\n\treturn;\n// 49 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void SetGraphAPiVersion()
	{
		//IL_0026: Expected O, but got I
		//IL_0060: Expected I, but got O
		//IL_0070: Expected O, but got I
		//IL_00ca: Expected O, but got I
		//IL_00e5: Expected O, but got I
		//IL_014f: Expected O, but got I
		global::UnityEngine.UI.InputField graphAPIVersionText = GraphAPIVersionText;
		nint num = 0;
		string text = graphAPIVersionText.text;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X9_v2 (Il2CppFieldInfo)+960]");
		global::UnityEngine.UI.InputField graphAPIVersionText2;
		object obj2;
		if (text != (string)0)
		{
			graphAPIVersionText2 = GraphAPIVersionText;
			nint num2 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v98 @ X0_v8+E0]");
			if ((nint)0 != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD441F]");
				if ((nint)0 != 0)
				{
					goto IL_00ba;
				}
			}
			else
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD441F]");
				if ((nint)0 != 0)
				{
					goto IL_00ba;
				}
			}
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			obj2 = 0;
			goto IL_00cf;
		}
		goto IL_0102;
		IL_00ba:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v97 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		obj2 = 0;
		goto IL_00cf;
		IL_0102:
		OnEnable();
		return;
		IL_00cf:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X0_v18+B8]");
		object obj3 = (nint)0 + (nint)32;
		obj3 = graphAPIVersionText2.text;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		goto IL_0102;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000DD")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDEB2C", Offset = "0xFDEB2C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsGraphAPIManager()
	{
	}
}
