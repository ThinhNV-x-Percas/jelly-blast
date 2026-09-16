[global::Cpp2ILInjected.Token(Token = "0x2000003")]
public static class EasingFunction
{
	[global::Cpp2ILInjected.Token(Token = "0x2000004")]
	public enum Ease
	{
		[global::Cpp2ILInjected.Token(Token = "0x4000004")]
		EaseInQuad = 0,
		[global::Cpp2ILInjected.Token(Token = "0x4000005")]
		EaseOutQuad = 1,
		[global::Cpp2ILInjected.Token(Token = "0x4000006")]
		EaseInOutQuad = 2,
		[global::Cpp2ILInjected.Token(Token = "0x4000007")]
		EaseInCubic = 3,
		[global::Cpp2ILInjected.Token(Token = "0x4000008")]
		EaseOutCubic = 4,
		[global::Cpp2ILInjected.Token(Token = "0x4000009")]
		EaseInOutCubic = 5,
		[global::Cpp2ILInjected.Token(Token = "0x400000A")]
		EaseInQuart = 6,
		[global::Cpp2ILInjected.Token(Token = "0x400000B")]
		EaseOutQuart = 7,
		[global::Cpp2ILInjected.Token(Token = "0x400000C")]
		EaseInOutQuart = 8,
		[global::Cpp2ILInjected.Token(Token = "0x400000D")]
		EaseInQuint = 9,
		[global::Cpp2ILInjected.Token(Token = "0x400000E")]
		EaseOutQuint = 10,
		[global::Cpp2ILInjected.Token(Token = "0x400000F")]
		EaseInOutQuint = 11,
		[global::Cpp2ILInjected.Token(Token = "0x4000010")]
		EaseInSine = 12,
		[global::Cpp2ILInjected.Token(Token = "0x4000011")]
		EaseOutSine = 13,
		[global::Cpp2ILInjected.Token(Token = "0x4000012")]
		EaseInOutSine = 14,
		[global::Cpp2ILInjected.Token(Token = "0x4000013")]
		EaseInExpo = 15,
		[global::Cpp2ILInjected.Token(Token = "0x4000014")]
		EaseOutExpo = 16,
		[global::Cpp2ILInjected.Token(Token = "0x4000015")]
		EaseInOutExpo = 17,
		[global::Cpp2ILInjected.Token(Token = "0x4000016")]
		EaseInCirc = 18,
		[global::Cpp2ILInjected.Token(Token = "0x4000017")]
		EaseOutCirc = 19,
		[global::Cpp2ILInjected.Token(Token = "0x4000018")]
		EaseInOutCirc = 20,
		[global::Cpp2ILInjected.Token(Token = "0x4000019")]
		Linear = 21,
		[global::Cpp2ILInjected.Token(Token = "0x400001A")]
		Spring = 22,
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		EaseInBounce = 23,
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		EaseOutBounce = 24,
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		EaseInOutBounce = 25,
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		EaseInBack = 26,
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		EaseOutBack = 27,
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		EaseInOutBack = 28,
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		EaseInElastic = 29,
		[global::Cpp2ILInjected.Token(Token = "0x4000022")]
		EaseOutElastic = 30,
		[global::Cpp2ILInjected.Token(Token = "0x4000023")]
		EaseInOutElastic = 31
	}

	[global::Cpp2ILInjected.Token(Token = "0x2000005")]
	public delegate float Function(float t);

	[global::Cpp2ILInjected.Token(Token = "0x4000002")]
	private const float NATURAL_LOG_OF_2 = 0.6931472f;

	[global::Cpp2ILInjected.Token(Token = "0x6000006")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD2F48", Offset = "0xFD2F48", Length = "0x4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn t;\n")]
	public static float Linear(float t)
	{
		return t;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000007")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD2F4C", Offset = "0xFD2F4C", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = t - 1f;\n\tv19 = v18 < 0;\n\tv20 = v18 == 0;\n\tv21 = t ^ 1f;\n\tv22 = t ^ v18;\n\tv23 = v21 & v22;\n\tv24 = v23 < 0;\n\tv25 = v19 == v24;\n\tv26 = ~v20;\n\tv27 = v25 & v26;\n\tv28 = ~v27;\n\tif (v28) goto L_FFFFFFFF;\n\tgoto L_0025;\nL_0025:\n\tv42 = t >= 0;\n\tif (v42) goto L_FFFFFFFF;\n\tgoto L_002E;\nL_002E:\n\tv49 = v45 * 0x40490FDB;\n\tv51 = v45 * 2.5f;\n\tv52 = v45 * v51;\n\tv53 = v45 * v52;\n\tv57 = v53 + 0x3E4CCCCD;\n\tv58 = v49 * v57;\n\tv59 = 0x274B058(methodInfo, v61, v62, v63, v64, v65, v66, v67, v58, v57, 0x3E4CCCCD, v68, v69, v70, v71, v72);\n\tv74 = 1f - v45;\n\tv79 = 0x274ACA4(v59, v61, v62, v63, v64, v65, v66, v67, v74, 0x400CCCCD, 0x3E4CCCCD, v68, v69, v70, v71, v72);\n\tv80 = v74 * v58;\n\tv81 = v45 + v80;\n\tv85 = v74 * 0x3F99999A;\n\tv86 = v85 + 1f;\n\treturnVal1 = v86 * v81;\n\treturn returnVal1;\n// 49 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float Spring(float t)
	{
		//IL_0040: Expected O, but got F4
		//IL_004d: Expected O, but got F4
		float num = t - 1f;
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj = t ^ 1f;
		object obj2 = t ^ num;
		int num2 = (int)((nint)obj & (nint)obj2);
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		bool flag5 = !flag2;
		float num3 = ((!(flag4 && flag5)) ? t : 1f);
		float num4 = ((!(t < 0f)) ? num3 : 0f);
		float num5 = num4 * (float)global::System.Math.PI;
		float num6 = num4 * 2.5f;
		float num7 = num4 * num6;
		float num8 = num4 * num7;
		float num9 = num8 + 0.2f;
		float num10 = num5 * num9;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274B058");
		float num11 = 1f - num4;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274ACA4");
		float num12 = num11 * num10;
		float num13 = num4 + num12;
		float num14 = num11 * 1.2f;
		float num15 = num14 + 1f;
		return num15 * num13;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000008")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD2FF8", Offset = "0xFD2FF8", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturnVal1 = t * t;\n\treturn returnVal1;\n")]
	public static float EaseInQuad(float t)
	{
		return t * t;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000009")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3000", Offset = "0xFD3000", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -2f;\n\tv3 = t * v1;\n\treturnVal1 = -v3;\n\treturn returnVal1;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutQuad(float t)
	{
		float num = t + -2f;
		float num2 = t * num;
		return 0f - num2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600000A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3010", Offset = "0xFD3010", Length = "0x40")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv5 = v0 - 1f;\n\tv6 = v5 < 0;\n\tv13 = v0 + -1f;\n\tv15 = v13 + -2f;\n\tv16 = v13 * v15;\n\tv17 = v16 + -1f;\n\tv19 = v17 * -0.5f;\n\tv21 = v0 * 0.5f;\n\treturnVal1 = v0 * v21;\n\tv23 = ~v6;\n\tv24 = ~v23;\n\tif (v24) goto L_001D;\n\tgoto L_001D;\nL_001D:\n\treturn returnVal1;\n// 15 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutQuad(float t)
	{
		float num = t + t;
		float num2 = num - 1f;
		bool flag = num2 < 0f;
		float num3 = num + -1f;
		float num4 = num3 + -2f;
		float num5 = num3 * num4;
		float num6 = num5 + -1f;
		float num7 = num6 * -0.5f;
		float num8 = num * 0.5f;
		float result = num * num8;
		if (!flag)
		{
			result = num7;
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600000B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3050", Offset = "0xFD3050", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t * t;\n\treturnVal1 = v0 * t;\n\treturn returnVal1;\n")]
	public static float EaseInCubic(float t)
	{
		float num = t * t;
		return num * t;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600000C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD305C", Offset = "0xFD305C", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv3 = v1 * v1;\n\tv4 = v1 * v3;\n\treturnVal1 = v4 + 1f;\n\treturn returnVal1;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutCubic(float t)
	{
		float num = t + -1f;
		float num2 = num * num;
		float num3 = num * num2;
		return num3 + 1f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600000D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3078", Offset = "0xFD3078", Length = "0x40")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv5 = v0 - 1f;\n\tv6 = v5 < 0;\n\tv13 = v0 + -2f;\n\tv14 = v13 * v13;\n\tv15 = v13 * v14;\n\tv17 = v15 + 2f;\n\tv19 = v17 * 0.5f;\n\tv20 = v0 * 0.5f;\n\tv21 = v0 * v20;\n\treturnVal1 = v0 * v21;\n\tv23 = ~v6;\n\tv24 = ~v23;\n\tif (v24) goto L_001D;\n\tgoto L_001D;\nL_001D:\n\treturn returnVal1;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutCubic(float t)
	{
		float num = t + t;
		float num2 = num - 1f;
		bool flag = num2 < 0f;
		float num3 = num + -2f;
		float num4 = num3 * num3;
		float num5 = num3 * num4;
		float num6 = num5 + 2f;
		float num7 = num6 * 0.5f;
		float num8 = num * 0.5f;
		float num9 = num * num8;
		float result = num * num9;
		if (!flag)
		{
			result = num7;
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600000E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD30B8", Offset = "0xFD30B8", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t * t;\n\tv2 = v0 * t;\n\treturnVal1 = v2 * t;\n\treturn returnVal1;\n")]
	public static float EaseInQuart(float t)
	{
		float num = t * t;
		float num2 = num * t;
		return num2 * t;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600000F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD30C8", Offset = "0xFD30C8", Length = "0x20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv3 = v1 * v1;\n\tv4 = v1 * v3;\n\tv5 = v1 * v4;\n\tv6 = v5 + -1f;\n\treturnVal1 = -v6;\n\treturn returnVal1;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutQuart(float t)
	{
		float num = t + -1f;
		float num2 = num * num;
		float num3 = num * num2;
		float num4 = num * num3;
		float num5 = num4 + -1f;
		return 0f - num5;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000010")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD30E8", Offset = "0xFD30E8", Length = "0x48")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv5 = v0 - 1f;\n\tv6 = v5 < 0;\n\tv13 = v0 + -2f;\n\tv14 = v13 * v13;\n\tv15 = v13 * v14;\n\tv16 = v13 * v15;\n\tv17 = v16 + -2f;\n\tv19 = v17 * -0.5f;\n\tv21 = v0 * 0.5f;\n\tv22 = v0 * v21;\n\tv23 = v0 * v22;\n\treturnVal1 = v0 * v23;\n\tv25 = ~v6;\n\tv26 = ~v25;\n\tif (v26) goto L_001F;\n\tgoto L_001F;\nL_001F:\n\treturn returnVal1;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutQuart(float t)
	{
		float num = t + t;
		float num2 = num - 1f;
		bool flag = num2 < 0f;
		float num3 = num + -2f;
		float num4 = num3 * num3;
		float num5 = num3 * num4;
		float num6 = num3 * num5;
		float num7 = num6 + -2f;
		float num8 = num7 * -0.5f;
		float num9 = num * 0.5f;
		float num10 = num * num9;
		float num11 = num * num10;
		float result = num * num11;
		if (!flag)
		{
			result = num8;
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000011")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3130", Offset = "0xFD3130", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t * t;\n\tv2 = v0 * t;\n\tv3 = v2 * t;\n\treturnVal1 = v3 * t;\n\treturn returnVal1;\n")]
	public static float EaseInQuint(float t)
	{
		float num = t * t;
		float num2 = num * t;
		float num3 = num2 * t;
		return num3 * t;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000012")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3144", Offset = "0xFD3144", Length = "0x24")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv3 = v1 * v1;\n\tv4 = v1 * v3;\n\tv5 = v1 * v4;\n\tv6 = v1 * v5;\n\treturnVal1 = v6 + 1f;\n\treturn returnVal1;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutQuint(float t)
	{
		float num = t + -1f;
		float num2 = num * num;
		float num3 = num * num2;
		float num4 = num * num3;
		float num5 = num * num4;
		return num5 + 1f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000013")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3168", Offset = "0xFD3168", Length = "0x50")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv5 = v0 - 1f;\n\tv6 = v5 < 0;\n\tv13 = v0 + -2f;\n\tv14 = v13 * v13;\n\tv15 = v13 * v14;\n\tv16 = v13 * v15;\n\tv17 = v13 * v16;\n\tv19 = v17 + 2f;\n\tv21 = v19 * 0.5f;\n\tv22 = v0 * 0.5f;\n\tv23 = v0 * v22;\n\tv24 = v0 * v23;\n\tv25 = v0 * v24;\n\treturnVal1 = v0 * v25;\n\tv27 = ~v6;\n\tv28 = ~v27;\n\tif (v28) goto L_0021;\n\tgoto L_0021;\nL_0021:\n\treturn returnVal1;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutQuint(float t)
	{
		float num = t + t;
		float num2 = num - 1f;
		bool flag = num2 < 0f;
		float num3 = num + -2f;
		float num4 = num3 * num3;
		float num5 = num3 * num4;
		float num6 = num3 * num5;
		float num7 = num3 * num6;
		float num8 = num7 + 2f;
		float num9 = num8 * 0.5f;
		float num10 = num * 0.5f;
		float num11 = num * num10;
		float num12 = num * num11;
		float num13 = num * num12;
		float result = num * num13;
		if (!flag)
		{
			result = num9;
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000014")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD31B8", Offset = "0xFD31B8", Length = "0x2C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv9 = t * 0x3FC90FDB;\n\tv11 = 0x274A380(methodInfo, v13, v14, v15, v16, v17, v18, v19, v9, 0x3FC90FDB, v20, v21, v22, v23, v24, v25);\n\treturnVal1 = 1f - v9;\n\treturn returnVal1;\n// 11 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInSine(float t)
	{
		float num = t * ((float)global::System.Math.PI / 2f);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A380");
		return 1f - num;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000015")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD31E4", Offset = "0xFD31E4", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturnVal1 = t * 0x3FC90FDB;\n\tv5 = 0x274B058(methodInfo, v7, v8, v9, v10, v11, v12, v13, returnVal1, 0x3FC90FDB, v14, v15, v16, v17, v18, v19);\n\treturn returnVal1;\n// 3 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutSine(float t)
	{
		float result = t * ((float)global::System.Math.PI / 2f);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274B058");
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000016")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD31F8", Offset = "0xFD31F8", Length = "0x34")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv9 = t * 0x40490FDB;\n\tv11 = 0x274A380(methodInfo, v13, v14, v15, v16, v17, v18, v19, v9, 0x40490FDB, v20, v21, v22, v23, v24, v25);\n\tv27 = v9 + -1f;\n\treturnVal1 = v27 * -0.5f;\n\treturn returnVal1;\n// 12 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutSine(float t)
	{
		float num = t * (float)global::System.Math.PI;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A380");
		float num2 = num + -1f;
		return num2 * -0.5f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000017")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD322C", Offset = "0xFD322C", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\treturnVal1 = v1 * 10f;\n\tv5 = 0x274A53C(methodInfo, v7, v8, v9, v10, v11, v12, v13, returnVal1, 10f, v14, v15, v16, v17, v18, v19);\n\treturn returnVal1;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInExpo(float t)
	{
		float num = t + -1f;
		float result = num * 10f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000018")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3240", Offset = "0xFD3240", Length = "0x24")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv7 = t * -10f;\n\tv9 = 0x274A53C(methodInfo, v11, v12, v13, v14, v15, v16, v17, v7, -10f, v18, v19, v20, v21, v22, v23);\n\treturnVal1 = 1f - v7;\n\treturn returnVal1;\n// 9 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutExpo(float t)
	{
		float num = t * -10f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
		return 1f - num;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000019")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3264", Offset = "0xFD3264", Length = "0x60")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv6 = t + t;\n\tv9 = v6 + -1f;\n\tv20 = v6 >= 1f;\n\tif (v20) goto L_001D;\n\tv22 = v9 * 10f;\n\tv23 = 0x274A53C(methodInfo, v25, v26, v27, v28, v29, v30, v31, v22, 10f, 1f, v32, v33, v34, v35, v36);\n\treturnVal1 = v22 * 0.5f;\n\treturn returnVal1;\nL_001D:\n\tv38 = v9 * -10f;\n\tv39 = 0x274A53C(methodInfo, v25, v26, v27, v28, v29, v30, v31, v38, -10f, 1f, v32, v33, v34, v35, v36);\n\tv45 = 2f - v38;\n\treturnVal2 = v45 * 0.5f;\n\treturn returnVal2;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutExpo(float t)
	{
		float num = t + t;
		float num2 = num + -1f;
		if (num < 1f)
		{
			float num3 = num2 * 10f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
			return num3 * 0.5f;
		}
		float num4 = num2 * -10f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
		float num5 = 2f - num4;
		return num5 * 0.5f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600001A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD32C4", Offset = "0xFD32C4", Length = "0x18")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t * t;\n\tv3 = 1f - v0;\n\tv4 = UnityEngine.Mathf::Sqrt(v3);\n\treturnVal1 = 1f - v4;\n\treturn returnVal1;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInCirc(float t)
	{
		float num = t * t;
		float f = 1f - num;
		float num2 = global::UnityEngine.Mathf.Sqrt(f);
		return 1f - num2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600001B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD32DC", Offset = "0xFD32DC", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv3 = v1 * v1;\n\tv5 = 1f - v3;\n\treturnVal1 = UnityEngine.Mathf::Sqrt(v5);\n\treturn returnVal1;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutCirc(float t)
	{
		float num = t + -1f;
		float num2 = num * num;
		float f = 1f - num2;
		return global::UnityEngine.Mathf.Sqrt(f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600001C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD32F8", Offset = "0xFD32F8", Length = "0x48")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv3 = v0 + -2f;\n\tv4 = v3 * v3;\n\tv5 = v0 * v0;\n\tv16 = v0 >= 1f;\n\tif (v16) goto L_FFFFFFFF;\n\tgoto L_0016;\nL_0016:\n\tv21 = v0 >= 1f;\n\tif (v21) goto L_FFFFFFFF;\n\tgoto L_001E;\nL_001E:\n\tv27 = v0 >= 1f;\n\tif (v27) goto L_FFFFFFFF;\n\tgoto L_0024;\nL_0024:\n\tv31 = 1f - v19;\n\tv32 = UnityEngine.Mathf::Sqrt(v31);\n\tv33 = v32 + v24;\n\treturnVal1 = v33 * v30;\n\treturn returnVal1;\n// 23 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutCirc(float t)
	{
		float num = t + t;
		float num2 = num + -2f;
		float num3 = num2 * num2;
		float num4 = num * num;
		float num5 = ((!(num < 1f)) ? num3 : num4);
		float num6 = ((!(num < 1f)) ? 1f : (-1f));
		float num7 = ((!(num < 1f)) ? 0.5f : (-0.5f));
		float f = 1f - num5;
		float num8 = global::UnityEngine.Mathf.Sqrt(f);
		float num9 = num8 + num6;
		return num9 * num7;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600001D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3340", Offset = "0xFD3340", Length = "0xD8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv13 = t >= 0x3EBA2E8C;\n\tif (v13) goto L_001F;\n\tv16 = t * 0x40F20000;\n\treturnVal1 = v16 * t;\n\treturn returnVal1;\nL_001F:\n\tv30 = t >= 0x3F3A2E8C;\n\tif (v30) goto L_0038;\n\tv64 = t + 0xBF0BA2E9;\n\tv66 = v64 * 0x40F20000;\n\tv67 = v64 * v66;\n\treturnVal2 = v67 + 0.75f;\n\treturn returnVal2;\nL_0038:\n\tv36 = t >= 0x3F68BA2F;\n\tif (v36) goto L_0048;\n\tv75 = t + 0xBF51745D;\n\tv77 = v75 * 0x40F20000;\n\tv78 = v75 * v77;\n\treturnVal3 = v78 + 0.9375f;\n\treturn returnVal3;\nL_0048:\n\tv82 = t + 0xBF745D17;\n\tv85 = v82 * 0x40F20000;\n\tv86 = v82 * v85;\n\treturnVal4 = v86 + 0x3F7C0000;\n\treturn returnVal4;\n// 57 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutBounce(float t)
	{
		if (t < 0.36363637f)
		{
			float num = t * 7.5625f;
			return num * t;
		}
		if (t < 0.72727275f)
		{
			float num2 = t + -0.54545456f;
			float num3 = num2 * 7.5625f;
			float num4 = num2 * num3;
			return num4 + 0.75f;
		}
		if (t < 0.90909094f)
		{
			float num5 = t + -0.8181818f;
			float num6 = num5 * 7.5625f;
			float num7 = num5 * num6;
			return num7 + 0.9375f;
		}
		float num8 = t + -21f / 22f;
		float num9 = num8 * 7.5625f;
		float num10 = num8 * num9;
		return num10 + 63f / 64f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600001E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3418", Offset = "0xFD3418", Length = "0x100")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = 1f - t;\n\tv15 = v1 >= 0x3EBA2E8C;\n\tif (v15) goto L_0023;\n\tv18 = v1 * 0x40F20000;\n\tv19 = v1 * v18;\n\treturnVal1 = 1f - v19;\n\treturn returnVal1;\nL_0023:\n\tv34 = v1 >= 0x3F3A2E8C;\n\tif (v34) goto L_003E;\n\tv68 = v1 + 0xBF0BA2E9;\n\tv70 = v68 * 0x40F20000;\n\tv71 = v68 * v70;\n\tv73 = v71 + 0.75f;\n\treturnVal2 = 1f - v73;\n\treturn returnVal2;\nL_003E:\n\tv36 = v1 >= 0x3F68BA2F;\n\tif (v36) goto L_0050;\n\tv81 = v1 + 0xBF51745D;\n\tv83 = v81 * 0x40F20000;\n\tv84 = v81 * v83;\n\tv86 = v84 + 0.9375f;\n\treturnVal3 = 1f - v86;\n\treturn returnVal3;\nL_0050:\n\tv90 = v1 + 0xBF745D17;\n\tv93 = v90 * 0x40F20000;\n\tv94 = v90 * v93;\n\tv96 = v94 + 0x3F7C0000;\n\treturnVal4 = 1f - v96;\n\treturn returnVal4;\n// 62 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInBounce(float t)
	{
		float num = 1f - t;
		if (num < 0.36363637f)
		{
			float num2 = num * 7.5625f;
			float num3 = num * num2;
			return 1f - num3;
		}
		if (num < 0.72727275f)
		{
			float num4 = num + -0.54545456f;
			float num5 = num4 * 7.5625f;
			float num6 = num4 * num5;
			float num7 = num6 + 0.75f;
			return 1f - num7;
		}
		if (num < 0.90909094f)
		{
			float num8 = num + -0.8181818f;
			float num9 = num8 * 7.5625f;
			float num10 = num8 * num9;
			float num11 = num10 + 0.9375f;
			return 1f - num11;
		}
		float num12 = num + -21f / 22f;
		float num13 = num12 * 7.5625f;
		float num14 = num12 * num13;
		float num15 = num14 + 63f / 64f;
		return 1f - num15;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600001F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3518", Offset = "0xFD3518", Length = "0x240")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv12 = t >= 0.5f;\n\tif (v12) goto L_0027;\n\tv14 = 1f - v0;\n\tv27 = v14 >= 0x3EBA2E8C;\n\tif (v27) goto L_004A;\n\tv45 = v14 * 0x40F20000;\n\tv46 = v14 * v45;\n\tv48 = 1f - v46;\n\treturnVal1 = v48 * 0.5f;\n\treturn returnVal1;\nL_0027:\n\tv29 = v0 + -1f;\n\tv42 = v29 >= 0x3EBA2E8C;\n\tif (v42) goto L_0067;\n\tv66 = v29 * 0x40F20000;\n\tv67 = v29 * v66;\n\tv69 = v67 * 0.5f;\n\treturnVal2 = v69 + 0.5f;\n\treturn returnVal2;\nL_004A:\n\tv63 = v14 >= 0x3F3A2E8C;\n\tif (v63) goto L_0083;\n\tv135 = v14 + 0xBF0BA2E9;\n\tv137 = v135 * 0x40F20000;\n\tv138 = v135 * v137;\n\tv140 = v138 + 0.75f;\n\tv142 = 1f - v140;\n\treturnVal3 = v142 * 0.5f;\n\treturn returnVal3;\nL_0067:\n\tv83 = v29 >= 0x3F3A2E8C;\n\tif (v83) goto L_00A0;\n\tv150 = v29 + 0xBF0BA2E9;\n\tv152 = v150 * 0x40F20000;\n\tv153 = v150 * v152;\n\tv155 = v153 + 0.75f;\n\tv156 = v155 * 0.5f;\n\treturnVal4 = v156 + 0.5f;\n\treturn returnVal4;\nL_0083:\n\tv99 = v14 >= 0x3F68BA2F;\n\tif (v99) goto L_00B3;\n\tv164 = v14 + 0xBF51745D;\n\tv166 = v164 * 0x40F20000;\n\tv167 = v164 * v166;\n\tv169 = v167 + 0.9375f;\n\tv171 = 1f - v169;\n\treturnVal5 = v171 * 0.5f;\n\treturn returnVal5;\nL_00A0:\n\tv100 = v29 >= 0x3F68BA2F;\n\tif (v100) goto L_00C3;\n\tv187 = v29 + 0xBF51745D;\n\tv189 = v187 * 0x40F20000;\n\tv190 = v187 * v189;\n\tv192 = v190 + 0.9375f;\n\tv193 = v192 * 0.5f;\n\treturnVal7 = v193 + 0.5f;\n\treturn returnVal7;\nL_00B3:\n\tv175 = v14 + 0xBF745D17;\n\tv178 = v175 * 0x40F20000;\n\tv179 = v175 * v178;\n\tv181 = v179 + 0x3F7C0000;\n\tv183 = 1f - v181;\n\treturnVal6 = v183 * 0.5f;\n\treturn returnVal6;\nL_00C3:\n\tv197 = v29 + 0xBF745D17;\n\tv200 = v197 * 0x40F20000;\n\tv201 = v197 * v200;\n\tv203 = v201 + 0x3F7C0000;\n\tv204 = v203 * 0.5f;\n\treturnVal8 = v204 + 0.5f;\n\treturn returnVal8;\n// 138 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutBounce(float t)
	{
		float num = t + t;
		if (t < 0.5f)
		{
			float num2 = 1f - num;
			if (num2 < 0.36363637f)
			{
				float num3 = num2 * 7.5625f;
				float num4 = num2 * num3;
				float num5 = 1f - num4;
				return num5 * 0.5f;
			}
			if (num2 < 0.72727275f)
			{
				float num6 = num2 + -0.54545456f;
				float num7 = num6 * 7.5625f;
				float num8 = num6 * num7;
				float num9 = num8 + 0.75f;
				float num10 = 1f - num9;
				return num10 * 0.5f;
			}
			if (num2 < 0.90909094f)
			{
				float num11 = num2 + -0.8181818f;
				float num12 = num11 * 7.5625f;
				float num13 = num11 * num12;
				float num14 = num13 + 0.9375f;
				float num15 = 1f - num14;
				return num15 * 0.5f;
			}
			float num16 = num2 + -21f / 22f;
			float num17 = num16 * 7.5625f;
			float num18 = num16 * num17;
			float num19 = num18 + 63f / 64f;
			float num20 = 1f - num19;
			return num20 * 0.5f;
		}
		float num21 = num + -1f;
		if (num21 < 0.36363637f)
		{
			float num22 = num21 * 7.5625f;
			float num23 = num21 * num22;
			float num24 = num23 * 0.5f;
			return num24 + 0.5f;
		}
		if (num21 < 0.72727275f)
		{
			float num25 = num21 + -0.54545456f;
			float num26 = num25 * 7.5625f;
			float num27 = num25 * num26;
			float num28 = num27 + 0.75f;
			float num29 = num28 * 0.5f;
			return num29 + 0.5f;
		}
		if (num21 < 0.90909094f)
		{
			float num30 = num21 + -0.8181818f;
			float num31 = num30 * 7.5625f;
			float num32 = num30 * num31;
			float num33 = num32 + 0.9375f;
			float num34 = num33 * 0.5f;
			return num34 + 0.5f;
		}
		float num35 = num21 + -21f / 22f;
		float num36 = num35 * 7.5625f;
		float num37 = num35 * num36;
		float num38 = num37 + 63f / 64f;
		float num39 = num38 * 0.5f;
		return num39 + 0.5f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000020")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3758", Offset = "0xFD3758", Length = "0x30")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t * t;\n\tv2 = v0 * t;\n\tv6 = t * 0x402CE6B0;\n\tv10 = v6 + 0xBFD9CD60;\n\treturnVal1 = v2 * v10;\n\treturn returnVal1;\n// 6 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInBack(float t)
	{
		float num = t * t;
		float num2 = num * t;
		float num3 = t * 2.70158f;
		float num4 = num3 + -1.70158f;
		return num2 * num4;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000021")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3788", Offset = "0xFD3788", Length = "0x40")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv3 = v1 * v1;\n\tv4 = v1 * v3;\n\tv8 = v1 * 0x402CE6B0;\n\tv12 = v8 + 0x3FD9CD60;\n\tv13 = v4 * v12;\n\treturnVal1 = v13 + 1f;\n\treturn returnVal1;\n// 8 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutBack(float t)
	{
		float num = t + -1f;
		float num2 = num * num;
		float num3 = num * num2;
		float num4 = num * 2.70158f;
		float num5 = num4 + 1.70158f;
		float num6 = num3 * num5;
		return num6 + 1f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000022")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD37C8", Offset = "0xFD37C8", Length = "0x84")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv5 = v0 - 1f;\n\tv6 = v5 < 0;\n\tv13 = v0 + -2f;\n\tv14 = v13 * v13;\n\tv15 = v13 * v14;\n\tv19 = v13 * 0x406612FF;\n\tv23 = v19 + 0x402612FF;\n\tv24 = v15 * v23;\n\tv26 = v24 + 2f;\n\tv27 = v0 * v0;\n\tv28 = v0 * v27;\n\tv32 = v0 * 0x406612FF;\n\tv36 = v32 + 0xC02612FF;\n\tv42 = v28 * v36;\n\tv38 = ~v6;\n\tv39 = ~v38;\n\tif (v39) goto L_002D;\n\tgoto L_002D;\nL_002D:\n\treturnVal1 = v42 * 0.5f;\n\treturn returnVal1;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutBack(float t)
	{
		float num = t + t;
		float num2 = num - 1f;
		bool flag = num2 < 0f;
		float num3 = num + -2f;
		float num4 = num3 * num3;
		float num5 = num3 * num4;
		float num6 = num3 * 3.5949094f;
		float num7 = num6 + 2.5949094f;
		float num8 = num5 * num7;
		float num9 = num8 + 2f;
		float num10 = num * num;
		float num11 = num * num10;
		float num12 = num * 3.5949094f;
		float num13 = num12 + -2.5949094f;
		float num14 = num11 * num13;
		if (!flag)
		{
			num14 = num9;
		}
		return num14 * 0.5f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000023")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD384C", Offset = "0xFD384C", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv11 = t != 0;\n\tif (v11) goto L_0013;\nL_000D:\n\treturn v28;\nL_0013:\n\tv21 = t == 1f;\n\tif (v21) goto L_000D;\n\tv77 = t + -1f;\n\tv79 = v77 * 10f;\n\tv80 = 0x274A53C(methodInfo, v81, v82, v83, v84, v85, v86, v87, v79, -1f, v88, v89, v90, v91, v92, v93);\n\tv98 = v77 + 0xBD99999A;\n\tv102 = v98 * 0xC0C90FDB;\n\tv105 = v102 / 0x3E99999A;\n\tv43 = 0x274B058(v80, v81, v82, v83, v84, v85, v86, v87, v105, 0x3E99999A, v88, v89, v90, v91, v92, v93);\n\tv73 = v105 * v79;\n\treturn v73;\n// 44 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInElastic(float t)
	{
		bool flag = t != 0f;
		float result = 0f;
		if (flag)
		{
			bool flag2 = t == 1f;
			result = 1f;
			if (!flag2)
			{
				float num = t + -1f;
				float num2 = num * 10f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
				float num3 = num + -0.075f;
				float num4 = num3 * ((float)global::System.Math.PI * -2f);
				float num5 = num4 / 0.3f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274B058");
				return num5 * num2;
			}
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000024")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD38D8", Offset = "0xFD38D8", Length = "0x90")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = t != 0;\n\tif (v22) goto L_001E;\nL_0018:\n\treturn returnVal1;\nL_001E:\n\tv32 = t == 1f;\n\tif (v32) goto L_0018;\n\tv74 = t * -10f;\n\tv75 = 0x274A53C(methodInfo, v76, v77, v78, v79, v80, v81, v82, v74, v47, v83, v84, v85, v86, v87, v88);\n\tv93 = t + 0xBD99999A;\n\tv97 = v93 * 0x40C90FDB;\n\tv100 = v97 / 0x3E99999A;\n\tv54 = 0x274B058(v75, v76, v77, v78, v79, v80, v81, v82, v100, 0x3E99999A, v83, v84, v85, v86, v87, v88);\n\tv101 = v74 * v100;\n\treturnVal2 = v101 + 1f;\n\treturn returnVal2;\n// 48 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutElastic(float t)
	{
		bool flag = t != 0f;
		float result = 0f;
		if (flag)
		{
			bool flag2 = t == 1f;
			result = 1f;
			if (!flag2)
			{
				float num = t * -10f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
				float num2 = t + -0.075f;
				float num3 = num2 * ((float)global::System.Math.PI * 2f);
				float num4 = num3 / 0.3f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274B058");
				float num5 = num * num4;
				return num5 + 1f;
			}
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000025")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3968", Offset = "0xFD3968", Length = "0xD4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = t != 0;\n\tif (v30) goto L_0026;\nL_0020:\n\treturn returnVal1;\nL_0026:\n\tv40 = t == 1f;\n\tif (v40) goto L_0020;\n\tv80 = overshoot >= 1f;\n\tif (v80) goto L_003D;\n\tv129 = period * 0.25f;\n\tgoto L_0046;\nL_003D:\n\tv110 = 1f / overshoot;\n\tv128 = 0x274A260(v128, v112, v113, v114, v115, v116, v117, v118, v110, overshoot, period, v119, v120, v121, v122, v123);\n\tv124 = period / 0x40C90FDB;\n\tv129 = v124 * v110;\nL_0046:\n\tv135 = t * -10f;\n\tv136 = 0x274A53C(v128, v112, v113, v114, v115, v116, v117, v118, v135, v124, period, v119, v120, v121, v122, v123);\n\tv140 = t - v129;\n\tv143 = v140 * 0x40C90FDB;\n\tv144 = v143 / period;\n\tv66 = 0x274B058(v136, v112, v113, v114, v115, v116, v117, v118, v144, 0x40C90FDB, period, v119, v120, v121, v122, v123);\n\tv145 = v135 * v131;\n\tv146 = v145 * v144;\n\treturnVal2 = v146 + 1f;\n\treturn returnVal2;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutElastic(float t, float overshoot = 1f, float period = 0.3f)
	{
		bool flag = t != 0f;
		float result = 0f;
		if (flag)
		{
			bool flag2 = t == 1f;
			result = 1f;
			if (!flag2)
			{
				float num;
				float num3;
				if (overshoot < 1f)
				{
					num = period * 0.25f;
					float num2 = overshoot;
					num3 = 1f;
				}
				else
				{
					float num4 = 1f / overshoot;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A260");
					float num2 = period / ((float)global::System.Math.PI * 2f);
					num = num2 * num4;
					num3 = overshoot;
				}
				float num5 = t * -10f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
				float num6 = t - num;
				float num7 = num6 * ((float)global::System.Math.PI * 2f);
				float num8 = num7 / period;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274B058");
				float num9 = num5 * num3;
				float num10 = num9 * num8;
				return num10 + 1f;
			}
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000026")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3A3C", Offset = "0xFD3A3C", Length = "0x60")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = returnVal1 < 0;\n\tv3 = ~v1;\n\tv6 = returnVal1 == 0;\n\tv11 = ~v3;\n\tv12 = v11 | v6;\n\tif (v12) goto L_0034;\n\tv23 = returnVal1 >= 1f;\n\tif (v23) goto L_0034;\n\tv53 = overshoot < 0;\n\tv49 = ~v53;\n\tv43 = overshoot == 0;\n\tv54 = ~v49;\n\tv33 = v54 | v43;\n\tif (v33) goto L_0034;\n\tv68 = overshoot + 1f;\n\tv70 = v68 + -1f;\n\tv71 = v68 * v70;\n\tv72 = UnityEngine.Mathf::Sqrt(v71);\n\tv73 = v68 - v72;\n\tv74 = v68 + v68;\n\tv27 = v74 / v73;\n\tv75 = v73 * v73;\n\tv76 = v68 / v75;\n\tv77 = v76 * returnVal1;\n\tv30 = v77 * returnVal1;\n\tv25 = v27 * returnVal1;\n\tv50 = v25 - v30;\nL_0034:\n\treturn v50;\n// 25 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseParabolaOvershoot(float t, float overshoot = 0.2f)
	{
		float num = default(float);
		bool flag = num < 0f;
		bool flag2 = !flag;
		bool flag3 = num == 0f;
		bool flag4 = !flag2;
		bool flag5 = flag4 || flag3;
		float result = 0f;
		if (!flag5)
		{
			bool flag6 = !(num < 1f);
			result = 1f;
			if (!flag6)
			{
				bool flag7 = overshoot < 0f;
				bool flag8 = !flag7;
				bool flag9 = overshoot == 0f;
				bool flag10 = !flag8;
				if (!(flag10 || flag9))
				{
					float num2 = overshoot + 1f;
					float num3 = num2 + -1f;
					float f = num2 * num3;
					float num4 = global::UnityEngine.Mathf.Sqrt(f);
					float num5 = num2 - num4;
					float num6 = num2 + num2;
					float num7 = num6 / num5;
					float num8 = num5 * num5;
					float num9 = num2 / num8;
					float num10 = num9 * num;
					float num11 = num10 * num;
					float num12 = num7 * num;
					result = num12 - num11;
				}
			}
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000027")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3A9C", Offset = "0xFD3A9C", Length = "0xD4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv12 = t != 0;\n\tif (v12) goto L_0013;\nL_000D:\n\treturn returnVal1;\nL_0013:\n\tv22 = t == 1f;\n\tif (v22) goto L_000D;\n\tv107 = t + t;\n\tv109 = v107 + -1f;\n\tv113 = v109 + 0xBD99999A;\n\tv117 = v113 * 0x40C90FDB;\n\tv120 = v117 / 0x3E99999A;\n\tv121 = 0x274B058(methodInfo, v122, v123, v124, v125, v126, v127, v128, v120, 0x3E99999A, v129, v130, v131, v132, v133, v134);\n\tv82 = v107 >= 1f;\n\tif (v82) goto L_004D;\n\tv139 = v109 * 10f;\n\tv46 = 0x274A53C(v121, v122, v123, v124, v125, v126, v127, v128, v139, 0x3E99999A, v129, v130, v131, v132, v133, v134);\n\tv142 = v139 * v120;\n\treturnVal2 = v142 * -0.5f;\n\treturn returnVal2;\nL_004D:\n\tv141 = v109 * -10f;\n\tv47 = 0x274A53C(v121, v122, v123, v124, v125, v126, v127, v128, v141, 0x3E99999A, v129, v130, v131, v132, v133, v134);\n\tv143 = v141 * v120;\n\tv144 = v143 * 0.5f;\n\treturnVal3 = v144 + 1f;\n\treturn returnVal3;\n// 67 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutElastic(float t)
	{
		bool flag = t != 0f;
		float result = 0f;
		if (flag)
		{
			bool flag2 = t == 1f;
			result = 1f;
			if (!flag2)
			{
				float num = t + t;
				float num2 = num + -1f;
				float num3 = num2 + -0.075f;
				float num4 = num3 * ((float)global::System.Math.PI * 2f);
				float num5 = num4 / 0.3f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274B058");
				if (num < 1f)
				{
					float num6 = num2 * 10f;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
					float num7 = num6 * num5;
					return num7 * -0.5f;
				}
				float num8 = num2 * -10f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
				float num9 = num8 * num5;
				float num10 = num9 * 0.5f;
				return num10 + 1f;
			}
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000028")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3B70", Offset = "0xFD3B70", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturn 1f;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float LinearD(float t)
	{
		return 1f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000029")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3B78", Offset = "0xFD3B78", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturnVal1 = t + t;\n\treturn returnVal1;\n")]
	public static float EaseInQuadD(float t)
	{
		return t + t;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600002A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3B80", Offset = "0xFD3B80", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\treturnVal1 = 2f - v0;\n\treturn returnVal1;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutQuadD(float t)
	{
		float num = t + t;
		return 2f - num;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600002B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3B90", Offset = "0xFD3B90", Length = "0x20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\treturnVal1 = t + t;\n\tv3 = returnVal1 + -1f;\n\tv5 = 1f - v3;\n\tv15 = returnVal1 >= 1f;\n\tif (v15) goto L_FFFFFFFF;\n\tgoto L_0014;\nL_0014:\n\treturn returnVal1;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutQuadD(float t)
	{
		float num = t + t;
		float num2 = num + -1f;
		float num3 = 1f - num2;
		if (!(num < 1f))
		{
			num = num3;
		}
		return num;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600002C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3BB0", Offset = "0xFD3BB0", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t * 3f;\n\treturnVal1 = v1 * t;\n\treturn returnVal1;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInCubicD(float t)
	{
		float num = t * 3f;
		return num * t;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600002D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3BC0", Offset = "0xFD3BC0", Length = "0x18")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv4 = v1 * 3f;\n\treturnVal1 = v1 * v4;\n\treturn returnVal1;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutCubicD(float t)
	{
		float num = t + -1f;
		float num2 = num * 3f;
		return num * num2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600002E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3BD8", Offset = "0xFD3BD8", Length = "0x28")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv17 = t + t;\n\tv3 = v17 + -1f;\n\tv14 = v17 >= 1f;\n\tif (v14) goto L_FFFFFFFF;\n\tgoto L_0014;\nL_0014:\n\tv19 = v17 * 1.5f;\n\treturnVal1 = v17 * v19;\n\treturn returnVal1;\n// 15 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutCubicD(float t)
	{
		float num = t + t;
		float num2 = num + -1f;
		if (!(num < 1f))
		{
			num = num2;
		}
		float num3 = num * 1.5f;
		return num * num3;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600002F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3C00", Offset = "0xFD3C00", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t * 4f;\n\tv3 = v1 * t;\n\treturnVal1 = v3 * t;\n\treturn returnVal1;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInQuartD(float t)
	{
		float num = t * 4f;
		float num2 = num * t;
		return num2 * t;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000030")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3C14", Offset = "0xFD3C14", Length = "0x1C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv4 = v1 * -4f;\n\tv5 = v1 * v4;\n\treturnVal1 = v1 * v5;\n\treturn returnVal1;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutQuartD(float t)
	{
		float num = t + -1f;
		float num2 = num * -4f;
		float num3 = num * num2;
		return num * num3;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000031")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3C30", Offset = "0xFD3C30", Length = "0x38")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv5 = v0 - 1f;\n\tv6 = v5 < 0;\n\tv13 = v0 + -1f;\n\tv15 = v13 * -2f;\n\tv16 = v13 * v15;\n\tv17 = v13 * v16;\n\tv18 = v0 + v0;\n\tv19 = v0 * v18;\n\treturnVal1 = v0 * v19;\n\tv21 = ~v6;\n\tv22 = ~v21;\n\tif (v22) goto L_001B;\n\tgoto L_001B;\nL_001B:\n\treturn returnVal1;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutQuartD(float t)
	{
		float num = t + t;
		float num2 = num - 1f;
		bool flag = num2 < 0f;
		float num3 = num + -1f;
		float num4 = num3 * -2f;
		float num5 = num3 * num4;
		float num6 = num3 * num5;
		float num7 = num + num;
		float num8 = num * num7;
		float result = num * num8;
		if (!flag)
		{
			result = num6;
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000032")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3C68", Offset = "0xFD3C68", Length = "0x18")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t * 5f;\n\tv3 = v1 * t;\n\tv4 = v3 * t;\n\treturnVal1 = v4 * t;\n\treturn returnVal1;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInQuintD(float t)
	{
		float num = t * 5f;
		float num2 = num * t;
		float num3 = num2 * t;
		return num3 * t;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000033")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3C80", Offset = "0xFD3C80", Length = "0x20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv4 = v1 * 5f;\n\tv5 = v1 * v4;\n\tv6 = v1 * v5;\n\treturnVal1 = v1 * v6;\n\treturn returnVal1;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutQuintD(float t)
	{
		float num = t + -1f;
		float num2 = num * 5f;
		float num3 = num * num2;
		float num4 = num * num3;
		return num * num4;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000034")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3CA0", Offset = "0xFD3CA0", Length = "0x30")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv17 = t + t;\n\tv3 = v17 + -1f;\n\tv14 = v17 >= 1f;\n\tif (v14) goto L_FFFFFFFF;\n\tgoto L_0014;\nL_0014:\n\tv19 = v17 * 2.5f;\n\tv20 = v17 * v19;\n\tv21 = v17 * v20;\n\treturnVal1 = v17 * v21;\n\treturn returnVal1;\n// 15 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutQuintD(float t)
	{
		float num = t + t;
		float num2 = num + -1f;
		if (!(num < 1f))
		{
			num = num2;
		}
		float num3 = num * 2.5f;
		float num4 = num * num3;
		float num5 = num * num4;
		return num * num5;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000035")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3CD0", Offset = "0xFD3CD0", Length = "0x30")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv13 = t * 0x3FC90FDB;\n\tv15 = 0x274B058(methodInfo, v17, v18, v19, v20, v21, v22, v23, v13, v24, v25, v26, v27, v28, v29, v30);\n\treturnVal1 = v13 * 0x3FC90FDB;\n\treturn returnVal1;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInSineD(float t)
	{
		float num = t * ((float)global::System.Math.PI / 2f);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274B058");
		return num * ((float)global::System.Math.PI / 2f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000036")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3D00", Offset = "0xFD3D00", Length = "0x30")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv13 = t * 0x3FC90FDB;\n\tv15 = 0x274A380(methodInfo, v17, v18, v19, v20, v21, v22, v23, v13, v24, v25, v26, v27, v28, v29, v30);\n\treturnVal1 = v13 * 0x3FC90FDB;\n\treturn returnVal1;\n// 14 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutSineD(float t)
	{
		float num = t * ((float)global::System.Math.PI / 2f);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A380");
		return num * ((float)global::System.Math.PI / 2f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000037")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3D30", Offset = "0xFD3D30", Length = "0x34")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv9 = t * 0x40490FDB;\n\tv11 = 0x274B058(methodInfo, v13, v14, v15, v16, v17, v18, v19, v9, 0x40490FDB, v20, v21, v22, v23, v24, v25);\n\treturnVal1 = v9 * 0x3FC90FDB;\n\treturn returnVal1;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutSineD(float t)
	{
		float num = t * (float)global::System.Math.PI;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274B058");
		return num * ((float)global::System.Math.PI / 2f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000038")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3D64", Offset = "0xFD3D64", Length = "0x34")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv7 = t + -1f;\n\tv10 = v7 * 10f;\n\tv11 = 0x274A53C(methodInfo, v13, v14, v15, v16, v17, v18, v19, v10, 10f, v20, v21, v22, v23, v24, v25);\n\treturnVal1 = v10 * 0x40DDCE9E;\n\treturn returnVal1;\n// 12 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInExpoD(float t)
	{
		float num = t + -1f;
		float num2 = num * 10f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
		return num2 * 6.931472f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000039")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3D98", Offset = "0xFD3D98", Length = "0x2C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv7 = t * -10f;\n\tv9 = 0x274A53C(methodInfo, v11, v12, v13, v14, v15, v16, v17, v7, -10f, v18, v19, v20, v21, v22, v23);\n\treturnVal1 = v7 * 0x40DDCE9E;\n\treturn returnVal1;\n// 11 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutExpoD(float t)
	{
		float num = t * -10f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
		return num * 6.931472f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600003A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3DC4", Offset = "0xFD3DC4", Length = "0x54")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv10 = t + t;\n\tv13 = v10 + -1f;\n\tv15 = v13 * 10f;\n\tv16 = 0x274A53C(methodInfo, v18, v19, v20, v21, v22, v23, v24, v15, 10f, v25, v26, v27, v28, v29, v30);\n\tv34 = v10 - 1f;\n\tv35 = v34 < 0;\n\tv44 = 0x405DCE9E / v15;\n\treturnVal1 = v15 * 0x405DCE9E;\n\tv47 = ~v35;\n\tv48 = ~v47;\n\tif (v48) goto L_0028;\n\tgoto L_0028;\nL_0028:\n\treturn returnVal1;\n// 28 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutExpoD(float t)
	{
		float num = t + t;
		float num2 = num + -1f;
		float num3 = num2 * 10f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
		float num4 = num - 1f;
		bool flag = num4 < 0f;
		float num5 = 3.465736f / num3;
		float result = num3 * 3.465736f;
		if (!flag)
		{
			result = num5;
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600003B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3E18", Offset = "0xFD3E18", Length = "0x18")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t * t;\n\tv3 = 1f - v0;\n\tv4 = UnityEngine.Mathf::Sqrt(v3);\n\treturnVal1 = t / v4;\n\treturn returnVal1;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInCircD(float t)
	{
		float num = t * t;
		float f = 1f - num;
		float num2 = global::UnityEngine.Mathf.Sqrt(f);
		return t / num2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600003C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3E30", Offset = "0xFD3E30", Length = "0x24")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv3 = v1 * v1;\n\tv5 = 1f - v3;\n\tv6 = UnityEngine.Mathf::Sqrt(v5);\n\tv7 = -v1;\n\treturnVal1 = v7 / v6;\n\treturn returnVal1;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutCircD(float t)
	{
		//IL_0045: Expected O, but got F4
		float num = t + -1f;
		float num2 = num * num;
		float f = 1f - num2;
		float num3 = global::UnityEngine.Mathf.Sqrt(f);
		object obj = 0f - num;
		return (float)obj / num3;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600003D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3E54", Offset = "0xFD3E54", Length = "0x44")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv30 = t + t;\n\tv5 = v30 - 1f;\n\tv6 = v5 < 0;\n\tv13 = v30 + -1f;\n\tv14 = v13 * v13;\n\tv15 = 1f - v14;\n\tv16 = UnityEngine.Mathf::Sqrt(v15);\n\tv17 = -v13;\n\tv18 = v30 * v30;\n\tv19 = 1f - v18;\n\tv25 = UnityEngine.Mathf::Sqrt(v19);\n\tv21 = ~v6;\n\tv22 = ~v21;\n\tif (v22) goto L_001B;\n\tgoto L_001B;\nL_001B:\n\tv26 = ~v6;\n\tv27 = ~v26;\n\tif (v27) goto L_0022;\n\tgoto L_0022;\nL_0022:\n\tv31 = v25 + v25;\n\treturnVal1 = v30 / v31;\n\treturn returnVal1;\n// 15 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutCircD(float t)
	{
		float num = t + t;
		float num2 = num - 1f;
		bool flag = num2 < 0f;
		float num3 = num + -1f;
		float num4 = num3 * num3;
		float f = 1f - num4;
		float num5 = global::UnityEngine.Mathf.Sqrt(f);
		float num6 = 0f - num3;
		float num7 = num * num;
		float f2 = 1f - num7;
		float num8 = global::UnityEngine.Mathf.Sqrt(f2);
		if (!flag)
		{
			num8 = num5;
		}
		if (!flag)
		{
			num = num6;
		}
		float num9 = num8 + num8;
		return num / num9;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600003E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3E98", Offset = "0xFD3E98", Length = "0x7C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv49 = 1f - t;\n\tv9 = v49 < 0x3EBA2E8C;\n\tif (v9) goto L_0037;\n\tv27 = v49 >= 0x3F3A2E8C;\n\tif (v27) goto L_002C;\n\tgoto L_0034;\nL_002C:\n\tv70 = v49 >= 0x3F68BA2F;\n\tif (v70) goto L_FFFFFFFF;\n\tgoto L_0034;\nL_0034:\n\tv49 = v49 + v48;\nL_0037:\n\treturnVal1 = v49 * 0x41720000;\n\treturn returnVal1;\n// 45 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInBounceD(float t)
	{
		float num = 1f - t;
		if (!(num < 0.36363637f))
		{
			int num2 = ((num < 0.72727275f) ? (-1089756439) : ((!(num < 0.90909094f)) ? (-1082893033) : (-1085180835)));
			num += (float)num2;
		}
		return num * 15.125f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600003F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3F14", Offset = "0xFD3F14", Length = "0x74")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv7 = v26 < 0x3EBA2E8C;\n\tif (v7) goto L_0035;\n\tv25 = v26 >= 0x3F3A2E8C;\n\tif (v25) goto L_002A;\n\tgoto L_0032;\nL_002A:\n\tv68 = v26 >= 0x3F68BA2F;\n\tif (v68) goto L_FFFFFFFF;\n\tgoto L_0032;\nL_0032:\n\tv26 = v26 + v50;\nL_0035:\n\treturnVal1 = v26 * 0x41720000;\n\treturn returnVal1;\n// 44 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutBounceD(float t)
	{
		float num = default(float);
		if (!(num < 0.36363637f))
		{
			int num2 = ((num < 0.72727275f) ? (-1089756439) : ((!(num < 0.90909094f)) ? (-1082893033) : (-1085180835)));
			num += (float)num2;
		}
		return num * 15.125f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000040")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD3F88", Offset = "0xFD3F88", Length = "0xC8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv12 = t >= 0.5f;\n\tif (v12) goto L_0024;\n\tv43 = 1f - v0;\n\tv27 = v43 >= 0x3EBA2E8C;\n\tif (v27) goto L_003E;\nL_001F:\n\tv56 = v43 * 0x41720000;\n\treturnVal1 = v56 * 0.5f;\n\treturn returnVal1;\nL_0024:\n\tv43 = v0 + -1f;\n\tv36 = v43 < 0x3EBA2E8C;\n\tif (v36) goto L_001F;\nL_003E:\n\tv83 = v60 >= 0x3F3A2E8C;\n\tif (v83) goto L_004F;\n\tgoto L_0057;\nL_004F:\n\tv122 = v60 >= 0x3F68BA2F;\n\tif (v122) goto L_FFFFFFFF;\n\tgoto L_0057;\nL_0057:\n\tv128 = v60 + v123;\n\tv130 = v128 * 0x41720000;\n\treturnVal2 = v130 * 0.5f;\n\treturn returnVal2;\n// 72 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutBounceD(float t)
	{
		float num = t + t;
		float num2;
		float num3;
		if (t < 0.5f)
		{
			num2 = 1f - num;
			bool flag = !(num2 < 0.36363637f);
			num3 = num2;
			if (!flag)
			{
				goto IL_006b;
			}
		}
		else
		{
			num2 = num + -1f;
			bool flag2 = num2 < 0.36363637f;
			num3 = num2;
			if (flag2)
			{
				goto IL_006b;
			}
		}
		int num4 = ((num3 < 0.72727275f) ? (-1089756439) : ((!(num3 < 0.90909094f)) ? (-1082893033) : (-1085180835)));
		float num5 = num3 + (float)num4;
		float num6 = num5 * 15.125f;
		return num6 * 0.5f;
		IL_006b:
		float num7 = num2 * 15.125f;
		return num7 * 0.5f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000041")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD4050", Offset = "0xFD4050", Length = "0x2C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv3 = t * 0x4101AD04;\n\tv5 = v3 * t;\n\tv9 = t * 0xC059CD60;\n\treturnVal1 = v5 + v9;\n\treturn returnVal1;\n// 6 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInBackD(float t)
	{
		float num = t * 8.10474f;
		float num2 = num * t;
		float num3 = t * -3.40316f;
		return num2 + num3;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000042")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD407C", Offset = "0xFD407C", Length = "0x34")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv1 = t + -1f;\n\tv6 = v1 * 0x4101AD04;\n\tv7 = v1 * v6;\n\tv11 = v1 * 0x4059CD60;\n\treturnVal1 = v11 + v7;\n\treturn returnVal1;\n// 7 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutBackD(float t)
	{
		float num = t + -1f;
		float num2 = num * 8.10474f;
		float num3 = num * num2;
		float num4 = num * 3.40316f;
		return num4 + num3;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000043")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD40B0", Offset = "0xFD40B0", Length = "0x74")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv0 = t + t;\n\tv5 = v0 - 1f;\n\tv6 = v5 < 0;\n\tv13 = v0 + -1f;\n\tv17 = v13 * 0x412C8E3F;\n\tv18 = v13 * v17;\n\tv22 = v13 * 0x40A612FF;\n\tv23 = v22 + v18;\n\tv27 = v0 * 0x412C8E3F;\n\tv28 = v0 * v27;\n\tv32 = v0 * 0xC0A612FF;\n\tv38 = v28 + v32;\n\tv34 = ~v6;\n\tv35 = ~v34;\n\tif (v35) goto L_0029;\n\tgoto L_0029;\nL_0029:\n\treturnVal1 = v38 * 0.5f;\n\treturn returnVal1;\n// 25 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutBackD(float t)
	{
		float num = t + t;
		float num2 = num - 1f;
		bool flag = num2 < 0f;
		float num3 = num + -1f;
		float num4 = num3 * 10.784728f;
		float num5 = num3 * num4;
		float num6 = num3 * 5.189819f;
		float num7 = num6 + num5;
		float num8 = num * 10.784728f;
		float num9 = num * num8;
		float num10 = num * -5.189819f;
		float num11 = num9 + num10;
		if (!flag)
		{
			num11 = num7;
		}
		return num11 * 0.5f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000044")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD4124", Offset = "0xFD4124", Length = "0x78")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv15 = 1f - t;\n\tv18 = v15 * -10f;\n\tv19 = 0x274A53C(methodInfo, v21, v22, v23, v24, v25, v26, v27, v18, 1f, v28, v29, v30, v31, v32, v33);\n\tv38 = v15 + 0xBD99999A;\n\tv42 = v38 * 0x40C90FDB;\n\tv46 = v42 / 0x3E99999A;\n\tv47 = 0x274A380(v19, v21, v22, v23, v24, v25, v26, v27, v46, 1f, v28, v29, v30, v31, v32, v33);\n\tv48 = v18 * 0x40C90FDB;\n\tv49 = v48 * v46;\n\treturnVal1 = v49 / 0x3E99999A;\n\treturn returnVal1;\n// 27 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInElasticD(float t)
	{
		float num = 1f - t;
		float num2 = num * -10f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
		float num3 = num + -0.075f;
		float num4 = num3 * ((float)global::System.Math.PI * 2f);
		float num5 = num4 / 0.3f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A380");
		float num6 = num2 * ((float)global::System.Math.PI * 2f);
		float num7 = num6 * num5;
		return num7 / 0.3f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000045")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD419C", Offset = "0xFD419C", Length = "0x74")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv17 = t * -10f;\n\tv18 = 0x274A53C(methodInfo, v20, v21, v22, v23, v24, v25, v26, v17, v27, v28, v29, v30, v31, v32, v33);\n\tv38 = t + 0xBD99999A;\n\tv42 = v38 * 0x40C90FDB;\n\tv46 = v42 / 0x3E99999A;\n\tv47 = 0x274A380(v18, v20, v21, v22, v23, v24, v25, v26, v46, v27, v28, v29, v30, v31, v32, v33);\n\tv48 = v17 * 0x40C90FDB;\n\tv49 = v48 * v46;\n\treturnVal1 = v49 / 0x3E99999A;\n\treturn returnVal1;\n// 27 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseOutElasticD(float t)
	{
		float num = t * -10f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
		float num2 = t + -0.075f;
		float num3 = num2 * ((float)global::System.Math.PI * 2f);
		float num4 = num3 / 0.3f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A380");
		float num5 = num * ((float)global::System.Math.PI * 2f);
		float num6 = num5 * num4;
		return num6 / 0.3f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000046")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD4210", Offset = "0xFD4210", Length = "0x98")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = t + t;\n\tv18 = v16 + -1f;\n\tv22 = v18 + 0xBD99999A;\n\tv26 = v22 * 0x40C90FDB;\n\tv30 = v26 / 0x3E99999A;\n\tv31 = 0x274A380(methodInfo, v33, v34, v35, v36, v37, v38, v39, v30, 0x3E99999A, v40, v41, v42, v43, v44, v45);\n\tv59 = t >= 0.5f;\n\tif (v59) goto L_FFFFFFFF;\n\tgoto L_002D;\nL_002D:\n\tv64 = t >= 0.5f;\n\tif (v64) goto L_FFFFFFFF;\n\tgoto L_0033;\nL_0033:\n\tv68 = v18 * v62;\n\tv69 = 0x274A53C(v31, v33, v34, v35, v36, v37, v38, v39, v68, v62, -0.5f, v41, v42, v43, v44, v45);\n\tv70 = v68 * 0x40C90FDB;\n\tv71 = v70 * v30;\n\treturnVal1 = v71 * v67;\n\treturn returnVal1;\n// 46 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float EaseInOutElasticD(float t)
	{
		float num = t + t;
		float num2 = num + -1f;
		float num3 = num2 + -0.075f;
		float num4 = num3 * ((float)global::System.Math.PI * 2f);
		float num5 = num4 / 0.3f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A380");
		float num6 = ((!(t < 0.5f)) ? (-10f) : 10f);
		float num7 = ((!(t < 0.5f)) ? 0.5f : (-0.5f));
		float num8 = num2 * num6;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A53C");
		float num9 = num8 * ((float)global::System.Math.PI * 2f);
		float num10 = num9 * num5;
		return num10 * num7;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000047")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD42A8", Offset = "0xFD42A8", Length = "0x100")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv26 = t - 1f;\n\tv27 = v26 < 0;\n\tv28 = v26 == 0;\n\tv29 = t ^ 1f;\n\tv30 = t ^ v26;\n\tv31 = v29 & v30;\n\tv32 = v31 < 0;\n\tv33 = v27 == v32;\n\tv34 = ~v28;\n\tv35 = v33 & v34;\n\tv36 = ~v35;\n\tif (v36) goto L_FFFFFFFF;\n\tgoto L_0029;\nL_0029:\n\tv50 = t >= 0;\n\tif (v50) goto L_FFFFFFFF;\n\tgoto L_0032;\nL_0032:\n\tv57 = v53 * 0x40490FDB;\n\tv59 = v53 * 2.5f;\n\tv60 = v53 * v59;\n\tv61 = v53 * v60;\n\tv65 = v61 + 0x3E4CCCCD;\n\tv66 = v57 * v65;\n\tv67 = 0x274A170(methodInfo, v69, v70, v71, v72, v73, v74, v75, v66, 0x3E4CCCCD, v76, v77, v78, v79, v80, v81);\n\tv84 = 1f - v53;\n\tv90 = 0x274ACA4(v67, v69, v70, v71, v72, v73, v74, v75, v84, 0x400CCCCD, v76, v77, v78, v79, v80, v81);\n\tv96 = 0x274ACA4(v90, v69, v70, v71, v72, v73, v74, v75, v84, 0x3F99999A, v76, v77, v78, v79, v80, v81);\n\tv99 = v53 * 7.5f;\n\tv100 = v53 * v99;\n\tv101 = v57 * v100;\n\tv102 = 0x274B058(v96, v69, v70, v71, v72, v73, v74, v75, v101, 0x3F99999A, v76, v77, v78, v79, v80, v81);\n\tv103 = v65 * 0x40490FDB;\n\tv104 = v103 * 0x3E4CCCCD;\n\tv105 = v101 * 0x40490FDB;\n\tv106 = v105 + v104;\n\tv107 = v84 * 0x400CCCCD;\n\tv109 = v107 * v66;\n\tv110 = v84 * v106;\n\treturnVal1 = v110 - v109;\n\treturn returnVal1;\n// 64 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static float SpringD(float t)
	{
		//IL_0040: Expected O, but got F4
		//IL_004d: Expected O, but got F4
		float num = t - 1f;
		bool flag = num < 0f;
		bool flag2 = num == 0f;
		object obj = t ^ 1f;
		object obj2 = t ^ num;
		int num2 = (int)((nint)obj & (nint)obj2);
		bool flag3 = num2 < 0;
		bool flag4 = flag == flag3;
		bool flag5 = !flag2;
		float num3 = ((!(flag4 && flag5)) ? t : 1f);
		float num4 = ((!(t < 0f)) ? num3 : 0f);
		float num5 = num4 * (float)global::System.Math.PI;
		float num6 = num4 * 2.5f;
		float num7 = num4 * num6;
		float num8 = num4 * num7;
		float num9 = num8 + 0.2f;
		float num10 = num5 * num9;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A170");
		float num11 = 1f - num4;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274ACA4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274ACA4");
		float num12 = num4 * 7.5f;
		float num13 = num4 * num12;
		float num14 = num5 * num13;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274B058");
		float num15 = num9 * (float)global::System.Math.PI;
		float num16 = num15 * 0.2f;
		float num17 = num14 * (float)global::System.Math.PI;
		float num18 = num17 + num16;
		float num19 = num11 * 2.2f;
		float num20 = num19 * num10;
		float num21 = num11 * num18;
		return num21 - num20;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000048")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD43A8", Offset = "0xFD43A8", Length = "0x678")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0074;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xED8;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv54 = Il2CppMethodInfo;\n\tv55 = v54 + 0xEE8;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv72 = Il2CppMethodInfo;\n\tv73 = v72 + 0xEF8;\n\tv74 = \"il2cpp_codegen_initialize_runtime_metadata\"(v73, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv91 = Il2CppMethodInfo;\n\tv92 = v91 + 0xF08;\n\tv93 = \"il2cpp_codegen_initialize_runtime_metadata\"(v92, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv94 = Il2CppMethodInfo;\n\tv95 = v94 + 0xF18;\n\tv96 = \"il2cpp_codegen_initialize_runtime_metadata\"(v95, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv97 = Il2CppMethodInfo;\n\tv98 = v97 + 0xF28;\n\tv99 = \"il2cpp_codegen_initialize_runtime_metadata\"(v98, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv100 = Il2CppMethodInfo;\n\tv101 = v100 + 0xF38;\n\tv102 = \"il2cpp_codegen_initialize_runtime_metadata\"(v101, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv103 = Il2CppMethodInfo;\n\tv104 = v103 + 0xF48;\n\tv105 = \"il2cpp_codegen_initialize_runtime_metadata\"(v104, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv106 = Il2CppMethodInfo;\n\tv107 = v106 + 0xF58;\n\tv108 = \"il2cpp_codegen_initialize_runtime_metadata\"(v107, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv109 = Il2CppMethodInfo;\n\tv110 = v109 + 0xF68;\n\tv111 = \"il2cpp_codegen_initialize_runtime_metadata\"(v110, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv112 = Il2CppMethodInfo;\n\tv113 = v112 + 0xF78;\n\tv114 = \"il2cpp_codegen_initialize_runtime_metadata\"(v113, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv115 = Il2CppMethodInfo;\n\tv116 = v115 + 0xF88;\n\tv117 = \"il2cpp_codegen_initialize_runtime_metadata\"(v116, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv118 = Il2CppMethodInfo;\n\tv119 = v118 + 0xF98;\n\tv120 = \"il2cpp_codegen_initialize_runtime_metadata\"(v119, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv121 = Il2CppMethodInfo;\n\tv122 = v121 + 0xFA8;\n\tv123 = \"il2cpp_codegen_initialize_runtime_metadata\"(v122, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv124 = Il2CppMethodInfo;\n\tv125 = v124 + 0xFB8;\n\tv126 = \"il2cpp_codegen_initialize_runtime_metadata\"(v125, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv127 = Il2CppMethodInfo;\n\tv128 = v127 + 0xFC8;\n\tv129 = \"il2cpp_codegen_initialize_runtime_metadata\"(v128, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv130 = Il2CppMethodInfo;\n\tv131 = v130 + 0xFD8;\n\tv132 = \"il2cpp_codegen_initialize_runtime_metadata\"(v131, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv133 = Il2CppMethodInfo;\n\tv134 = v133 + 0xFE8;\n\tv135 = \"il2cpp_codegen_initialize_runtime_metadata\"(v134, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv136 = Il2CppMethodInfo;\n\tv137 = v136 + 0xFF8;\n\tv138 = \"il2cpp_codegen_initialize_runtime_metadata\"(v137, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv139 = Il2CppMethodInfo;\n\tv140 = v139 + 8;\n\tv141 = \"il2cpp_codegen_initialize_runtime_metadata\"(v140, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv142 = Il2CppMethodInfo;\n\tv143 = v142 + 0x18;\n\tv144 = \"il2cpp_codegen_initialize_runtime_metadata\"(v143, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv145 = Il2CppMethodInfo;\n\tv146 = v145 + 0x28;\n\tv147 = \"il2cpp_codegen_initialize_runtime_metadata\"(v146, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv148 = Il2CppMethodInfo;\n\tv149 = v148 + 0x38;\n\tv150 = \"il2cpp_codegen_initialize_runtime_metadata\"(v149, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv151 = Il2CppMethodInfo;\n\tv152 = v151 + 0x48;\n\tv153 = \"il2cpp_codegen_initialize_runtime_metadata\"(v152, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv154 = Il2CppMethodInfo;\n\tv155 = v154 + 0x58;\n\tv156 = \"il2cpp_codegen_initialize_runtime_metadata\"(v155, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv157 = Il2CppMethodInfo;\n\tv158 = v157 + 0x68;\n\tv159 = \"il2cpp_codegen_initialize_runtime_metadata\"(v158, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv160 = Il2CppMethodInfo;\n\tv161 = v160 + 0x78;\n\tv162 = \"il2cpp_codegen_initialize_runtime_metadata\"(v161, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv163 = Il2CppMethodInfo;\n\tv164 = v163 + 0x88;\n\tv165 = \"il2cpp_codegen_initialize_runtime_metadata\"(v164, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv166 = Il2CppMethodInfo;\n\tv167 = v166 + 0x98;\n\tv168 = \"il2cpp_codegen_initialize_runtime_metadata\"(v167, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv169 = Il2CppMethodInfo;\n\tv170 = v169 + 0xA8;\n\tv171 = \"il2cpp_codegen_initialize_runtime_metadata\"(v170, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv172 = Il2CppMethodInfo;\n\tv173 = v172 + 0xB8;\n\tv174 = \"il2cpp_codegen_initialize_runtime_metadata\"(v173, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv175 = Il2CppMethodInfo;\n\tv176 = v175 + 0xC8;\n\tv177 = \"il2cpp_codegen_initialize_runtime_metadata\"(v176, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv178 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv179 = v178 + 0x858;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v179, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8CB]) = v42;\nL_0074:\n\tv43 = v39 < 0x1F;\n\tv44 = ~v43;\n\tv45 = v39 - 0x1F;\n\tv47 = v45 == 0;\n\tv52 = ~v47;\n\tv53 = v44 & v52;\n\tif (v53) goto L_0109;\n\tv59 = 0x2875000 + 0x890;\n\tv62 = *([v59 @ X9_v2 (System.Int32)+v39 @ X0_v1 (EasingFunction+Ease)]) << 2;\n\tv63 = 0xFD4580 + v62;\n\t// 135 IndirectJump v63 @ X10_v2 (System.Int32), v39 @ X0_v1 (EasingFunction+Ease), v39 @ X0_v1 (EasingFunction+Ease), methodInfo @ X1 (Il2CppMethodInfo), v25 @ X2, v26 @ X3, v27 @ X4, v28 @ X5, v29 @ X6, v30 @ X7, v31 @ V0, v32 @ V1, v33 @ V2, v34 @ V3, v35 @ V4, v36 @ V5, v37 @ V6, v38 @ V7\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0xFD8;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0x78;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0xF98;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0xF08;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0x48;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0x88;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0xFF8;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0xFB8;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\n// ... truncated")]
	public static EasingFunction.Function GetEasingFunction(EasingFunction.Ease easingFunction)
	{
		EasingFunction.Ease ease = default(EasingFunction.Ease);
		bool flag = ease < EasingFunction.Ease.EaseInOutElastic;
		bool flag2 = !flag;
		int num = (int)(ease - 31);
		bool flag3 = num == 0;
		bool flag4 = !flag3;
		if (!(flag2 && flag4))
		{
			int num2 = 42422272 + 2192;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X9_v2 (System.Int32)+v39 @ X0_v1 (EasingFunction+Ease)]");
			int num3 = (int)((nint)0 << 2);
			int num4 = 16598400 + num3;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v63 @ X10_v2 (System.Int32) (should have been resolved before IL gen)");
		}
		return null;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000049")]
	[global::Cpp2ILInjected.Address(RVA = "0xFD4AC4", Offset = "0xFD4AC4", Length = "0x678")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0074;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xEE0;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv54 = Il2CppMethodInfo;\n\tv55 = v54 + 0xEF0;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv72 = Il2CppMethodInfo;\n\tv73 = v72 + 0xF00;\n\tv74 = \"il2cpp_codegen_initialize_runtime_metadata\"(v73, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv91 = Il2CppMethodInfo;\n\tv92 = v91 + 0xF10;\n\tv93 = \"il2cpp_codegen_initialize_runtime_metadata\"(v92, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv94 = Il2CppMethodInfo;\n\tv95 = v94 + 0xF20;\n\tv96 = \"il2cpp_codegen_initialize_runtime_metadata\"(v95, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv97 = Il2CppMethodInfo;\n\tv98 = v97 + 0xF30;\n\tv99 = \"il2cpp_codegen_initialize_runtime_metadata\"(v98, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv100 = Il2CppMethodInfo;\n\tv101 = v100 + 0xF40;\n\tv102 = \"il2cpp_codegen_initialize_runtime_metadata\"(v101, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv103 = Il2CppMethodInfo;\n\tv104 = v103 + 0xF50;\n\tv105 = \"il2cpp_codegen_initialize_runtime_metadata\"(v104, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv106 = Il2CppMethodInfo;\n\tv107 = v106 + 0xF60;\n\tv108 = \"il2cpp_codegen_initialize_runtime_metadata\"(v107, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv109 = Il2CppMethodInfo;\n\tv110 = v109 + 0xF70;\n\tv111 = \"il2cpp_codegen_initialize_runtime_metadata\"(v110, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv112 = Il2CppMethodInfo;\n\tv113 = v112 + 0xF80;\n\tv114 = \"il2cpp_codegen_initialize_runtime_metadata\"(v113, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv115 = Il2CppMethodInfo;\n\tv116 = v115 + 0xF90;\n\tv117 = \"il2cpp_codegen_initialize_runtime_metadata\"(v116, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv118 = Il2CppMethodInfo;\n\tv119 = v118 + 0xFA0;\n\tv120 = \"il2cpp_codegen_initialize_runtime_metadata\"(v119, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv121 = Il2CppMethodInfo;\n\tv122 = v121 + 0xFB0;\n\tv123 = \"il2cpp_codegen_initialize_runtime_metadata\"(v122, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv124 = Il2CppMethodInfo;\n\tv125 = v124 + 0xFC0;\n\tv126 = \"il2cpp_codegen_initialize_runtime_metadata\"(v125, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv127 = Il2CppMethodInfo;\n\tv128 = v127 + 0xFD0;\n\tv129 = \"il2cpp_codegen_initialize_runtime_metadata\"(v128, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv130 = Il2CppMethodInfo;\n\tv131 = v130 + 0xFE0;\n\tv132 = \"il2cpp_codegen_initialize_runtime_metadata\"(v131, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv133 = Il2CppMethodInfo;\n\tv134 = v133 + 0xFF0;\n\tv135 = \"il2cpp_codegen_initialize_runtime_metadata\"(v134, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv136 = Il2CppMethodInfo;\n\tv137 = v136 + 0;\n\tv138 = \"il2cpp_codegen_initialize_runtime_metadata\"(v137, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv139 = Il2CppMethodInfo;\n\tv140 = v139 + 0x10;\n\tv141 = \"il2cpp_codegen_initialize_runtime_metadata\"(v140, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv142 = Il2CppMethodInfo;\n\tv143 = v142 + 0x20;\n\tv144 = \"il2cpp_codegen_initialize_runtime_metadata\"(v143, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv145 = Il2CppMethodInfo;\n\tv146 = v145 + 0x30;\n\tv147 = \"il2cpp_codegen_initialize_runtime_metadata\"(v146, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv148 = Il2CppMethodInfo;\n\tv149 = v148 + 0x40;\n\tv150 = \"il2cpp_codegen_initialize_runtime_metadata\"(v149, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv151 = Il2CppMethodInfo;\n\tv152 = v151 + 0x50;\n\tv153 = \"il2cpp_codegen_initialize_runtime_metadata\"(v152, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv154 = Il2CppMethodInfo;\n\tv155 = v154 + 0x60;\n\tv156 = \"il2cpp_codegen_initialize_runtime_metadata\"(v155, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv157 = Il2CppMethodInfo;\n\tv158 = v157 + 0x70;\n\tv159 = \"il2cpp_codegen_initialize_runtime_metadata\"(v158, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv160 = Il2CppMethodInfo;\n\tv161 = v160 + 0x80;\n\tv162 = \"il2cpp_codegen_initialize_runtime_metadata\"(v161, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv163 = Il2CppMethodInfo;\n\tv164 = v163 + 0x90;\n\tv165 = \"il2cpp_codegen_initialize_runtime_metadata\"(v164, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv166 = Il2CppMethodInfo;\n\tv167 = v166 + 0xA0;\n\tv168 = \"il2cpp_codegen_initialize_runtime_metadata\"(v167, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv169 = Il2CppMethodInfo;\n\tv170 = v169 + 0xB0;\n\tv171 = \"il2cpp_codegen_initialize_runtime_metadata\"(v170, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv172 = Il2CppMethodInfo;\n\tv173 = v172 + 0xC0;\n\tv174 = \"il2cpp_codegen_initialize_runtime_metadata\"(v173, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv175 = Il2CppMethodInfo;\n\tv176 = v175 + 0xD0;\n\tv177 = \"il2cpp_codegen_initialize_runtime_metadata\"(v176, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv178 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv179 = v178 + 0x858;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v179, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A8CC]) = v42;\nL_0074:\n\tv43 = v39 < 0x1F;\n\tv44 = ~v43;\n\tv45 = v39 - 0x1F;\n\tv47 = v45 == 0;\n\tv52 = ~v47;\n\tv53 = v44 & v52;\n\tif (v53) goto L_0109;\n\tv59 = 0x2875000 + 0x8B0;\n\tv62 = *([v59 @ X9_v2 (System.Int32)+v39 @ X0_v1 (EasingFunction+Ease)]) << 2;\n\tv63 = 0xFD4C9C + v62;\n\t// 135 IndirectJump v63 @ X10_v2 (System.Int32), v39 @ X0_v1 (EasingFunction+Ease), v39 @ X0_v1 (EasingFunction+Ease), methodInfo @ X1 (Il2CppMethodInfo), v25 @ X2, v26 @ X3, v27 @ X4, v28 @ X5, v29 @ X6, v30 @ X7, v31 @ V0, v32 @ V1, v33 @ V2, v34 @ V3, v35 @ V4, v36 @ V5, v37 @ V6, v38 @ V7\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0xFE0;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0x80;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0xFA0;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0xF10;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0x50;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0x90;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 = *([X8]);\n\tX0 = 0xF3F48C(X0, X1, X2, X3, X4, X5, X6, X7, V0, V1, V2, V3, V4, V5, V6, V7);\n\tX19 = X0;\n\tX8 = X8 + 0xFC0;\n\tgoto L_0191;\n\tX8 = X8 + 0x858;\n\tX0 =\n// ... truncated")]
	public static EasingFunction.Function GetEasingFunctionDerivative(EasingFunction.Ease easingFunction)
	{
		EasingFunction.Ease ease = default(EasingFunction.Ease);
		bool flag = ease < EasingFunction.Ease.EaseInOutElastic;
		bool flag2 = !flag;
		int num = (int)(ease - 31);
		bool flag3 = num == 0;
		bool flag4 = !flag3;
		if (!(flag2 && flag4))
		{
			int num2 = 42422272 + 2224;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v59 @ X9_v2 (System.Int32)+v39 @ X0_v1 (EasingFunction+Ease)]");
			int num3 = (int)((nint)0 << 2);
			int num4 = 16600220 + num3;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v63 @ X10_v2 (System.Int32) (should have been resolved before IL gen)");
		}
		return null;
	}
}
