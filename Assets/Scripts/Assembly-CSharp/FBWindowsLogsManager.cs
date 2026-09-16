[global::Cpp2ILInjected.Token(Token = "0x2000025")]
public class FBWindowsLogsManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400009E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.UI.Text LogText;

	[global::Cpp2ILInjected.Token(Token = "0x400009F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.UI.ScrollRect ScrollView;

	[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE052C", Offset = "0xFE052C", Length = "0x94")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = 0x302A000;\n\tv12 = System.ComponentModel.BooleanConverter;\n\tv14 = *([302A92F]) & 1;\n\tv15 = v14 == 0;\n\tif (v15) goto L_0023;\n\tv45 = \"The specified path is not of a legal form.\" + 0x590;\n\tv18 = *([v12 @ X19_v1 (Il2CppClass<System.ComponentModel.BooleanConverter>)+B98]);\n\tv20 = *([v18 @ X0_v13+E0]) == 0;\n\tif (v20) goto L_0033;\nL_001A:\n\tUnityEngine.Debug::Log(*([v45 @ X20_v6]));\n\treturn;\nL_0023:\n\t*([v10 @ X20_v1+92F]) = 1;\n\tv45 = \"The specified path is not of a legal form.\" + 0x590;\n\tv40 = *([v12 @ X19_v1 (Il2CppClass<System.ComponentModel.BooleanConverter>)+B98]);\n\tv69 = *([v40 @ X0_v10+E0]) == 0;\n\tv42 = ~v69;\n\tif (v42) goto L_001A;\nL_0033:\n\tUnityEngine.Debug::Log(*([v56 @ X20_v2]));\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b5: Expected O, but got Unknown
		//IL_00c5: Expected O, but got I
		//IL_0054: Unknown result type (might be due to invalid IL or missing references)
		//IL_0059: Expected O, but got Unknown
		//IL_0069: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.ComponentModel.BooleanConverter);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A92F]");
		object obj2;
		object message;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			obj2 = "The specified path is not of a legal form." + 1424;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v1 (Il2CppClass<System.ComponentModel.BooleanConverter>)+B98]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X0_v13+E0]");
			bool flag = (nint)0 == 0;
			message = obj2;
			if (!flag)
			{
				goto IL_0096;
			}
		}
		else
		{
			_ = 1;
			obj2 = "The specified path is not of a legal form." + 1424;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X19_v1 (Il2CppClass<System.ComponentModel.BooleanConverter>)+B98]");
			object obj4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X0_v10+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			message = obj2;
			if (flag3)
			{
				goto IL_0096;
			}
		}
		global::UnityEngine.Debug.Log(message);
		return;
		IL_0096:
		global::UnityEngine.Debug.Log(obj2);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC0F8", Offset = "0xFDC0F8", Length = "0xD0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv27 = \"<'width'>\";\n\tv28 = v27 + 0xB0;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, message, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv50 = \"<'width'>\";\n\tv51 = v50 + 0x2B0;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, message, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A930]) = v47;\nL_001D:\n\tv52 = \"<'width'>\";\n\tv54 = \"<'width'>\";\n\tv60 = UnityEngine.UI.Text::get_text(this.LogText);\n\tv65 = System.String::Concat(v60, *([v52 @ X22_v2 (System.String)+2B0]), message, *([v54 @ X23_v2 (System.String)+B0]));\n\tv85 = UnityEngine.UI.Text::set_text(this.LogText, v65);\n\tUnityEngine.UI.ScrollRect::set_verticalNormalizedPosition(this.ScrollView, 0f);\n\tUnityEngine.Canvas::ForceUpdateCanvases();\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 50 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void DebugLog(string message)
	{
		//IL_004b: Expected O, but got I
		//IL_004b: Expected O, but got I
		string text = "<'width'>";
		string text2 = "<'width'>";
		string text3 = LogText.text;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v2 (System.String)+2B0]");
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X23_v2 (System.String)+B0]");
		string text4 = text3 + (string)num + message + (string)0;
		LogText.text = text4;
		ScrollView.verticalNormalizedPosition = 0f;
		global::UnityEngine.Canvas.ForceUpdateCanvases();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC334", Offset = "0xFDC334", Length = "0xD0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv27 = \"<'width'>\";\n\tv28 = v27 + 0x2A8;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, message, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv50 = \"<'width'>\";\n\tv51 = v50 + 0xB0;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, message, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A931]) = v47;\nL_001D:\n\tv52 = \"<'width'>\";\n\tv54 = \"<'width'>\";\n\tv60 = UnityEngine.UI.Text::get_text(this.LogText);\n\tv65 = System.String::Concat(v60, *([v52 @ X22_v2 (System.String)+2A8]), message, *([v54 @ X23_v2 (System.String)+B0]));\n\tv85 = UnityEngine.UI.Text::set_text(this.LogText, v65);\n\tUnityEngine.UI.ScrollRect::set_verticalNormalizedPosition(this.ScrollView, 0f);\n\tUnityEngine.Canvas::ForceUpdateCanvases();\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 50 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void DebugErrorLog(string message)
	{
		//IL_004b: Expected O, but got I
		//IL_004b: Expected O, but got I
		string text = "<'width'>";
		string text2 = "<'width'>";
		string text3 = LogText.text;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v2 (System.String)+2A8]");
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X23_v2 (System.String)+B0]");
		string text4 = text3 + (string)num + message + (string)0;
		LogText.text = text4;
		ScrollView.verticalNormalizedPosition = 0f;
		global::UnityEngine.Canvas.ForceUpdateCanvases();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC974", Offset = "0xFDC974", Length = "0xD0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv27 = \"<'width'>\";\n\tv28 = v27 + 0xB0;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, message, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv50 = \"<'width'>\";\n\tv51 = v50 + 0x2B8;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, message, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A932]) = v47;\nL_001D:\n\tv52 = \"<'width'>\";\n\tv54 = \"<'width'>\";\n\tv60 = UnityEngine.UI.Text::get_text(this.LogText);\n\tv65 = System.String::Concat(v60, *([v52 @ X22_v2 (System.String)+2B8]), message, *([v54 @ X23_v2 (System.String)+B0]));\n\tv85 = UnityEngine.UI.Text::set_text(this.LogText, v65);\n\tUnityEngine.UI.ScrollRect::set_verticalNormalizedPosition(this.ScrollView, 0f);\n\tUnityEngine.Canvas::ForceUpdateCanvases();\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 50 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void DebugWarningLog(string message)
	{
		//IL_004b: Expected O, but got I
		//IL_004b: Expected O, but got I
		string text = "<'width'>";
		string text2 = "<'width'>";
		string text3 = LogText.text;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v2 (System.String)+2B8]");
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X23_v2 (System.String)+B0]");
		string text4 = text3 + (string)num + message + (string)0;
		LogText.text = text4;
		ScrollView.verticalNormalizedPosition = 0f;
		global::UnityEngine.Canvas.ForceUpdateCanvases();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE05EC", Offset = "0xFE05EC", Length = "0x60")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0012;\n\tv17 = Il2CppFieldInfo;\n\tv18 = v17 + 0x960;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A933]) = v37;\nL_0012:\n\tv38 = this.LogText;\n\tv40 = Il2CppFieldInfo;\n\tv42 = *([v40 @ X8_v3 (Il2CppFieldInfo)+960]);\n\tv43 = *([v38 @ X0_v2 (UnityEngine.UI.Text)]);\n\tv44 = *([v43 @ X8_v5 (Il2CppClass<UnityEngine.UI.Text>)+5E8]);\n\tv45 = *([v43 @ X8_v5 (Il2CppClass<UnityEngine.UI.Text>)+5F0]);\n\t// 32 IndirectJump v44 @ X3_v1, v38 @ X0_v2 (UnityEngine.UI.Text), v38 @ X0_v2 (UnityEngine.UI.Text), v42 @ X1_v1, v45 @ X2_v1, v44 @ X3_v1, v23 @ X4, v24 @ X5, v25 @ X6, v26 @ X7, v27 @ V0, v28 @ V1, v29 @ V2, v30 @ V3, v31 @ V4, v32 @ V5, v33 @ V6, v34 @ V7\n\tthrow System.NullReferenceException;\n\treturn;\n// 20 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void DebugClean()
	{
		//IL_001b: Expected O, but got I
		//IL_0023: Expected I, but got O
		//IL_0033: Expected O, but got I
		//IL_0043: Expected O, but got I
		while (true)
		{
			global::UnityEngine.UI.Text logText = LogText;
			nint num = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3 (Il2CppFieldInfo)+960]");
			object obj = 0;
			nint num2 = (nint)logText;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<UnityEngine.UI.Text>)+5E8]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<UnityEngine.UI.Text>)+5F0]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v44 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE05C0", Offset = "0xFE05C0", Length = "0x2C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.UI.ScrollRect::set_verticalNormalizedPosition(this.ScrollView, 0f);\n\tUnityEngine.Canvas::ForceUpdateCanvases();\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void ScrollToTheBottom()
	{
		ScrollView.verticalNormalizedPosition = 0f;
		global::UnityEngine.Canvas.ForceUpdateCanvases();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE064C", Offset = "0xFE064C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsLogsManager()
	{
	}
}
