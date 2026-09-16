[global::Cpp2ILInjected.Token(Token = "0x2000022")]
public class FBWindowsInitManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000093")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDEC04", Offset = "0xFDEC04", Length = "0x170")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302A000;\n\tv22 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv24 = *([302A925]) & 1;\n\tv25 = v24 == 0;\n\tif (v25) goto L_003B;\n\tv26 = *([v22 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv28 = *([v26 @ X0_v38+E0]) == 0;\n\tif (v28) goto L_0043;\nL_0017:\n\tv54 = Facebook.Unity.FB::get_IsInitialized();\n\tv63 = v54 == 0;\n\tif (v63) goto L_0048;\nL_001B:\n\tv73 = *([v22 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv75 = *([v73 @ X0_v31+E0]) == 0;\n\tif (v75) goto L_007E;\n\tFacebook.Unity.FB::ActivateApp();\n\treturn;\nL_003B:\n\t*([v20 @ X20_v1+925]) = 1;\n\tv48 = *([v22 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv123 = *([v48 @ X0_v29+E0]) == 0;\n\tv50 = ~v123;\n\tif (v50) goto L_0017;\nL_0043:\n\tv65 = Facebook.Unity.FB::get_IsInitialized();\n\tv90 = v65 == 0;\n\tv71 = ~v90;\n\tif (v71) goto L_001B;\nL_0048:\n\tv79 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv81 = Il2CppMethodInfo;\n\tv83 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv85 = Il2CppMethodInfo;\n\tv88 = new *([v79 @ X8_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+118])();\n\tFacebook.Unity.InitDelegate::.ctor(v88, this, *([v81 @ X21_v1 (Il2CppMethodInfo)+298]));\n\tv121 = new *([v83 @ X23_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+720])();\n\tFacebook.Unity.HideUnityDelegate::.ctor(v121, this, *([v85 @ X24_v1 (Il2CppMethodInfo)+2A0]));\n\tgoto L_0071;\n\tv158 = \"il2cpp_codegen_runtime_class_init\"(v156, v154, v153, v155, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_0071:\n\tFacebook.Unity.FB::Init(v88, v121, 0);\n\treturn;\nL_007E:\n\tFacebook.Unity.FB::ActivateApp();\n\treturn;\n// 89 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void InitButton()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00f6: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_016a: Expected I, but got O
		//IL_017e: Expected I, but got O
		//IL_00b5: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A925]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v26 @ X0_v38+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X0_v29+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		if (global::Facebook.Unity.FB.IsInitialized)
		{
			goto IL_00a5;
		}
		goto IL_015c;
		IL_00a5:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X22_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v73 @ X0_v31+E0]");
		if ((nint)0 != 0)
		{
			global::Facebook.Unity.FB.ActivateApp();
		}
		else
		{
			global::Facebook.Unity.FB.ActivateApp();
		}
		return;
		IL_015c:
		nint num2 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		nint num3 = 0;
		nint num4 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v81 @ X21_v1 (Il2CppMethodInfo)+298]");
		global::Facebook.Unity.InitDelegate onInitComplete = new global::Facebook.Unity.InitDelegate(this, (global::System.IntPtr)0);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v85 @ X24_v1 (Il2CppMethodInfo)+2A0]");
		global::Facebook.Unity.HideUnityDelegate onHideUnity = new global::Facebook.Unity.HideUnityDelegate(this, (global::System.IntPtr)0);
		global::Facebook.Unity.FB.Init(onInitComplete, onHideUnity);
		return;
		IL_007f:
		if (global::Facebook.Unity.FB.IsInitialized)
		{
			goto IL_00a5;
		}
		goto IL_015c;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDED74", Offset = "0xFDED74", Length = "0x184")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv20 = *([302A926]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0056;\n\tv22 = *([v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv24 = *([v22 @ X0_v41+E0]) == 0;\n\tif (v24) goto L_005E;\nL_0015:\n\tv50 = Facebook.Unity.FB::get_IsInitialized();\n\tv69 = this.Logger;\n\tv59 = ~v50;\n\tif (v59) goto L_0065;\nL_001D:\n\tgoto L_0020;\n\tv84 = \"il2cpp_codegen_runtime_class_init\"(v71, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\nL_0020:\n\tv87 = Facebook.Unity.FB::get_FacebookImpl();\n\tv154 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv157 = *([v87 @ X0_v26 (Facebook.Unity.IFacebook)]);\n\tv232 = *([v157 @ X8_v13 (Il2CppClass<Facebook.Unity.IFacebook>)+12E]);\n\tv159 = *([v157 @ X8_v13 (Il2CppClass<Facebook.Unity.IFacebook>)+12E]) == 0;\n\tif (v159) goto L_0047;\n\tv231 = *([v157 @ X8_v13 (Il2CppClass<Facebook.Unity.IFacebook>)+B0]) + 8;\nL_0032:\n\tv237 = *([v231 @ X10_v6-8]) == *([v154 @ X8_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+AD8]);\n\tif (v237) goto L_0073;\n\tv231 = v231 + 0x10;\n\tv217 = v232 - 1;\n\tv197 = v232 != 1;\n\tif (v197) goto L_0032;\nL_0047:\n\tv249 = 0xF7087C(v87, *([v154 @ X8_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+AD8]), 3, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_007A;\nL_0056:\n\t*([302A926]) = 1;\n\tv44 = *([v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv153 = *([v44 @ X0_v21+E0]) == 0;\n\tv46 = ~v153;\n\tif (v46) goto L_0015;\nL_005E:\n\tv61 = Facebook.Unity.FB::get_IsInitialized();\n\tv69 = this.Logger;\n\tv80 = ~v61;\n\tv67 = ~v80;\n\tif (v67) goto L_001D;\nL_0065:\n\tv88 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tFBWindowsLogsManager::DebugErrorLog(v78, *([v88 @ X8_v4 (System.String)+350]));\n\treturn;\nL_0073:\n\tv244 = *([v231 @ X10_v6]) + 3;\n\tv245 = v244 << 4;\n\tv246 = v157 + v245;\n\tv249 = v246 + 0x138;\nL_007A:\n\t*([v249 @ X0_v27])(v254, v87, *([v249 @ X0_v27+8]), 3, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv255 = \"Parent table name is missing in relation '{0}'.\";\n\tv142 = System.String::Concat(*([v255 @ X8_v16 (System.String)+DF8]), v254);\n\tFBWindowsLogsManager::DebugLog(v69, v142);\n\tFacebook.Unity.FB::ActivateApp();\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 93 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void InitCallback()
	{
		//IL_000e: Expected I, but got O
		//IL_0190: Expected O, but got I
		//IL_0051: Expected O, but got I
		//IL_0224: Expected O, but got I
		//IL_00cd: Expected I, but got O
		//IL_00d5: Expected I, but got O
		//IL_00e5: Expected O, but got I
		//IL_02d0: Expected O, but got I
		//IL_0120: Expected O, but got I
		//IL_022e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0233: Expected O, but got Unknown
		//IL_0250: Expected O, but got I
		//IL_025f: Expected O, but got I
		//IL_0134: Expected O, but got I
		//IL_0143: Expected O, but got I
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A926]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v41+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v21+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		bool isInitialized = global::Facebook.Unity.FB.IsInitialized;
		FBWindowsLogsManager logger = Logger;
		bool flag = !isInitialized;
		bool flag2 = !flag;
		FBWindowsLogsManager logger2 = Logger;
		if (flag2)
		{
			goto IL_00b1;
		}
		goto IL_0206;
		IL_02a8:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v249 @ X0_v27] (should have been resolved before IL gen)");
		string text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v16 (System.String)+DF8]");
		string text2 = default(string);
		string message = (string)0 + text2;
		logger.DebugLog(message);
		global::Facebook.Unity.FB.ActivateApp();
		return;
		IL_016b:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		goto IL_02a8;
		IL_00b1:
		global::Facebook.Unity.IFacebook facebookImpl = global::Facebook.Unity.FB.FacebookImpl;
		nint num2 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num3 = (nint)facebookImpl;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v13 (Il2CppClass<Facebook.Unity.IFacebook>)+12E]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v13 (Il2CppClass<Facebook.Unity.IFacebook>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_016b;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v157 @ X8_v13 (Il2CppClass<Facebook.Unity.IFacebook>)+B0]");
		object obj4 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X10_v6-8]");
			nint num4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v154 @ X8_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+AD8]");
			if (num4 == 0)
			{
				break;
			}
			obj4 = (nint)obj4 + 16;
			object obj5 = (nint)obj3 - 1;
			bool flag3 = (nint)obj3 != 1;
			obj3 = obj5;
			if (flag3)
			{
				continue;
			}
			goto IL_016b;
		}
		object obj6 = obj4 + 3;
		int num5 = (int)((nint)obj6 << 4);
		object obj7 = num3 + num5;
		object obj8 = (nint)obj7 + 312;
		goto IL_02a8;
		IL_0076:
		bool isInitialized2 = global::Facebook.Unity.FB.IsInitialized;
		logger = Logger;
		bool flag4 = !isInitialized2;
		logger2 = Logger;
		if (!flag4)
		{
			goto IL_00b1;
		}
		goto IL_0206;
		IL_0206:
		string text3 = "Expected ComplexType. Schema was not generated using this tool.";
		FBWindowsLogsManager fBWindowsLogsManager = logger2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X8_v4 (System.String)+350]");
		fBWindowsLogsManager.DebugErrorLog((string)0);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDEEF8", Offset = "0xFDEEF8", Length = "0x18")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv5 = isGameShown == 0;\n\tv12 = ~v5;\n\tv13 = ~v12;\n\tif (v13) goto L_FFFFFFFF;\n\tgoto L_0013;\nL_0013:\n\tUnityEngine.Time::set_timeScale(v16);\n\treturn;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnHideUnity(bool isGameShown)
	{
		float timeScale = ((!isGameShown) ? 0f : 1f);
		global::UnityEngine.Time.timeScale = timeScale;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDEF10", Offset = "0xFDEF10", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsInitManager()
	{
	}
}
