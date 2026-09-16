[global::Cpp2ILInjected.Token(Token = "0x2000026")]
public class FBWindowsPhysicalGamepadManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.UI.Text displayGamepadInputText;

	[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE0654", Offset = "0xFE0654", Length = "0x60")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0012;\n\tv17 = \"Parent table name is missing in relation '{0}'.\";\n\tv18 = v17 + 0xD88;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A934]) = v37;\nL_0012:\n\tv38 = this.displayGamepadInputText;\n\tv40 = \"Parent table name is missing in relation '{0}'.\";\n\tv42 = *([v40 @ X8_v3 (System.String)+D88]);\n\tv43 = *([v38 @ X0_v2 (UnityEngine.UI.Text)]);\n\tv44 = *([v43 @ X8_v5 (Il2CppClass<UnityEngine.UI.Text>)+5E8]);\n\tv45 = *([v43 @ X8_v5 (Il2CppClass<UnityEngine.UI.Text>)+5F0]);\n\t// 32 IndirectJump v44 @ X3_v1, v38 @ X0_v2 (UnityEngine.UI.Text), v38 @ X0_v2 (UnityEngine.UI.Text), v42 @ X1_v1, v45 @ X2_v1, v44 @ X3_v1, v23 @ X4, v24 @ X5, v25 @ X6, v26 @ X7, v27 @ V0, v28 @ V1, v29 @ V2, v30 @ V3, v31 @ V4, v32 @ V5, v33 @ V6, v34 @ V7\n\tthrow System.NullReferenceException;\n\treturn;\n// 20 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		//IL_001e: Expected O, but got I
		//IL_0026: Expected I, but got O
		//IL_0036: Expected O, but got I
		//IL_0046: Expected O, but got I
		while (true)
		{
			global::UnityEngine.UI.Text text = displayGamepadInputText;
			string text2 = "Parent table name is missing in relation '{0}'.";
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X8_v3 (System.String)+D88]");
			object obj = 0;
			nint num = (nint)text;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<UnityEngine.UI.Text>)+5E8]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v43 @ X8_v5 (Il2CppClass<UnityEngine.UI.Text>)+5F0]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v44 @ X3_v1 (should have been resolved before IL gen)");
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE06B4", Offset = "0xFE06B4", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsPhysicalGamepadManager()
	{
	}
}
