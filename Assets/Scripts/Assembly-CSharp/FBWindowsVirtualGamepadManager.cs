[global::Cpp2ILInjected.Token(Token = "0x200002F")]
public class FBWindowsVirtualGamepadManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.UI.InputField NewVirtualGamepadLayout;

	[global::Cpp2ILInjected.Token(Token = "0x6000128")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE53C4", Offset = "0xFE53C4", Length = "0xD8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x328;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv46 = v45 + 0xD48;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv69 = \"Scrollbar Horizontal\";\n\tv70 = v69 + 0x2A8;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A953]) = v42;\nL_001A:\n\tv43 = this.NewVirtualGamepadLayout;\n\tv48 = \"Scrollbar Horizontal\";\n\tv54 = System.String::Concat(*([v48 @ X9_v2 (System.String)+2A8]), v43.m_Text);\n\tFBWindowsLogsManager::DebugLog(this.Logger, v54);\n\tv66 = this.NewVirtualGamepadLayout;\n\tv95 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv96 = Il2CppMethodInfo;\n\tv100 = new *([v95 @ X9_v4 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+D48])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v100, this, *([v96 @ X22_v1 (Il2CppMethodInfo)+328]), 0);\n\tFacebook.Unity.FB+Windows::SetVirtualGamepadLayout(v66.m_Text, v100);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 45 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void SetVirtualGamepadLayout()
	{
		//IL_0028: Expected O, but got I
		//IL_005d: Expected I, but got O
		global::UnityEngine.UI.InputField newVirtualGamepadLayout = NewVirtualGamepadLayout;
		string text = "Scrollbar Horizontal";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X9_v2 (System.String)+2A8]");
		string message = (string)0 + newVirtualGamepadLayout.text;
		Logger.DebugLog(message);
		global::UnityEngine.UI.InputField newVirtualGamepadLayout2 = NewVirtualGamepadLayout;
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IVirtualGamepadLayoutResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FB.Windows.SetVirtualGamepadLayout(newVirtualGamepadLayout2.text, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000129")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE549C", Offset = "0xFE549C", Length = "0x270")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv27 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv28 = v27 + 0xDF8;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv49 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv50 = v49 + 0xFC8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv167 = \"DarkSalmon\";\n\tv168 = v167 + 0xE50;\n\tv169 = \"il2cpp_codegen_initialize_runtime_metadata\"(v168, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv199 = \"Unable to decode certificate.\";\n\tv200 = v199 + 0xD90;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v200, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A954]) = v47;\nL_0022:\n\tv52 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv55 = result->klass;\n\tv212 = result->klass->rank;\n\tv57 = *([v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]) == 0;\n\tif (v57) goto L_0045;\n\tv211 = *([v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+B0]) + 8;\nL_0030:\n\tv217 = *([v211 @ X10_v26-8]) == *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v217) goto L_0048;\n\tv211 = v211 + 0x10;\n\tv195 = v212 - 1;\n\tv175 = v212 != 1;\n\tif (v175) goto L_0030;\nL_0045:\n\tv303 = 0xF7087C(result, *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_004E;\nL_0048:\n\tv286 = *([v211 @ X10_v26]) << 4;\n\tv287 = v55 + v286;\n\tv303 = v287 + 0x138;\nL_004E:\n\t*([v303 @ X0_v4])(v308, result, *([v303 @ X0_v4+8]), v437, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv309 = result->klass;\n\tv409 = result->klass->rank;\n\tv311 = v308 == 0;\n\tif (v311) goto L_0077;\n\tv312 = \"DarkSalmon\";\n\tv314 = *([v309 @ X8_v7 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]) == 0;\n\tif (v314) goto L_0075;\n\tv387 = *([v309 @ X8_v7 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+B0]) + 8;\nL_0060:\n\tv393 = *([v387 @ X10_v21-8]) == *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v393) goto L_009B;\n\tv387 = v387 + 0x10;\n\tv344 = v409 - 1;\n\tv324 = v409 != 1;\n\tif (v324) goto L_0060;\nL_0075:\n\tv426 = 0xF7087C(result, *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 2, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00A2;\nL_0077:\n\tv315 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv318 = *([v309 @ X8_v7 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]) == 0;\n\tif (v318) goto L_0098;\n\tv408 = *([v309 @ X8_v7 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+B0]) + 8;\nL_0083:\n\tv414 = *([v408 @ X10_v9-8]) == *([v315 @ X10_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+FC8]);\n\tif (v414) goto L_00EF;\n\tv408 = v408 + 0x10;\n\tv373 = v409 - 1;\n\tv353 = v409 != 1;\n\tif (v353) goto L_0083;\nL_0098:\n\tv438 = 0xF7087C(result, *([v315 @ X10_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+FC8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00F5;\nL_009B:\n\tv421 = *([v387 @ X10_v21]) + 2;\n\tv422 = v421 << 4;\n\tv423 = v309 + v422;\n\tv426 = v423 + 0x138;\nL_00A2:\n\t*([v426 @ X0_v16])(v430, result, *([v426 @ X0_v16+8]), v437, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv148 = System.String::Concat(*([v312 @ X23_v3 (System.String)+E50]), v430);\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v148);\n\tv449 = result->klass;\n\tv476 = result->klass->rank;\n\tv451 = *([v449 @ X8_v15 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]) == 0;\n\tif (v451) goto L_00CE;\n\tv132 = *([v449 @ X8_v15 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+B0]) + 8;\nL_00B9:\n\tv108 = *([v132 @ X10_v16-8]) == *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v108) goto L_00D8;\n\tv132 = v132 + 0x10;\n\tv464 = v476 - 1;\n\tv454 = v476 != 1;\n\tif (v454) goto L_00B9;\nL_00CE:\n\tv466 = 0xF7087C(result, *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([v466 @ X0_v25])(v485, result, *([v466 @ X0_v25+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv479 = this.Logger == 0;\n\tv154 = ~v479;\n\tif (v154) goto L_00EC;\n\tgoto L_010B;\nL_00D8:\n\tv68 = *([v132 @ X10_v16]) << 4;\n\tv481 = v449 + v68;\n\tv482 = v481 + 0x138;\n\t*([v482 @ X0_v28])(v485, result, *([v482 @ X0_v28+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_00EC:\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v485);\n\treturn;\nL_00EF:\n\tv434 = *([v408 @ X10_v9]) << 4;\n\tv435 = v309 + v434;\n\tv438 = v435 + 0x138;\nL_00F5:\n\t*([v438 @ X0_v7])(v443, result, *([v438 @ X0_v7+8]), v437, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv444 = \"Unable to decode certificate.\";\n\tv151 = System.String::Concat(*([v444 @ X8_v10 (System.String)+D90]), v443);\n\tFBWindowsLogsManager::DebugLog(this.Logger, v151);\n\treturn;\nL_010B:\n\tthrow System.NullReferenceException;\n// 169 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void CallbackSetVirtualGamepadLayout(global::Facebook.Unity.IVirtualGamepadLayoutResult result)
	{
		//IL_0013: Expected I, but got O
		//IL_001b: Expected I, but got O
		//IL_002b: Expected O, but got I
		//IL_00c0: Expected I, but got O
		//IL_0443: Expected I, but got O
		//IL_0453: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_01aa: Expected I, but got O
		//IL_023f: Expected I, but got O
		//IL_00d3: Expected I4, but got O
		//IL_00e1: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_0518: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_04bb: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_03cd: Expected I4, but got O
		//IL_03db: Expected O, but got I
		//IL_03ea: Expected O, but got I
		//IL_029a: Expected I, but got O
		//IL_02aa: Expected O, but got I
		//IL_01f9: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_027e: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_0382: Expected I4, but got O
		//IL_0390: Expected O, but got I
		//IL_039f: Expected O, but got I
		//IL_02f9: Expected O, but got I
		//IL_0308: Expected O, but got I
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00b1;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v211 @ X10_v26-8]");
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
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
		goto IL_0431;
		IL_0330:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v466 @ X0_v25] (should have been resolved before IL gen)");
		if ((object)Logger == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_03af;
		IL_0184:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		nint num5 = 2;
		goto IL_049c;
		IL_049c:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v426 @ X0_v16] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v312 @ X23_v3 (System.String)+E50]");
		string text = default(string);
		string message = (string)0 + text;
		Logger.DebugErrorLog(message);
		nint num6 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v15 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v15 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0330;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v449 @ X8_v15 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v132 @ X10_v16-8]");
			nint num7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
			if (num7 == 0)
			{
				break;
			}
			obj7 = (nint)obj7 + 16;
			object obj8 = (nint)obj6 - 1;
			bool flag2 = (nint)obj6 != 1;
			obj6 = obj8;
			if (flag2)
			{
				continue;
			}
			goto IL_0330;
		}
		int num8 = obj7 << 4;
		object obj9 = num6 + num8;
		object obj10 = (nint)obj9 + 312;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v482 @ X0_v28] (should have been resolved before IL gen)");
		goto IL_03af;
		IL_03af:
		string message2 = default(string);
		Logger.DebugErrorLog(message2);
		return;
		IL_00b1:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		num5 = unchecked((nint)null);
		goto IL_0431;
		IL_0431:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v303 @ X0_v4] (should have been resolved before IL gen)");
		nint num9 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v7 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]");
		object obj11 = 0;
		object obj12 = default(object);
		if (obj12 != null)
		{
			string text2 = "DarkSalmon";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v7 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0184;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v7 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v387 @ X10_v21-8]");
				nint num10 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
				if (num10 == 0)
				{
					break;
				}
				obj13 = (nint)obj13 + 16;
				object obj14 = (nint)obj11 - 1;
				bool flag3 = (nint)obj11 != 1;
				obj11 = obj14;
				if (flag3)
				{
					continue;
				}
				goto IL_0184;
			}
			object obj15 = obj13 + 2;
			int num11 = (int)((nint)obj15 << 4);
			object obj16 = num9 + num11;
			object obj17 = (nint)obj16 + 312;
			goto IL_049c;
		}
		nint num12 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v7 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0230;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v309 @ X8_v7 (Il2CppClass<Facebook.Unity.IVirtualGamepadLayoutResult>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X10_v9-8]");
			nint num13 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v315 @ X10_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+FC8]");
			if (num13 == 0)
			{
				break;
			}
			obj18 = (nint)obj18 + 16;
			object obj19 = (nint)obj11 - 1;
			bool flag4 = (nint)obj11 != 1;
			obj11 = obj19;
			if (flag4)
			{
				continue;
			}
			goto IL_0230;
		}
		int num14 = obj18 << 4;
		object obj20 = num9 + num14;
		object obj21 = (nint)obj20 + 312;
		goto IL_04f0;
		IL_04f0:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v438 @ X0_v7] (should have been resolved before IL gen)");
		string text3 = "Unable to decode certificate.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v444 @ X8_v10 (System.String)+D90]");
		string text4 = default(string);
		string message3 = (string)0 + text4;
		Logger.DebugLog(message3);
		return;
		IL_0230:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		num5 = unchecked((nint)null);
		goto IL_04f0;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600012A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE570C", Offset = "0xFE570C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsVirtualGamepadManager()
	{
	}
}
