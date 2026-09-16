[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Image))]
[global::UnityEngine.RequireComponent(typeof(SecondaryImageColor))]
[global::Cpp2ILInjected.Token(Token = "0x20000E1")]
public class UIButtonStyler : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40004A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public UIButtonStyle buttonStyle;

	[global::Cpp2ILInjected.Token(Token = "0x40004A1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::UnityEngine.UI.Image image;

	[global::Cpp2ILInjected.Token(Token = "0x40004A2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private SecondaryImageColor secondaryImageColor;

	[global::Cpp2ILInjected.Token(Token = "0x6000400")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A63C", Offset = "0x101A63C", Length = "0x94")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Il2CppMethodInfo;\n\tv20 = Il2CppMethodInfo;\n\tgoto L_001D;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x670;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = Il2CppMethodInfo;\n\tv51 = v50 + 0x728;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AAA5]) = v46;\nL_001D:\n\tv49 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v18 @ X22_v1 (Il2CppMethodInfo)+670]));\n\tv54 = this + 0x28;\n\tthis.image = v49;\n\tv55 = 0xF3F1B4(v54, v49, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv58 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v20 @ X20_v1 (Il2CppMethodInfo)+728]));\n\tv60 = this + 0x30;\n\tthis.secondaryImageColor = v58;\n\tv68 = 0xF3F1B4(v60, v58, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_0048: Expected O, but got I
		//IL_001d: Expected O, but got I
		nint num = 0;
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		object obj = (nint)this + 40;
		global::UnityEngine.UI.Image image = default(global::UnityEngine.UI.Image);
		this.image = image;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		object obj2 = (nint)this + 48;
		SecondaryImageColor secondaryImageColor = default(SecondaryImageColor);
		this.secondaryImageColor = secondaryImageColor;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000401")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A6D0", Offset = "0x101A6D0", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUIButtonStyler::SetStyle(this, this.buttonStyle);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		SetStyle(buttonStyle);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000402")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A6D8", Offset = "0x101A6D8", Length = "0x70")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv13 = this + 0x20;\n\tthis.buttonStyle = _buttonStyle;\n\tv16 = 0xF3F1B4(v13, _buttonStyle, methodInfo, v18, v19, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30);\n\tv31 = this.buttonStyle;\n\tv33 = this.image;\n\tv54 = UnityEngine.UI.Graphic::set_color(v33, Color_arg);\n\tv52 = this.buttonStyle;\n\t// 41 MakeStruct v59 @ AGG101A740_1_v1 (UnityEngine.Color), typeof(UnityEngine.Color), v52.bottomColor (UnityEngine.Color), v52.bottomColor.g (System.Single), v52.bottomColor.b (System.Single), v52.bottomColor.a (System.Single)\n\tSecondaryImageColor::set_SecondaryColor(this.secondaryImageColor, v59);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void SetStyle(UIButtonStyle _buttonStyle)
	{
		//IL_000c: Expected O, but got I
		object obj = (nint)this + 32;
		buttonStyle = _buttonStyle;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		UIButtonStyle uIButtonStyle = buttonStyle;
		global::UnityEngine.UI.Image image = this.image;
		global::UnityEngine.Color color = default(global::UnityEngine.Color);
		color.r = uIButtonStyle.topColor.r;
		color.g = uIButtonStyle.topColor.g;
		color.b = uIButtonStyle.topColor.b;
		color.a = uIButtonStyle.topColor.a;
		image.color = color;
		UIButtonStyle uIButtonStyle2 = buttonStyle;
		global::UnityEngine.Color secondaryColor = default(global::UnityEngine.Color);
		secondaryColor.r = uIButtonStyle2.bottomColor.r;
		secondaryColor.g = uIButtonStyle2.bottomColor.g;
		secondaryColor.b = uIButtonStyle2.bottomColor.b;
		secondaryColor.a = uIButtonStyle2.bottomColor.a;
		secondaryImageColor.SecondaryColor = secondaryColor;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000403")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A748", Offset = "0x101A748", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public UIButtonStyler()
	{
	}
}
