[global::Cpp2ILInjected.Token(Token = "0x200000F")]
public class PurchasePage : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000058")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.UI.Button _loadProductsBtn;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000059")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::UnityEngine.UI.Button _loadPurchasesBtn;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400005A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private global::UnityEngine.GameObject _productRowPrefab;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400005B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private global::UnityEngine.Transform _productScrollTransform;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400005C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private global::UnityEngine.GameObject _purchaseRowPrefab;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400005D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::UnityEngine.Transform _purchaseScrollTransform;

	[global::Cpp2ILInjected.Token(Token = "0x400005E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private LogScroller _logScroller;

	[global::Cpp2ILInjected.Token(Token = "0x400005F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private global::System.Collections.Generic.IList<global::Facebook.Unity.Product> _products;

	[global::Cpp2ILInjected.Token(Token = "0x6000091")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8F50", Offset = "0xFD8F50", Length = "0x7C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0014;\n\tv17 = Il2CppMethodInfo;\n\tv18 = v17 + 0x778;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A8F3]) = v37;\nL_0014:\n\tv40 = UnityEngine.Component::get_transform(this);\n\tv43 = UnityEngine.Transform::get_root(v40);\n\tv54 = Il2CppMethodInfo;\n\tv47 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v43, *([v54 @ X8_v4 (Il2CppMethodInfo)+778]));\n\tv69 = this + 0x50;\n\tthis._logScroller = *([v47 @ X0_v7+20]);\n\tv60 = 0xF3F1B4(v69, *([v47 @ X0_v7+20]), v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 30 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_0038: Expected O, but got I
		//IL_004a: Expected O, but got I
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Transform root = transform.root;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		object obj = (nint)this + 80;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v7+20]");
		_logScroller = (LogScroller)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000092")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD8FCC", Offset = "0xFD8FCC", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv21 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv22 = v21 + 0xCB8;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0x7B0;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv56 = \"Cannot load image: download failed\";\n\tv57 = v56 + 0x4F0;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8F4]) = v42;\nL_001D:\n\tv48 = \"Cannot load image: download failed\";\n\tv50 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv52 = Il2CppMethodInfo;\n\tLogScroller::Log(this._logScroller, *([v48 @ X8_v3 (System.String)+4F0]));\n\tv59 = new *([v50 @ X20_v2 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CB8])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v59, this, *([v52 @ X21_v1 (Il2CppMethodInfo)+7B0]), 0);\n\tFacebook.Unity.FBGamingServices::OnIAPReady(v59);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void CheckReady()
	{
		//IL_001c: Expected I, but got O
		//IL_0039: Expected O, but got I
		string text = "Cannot load image: download failed";
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num2 = 0;
		LogScroller logScroller = _logScroller;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v48 @ X8_v3 (System.String)+4F0]");
		logScroller.Log((string)0);
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IIAPReadyResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Facebook.Unity.FBGamingServices.OnIAPReady(callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000093")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6798", Offset = "0xFD6798", Length = "0x180")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0027;\n\tv31 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv32 = v31 + 0xC98;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, purchase, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x538;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, purchase, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv58 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv59 = v58 + 0x870;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v59, purchase, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv62 = Il2CppFieldInfo;\n\tv63 = v62 + 0xD70;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, purchase, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv105 = \"Cannot load image: download failed\";\n\tv106 = v105 + 0x8A8;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v106, purchase, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302A8F5]) = v50;\nL_0027:\n\tv52 = new *([v26 @ X23_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+870])();\n\tSystem.Object::.ctor(v52);\n\tv66 = v52 + 0x10;\n\t*([v52 @ X0_v3 (System.Object)+10]) = this;\n\tv68 = 0xF3F1B4(v66, this, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv97 = v52 + 0x18;\n\t*([v52 @ X0_v3 (System.Object)+18]) = purchase;\n\tv110 = 0xF3F1B4(v97, purchase, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv103 = v52 + 0x20;\n\t*([v52 @ X0_v3 (System.Object)+20]) = callback;\n\tv88 = 0xF3F1B4(v103, callback, callback, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv99 = *([v52 @ X0_v3 (System.Object)+18]);\n\tv143 = \"Cannot load image: download failed\";\n\tv144 = Il2CppFieldInfo;\n\tv147 = System.String::Concat(*([v143 @ X9_v2 (System.String)+8A8]), *([v99 @ X8_v4+50]), *([v144 @ X10_v2 (Il2CppFieldInfo)+D70]), *([v99 @ X8_v4+30]));\n\tLogScroller::Log(this._logScroller, v147);\n\tv100 = *([v52 @ X0_v3 (System.Object)+20]);\n\t*([v100 @ X8_v5+18])(v90, *([v100 @ X8_v5+40]), 1, *([v100 @ X8_v5+28]), *([v99 @ X8_v4+30]), 0, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv101 = *([v52 @ X0_v3 (System.Object)+18]);\n\tv149 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv150 = Il2CppMethodInfo;\n\tv154 = new *([v149 @ X9_v5 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+C98])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v154, v52, *([v150 @ X22_v5 (Il2CppMethodInfo)+538]), 0);\n\tFacebook.Unity.FBGamingServices::ConsumePurchase(*([v101 @ X8_v6+50]), v154);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ConsumePurchase(global::Facebook.Unity.Purchase purchase, global::System.Action<bool> callback)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0060: Expected O, but got I
		//IL_007f: Expected O, but got I
		//IL_00c8: Expected O, but got I
		//IL_00c8: Expected O, but got I
		//IL_00c8: Expected O, but got I
		//IL_00c8: Expected O, but got I
		//IL_00f0: Expected O, but got I
		//IL_010f: Expected O, but got I
		//IL_0122: Expected I, but got O
		//IL_0151: Expected O, but got I
		nint num = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
		object obj = new object();
		object obj2 = (nint)obj + 16;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)obj + 24;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj4 = (nint)obj + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		object obj5 = 0;
		string text = "Cannot load image: download failed";
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X9_v2 (System.String)+8A8]");
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+50]");
		nint num4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X10_v2 (Il2CppFieldInfo)+D70]");
		nint num5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v99 @ X8_v4+30]");
		string text2 = (string)num3 + (string)num4 + (string)num5 + (string)0;
		_logScroller.Log(text2);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+20]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v100 @ X8_v5+18] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v52 @ X0_v3 (System.Object)+18]");
		object obj7 = 0;
		nint num6 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num7 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IConsumePurchaseResult> callback2 = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v101 @ X8_v6+50]");
		global::Facebook.Unity.FBGamingServices.ConsumePurchase((string)0, callback2);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000094")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD909C", Offset = "0xFD909C", Length = "0x378")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv29 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv30 = v29 + 0xC90;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv54 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv55 = v54 + 0x9F0;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv138 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv139 = v138 + 0xA90;\n\tv140 = \"il2cpp_codegen_initialize_runtime_metadata\"(v139, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv201 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv202 = v201 + 0xFD8;\n\tv203 = \"il2cpp_codegen_initialize_runtime_metadata\"(v202, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv212 = Il2CppMethodInfo;\n\tv213 = v212 + 0x7B8;\n\tv214 = \"il2cpp_codegen_initialize_runtime_metadata\"(v213, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv229 = System.Net.Configuration.SettingsSectionInternal;\n\tv230 = v229 + 0xAA8;\n\tv231 = \"il2cpp_codegen_initialize_runtime_metadata\"(v230, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv276 = \"IsCyrillic\";\n\tv277 = v276 + 0x9B0;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v277, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302A8F6]) = v50;\nL_002A:\n\tv51 = 0;\n\tv57 = \"IsCyrillic\";\n\tLogScroller::Log(this._logScroller, *([v57 @ X8_v12 (System.String)+9B0]));\n\tv204 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv205 = System.Net.Configuration.SettingsSectionInternal;\n\tv207 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv425 = UnityEngine.UIElements.EnumFieldHelpers + 0x9F0;\n\tv424 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char> + 0xC90;\n\tv423 = Il2CppMethodInfo + 0x7B8;\n\tv211 = UnityEngine.Transform::GetEnumerator(this._productScrollTransform);\n\tgoto L_004E;\nL_004C:\n\tUnityEngine.Object::Destroy(v654);\nL_004E:\n\tv271 = v111 == 0;\n\tif (v271) goto L_0127;\n\tv279 = *([v111 @ stack_-58_v6]);\n\tv334 = *([v279 @ X8_v18+12E]);\n\tv281 = *([v279 @ X8_v18+12E]) == 0;\n\tif (v281) goto L_0071;\n\tv333 = *([v279 @ X8_v18+B0]) + 8;\nL_0057:\n\t;\n\tv339 = *([v333 @ X10_v24-8]) == *([v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v339) goto L_0073;\n\tv333 = v333 + 0x10;\n\tv313 = v334 - 1;\n\tv293 = v334 != 1;\n\tif (v293) goto L_0057;\nL_0071:\n\tv399 = 0xF7087C(v111, *([v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_0077;\nL_0073:\n\t;\n\tv396 = *([v333 @ X10_v24]) << 4;\n\tv397 = v279 + v396;\n\tv399 = v397 + 0x138;\nL_0077:\n\t;\n\t*([v399 @ X0_v34])(v402, v111, *([v399 @ X0_v34+8]), v407, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv403 = v402 & 1;\n\tv404 = v403 == 0;\n\tif (v404) goto L_00D8;\n\tv387 = v111 == 0;\n\tif (v387) goto L_0129;\n\tv542 = *([v111 @ stack_-58_v6]);\n\tv618 = *([v542 @ X8_v22+12E]);\n\tv544 = *([v542 @ X8_v22+12E]) == 0;\n\tif (v544) goto L_00A2;\n\tv617 = *([v542 @ X8_v22+B0]) + 8;\nL_0088:\n\t;\n\tv623 = *([v617 @ X10_v19-8]) == *([v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v623) goto L_00A4;\n\tv617 = v617 + 0x10;\n\tv593 = v618 - 1;\n\tv573 = v618 != 1;\n\tif (v573) goto L_0088;\nL_00A2:\n\tv634 = 0xF7087C(v111, *([v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_00A9;\nL_00A4:\n\t;\n\tv630 = *([v617 @ X10_v19]) + 1;\n\tv631 = v630 << 4;\n\tv632 = v542 + v631;\n\tv634 = v632 + 0x138;\nL_00A9:\n\t;\n\t*([v634 @ X0_v40])(v637, v111, *([v634 @ X0_v40+8]), v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv189 = *([v205 @ X25_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv638 = *([v637 @ X0_v42 (UnityEngine.Component)]);\n\tv639 = *([v638 @ X8_v25 (Il2CppClass<UnityEngine.Component>)+130]) < *([v189 @ X1_v5+130]);\n\tv640 = ~v639;\n\tv648 = ~v640;\n\tif (v648) goto L_0125;\n\tv235 = *([v189 @ X1_v5+130]) << 3;\n\tv650 = *([v638 @ X8_v25 (Il2CppClass<UnityEngine.Component>)+C8]) + v235;\n\tv239 = *([v650 @ X8_v28-8]) != v189;\n\tif (v239) goto L_0125;\n\tv654 = UnityEngine.Component::get_gameObject(v637);\n\tgoto L_004C;\n\tv657 = \"il2cpp_codegen_runtime_class_init\"(v655, v653, v237, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_004C;\nL_00D8:\n\tv437 = &v111 @ stack_-58_v6;\n\tv428 = &v51 @ stack_-60_v1;\n\tv189 = *([v207 @ X24_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv432 = 0xF3F36C(*([v437 @ X8_v21]), *([v207 @ X24_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v407, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\t*([v428 @ X25_v9]) = v432;\n\tv435 = v432 == 0;\n\tif (v435) goto L_010C;\nL_00E1:\n\t;\n\tv442 = *([v432 @ X0_v22]);\n\tv558 = *([v442 @ X8_v8+12E]);\n\tv444 = *([v442 @ X8_v8+12E]) == 0;\n\tif (v444) goto L_0102;\n\tv557 = *([v442 @ X8_v8+B0]) + 8;\nL_00E8:\n\t;\n\tv563 = *([v557 @ X10_v9-8]) == *([v425 @ X24_v5]);\n\tif (v563) goto L_0104;\n\tv557 = v557 + 0x10;\n\tv537 = v558 - 1;\n\tv517 = v558 != 1;\n\tif (v517) goto L_00E8;\nL_0102:\n\tv604 = 0xF7087C(v432, *([v425 @ X24_v5]), 0, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_0108;\nL_0104:\n\t;\n\tv601 = *([v557 @ X10_v9]) << 4;\n\tv602 = v442 + v601;\n\tv604 = v602 + 0x138;\nL_0108:\n\t;\n\tv189 = *([v604 @ X0_v23+8]);\n\t*([v604 @ X0_v23])(v508, v432, *([v604 @ X0_v23+8]), v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_010C:\n\tv511 = v198 == 0;\n\tv194 = ~v511;\n\tif (v194) goto L_012F;\n\tv546 = new *([v180 @ X23_v1])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v546, this, *([v178 @ X22_v1]), 0);\n\tFacebook.Unity.FBGamingServices::GetCatalog(v546);\n\treturn;\nL_0125:\n\tv384 = new System.InvalidCastException();\n\tgoto L_012C;\nL_0127:\n\tv282 = new System.NullReferenceException();\n\tgoto L_012C;\nL_0129:\n\tv385 = new System.NullReferenceException();\n\tgoto L_012C;\n\tv383 = new System.NullReferenceException();\nL_012C:\n\t// 300 Interrupt\n\tthrow System.NullReferenceException;\nL_012F:\n\tv200 = new System.OutOfMemoryException();\n\tgoto L_013F;\n\tgoto L_013F;\n\tgoto L_013F;\n\tgoto L_013F;\n\tgoto L_013F;\nL_013F:\n\tv228 = v189 != 1;\n\tif (v228) goto L_0152;\n\tv273 = 0x274A080(v200, v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv438 = *([v273 @ X0_v18]);\n\tv285 = 0x274A098(v273, v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv189 = *([v182 @ X24_v1]);\n\tv432 = 0xF3F36C(*([v171 @ stack_-70_v3]), *([v182 @ X24_v1]), v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\t*([v169 @ stack_-68_v3]) = v432;\n\tv392 = v432 == 0;\n\tv393 = ~v392;\n\tif (v393) goto L_00E1;\n\tgoto L_010C;\n\tX20 = X0;\nL_0152:\n\tv275 = 0xBF079C(&v107 @ stack_-78_v2 (System.Int32), v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv287 = 0x27498DC(v200, v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv322 = 0xD6F8(v287, v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturn;\n// 177 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void LoadProducts()
	{
		//IL_068d: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_0038: Expected I, but got O
		//IL_0046: Expected I, but got O
		//IL_0054: Expected I, but got O
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_00e2: Expected O, but got I
		//IL_017c: Expected O, but got I4
		//IL_011e: Expected O, but got I
		//IL_03b9: Expected O, but got I
		//IL_0190: Expected I4, but got O
		//IL_019e: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_0465: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_04ff: Expected O, but got I4
		//IL_01f0: Expected O, but got I
		//IL_07b1: Expected O, but got I
		//IL_04a1: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_05e4: Expected I4, but got O
		//IL_022c: Expected O, but got I
		//IL_0648: Expected I4, but got O
		//IL_0513: Expected I4, but got O
		//IL_0521: Expected O, but got I
		//IL_0530: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_02ef: Expected I, but got O
		//IL_04b5: Expected O, but got I
		//IL_04c4: Expected O, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02bb: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_065e: Expected I4, but got O
		//IL_067e: Expected I4, but got O
		//IL_035f: Expected O, but got I
		//IL_0240: Expected O, but got I
		//IL_024f: Expected O, but got I
		object obj = 0;
		string text = "IsCyrillic";
		LogScroller logScroller = _logScroller;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v12 (System.String)+9B0]");
		logScroller.Log((string)0);
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		nint num3 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		object obj2 = typeof(global::UnityEngine.UIElements.EnumFieldHelpers) + 2544;
		object obj3 = typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>) + 3216;
		object obj4 = (nint)0 + (nint)1976;
		global::System.Collections.IEnumerator enumerator = _productScrollTransform.GetEnumerator();
		object obj5 = default(object);
		object obj18 = default(object);
		object obj20 = default(object);
		object obj13 = default(object);
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj32 = default(object);
		object obj19;
		object obj23;
		int num8;
		while (true)
		{
			object obj12;
			if (obj5 != null)
			{
				object obj6 = obj5;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v18+12E]");
				object obj7 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v18+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0169;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v18+B0]");
				object obj8 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X10_v24-8]");
					nint num4 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num4 == 0)
					{
						break;
					}
					obj8 = (nint)obj8 + 16;
					object obj9 = (nint)obj7 - 1;
					bool flag = (nint)obj7 != 1;
					obj7 = obj9;
					if (flag)
					{
						continue;
					}
					goto IL_0169;
				}
				int num5 = obj8 << 4;
				object obj10 = (nint)obj6 + num5;
				object obj11 = (nint)obj10 + 312;
				obj12 = obj13;
				goto IL_06c5;
			}
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			break;
			IL_073b:
			int num6;
			object obj14;
			object obj15;
			object obj16;
			int num7;
			object obj21;
			object obj22;
			object obj17;
			while (true)
			{
				bool flag2 = num6 == 0;
				bool flag3 = !flag2;
				obj4 = obj14;
				obj3 = obj15;
				obj2 = obj16;
				if (!flag3)
				{
					global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.ICatalogResult> callback = null;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
					global::Facebook.Unity.FBGamingServices.GetCatalog(callback);
					return;
				}
				global::System.OutOfMemoryException ex2 = new global::System.OutOfMemoryException();
				if ((nint)obj17 == 1)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
					num7 = (int)obj18;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
					obj17 = obj16;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
					obj19 = obj20;
					bool flag4 = obj20 == null;
					bool flag5 = !flag4;
					obj12 = obj13;
					obj21 = obj19;
					obj22 = obj23;
					num8 = (int)obj18;
					if (flag5)
					{
						break;
					}
					num8 = (int)obj18;
					obj14 = obj14;
					obj15 = obj15;
					obj16 = obj16;
					num6 = (int)obj18;
					continue;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF079C");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
				return;
			}
			goto IL_044c;
			IL_044c:
			object obj24 = obj20;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v8+12E]");
			object obj25 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04ec;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v8+B0]");
			object obj26 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X10_v9-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj26 = (nint)obj26 + 16;
				object obj27 = (nint)obj25 - 1;
				bool flag6 = (nint)obj25 != 1;
				obj25 = obj27;
				if (flag6)
				{
					continue;
				}
				goto IL_04ec;
			}
			int num9 = obj26 << 4;
			object obj28 = (nint)obj24 + num9;
			object obj29 = (nint)obj28 + 312;
			obj13 = obj12;
			goto IL_07a0;
			IL_0277:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			obj13 = 1;
			goto IL_072a;
			IL_072a:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v634 @ X0_v40] (should have been resolved before IL gen)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X25_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
			obj17 = 0;
			nint num10 = (nint)component;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v25 (Il2CppClass<UnityEngine.Component>)+130]");
			nint num11 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X1_v5+130]");
			if (num11 >= 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X1_v5+130]");
				int num12 = (int)((nint)0 << 3);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v25 (Il2CppClass<UnityEngine.Component>)+C8]");
				object obj30 = (nint)0 + (nint)num12;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v28-8]");
				if (0 == (nint)obj17)
				{
					global::UnityEngine.GameObject obj31 = component.gameObject;
					global::UnityEngine.Object.Destroy(obj31);
					continue;
				}
			}
			global::System.InvalidCastException ex3 = new global::System.InvalidCastException();
			break;
			IL_0169:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			obj12 = 0;
			goto IL_06c5;
			IL_06c5:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v399 @ X0_v34] (should have been resolved before IL gen)");
			if ((int)((nint)obj32 & 1) != 0)
			{
				if (obj5 != null)
				{
					object obj33 = obj5;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v22+12E]");
					object obj34 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v22+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0277;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v22+B0]");
					object obj35 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X10_v19-8]");
						nint num13 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num13 == 0)
						{
							break;
						}
						obj35 = (nint)obj35 + 16;
						object obj36 = (nint)obj34 - 1;
						bool flag7 = (nint)obj34 != 1;
						obj34 = obj36;
						if (flag7)
						{
							continue;
						}
						goto IL_0277;
					}
					object obj37 = obj35 + 1;
					int num14 = (int)((nint)obj37 << 4);
					object obj38 = (nint)obj33 + num14;
					object obj39 = (nint)obj38 + 312;
					obj13 = obj12;
					goto IL_072a;
				}
				global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
				break;
			}
			object obj40 = obj5;
			object obj41 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X24_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
			obj17 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			obj41 = obj20;
			bool flag8 = obj20 == null;
			obj21 = obj;
			obj22 = obj5;
			num8 = 0;
			num7 = 0;
			obj13 = obj12;
			obj19 = obj;
			obj23 = obj5;
			num8 = 0;
			obj14 = obj4;
			obj15 = obj3;
			obj16 = obj2;
			num6 = 0;
			if (!flag8)
			{
				goto IL_044c;
			}
			goto IL_073b;
			IL_07a0:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v23+8]");
			obj17 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v604 @ X0_v23] (should have been resolved before IL gen)");
			obj19 = obj21;
			obj23 = obj22;
			obj14 = obj4;
			obj15 = obj3;
			obj16 = obj2;
			num6 = num7;
			goto IL_073b;
			IL_04ec:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			obj13 = 0;
			goto IL_07a0;
		}
		obj19 = obj;
		obj23 = obj5;
		num8 = 0;
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000095")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD9414", Offset = "0xFD9414", Length = "0x378")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002A;\n\tv29 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv30 = v29 + 0xD00;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv54 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv55 = v54 + 0x9F0;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv138 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv139 = v138 + 0xA90;\n\tv140 = \"il2cpp_codegen_initialize_runtime_metadata\"(v139, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv201 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv202 = v201 + 0xFD8;\n\tv203 = \"il2cpp_codegen_initialize_runtime_metadata\"(v202, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv212 = Il2CppMethodInfo;\n\tv213 = v212 + 0x7C0;\n\tv214 = \"il2cpp_codegen_initialize_runtime_metadata\"(v213, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv229 = System.Net.Configuration.SettingsSectionInternal;\n\tv230 = v229 + 0xAA8;\n\tv231 = \"il2cpp_codegen_initialize_runtime_metadata\"(v230, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv276 = \"IsCyrillic\";\n\tv277 = v276 + 0x9B8;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v277, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302A8F7]) = v50;\nL_002A:\n\tv51 = 0;\n\tv57 = \"IsCyrillic\";\n\tLogScroller::Log(this._logScroller, *([v57 @ X8_v12 (System.String)+9B8]));\n\tv204 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv205 = System.Net.Configuration.SettingsSectionInternal;\n\tv207 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv425 = UnityEngine.UIElements.EnumFieldHelpers + 0x9F0;\n\tv424 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char> + 0xD00;\n\tv423 = Il2CppMethodInfo + 0x7C0;\n\tv211 = UnityEngine.Transform::GetEnumerator(this._purchaseScrollTransform);\n\tgoto L_004E;\nL_004C:\n\tUnityEngine.Object::Destroy(v654);\nL_004E:\n\tv271 = v111 == 0;\n\tif (v271) goto L_0127;\n\tv279 = *([v111 @ stack_-58_v6]);\n\tv334 = *([v279 @ X8_v18+12E]);\n\tv281 = *([v279 @ X8_v18+12E]) == 0;\n\tif (v281) goto L_0071;\n\tv333 = *([v279 @ X8_v18+B0]) + 8;\nL_0057:\n\t;\n\tv339 = *([v333 @ X10_v24-8]) == *([v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v339) goto L_0073;\n\tv333 = v333 + 0x10;\n\tv313 = v334 - 1;\n\tv293 = v334 != 1;\n\tif (v293) goto L_0057;\nL_0071:\n\tv399 = 0xF7087C(v111, *([v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_0077;\nL_0073:\n\t;\n\tv396 = *([v333 @ X10_v24]) << 4;\n\tv397 = v279 + v396;\n\tv399 = v397 + 0x138;\nL_0077:\n\t;\n\t*([v399 @ X0_v34])(v402, v111, *([v399 @ X0_v34+8]), v407, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv403 = v402 & 1;\n\tv404 = v403 == 0;\n\tif (v404) goto L_00D8;\n\tv387 = v111 == 0;\n\tif (v387) goto L_0129;\n\tv542 = *([v111 @ stack_-58_v6]);\n\tv618 = *([v542 @ X8_v22+12E]);\n\tv544 = *([v542 @ X8_v22+12E]) == 0;\n\tif (v544) goto L_00A2;\n\tv617 = *([v542 @ X8_v22+B0]) + 8;\nL_0088:\n\t;\n\tv623 = *([v617 @ X10_v19-8]) == *([v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v623) goto L_00A4;\n\tv617 = v617 + 0x10;\n\tv593 = v618 - 1;\n\tv573 = v618 != 1;\n\tif (v573) goto L_0088;\nL_00A2:\n\tv634 = 0xF7087C(v111, *([v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_00A9;\nL_00A4:\n\t;\n\tv630 = *([v617 @ X10_v19]) + 1;\n\tv631 = v630 << 4;\n\tv632 = v542 + v631;\n\tv634 = v632 + 0x138;\nL_00A9:\n\t;\n\t*([v634 @ X0_v40])(v637, v111, *([v634 @ X0_v40+8]), v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv189 = *([v205 @ X25_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv638 = *([v637 @ X0_v42 (UnityEngine.Component)]);\n\tv639 = *([v638 @ X8_v25 (Il2CppClass<UnityEngine.Component>)+130]) < *([v189 @ X1_v5+130]);\n\tv640 = ~v639;\n\tv648 = ~v640;\n\tif (v648) goto L_0125;\n\tv235 = *([v189 @ X1_v5+130]) << 3;\n\tv650 = *([v638 @ X8_v25 (Il2CppClass<UnityEngine.Component>)+C8]) + v235;\n\tv239 = *([v650 @ X8_v28-8]) != v189;\n\tif (v239) goto L_0125;\n\tv654 = UnityEngine.Component::get_gameObject(v637);\n\tgoto L_004C;\n\tv657 = \"il2cpp_codegen_runtime_class_init\"(v655, v653, v237, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_004C;\nL_00D8:\n\tv437 = &v111 @ stack_-58_v6;\n\tv428 = &v51 @ stack_-60_v1;\n\tv189 = *([v207 @ X24_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv432 = 0xF3F36C(*([v437 @ X8_v21]), *([v207 @ X24_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v407, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\t*([v428 @ X25_v9]) = v432;\n\tv435 = v432 == 0;\n\tif (v435) goto L_010C;\nL_00E1:\n\t;\n\tv442 = *([v432 @ X0_v22]);\n\tv558 = *([v442 @ X8_v8+12E]);\n\tv444 = *([v442 @ X8_v8+12E]) == 0;\n\tif (v444) goto L_0102;\n\tv557 = *([v442 @ X8_v8+B0]) + 8;\nL_00E8:\n\t;\n\tv563 = *([v557 @ X10_v9-8]) == *([v425 @ X24_v5]);\n\tif (v563) goto L_0104;\n\tv557 = v557 + 0x10;\n\tv537 = v558 - 1;\n\tv517 = v558 != 1;\n\tif (v517) goto L_00E8;\nL_0102:\n\tv604 = 0xF7087C(v432, *([v425 @ X24_v5]), 0, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_0108;\nL_0104:\n\t;\n\tv601 = *([v557 @ X10_v9]) << 4;\n\tv602 = v442 + v601;\n\tv604 = v602 + 0x138;\nL_0108:\n\t;\n\tv189 = *([v604 @ X0_v23+8]);\n\t*([v604 @ X0_v23])(v508, v432, *([v604 @ X0_v23+8]), v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_010C:\n\tv511 = v198 == 0;\n\tv194 = ~v511;\n\tif (v194) goto L_012F;\n\tv546 = new *([v180 @ X23_v1])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v546, this, *([v178 @ X22_v1]), 0);\n\tFacebook.Unity.FBGamingServices::GetPurchases(v546);\n\treturn;\nL_0125:\n\tv384 = new System.InvalidCastException();\n\tgoto L_012C;\nL_0127:\n\tv282 = new System.NullReferenceException();\n\tgoto L_012C;\nL_0129:\n\tv385 = new System.NullReferenceException();\n\tgoto L_012C;\n\tv383 = new System.NullReferenceException();\nL_012C:\n\t// 300 Interrupt\n\tthrow System.NullReferenceException;\nL_012F:\n\tv200 = new System.OutOfMemoryException();\n\tgoto L_013F;\n\tgoto L_013F;\n\tgoto L_013F;\n\tgoto L_013F;\n\tgoto L_013F;\nL_013F:\n\tv228 = v189 != 1;\n\tif (v228) goto L_0152;\n\tv273 = 0x274A080(v200, v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv438 = *([v273 @ X0_v18]);\n\tv285 = 0x274A098(v273, v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv189 = *([v182 @ X24_v1]);\n\tv432 = 0xF3F36C(*([v171 @ stack_-70_v3]), *([v182 @ X24_v1]), v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\t*([v169 @ stack_-68_v3]) = v432;\n\tv392 = v432 == 0;\n\tv393 = ~v392;\n\tif (v393) goto L_00E1;\n\tgoto L_010C;\n\tX20 = X0;\nL_0152:\n\tv275 = 0xBF079C(&v107 @ stack_-78_v2 (System.Int32), v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv287 = 0x27498DC(v200, v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv322 = 0xD6F8(v287, v189, v145, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\treturn;\n// 177 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void LoadPurchases()
	{
		//IL_068d: Expected O, but got I4
		//IL_0025: Expected O, but got I
		//IL_0038: Expected I, but got O
		//IL_0046: Expected I, but got O
		//IL_0054: Expected I, but got O
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_0077: Unknown result type (might be due to invalid IL or missing references)
		//IL_007c: Expected O, but got Unknown
		//IL_0088: Expected O, but got I
		//IL_00e2: Expected O, but got I
		//IL_017c: Expected O, but got I4
		//IL_011e: Expected O, but got I
		//IL_03b9: Expected O, but got I
		//IL_0190: Expected I4, but got O
		//IL_019e: Expected O, but got I
		//IL_01ad: Expected O, but got I
		//IL_0465: Expected O, but got I
		//IL_0132: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_04ff: Expected O, but got I4
		//IL_01f0: Expected O, but got I
		//IL_07b1: Expected O, but got I
		//IL_04a1: Expected O, but got I
		//IL_028a: Expected O, but got I4
		//IL_05e4: Expected I4, but got O
		//IL_022c: Expected O, but got I
		//IL_0648: Expected I4, but got O
		//IL_0513: Expected I4, but got O
		//IL_0521: Expected O, but got I
		//IL_0530: Expected O, but got I
		//IL_02e7: Expected O, but got I
		//IL_02ef: Expected I, but got O
		//IL_04b5: Expected O, but got I
		//IL_04c4: Expected O, but got I
		//IL_0299: Unknown result type (might be due to invalid IL or missing references)
		//IL_029e: Expected O, but got Unknown
		//IL_02bb: Expected O, but got I
		//IL_02ca: Expected O, but got I
		//IL_065e: Expected I4, but got O
		//IL_067e: Expected I4, but got O
		//IL_035f: Expected O, but got I
		//IL_0240: Expected O, but got I
		//IL_024f: Expected O, but got I
		object obj = 0;
		string text = "IsCyrillic";
		LogScroller logScroller = _logScroller;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v12 (System.String)+9B8]");
		logScroller.Log((string)0);
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		nint num3 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		object obj2 = typeof(global::UnityEngine.UIElements.EnumFieldHelpers) + 2544;
		object obj3 = typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>) + 3328;
		object obj4 = (nint)0 + (nint)1984;
		global::System.Collections.IEnumerator enumerator = _purchaseScrollTransform.GetEnumerator();
		object obj5 = default(object);
		object obj18 = default(object);
		object obj20 = default(object);
		object obj13 = default(object);
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj32 = default(object);
		object obj19;
		object obj23;
		int num8;
		while (true)
		{
			object obj12;
			if (obj5 != null)
			{
				object obj6 = obj5;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v18+12E]");
				object obj7 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v18+12E]");
				if ((nint)0 == 0)
				{
					goto IL_0169;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v279 @ X8_v18+B0]");
				object obj8 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v333 @ X10_v24-8]");
					nint num4 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num4 == 0)
					{
						break;
					}
					obj8 = (nint)obj8 + 16;
					object obj9 = (nint)obj7 - 1;
					bool flag = (nint)obj7 != 1;
					obj7 = obj9;
					if (flag)
					{
						continue;
					}
					goto IL_0169;
				}
				int num5 = obj8 << 4;
				object obj10 = (nint)obj6 + num5;
				object obj11 = (nint)obj10 + 312;
				obj12 = obj13;
				goto IL_06c5;
			}
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			break;
			IL_073b:
			int num6;
			object obj14;
			object obj15;
			object obj16;
			int num7;
			object obj21;
			object obj22;
			object obj17;
			while (true)
			{
				bool flag2 = num6 == 0;
				bool flag3 = !flag2;
				obj4 = obj14;
				obj3 = obj15;
				obj2 = obj16;
				if (!flag3)
				{
					global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchasesResult> callback = null;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
					global::Facebook.Unity.FBGamingServices.GetPurchases(callback);
					return;
				}
				global::System.OutOfMemoryException ex2 = new global::System.OutOfMemoryException();
				if ((nint)obj17 == 1)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
					num7 = (int)obj18;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
					obj17 = obj16;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
					obj19 = obj20;
					bool flag4 = obj20 == null;
					bool flag5 = !flag4;
					obj12 = obj13;
					obj21 = obj19;
					obj22 = obj23;
					num8 = (int)obj18;
					if (flag5)
					{
						break;
					}
					num8 = (int)obj18;
					obj14 = obj14;
					obj15 = obj15;
					obj16 = obj16;
					num6 = (int)obj18;
					continue;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF079C");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
				return;
			}
			goto IL_044c;
			IL_044c:
			object obj24 = obj20;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v8+12E]");
			object obj25 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_04ec;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v442 @ X8_v8+B0]");
			object obj26 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v557 @ X10_v9-8]");
				if (0 == (nint)obj2)
				{
					break;
				}
				obj26 = (nint)obj26 + 16;
				object obj27 = (nint)obj25 - 1;
				bool flag6 = (nint)obj25 != 1;
				obj25 = obj27;
				if (flag6)
				{
					continue;
				}
				goto IL_04ec;
			}
			int num9 = obj26 << 4;
			object obj28 = (nint)obj24 + num9;
			object obj29 = (nint)obj28 + 312;
			obj13 = obj12;
			goto IL_07a0;
			IL_0277:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			obj13 = 1;
			goto IL_072a;
			IL_072a:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v634 @ X0_v40] (should have been resolved before IL gen)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v205 @ X25_v7 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
			obj17 = 0;
			nint num10 = (nint)component;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v25 (Il2CppClass<UnityEngine.Component>)+130]");
			nint num11 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X1_v5+130]");
			if (num11 >= 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v189 @ X1_v5+130]");
				int num12 = (int)((nint)0 << 3);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v638 @ X8_v25 (Il2CppClass<UnityEngine.Component>)+C8]");
				object obj30 = (nint)0 + (nint)num12;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v650 @ X8_v28-8]");
				if (0 == (nint)obj17)
				{
					global::UnityEngine.GameObject obj31 = component.gameObject;
					global::UnityEngine.Object.Destroy(obj31);
					continue;
				}
			}
			global::System.InvalidCastException ex3 = new global::System.InvalidCastException();
			break;
			IL_0169:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			obj12 = 0;
			goto IL_06c5;
			IL_06c5:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v399 @ X0_v34] (should have been resolved before IL gen)");
			if ((int)((nint)obj32 & 1) != 0)
			{
				if (obj5 != null)
				{
					object obj33 = obj5;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v22+12E]");
					object obj34 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v22+12E]");
					if ((nint)0 == 0)
					{
						goto IL_0277;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X8_v22+B0]");
					object obj35 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X10_v19-8]");
						nint num13 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num13 == 0)
						{
							break;
						}
						obj35 = (nint)obj35 + 16;
						object obj36 = (nint)obj34 - 1;
						bool flag7 = (nint)obj34 != 1;
						obj34 = obj36;
						if (flag7)
						{
							continue;
						}
						goto IL_0277;
					}
					object obj37 = obj35 + 1;
					int num14 = (int)((nint)obj37 << 4);
					object obj38 = (nint)obj33 + num14;
					object obj39 = (nint)obj38 + 312;
					obj13 = obj12;
					goto IL_072a;
				}
				global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
				break;
			}
			object obj40 = obj5;
			object obj41 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v207 @ X24_v6 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
			obj17 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			obj41 = obj20;
			bool flag8 = obj20 == null;
			obj21 = obj;
			obj22 = obj5;
			num8 = 0;
			num7 = 0;
			obj13 = obj12;
			obj19 = obj;
			obj23 = obj5;
			num8 = 0;
			obj14 = obj4;
			obj15 = obj3;
			obj16 = obj2;
			num6 = 0;
			if (!flag8)
			{
				goto IL_044c;
			}
			goto IL_073b;
			IL_07a0:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X0_v23+8]");
			obj17 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v604 @ X0_v23] (should have been resolved before IL gen)");
			obj19 = obj21;
			obj23 = obj22;
			obj14 = obj4;
			obj15 = obj3;
			obj16 = obj2;
			num6 = num7;
			goto IL_073b;
			IL_04ec:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			obj13 = 0;
			goto IL_07a0;
		}
		obj19 = obj;
		obj23 = obj5;
		num8 = 0;
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000096")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD61F0", Offset = "0xFD61F0", Length = "0x148")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_0026;\n\tv29 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv30 = v29 + 0xCF8;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, product, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv52 = Il2CppMethodInfo;\n\tv53 = v52 + 0x540;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, product, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv57 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv58 = v57 + 0x878;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, product, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv61 = \"Parent table name is missing in relation '{0}'.\";\n\tv62 = v61 + 0x5A0;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, product, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv89 = Il2CppFieldInfo;\n\tv90 = v89 + 0x960;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v90, product, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv49 = 1;\n\t*([302A8F8]) = v49;\nL_0026:\n\tv51 = new *([v24 @ X22_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+878])();\n\tSystem.Object::.ctor(v51);\n\tv65 = v51 + 0x10;\n\t*([v51 @ X0_v3 (System.Object)+10]) = this;\n\tv67 = 0xF3F1B4(v65, this, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv84 = v51 + 0x18;\n\t*([v51 @ X0_v3 (System.Object)+18]) = product;\n\tv77 = 0xF3F1B4(v84, product, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv86 = *([v51 @ X0_v3 (System.Object)+18]);\n\tv121 = \"Parent table name is missing in relation '{0}'.\";\n\tv124 = System.String::Concat(*([v121 @ X9_v2 (System.String)+5A0]), *([v86 @ X8_v4+18]));\n\tLogScroller::Log(this._logScroller, v124);\n\tv87 = *([v51 @ X0_v3 (System.Object)+18]);\n\tv125 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv126 = Il2CppMethodInfo;\n\tv128 = Il2CppFieldInfo;\n\tv132 = new *([v125 @ X9_v4 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+CF8])();\n\tFacebook.Unity.FacebookDelegate`1::.ctor /* +1 sharing this address */(v132, v51, *([v126 @ X22_v6 (Il2CppMethodInfo)+540]), 0);\n\tFacebook.Unity.FBGamingServices::Purchase(*([v87 @ X8_v5+18]), v132, *([v128 @ X23_v1 (Il2CppFieldInfo)+960]));\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 62 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void MakePurchase(global::Facebook.Unity.Product product)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected O, but got I
		//IL_003d: Expected O, but got I
		//IL_0061: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_008c: Expected O, but got I
		//IL_00b4: Expected O, but got I
		//IL_00c7: Expected I, but got O
		//IL_0108: Expected O, but got I
		//IL_0108: Expected O, but got I
		nint num = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
		object obj = new object();
		object obj2 = (nint)obj + 16;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)obj + 24;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		object obj4 = 0;
		string text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X9_v2 (System.String)+5A0]");
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X8_v4+18]");
		string text2 = (string)num2 + (string)0;
		_logScroller.Log(text2);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X0_v3 (System.Object)+18]");
		object obj5 = 0;
		nint num3 = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		nint num4 = 0;
		nint num5 = 0;
		global::Facebook.Unity.FacebookDelegate<global::Facebook.Unity.IPurchaseResult> callback = null;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @154E9A0 (Facebook.Unity.FacebookDelegate`1::.ctor, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X8_v5+18]");
		nint num6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v128 @ X23_v1 (Il2CppFieldInfo)+960]");
		global::Facebook.Unity.FBGamingServices.Purchase((string)num6, callback, (string)0);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000097")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD9794", Offset = "0xFD9794", Length = "0x2E8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001D;\n\tv27 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv28 = v27 + 0x9F0;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, show, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv51 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv52 = v51 + 0xA90;\n\tv53 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, show, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv129 = System.Net.Configuration.SettingsSectionInternal;\n\tv130 = v129 + 0xAA8;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v130, show, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv47 = 1;\n\t*([302A8F9]) = v47;\nL_001D:\n\tv48 = 0;\n\tv54 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv56 = System.Net.Configuration.SettingsSectionInternal;\n\tv58 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv409 = UnityEngine.UIElements.EnumFieldHelpers + 0x9F0;\n\tv61 = UnityEngine.Transform::GetEnumerator(this._purchaseScrollTransform);\nL_0030:\n\tv229 = v113 == 0;\n\tif (v229) goto L_00FB;\n\tv231 = *([v113 @ stack_-48_v6]);\n\tv290 = *([v231 @ X8_v16+12E]);\n\tv233 = *([v231 @ X8_v16+12E]) == 0;\n\tif (v233) goto L_0053;\n\tv289 = *([v231 @ X8_v16+B0]) + 8;\nL_003E:\n\tv295 = *([v289 @ X10_v24-8]) == *([v54 @ X22_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v295) goto L_0056;\n\tv289 = v289 + 0x10;\n\tv271 = v290 - 1;\n\tv251 = v290 != 1;\n\tif (v251) goto L_003E;\nL_0053:\n\tv360 = 0xF7087C(v113, *([v54 @ X22_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_005C;\nL_0056:\n\tv357 = *([v289 @ X10_v24]) << 4;\n\tv358 = v231 + v357;\n\tv360 = v358 + 0x138;\nL_005C:\n\t*([v360 @ X0_v30])(v363, v113, *([v360 @ X0_v30+8]), v387, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv364 = v363 & 1;\n\tv365 = v364 == 0;\n\tif (v365) goto L_00B8;\n\tv346 = v113 == 0;\n\tif (v346) goto L_00FD;\n\tv381 = *([v113 @ stack_-48_v6]);\n\tv543 = *([v381 @ X8_v20+12E]);\n\tv383 = *([v381 @ X8_v20+12E]) == 0;\n\tif (v383) goto L_0084;\n\tv542 = *([v381 @ X8_v20+B0]) + 8;\nL_006F:\n\tv548 = *([v542 @ X10_v19-8]) == *([v54 @ X22_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]);\n\tif (v548) goto L_0087;\n\tv542 = v542 + 0x10;\n\tv480 = v543 - 1;\n\tv460 = v543 != 1;\n\tif (v460) goto L_006F;\nL_0084:\n\tv580 = 0xF7087C(v113, *([v54 @ X22_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]), 1, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_008E;\nL_0087:\n\tv576 = *([v542 @ X10_v19]) + 1;\n\tv577 = v576 << 4;\n\tv578 = v381 + v577;\n\tv580 = v578 + 0x138;\nL_008E:\n\t*([v580 @ X0_v36])(v583, v113, *([v580 @ X0_v36+8]), v138, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv170 = *([v56 @ X23_v6 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]);\n\tv592 = *([v583 @ X0_v38 (UnityEngine.Component)]);\n\tv593 = *([v592 @ X8_v23 (Il2CppClass<UnityEngine.Component>)+130]) < *([v170 @ X1_v3 (System.Boolean)+130]);\n\tv594 = ~v593;\n\tv602 = ~v594;\n\tif (v602) goto L_00F9;\n\tv193 = *([v170 @ X1_v3 (System.Boolean)+130]) << 3;\n\tv604 = *([v592 @ X8_v23 (Il2CppClass<UnityEngine.Component>)+C8]) + v193;\n\tv197 = *([v604 @ X8_v26-8]) != v170;\n\tif (v197) goto L_00F9;\n\tv221 = UnityEngine.Component::get_gameObject(v583);\n\tv223 = v221 == 0;\n\tif (v223) goto L_00FF;\n\tUnityEngine.GameObject::SetActive(v221, show);\n\tgoto L_0030;\nL_00B8:\n\tv373 = &v113 @ stack_-48_v6;\n\tv374 = &v48 @ stack_-50_v1;\n\tv170 = *([v58 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]);\n\tv406 = 0xF3F36C(*([v373 @ X8_v19]), *([v58 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]), v387, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([v374 @ X22_v9]) = v406;\n\tv384 = v406 == 0;\n\tif (v384) goto L_00EC;\nL_00C2:\n\tv414 = *([v406 @ X0_v19]);\n\tv564 = *([v414 @ X8_v8+12E]);\n\tv416 = *([v414 @ X8_v8+12E]) == 0;\n\tif (v416) goto L_00E2;\n\tv563 = *([v414 @ X8_v8+B0]) + 8;\nL_00CD:\n\tv569 = *([v563 @ X10_v9-8]) == *([v409 @ X21_v6 (System.Int32)]);\n\tif (v569) goto L_00E5;\n\tv563 = v563 + 0x10;\n\tv528 = v564 - 1;\n\tv508 = v564 != 1;\n\tif (v508) goto L_00CD;\nL_00E2:\n\tv589 = 0xF7087C(v406, *([v409 @ X21_v6 (System.Int32)]), 0, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tgoto L_00E9;\nL_00E5:\n\tv586 = *([v563 @ X10_v9]) << 4;\n\tv587 = v414 + v586;\n\tv589 = v587 + 0x138;\nL_00E9:\n\tv170 = *([v589 @ X0_v20+8]);\n\t*([v589 @ X0_v20])(v499, v406, *([v589 @ X0_v20+8]), v138, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\nL_00EC:\n\tv502 = v187 == 0;\n\tv179 = ~v502;\n\tif (v179) goto L_0105;\n\treturn;\nL_00F9:\n\tv342 = new System.InvalidCastException();\n\tgoto L_0102;\nL_00FB:\n\tv234 = new System.NullReferenceException();\n\tgoto L_0102;\nL_00FD:\n\tv343 = new System.NullReferenceException();\n\tgoto L_0102;\nL_00FF:\n\tv344 = new System.NullReferenceException();\n\tgoto L_0102;\n\tv341 = new System.NullReferenceException();\nL_0102:\n\t// 258 Interrupt\n\tthrow System.NullReferenceException;\nL_0105:\n\tv189 = new System.OutOfMemoryException();\n\tgoto L_0117;\n\tgoto L_0117;\n\tgoto L_0117;\n\tgoto L_0117;\n\tgoto L_0117;\n\tgoto L_0117;\n\tgoto L_0117;\nL_0117:\n\tv245 = v170 != 1;\n\tif (v245) goto L_012A;\n\tv276 = 0x274A080(v189, v170, v138, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv411 = *([v276 @ X0_v15]);\n\tv352 = 0x274A098(v276, v170, v138, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv170 = *([v183 @ X21_v3 (System.Int32)]);\n\tv406 = 0xF3F36C(*([v164 @ stack_-60_v3]), *([v183 @ X21_v3 (System.Int32)]), v138, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\t*([v162 @ stack_-58_v3]) = v406;\n\tv378 = v406 == 0;\n\tv379 = ~v378;\n\tif (v379) goto L_00C2;\n\tgoto L_00EC;\n\tX19 = X0;\nL_012A:\n\tv278 = 0xBF079C(&v109 @ stack_-68_v1 (System.Int32), v170, v138, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv354 = 0x27498DC(v189, v170, v138, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv371 = 0xD6F8(v354, v170, v138, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\treturn;\n// 163 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ToggleShowConsumedClicked(bool show)
	{
		//IL_05ff: Expected O, but got I4
		//IL_0013: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_002f: Expected I, but got O
		//IL_003e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0043: Expected I4, but got Unknown
		//IL_0070: Expected O, but got I
		//IL_0105: Expected I, but got O
		//IL_00ab: Expected O, but got I
		//IL_0118: Expected I4, but got O
		//IL_0126: Expected O, but got I
		//IL_0135: Expected O, but got I
		//IL_013a: Expected I, but got O
		//IL_03fc: Expected O, but got I
		//IL_00bf: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_0491: Expected I, but got O
		//IL_0174: Expected O, but got I
		//IL_0437: Expected O, but got I
		//IL_0566: Expected I4, but got O
		//IL_01af: Expected O, but got I
		//IL_05ca: Expected I4, but got O
		//IL_04a4: Expected I4, but got O
		//IL_04b2: Expected O, but got I
		//IL_04c1: Expected O, but got I
		//IL_0271: Expected I, but got O
		//IL_044b: Expected O, but got I
		//IL_045a: Expected O, but got I
		//IL_021b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0220: Expected O, but got Unknown
		//IL_023d: Expected O, but got I
		//IL_024c: Expected O, but got I
		//IL_05e0: Expected I4, but got O
		//IL_05f0: Expected I4, but got O
		//IL_02de: Expected O, but got I
		//IL_01c3: Expected O, but got I
		//IL_01d2: Expected O, but got I
		object obj = 0;
		nint num = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		nint num2 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		nint num3 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		int num4 = typeof(global::UnityEngine.UIElements.EnumFieldHelpers) + 2544;
		global::System.Collections.IEnumerator enumerator = _purchaseScrollTransform.GetEnumerator();
		object obj2 = default(object);
		object obj9 = default(object);
		object obj11 = default(object);
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		object obj16 = default(object);
		object obj10;
		object obj14;
		int num12;
		while (true)
		{
			nint num7;
			if (obj2 != null)
			{
				object obj3 = obj2;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v16+12E]");
				object obj4 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v16+12E]");
				if ((nint)0 == 0)
				{
					goto IL_00f6;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v231 @ X8_v16+B0]");
				object obj5 = (nint)0 + (nint)8;
				while (true)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v289 @ X10_v24-8]");
					nint num5 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X22_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
					if (num5 == 0)
					{
						break;
					}
					obj5 = (nint)obj5 + 16;
					object obj6 = (nint)obj4 - 1;
					bool flag = (nint)obj4 != 1;
					obj4 = obj6;
					if (flag)
					{
						continue;
					}
					goto IL_00f6;
				}
				int num6 = obj5 << 4;
				object obj7 = (nint)obj3 + num6;
				object obj8 = (nint)obj7 + 312;
				num7 = unchecked((nint)null);
				goto IL_0630;
			}
			global::System.NullReferenceException ex = new global::System.NullReferenceException();
			break;
			IL_06be:
			int num8;
			int num9;
			int num10;
			object obj12;
			object obj13;
			bool flag4;
			nint num11;
			while (true)
			{
				bool flag2 = num8 == 0;
				bool flag3 = !flag2;
				num4 = num9;
				if (!flag3)
				{
					return;
				}
				global::System.OutOfMemoryException ex2 = new global::System.OutOfMemoryException();
				if (flag4)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
					num10 = (int)obj9;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
					flag4 = (byte)num9 != 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
					obj10 = obj11;
					bool flag5 = obj11 == null;
					bool flag6 = !flag5;
					num7 = num11;
					obj12 = obj10;
					obj13 = obj14;
					num12 = (int)obj9;
					if (flag6)
					{
						break;
					}
					num12 = (int)obj9;
					num9 = num9;
					num8 = (int)obj9;
					continue;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF079C");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
				return;
			}
			goto IL_03e4;
			IL_0482:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num11 = unchecked((nint)null);
			goto IL_0712;
			IL_01fa:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num11 = 1;
			goto IL_0692;
			IL_0692:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v580 @ X0_v36] (should have been resolved before IL gen)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v56 @ X23_v6 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+AA8]");
			flag4 = false;
			nint num13 = (nint)component;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v23 (Il2CppClass<UnityEngine.Component>)+130]");
			nint num14 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v3 (System.Boolean)+130]");
			if (num14 >= 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v170 @ X1_v3 (System.Boolean)+130]");
				int num15 = (int)((nint)0 << 3);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v23 (Il2CppClass<UnityEngine.Component>)+C8]");
				object obj15 = (nint)0 + (nint)num15;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v604 @ X8_v26-8]");
				if ((nint)0 == (flag4 ? 1 : 0))
				{
					global::UnityEngine.GameObject gameObject = component.gameObject;
					if ((object)gameObject != null)
					{
						gameObject.SetActive(show);
						continue;
					}
					global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
					break;
				}
			}
			global::System.InvalidCastException ex4 = new global::System.InvalidCastException();
			break;
			IL_00f6:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
			num7 = unchecked((nint)null);
			goto IL_0630;
			IL_0630:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v360 @ X0_v30] (should have been resolved before IL gen)");
			if ((int)((nint)obj16 & 1) != 0)
			{
				if (obj2 != null)
				{
					object obj17 = obj2;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v20+12E]");
					object obj18 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v20+12E]");
					if ((nint)0 == 0)
					{
						goto IL_01fa;
					}
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v381 @ X8_v20+B0]");
					object obj19 = (nint)0 + (nint)8;
					while (true)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v542 @ X10_v19-8]");
						nint num16 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X22_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+A90]");
						if (num16 == 0)
						{
							break;
						}
						obj19 = (nint)obj19 + 16;
						object obj20 = (nint)obj18 - 1;
						bool flag7 = (nint)obj18 != 1;
						obj18 = obj20;
						if (flag7)
						{
							continue;
						}
						goto IL_01fa;
					}
					object obj21 = obj19 + 1;
					int num17 = (int)((nint)obj21 << 4);
					object obj22 = (nint)obj17 + num17;
					object obj23 = (nint)obj22 + 312;
					num11 = num7;
					goto IL_0692;
				}
				global::System.NullReferenceException ex5 = new global::System.NullReferenceException();
				break;
			}
			object obj24 = obj2;
			object obj25 = obj;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X21_v7 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+9F0]");
			flag4 = false;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F36C");
			obj25 = obj11;
			bool flag8 = obj11 == null;
			obj12 = obj;
			obj13 = obj2;
			num12 = 0;
			num10 = 0;
			num11 = num7;
			obj10 = obj;
			obj14 = obj2;
			num12 = 0;
			num9 = num4;
			num8 = 0;
			if (!flag8)
			{
				goto IL_03e4;
			}
			goto IL_06be;
			IL_03e4:
			object obj26 = obj11;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v8+12E]");
			object obj27 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v8+12E]");
			if ((nint)0 == 0)
			{
				goto IL_0482;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v414 @ X8_v8+B0]");
			object obj28 = (nint)0 + (nint)8;
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v563 @ X10_v9-8]");
				if ((nint)0 == num4)
				{
					break;
				}
				obj28 = (nint)obj28 + 16;
				object obj29 = (nint)obj27 - 1;
				bool flag9 = (nint)obj27 != 1;
				obj27 = obj29;
				if (flag9)
				{
					continue;
				}
				goto IL_0482;
			}
			int num18 = obj28 << 4;
			object obj30 = (nint)obj26 + num18;
			object obj31 = (nint)obj30 + 312;
			num11 = num7;
			goto IL_0712;
			IL_0712:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v589 @ X0_v20+8]");
			flag4 = false;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v589 @ X0_v20] (should have been resolved before IL gen)");
			obj10 = obj12;
			obj14 = obj13;
			num9 = num4;
			num8 = num10;
			goto IL_06be;
		}
		obj10 = obj;
		obj14 = obj2;
		num12 = 0;
		throw new global::System.NullReferenceException();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000098")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD9A7C", Offset = "0xFD9A7C", Length = "0x13C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv28 = 0x302A000;\n\tv30 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv32 = *([302A8FA]) & 1;\n\tv33 = v32 == 0;\n\tif (v33) goto L_0030;\n\tv61 = Il2CppMethodInfo + 0xA8;\n\tv67 = this._purchaseRowPrefab;\n\tv59 = this._purchaseScrollTransform;\n\tv38 = *([v30 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv40 = *([v38 @ X0_v24+E0]) == 0;\n\tif (v40) goto L_003E;\nL_0021:\n\tv94 = UnityEngine.Object::Instantiate /* +1 sharing this address */(v67, v59, *([v61 @ X25_v8]));\n\tv83 = v94 == 0;\n\tv84 = ~v83;\n\tif (v84) goto L_0042;\n\tgoto L_006E;\nL_0030:\n\t*([v28 @ X22_v1+8FA]) = 1;\n\tv61 = Il2CppMethodInfo + 0xA8;\n\tv67 = this._purchaseRowPrefab;\n\tv59 = this._purchaseScrollTransform;\n\tv58 = *([v30 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv108 = *([v58 @ X0_v20+E0]) == 0;\n\tv64 = ~v108;\n\tif (v64) goto L_0021;\nL_003E:\n\tv94 = UnityEngine.Object::Instantiate /* +1 sharing this address */(v78, v74, *([v75 @ X25_v5]));\nL_0042:\n\tv102 = Il2CppMethodInfo;\n\tv105 = UnityEngine.GameObject::GetComponent /* +1 sharing this address */(v94, *([v102 @ X8_v4 (Il2CppMethodInfo)+A98]));\n\tPurchaseRowPrefab::Initialize(v105, this, this._logScroller, purchase);\n\tv145 = ~setToTop;\n\tif (v145) goto L_006D;\n\tv116 = UnityEngine.GameObject::get_transform(v94);\n\tUnityEngine.Transform::SetSiblingIndex(v116, 0);\n\treturn;\nL_006D:\n\treturn;\nL_006E:\n\tthrow System.NullReferenceException;\n// 77 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void AddPurchase(global::Facebook.Unity.Purchase purchase, bool setToTop)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_0104: Expected O, but got I
		//IL_0128: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_007a: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A8FA]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)168;
			global::UnityEngine.GameObject purchaseRowPrefab = _purchaseRowPrefab;
			global::UnityEngine.Transform purchaseScrollTransform = _purchaseScrollTransform;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v38 @ X0_v24+E0]");
			bool flag = (nint)0 == 0;
			global::UnityEngine.Transform purchaseScrollTransform2 = _purchaseScrollTransform;
			object obj4 = obj2;
			global::UnityEngine.GameObject purchaseRowPrefab2 = _purchaseRowPrefab;
			if (!flag)
			{
				goto IL_00bb;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)168;
			global::UnityEngine.GameObject purchaseRowPrefab = _purchaseRowPrefab;
			global::UnityEngine.Transform purchaseScrollTransform = _purchaseScrollTransform;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v30 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v58 @ X0_v20+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			global::UnityEngine.Transform purchaseScrollTransform2 = _purchaseScrollTransform;
			object obj4 = obj2;
			global::UnityEngine.GameObject purchaseRowPrefab2 = _purchaseRowPrefab;
			if (flag3)
			{
				goto IL_00bb;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		goto IL_0183;
		IL_0183:
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @114831C (UnityEngine.GameObject::GetComponent, and 1 more at this address)");
		PurchaseRowPrefab purchaseRowPrefab3 = default(PurchaseRowPrefab);
		purchaseRowPrefab3.Initialize(this, _logScroller, purchase);
		global::UnityEngine.GameObject gameObject = default(global::UnityEngine.GameObject);
		if (setToTop)
		{
			global::UnityEngine.Transform transform = gameObject.transform;
			transform.SetSiblingIndex(0);
		}
		return;
		IL_00bb:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11711B8 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		if ((object)gameObject == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_0183;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000099")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD9078", Offset = "0xFD9078", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tLogScroller::Log(this._logScroller, text);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 10 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void LogText(string text)
	{
		_logScroller.Log(text);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600009A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD9BB8", Offset = "0xFD9BB8", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xAE0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv50 = v49 + 0x258;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A8FB]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+258])();\n\tSystem.Collections.Generic.List`1<System.Object>::.ctor(v48);\n\tv54 = this + 0x58;\n\tthis._products = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public PurchasePage()
	{
		//IL_000e: Expected I, but got O
		//IL_0031: Expected O, but got I
		nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
		global::System.Collections.Generic.IList<global::Facebook.Unity.Product> products = (global::System.Collections.Generic.IList<global::Facebook.Unity.Product>)new global::System.Collections.Generic.List<object>();
		object obj = (nint)this + 88;
		_products = products;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		base._002Ector();
	}
}
