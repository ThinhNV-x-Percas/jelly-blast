[global::Cpp2ILInjected.Token(Token = "0x2000018")]
public class FBWindowsA2UNotificationsManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000075")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x4000076")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.UI.InputField TitleText;

	[global::Cpp2ILInjected.Token(Token = "0x4000077")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.UI.InputField BodyText;

	[global::Cpp2ILInjected.Token(Token = "0x4000078")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.UI.InputField MediaText;

	[global::Cpp2ILInjected.Token(Token = "0x4000079")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::UnityEngine.UI.InputField PayloadText;

	[global::Cpp2ILInjected.Token(Token = "0x400007A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public global::UnityEngine.UI.InputField TimeIntervalText;

	[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDBF88", Offset = "0xFDBF88", Length = "0x170")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0029;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0x270;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv57 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv58 = v57 + 0x1F0;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv99 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv100 = v99 + 0xD20;\n\tv101 = \"il2cpp_codegen_initialize_runtime_metadata\"(v100, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv102 = System.Net.Configuration.SettingsSectionInternal;\n\tv103 = v102 + 0xF20;\n\tv104 = \"il2cpp_codegen_initialize_runtime_metadata\"(v103, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv151 = \"Parent table name is missing in relation '{0}'.\";\n\tv152 = v151 + 0xFA0;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v152, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302A90C]) = v54;\nL_0029:\n\tv60 = \"Parent table name is missing in relation '{0}'.\";\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v60 @ X8_v4 (System.String)+FA0]));\n\tv93 = this.TitleText;\n\tv79 = this.BodyText;\n\tv76 = this.MediaText;\n\tv153 = System.Net.Configuration.SettingsSectionInternal;\n\tv84 = new *([v153 @ X11_v2 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F20])();\n\tSystem.Uri::.ctor(v84, v76.m_Text);\n\tv94 = this.TimeIntervalText;\n\tv85 = System.Int32::Parse(v94.m_Text);\n\tv95 = this.PayloadText;\n\tv157 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv158 = Il2CppMethodInfo;\n\tv164 = new *([v157 @ X9_v3 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+D20])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v164, this, *([v158 @ X26_v1 (Il2CppMethodInfo)+270]), 0);\n\tgoto L_0073;\n\tv171 = \"il2cpp_codegen_runtime_class_init\"(v169, v167, v166, v168, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\nL_0073:\n\tFacebook.Unity.FB::ScheduleAppToUserNotification(v93.m_Text, v79.m_Text, v84, v85, v95.m_Text, v164);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 80 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ScheduleButton()
	{
		//IL_0025: Expected O, but got I
		//IL_0060: Expected I, but got O
		//IL_00b6: Expected I, but got O
		string text = "Parent table name is missing in relation '{0}'.";
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v60 @ X8_v4 (System.String)+FA0]");
		logger.DebugLog((string)0);
		global::UnityEngine.UI.InputField titleText = TitleText;
		global::UnityEngine.UI.InputField bodyText = BodyText;
		global::UnityEngine.UI.InputField mediaText = MediaText;
		nint num = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		global::System.Uri media = new global::System.Uri(mediaText.text);
		global::UnityEngine.UI.InputField timeIntervalText = TimeIntervalText;
		int timeInterval = int.Parse(timeIntervalText.text);
		global::UnityEngine.UI.InputField payloadText = PayloadText;
		nint num2 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num3 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IScheduleAppToUserNotificationResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FB.ScheduleAppToUserNotification(titleText.text, bodyText.text, media, timeInterval, payloadText.text, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC1C8", Offset = "0xFDC1C8", Length = "0x16C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv23 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv24 = v23 + 0xDF8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, result, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = \"Min\";\n\tv46 = v45 + 0x8C0;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, result, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A90D]) = v43;\nL_001A:\n\tv47 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv50 = result->klass;\n\tv183 = result->klass->rank;\n\tv52 = *([v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+12E]) == 0;\n\tif (v52) goto L_003D;\n\tv182 = *([v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+B0]) + 8;\nL_0028:\n\tv188 = *([v182 @ X10_v13-8]) == *([v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v188) goto L_0070;\n\tv182 = v182 + 0x10;\n\tv168 = v183 - 1;\n\tv148 = v183 != 1;\n\tif (v148) goto L_0028;\nL_003D:\n\tv171 = 0xF7087C(result, *([v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\t*([v171 @ X0_v17])(v196, result, *([v171 @ X0_v17+8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv140 = this.Logger;\n\tv198 = v196 == 0;\n\tif (v198) goto L_007D;\nL_0046:\n\tv285 = result->klass;\n\tv314 = result->klass->rank;\n\tv287 = *([v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+12E]) == 0;\n\tif (v287) goto L_0066;\n\tv115 = *([v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+B0]) + 8;\nL_0051:\n\tv95 = *([v115 @ X10_v8-8]) == *([v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v95) goto L_008B;\n\tv115 = v115 + 0x10;\n\tv301 = v314 - 1;\n\tv291 = v314 != 1;\n\tif (v291) goto L_0051;\nL_0066:\n\tv303 = 0xF7087C(result, *([v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\t*([v303 @ X0_v10])(v323, result, *([v303 @ X0_v10+8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv317 = v140 == 0;\n\tv131 = ~v317;\n\tif (v131) goto L_009D;\n\tgoto L_009F;\nL_0070:\n\tv258 = *([v182 @ X10_v13]) << 4;\n\tv259 = v50 + v258;\n\tv260 = v259 + 0x138;\n\t*([v260 @ X0_v20])(v264, result, *([v260 @ X0_v20+8]), v210, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv140 = this.Logger;\n\tv266 = v264 == 0;\n\tv267 = ~v266;\n\tif (v267) goto L_0046;\nL_007D:\n\tv304 = \"Min\";\n\tFBWindowsLogsManager::DebugLog(v141, *([v304 @ X8_v6 (System.String)+8C0]));\n\treturn;\nL_008B:\n\tv61 = *([v115 @ X10_v8]) << 4;\n\tv319 = v285 + v61;\n\tv320 = v319 + 0x138;\n\t*([v320 @ X0_v13])(v323, result, *([v320 @ X0_v13+8]), v210, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_009D:\n\tFBWindowsLogsManager::DebugErrorLog(v140, v323);\n\treturn;\nL_009F:\n\tthrow System.NullReferenceException;\n// 100 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void A2UNotificationCallback(global::Facebook.Unity.IScheduleAppToUserNotificationResult result)
	{
		//IL_0013: Expected I, but got O
		//IL_001b: Expected I, but got O
		//IL_002b: Expected O, but got I
		//IL_00e3: Expected I, but got O
		//IL_0270: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_0104: Expected I, but got O
		//IL_0114: Expected O, but got I
		//IL_01cd: Expected I, but got O
		//IL_01ee: Expected I4, but got O
		//IL_01fc: Expected O, but got I
		//IL_020b: Expected O, but got I
		//IL_014f: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_027f: Expected I4, but got O
		//IL_028d: Expected O, but got I
		//IL_029c: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_0172: Expected O, but got I
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00b1;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v13-8]");
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
			if (num3 == 0)
			{
				break;
			}
			obj2 = (nint)obj2 + 16;
			object obj3 = (nint)obj - 1;
			bool flag = (nint)obj != 1;
			obj = obj3;
			if (flag)
			{
				continue;
			}
			goto IL_00b1;
		}
		int num4 = obj2 << 4;
		object obj4 = num2 + num4;
		object obj5 = (nint)obj4 + 312;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X0_v20] (should have been resolved before IL gen)");
		FBWindowsLogsManager logger = Logger;
		object obj6 = default(object);
		bool flag2 = obj6 == null;
		bool flag3 = !flag2;
		FBWindowsLogsManager logger2 = Logger;
		if (flag3)
		{
			goto IL_00fc;
		}
		goto IL_0252;
		IL_0252:
		string text = "Min";
		FBWindowsLogsManager fBWindowsLogsManager = logger2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v6 (System.String)+8C0]");
		fBWindowsLogsManager.DebugLog((string)0);
		return;
		IL_00fc:
		nint num5 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+12E]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_019a;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IScheduleAppToUserNotificationResult>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X10_v8-8]");
			nint num6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
			if (num6 == 0)
			{
				break;
			}
			obj8 = (nint)obj8 + 16;
			object obj9 = (nint)obj7 - 1;
			bool flag4 = (nint)obj7 != 1;
			obj7 = obj9;
			if (flag4)
			{
				continue;
			}
			goto IL_019a;
		}
		int num7 = obj8 << 4;
		object obj10 = num5 + num7;
		object obj11 = (nint)obj10 + 312;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v320 @ X0_v13] (should have been resolved before IL gen)");
		goto IL_02ab;
		IL_019a:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v10] (should have been resolved before IL gen)");
		bool flag5 = (object)logger == null;
		bool flag6 = !flag5;
		nint num8 = unchecked((nint)null);
		if (!flag6)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_02ab;
		IL_02ab:
		string message = default(string);
		logger.DebugErrorLog(message);
		return;
		IL_00b1:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ X0_v17] (should have been resolved before IL gen)");
		logger = Logger;
		object obj12 = default(object);
		bool flag7 = obj12 == null;
		num8 = unchecked((nint)null);
		logger2 = Logger;
		if (!flag7)
		{
			goto IL_00fc;
		}
		goto IL_0252;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDC404", Offset = "0xFDC404", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsA2UNotificationsManager()
	{
	}
}
