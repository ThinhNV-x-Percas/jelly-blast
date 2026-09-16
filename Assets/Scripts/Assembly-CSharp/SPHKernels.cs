[global::Cpp2ILInjected.Token(Token = "0x20000CF")]
internal static class SPHKernels
{
	[global::Cpp2ILInjected.Token(Token = "0x4000469")]
	public static readonly float r;

	[global::Cpp2ILInjected.Token(Token = "0x400046A")]
	private static readonly float densityCoef;

	[global::Cpp2ILInjected.Token(Token = "0x400046B")]
	private static readonly float nearDensityCoef;

	[global::Cpp2ILInjected.Token(Token = "0x400046C")]
	private static readonly float viscosityVolume;

	[global::Cpp2ILInjected.Token(Token = "0x400046D")]
	public const float RHO_EPS = 1E-06f;

	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	[global::Cpp2ILInjected.Token(Token = "0x60003AE")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015F84", Offset = "0x1015F84", Length = "0xCC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Runtime.Serialization.ObjectHolderList;\n\tv20 = *([302AA8A]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0030;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv24 = *([v42 @ X0_v12+E0]) == 0;\n\tif (v24) goto L_0037;\nL_0014:\n\tv151 = *([v42 @ X0_v12+B8]);\n\tv159 = *([v151 @ X8_v3]);\n\tv62 = *([v151 @ X8_v3]) > dst;\n\tif (v62) goto L_004B;\nL_002B:\n\treturn returnVal1;\nL_0030:\n\t*([v16 @ X20_v1+A8A]) = 1;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv68 = *([v42 @ X0_v12+E0]) == 0;\n\tv45 = ~v68;\n\tif (v45) goto L_0014;\nL_0037:\n\tv94 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv151 = *([v94 @ X0_v6+B8]);\n\tv159 = *([v151 @ X8_v3]);\n\tv72 = *([v151 @ X8_v3]) <= dst;\n\tif (v72) goto L_002B;\nL_004B:\n\tgoto L_0050;\n\tv158 = \"il2cpp_codegen_runtime_class_init\"(v116, v28, v29, v30, v31, v32, v33, v34, v114, v115, v36, v37, v38, v39, v40, v41);\n\tv164 = *([v19 @ X19_v2]);\n\tv161 = *([v164 @ X8_v4+B8]);\n\tv160 = *([v161 @ X8_v5]);\nL_0050:\n\tv162 = v159 - dst;\n\tv163 = v162 * v162;\n\treturnVal2 = *([v151 @ X8_v3+4]) * v163;\n\treturn returnVal2;\n// 60 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float DensityKernel(float dst)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00d9: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_0119: Expected O, but got I
		//IL_0129: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA8A]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+B8]");
		object obj4 = 0;
		object obj5 = obj4;
		bool flag = !((float)obj4 > dst);
		float result = 0f;
		if (flag)
		{
			goto IL_00be;
		}
		goto IL_0160;
		IL_00be:
		return result;
		IL_0160:
		float num2 = (float)obj5 - dst;
		float num3 = num2 * num2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v3+4]");
		return 0f * num3;
		IL_007f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+B8]");
		obj4 = 0;
		obj5 = obj4;
		bool flag2 = (float)obj4 > dst;
		result = 0f;
		if (!flag2)
		{
			goto IL_00be;
		}
		goto IL_0160;
	}

	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	[global::Cpp2ILInjected.Token(Token = "0x60003AF")]
	[global::Cpp2ILInjected.Address(RVA = "0x1016050", Offset = "0x1016050", Length = "0xD0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Runtime.Serialization.ObjectHolderList;\n\tv20 = *([302AA8B]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0030;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv24 = *([v42 @ X0_v12+E0]) == 0;\n\tif (v24) goto L_0037;\nL_0014:\n\tv153 = *([v42 @ X0_v12+B8]);\n\tv161 = *([v153 @ X8_v3]);\n\tv62 = *([v153 @ X8_v3]) > dst;\n\tif (v62) goto L_004B;\nL_002B:\n\treturn returnVal1;\nL_0030:\n\t*([v16 @ X20_v1+A8B]) = 1;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv68 = *([v42 @ X0_v12+E0]) == 0;\n\tv45 = ~v68;\n\tif (v45) goto L_0014;\nL_0037:\n\tv94 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv153 = *([v94 @ X0_v6+B8]);\n\tv161 = *([v153 @ X8_v3]);\n\tv72 = *([v153 @ X8_v3]) <= dst;\n\tif (v72) goto L_002B;\nL_004B:\n\tgoto L_0050;\n\tv160 = \"il2cpp_codegen_runtime_class_init\"(v116, v28, v29, v30, v31, v32, v33, v34, v114, v115, v36, v37, v38, v39, v40, v41);\n\tv166 = *([v19 @ X19_v2]);\n\tv163 = *([v166 @ X8_v4+B8]);\n\tv162 = *([v163 @ X8_v5]);\nL_0050:\n\tv164 = v161 - dst;\n\tv126 = v164 * v164;\n\tv165 = v164 * v126;\n\treturnVal2 = *([v153 @ X8_v3+8]) * v165;\n\treturn returnVal2;\n// 60 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float NearDensityKernel(float dst)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00d9: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_0119: Expected O, but got I
		//IL_0129: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA8B]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X0_v6+B8]");
		object obj4 = 0;
		object obj5 = obj4;
		bool flag = !((float)obj4 > dst);
		float result = 0f;
		if (flag)
		{
			goto IL_00be;
		}
		goto IL_0160;
		IL_00be:
		return result;
		IL_0160:
		float num2 = (float)obj5 - dst;
		float num3 = num2 * num2;
		float num4 = num2 * num3;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X8_v3+8]");
		return 0f * num4;
		IL_007f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+B8]");
		obj4 = 0;
		obj5 = obj4;
		bool flag2 = (float)obj4 > dst;
		result = 0f;
		if (!flag2)
		{
			goto IL_00be;
		}
		goto IL_0160;
	}

	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	[global::Cpp2ILInjected.Token(Token = "0x60003B0")]
	[global::Cpp2ILInjected.Address(RVA = "0x1016120", Offset = "0x1016120", Length = "0xC8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Runtime.Serialization.ObjectHolderList;\n\tv20 = *([302AA8C]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_002E;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv24 = *([v42 @ X0_v12+E0]) == 0;\n\tif (v24) goto L_0035;\nL_0014:\n\tv144 = *([v42 @ X0_v12+B8]);\n\tv152 = *([v144 @ X8_v3]);\n\tv60 = *([v144 @ X8_v3]) >= dst;\n\tif (v60) goto L_0048;\nL_0029:\n\treturn returnVal1;\nL_002E:\n\t*([v16 @ X20_v1+A8C]) = 1;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv66 = *([v42 @ X0_v12+E0]) == 0;\n\tv45 = ~v66;\n\tif (v45) goto L_0014;\nL_0035:\n\tv90 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv144 = *([v90 @ X0_v6+B8]);\n\tv152 = *([v144 @ X8_v3]);\n\tv68 = *([v144 @ X8_v3]) < dst;\n\tif (v68) goto L_0029;\nL_0048:\n\tgoto L_004E;\n\tv151 = \"il2cpp_codegen_runtime_class_init\"(v111, v28, v29, v30, v31, v32, v33, v34, v109, v110, v36, v37, v38, v39, v40, v41);\n\tv157 = *([v19 @ X19_v2]);\n\tv154 = *([v157 @ X8_v4+B8]);\n\tv153 = *([v154 @ X8_v5]);\nL_004E:\n\tv137 = v152 - dst;\n\tv156 = v137 * *([v144 @ X8_v3+4]);\n\treturnVal2 = -v156;\n\treturn returnVal2;\n// 57 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float DensityDerivative(float dst)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00dc: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA8C]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+B8]");
		object obj4 = 0;
		object obj5 = obj4;
		bool flag = (float)obj4 < dst;
		float result = 0f;
		if (flag)
		{
			goto IL_00c1;
		}
		goto IL_0160;
		IL_00c1:
		return result;
		IL_0160:
		float num2 = (float)obj5 - dst;
		float num3 = num2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v3+4]");
		float num4 = num3 * 0f;
		return 0f - num4;
		IL_007f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+B8]");
		obj4 = 0;
		obj5 = obj4;
		bool flag2 = !((float)obj4 < dst);
		result = 0f;
		if (!flag2)
		{
			goto IL_00c1;
		}
		goto IL_0160;
	}

	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	[global::Cpp2ILInjected.Token(Token = "0x60003B1")]
	[global::Cpp2ILInjected.Address(RVA = "0x10161E8", Offset = "0x10161E8", Length = "0xCC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Runtime.Serialization.ObjectHolderList;\n\tv20 = *([302AA8D]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_002E;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv24 = *([v42 @ X0_v12+E0]) == 0;\n\tif (v24) goto L_0035;\nL_0014:\n\tv144 = *([v42 @ X0_v12+B8]);\n\tv152 = *([v144 @ X8_v3]);\n\tv60 = *([v144 @ X8_v3]) >= dst;\n\tif (v60) goto L_0048;\nL_0029:\n\treturn returnVal1;\nL_002E:\n\t*([v16 @ X20_v1+A8D]) = 1;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv66 = *([v42 @ X0_v12+E0]) == 0;\n\tv45 = ~v66;\n\tif (v45) goto L_0014;\nL_0035:\n\tv90 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv144 = *([v90 @ X0_v6+B8]);\n\tv152 = *([v144 @ X8_v3]);\n\tv68 = *([v144 @ X8_v3]) < dst;\n\tif (v68) goto L_0029;\nL_0048:\n\tgoto L_004D;\n\tv151 = \"il2cpp_codegen_runtime_class_init\"(v111, v28, v29, v30, v31, v32, v33, v34, v109, v110, v36, v37, v38, v39, v40, v41);\n\tv158 = *([v19 @ X19_v2]);\n\tv154 = *([v158 @ X8_v4+B8]);\n\tv153 = *([v154 @ X8_v5]);\nL_004D:\n\tv155 = v152 - dst;\n\tv156 = v155 * v155;\n\tv157 = -v156;\n\treturnVal2 = *([v144 @ X8_v3+8]) * v157;\n\treturn returnVal2;\n// 57 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float NearDensityDerivative(float dst)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00dc: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_011c: Expected O, but got I
		//IL_012c: Expected O, but got I
		//IL_0187: Expected O, but got F4
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA8D]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X0_v6+B8]");
		object obj4 = 0;
		object obj5 = obj4;
		bool flag = (float)obj4 < dst;
		float result = 0f;
		if (flag)
		{
			goto IL_00c1;
		}
		goto IL_0160;
		IL_00c1:
		return result;
		IL_0160:
		float num2 = (float)obj5 - dst;
		float num3 = num2 * num2;
		object obj6 = 0f - num3;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v144 @ X8_v3+8]");
		return 0f * (float)obj6;
		IL_007f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+B8]");
		obj4 = 0;
		obj5 = obj4;
		bool flag2 = !((float)obj4 < dst);
		result = 0f;
		if (!flag2)
		{
			goto IL_00c1;
		}
		goto IL_0160;
	}

	[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.AggressiveInlining)]
	[global::Cpp2ILInjected.Token(Token = "0x60003B2")]
	[global::Cpp2ILInjected.Address(RVA = "0x10162B4", Offset = "0x10162B4", Length = "0xC8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = System.Runtime.Serialization.ObjectHolderList;\n\tv20 = *([302AA8E]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_002F;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv24 = *([v42 @ X0_v12+E0]) == 0;\n\tif (v24) goto L_0036;\nL_0014:\n\tv145 = *([v42 @ X0_v12+B8]);\n\tv153 = *([v145 @ X8_v3]);\n\tv51 = *([v145 @ X8_v3]) < dst;\n\tv52 = ~v51;\n\tv53 = *([v145 @ X8_v3]) - dst;\n\tv55 = v53 == 0;\n\tv60 = ~v55;\n\tv61 = v52 & v60;\n\tif (v61) goto L_0049;\nL_002A:\n\treturn returnVal1;\nL_002F:\n\t*([v16 @ X20_v1+A8E]) = 1;\n\tv42 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv67 = *([v42 @ X0_v12+E0]) == 0;\n\tv45 = ~v67;\n\tif (v45) goto L_0014;\nL_0036:\n\tv91 = *([v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv145 = *([v91 @ X0_v6+B8]);\n\tv153 = *([v145 @ X8_v3]);\n\tv118 = *([v145 @ X8_v3]) < dst;\n\tv85 = ~v118;\n\tv83 = *([v145 @ X8_v3]) - dst;\n\tv79 = v83 == 0;\n\tv119 = ~v85;\n\tv69 = v119 | v79;\n\tif (v69) goto L_002A;\nL_0049:\n\tgoto L_004F;\n\tv152 = \"il2cpp_codegen_runtime_class_init\"(v112, v28, v29, v30, v31, v32, v33, v34, v110, v111, v36, v37, v38, v39, v40, v41);\n\tv157 = *([v19 @ X19_v2]);\n\tv155 = *([v157 @ X8_v4+B8]);\n\tv154 = *([v155 @ X8_v5]);\nL_004F:\n\tv138 = v153 - dst;\n\treturnVal2 = v138 / *([v145 @ X8_v3+C]);\n\treturn returnVal2;\n// 48 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float ViscosityKernel(float dst)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_011c: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_015c: Expected O, but got I
		//IL_016c: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA8E]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X19_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v6+B8]");
		object obj4 = 0;
		object obj5 = obj4;
		bool flag = (float)obj4 < dst;
		bool flag2 = !flag;
		float num2 = (float)obj4 - dst;
		bool flag3 = num2 == 0f;
		bool flag4 = !flag2;
		bool flag5 = flag4 || flag3;
		float result = 0f;
		if (flag5)
		{
			goto IL_0101;
		}
		goto IL_01e3;
		IL_0101:
		return result;
		IL_01e3:
		float num3 = (float)obj5 - dst;
		float num4 = num3;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X8_v3+C]");
		return num4 / 0f;
		IL_007f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v42 @ X0_v12+B8]");
		obj4 = 0;
		obj5 = obj4;
		bool flag6 = (float)obj4 < dst;
		bool flag7 = !flag6;
		float num5 = (float)obj4 - dst;
		bool flag8 = num5 == 0f;
		bool flag9 = !flag8;
		bool flag10 = flag7 && flag9;
		result = 0f;
		if (!flag10)
		{
			goto IL_0101;
		}
		goto IL_01e3;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003B3")]
	[global::Cpp2ILInjected.Address(RVA = "0x101637C", Offset = "0x101637C", Length = "0x54")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = System.Runtime.Serialization.ObjectHolderList;\n\tgoto L_0013;\n\tv17 = System.Runtime.Serialization.ObjectHolderList;\n\tv18 = v17 + 0xD20;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, v20, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv38 = 1;\n\t*([302AA8F]) = v38;\nL_0013:\n\tv39 = *([v12 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]);\n\tv40 = *([v39 @ X8_v3+B8]);\n\t*([v40 @ X8_v4]) = *([2875A80]);\n\treturn;\n// 19 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	static SPHKernels()
	{
		//IL_000e: Expected I, but got O
		//IL_0023: Expected O, but got I
		//IL_0033: Expected O, but got I
		//IL_0043: Expected O, but got I
		nint num = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v12 @ X20_v1 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+D20]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v39 @ X8_v3+B8]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2875A80]");
		obj2 = 0;
	}
}
