[global::Cpp2ILInjected.Token(Token = "0x20000C2")]
public class NumberFormatter : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x6000374")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013450", Offset = "0x1013450", Length = "0xE0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0024;\n\tv22 = \"focus\";\n\tv23 = v22 + 0xE90;\n\tv24 = \"il2cpp_codegen_initialize_runtime_metadata\"(v23, v25, v26, v27, v28, v29, v30, v31, num, v32, v33, v34, v35, v36, v37, v38);\n\tv57 = \"l1\";\n\tv58 = v57 + 0x368;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, v25, v26, v27, v28, v29, v30, v31, num, v32, v33, v34, v35, v36, v37, v38);\n\tv43 = 1;\n\t*([302AA74]) = v43;\nL_0024:\n\tv56 = num >= 0x49742400;\n\tif (v56) goto L_003E;\n\tv70 = num >= 0x447A0000;\n\tif (v70) goto L_004D;\n\treturnVal2 = System.Single::ToString(&num @ V0 (System.Single));\n\treturn returnVal2;\nL_003E:\n\tv71 = \"l1\";\n\treturnVal1 = NumberFormatter::FormatWithSuffix(num, 0xF4240, *([v71 @ X8_v5 (System.String)+368]));\n\treturn returnVal1;\nL_004D:\n\tv87 = \"focus\";\n\treturnVal3 = NumberFormatter::FormatWithSuffix(num, 0x3E8, *([v87 @ X8_v8 (System.String)+E90]));\n\treturn returnVal3;\n// 70 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static string FormatNumber(float num)
	{
		//IL_005c: Expected O, but got I
		//IL_0088: Expected O, but got I
		if (num < 1000000f)
		{
			float num2 = default(float);
			if (num < 1000f)
			{
				return num2.ToString();
			}
			return FormatWithSuffix(num, 1000, "K");
		}
		return FormatWithSuffix(num, 1000000, "M");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000375")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013530", Offset = "0x1013530", Length = "0x114")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_001D;\n\tv31 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv32 = v31 + 0x918;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, suffix, methodInfo, v35, v36, v37, v38, v39, num, v40, v41, v42, v43, v44, v45, v46);\n\tv61 = \", R=\";\n\tv62 = v61 + 0x7E0;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, suffix, methodInfo, v35, v36, v37, v38, v39, num, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AA75]) = v50;\nL_001D:\n\tv51 = \", R=\";\n\tv55 = num / divisor;\n\tgoto L_002A;\n\tv63 = \"il2cpp_codegen_runtime_class_init\"(v57, suffix, methodInfo, v35, v36, v37, v38, v39, v53, v54, v41, v42, v43, v44, v45, v46);\nL_002A:\n\tv66 = 0x274A8CC(*([v26 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]), suffix, methodInfo, v35, v36, v37, v38, v39, v55, divisor, v41, v42, v43, v44, v45, v46);\n\tv67 = System.Math::Floor(v55);\n\tv70 = 2 - v55;\n\tv84 = v67 != 0x7FF0000000000000;\n\tif (v84) goto L_FFFFFFFF;\n\tgoto L_0044;\nL_0044:\n\tv90 = System.Math::Max(0, v87);\n\tv95 = System.String::CreateString(0, 0x23, v90);\n\tv99 = System.String::Concat(*([v51 @ X21_v2 (System.String)+7E0]), v95);\n\tv103 = System.Double::ToString(&v55 @ V8_v2 (System.Single), v99);\n\treturnVal1 = System.String::Concat(v103, suffix);\n\treturn returnVal1;\n// 69 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe static string FormatWithSuffix(float num, int divisor, string suffix)
	{
		//IL_000e: Expected I, but got O
		//IL_007f: Expected I4, but got F8
		//IL_0108: Expected O, but got I
		string text = ", R=";
		float num3 = num / (float)divisor;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A8CC");
		double num4 = global::System.Math.Floor(num3);
		double num5 = 1E-323 - (double)num3;
		int val = ((num4 != 9.218868437227405E+18) ? ((int)num5) : (-2147483646));
		int count = global::System.Math.Max(0, val);
		string text2 = new string('#', count);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v51 @ X21_v2 (System.String)+7E0]");
		string text3 = "0." + text2;
		string text4 = ((double*)(&num3))->ToString(text3);
		return text4 + suffix;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000376")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013644", Offset = "0x1013644", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public NumberFormatter()
	{
	}
}
