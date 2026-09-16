[global::Cpp2ILInjected.Token(Token = "0x200000A")]
public class PurchaseRowPrefab : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400003D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.UI.Text _purchaseTokenText;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400003E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::UnityEngine.UI.Text _productIdText;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x400003F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private global::UnityEngine.UI.Text _purchaseTimeText;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000040")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private global::UnityEngine.GameObject _consumeBtn;

	[global::Cpp2ILInjected.Token(Token = "0x4000041")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private string DATE_FORMAT;

	[global::Cpp2ILInjected.Token(Token = "0x4000042")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::Facebook.Unity.Purchase _purchase;

	[global::Cpp2ILInjected.Token(Token = "0x4000043")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private LogScroller _logScroller;

	[global::Cpp2ILInjected.Token(Token = "0x4000044")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private PurchasePage _parentScript;

	[global::Cpp2ILInjected.Token(Token = "0x600006A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6694", Offset = "0xFD6694", Length = "0x20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv6 = this._purchase;\n\treturn v6.<PurchaseToken>k__BackingField;\n\treturnVal2 = new System.NullReferenceException();\n\treturn returnVal2;\n// 10 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public string GetPurchaseToken()
	{
		global::Facebook.Unity.Purchase purchase = _purchase;
		return purchase.PurchaseToken;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600006B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD66B4", Offset = "0xFD66B4", Length = "0x44")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.Purchase::ToString(this._purchase);\n\tLogScroller::Log(this._logScroller, v18);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 23 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnLogBtnClick()
	{
		string text = _purchase.ToString();
		_logScroller.Log(text);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600006C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD66F8", Offset = "0xFD66F8", Length = "0xA0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = System.Collections.Generic.NullableComparer`1;\n\tv24 = Il2CppMethodInfo;\n\tgoto L_0020;\n\tv29 = System.Collections.Generic.NullableComparer`1;\n\tv30 = v29 + 0xC78;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv55 = Il2CppMethodInfo;\n\tv56 = v55 + 0x7C8;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302A8D5]) = v50;\nL_0020:\n\tv54 = new *([v22 @ X22_v1 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+C78])();\n\tSystem.Action`1<System.Boolean>::.ctor(v54, this, *([v24 @ X23_v1 (Il2CppMethodInfo)+7C8]));\n\tPurchasePage::ConsumePurchase(this._parentScript, this._purchase, v54);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnConsumeBtnClick()
	{
		//IL_000e: Expected I, but got O
		nint num = (nint)typeof(global::System.Collections.Generic.NullableComparer<>);
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X23_v1 (Il2CppMethodInfo)+7C8]");
		global::System.Action<bool> callback = new global::System.Action<bool>(this, (global::System.IntPtr)0);
		_parentScript.ConsumePurchase(_purchase, callback);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600006D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6918", Offset = "0xFD6918", Length = "0x140")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv31 = System.ComponentModel.BooleanConverter;\n\tv32 = v31 + 0xB30;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, parentScript, logScroller, purchase, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv48 = 1;\n\t*([302A8D6]) = v48;\nL_001A:\n\tthis = this + 0x58;\n\tthis._parentScript = parentScript;\n\tthis = 0xF3F1B4(this, parentScript, logScroller, purchase, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tthis = this + 0x50;\n\tthis._logScroller = logScroller;\n\tthis = 0xF3F1B4(this, logScroller, logScroller, purchase, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv58 = this + 0x48;\n\tthis._purchase = purchase;\n\tthis = 0xF3F1B4(v58, purchase, logScroller, purchase, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tthis = UnityEngine.UI.Text::set_text(this._purchaseTokenText, purchase.<PurchaseToken>k__BackingField);\n\tthis = UnityEngine.UI.Text::set_text(this._productIdText, purchase.<ProductID>k__BackingField);\n\tv90 = this._purchaseTimeText;\n\tv98 = purchase.<PurchaseTime>k__BackingField;\n\tgoto L_0048;\n\tv131 = \"il2cpp_codegen_runtime_class_init\"(v100, v94, v96, purchase, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\nL_0048:\n\tv135 = System.DateTime::ToLocalTime(&v98 @ X8_v6 (System.DateTime));\n\tv80 = System.DateTime::ToString(&v135 @ X0_v19 (System.DateTime), this.DATE_FORMAT);\n\tthis = UnityEngine.UI.Text::set_text(v90, v80);\n\tPurchaseRowPrefab::SetConsumeBtnData(this, purchase.<IsConsumed>k__BackingField);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Initialize(PurchasePage parentScript, LogScroller logScroller, global::Facebook.Unity.Purchase purchase)
	{
		//IL_009d: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		PurchaseRowPrefab purchaseRowPrefab = (PurchaseRowPrefab)((nint)this + 88);
		_parentScript = parentScript;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		purchaseRowPrefab = (PurchaseRowPrefab)((nint)this + 80);
		_logScroller = logScroller;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj = (nint)this + 72;
		_purchase = purchase;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_purchaseTokenText.text = purchase.PurchaseToken;
		_productIdText.text = purchase.ProductID;
		global::UnityEngine.UI.Text purchaseTimeText = _purchaseTimeText;
		string text = purchase.PurchaseTime.ToLocalTime().ToString(DATE_FORMAT);
		purchaseTimeText.text = text;
		SetConsumeBtnData(purchase.IsConsumed);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600006E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6A58", Offset = "0xFD6A58", Length = "0xF8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0021;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x750;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, isConsumed, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv46 = Il2CppMethodInfo;\n\tv47 = v46 + 0xA20;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v47, isConsumed, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv75 = \"Cannot load image: download failed\";\n\tv76 = v75 + 0x898;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, isConsumed, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv78 = \"Cannot load image: download failed\";\n\tv79 = v78 + 0x888;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, isConsumed, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A8D7]) = v43;\nL_0021:\n\tv49 = Il2CppMethodInfo;\n\tv52 = UnityEngine.GameObject::GetComponent /* +1 sharing this address */(this._consumeBtn, *([v49 @ X8_v4 (Il2CppMethodInfo)+A20]));\n\tv57 = isConsumed ^ 1;\n\tUnityEngine.UI.Selectable::set_interactable(v52, v57);\n\tv63 = UnityEngine.GameObject::get_transform(this._consumeBtn);\n\tv64 = UnityEngine.Transform::GetChild(v63, 0);\n\tv135 = Il2CppMethodInfo;\n\tv65 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v64, *([v135 @ X8_v6 (Il2CppMethodInfo)+750]));\n\tv142 = \"Cannot load image: download failed\" + 0x898;\n\tv117 = \"Cannot load image: download failed\" + 0x888;\n\tv105 = isConsumed == 0;\n\tv90 = ~v105;\n\tv87 = ~v90;\n\tif (v87) goto L_FFFFFFFF;\n\tgoto L_0050;\nL_0050:\n\tv122 = *([v142 @ X8_v10]);\n\tv126 = *([v65 @ X0_v9]);\n\tv85 = *([v126 @ X8_v11+5E8]);\n\tv120 = *([v126 @ X8_v11+5F0]);\n\t// 91 IndirectJump v85 @ X3_v1, v65 @ X0_v9, v65 @ X0_v9, v122 @ X1_v7, v120 @ X2_v4, v85 @ X3_v1, v28 @ X4, v29 @ X5, v30 @ X6, v31 @ X7, v32 @ V0, v33 @ V1, v34 @ V2, v35 @ V3, v36 @ V4, v37 @ V5, v38 @ V6, v39 @ V7\n\tthrow System.NullReferenceException;\n\treturn;\n// 57 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void SetConsumeBtnData(bool isConsumed)
	{
		//IL_0084: Unknown result type (might be due to invalid IL or missing references)
		//IL_0089: Expected O, but got Unknown
		//IL_0093: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_00fd: Expected O, but got I
		//IL_010d: Expected O, but got I
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @114831C (UnityEngine.GameObject::GetComponent, and 1 more at this address)");
		bool interactable = (byte)((isConsumed ? 1u : 0u) ^ 1u) != 0;
		global::UnityEngine.UI.Selectable selectable = default(global::UnityEngine.UI.Selectable);
		selectable.interactable = interactable;
		global::UnityEngine.Transform transform = _consumeBtn.transform;
		global::UnityEngine.Transform child = transform.GetChild(0);
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		object obj = "Cannot load image: download failed" + 2200;
		object obj2 = "Cannot load image: download failed" + 2184;
		if (!isConsumed)
		{
			obj = obj2;
		}
		object obj3 = obj;
		object obj5 = default(object);
		object obj4 = obj5;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v11+5E8]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v126 @ X8_v11+5F0]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v85 @ X3_v1 (should have been resolved before IL gen)");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600006F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6B50", Offset = "0xFD6B50", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = \"IsCyrillic\";\n\tgoto L_0018;\n\tv23 = \"IsCyrillic\";\n\tv24 = v23 + 0xAE8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A8D8]) = v43;\nL_0018:\n\tv46 = this + 0x40;\n\tthis.DATE_FORMAT = *([v18 @ X21_v1 (System.String)+AE8]);\n\tv47 = 0xF3F1B4(v46, *([v18 @ X21_v1 (System.String)+AE8]), v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public PurchaseRowPrefab()
	{
		//IL_0020: Expected O, but got I
		//IL_0032: Expected O, but got I
		base._002Ector();
		string text = "IsCyrillic";
		object obj = (nint)this + 64;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (System.String)+AE8]");
		DATE_FORMAT = (string)0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}
}
