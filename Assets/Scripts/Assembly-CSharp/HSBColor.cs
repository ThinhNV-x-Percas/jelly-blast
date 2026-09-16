[global::System.Serializable]
[global::Cpp2ILInjected.Token(Token = "0x20000B0")]
public struct HSBColor
{
	[global::Cpp2ILInjected.Token(Token = "0x40003E3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public float h;

	[global::Cpp2ILInjected.Token(Token = "0x40003E4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
	public float s;

	[global::Cpp2ILInjected.Token(Token = "0x40003E5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
	public float b;

	[global::Cpp2ILInjected.Token(Token = "0x40003E6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
	public float a;

	[global::Cpp2ILInjected.Token(Token = "0x600031B")]
	[global::Cpp2ILInjected.Address(RVA = "0x100DA54", Offset = "0x100DA54", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.h = h;\n\tthis.s = s;\n\tthis.b = b;\n\tthis.a = a;\n\treturn;\n")]
	public HSBColor(float h, float s, float b, float a)
	{
		this.h = h;
		this.s = s;
		this.b = b;
		this.a = a;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600031C")]
	[global::Cpp2ILInjected.Address(RVA = "0x100DA60", Offset = "0x100DA60", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.h = h;\n\tthis.s = s;\n\tthis.b = b;\n\tthis.a = 1f;\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public HSBColor(float h, float s, float b)
	{
		this.h = h;
		this.s = s;
		this.b = b;
		a = 1f;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600031D")]
	[global::Cpp2ILInjected.Address(RVA = "0x100DA74", Offset = "0x100DA74", Length = "0xF0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv6 = col.g - col.b;\n\tv7 = v6 < 0;\n\tv8 = v6 == 0;\n\tv9 = col.g ^ col.b;\n\tv10 = col.g ^ v6;\n\tv11 = v9 & v10;\n\tv12 = v11 < 0;\n\tv13 = v7 == v12;\n\tv14 = ~v8;\n\tv15 = v13 & v14;\n\tv16 = ~v15;\n\tif (v16) goto L_FFFFFFFF;\n\tgoto L_0017;\nL_0017:\n\tv22 = col - v35;\n\tv23 = v22 < 0;\n\tv24 = v22 == 0;\n\tv25 = col ^ v35;\n\tv26 = col ^ v22;\n\tv27 = v25 & v26;\n\tv28 = v27 < 0;\n\tv29 = v23 == v28;\n\tv30 = ~v24;\n\tv31 = v29 & v30;\n\tv32 = ~v31;\n\tif (v32) goto L_0028;\n\tgoto L_0028;\nL_0028:\n\tv37 = v35 < 0;\n\tv38 = ~v37;\n\tv41 = v35 == 0;\n\tv48 = ~v38;\n\tv49 = v48 | v41;\n\tif (v49) goto L_00BE;\n\tv59 = col.g >= col.b;\n\tif (v59) goto L_FFFFFFFF;\n\tgoto L_004E;\nL_004E:\n\tv109 = col >= v99;\n\tif (v109) goto L_FFFFFFFF;\n\tgoto L_0054;\nL_0054:\n\tv113 = v35 - v112;\n\tv125 = v35 <= v112;\n\tif (v125) goto L_00BB;\n\tv126 = col.g - col.b;\n\tv127 = v126 / v113;\n\tv152 = v127 * 0x42700000;\n\tv133 = col.g - col.b;\n\tv134 = v133 < 0;\n\tv142 = v152 + 0x43B40000;\n\tv143 = ~v134;\n\tv144 = ~v143;\n\tif (v144) goto L_FFFFFFFF;\n\tgoto L_007A;\nL_007A:\n\tv172 = col - col.g;\n\tv173 = v172 / v113;\n\tv176 = v173 * 0x42700000;\n\tv156 = v176 + 0x43700000;\n\tv180 = col.b - v35;\n\tv182 = v180 == 0;\n\tv187 = ~v182;\n\tv188 = ~v187;\n\tif (v188) goto L_FFFFFFFF;\n\tgoto L_0092;\nL_0092:\n\tv192 = col.b - col;\n\tv193 = v192 / v113;\n\tv196 = v193 * 0x42700000;\n\tv148 = v196 + 0x42F00000;\n\tv199 = col.g - v35;\n\tv201 = v199 == 0;\n\tv206 = ~v201;\n\tv157 = ~v206;\n\tif (v157) goto L_FFFFFFFF;\n\tgoto L_00B3;\nL_00B3:\n\tv158 = v152 >= 0;\n\tif (v158) goto L_00BB;\n\tv152 = v152 + 0x43B40000;\nL_00BB:\n\tv68 = v152 * 0x3B360B61;\n\tv72 = v113 / v35;\nL_00BE:\n\tthis.h = v68;\n\tthis.s = v72;\n\tthis.b = v70;\n\tthis.a = col.a;\n\treturn;\n// 114 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public HSBColor(global::UnityEngine.Color col)
	{
		//IL_0052: Expected O, but got F4
		//IL_0064: Expected O, but got F4
		//IL_027f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_028c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0291: Expected O, but got Unknown
		//IL_015b: Expected O, but got F4
		float num = col.g - col.b;
		bool flag4 = num > 0f;
		float num3 = (!flag4) ? col.b : col.g;
		float num4 = col.r - num3;
		bool flag9 = num4 > 0f;
		if (flag9)
		{
			num3 = col.r;
		}
		bool flag15 = num3 <= 0f;
		float num6 = 0f;
		float num7 = 0f;
		float num8 = 0f;
		if (!flag15)
		{
			float num9 = ((!(col.g < col.b)) ? col.b : col.g);
			float num9b = ((!(col.r < num9)) ? num9 : col.r);
			float num10 = num3 - num9b;
			bool flag16 = !(num3 > num9b);
			float num11 = 0f;
			if (!flag16)
			{
				float num12 = col.g - col.b;
				float num13 = num12 / num10;
				num11 = num13 * 60f;
				float num14 = col.g - col.b;
				bool flag17 = num14 < 0f;
				float num15 = num11 + 360f;
				if (flag17)
				{
					num11 = num15;
				}
				float num16 = col.r - col.g;
				float num17 = num16 / num10;
				float num18 = num17 * 60f;
				float num19 = num18 + 240f;
				float num20 = col.b - num3;
				if (num20 == 0f)
				{
					num11 = num19;
				}
				float num21 = col.b - col.r;
				float num22 = num21 / num10;
				float num23 = num22 * 60f;
				float num24 = num23 + 120f;
				float num25 = col.g - num3;
				if (num25 == 0f)
				{
					num11 = num24;
				}
				if (num11 < 0f)
				{
					num11 += 360f;
				}
			}
			num6 = num11 * 0.0027777778f;
			num8 = num10 / num3;
			num7 = num3;
		}
		h = num6;
		s = num8;
		b = num7;
		a = col.a;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600031E")]
	[global::Cpp2ILInjected.Address(RVA = "0x100DB64", Offset = "0x100DB64", Length = "0xF8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv6 = color.g - color.b;\n\tv7 = v6 < 0;\n\tv8 = v6 == 0;\n\tv9 = color.g ^ color.b;\n\tv10 = color.g ^ v6;\n\tv11 = v9 & v10;\n\tv12 = v11 < 0;\n\tv13 = v7 == v12;\n\tv14 = ~v8;\n\tv15 = v13 & v14;\n\tv16 = ~v15;\n\tif (v16) goto L_FFFFFFFF;\n\tgoto L_0017;\nL_0017:\n\tv22 = color - v19;\n\tv23 = v22 < 0;\n\tv24 = v22 == 0;\n\tv25 = color ^ v19;\n\tv26 = color ^ v22;\n\tv27 = v25 & v26;\n\tv28 = v27 < 0;\n\tv29 = v23 == v28;\n\tv30 = ~v24;\n\tv31 = v29 & v30;\n\tv32 = ~v31;\n\tif (v32) goto L_FFFFFFFF;\n\tgoto L_0028;\nL_0028:\n\tv37 = v35 < 0;\n\tv38 = ~v37;\n\tv41 = v35 == 0;\n\tv48 = ~v38;\n\tv49 = v48 | v41;\n\tif (v49) goto L_00C2;\n\tv59 = color.g >= color.b;\n\tif (v59) goto L_FFFFFFFF;\n\tgoto L_004E;\nL_004E:\n\tv111 = color >= v101;\n\tif (v111) goto L_FFFFFFFF;\n\tgoto L_0054;\nL_0054:\n\tv115 = v35 - v114;\n\tv128 = v35 <= v114;\n\tif (v128) goto L_00BC;\n\tv129 = color.g - color.b;\n\tv130 = v129 / v115;\n\tv157 = v130 * 0x42700000;\n\tv136 = color.g - color.b;\n\tv137 = v136 < 0;\n\tv145 = v157 + 0x43B40000;\n\tv146 = ~v137;\n\tv147 = ~v146;\n\tif (v147) goto L_FFFFFFFF;\n\tgoto L_007B;\nL_007B:\n\tv175 = color - color.g;\n\tv176 = v175 / v115;\n\tv179 = v176 * 0x42700000;\n\tv156 = v179 + 0x43700000;\n\tv183 = color.b - v35;\n\tv185 = v183 == 0;\n\tv190 = ~v185;\n\tv191 = ~v190;\n\tif (v191) goto L_FFFFFFFF;\n\tgoto L_0093;\nL_0093:\n\tv195 = color.b - color;\n\tv196 = v195 / v115;\n\tv199 = v196 * 0x42700000;\n\tv151 = v199 + 0x42F00000;\n\tv202 = color.g - v35;\n\tv204 = v202 == 0;\n\tv209 = ~v204;\n\tv160 = ~v209;\n\tif (v160) goto L_FFFFFFFF;\n\tgoto L_00B4;\nL_00B4:\n\tv161 = v157 >= 0;\n\tif (v161) goto L_00BC;\n\tv157 = v157 + 0x43B40000;\nL_00BC:\n\tv73 = v157 * 0x3B360B61;\nL_00C2:\n\treturn v72;\n// 119 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static HSBColor FromColor(global::UnityEngine.Color color)
	{
		//IL_0052: Expected O, but got F4
		//IL_0064: Expected O, but got F4
		//IL_0287: Unknown result type (might be due to invalid IL or missing references)
		//IL_028c: Expected O, but got Unknown
		//IL_0294: Unknown result type (might be due to invalid IL or missing references)
		//IL_0299: Expected O, but got Unknown
		//IL_00fa: Expected O, but got F4
		//IL_0163: Expected O, but got F4
		//IL_0384: Expected O, but got I
		//IL_050d: Expected O, but got F4
		float num = color.g - color.b;
		bool flag4 = num > 0f;
		float num3 = (!flag4) ? color.b : color.g;
		float num4 = color.r - num3;
		bool flag9 = num4 > 0f;
		float obj5 = flag9 ? color.r : num3;
		bool flag15 = obj5 <= 0f;
		HSBColor result = default(HSBColor);
		if (flag15)
		{
			return result;
		}
		float num6 = ((!(color.g < color.b)) ? color.b : color.g);
		float obj6 = ((!(color.r < num6)) ? num6 : color.r);
		float obj7 = obj5 - obj6;
		bool flag16 = obj5 <= obj6;
		float num7 = 0f;
		if (!flag16)
		{
			float num8 = color.g - color.b;
			float num9 = num8 / obj7;
			num7 = num9 * 60f;
			float num10 = color.g - color.b;
			bool flag17 = num10 < 0f;
			float num11 = num7 + 360f;
			if (flag17)
			{
				num7 = num11;
			}
			float num12 = color.r - color.g;
			float num13 = num12 / obj7;
			float num14 = num13 * 60f;
			float num15 = num14 + 240f;
			float num16 = color.b - obj5;
			if (num16 == 0f)
			{
				num7 = num15;
			}
			float num17 = color.b - color.r;
			float num18 = num17 / obj7;
			float num19 = num18 * 60f;
			float num20 = num19 + 120f;
			float num21 = color.g - obj5;
			if (num21 == 0f)
			{
				num7 = num20;
			}
			if (num7 < 0f)
			{
				num7 += 360f;
			}
		}
		float num22 = num7 * 0.0027777778f;
		return new HSBColor(num22, obj7 / obj5, obj5, color.a);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600031F")]
	[global::Cpp2ILInjected.Address(RVA = "0x100DC5C", Offset = "0x100DC5C", Length = "0x1C0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv13 = hsbColor.s != 0;\n\tif (v13) goto L_0011;\n\tgoto L_FFFFFFFF;\nL_0011:\n\tv16 = hsbColor.b * hsbColor.s;\n\tv17 = hsbColor.b - v16;\n\tv20 = hsbColor * 0x43B40000;\n\tv32 = v20 >= 0x42700000;\n\tif (v32) goto L_009A;\n\tv72 = v20 * v16;\n\tv37 = v72 / 0x42700000;\n\tv106 = v17 + v37;\nL_002C:\n\tv158 = v85 - 1f;\n\tv159 = v158 < 0;\n\tv160 = v158 == 0;\n\tv161 = v85 ^ 1f;\n\tv162 = v85 ^ v158;\n\tv163 = v161 & v162;\n\tv164 = v163 < 0;\n\tv165 = v159 == v164;\n\tv166 = ~v160;\n\tv167 = v165 & v166;\n\tv168 = ~v167;\n\tif (v168) goto L_FFFFFFFF;\n\tgoto L_0046;\nL_0046:\n\tv196 = v85 >= 0;\n\tif (v196) goto L_FFFFFFFF;\n\tgoto L_004E;\nL_004E:\n\tv216 = v106 - 1f;\n\tv217 = v216 < 0;\n\tv218 = v216 == 0;\n\tv219 = v106 ^ 1f;\n\tv220 = v106 ^ v216;\n\tv221 = v219 & v220;\n\tv222 = v221 < 0;\n\tv223 = v217 == v222;\n\tv224 = ~v218;\n\tv225 = v223 & v224;\n\tv226 = ~v225;\n\tif (v226) goto L_0067;\n\tgoto L_0067;\nL_0067:\n\tv243 = v106 >= 0;\n\tif (v243) goto L_006F;\n\tgoto L_006F;\nL_006F:\n\tv249 = v112 - 1f;\n\tv250 = v249 < 0;\n\tv251 = v249 == 0;\n\tv252 = v112 ^ 1f;\n\tv253 = v112 ^ v249;\n\tv254 = v252 & v253;\n\tv255 = v254 < 0;\n\tv256 = v250 == v255;\n\tv257 = ~v251;\n\tv258 = v256 & v257;\n\tv259 = ~v258;\n\tif (v259) goto L_0088;\n\tgoto L_0088;\nL_0088:\n\tv272 = v112 >= 0;\n\tif (v272) goto L_008E;\n\tgoto L_008E;\nL_008E:\n\treturn returnVal1;\nL_009A:\n\tv84 = v20 >= 0x42F00000;\n\tif (v84) goto L_00B2;\n\tv171 = v20 + 0xC2F00000;\n\tv172 = v16 * v171;\n\tv91 = v172 / 0xC2700000;\n\tv85 = v17 + v91;\n\tgoto L_002C;\nL_00B2:\n\tv119 = v20 >= 0x43340000;\n\tif (v119) goto L_00CA;\n\tv180 = v20 + 0xC2F00000;\n\tv181 = v16 * v180;\n\tv92 = v181 / 0x42700000;\n\tv112 = v17 + v92;\n\tgoto L_002C;\nL_00CA:\n\tv120 = v20 >= 0x43700000;\n\tif (v120) goto L_00E2;\n\tv199 = v20 + 0xC3700000;\n\tv200 = v16 * v199;\n\tv93 = v200 / 0xC2700000;\n\tv106 = v17 + v93;\n\tgoto L_002C;\nL_00E2:\n\tv121 = v20 >= 0x43960000;\n\tif (v121) goto L_00F2;\n\tv208 = v20 + 0xC3700000;\n\tv209 = v16 * v208;\n\tv94 = v209 / 0x42700000;\n\tv85 = v17 + v94;\n\tgoto L_002C;\nL_00F2:\n\tv211 = v20 < 0x43B40000;\n\tv69 = ~v211;\n\tv67 = v20 - 0x43B40000;\n\tv63 = v67 == 0;\n\tv212 = ~v63;\n\tv53 = v69 & v212;\n\tif (v53) goto L_002C;\n\tv229 = v20 + 0xC3B40000;\n\tv230 = v16 * v229;\n\tv38 = v230 / 0xC2700000;\n\tv112 = v17 + v38;\n\tgoto L_FFFFFFFF;\n\treturn V0;\n// 166 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static global::UnityEngine.Color ToColor(HSBColor hsbColor)
	{
		//IL_05f2: Expected O, but got F4
		//IL_05ff: Expected O, but got F4
		//IL_0117: Expected O, but got F4
		//IL_0455: Expected O, but got F4
		//IL_0462: Expected O, but got F4
		//IL_0521: Expected O, but got F4
		//IL_052e: Expected O, but got F4
		float num;
		float num2;
		float num9;
		if (hsbColor.s == 0f)
		{
			num = hsbColor.b;
			num2 = hsbColor.b;
		}
		else
		{
			float num3 = hsbColor.b * hsbColor.s;
			float num4 = hsbColor.b - num3;
			float num5 = hsbColor.h * 360f;
			if (!(num5 < 60f))
			{
				if (num5 < 120f)
				{
					float num6 = num5 + -120f;
					float num7 = num3 * num6;
					float num8 = num7 / -60f;
					num9 = num4 + num8;
					num = hsbColor.b;
					num2 = num4;
				}
				else if (num5 < 180f)
				{
					float num10 = num5 + -120f;
					float num11 = num3 * num10;
					float num12 = num11 / 60f;
					num2 = num4 + num12;
					num9 = num4;
					num = hsbColor.b;
				}
				else if (num5 < 240f)
				{
					float num13 = num5 + -240f;
					float num14 = num3 * num13;
					float num15 = num14 / -60f;
					num = num4 + num15;
					num9 = num4;
					num2 = hsbColor.b;
				}
				else if (num5 < 300f)
				{
					float num16 = num5 + -240f;
					float num17 = num3 * num16;
					float num18 = num17 / 60f;
					num9 = num4 + num18;
					num = num4;
					num2 = hsbColor.b;
				}
				else
				{
					bool flag = num5 < 360f;
					bool flag2 = !flag;
					float num19 = num5 - 360f;
					bool flag3 = num19 == 0f;
					bool flag4 = !flag3;
					bool flag5 = flag2 && flag4;
					num9 = 0f;
					num = 0f;
					num2 = 0f;
					if (!flag5)
					{
						float num20 = num5 + -360f;
						float num21 = num3 * num20;
						float num22 = num21 / -60f;
						num2 = num4 + num22;
						num = num4;
						goto IL_03e1;
					}
				}
				goto IL_05b2;
			}
			float num23 = num5 * num3;
			float num24 = num23 / 60f;
			num = num4 + num24;
			num2 = num4;
		}
		goto IL_03e1;
		IL_05b2:
		float r = global::UnityEngine.Mathf.Clamp01(num9);
		float g = global::UnityEngine.Mathf.Clamp01(num);
		float b2 = global::UnityEngine.Mathf.Clamp01(num2);
		global::UnityEngine.Color result = new global::UnityEngine.Color(r, g, b2, hsbColor.a);
		return result;
		IL_03e1:
		num9 = hsbColor.b;
		goto IL_05b2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000320")]
	[global::Cpp2ILInjected.Address(RVA = "0x100DE1C", Offset = "0x100DE1C", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\t// 4 MakeStruct v5 @ AGG100DE24_0_v1 (HSBColor), typeof(HSBColor), this.h (System.Single), this.s (System.Single), this.b (System.Single), this.a (System.Single)\n\treturnVal1 = HSBColor::ToColor(v5);\n\treturn returnVal1;\n// 7 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public global::UnityEngine.Color ToColor()
	{
		HSBColor hsbColor = default(HSBColor);
		hsbColor.h = h;
		hsbColor.s = s;
		hsbColor.b = b;
		hsbColor.a = a;
		return ToColor(hsbColor);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000321")]
	[global::Cpp2ILInjected.Address(RVA = "0x100DE28", Offset = "0x100DE28", Length = "0x188")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = CollectParticleData[];\n\tgoto L_0021;\n\tv23 = CollectParticleData[];\n\tv24 = v23 + 0x540;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv48 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv49 = v48 + 0xCD8;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v49, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv52 = Il2CppFieldInfo;\n\tv53 = v52 + 0xE88;\n\tv54 = \"il2cpp_codegen_initialize_runtime_metadata\"(v53, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv97 = Il2CppFieldInfo;\n\tv98 = v97 + 0xDB0;\n\tv42 = \"il2cpp_codegen_initialize_runtime_metadata\"(v98, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = 1;\n\t*([302AA59]) = v44;\nL_0021:\n\tv47 = \"SzArrayNew\"(*([v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+540]), 6, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv99 = \"Expected ComplexType. Schema was not generated using this tool.\";\n\tv103 = v47 + 0x20;\n\tv47[0] = *([v99 @ X8_v6 (System.String)+CD8]);\n\tv105 = 0xF3F1B4(v103, *([v99 @ X8_v6 (System.String)+CD8]), v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv147 = System.Single::ToString(this);\n\tv154 = v47 + 0x28;\n\tv47[1] = v147;\n\tv148 = 0xF3F1B4(v154, v147, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv195 = Il2CppFieldInfo;\n\tv155 = v47 + 0x30;\n\tv47[2] = *([v195 @ X8_v10 (Il2CppFieldInfo)+E88]);\n\tv200 = 0xF3F1B4(v155, *([v195 @ X8_v10 (Il2CppFieldInfo)+E88]), v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv201 = this + 4;\n\tv149 = System.Single::ToString(v201);\n\tv156 = v47 + 0x38;\n\tv47[3] = v149;\n\tv150 = 0xF3F1B4(v156, v149, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv206 = Il2CppFieldInfo;\n\tv157 = v47 + 0x40;\n\tv47[4] = *([v206 @ X8_v14 (Il2CppFieldInfo)+DB0]);\n\tv211 = 0xF3F1B4(v157, *([v206 @ X8_v14 (Il2CppFieldInfo)+DB0]), v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv212 = this + 8;\n\tv151 = System.Single::ToString(v212);\n\tv217 = v47 + 0x48;\n\tv47[5] = v151;\n\tv218 = 0xF3F1B4(v217, v151, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturnVal2 = System.String::Concat(v47);\n\treturn returnVal2;\n\tv88 = new System.IndexOutOfRangeException();\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 109 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe override string ToString()
	{
		//IL_000e: Expected I, but got O
		//IL_002b: Expected O, but got I
		//IL_0045: Expected O, but got I
		//IL_006d: Expected O, but got I
		//IL_00a3: Expected O, but got I
		//IL_00bd: Expected O, but got I
		//IL_00e5: Expected Ref, but got F4
		//IL_00fd: Expected O, but got I
		//IL_0133: Expected O, but got I
		//IL_014d: Expected O, but got I
		//IL_0175: Expected Ref, but got F4
		//IL_018d: Expected O, but got I
		string[] array = new string[6];
		array[0] = "H:";
		array[1] = h.ToString();
		array[2] = " S:";
		array[3] = s.ToString();
		array[4] = " B:";
		array[5] = b.ToString();
		return string.Concat(array);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000322")]
	[global::Cpp2ILInjected.Address(RVA = "0x100DFB0", Offset = "0x100DFB0", Length = "0x15C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv15 = a.b == 0;\n\tif (v15) goto L_0101;\n\tv30 = b.b != 0;\n\tif (v30) goto L_0025;\n\tgoto L_0101;\nL_0025:\n\tv96 = a.s == 0;\n\tif (v96) goto L_00DB;\n\tv107 = b.s == 0;\n\tif (v107) goto L_00DB;\n\tv143 = a * 0x43B40000;\n\tv170 = b * 0x43B40000;\n\tv171 = v170 - v143;\n\tv172 = v171 / 0x43B40000;\n\tv173 = UnityEngine.Mathf::Floor(v172);\n\tv180 = v173 * 0xC3B40000;\n\tv181 = v171 + v180;\n\tv184 = v181 - 0x43B40000;\n\tv185 = v184 < 0;\n\tv186 = v184 == 0;\n\tv187 = v181 ^ 0x43B40000;\n\tv188 = v181 ^ v184;\n\tv189 = v187 & v188;\n\tv190 = v189 < 0;\n\tv191 = v185 == v190;\n\tv192 = ~v186;\n\tv193 = v191 & v192;\n\tv194 = ~v193;\n\tif (v194) goto L_FFFFFFFF;\n\tgoto L_005D;\nL_005D:\n\tv220 = v181 >= 0;\n\tif (v220) goto L_0063;\n\tgoto L_0063;\nL_0063:\n\tv226 = v243 + 0xC3B40000;\n\tv230 = v243 - 0x43340000;\n\tv231 = v230 < 0;\n\tv232 = v230 == 0;\n\tv233 = v243 ^ 0x43340000;\n\tv234 = v243 ^ v230;\n\tv235 = v233 & v234;\n\tv236 = v235 < 0;\n\tv237 = v231 == v236;\n\tv238 = ~v232;\n\tv239 = v237 & v238;\n\tv240 = ~v239;\n\tif (v240) goto L_007B;\n\tgoto L_007B;\nL_007B:\n\tv247 = t - 1f;\n\tv248 = v247 < 0;\n\tv249 = v247 == 0;\n\tv250 = t ^ 1f;\n\tv251 = t ^ v247;\n\tv252 = v250 & v251;\n\tv253 = v252 < 0;\n\tv254 = v248 == v253;\n\tv255 = ~v249;\n\tv256 = v254 & v255;\n\tv257 = ~v256;\n\tif (v257) goto L_FFFFFFFF;\n\tgoto L_0094;\nL_0094:\n\tv115 = t >= 0;\n\tif (v115) goto L_FFFFFFFF;\n\tgoto L_009A;\nL_009A:\n\tv272 = v271 * v243;\n\tv346 = v143 + v272;\n\tv283 = v346 >= 0;\n\tif (v283) goto L_00C1;\nL_00A9:\n\tv346 = v321 + 0x43B40000;\n\tv301 = v346 < 0;\n\tif (v301) goto L_00A9;\nL_00C1:\n\tv319 = v346 <= 0x43B40000;\n\tif (v319) goto L_00D7;\nL_00C6:\n\tv346 = v359 + 0xC3B40000;\n\tv345 = v346 > 0x43B40000;\n\tif (v345) goto L_00C6;\nL_00D7:\n\tv125 = v346 / 0x43B40000;\nL_00DB:\n\tv147 = t - 1f;\n\tv148 = v147 < 0;\n\tv149 = v147 == 0;\n\tv150 = t ^ 1f;\n\tv151 = t ^ v147;\n\tv152 = v150 & v151;\n\tv153 = v152 < 0;\n\tv154 = v148 == v153;\n\tv38 = ~v149;\n\tv52 = v154 & v38;\n\tv155 = ~v52;\n\tif (v155) goto L_00F5;\n\tgoto L_00F5;\nL_00F5:\n\tv35 = t >= 0;\n\tif (v35) goto L_0101;\n\tgoto L_0101;\nL_0101:\n\tv81 = t - 1f;\n\tv82 = v81 < 0;\n\tv83 = v81 == 0;\n\tv84 = t ^ 1f;\n\tv85 = t ^ v81;\n\tv86 = v84 & v85;\n\tv87 = v86 < 0;\n\tv88 = v82 == v87;\n\tv89 = ~v83;\n\tv90 = v88 & v89;\n\tv91 = ~v90;\n\tif (v91) goto L_011B;\n\tgoto L_011B;\nL_011B:\n\tv167 = t >= 0;\n\tif (v167) goto L_0128;\n\tgoto L_0128;\nL_0128:\n\treturn returnVal1;\n// 189 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static HSBColor Lerp(HSBColor a, HSBColor b, float t)
	{
		//IL_0300: Expected O, but got F4
		//IL_030d: Expected O, but got F4
		//IL_03aa: Expected O, but got F4
		//IL_03b7: Expected O, but got F4
		//IL_0168: Unknown result type (might be due to invalid IL or missing references)
		//IL_016d: Expected O, but got Unknown
		//IL_017a: Expected O, but got F4
		//IL_0481: Unknown result type (might be due to invalid IL or missing references)
		//IL_0486: Expected I4, but got Unknown
		//IL_0493: Expected O, but got F4
		//IL_052f: Expected O, but got F4
		//IL_053c: Expected O, but got F4
		//IL_02a7: Expected O, but got F4
		//IL_024b: Expected O, but got F4
		//IL_0282: Expected O, but got F4
		//IL_0624: Expected O, but got F4
		//IL_065b: Expected O, but got F4
		bool flag = a.b == 0f;
		HSBColor result = b;
		if (!flag)
		{
			if (b.b == 0f)
			{
				result = a;
			}
			else
			{
				bool flag2 = a.s == 0f;
				result = b;
				if (!flag2)
				{
					bool flag3 = b.s == 0f;
					result = a;
					if (!flag3)
					{
						float num = a.h * 360f;
						float num2 = b.h * 360f;
						float num3 = num2 - num;
						float f = num3 / 360f;
						float num4 = global::UnityEngine.Mathf.Floor(f);
						float num5 = num4 * -360f;
						float num6 = num3 + num5;
						bool flag7 = num6 > 360f;
						float num9 = (!flag7) ? num6 : 360f;
						if (num6 < 0f)
						{
							num9 = 0f;
						}
						float num10 = num9 - 360f;
						bool flag12 = num9 > 180f;
						if (flag12)
						{
							num9 = num10;
						}
						float num17 = global::UnityEngine.Mathf.Clamp01(t);
						float num18 = num17 * num9;
						float num19 = num + num18;
						while (num19 < 0f)
						{
							num19 += 360f;
						}
						while (num19 > 360f)
						{
							num19 -= 360f;
						}
						float num20 = num19 / 360f;
						result.h = num20;
					}
				}
			}
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000323")]
	[global::Cpp2ILInjected.Address(RVA = "0x100E10C", Offset = "0x100E10C", Length = "0x26C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = \"papayawhip\";\n\tgoto L_0030;\n\tv31 = System.ComponentModel.BooleanConverter;\n\tv32 = v31 + 0xB98;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv71 = \"__sort-indicator\";\n\tv72 = v71 + 0x810;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv78 = \"system.security.cryptography.des\";\n\tv79 = v78 + 0xE78;\n\tv80 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv86 = \", R=\";\n\tv87 = v86 + 0x800;\n\tv88 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv93 = \"focus\";\n\tv94 = v93 + 0x348;\n\tv95 = \"il2cpp_codegen_initialize_runtime_metadata\"(v94, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv101 = \"focus\";\n\tv102 = v101 + 0x330;\n\tv103 = \"il2cpp_codegen_initialize_runtime_metadata\"(v102, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv108 = \"papayawhip\";\n\tv109 = v108 + 0x4D8;\n\tv110 = \"il2cpp_codegen_initialize_runtime_metadata\"(v109, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv112 = \", R=\";\n\tv113 = v112 + 0xCE0;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v113, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv53 = 1;\n\t*([302AA5A]) = v53;\nL_0030:\n\tv54 = \"focus\";\n\tv56 = \"__sort-indicator\";\n\tv58 = \"focus\";\n\tv60 = \"system.security.cryptography.des\";\n\tv62 = \", R=\";\n\tv64 = \", R=\";\n\tv67 = *([282B2C0]);\n\tv70 = HSBColor::ToString(&v67 @ V0_v1 (HSBColor));\n\tv77 = System.String::Concat(*([v24 @ X19_v1 (System.String)+4D8]), v70);\n\tgoto L_004E;\n\tv89 = \"il2cpp_codegen_runtime_class_init\"(v82, v74, v76, v36, v37, v38, v39, v40, v67, v42, v43, v44, v45, v46, v47, v48);\nL_004E:\n\tUnityEngine.Debug::Log(v77);\n\tv67 = *([2875A50]);\n\tv100 = HSBColor::ToString(&v67 @ V0_v1 (HSBColor));\n\tv107 = System.String::Concat(*([v54 @ X26_v1 (System.String)+330]), v100);\n\tUnityEngine.Debug::Log(v107);\n\tv67 = *([2875A60]);\n\tv118 = HSBColor::ToString(&v67 @ V0_v1 (HSBColor));\n\tv122 = System.String::Concat(*([v56 @ X25_v1 (System.String)+810]), v118);\n\tUnityEngine.Debug::Log(v122);\n\tv67 = *([282AB20]);\n\tv128 = HSBColor::ToString(&v67 @ V0_v1 (HSBColor));\n\tv132 = System.String::Concat(*([v58 @ X23_v1 (System.String)+348]), v128);\n\tUnityEngine.Debug::Log(v132);\n\tv67 = *([281F2B0]);\n\tv138 = HSBColor::ToString(&v67 @ V0_v1 (HSBColor));\n\tv142 = System.String::Concat(*([v60 @ X22_v1 (System.String)+E78]), v138);\n\tUnityEngine.Debug::Log(v142);\n\tv67 = *([2875A70]);\n\tv148 = HSBColor::ToString(&v67 @ V0_v1 (HSBColor));\n\tv152 = System.String::Concat(*([v62 @ X21_v1 (System.String)+800]), v148);\n\tUnityEngine.Debug::Log(v152);\n\t// 144 MakeStruct v164 @ AGG100E324_0_v1 (HSBColor), typeof(HSBColor), 1065285018, 1056964620, 1059366048, 1f\n\tv165 = HSBColor::ToColor(v164);\n\tv177 = 0x101BF40(&v165 @ V0_v8 (UnityEngine.Color), 0, 0, 0, v37, v38, v39, v40, v165, v165.g, v165.b, v165.a, v45, v46, v47, v48);\n\tv181 = System.String::Concat(*([v64 @ X20_v2 (System.String)+CE0]), v177);\n\tUnityEngine.Debug::Log(v181);\n\treturn;\n// 110 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static void Test()
	{
		//IL_023c: Expected O, but got I
		//IL_025e: Expected O, but got I
		//IL_0027: Expected O, but got I
		//IL_004e: Expected O, but got I
		//IL_0070: Expected O, but got I
		//IL_0092: Expected O, but got I
		//IL_00b4: Expected O, but got I
		//IL_00db: Expected O, but got I
		//IL_00fd: Expected O, but got I
		//IL_011f: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0168: Expected O, but got I
		//IL_01e3: Expected O, but got I
		string text = "papayawhip";
		string text2 = "focus";
		string text3 = "__sort-indicator";
		string text4 = "focus";
		string text5 = "system.security.cryptography.des";
		string text6 = ", R=";
		string text7 = ", R=";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [282B2C0]");
		string text8 = default(HSBColor).ToString();
		string message = text + text8;
		global::UnityEngine.Debug.Log(message);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2875A50]");
		string text9 = default(HSBColor).ToString();
		string message2 = text2 + text9;
		global::UnityEngine.Debug.Log(message2);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2875A60]");
		string text10 = default(HSBColor).ToString();
		string message3 = text3 + text10;
		global::UnityEngine.Debug.Log(message3);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [282AB20]");
		string text11 = default(HSBColor).ToString();
		string message4 = text4 + text11;
		global::UnityEngine.Debug.Log(message4);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [281F2B0]");
		string text12 = default(HSBColor).ToString();
		string message5 = text5 + text12;
		global::UnityEngine.Debug.Log(message5);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2875A70]");
		string text13 = default(HSBColor).ToString();
		string message6 = text6 + text13;
		global::UnityEngine.Debug.Log(message6);
		HSBColor hsbColor = default(HSBColor);
		hsbColor.h = 0.9959351f;
		hsbColor.s = 0.5000007f;
		hsbColor.b = 0.643137f;
		hsbColor.a = 1f;
		global::UnityEngine.Color color = ToColor(hsbColor);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @101BF40 (inside UIIconGenerator::<UpdateIcons>b__11_1 +0x68)");
		string text14 = default(string);
		string message7 = text7 + text14;
		global::UnityEngine.Debug.Log(message7);
	}
}
