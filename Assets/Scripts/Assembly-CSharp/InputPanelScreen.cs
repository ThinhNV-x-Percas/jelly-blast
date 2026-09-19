[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
public class InputPanelScreen : Viewport
{
	[global::Cpp2ILInjected.Token(Token = "0x6000453")]
	[global::Cpp2ILInjected.Address(RVA = "0x101F248", Offset = "0x101F248", Length = "0x88")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Xml.ValidateNames;\n\tv20 = *([302AAE4]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0023;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv24 = *([v22 @ X0_v10+E0]) == 0;\n\tif (v24) goto L_0033;\nL_001D:\n\tViewport::.ctor(this);\n\treturn;\nL_0023:\n\t*([v16 @ X20_v1+AE4]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]);\n\tv62 = *([v44 @ X0_v7+E0]) == 0;\n\tv46 = ~v62;\n\tif (v46) goto L_001D;\nL_0033:\n\tViewport::.ctor(this);\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public InputPanelScreen()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_009c: Expected O, but got I
		//IL_005a: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AAE4]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v10+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<System.Xml.ValidateNames>)+198]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v7+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		return;
		IL_007f:
		;
	}
}
