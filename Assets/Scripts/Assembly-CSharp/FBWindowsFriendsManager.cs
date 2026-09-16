[global::Cpp2ILInjected.Token(Token = "0x200001F")]
public class FBWindowsFriendsManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000087")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x4000088")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.Transform ReceivedInvitationsPanelTransform;

	[global::Cpp2ILInjected.Token(Token = "0x4000089")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.GameObject ShowReceivedInvitation;

	[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDD350", Offset = "0xFDD350", Length = "0x128")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv20 = *([302A91A]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_003F;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv24 = *([v22 @ X0_v31+E0]) == 0;\n\tif (v24) goto L_0047;\nL_0015:\n\tv50 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv58 = ~v50;\n\tif (v58) goto L_004E;\nL_0018:\n\tv68 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv71 = new *([v68 @ X8_v9 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CA8])();\n\tv82 = Il2CppMethodInfo;\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v71, this, *([v82 @ X8_v11 (Il2CppMethodInfo)+288]), 0);\n\tv99 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv101 = *([v99 @ X0_v24+E0]) == 0;\n\tif (v101) goto L_0064;\n\tFacebook.Unity.FB::OpenFriendFinderDialog(v71);\n\treturn;\nL_003F:\n\t*([v16 @ X20_v1+91A]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv98 = *([v44 @ X0_v20+E0]) == 0;\n\tv46 = ~v98;\n\tif (v46) goto L_0015;\nL_0047:\n\tv60 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv77 = ~v60;\n\tv66 = ~v77;\n\tif (v66) goto L_0018;\nL_004E:\n\tv87 = \"IsCyrillic\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v87 @ X8_v3 (System.String)+A68]));\n\treturn;\nL_0064:\n\tFacebook.Unity.FB::OpenFriendFinderDialog(v71);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 68 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Button_OpenReceivedInvitations()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_011e: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_00af: Expected I, but got O
		//IL_00d9: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A91A]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v31+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v20+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		if (global::Facebook.Unity.FB.IsLoggedIn)
		{
			goto IL_00a1;
		}
		goto IL_0180;
		IL_00a1:
		nint num2 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IGamingServicesFriendFinderResult> callback = null;
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v24+E0]");
		if ((nint)0 != 0)
		{
			global::Facebook.Unity.FB.OpenFriendFinderDialog(callback);
		}
		else
		{
			global::Facebook.Unity.FB.OpenFriendFinderDialog(callback);
		}
		return;
		IL_0180:
		string text = "IsCyrillic";
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v3 (System.String)+A68]");
		logger.DebugWarningLog((string)0);
		return;
		IL_007f:
		if (global::Facebook.Unity.FB.IsLoggedIn)
		{
			goto IL_00a1;
		}
		goto IL_0180;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDD478", Offset = "0xFDD478", Length = "0x16C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv23 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv24 = v23 + 0xDF8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, result, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv46 = v45 + 0x7B0;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, result, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A91B]) = v43;\nL_001A:\n\tv47 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv50 = result->klass;\n\tv183 = result->klass->rank;\n\tv52 = *([v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+12E]) == 0;\n\tif (v52) goto L_003D;\n\tv182 = *([v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+B0]) + 8;\nL_0028:\n\tv188 = *([v182 @ X10_v13-8]) == *([v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v188) goto L_0070;\n\tv182 = v182 + 0x10;\n\tv168 = v183 - 1;\n\tv148 = v183 != 1;\n\tif (v148) goto L_0028;\nL_003D:\n\tv171 = 0xF7087C(result, *([v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\t*([v171 @ X0_v17])(v196, result, *([v171 @ X0_v17+8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv140 = this.Logger;\n\tv198 = v196 == 0;\n\tif (v198) goto L_007D;\nL_0046:\n\tv285 = result->klass;\n\tv314 = result->klass->rank;\n\tv287 = *([v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+12E]) == 0;\n\tif (v287) goto L_0066;\n\tv115 = *([v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+B0]) + 8;\nL_0051:\n\tv95 = *([v115 @ X10_v8-8]) == *([v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v95) goto L_008B;\n\tv115 = v115 + 0x10;\n\tv301 = v314 - 1;\n\tv291 = v314 != 1;\n\tif (v291) goto L_0051;\nL_0066:\n\tv303 = 0xF7087C(result, *([v47 @ X21_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\t*([v303 @ X0_v10])(v323, result, *([v303 @ X0_v10+8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv317 = v140 == 0;\n\tv131 = ~v317;\n\tif (v131) goto L_009D;\n\tgoto L_009F;\nL_0070:\n\tv258 = *([v182 @ X10_v13]) << 4;\n\tv259 = v50 + v258;\n\tv260 = v259 + 0x138;\n\t*([v260 @ X0_v20])(v264, result, *([v260 @ X0_v20+8]), v210, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv140 = this.Logger;\n\tv266 = v264 == 0;\n\tv267 = ~v266;\n\tif (v267) goto L_0046;\nL_007D:\n\tv304 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tFBWindowsLogsManager::DebugLog(v141, *([v304 @ X8_v6 (System.String)+7B0]));\n\treturn;\nL_008B:\n\tv61 = *([v115 @ X10_v8]) << 4;\n\tv319 = v285 + v61;\n\tv320 = v319 + 0x138;\n\t*([v320 @ X0_v13])(v323, result, *([v320 @ X0_v13+8]), v210, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_009D:\n\tFBWindowsLogsManager::DebugErrorLog(v140, v323);\n\treturn;\nL_009F:\n\tthrow System.NullReferenceException;\n// 100 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OpenFriendsDialogCallBack(global::Facebook.Unity.IGamingServicesFriendFinderResult result)
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
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00b1;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+B0]");
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
		string text = "Expected ComplexType. Schema was not generated using this tool.";
		FBWindowsLogsManager fBWindowsLogsManager = logger2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v6 (System.String)+7B0]");
		fBWindowsLogsManager.DebugLog((string)0);
		return;
		IL_00fc:
		nint num5 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+12E]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_019a;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IGamingServicesFriendFinderResult>)+B0]");
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

	[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDD5E4", Offset = "0xFDD5E4", Length = "0x128")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv20 = *([302A91C]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_003F;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv24 = *([v22 @ X0_v31+E0]) == 0;\n\tif (v24) goto L_0047;\nL_0015:\n\tv50 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv58 = ~v50;\n\tif (v58) goto L_004E;\nL_0018:\n\tv68 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv71 = new *([v68 @ X8_v9 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CA0])();\n\tv82 = Il2CppMethodInfo;\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v71, this, *([v82 @ X8_v11 (Il2CppMethodInfo)+280]), 0);\n\tv99 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv101 = *([v99 @ X0_v24+E0]) == 0;\n\tif (v101) goto L_0064;\n\tFacebook.Unity.FB::GetFriendFinderInvitations(v71);\n\treturn;\nL_003F:\n\t*([v16 @ X20_v1+91C]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv98 = *([v44 @ X0_v20+E0]) == 0;\n\tv46 = ~v98;\n\tif (v46) goto L_0015;\nL_0047:\n\tv60 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv77 = ~v60;\n\tv66 = ~v77;\n\tif (v66) goto L_0018;\nL_004E:\n\tv87 = \"IsCyrillic\";\n\tFBWindowsLogsManager::DebugWarningLog(this.Logger, *([v87 @ X8_v3 (System.String)+A68]));\n\treturn;\nL_0064:\n\tFacebook.Unity.FB::GetFriendFinderInvitations(v71);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 68 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Button_GetFriendFinderInvitations()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_011e: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_01a0: Expected O, but got I
		//IL_00af: Expected I, but got O
		//IL_00d9: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A91C]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v31+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v20+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		if (global::Facebook.Unity.FB.IsLoggedIn)
		{
			goto IL_00a1;
		}
		goto IL_0180;
		IL_00a1:
		nint num2 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IFriendFinderInvitationResult> callback = null;
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X0_v24+E0]");
		if ((nint)0 != 0)
		{
			global::Facebook.Unity.FB.GetFriendFinderInvitations(callback);
		}
		else
		{
			global::Facebook.Unity.FB.GetFriendFinderInvitations(callback);
		}
		return;
		IL_0180:
		string text = "IsCyrillic";
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v3 (System.String)+A68]");
		logger.DebugWarningLog((string)0);
		return;
		IL_007f:
		if (global::Facebook.Unity.FB.IsLoggedIn)
		{
			goto IL_00a1;
		}
		goto IL_0180;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDD70C", Offset = "0xFDD70C", Length = "0xD54")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0063;\n\tv35 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv36 = v35 + 0x1F0;\n\tv37 = \"il2cpp_codegen_initialize_runtime_metadata\"(v36, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0xB28;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv330 = Il2CppMethodInfo;\n\tv331 = v330 + 0xA20;\n\tv332 = \"il2cpp_codegen_initialize_runtime_metadata\"(v331, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv408 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv409 = v408 + 0x6D8;\n\tv410 = \"il2cpp_codegen_initialize_runtime_metadata\"(v409, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv414 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv415 = v414 + 0x9F0;\n\tv416 = \"il2cpp_codegen_initialize_runtime_metadata\"(v415, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv724 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv725 = v724 + 0x880;\n\tv726 = \"il2cpp_codegen_initialize_runtime_metadata\"(v725, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv780 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv781 = v780 + 0x9F0;\n\tv782 = \"il2cpp_codegen_initialize_runtime_metadata\"(v781, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv868 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv869 = v868 + 0xA90;\n\tv870 = \"il2cpp_codegen_initialize_runtime_metadata\"(v869, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv880 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv881 = v880 + 0xB28;\n\tv882 = \"il2cpp_codegen_initialize_runtime_metadata\"(v881, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv985 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv986 = v985 + 0xDF8;\n\tv987 = \"il2cpp_codegen_initialize_runtime_metadata\"(v986, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1038 = Il2CppMethodInfo;\n\tv1039 = v1038 + 0x58;\n\tv1040 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1039, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1073 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv1074 = v1073 + 0xFD8;\n\tv1075 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1074, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1104 = CollectParticleData[];\n\tv1105 = v1104 + 0x540;\n\tv1106 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1105, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1169 = System.Net.Configuration.SettingsSectionInternal;\n\tv1170 = v1169 + 0xAA8;\n\tv1171 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1170, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1221 = Il2CppMethodInfo;\n\tv1222 = v1221 + 0xBE0;\n\tv1223 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1222, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1253 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv1254 = v1253 + 0xA78;\n\tv1255 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1254, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1294 = System.Net.Configuration.SettingsSectionInternal;\n\tv1295 = v1294 + 0xE60;\n\tv1296 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1295, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1342 = \"IsCyrillic\";\n\tv1343 = v1342 + 0xA68;\n\tv1344 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1343, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1385 = \"Min\";\n\tv1386 = v1385 + 0x640;\n\tv1387 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1386, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1422 = Il2CppFieldInfo;\n\tv1423 = v1422 + 0xAE8;\n\tv1424 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1423, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1442 = \"<'width'>\";\n\tv1443 = v1442 + 0xEF0;\n\tv1444 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1443, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1476 = Il2CppFieldInfo;\n\tv1477 = v1476 + 0xAE0;\n\tv1478 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1477, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1507 = Il2CppFieldInfo;\n\tv1508 = v1507 + 0xAD8;\n\tv1509 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1508, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1564 = \"Parent table name is missing in relation '{0}'.\";\n\tv1565 = v1564 + 0x3E8;\n\tv1566 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1565, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv1597 = Il2CppFieldInfo;\n\tv1598 = v1597 + 0xAF0;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1598, receivedInvitations, methodInfo, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51);\n\tv55 = 1;\n\t*([302A91D]) = v55;\nL_0063:\n\tv56 = 0;\n\tv64 = \"Parent table name is missing in relation '{0}'.\";\n\tv66 = UnityEngine.UIElements.EnumFieldHelpers;\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v64 @ X8_v19 (System.String)+3E8]));\n\tv333 = *([v66 @ X21_v13 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]);\n\tv334 = *([v333 @ X0_v32+E0]) == 0;\n\tif (v334) goto L_007B;\n\tv412 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv417 = ~v412;\n\tv418 = ~v417;\n\tif (v418) goto L_0082;\n\tgoto L_0482;\nL_007B:\n\tv420 = Facebook.Unity.FB::get_IsLoggedIn();\n\tv729 = ~v420;\n\tif (v729) goto L_0482;\nL_0082:\n\tv825 = UnityEngine.Transform::GetEnumerator(this.ReceivedInvitationsPanelTransform);\n\tv877 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv878 = System.Net.Configuration.SettingsSectionInternal;\n\tgoto L_0094;\nL_0092:\n\tUnityEngine.Object::Destroy(v1446);\nL_0094:\n\tv676 = v274 == 0;\n\tif (v676) goto L_0496;\n\tv1032 = *([v274 @ stack_-68_v12]);\n\tv1087 = *([v1032 @ X8_v25+12E]);\n\tv1034 = *([v1032 @ X8_v25+12E]) == 0;\n\tif (v1034) goto L_00B7;\n\tv1086 = *([v1032 @ X8_v25+B0]) + 8;\nL_00A2:\n\tv1092 = *([v1086 @ X10_v86-8]) == *([v877 @ X26_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v1092) goto L_00BA;\n\tv1086 = v1086 + 0x10;\n\tv1066 = v1087 - 1;\n\tv1046 = v1087 != 1;\n\tif (v1046) goto L_00A2;\nL_00B7:\n\tv1112 = 0xF7087C(v274, *([v877 @ X26_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, v1126, v40, v41, v42, v43, v1125, v1124, v1123, v47, v48, v49, v50, v51);\n\tgoto L_00C0;\nL_00BA:\n\tv1109 = *([v1086 @ X10_v86]) << 4;\n\tv1110 = v1032 + v1109;\n\tv1112 = v1110 + 0x138;\nL_00C0:\n\t*([v1112 @ X0_v38])(v1115, v274, *([v1112 @ X0_v38+8]), v899, v1126, v40, v41, v42, v43, v1125, v1124, v1123, v47, v48, v49, v50, v51);\n\tv1116 = v1115 & 1;\n\tv1117 = v1116 == 0;\n\tif (v1117) goto L_011F;\n\tv677 = v274 == 0;\n\tif (v677) goto L_0498;\n\tv1225 = *([v274 @ stack_-68_v12]);\n\tv1308 = *([v1225 @ X8_v117+12E]);\n\tv1227 = *([v1225 @ X8_v117+12E]) == 0;\n\tif (v1227) goto L_00E8;\n\tv1307 = *([v1225 @ X8_v117+B0]) + 8;\nL_00D3:\n\tv1313 = *([v1307 @ X10_v81-8]) == *([v877 @ X26_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v1313) goto L_00EB;\n\tv1307 = v1307 + 0x10;\n\tv1281 = v1308 - 1;\n\tv1261 = v1308 != 1;\n\tif (v1261) goto L_00D3;\nL_00E8:\n\tv1351 = 0xF7087C(v274, *([v877 @ X26_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, v1126, v40, v41, v42, v43, v1125, v1124, v1123, v47, v48, v49, v50, v51);\n\tgoto L_00F2;\nL_00EB:\n\tv1347 = *([v1307 @ X10_v81]) + 1;\n// ... truncated")]
	private void GetFriendFinderInvitationsCallback(global::Facebook.Unity.IFriendFinderInvitationResult receivedInvitations)
	{
		//IL_1a5c: Expected O, but got I4
		//IL_001c: Expected I, but got O
		//IL_0033: Expected O, but got I
		//IL_0043: Expected O, but got I
		//IL_1876: Expected O, but got I
		//IL_00e8: Expected I, but got O
		//IL_00f6: Expected I, but got O
		//IL_013e: Expected O, but got I
		//IL_01d3: Expected I, but got O
		//IL_0179: Expected O, but got I
		//IL_1e60: Expected I, but got O
		//IL_1e70: Expected O, but got I
		//IL_01e6: Expected I4, but got O
		//IL_01f4: Expected O, but got I
		//IL_0203: Expected O, but got I
		//IL_018d: Expected O, but got I
		//IL_019c: Expected O, but got I
		//IL_0405: Expected O, but got I
		//IL_023d: Expected O, but got I
		//IL_049a: Expected I, but got O
		//IL_1b6d: Expected O, but got I
		//IL_0440: Expected O, but got I
		//IL_0278: Expected O, but got I
		//IL_04ad: Expected I4, but got O
		//IL_04bb: Expected O, but got I
		//IL_04ca: Expected O, but got I
		//IL_032a: Expected O, but got I
		//IL_0332: Expected I, but got O
		//IL_02e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e9: Expected O, but got Unknown
		//IL_0306: Expected O, but got I
		//IL_0315: Expected O, but got I
		//IL_0454: Expected O, but got I
		//IL_0463: Expected O, but got I
		//IL_028c: Expected O, but got I
		//IL_029b: Expected O, but got I
		//IL_039f: Expected O, but got I
		object obj = 0;
		string text = "Parent table name is missing in relation '{0}'.";
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v64 @ X8_v19 (System.String)+3E8]");
		logger.DebugLog((string)0);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v66 @ X21_v13 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+1F0]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X0_v32+E0]");
		FBWindowsFriendsManager fBWindowsFriendsManager;
		if ((nint)0 != 0)
		{
			if (global::Facebook.Unity.FB.IsLoggedIn)
			{
				goto IL_00cb;
			}
			fBWindowsFriendsManager = this;
		}
		else
		{
			bool isLoggedIn = global::Facebook.Unity.FB.IsLoggedIn;
			bool flag = !isLoggedIn;
			fBWindowsFriendsManager = this;
			if (!flag)
			{
				goto IL_00cb;
			}
		}
		string text2 = "IsCyrillic";
		FBWindowsLogsManager logger2 = fBWindowsFriendsManager.Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v871 @ X8_v12 (System.String)+A68]");
		logger2.DebugWarningLog((string)0);
		return;
		IL_00cb:
		global::System.Collections.IEnumerator enumerator = ReceivedInvitationsPanelTransform.GetEnumerator();
		nint num2 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num3 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		object obj3 = default(object);
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj12 = default(object);
		object obj22 = default(object);
		while (true)
		{
			if (obj3 != null)
			{
				object obj4 = obj3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X8_v25+12E]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X8_v25+12E]");
				if ((nint)0 == 0)
				{
					goto IL_01c4;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1032 @ X8_v25+B0]");
				object obj6 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1086 @ X10_v86-8]");
					nint num4 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X26_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num4 == 0)
					{
						break;
					}
					obj6 = (nint)obj6 + 16;
					object obj7 = (nint)obj5 - 1;
					bool flag2 = (nint)obj5 != 1;
					obj5 = obj7;
					if (flag2)
					{
						continue;
					}
					goto IL_01c4;
				}
				int num5 = obj6 << 4;
				object obj8 = (nint)obj4 + num5;
				object obj9 = (nint)obj8 + 312;
				goto IL_1a8d;
			}
			throw new global::System.NullReferenceException();
			IL_02c3:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			nint num6 = 1;
			goto IL_1aef;
			IL_1b5d:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1434 @ X0_v192+8]");
			string text3 = (string)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1434 @ X0_v192] (should have been resolved before IL gen)");
			break;
			IL_048b:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num6 = unchecked((nint)null);
			goto IL_1b5d;
			IL_1aef:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1351 @ X0_v199] (should have been resolved before IL gen)");
			if ((object)component != null)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v878 @ X22_v12 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
				string text4 = (string)0;
				nint num7 = (nint)component;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1388 @ X8_v120 (Il2CppClass<UnityEngine.Component>)+130]");
				nint num8 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X1_v81 (System.String)+130]");
				if (num8 >= 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v623 @ X1_v81 (System.String)+130]");
					int num9 = (int)((nint)0 << 3);
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1388 @ X8_v120 (Il2CppClass<UnityEngine.Component>)+C8]");
					object obj10 = (nint)0 + (nint)num9;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1426 @ X8_v123-8]");
					if (0 == (nint)text4)
					{
						global::UnityEngine.GameObject obj11 = component.gameObject;
						global::UnityEngine.Object.Destroy(obj11);
						continue;
					}
				}
				throw new global::System.InvalidCastException();
			}
			throw new global::System.NullReferenceException();
			IL_01c4:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num6 = unchecked((nint)null);
			goto IL_1a8d;
			IL_1a8d:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v1112 @ X0_v38] (should have been resolved before IL gen)");
			if ((int)((nint)obj12 & 1) != 0)
			{
				if (obj3 != null)
				{
					object obj13 = obj3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v117+12E]");
					object obj14 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v117+12E]");
					if ((nint)0 == 0)
					{
						goto IL_02c3;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1225 @ X8_v117+B0]");
					object obj15 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X10_v81-8]");
						nint num10 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v877 @ X26_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num10 == 0)
						{
							break;
						}
						obj15 = (nint)obj15 + 16;
						object obj16 = (nint)obj14 - 1;
						bool flag3 = (nint)obj14 != 1;
						obj14 = obj16;
						if (flag3)
						{
							continue;
						}
						goto IL_02c3;
					}
					object obj17 = obj15 + 1;
					int num11 = (int)((nint)obj17 << 4);
					object obj18 = (nint)obj13 + num11;
					object obj19 = (nint)obj18 + 312;
					goto IL_1aef;
				}
				throw new global::System.NullReferenceException();
			}
			object obj20 = obj3;
			object obj21 = obj;
			nint num12 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X25_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
			text3 = (string)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			obj21 = obj22;
			if (obj22 == null)
			{
				break;
			}
			object obj23 = obj22;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v113+12E]");
			object obj24 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v113+12E]");
			if ((nint)0 == 0)
			{
				goto IL_048b;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1320 @ X8_v113+B0]");
			object obj25 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1409 @ X10_v74-8]");
				nint num13 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1229 @ X25_v11 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
				if (num13 == 0)
				{
					break;
				}
				obj25 = (nint)obj25 + 16;
				object obj26 = (nint)obj24 - 1;
				bool flag4 = (nint)obj24 != 1;
				obj24 = obj26;
				if (flag4)
				{
					continue;
				}
				goto IL_048b;
			}
			int num14 = obj25 << 4;
			object obj27 = (nint)obj23 + num14;
			object obj28 = (nint)obj27 + 312;
			goto IL_1b5d;
		}
		object obj29 = obj3;
		int num15 = 0;
		fBWindowsFriendsManager = this;
		throw new global::System.OutOfMemoryException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDE468", Offset = "0xFDE468", Length = "0x17C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv23 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv24 = v23 + 0xDF8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, receivedInvitations, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = \"Hungarian\";\n\tv46 = v45 + 0xED0;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, receivedInvitations, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A91E]) = v43;\nL_001A:\n\tv47 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv50 = receivedInvitations->klass;\n\tv183 = receivedInvitations->klass->rank;\n\tv52 = *([v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+12E]) == 0;\n\tif (v52) goto L_003D;\n\tv182 = *([v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+B0]) + 8;\nL_0028:\n\tv188 = *([v182 @ X10_v13-8]) == *([v47 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v188) goto L_0070;\n\tv182 = v182 + 0x10;\n\tv168 = v183 - 1;\n\tv148 = v183 != 1;\n\tif (v148) goto L_0028;\nL_003D:\n\tv171 = 0xF7087C(receivedInvitations, *([v47 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\t*([v171 @ X0_v19])(v196, receivedInvitations, *([v171 @ X0_v19+8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv140 = this.Logger;\n\tv198 = v196 == 0;\n\tif (v198) goto L_007D;\nL_0046:\n\tv285 = receivedInvitations->klass;\n\tv315 = receivedInvitations->klass->rank;\n\tv287 = *([v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+12E]) == 0;\n\tif (v287) goto L_0066;\n\tv115 = *([v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+B0]) + 8;\nL_0051:\n\tv95 = *([v115 @ X10_v8-8]) == *([v47 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v95) goto L_008D;\n\tv115 = v115 + 0x10;\n\tv301 = v315 - 1;\n\tv291 = v315 != 1;\n\tif (v291) goto L_0051;\nL_0066:\n\tv303 = 0xF7087C(receivedInvitations, *([v47 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\t*([v303 @ X0_v12])(v324, receivedInvitations, *([v303 @ X0_v12+8]), 0, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv318 = v140 == 0;\n\tv132 = ~v318;\n\tif (v132) goto L_0098;\n\tgoto L_00A3;\nL_0070:\n\tv258 = *([v182 @ X10_v13]) << 4;\n\tv259 = v50 + v258;\n\tv260 = v259 + 0x138;\n\t*([v260 @ X0_v22])(v264, receivedInvitations, *([v260 @ X0_v22+8]), v207, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv140 = this.Logger;\n\tv266 = v264 == 0;\n\tv267 = ~v266;\n\tif (v267) goto L_0046;\nL_007D:\n\tv304 = \"Hungarian\";\n\tFBWindowsLogsManager::DebugLog(v141, *([v304 @ X8_v6 (System.String)+ED0]));\n\tFBWindowsFriendsManager::Button_GetFriendFinderInvitations(this);\n\treturn;\nL_008D:\n\tv61 = *([v115 @ X10_v8]) << 4;\n\tv320 = v285 + v61;\n\tv321 = v320 + 0x138;\n\t*([v321 @ X0_v15])(v324, receivedInvitations, *([v321 @ X0_v15+8]), v207, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_0098:\n\tFBWindowsLogsManager::DebugErrorLog(v140, v324);\n\tFBWindowsFriendsManager::Button_GetFriendFinderInvitations(this);\n\treturn;\nL_00A3:\n\tthrow System.NullReferenceException;\n// 102 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void DeleteFriendFinderInvitationCallback(global::Facebook.Unity.IFriendFinderInvitationResult receivedInvitations)
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
		//IL_028a: Expected I4, but got O
		//IL_0298: Expected O, but got I
		//IL_02a7: Expected O, but got I
		//IL_0163: Expected O, but got I
		//IL_0172: Expected O, but got I
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)receivedInvitations;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00b1;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X8_v4 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v182 @ X10_v13-8]");
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
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
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v260 @ X0_v22] (should have been resolved before IL gen)");
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
		string text = "Hungarian";
		FBWindowsLogsManager fBWindowsLogsManager = logger2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v304 @ X8_v6 (System.String)+ED0]");
		fBWindowsLogsManager.DebugLog((string)0);
		Button_GetFriendFinderInvitations();
		return;
		IL_00fc:
		nint num5 = (nint)receivedInvitations;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+12E]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_019a;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v9 (Il2CppClass<Facebook.Unity.IFriendFinderInvitationResult>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v115 @ X10_v8-8]");
			nint num6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
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
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v321 @ X0_v15] (should have been resolved before IL gen)");
		goto IL_02b6;
		IL_019a:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v12] (should have been resolved before IL gen)");
		bool flag5 = (object)logger == null;
		bool flag6 = !flag5;
		nint num8 = unchecked((nint)null);
		if (!flag6)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_02b6;
		IL_02b6:
		string message = default(string);
		logger.DebugErrorLog(message);
		Button_GetFriendFinderInvitations();
		return;
		IL_00b1:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v171 @ X0_v19] (should have been resolved before IL gen)");
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

	[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDE5E4", Offset = "0xFDE5E4", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsFriendsManager()
	{
	}
}
