[global::Cpp2ILInjected.Token(Token = "0x20000B6")]
public abstract class FloatConverter<T> : global::Newtonsoft.Json.JsonConverter
{
	[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
	protected abstract int ComponentCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000335")]
		get;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000334")]
	protected abstract T CreateInstance(float x, float y, float z = 0f);

	[global::Cpp2ILInjected.Token(Token = "0x6000336")]
	[global::Cpp2ILInjected.Address(RVA = "0x1571FC4", Offset = "0x1571FC4", Length = "0x294")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv28 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0031;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0xC10;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, writer, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv56 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv57 = v56 + 0x330;\n\tv58 = \"il2cpp_codegen_initialize_runtime_metadata\"(v57, writer, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv61 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv62 = v61 + 0x358;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, writer, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv65 = \"system.security.cryptography.des\";\n\tv66 = v65 + 0xF48;\n\tv67 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, writer, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv148 = \"x-cp50227\";\n\tv149 = v148 + 0x258;\n\tv150 = \"il2cpp_codegen_initialize_runtime_metadata\"(v149, writer, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv163 = \"x-cp50227\";\n\tv164 = v163 + 0x3B0;\n\tv165 = \"il2cpp_codegen_initialize_runtime_metadata\"(v164, writer, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv192 = System.Xml.ValidateNames;\n\tv193 = v192 + 0xD40;\n\tv194 = \"il2cpp_codegen_initialize_runtime_metadata\"(v193, writer, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv225 = System.Xml.ValidateNames;\n\tv226 = v225 + 0xD50;\n\tv50 = \"il2cpp_codegen_initialize_runtime_metadata\"(v226, writer, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\n\tv53 = 1;\n\t*([302B5E2]) = v53;\nL_0031:\n\tv55 = new *([v28 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+330])();\n\tNewtonsoft.Json.Linq.JObject::.ctor(v55);\n\tv64 = value == 0;\n\tif (v64) goto L_0097;\n\tv68 = System.Xml.ValidateNames;\n\tv76 = *([value @ X2 (System.Object)]) == *([v68 @ X8_v30 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tif (v76) goto L_0076;\n\tv151 = System.Xml.ValidateNames;\n\tv96 = *([value @ X2 (System.Object)]) != *([v151 @ X9_v5 (Il2CppClass<System.Xml.ValidateNames>)+D50]);\n\tif (v96) goto L_0097;\n\tv167 = \"il2cpp_vm_object_unbox\"(value, 0, value, v81, methodInfo, v38, v39, v40, v85, v42, v43, v44, v45, v46, v47, v48);\n\tv88 = *([v167 @ X0_v37+8]);\n\tgoto L_0062;\n\tv227 = \"il2cpp_codegen_runtime_class_init\"(v200, v60, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\nL_0062:\n\tv231 = Newtonsoft.Json.Linq.JToken::op_Implicit(*([v167 @ X0_v37]));\n\tv299 = \"system.security.cryptography.des\";\n\tNewtonsoft.Json.Linq.JObject::set_Item(v55, *([v299 @ X8_v42 (System.String)+F48]), v231);\n\tv311 = Newtonsoft.Json.Linq.JToken::op_Implicit(*([v167 @ X0_v37+4]));\n\tv142 = \"x-cp50227\" + 0x3B0;\n\tv140 = \"x-cp50227\" + 0x258;\n\tgoto L_008E;\nL_0076:\n\tv155 = \"il2cpp_vm_object_unbox\"(value, 0, value, v81, methodInfo, v38, v39, v40, v85, v42, v43, v44, v45, v46, v47, v48);\n\tv88 = *([v155 @ X0_v30+4]);\n\tgoto L_0083;\n\tv204 = \"il2cpp_codegen_runtime_class_init\"(v172, v60, value, serializer, methodInfo, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48);\nL_0083:\n\tv208 = Newtonsoft.Json.Linq.JToken::op_Implicit(*([v155 @ X0_v30]));\n\tv142 = \"x-cp50227\" + 0x258;\n\tv140 = \"system.security.cryptography.des\" + 0xF48;\nL_008E:\n\tNewtonsoft.Json.Linq.JObject::set_Item(v55, *([v140 @ X8_v33]), v305);\n\tv347 = Newtonsoft.Json.Linq.JToken::op_Implicit(v88);\n\tv133 = *([v142 @ X21_v6]);\n\tNewtonsoft.Json.Linq.JObject::set_Item(v55, *([v142 @ X21_v6]), v347);\nL_0097:\n\tv143 = Il2CppMethodInfo;\n\tv145 = *([v143 @ X8_v5 (Il2CppMethodInfo)+C10]);\n\tv146 = *([v145 @ X21_v4+38]);\n\tv147 = *([v145 @ X21_v4+38]) == 0;\n\tif (v147) goto L_00C3;\n\tv176 = *([v146 @ X8_v7+10]);\n\tv157 = *([v146 @ X8_v7+10]) + 0x135;\n\tv159 = *([v157 @ X8_v28]) & 1;\n\tv160 = v159 == 0;\n\tif (v160) goto L_00CC;\nL_00A4:\n\tv183 = *([v176 @ X0_v22+E0]) == 0;\n\tif (v183) goto L_00D2;\nL_00A6:\n\tv214 = *([v145 @ X21_v4+38]);\n\tv277 = *([v214 @ X8_v23+10]);\n\tv216 = *([v214 @ X8_v23+10]) + 0x135;\n\tv218 = *([v216 @ X8_v24]) & 1;\n\tv219 = v218 == 0;\n\tif (v219) goto L_00DA;\nL_00AF:\n\tv280 = *([v277 @ X0_v17+B8]);\n\tv282 = *([v55 @ X0_v3 (Newtonsoft.Json.Linq.JObject)]);\n\t// 193 IndirectJump [v282 @ X8_v20 (Il2CppClass<Newtonsoft.Json.Linq.JObject>)+248], v55 @ X0_v3 (Newtonsoft.Json.Linq.JObject), v55 @ X0_v3 (Newtonsoft.Json.Linq.JObject), writer @ X1 (Newtonsoft.Json.JsonWriter), [v280 @ X8_v19], [v282 @ X8_v20 (Il2CppClass<Newtonsoft.Json.Linq.JObject>)+250], [v282 @ X8_v20 (Il2CppClass<Newtonsoft.Json.Linq.JObject>)+248], v38 @ X5, v39 @ X6, v40 @ X7, v88 @ V8_v4 (System.Single), v42 @ V1, v43 @ V2, v44 @ V3, v45 @ V4, v46 @ V5, v47 @ V6, v48 @ V7\nL_00C3:\n\tv162 = 0xF705D0(v145, v133, v347, 0, methodInfo, v38, v39, v40, v88, v42, v43, v44, v45, v46, v47, v48);\n\tv188 = *([v145 @ X21_v4+38]);\n\tv176 = *([v188 @ X8_v15+10]);\n\tv189 = *([v188 @ X8_v15+10]) + 0x135;\n\tv190 = *([v189 @ X8_v16]) & 1;\n\tv191 = v190 == 0;\n\tv179 = ~v191;\n\tif (v179) goto L_00A4;\nL_00CC:\n\tv187 = 0xF7055C(v184, v133, v347, 0, methodInfo, v38, v39, v40, v88, v42, v43, v44, v45, v46, v47, v48);\n\tv224 = *([v187 @ X0_v13+E0]) == 0;\n\tv211 = ~v224;\n\tif (v211) goto L_00A6;\nL_00D2:\n\tv244 = *([v145 @ X21_v4+38]);\n\tv277 = *([v244 @ X8_v10+10]);\n\tv245 = *([v244 @ X8_v10+10]) + 0x135;\n\tv246 = *([v245 @ X8_v11]) & 1;\n\tv247 = v246 == 0;\n\tv236 = ~v247;\n\tif (v236) goto L_00AF;\nL_00DA:\n\tv277 = 0xF7055C(v240, v133, v347, 0, methodInfo, v38, v39, v40, v88, v42, v43, v44, v45, v46, v47, v48);\n\tv297 = v55 == 0;\n\tv273 = ~v297;\n\tif (v273) goto L_00AF;\n\tthrow System.NullReferenceException;\n// 119 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.JsonSerializer serializer)
	{
		//IL_000e: Expected I, but got O
		//IL_0189: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_02f1: Expected O, but got I
		//IL_0301: Expected O, but got I
		//IL_0317: Expected O, but got I
		//IL_0320: Unknown result type (might be due to invalid IL or missing references)
		//IL_0325: Expected I4, but got Unknown
		//IL_034f: Expected O, but got I
		//IL_0021: Expected I, but got O
		//IL_01ce: Expected O, but got I
		//IL_01e4: Expected O, but got I
		//IL_01ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f2: Expected I4, but got Unknown
		//IL_0211: Expected O, but got I
		//IL_0131: Expected F4, but got I
		//IL_03a7: Expected O, but got I
		//IL_03b7: Expected O, but got I
		//IL_03cd: Expected O, but got I
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03db: Expected I4, but got Unknown
		//IL_0405: Expected O, but got I
		//IL_013f: Expected F4, but got O
		//IL_0053: Expected I, but got O
		//IL_02c5: Expected O, but got I
		//IL_02cd: Expected I, but got O
		//IL_0254: Expected O, but got I
		//IL_0264: Expected O, but got I
		//IL_027a: Expected O, but got I
		//IL_0283: Unknown result type (might be due to invalid IL or missing references)
		//IL_0288: Expected I4, but got Unknown
		//IL_02a7: Expected O, but got I
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_0157: Expected O, but got Unknown
		//IL_0161: Unknown result type (might be due to invalid IL or missing references)
		//IL_0166: Expected O, but got Unknown
		//IL_0099: Expected F4, but got I
		//IL_00a7: Expected F4, but got O
		//IL_00d2: Expected O, but got I
		//IL_00e3: Expected F4, but got I
		//IL_00f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fb: Expected O, but got Unknown
		//IL_0105: Unknown result type (might be due to invalid IL or missing references)
		//IL_010a: Expected O, but got Unknown
		global::Newtonsoft.Json.Linq.JObject jObject = new global::Newtonsoft.Json.Linq.JObject();
		bool flag = value == null;
		string text = null;
		if (!flag)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v68 @ X8_v30 (Il2CppClass<System.Xml.ValidateNames>)+D40]");
			float num4;
			object obj2;
			object propertyName;
			global::Newtonsoft.Json.Linq.JToken value3;
			if (value != null)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X9_v5 (Il2CppClass<System.Xml.ValidateNames>)+D50]");
				bool flag2 = value != null;
				text = null;
				if (flag2)
				{
					goto IL_0173;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_unbox\"");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v37+8]");
				num4 = 0f;
				object obj = default(object);
				global::Newtonsoft.Json.Linq.JToken value2 = (float)obj;
				string text2 = "system.security.cryptography.des";
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v299 @ X8_v42 (System.String)+F48]");
				jObject[(string)0] = value2;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v167 @ X0_v37+4]");
				global::Newtonsoft.Json.Linq.JToken jToken = 0f;
				obj2 = "x-cp50227" + 944;
				propertyName = "x-cp50227" + 600;
				value3 = jToken;
			}
			else
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"il2cpp_vm_object_unbox\"");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v155 @ X0_v30+4]");
				num4 = 0f;
				object obj3 = default(object);
				global::Newtonsoft.Json.Linq.JToken jToken2 = (float)obj3;
				obj2 = "x-cp50227" + 600;
				propertyName = "system.security.cryptography.des" + 3912;
				value3 = jToken2;
			}
			jObject[(string)propertyName] = value3;
			global::Newtonsoft.Json.Linq.JToken value4 = num4;
			text = (string)obj2;
			jObject[(string)obj2] = value4;
		}
		goto IL_0173;
		IL_0244:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X21_v4+38]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v23+10]");
		object obj5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v23+10]");
		object obj6 = (nint)0 + (nint)309;
		int num5 = obj6 & 1;
		bool flag3 = num5 == 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v214 @ X8_v23+10]");
		object obj7 = 0;
		if (!flag3)
		{
			goto IL_02b5;
		}
		goto IL_0413;
		IL_035d:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7055C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v187 @ X0_v13+E0]");
		if ((nint)0 != 0)
		{
			goto IL_0244;
		}
		goto IL_0397;
		IL_02d7:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F705D0");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X21_v4+38]");
		object obj8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v15+10]");
		object obj9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v15+10]");
		object obj10 = (nint)0 + (nint)309;
		int num6 = obj10 & 1;
		bool flag4 = num6 == 0;
		bool flag5 = !flag4;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v188 @ X8_v15+10]");
		object obj11 = 0;
		if (flag5)
		{
			goto IL_021f;
		}
		goto IL_035d;
		IL_0397:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X21_v4+38]");
		object obj12 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v10+10]");
		obj5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v10+10]");
		object obj13 = (nint)0 + (nint)309;
		int num7 = obj13 & 1;
		bool flag6 = num7 == 0;
		bool flag7 = !flag6;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v244 @ X8_v10+10]");
		obj7 = 0;
		if (flag7)
		{
			goto IL_02b5;
		}
		goto IL_0413;
		IL_02b5:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v277 @ X0_v17+B8]");
		object obj14 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: [v282 @ X8_v20 (Il2CppClass<Newtonsoft.Json.Linq.JObject>)+248] (should have been resolved before IL gen)");
		goto IL_02d7;
		IL_0173:
		nint num9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v143 @ X8_v5 (Il2CppMethodInfo)+C10]");
		object obj15 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X21_v4+38]");
		object obj16 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v145 @ X21_v4+38]");
		if ((nint)0 == 0)
		{
			goto IL_02d7;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v7+10]");
		obj9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v7+10]");
		object obj17 = (nint)0 + (nint)309;
		int num10 = obj17 & 1;
		bool flag8 = num10 == 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v146 @ X8_v7+10]");
		obj11 = 0;
		if (!flag8)
		{
			goto IL_021f;
		}
		goto IL_035d;
		IL_0413:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F7055C");
		if (jObject == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_02b5;
		IL_021f:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v176 @ X0_v22+E0]");
		if ((nint)0 != 0)
		{
			goto IL_0244;
		}
		goto IL_0397;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000337")]
	[global::Cpp2ILInjected.Address(RVA = "0x1572258", Offset = "0x1572258", Length = "0x1F0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv25 = &v25 @ X29;\n\tv36 = *([2C38708]);\n\t*([v25 @ X29-68]) = *([v36 @ X8_v2]);\n\tgoto L_002E;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x240;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, reader, objectType, existingValue, serializer, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv76 = \"system.security.cryptography.des\";\n\tv77 = v76 + 0xF48;\n\tv78 = \"il2cpp_codegen_initialize_runtime_metadata\"(v77, reader, objectType, existingValue, serializer, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv80 = \"x-cp50227\";\n\tv81 = v80 + 0x258;\n\tv82 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, reader, objectType, existingValue, serializer, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv94 = \"x-cp50227\";\n\tv95 = v94 + 0x3B0;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v95, reader, objectType, existingValue, serializer, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv62 = 1;\n\t*([302B5E3]) = v62;\nL_002E:\n\tv65 = Il2CppClass<T>;\n\tv69 = *([v65 @ X8_v8 (Il2CppClass<T>)+FC]) + 0xF;\n\tv70 = v69 & 0x1FFFFFFF0;\n\tv71 = &v68 @ stack_-B0_v1 - v70;\n\tv75 = Newtonsoft.Json.Linq.JObject::Load(reader);\n\tv84 = \"system.security.cryptography.des\";\n\tv86 = Il2CppMethodInfo;\n\tv88 = \"x-cp50227\";\n\tv92 = Newtonsoft.Json.Linq.JObject::get_Item(v75, *([v84 @ X8_v13 (System.String)+F48]));\n\tv98 = v92 == 0;\n\tif (v98) goto L_004B;\n\tv165 = Newtonsoft.Json.Linq.Extensions::Value /* +1 sharing this address */(v92, *([v86 @ X23_v2 (Il2CppMethodInfo)+240]));\nL_004B:\n\tv169 = \"x-cp50227\";\n\tv173 = Newtonsoft.Json.Linq.JObject::get_Item(v75, *([v88 @ X24_v2 (System.String)+258]));\n\tv174 = v173 == 0;\n\tif (v174) goto L_0059;\n\tv225 = Newtonsoft.Json.Linq.Extensions::Value /* +1 sharing this address */(v173, *([v86 @ X23_v2 (Il2CppMethodInfo)+240]));\nL_0059:\n\tv232 = Newtonsoft.Json.Linq.JObject::get_Item(v75, *([v169 @ X25_v2 (System.String)+3B0]));\n\tv159 = v232 == 0;\n\tif (v159) goto L_0061;\n\tv235 = Newtonsoft.Json.Linq.Extensions::Value /* +1 sharing this address */(v232, *([v86 @ X23_v2 (Il2CppMethodInfo)+240]));\nL_0061:\n\tv239 = this->klass;\n\t*([v239 @ X8_v15 (Il2CppClass<FloatConverter`1<T>>)+1D8])(v243, this, *([v239 @ X8_v15 (Il2CppClass<FloatConverter`1<T>>)+1E0]), 0, v101, v99, methodInfo, v49, v50, v140, v52, v53, v54, v55, v56, v57, v58);\n\tv108 = v243 != 3;\n\tif (v108) goto L_FFFFFFFF;\n\tgoto L_0075;\nL_0075:\n\t*([v25 @ X29-90]) = v149;\n\t*([v25 @ X29-8C]) = v147;\n\t*([v25 @ X29-94]) = v141;\n\tv255 = this->klass;\n\tv256 = &v25 @ X29 - 0x8C;\n\tv105 = &v25 @ X29 - 0x90;\n\t*([v25 @ X29-88]) = v256;\n\t*([v25 @ X29-80]) = v105;\n\tv257 = &v25 @ X29 - 0x94;\n\t*([v25 @ X29-78]) = v257;\n\t*([v25 @ X29-70]) = v71;\n\tv258 = this->klass->vtable[9];\n\tv102 = &v25 @ X29 - 0x88;\n\t*([v258 @ X1_v10+10])(v261, *([v258 @ X1_v10+8]), *([v255 @ X8_v16 (Il2CppClass<FloatConverter`1<T>>)+1D0]), this, v102, v71, methodInfo, v49, v50, v141, v52, v53, v54, v55, v56, v57, v58);\n\t// 139 Box returnVal2 @ X0_v20 (System.Object), typeof(Il2CppClass<T>), v71 @ X21_v2 (Newtonsoft.Json.JsonSerializer)\n\tv266 = *([2C38708]);\n\tv113 = *([v266 @ X9_v7]) != *([v25 @ X29-68]);\n\tif (v113) goto L_00AD;\n\treturn returnVal2;\n\tv93 = new System.NullReferenceException();\nL_00AD:\n\treturnVal1 = 0x274A17C(v156, 0, objectType, v101, v99, methodInfo, v49, v50, v140, v52, v53, v54, v55, v56, v57, v58);\n\treturn returnVal1;\n// 109 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
	{
		//IL_0018: Expected O, but got I
		//IL_0109: Expected O, but got I
		//IL_011c: Expected I4, but got I8
		//IL_012a: Expected O, but got I
		//IL_004f: Expected O, but got I
		//IL_015a: Expected O, but got I
		//IL_0199: Expected O, but got I
		//IL_01c8: Expected I, but got O
		//IL_0206: Expected I, but got O
		//IL_0215: Expected O, but got I
		//IL_0224: Expected O, but got I
		//IL_023d: Expected O, but got I
		//IL_0257: Expected O, but got I
		//IL_0266: Expected O, but got I
		//IL_0279: Expected I, but got O
		//IL_028d: Expected O, but got I
		object obj = obj;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2C38708]");
		object obj2 = 0;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v65 @ X8_v8 (Il2CppClass<T>)+FC]");
		object obj3 = (nint)0 + (nint)15;
		int num2 = (int)((nint)obj3 & 0x1FFFFFFF0L);
		object obj4 = default(object);
		global::Newtonsoft.Json.JsonSerializer jsonSerializer = (global::Newtonsoft.Json.JsonSerializer)((nint)obj4 - num2);
		global::Newtonsoft.Json.Linq.JObject jObject = global::Newtonsoft.Json.Linq.JObject.Load(reader);
		string text = "system.security.cryptography.des";
		nint num3 = 0;
		string text2 = "x-cp50227";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v84 @ X8_v13 (System.String)+F48]");
		global::Newtonsoft.Json.Linq.JToken jToken = jObject[(string)0];
		bool flag = jToken == null;
		int num4 = 0;
		int num5 = default(int);
		if (!flag)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11466B4 (Newtonsoft.Json.Linq.Extensions::Value, and 1 more at this address)");
			num4 = num5;
		}
		string text3 = "x-cp50227";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X24_v2 (System.String)+258]");
		global::Newtonsoft.Json.Linq.JToken jToken2 = jObject[(string)0];
		bool flag2 = jToken2 == null;
		int num6 = 0;
		if (!flag2)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11466B4 (Newtonsoft.Json.Linq.Extensions::Value, and 1 more at this address)");
			num6 = num5;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v169 @ X25_v2 (System.String)+3B0]");
		global::Newtonsoft.Json.Linq.JToken jToken3 = jObject[(string)0];
		bool flag3 = jToken3 == null;
		int num7 = 0;
		if (!flag3)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11466B4 (Newtonsoft.Json.Linq.Extensions::Value, and 1 more at this address)");
			num7 = num5;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v239 @ X8_v15 (Il2CppClass<FloatConverter`1<T>>)+1D8] (should have been resolved before IL gen)");
		object obj5 = default(object);
		if ((nint)obj5 == 3)
		{
			int num9 = num7;
		}
		else
		{
			int num9 = 0;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X8_v16 (Il2CppClass<FloatConverter`1<T>>)+1D0]");
		object obj9 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: [v258 @ X1_v10+10] (should have been resolved before IL gen)");
		object result = (global::System.IntPtr)jsonSerializer;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2C38708]");
		object obj11 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X29-68]");
		if (obj11 == null)
		{
			return result;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A17C");
		object result2 = default(object);
		return result2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000338")]
	[global::Cpp2ILInjected.Address(RVA = "0x1572448", Offset = "0x1572448", Length = "0x84")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv25 = System.Net.Configuration.SettingsSectionInternal;\n\tv26 = v25 + 0xB78;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, objectType, methodInfo, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = 1;\n\t*([302B5E4]) = v44;\nL_001E:\n\tgoto L_0022;\n\tv52 = \"il2cpp_codegen_runtime_class_init\"(v48, objectType, methodInfo, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\nL_0022:\n\tv56 = System.Type::GetTypeFromHandle(Il2CppClass<T>);\n\treturnVal1 = System.Type::op_Equality(objectType, v56);\n\treturn returnVal1;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override bool CanConvert(global::System.Type objectType)
	{
		global::System.Type typeFromHandle = typeof(T);
		return objectType == typeFromHandle;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000339")]
	[global::Cpp2ILInjected.Address(RVA = "0x15724CC", Offset = "0x15724CC", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tNewtonsoft.Json.JsonConverter::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected internal FloatConverter()
	{
	}
}
