[global::UnityEngine.ExecuteAlways]
[global::Cpp2ILInjected.Token(Token = "0x20000C0")]
public class LevelSequenceManager : Singleton<LevelSequenceManager>
{
	[global::Cpp2ILInjected.Token(Token = "0x400042E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public Level[] onboardingLevelPrefabs;

	[global::Cpp2ILInjected.Token(Token = "0x400042F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public Level[] repeatLevelPrefabs;

	[global::Cpp2ILInjected.Token(Token = "0x4000430")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public Level testLevelPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x4000431")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public string testLevelPrefabPath;

	[global::Cpp2ILInjected.Token(Token = "0x4000432")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public Level level;

	[global::Cpp2ILInjected.Token(Token = "0x600036D")]
	[global::Cpp2ILInjected.Address(RVA = "0x100A29C", Offset = "0x100A29C", Length = "0x54")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv108 = this.onboardingLevelPrefabs;\n\tv20 = v82 - v108.Length;\n\tv21 = v82 >= v108.Length;\n\tif (v21) goto L_001C;\nL_001B:\n\treturn v108[v82 @ X1_v4 (System.Int32)];\nL_001C:\n\tv108 = this.repeatLevelPrefabs;\n\tv85 = v20 / v108.Length;\n\tv107 = v85 * v108.Length;\n\tv82 = v20 - v107;\n\tv114 = v82 < v108.Length;\n\tv105 = ~v114;\n\tv89 = ~v105;\n\tif (v89) goto L_001B;\n\tv31 = new System.IndexOutOfRangeException();\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 33 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Level GetLevelPrefab(int index)
	{
		Level[] array = onboardingLevelPrefabs;
		int num2 = default(int);
		int num = num2 - array.Length;
		if (num2 >= array.Length)
		{
			array = repeatLevelPrefabs;
			int num3 = num / array.Length;
			int num4 = num3 * array.Length;
			num2 = num - num4;
			if (num2 >= array.Length)
			{
				global::System.IndexOutOfRangeException ex = new global::System.IndexOutOfRangeException();
				return (Level)(object)new global::System.NullReferenceException();
			}
		}
		return array[num2];
	}

	[global::Cpp2ILInjected.Token(Token = "0x600036E")]
	[global::Cpp2ILInjected.Address(RVA = "0x1012CE4", Offset = "0x1012CE4", Length = "0xA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = *([302AA72]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0028;\n\tv51 = Il2CppMethodInfo + 0xC98;\n\tv24 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A50]);\n\tv26 = *([v24 @ X0_v13+E0]) == 0;\n\tif (v26) goto L_003A;\nL_001F:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v51 @ X21_v6]));\n\treturn;\nL_0028:\n\t*([v16 @ X21_v1+A72]) = 1;\n\tv51 = Il2CppMethodInfo + 0xC98;\n\tv46 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A50]);\n\tv79 = *([v46 @ X0_v10+E0]) == 0;\n\tv48 = ~v79;\n\tif (v48) goto L_001F;\nL_003A:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v64 @ X21_v2]));\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public LevelSequenceManager()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00b0: Expected O, but got I
		//IL_00c0: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA72]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)3224;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A50]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X0_v13+E0]");
			bool flag = (nint)0 == 0;
			object obj4 = obj2;
			if (!flag)
			{
				goto IL_0093;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)3224;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A50]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X0_v10+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			if (flag3)
			{
				goto IL_0093;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
		return;
		IL_0093:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18ABE40 (Singleton`1::.ctor, and 1 more at this address)");
	}
}
