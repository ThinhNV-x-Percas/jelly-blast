[global::Cpp2ILInjected.Token(Token = "0x2000009")]
public class ProductRowPrefab : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000036")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.UI.RawImage _thumbImg;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000037")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::UnityEngine.UI.Text _titleText;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000038")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private global::UnityEngine.UI.Text _productIdText;

	[global::UnityEngine.SerializeField]
	[global::Cpp2ILInjected.Token(Token = "0x4000039")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	private global::UnityEngine.GameObject _buyBtn;

	[global::Cpp2ILInjected.Token(Token = "0x400003A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private global::Facebook.Unity.Product _product;

	[global::Cpp2ILInjected.Token(Token = "0x400003B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private LogScroller _logScroller;

	[global::Cpp2ILInjected.Token(Token = "0x400003C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private PurchasePage _parentScript;

	[global::Cpp2ILInjected.Token(Token = "0x6000062")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5EF0", Offset = "0xFD5EF0", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn;\n")]
	private void Awake()
	{
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000063")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD5EF4", Offset = "0xFD5EF4", Length = "0x44")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.Product::ToString(this._product);\n\tLogScroller::Log(this._logScroller, v18);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 23 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnLogBtnClick()
	{
		string text = _product.ToString();
		_logScroller.Log(text);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000064")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD61CC", Offset = "0xFD61CC", Length = "0x24")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tPurchasePage::MakePurchase(this._parentScript, this._product);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 12 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void OnPurchaseBtnClick()
	{
		_parentScript.MakePurchase(_product);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000065")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6338", Offset = "0xFD6338", Length = "0x124")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x750;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, parentScript, logScroller, product, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv48 = 1;\n\t*([302A8D4]) = v48;\nL_001A:\n\tv50 = this + 0x50;\n\tthis._parentScript = parentScript;\n\tv52 = 0xF3F1B4(v50, parentScript, logScroller, product, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv54 = this + 0x48;\n\tthis._logScroller = logScroller;\n\tv56 = 0xF3F1B4(v54, logScroller, logScroller, product, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv58 = this + 0x40;\n\tthis._product = product;\n\tv61 = 0xF3F1B4(v58, product, logScroller, product, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv96 = UnityEngine.UI.Text::set_text(this._titleText, product.<Title>k__BackingField);\n\tv97 = UnityEngine.UI.Text::set_text(this._productIdText, product.<ProductID>k__BackingField);\n\tv82 = UnityEngine.GameObject::get_transform(this._buyBtn);\n\tv83 = UnityEngine.Transform::GetChild(v82, 0);\n\tv125 = Il2CppMethodInfo;\n\tv84 = UnityEngine.Component::GetComponent /* +1 sharing this address */(v83, *([v125 @ X8_v6 (Il2CppMethodInfo)+750]));\n\tv112 = *([v84 @ X0_v19]);\n\t*([v112 @ X8_v8+5E8])(v128, v84, product.<Price>k__BackingField, *([v112 @ X8_v8+5F0]), product, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tProductRowPrefab::SetThumb(this, product.<ProductID>k__BackingField, product.<ImageURI>k__BackingField);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Initialize(PurchasePage parentScript, LogScroller logScroller, global::Facebook.Unity.Product product)
	{
		//IL_00ae: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_00ee: Expected O, but got I
		object obj = (nint)this + 80;
		_parentScript = parentScript;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj2 = (nint)this + 72;
		_logScroller = logScroller;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj3 = (nint)this + 64;
		_product = product;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		_titleText.text = product.Title;
		_productIdText.text = product.ProductID;
		global::UnityEngine.Transform transform = _buyBtn.transform;
		global::UnityEngine.Transform child = transform.GetChild(0);
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		object obj5 = default(object);
		object obj4 = obj5;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v112 @ X8_v8+5E8] (should have been resolved before IL gen)");
		SetThumb(product.ProductID, product.ImageURI);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000066")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD645C", Offset = "0xFD645C", Length = "0x14C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = System.Collections.Generic.NullableComparer`1;\n\tv32 = Il2CppMethodInfo;\n\tv34 = System.Net.Configuration.SettingsSectionInternal;\n\tgoto L_0027;\n\tv39 = System.Collections.Generic.NullableComparer`1;\n\tv40 = v39 + 0xD70;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, productId, url, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x648;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, productId, url, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv68 = System.Net.Configuration.SettingsSectionInternal;\n\tv69 = v68 + 0xF78;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, productId, url, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv58 = 1;\n\t*([302A9A5]) = v58;\nL_0027:\n\tv60 = new *([v30 @ X25_v1 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D70])();\n\tSystem.Action`1<System.Object>::.ctor(v60, this, *([v32 @ X24_v1 (Il2CppMethodInfo)+648]));\n\tv70 = *([v34 @ X23_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]);\n\tv72 = *([v70 @ X0_v4+E0]) == 0;\n\tif (v72) goto L_0067;\n\tv86 = Sponge+<>c__DisplayClass7_0 + 0x568;\n\tgoto L_003F;\nL_003D:\n\t*([302A9A6]) = 1;\nL_003F:\n\tv100 = new *([v86 @ X24_v7])();\n\tSystem.Object::.ctor(v100);\n\t*([v100 @ X0_v7 (System.Object)+10]) = 0;\n\tv106 = v100 + 0x20;\n\t*([v100 @ X0_v7 (System.Object)+20]) = productId;\n\tv108 = 0xF3F1B4(v106, productId, *([v32 @ X24_v1 (Il2CppMethodInfo)+648]), 0, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv110 = v100 + 0x30;\n\t*([v100 @ X0_v7 (System.Object)+30]) = url;\n\tv112 = 0xF3F1B4(v110, url, *([v32 @ X24_v1 (Il2CppMethodInfo)+648]), 0, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv114 = v100 + 0x28;\n\t*([v100 @ X0_v7 (System.Object)+28]) = v60;\n\tv116 = 0xF3F1B4(v114, v60, *([v32 @ X24_v1 (Il2CppMethodInfo)+648]), 0, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv130 = UnityEngine.MonoBehaviour::StartCoroutine(this, v100);\n\treturn;\nL_0067:\n\tv87 = Sponge+<>c__DisplayClass7_0 + 0x568;\n\tv102 = *([302A9A6]) & 1;\n\tv83 = v102 == 0;\n\tif (v83) goto L_003D;\n\tgoto L_003F;\n\treturn;\n// 66 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void SetThumb(string productId, string url)
	{
		//IL_000e: Expected I, but got O
		//IL_0022: Expected I, but got O
		//IL_0116: Expected O, but got I
		//IL_00aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_00af: Expected O, but got Unknown
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		//IL_003b: Expected O, but got Unknown
		//IL_015a: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_0078: Expected O, but got I
		nint num = (nint)typeof(global::System.Collections.Generic.NullableComparer<>);
		nint num2 = 0;
		nint num3 = (nint)typeof(global::System.Net.Configuration.SettingsSectionInternal);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v32 @ X24_v1 (Il2CppMethodInfo)+648]");
		object obj = new global::System.Action<object>(this, (global::System.IntPtr)0);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v34 @ X23_v1 (Il2CppClass<System.Net.Configuration.SettingsSectionInternal>)+F78]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v70 @ X0_v4+E0]");
		if ((nint)0 != 0)
		{
			object obj3 = typeof(Sponge._003C_003Ec__DisplayClass7_0) + 1384;
		}
		else
		{
			object obj4 = typeof(Sponge._003C_003Ec__DisplayClass7_0) + 1384;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A9A6]");
			if ((int)((nint)0 & (nint)1) == 0)
			{
				_ = 1;
			}
			else
			{
				object obj3 = obj4;
			}
		}
		object obj5 = new object();
		_ = 0;
		object obj6 = (nint)obj5 + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj7 = (nint)obj5 + 48;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		object obj8 = (nint)obj5 + 40;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.Coroutine coroutine = StartCoroutine((global::System.Collections.IEnumerator)obj5);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000067")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD6650", Offset = "0xFD6650", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tLogScroller::Log(this._logScroller, text);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 10 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void LogText(string text)
	{
		_logScroller.Log(text);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000068")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD666C", Offset = "0xFD666C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public ProductRowPrefab()
	{
	}
}
