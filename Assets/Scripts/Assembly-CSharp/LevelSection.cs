[global::System.Serializable]
[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
public class LevelSection
{
	[global::UnityEngine.Tooltip("World-space Y position of this section’s centre")]
	[global::Cpp2ILInjected.Token(Token = "0x40003F6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public float y;

	[global::UnityEngine.Tooltip("Locks that belong to this section (populated automatically in Init)")]
	[global::Cpp2ILInjected.Token(Token = "0x40003F7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public global::System.Collections.Generic.List<Lock> locks;

	[global::Cpp2ILInjected.Token(Token = "0x6000343")]
	[global::Cpp2ILInjected.Address(RVA = "0x100F250", Offset = "0x100F250", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x610;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv50 = v49 + 0x178;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA62]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+178])();\n\tSystem.Collections.Generic.List`1<Lock>::.ctor(v48);\n\tv54 = this + 0x18;\n\tthis.locks = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tSystem.Object::.ctor(this);\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public LevelSection()
	{
		//IL_000e: Expected I, but got O
		//IL_0031: Expected O, but got I
		global::System.Collections.Generic.List<Lock> list = new global::System.Collections.Generic.List<Lock>();
		locks = list;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}
}
