[global::Cpp2ILInjected.Token(Token = "0x2000033")]
public class SplashEffect : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.MaterialPropertyBlock _propBlock;

	[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.MeshRenderer mr;

	[global::Cpp2ILInjected.Token(Token = "0x6000130")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5B48", Offset = "0xFE5B48", Length = "0x6C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0017;\n\tv23 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv24 = v23 + 0x900;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A956]) = v43;\nL_0017:\n\tv45 = new *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+900])();\n\tUnityEngine.MaterialPropertyBlock::.ctor(v45);\n\tv48 = this + 0x20;\n\tthis._propBlock = v45;\n\tv57 = 0xF3F1B4(v48, v45, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn;\n// 27 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_000e: Expected I, but got O
		//IL_002a: Expected O, but got I
		nint num = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::UnityEngine.MaterialPropertyBlock propBlock = new global::UnityEngine.MaterialPropertyBlock();
		object obj = (nint)this + 32;
		_propBlock = propBlock;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000131")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5BB4", Offset = "0xFE5BB4", Length = "0xB0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv33 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv34 = v33 + 0x900;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, color, v0, v2, v3, v43, v44, v45, v46);\n\tv49 = 1;\n\t*([302A957]) = v49;\nL_0022:\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv78 = \"Writing object reference to Id '{0}' for {1}.\";\n\tUnityEngine.MaterialPropertyBlock::SetColor(this._propBlock, *([v78 @ X8_v4 (System.String)+900]), color);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 53 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void SetColor(global::UnityEngine.Color color)
	{
		//IL_003f: Expected O, but got I
		mr.GetPropertyBlock(_propBlock);
		string text = "Writing object reference to Id '{0}' for {1}.";
		global::UnityEngine.MaterialPropertyBlock propBlock = _propBlock;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X8_v4 (System.String)+900]");
		propBlock.SetColor((string)0, color);
		mr.SetPropertyBlock(_propBlock);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000132")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5C64", Offset = "0xFE5C64", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SplashEffect()
	{
	}
}
