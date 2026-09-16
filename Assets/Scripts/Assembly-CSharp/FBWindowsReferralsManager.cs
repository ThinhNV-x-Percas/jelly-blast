[global::Cpp2ILInjected.Token(Token = "0x200002B")]
public class FBWindowsReferralsManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public FBWindowsLogsManager Logger;

	[global::Cpp2ILInjected.Token(Token = "0x40000B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.UI.InputField Payload;

	[global::Cpp2ILInjected.Token(Token = "0x40000B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.UI.InputField ReferralLinks;

	[global::Cpp2ILInjected.Token(Token = "0x40000B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private string _referral_example_payload;

	[global::Cpp2ILInjected.Token(Token = "0x600010E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE2D90", Offset = "0xFE2D90", Length = "0x28")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.UI.InputField::set_text(this.Payload, this._referral_example_payload);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnEnable()
	{
		Payload.text = _referral_example_payload;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600010F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE2DB8", Offset = "0xFE2DB8", Length = "0xBC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x2D8;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv46 = v45 + 0xD08;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv57 = \"Cannot load image: download failed\";\n\tv58 = v57 + 0xD80;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A93D]) = v42;\nL_001D:\n\tv48 = \"Cannot load image: download failed\";\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v48 @ X8_v4 (System.String)+D80]));\n\tv55 = this.Payload;\n\tv59 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv61 = Il2CppMethodInfo;\n\tv65 = new *([v59 @ X9_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+D08])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v65, this, *([v61 @ X22_v1 (Il2CppMethodInfo)+2D8]), 0);\n\tFacebook.Unity.FB+Windows::CreateReferral(v55.m_Text, v65);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void CreateReferral()
	{
		//IL_0025: Expected O, but got I
		//IL_0042: Expected I, but got O
		string text = "Cannot load image: download failed";
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v4 (System.String)+D80]");
		logger.DebugLog((string)0);
		global::UnityEngine.UI.InputField payload = Payload;
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IReferralsCreateResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FB.Windows.CreateReferral(payload.text, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000110")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE2E74", Offset = "0xFE2E74", Length = "0x384")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0025;\n\tv27 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv28 = v27 + 0xDC0;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv49 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv50 = v49 + 0xDF8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv222 = \"DarkSalmon\";\n\tv223 = v222 + 0xCA0;\n\tv224 = \"il2cpp_codegen_initialize_runtime_metadata\"(v223, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv254 = \"Parent table name is missing in relation '{0}'.\";\n\tv255 = v254 + 0x9D8;\n\tv256 = \"il2cpp_codegen_initialize_runtime_metadata\"(v255, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv356 = \"Parent table name is missing in relation '{0}'.\";\n\tv357 = v356 + 0x9C8;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v357, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A93E]) = v47;\nL_0025:\n\tv52 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv55 = result->klass;\n\tv268 = result->klass->rank;\n\tv57 = *([v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]) == 0;\n\tif (v57) goto L_0048;\n\tv267 = *([v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]) + 8;\nL_0033:\n\tv273 = *([v267 @ X10_v36-8]) == *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v273) goto L_004B;\n\tv267 = v267 + 0x10;\n\tv250 = v268 - 1;\n\tv230 = v268 != 1;\n\tif (v230) goto L_0033;\nL_0048:\n\tv377 = 0xF7087C(result, *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_0051;\nL_004B:\n\tv360 = *([v267 @ X10_v36]) << 4;\n\tv361 = v55 + v360;\n\tv377 = v361 + 0x138;\nL_0051:\n\t*([v377 @ X0_v4])(v382, result, *([v377 @ X0_v4+8]), v510, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv383 = result->klass;\n\tv482 = result->klass->rank;\n\tv385 = v382 == 0;\n\tif (v385) goto L_007A;\n\tv386 = \"DarkSalmon\";\n\tv388 = *([v383 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]) == 0;\n\tif (v388) goto L_0078;\n\tv460 = *([v383 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]) + 8;\nL_0063:\n\tv466 = *([v460 @ X10_v31-8]) == *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v466) goto L_009E;\n\tv460 = v460 + 0x10;\n\tv417 = v482 - 1;\n\tv397 = v482 != 1;\n\tif (v397) goto L_0063;\nL_0078:\n\tv499 = 0xF7087C(result, *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 2, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00A5;\nL_007A:\n\tv389 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv391 = *([v383 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]) == 0;\n\tif (v391) goto L_009B;\n\tv481 = *([v383 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]) + 8;\nL_0086:\n\tv487 = *([v481 @ X10_v19-8]) == *([v389 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC0]);\n\tif (v487) goto L_00F2;\n\tv481 = v481 + 0x10;\n\tv446 = v482 - 1;\n\tv426 = v482 != 1;\n\tif (v426) goto L_0086;\nL_009B:\n\tv511 = 0xF7087C(result, *([v389 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC0]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00F8;\nL_009E:\n\tv494 = *([v460 @ X10_v31]) + 2;\n\tv495 = v494 << 4;\n\tv496 = v383 + v495;\n\tv499 = v496 + 0x138;\nL_00A5:\n\t*([v499 @ X0_v34])(v503, result, *([v499 @ X0_v34+8]), v510, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv193 = System.String::Concat(*([v386 @ X23_v3 (System.String)+CA0]), v503);\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v193);\n\tv524 = result->klass;\n\tv584 = result->klass->rank;\n\tv526 = *([v524 @ X8_v26 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]) == 0;\n\tif (v526) goto L_00D1;\n\tv167 = *([v524 @ X8_v26 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]) + 8;\nL_00BC:\n\tv131 = *([v167 @ X10_v26-8]) == *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v131) goto L_00DB;\n\tv167 = v167 + 0x10;\n\tv543 = v584 - 1;\n\tv533 = v584 != 1;\n\tif (v533) goto L_00BC;\nL_00D1:\n\tv545 = 0xF7087C(result, *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([v545 @ X0_v43])(v614, result, *([v545 @ X0_v43+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv587 = this.Logger == 0;\n\tv202 = ~v587;\n\tif (v202) goto L_00EF;\n\tgoto L_017F;\nL_00DB:\n\tv72 = *([v167 @ X10_v26]) << 4;\n\tv610 = v524 + v72;\n\tv611 = v610 + 0x138;\n\t*([v611 @ X0_v46])(v614, result, *([v611 @ X0_v46+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_00EF:\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v614);\n\treturn;\nL_00F2:\n\tv507 = *([v481 @ X10_v19]) << 4;\n\tv508 = v383 + v507;\n\tv511 = v508 + 0x138;\nL_00F8:\n\t*([v511 @ X0_v7])(v516, result, *([v511 @ X0_v7+8]), v510, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv517 = \"Parent table name is missing in relation '{0}'.\";\n\tv196 = System.String::Concat(*([v517 @ X8_v10 (System.String)+9D8]), v516);\n\tFBWindowsLogsManager::DebugLog(this.Logger, v196);\n\tv528 = result->klass;\n\tv599 = result->klass->rank;\n\tv530 = *([v528 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]) == 0;\n\tif (v530) goto L_0126;\n\tv598 = *([v528 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]) + 8;\nL_0111:\n\tv604 = *([v598 @ X10_v14-8]) == *([v389 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC0]);\n\tif (v604) goto L_0129;\n\tv598 = v598 + 0x10;\n\tv571 = v599 - 1;\n\tv551 = v599 != 1;\n\tif (v551) goto L_0111;\nL_0126:\n\tv622 = 0xF7087C(result, *([v389 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC0]), 1, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_0130;\nL_0129:\n\tv617 = *([v598 @ X10_v14]) + 1;\n\tv618 = v617 << 4;\n\tv619 = v528 + v618;\n\tv622 = v619 + 0x138;\nL_0130:\n\t*([v622 @ X0_v13])(v627, result, *([v622 @ X0_v13+8]), v621, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv628 = \"Parent table name is missing in relation '{0}'.\";\n\tv197 = System.String::Concat(*([v628 @ X8_v15 (System.String)+9C8]), v627);\n\tFBWindowsLogsManager::DebugLog(this.Logger, v197);\n\tv633 = result->klass;\n\tv660 = result->klass->rank;\n\tv635 = *([v633 @ X8_v17 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]) == 0;\n\tif (v635) goto L_015E;\n\tv164 = *([v633 @ X8_v17 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]) + 8;\nL_0149:\n\tv128 = *([v164 @ X10_v9-8]) == *([v389 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC0]);\n\tif (v128) goto L_0174;\n\tv164 = v164 + 0x10;\n\tv648 = v660 - 1;\n\tv638 = v660 != 1;\n\tif (v638) goto L_0149;\nL_015E:\n\tv650 = 0xF7087C(result, *([v389 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC0]), 1, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([v650 @ X0_v22])(v671, result, *([v650 @ X0_v22+8]), 1, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_0171:\n\tUnityEngine.UI.InputField::set_text(this.ReferralLinks, v671);\n\treturn;\nL_0174:\n\tv173 = *([v164 @ X10_v9]) + 1;\n\tv70 = v173 << 4;\n\tv665 = v633 + v70;\n\tv666 = v665 + 0x138;\n\t*([v666 @ X0_v25])(v671, result, *([v666 @ X0_v25+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv668 = this.ReferralLinks == 0;\n\tv200 = ~v668;\n\tif (v200) goto L_0171;\nL_017F:\n\tthrow System.NullReferenceException;\n// 239 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void CallbackReferralsCreate(global::Facebook.Unity.IReferralsCreateResult result)
	{
		//IL_0013: Expected I, but got O
		//IL_001b: Expected I, but got O
		//IL_002b: Expected O, but got I
		//IL_00c0: Expected I, but got O
		//IL_0684: Expected I, but got O
		//IL_0694: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_01aa: Expected I, but got O
		//IL_023f: Expected I, but got O
		//IL_00d3: Expected I4, but got O
		//IL_00e1: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_0759: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_0406: Expected I, but got O
		//IL_0416: Expected O, but got I
		//IL_06fc: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_04af: Expected O, but got I4
		//IL_03cd: Expected I4, but got O
		//IL_03db: Expected O, but got I
		//IL_03ea: Expected O, but got I
		//IL_029a: Expected I, but got O
		//IL_02aa: Expected O, but got I
		//IL_07e2: Expected O, but got I
		//IL_0451: Expected O, but got I
		//IL_01f9: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_027e: Expected O, but got I
		//IL_0513: Expected I, but got O
		//IL_0523: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04df: Expected O, but got I
		//IL_04ee: Expected O, but got I
		//IL_04f7: Expected O, but got I4
		//IL_055e: Expected O, but got I
		//IL_0465: Expected O, but got I
		//IL_0474: Expected O, but got I
		//IL_0382: Expected I4, but got O
		//IL_0390: Expected O, but got I
		//IL_039f: Expected O, but got I
		//IL_02f9: Expected O, but got I
		//IL_0308: Expected O, but got I
		//IL_05db: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e0: Expected O, but got Unknown
		//IL_05fd: Expected O, but got I
		//IL_060c: Expected O, but got I
		//IL_0572: Expected O, but got I
		//IL_0581: Expected O, but got I
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00b1;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v267 @ X10_v36-8]");
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
		goto IL_0672;
		IL_0184:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		nint num5 = 2;
		goto IL_06dd;
		IL_06dd:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v499 @ X0_v34] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v386 @ X23_v3 (System.String)+CA0]");
		string text = default(string);
		string message = (string)0 + text;
		Logger.DebugErrorLog(message);
		nint num6 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v26 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v26 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0330;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v524 @ X8_v26 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X10_v26-8]");
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
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v611 @ X0_v46] (should have been resolved before IL gen)");
		goto IL_03af;
		IL_05a9:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v650 @ X0_v22] (should have been resolved before IL gen)");
		goto IL_05c2;
		IL_0640:
		throw new global::System.NullReferenceException();
		IL_00b1:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		num5 = unchecked((nint)null);
		goto IL_0672;
		IL_0672:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v377 @ X0_v4] (should have been resolved before IL gen)");
		nint num9 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		object obj11 = 0;
		object obj12 = default(object);
		if (obj12 != null)
		{
			string text2 = "DarkSalmon";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0184;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]");
			object obj13 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v460 @ X10_v31-8]");
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
			goto IL_06dd;
		}
		nint num12 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0230;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v383 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]");
		object obj18 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v481 @ X10_v19-8]");
			nint num13 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC0]");
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
		goto IL_0731;
		IL_049c:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		object obj22 = 1;
		goto IL_07ba;
		IL_05c2:
		string text3 = default(string);
		ReferralLinks.text = text3;
		return;
		IL_03af:
		string message2 = default(string);
		Logger.DebugErrorLog(message2);
		return;
		IL_07ba:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v622 @ X0_v13] (should have been resolved before IL gen)");
		string text4 = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v628 @ X8_v15 (System.String)+9C8]");
		string text5 = default(string);
		string message3 = (string)0 + text5;
		Logger.DebugLog(message3);
		nint num15 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v17 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		object obj23 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v17 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_05a9;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v633 @ X8_v17 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]");
		object obj24 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v164 @ X10_v9-8]");
			nint num16 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC0]");
			if (num16 == 0)
			{
				break;
			}
			obj24 = (nint)obj24 + 16;
			object obj25 = (nint)obj23 - 1;
			bool flag5 = (nint)obj23 != 1;
			obj23 = obj25;
			if (flag5)
			{
				continue;
			}
			goto IL_05a9;
		}
		object obj26 = obj24 + 1;
		int num17 = (int)((nint)obj26 << 4);
		object obj27 = num15 + num17;
		object obj28 = (nint)obj27 + 312;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v666 @ X0_v25] (should have been resolved before IL gen)");
		if ((object)ReferralLinks != null)
		{
			goto IL_05c2;
		}
		goto IL_0640;
		IL_0330:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v545 @ X0_v43] (should have been resolved before IL gen)");
		if ((object)Logger != null)
		{
			goto IL_03af;
		}
		goto IL_0640;
		IL_0230:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		num5 = unchecked((nint)null);
		goto IL_0731;
		IL_0731:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v511 @ X0_v7] (should have been resolved before IL gen)");
		string text6 = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v517 @ X8_v10 (System.String)+9D8]");
		string text7 = default(string);
		string message4 = (string)0 + text7;
		Logger.DebugLog(message4);
		nint num18 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		object obj29 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_049c;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v528 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsCreateResult>)+B0]");
		object obj30 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v598 @ X10_v14-8]");
			nint num19 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v389 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC0]");
			if (num19 == 0)
			{
				break;
			}
			obj30 = (nint)obj30 + 16;
			object obj31 = (nint)obj29 - 1;
			bool flag6 = (nint)obj29 != 1;
			obj29 = obj31;
			if (flag6)
			{
				continue;
			}
			goto IL_049c;
		}
		object obj32 = obj30 + 1;
		int num20 = (int)((nint)obj32 << 4);
		object obj33 = num18 + num20;
		object obj34 = (nint)obj33 + 312;
		obj22 = 0;
		goto IL_07ba;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000111")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE31F8", Offset = "0xFE31F8", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x2E0;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv46 = v45 + 0xD10;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv56 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv57 = v56 + 0xB70;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A93F]) = v42;\nL_001D:\n\tv48 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = Il2CppMethodInfo;\n\tFBWindowsLogsManager::DebugLog(this.Logger, *([v48 @ X8_v3 (System.String)+B70]));\n\tv59 = new *([v50 @ X20_v2 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+D10])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v59, this, *([v52 @ X21_v1 (Il2CppMethodInfo)+2E0]), 0);\n\tFacebook.Unity.FB+Windows::GetDataReferral(v59);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void GetDataReferral()
	{
		//IL_001c: Expected I, but got O
		//IL_0039: Expected O, but got I
		string text = "Expected ComplexType. Schema was not generated using this tool.";
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = 0;
		FBWindowsLogsManager logger = Logger;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (System.String)+B70]");
		logger.DebugLog((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IReferralsGetDataResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FB.Windows.GetDataReferral(callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000112")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE32A4", Offset = "0xFE32A4", Length = "0x304")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0025;\n\tv27 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv28 = v27 + 0xDC8;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv49 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv50 = v49 + 0xDF8;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv187 = \"DarkSalmon\";\n\tv188 = v187 + 0xCA0;\n\tv189 = \"il2cpp_codegen_initialize_runtime_metadata\"(v188, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv219 = \"Parent table name is missing in relation '{0}'.\";\n\tv220 = v219 + 0x9D0;\n\tv221 = \"il2cpp_codegen_initialize_runtime_metadata\"(v220, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv305 = \"Parent table name is missing in relation '{0}'.\";\n\tv306 = v305 + 0x9D8;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v306, result, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A940]) = v47;\nL_0025:\n\tv52 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv55 = result->klass;\n\tv233 = result->klass->rank;\n\tv57 = *([v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]) == 0;\n\tif (v57) goto L_0048;\n\tv232 = *([v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]) + 8;\nL_0033:\n\tv238 = *([v232 @ X10_v30-8]) == *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v238) goto L_004B;\n\tv232 = v232 + 0x10;\n\tv215 = v233 - 1;\n\tv195 = v233 != 1;\n\tif (v195) goto L_0033;\nL_0048:\n\tv326 = 0xF7087C(result, *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_0051;\nL_004B:\n\tv309 = *([v232 @ X10_v30]) << 4;\n\tv310 = v55 + v309;\n\tv326 = v310 + 0x138;\nL_0051:\n\t*([v326 @ X0_v4])(v331, result, *([v326 @ X0_v4+8]), v459, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv332 = result->klass;\n\tv431 = result->klass->rank;\n\tv334 = v331 == 0;\n\tif (v334) goto L_007A;\n\tv335 = \"DarkSalmon\";\n\tv337 = *([v332 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]) == 0;\n\tif (v337) goto L_0078;\n\tv409 = *([v332 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]) + 8;\nL_0063:\n\tv415 = *([v409 @ X10_v25-8]) == *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v415) goto L_009E;\n\tv409 = v409 + 0x10;\n\tv366 = v431 - 1;\n\tv346 = v431 != 1;\n\tif (v346) goto L_0063;\nL_0078:\n\tv448 = 0xF7087C(result, *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 2, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00A5;\nL_007A:\n\tv338 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv340 = *([v332 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]) == 0;\n\tif (v340) goto L_009B;\n\tv430 = *([v332 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]) + 8;\nL_0086:\n\tv436 = *([v430 @ X10_v13-8]) == *([v338 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC8]);\n\tif (v436) goto L_00F2;\n\tv430 = v430 + 0x10;\n\tv395 = v431 - 1;\n\tv375 = v431 != 1;\n\tif (v375) goto L_0086;\nL_009B:\n\tv460 = 0xF7087C(result, *([v338 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00F8;\nL_009E:\n\tv443 = *([v409 @ X10_v25]) + 2;\n\tv444 = v443 << 4;\n\tv445 = v332 + v444;\n\tv448 = v445 + 0x138;\nL_00A5:\n\t*([v448 @ X0_v25])(v452, result, *([v448 @ X0_v25+8]), v459, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv164 = System.String::Concat(*([v335 @ X23_v3 (System.String)+CA0]), v452);\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v164);\n\tv473 = result->klass;\n\tv533 = result->klass->rank;\n\tv475 = *([v473 @ X8_v21 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]) == 0;\n\tif (v475) goto L_00D1;\n\tv144 = *([v473 @ X8_v21 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]) + 8;\nL_00BC:\n\tv116 = *([v144 @ X10_v20-8]) == *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]);\n\tif (v116) goto L_00DB;\n\tv144 = v144 + 0x10;\n\tv492 = v533 - 1;\n\tv482 = v533 != 1;\n\tif (v482) goto L_00BC;\nL_00D1:\n\tv494 = 0xF7087C(result, *([v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([v494 @ X0_v34])(v563, result, *([v494 @ X0_v34+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv536 = this.Logger == 0;\n\tv171 = ~v536;\n\tif (v171) goto L_00EF;\n\tgoto L_0146;\nL_00DB:\n\tv69 = *([v144 @ X10_v20]) << 4;\n\tv559 = v473 + v69;\n\tv560 = v559 + 0x138;\n\t*([v560 @ X0_v37])(v563, result, *([v560 @ X0_v37+8]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_00EF:\n\tFBWindowsLogsManager::DebugErrorLog(this.Logger, v563);\n\treturn;\nL_00F2:\n\tv456 = *([v430 @ X10_v13]) << 4;\n\tv457 = v332 + v456;\n\tv460 = v457 + 0x138;\nL_00F8:\n\t*([v460 @ X0_v7])(v465, result, *([v460 @ X0_v7+8]), v459, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv466 = \"Parent table name is missing in relation '{0}'.\";\n\tv167 = System.String::Concat(*([v466 @ X8_v10 (System.String)+9D8]), v465);\n\tFBWindowsLogsManager::DebugLog(this.Logger, v167);\n\tv477 = result->klass;\n\tv548 = result->klass->rank;\n\tv479 = *([v477 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]) == 0;\n\tif (v479) goto L_0126;\n\tv547 = *([v477 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]) + 8;\nL_0111:\n\tv553 = *([v547 @ X10_v8-8]) == *([v338 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC8]);\n\tif (v553) goto L_0129;\n\tv547 = v547 + 0x10;\n\tv520 = v548 - 1;\n\tv500 = v548 != 1;\n\tif (v500) goto L_0111;\nL_0126:\n\tv571 = 0xF7087C(result, *([v338 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC8]), 1, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_0130;\nL_0129:\n\tv566 = *([v547 @ X10_v8]) + 1;\n\tv567 = v566 << 4;\n\tv568 = v477 + v567;\n\tv571 = v568 + 0x138;\nL_0130:\n\t*([v571 @ X0_v13])(v576, result, *([v571 @ X0_v13+8]), v570, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv577 = \"Parent table name is missing in relation '{0}'.\";\n\tv168 = System.String::Concat(*([v577 @ X8_v15 (System.String)+9D0]), v576);\n\tFBWindowsLogsManager::DebugLog(this.Logger, v168);\n\treturn;\nL_0146:\n\tthrow System.NullReferenceException;\n// 204 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void CallbackReferralsGetData(global::Facebook.Unity.IReferralsGetDataResult result)
	{
		//IL_0013: Expected I, but got O
		//IL_001b: Expected I, but got O
		//IL_002b: Expected O, but got I
		//IL_00c0: Expected I, but got O
		//IL_0550: Expected I, but got O
		//IL_0560: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_01aa: Expected I, but got O
		//IL_023f: Expected I, but got O
		//IL_00d3: Expected I4, but got O
		//IL_00e1: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_0625: Expected O, but got I
		//IL_01e5: Expected O, but got I
		//IL_007a: Expected O, but got I
		//IL_0089: Expected O, but got I
		//IL_0406: Expected I, but got O
		//IL_0416: Expected O, but got I
		//IL_05c8: Expected O, but got I
		//IL_0139: Expected O, but got I
		//IL_04af: Expected O, but got I4
		//IL_03cd: Expected I4, but got O
		//IL_03db: Expected O, but got I
		//IL_03ea: Expected O, but got I
		//IL_029a: Expected I, but got O
		//IL_02aa: Expected O, but got I
		//IL_06ae: Expected O, but got I
		//IL_0451: Expected O, but got I
		//IL_01f9: Expected O, but got I
		//IL_0208: Expected O, but got I
		//IL_024d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0252: Expected O, but got Unknown
		//IL_026f: Expected O, but got I
		//IL_027e: Expected O, but got I
		//IL_02e5: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_04bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c2: Expected O, but got Unknown
		//IL_04df: Expected O, but got I
		//IL_04ee: Expected O, but got I
		//IL_04f7: Expected O, but got I4
		//IL_0465: Expected O, but got I
		//IL_0474: Expected O, but got I
		//IL_0382: Expected I4, but got O
		//IL_0390: Expected O, but got I
		//IL_039f: Expected O, but got I
		//IL_02f9: Expected O, but got I
		//IL_0308: Expected O, but got I
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_00b1;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X8_v4 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v232 @ X10_v30-8]");
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
		goto IL_053e;
		IL_03af:
		string message = default(string);
		Logger.DebugErrorLog(message);
		return;
		IL_0230:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		nint num5 = unchecked((nint)null);
		goto IL_05fd;
		IL_05fd:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v460 @ X0_v7] (should have been resolved before IL gen)");
		string text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v466 @ X8_v10 (System.String)+9D8]");
		string text2 = default(string);
		string message2 = (string)0 + text2;
		Logger.DebugLog(message2);
		nint num6 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_049c;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v477 @ X8_v12 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]");
		object obj7 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v547 @ X10_v8-8]");
			nint num7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC8]");
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
			goto IL_049c;
		}
		object obj9 = obj7 + 1;
		int num8 = (int)((nint)obj9 << 4);
		object obj10 = num6 + num8;
		object obj11 = (nint)obj10 + 312;
		object obj12 = 0;
		goto IL_0686;
		IL_05a9:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v448 @ X0_v25] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v335 @ X23_v3 (System.String)+CA0]");
		string text3 = default(string);
		string message3 = (string)0 + text3;
		Logger.DebugErrorLog(message3);
		nint num9 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v21 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]");
		object obj13 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v21 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0330;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v473 @ X8_v21 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]");
		object obj14 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v20-8]");
			nint num10 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
			if (num10 == 0)
			{
				break;
			}
			obj14 = (nint)obj14 + 16;
			object obj15 = (nint)obj13 - 1;
			bool flag3 = (nint)obj13 != 1;
			obj13 = obj15;
			if (flag3)
			{
				continue;
			}
			goto IL_0330;
		}
		int num11 = obj14 << 4;
		object obj16 = num9 + num11;
		object obj17 = (nint)obj16 + 312;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v560 @ X0_v37] (should have been resolved before IL gen)");
		goto IL_03af;
		IL_00b1:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		num5 = unchecked((nint)null);
		goto IL_053e;
		IL_053e:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v326 @ X0_v4] (should have been resolved before IL gen)");
		nint num12 = (nint)result;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]");
		object obj18 = 0;
		object obj19 = default(object);
		if (obj19 != null)
		{
			string text4 = "DarkSalmon";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0184;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]");
			object obj20 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v409 @ X10_v25-8]");
				nint num13 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X22_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DF8]");
				if (num13 == 0)
				{
					break;
				}
				obj20 = (nint)obj20 + 16;
				object obj21 = (nint)obj18 - 1;
				bool flag4 = (nint)obj18 != 1;
				obj18 = obj21;
				if (flag4)
				{
					continue;
				}
				goto IL_0184;
			}
			object obj22 = obj20 + 2;
			int num14 = (int)((nint)obj22 << 4);
			object obj23 = num12 + num14;
			object obj24 = (nint)obj23 + 312;
			goto IL_05a9;
		}
		nint num15 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0230;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v332 @ X8_v7 (Il2CppClass<Facebook.Unity.IReferralsGetDataResult>)+B0]");
		object obj25 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v430 @ X10_v13-8]");
			nint num16 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v338 @ X22_v4 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+DC8]");
			if (num16 == 0)
			{
				break;
			}
			obj25 = (nint)obj25 + 16;
			object obj26 = (nint)obj18 - 1;
			bool flag5 = (nint)obj18 != 1;
			obj18 = obj26;
			if (flag5)
			{
				continue;
			}
			goto IL_0230;
		}
		int num17 = obj25 << 4;
		object obj27 = num12 + num17;
		object obj28 = (nint)obj27 + 312;
		goto IL_05fd;
		IL_0686:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v571 @ X0_v13] (should have been resolved before IL gen)");
		string text5 = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v577 @ X8_v15 (System.String)+9D0]");
		string text6 = default(string);
		string message4 = (string)0 + text6;
		Logger.DebugLog(message4);
		return;
		IL_049c:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		obj12 = 1;
		goto IL_0686;
		IL_0330:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v494 @ X0_v34] (should have been resolved before IL gen)");
		if ((object)Logger == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_03af;
		IL_0184:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		num5 = 2;
		goto IL_05a9;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000113")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE35A8", Offset = "0xFE35A8", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = \"x-cp50227\";\n\tgoto L_0018;\n\tv23 = \"x-cp50227\";\n\tv24 = v23 + 0x460;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A941]) = v43;\nL_0018:\n\tv46 = this + 0x38;\n\tthis._referral_example_payload = *([v18 @ X21_v1 (System.String)+460]);\n\tv47 = 0xF3F1B4(v46, *([v18 @ X21_v1 (System.String)+460]), v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsReferralsManager()
	{
		//IL_0020: Expected O, but got I
		//IL_0032: Expected O, but got I
		base._002Ector();
		string text = "x-cp50227";
		object obj = (nint)this + 56;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (System.String)+460]");
		_referral_example_payload = (string)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}
}
