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
		int num = index - array.Length;
		if (index >= array.Length)
		{
			array = repeatLevelPrefabs;
			int num3 = num / array.Length;
			int num4 = num3 * array.Length;
			index = num - num4;
			if (index >= array.Length)
			{
				throw new global::System.IndexOutOfRangeException();
			}
		}
		return array[index];
	}

	[global::Cpp2ILInjected.Token(Token = "0x600036E")]
	[global::Cpp2ILInjected.Address(RVA = "0x1012CE4", Offset = "0x1012CE4", Length = "0xA4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv20 = *([302AA72]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0028;\n\tv51 = Il2CppMethodInfo + 0xC98;\n\tv24 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A50]);\n\tv26 = *([v24 @ X0_v13+E0]) == 0;\n\tif (v26) goto L_003A;\nL_001F:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v51 @ X21_v6]));\n\treturn;\nL_0028:\n\t*([v16 @ X21_v1+A72]) = 1;\n\tv51 = Il2CppMethodInfo + 0xC98;\n\tv46 = *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+A50]);\n\tv79 = *([v46 @ X0_v10+E0]) == 0;\n\tv48 = ~v79;\n\tif (v48) goto L_001F;\nL_003A:\n\tSingleton`1::.ctor /* +1 sharing this address */(this, *([v64 @ X21_v2]));\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public LevelSequenceManager()
	{
	}
}
