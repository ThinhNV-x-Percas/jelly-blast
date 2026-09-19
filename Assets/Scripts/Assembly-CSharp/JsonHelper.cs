[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
public static class JsonHelper
{
	[global::Cpp2ILInjected.Token(Token = "0x40003F2")]
	private static readonly global::Newtonsoft.Json.JsonSerializerSettings _settings;

	[global::Cpp2ILInjected.Token(Token = "0x6000340")]
	[global::Cpp2ILInjected.Address(RVA = "0x1152534", Offset = "0x1152534", Length = "0xC4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302B000;\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302B07A]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_002F;\n\tv45 = *([v18 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]);\n\tv26 = *([v45 @ X0_v17+E0]) == 0;\n\tif (v26) goto L_0038;\nL_0016:\n\tv53 = *([v45 @ X0_v17+B8]);\n\tv72 = *([v53 @ X8_v10]);\n\tgoto L_0026;\nL_0026:\n\treturnVal1 = Newtonsoft.Json.JsonConvert::SerializeObject(obj, v72);\n\treturn returnVal1;\nL_002F:\n\t*([v16 @ X21_v1+7A]) = 1;\n\tv45 = *([v18 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]);\n\tv96 = *([v45 @ X0_v17+E0]) == 0;\n\tv48 = ~v96;\n\tif (v48) goto L_0016;\nL_0038:\n\tv91 = *([v18 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]);\n\tv92 = *([v91 @ X0_v5+B8]);\n\tv72 = *([v92 @ X8_v4]);\n\tgoto L_0026;\n\tv68 = \"il2cpp_codegen_runtime_class_init\"(v90, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tgoto L_0026;\n\treturn X0;\n// 42 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static string Serialize<T>(T obj)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00c8: Expected O, but got I
		//IL_008f: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_0108: Expected O, but got I
		//IL_0118: Expected O, but got I
		object obj2 = 50507776;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302B07A]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v17+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v17+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v91 @ X0_v5+B8]");
		object obj5 = 0;
		global::Newtonsoft.Json.JsonSerializerSettings settings = (global::Newtonsoft.Json.JsonSerializerSettings)obj5;
		goto IL_009c;
		IL_009c:
		return global::Newtonsoft.Json.JsonConvert.SerializeObject(obj, settings);
		IL_007f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v17+B8]");
		object obj6 = 0;
		settings = (global::Newtonsoft.Json.JsonSerializerSettings)obj6;
		goto IL_009c;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000341")]
	[global::Cpp2ILInjected.Address(RVA = "0x115234C", Offset = "0x115234C", Length = "0xBC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0017;\n\tgoto L_0017;\nL_0017:\n\tv44 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv62 = *([v44 @ X21_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]);\n\tgoto L_0020;\n\tv60 = \"il2cpp_codegen_runtime_class_init\"(v54, methodInfo, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37);\n\tv63 = *([v52 @ X21_v4]);\nL_0020:\n\tv66 = *([v62 @ X0_v1+B8]);\n\tgoto L_0035;\n\tv74 = \"il2cpp_codegen_runtime_class_init\"(v70, methodInfo, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37);\nL_0035:\n\treturnVal1 = Newtonsoft.Json.JsonConvert::DeserializeObject(json, *([v66 @ X8_v3]));\n\treturn returnVal1;\n\tv88 = 0xF705D0(methodInfo, methodInfo, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37);\n\tv89 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv62 = *([v89 @ X21_v7 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]);\n\tgoto L_0020;\n\tgoto L_FFFFFFFF;\n\treturn X0;\n// 48 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public static T Deserialize<T>(string json)
	{
		//IL_0018: Expected I, but got O
		//IL_0028: Expected O, but got I
		//IL_0080: Expected O, but got I
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X21_v5 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v62 @ X0_v1+B8]");
		object settings = 0;
		return global::Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json, (global::Newtonsoft.Json.JsonSerializerSettings?)settings);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000342")]
	[global::Cpp2ILInjected.Address(RVA = "0x100F01C", Offset = "0x100F01C", Length = "0x234")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0024;\n\tv25 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv26 = v25 + 0x320;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv51 = v50 + 0x328;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv55 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv56 = v55 + 0x710;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv59 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv60 = v59 + 0x418;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv136 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv137 = v136 + 0x498;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v137, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv47 = 1;\n\t*([302AABC]) = v47;\nL_0024:\n\tv49 = new *([v20 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+498])();\n\tNewtonsoft.Json.JsonSerializerSettings::.ctor(v49);\n\tv62 = UnityEngine.UIElements.EnumFieldHelpers;\n\tNewtonsoft.Json.JsonSerializerSettings::set_ReferenceLoopHandling(v49, 1);\n\tv130 = v49.<Converters>k__BackingField;\n\tv139 = new *([v62 @ X21_v2 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+328])();\n\tgoto L_0043;\n\tv196 = Il2CppMethodInfo;\n\tv197 = v196 + 0x840;\n\tv198 = \"il2cpp_codegen_initialize_runtime_metadata\"(v197, v66, v67, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\t*([302AABB]) = v64;\nL_0043:\n\tFloatConverter`1<Unity.Mathematics.float3>::.ctor(v139);\n\tv200 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv201 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv204 = *([v130 @ X20_v4 (System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>)]);\n\tv247 = *([v204 @ X8_v5 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+12E]);\n\tv206 = *([v204 @ X8_v5 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+12E]) == 0;\n\tif (v206) goto L_006B;\n\tv246 = *([v204 @ X8_v5 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+B0]) + 8;\nL_0056:\n\tv252 = *([v246 @ X10_v12-8]) == *([v200 @ X22_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+710]);\n\tif (v252) goto L_006E;\n\tv246 = v246 + 0x10;\n\tv232 = v247 - 1;\n\tv212 = v247 != 1;\n\tif (v212) goto L_0056;\nL_006B:\n\tv264 = 0xF7087C(v130, *([v200 @ X22_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+710]), 2, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_0076;\nL_006E:\n\tv259 = *([v246 @ X10_v12]) + 2;\n\tv260 = v259 << 4;\n\tv261 = v204 + v260;\n\tv264 = v261 + 0x138;\nL_0076:\n\t*([v264 @ X0_v11])(v269, v130, v139, *([v264 @ X0_v11+8]), v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv131 = v49.<Converters>k__BackingField;\n\tv271 = new *([v201 @ X23_v3 (Il2CppClass<UnityEngine.UIElements.EnumFieldHelpers>)+320])();\n\tgoto L_008A;\n\tv277 = Il2CppMethodInfo;\n\tv278 = v277 + 0x838;\n\tv279 = \"il2cpp_codegen_initialize_runtime_metadata\"(v278, v268, v114, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv281 = 1;\n\t*([302AABA]) = v281;\nL_008A:\n\tFloatConverter`1<Unity.Mathematics.float2>::.ctor(v271);\n\tv282 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv285 = *([v131 @ X20_v5 (System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>)]);\n\tv327 = *([v285 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+12E]);\n\tv187 = *([v285 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+12E]) == 0;\n\tif (v187) goto L_00B0;\n\tv326 = *([v285 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+B0]) + 8;\nL_009B:\n\tv332 = *([v326 @ X10_v7-8]) == *([v200 @ X22_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+710]);\n\tif (v332) goto L_00B3;\n\tv326 = v326 + 0x10;\n\tv312 = v327 - 1;\n\tv292 = v327 != 1;\n\tif (v292) goto L_009B;\nL_00B0:\n\tv344 = 0xF7087C(v131, *([v200 @ X22_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+710]), 2, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tgoto L_00BB;\nL_00B3:\n\tv339 = *([v326 @ X10_v7]) + 2;\n\tv340 = v339 << 4;\n\tv341 = v285 + v340;\n\tv344 = v341 + 0x138;\nL_00BB:\n\t*([v344 @ X0_v18])(v349, v131, v271, *([v344 @ X0_v18+8]), v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv350 = *([v282 @ X23_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]);\n\tv351 = *([v350 @ X8_v13+B8]);\n\t*([v351 @ X8_v14]) = v49;\n\tv191 = *([v282 @ X23_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]);\n\tv185 = 0xF3F1B4(*([v191 @ X8_v15+B8]), v49, *([v344 @ X0_v18+8]), v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 120 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	static JsonHelper()
	{
		//IL_000e: Expected I, but got O
		//IL_0021: Expected I, but got O
		//IL_005e: Expected I, but got O
		//IL_006c: Expected I, but got O
		//IL_0074: Expected I, but got O
		//IL_0084: Expected O, but got I
		//IL_00bf: Expected O, but got I
		//IL_0166: Expected I, but got O
		//IL_016e: Expected I, but got O
		//IL_017e: Expected O, but got I
		//IL_0122: Unknown result type (might be due to invalid IL or missing references)
		//IL_0127: Expected O, but got Unknown
		//IL_0144: Expected O, but got I
		//IL_0153: Expected O, but got I
		//IL_00d3: Expected O, but got I
		//IL_00e2: Expected O, but got I
		//IL_0305: Expected O, but got I
		//IL_0315: Expected O, but got I
		//IL_032d: Expected O, but got I
		//IL_01b9: Expected O, but got I
		//IL_021c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0221: Expected O, but got Unknown
		//IL_023e: Expected O, but got I
		//IL_024d: Expected O, but got I
		//IL_01cd: Expected O, but got I
		//IL_01dc: Expected O, but got I
		global::Newtonsoft.Json.JsonSerializerSettings jsonSerializerSettings = new global::Newtonsoft.Json.JsonSerializerSettings();
		jsonSerializerSettings.ReferenceLoopHandling = global::Newtonsoft.Json.ReferenceLoopHandling.Ignore;
		global::System.Collections.Generic.IList<global::Newtonsoft.Json.JsonConverter> converters = jsonSerializerSettings.Converters;
		FloatConverter<global::Unity.Mathematics.float3> floatConverter = new FloatConverter<global::Unity.Mathematics.float3>();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v5 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+12E]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v5 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_010a;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v204 @ X8_v5 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+B0]");
		object obj2 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v246 @ X10_v12-8]");
			nint num6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X22_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+710]");
			if (num6 == 0)
			{
				break;
			}
			obj2 = (nint)obj2 + 16;
			object obj3 = (nint)obj - 1;
			bool flag = (nint)obj != 1;
			obj = obj3;
			if (flag)
			{
				continue;
			}
			goto IL_010a;
		}
		object obj4 = obj2 + 2;
		int num7 = (int)((nint)obj4 << 4);
		nint num5 = 0;
		object obj5 = num5 + num7;
		goto IL_0293;
		IL_010a:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		goto IL_0293;
		IL_0293:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v264 @ X0_v11] (should have been resolved before IL gen)");
		global::System.Collections.Generic.IList<global::Newtonsoft.Json.JsonConverter> converters2 = jsonSerializerSettings.Converters;
		FloatConverter<global::Unity.Mathematics.float2> floatConverter2 = new FloatConverter<global::Unity.Mathematics.float2>();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+12E]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+12E]");
		if ((nint)0 == 0)
		{
			goto IL_0204;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v285 @ X8_v10 (Il2CppClass<System.Collections.Generic.IList`1<Newtonsoft.Json.JsonConverter>>)+B0]");
		object obj8 = (nint)0 + (nint)8;
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v326 @ X10_v7-8]");
			nint num10 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v200 @ X22_v3 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+710]");
			if (num10 == 0)
			{
				break;
			}
			obj8 = (nint)obj8 + 16;
			object obj9 = (nint)obj7 - 1;
			bool flag2 = (nint)obj7 != 1;
			obj7 = obj9;
			if (flag2)
			{
				continue;
			}
			goto IL_0204;
		}
		object obj10 = obj8 + 2;
		int num11 = (int)((nint)obj10 << 4);
		nint num9 = 0;
		object obj11 = num9 + num11;
		goto IL_02eb;
		IL_02eb:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v344 @ X0_v18] (should have been resolved before IL gen)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X23_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]");
		object obj13 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v350 @ X8_v13+B8]");
		object obj14 = 0;
		obj14 = jsonSerializerSettings;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v282 @ X23_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+418]");
		object obj15 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return;
		IL_0204:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7087C");
		goto IL_02eb;
	}
}
