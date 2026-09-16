[global::Cpp2ILInjected.Token(Token = "0x20000C1")]
public class Lock : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000433")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public GoalData goalData;

	[global::Cpp2ILInjected.Token(Token = "0x4000434")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::UnityEngine.MaterialPropertyBlock _propBlock;

	[global::Cpp2ILInjected.Token(Token = "0x4000435")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.Transform collectionPoint;

	[global::Cpp2ILInjected.Token(Token = "0x4000436")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.Rigidbody2D pad;

	[global::Cpp2ILInjected.Token(Token = "0x4000437")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public ElasticScale counterElasticScale;

	[global::Cpp2ILInjected.Token(Token = "0x4000438")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public global::TMPro.TextMeshPro counterText;

	[global::Cpp2ILInjected.Token(Token = "0x4000439")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public global::UnityEngine.GameObject[] destroyObjects;

	[global::Cpp2ILInjected.Token(Token = "0x400043A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public global::UnityEngine.MeshRenderer[] colorMeshRenderers;

	[global::Cpp2ILInjected.Token(Token = "0x600036F")]
	[global::Cpp2ILInjected.Address(RVA = "0x1012D88", Offset = "0x1012D88", Length = "0x418")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002E;\n\tv45 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv46 = v45 + 0x900;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv71 = Il2CppMethodInfo;\n\tv72 = v71 + 0xC90;\n\tv73 = \"il2cpp_codegen_initialize_runtime_metadata\"(v72, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv357 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv358 = v357 + 0xA48;\n\tv359 = \"il2cpp_codegen_initialize_runtime_metadata\"(v358, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv412 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv413 = v412 + 0x900;\n\tv414 = \"il2cpp_codegen_initialize_runtime_metadata\"(v413, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv416 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv417 = v416 + 0x950;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v417, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv66 = 1;\n\t*([302AAC0]) = v66;\nL_002E:\n\tv337 = this.goalData;\n\tv337.displayedCount = v337.count;\n\tgoto L_0041;\n\tv360 = \"Cannot load image: download failed\";\n\tv361 = v360 + 0xE78;\n\tv303 = \"il2cpp_codegen_initialize_runtime_metadata\"(v361, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv415 = 1;\n\t*([302AAC1]) = v415;\n\tv336 = v38.goalData;\nL_0041:\n\tv364 = \"Cannot load image: download failed\";\n\tv351 = this.counterText;\n\tv365 = v337 + 0x1C;\n\tv304 = System.Int32::ToString(v365, *([v364 @ X9_v5 (System.String)+E78]));\n\tv419 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv338 = *([v351 @ X20_v5 (TMPro.TextMeshPro)]);\n\tv422 = TMPro.TMP_Text::set_text(v351, v304);\n\tv424 = new *([v419 @ X21_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+900])();\n\tUnityEngine.MaterialPropertyBlock::.ctor(v424);\n\tv352 = this + 0x28;\n\tthis._propBlock = v424;\n\tv305 = 0xF3F1B4(v352, v424, *([v338 @ X8_v7 (Il2CppClass<TMPro.TextMeshPro>)+560]), v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv265 = this.colorMeshRenderers;\n\tv526 = v265.Length < 1;\n\tif (v526) goto L_013F;\n\tv528 = Il2CppMethodInfo;\n\tv529 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv530 = \"Writing object reference to Id '{0}' for {1}.\";\nL_007D:\n\tgoto L_007F;\n\tv586 = \"il2cpp_codegen_runtime_class_init\"(v570, v283, v273, v126, v51, v52, v53, v54, v166, v159, v152, v145, v59, v60, v61, v62);\nL_007F:\n\t;\n\tv306 = Singleton`1::get_Instance /* +1 sharing this address */(*([v528 @ X26_v5 (Il2CppMethodInfo)+C90]));\n\tv340 = *([v306 @ X0_v27+78]);\n\tv294 = this.goalData;\n\tv175 = v294.fluidType << 4;\n\tv342 = *([v340 @ X8_v21+28]) + v175;\n\t// 162 MakeStruct v123 @ AGG1012F54_0_v5 (UnityEngine.Color), typeof(UnityEngine.Color), [v342 @ X8_v23+20], [v342 @ X8_v23+24], [v342 @ X8_v23+28], [v342 @ X8_v23+2C]\n\tUnityEngine.Color::RGBToHSV(v123, &v142 @ stack_-94_v5 (System.Single), &v137 @ stack_-98_v6 (System.Single), &v133 @ stack_-9C_v6 (System.Single));\n\tv606 = v133 * 0.75f;\n\tv167 = UnityEngine.Color::HSVToRGB(v142, v137, v606, 1);\n\tUnityEngine.Renderer::GetPropertyBlock(v265[v202 @ X24_v6 (System.Int32)], this._propBlock, 0);\n\tv308 = Singleton`1::get_Instance /* +1 sharing this address */(*([v528 @ X26_v5 (Il2CppMethodInfo)+C90]));\n\tv343 = *([v308 @ X0_v32+78]);\n\tv296 = this.goalData;\n\tv176 = v296.fluidType << 4;\n\tv345 = *([v343 @ X8_v24+28]) + v176;\n\t// 222 MakeStruct v97 @ AGG1012FEC_2_v5 (UnityEngine.Color), typeof(UnityEngine.Color), [v345 @ X8_v26+20], [v345 @ X8_v26+24], [v345 @ X8_v26+28], [v345 @ X8_v26+2C]\n\tUnityEngine.MaterialPropertyBlock::SetColor(this._propBlock, *([v529 @ X27_v5 (System.String)+900]), v97);\n\tUnityEngine.MaterialPropertyBlock::SetColor(this._propBlock, *([v530 @ X25_v5 (System.String)+950]), v167);\n\tUnityEngine.Renderer::SetPropertyBlock(v265[v202 @ X24_v6 (System.Int32)], this._propBlock, 0);\n\tUnityEngine.Renderer::GetPropertyBlock(v265[v202 @ X24_v6 (System.Int32)], this._propBlock, 2);\n\tv310 = Singleton`1::get_Instance /* +1 sharing this address */(*([v528 @ X26_v5 (Il2CppMethodInfo)+C90]));\n\tv346 = *([v310 @ X0_v38+78]);\n\tv298 = this.goalData;\n\tv177 = v298.fluidType << 4;\n\tv348 = *([v346 @ X8_v27+28]) + v177;\n\t// 282 MakeStruct v87 @ AGG1013090_2_v5 (UnityEngine.Color), typeof(UnityEngine.Color), [v348 @ X8_v29+20], [v348 @ X8_v29+24], [v348 @ X8_v29+28], [v348 @ X8_v29+2C]\n\tUnityEngine.MaterialPropertyBlock::SetColor(this._propBlock, *([v529 @ X27_v5 (System.String)+900]), v87);\n\tUnityEngine.MaterialPropertyBlock::SetColor(this._propBlock, *([v530 @ X25_v5 (System.String)+950]), v167);\n\tUnityEngine.Renderer::SetPropertyBlock(v265[v202 @ X24_v6 (System.Int32)], this._propBlock, 2);\n\tv202 = v202 + 1;\n\tv545 = v202 < v265.Length;\n\tif (v545) goto L_007D;\nL_013F:\n\tgoto L_0145;\n\tv573 = System.Xml.ValidateNames;\n\tv574 = v573 + 0x98;\n\tv575 = \"il2cpp_codegen_initialize_runtime_metadata\"(v574, v289, v279, v130, v51, v52, v53, v54, v541, v539, v157, v150, v59, v60, v61, v62);\n\tv578 = 1;\n\t*([2DD4432]) = v578;\nL_0145:\n\tv579 = System.Xml.ValidateNames;\n\tv581 = *([v579 @ X8_v12 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv349 = *([v581 @ X8_v14+B8]);\n\tv585 = UnityEngine.Random::Range(-1f, 1f);\n\tv171 = UnityEngine.Random::Range(2f, 3f);\n\tv488 = v585 < 0;\n\tv482 = v585 ^ v585;\n\tv480 = v585 & v482;\n\tv478 = v480 < 0;\n\tv591 = v488 == v478;\n\tv476 = ~v591;\n\tv433 = ~v476;\n\tif (v433) goto L_FFFFFFFF;\n\tgoto L_0169;\nL_0169:\n\tv595 = *([v349 @ X8_v15+2C]) * v594;\n\tv458 = v171 * v595;\n\tv456 = *([v349 @ X8_v15+28]) * v594;\n\tv460 = v171 * v456;\n\t// 368 MakeStruct v426 @ AGG1013168_1_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v460 @ V0_v8 (System.Single), v458 @ V1_v7 (System.Single)\n\tUnityEngine.Rigidbody2D::AddForce(this.pad, v426, 1);\n\treturn;\n\tv356 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 283 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private unsafe void Start()
	{
		//IL_0053: Expected O, but got I
		//IL_006a: Expected I, but got O
		//IL_0072: Expected I, but got O
		//IL_009a: Expected O, but got I
		//IL_0549: Expected I, but got O
		//IL_0559: Expected O, but got I
		//IL_0569: Expected O, but got I
		//IL_04bc: Expected O, but got F4
		//IL_04c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ca: Expected I4, but got Unknown
		//IL_0122: Expected O, but got I
		//IL_0164: Expected O, but got I
		//IL_017d: Expected F4, but got I
		//IL_0192: Expected F4, but got I
		//IL_01a7: Expected F4, but got I
		//IL_01bc: Expected F4, but got I
		//IL_023d: Expected O, but got I
		//IL_027f: Expected O, but got I
		//IL_0299: Expected F4, but got I
		//IL_02ae: Expected F4, but got I
		//IL_02c3: Expected F4, but got I
		//IL_02d8: Expected F4, but got I
		//IL_02f3: Expected O, but got I
		//IL_0314: Expected O, but got I
		//IL_0373: Expected O, but got I
		//IL_03b5: Expected O, but got I
		//IL_03cf: Expected F4, but got I
		//IL_03e4: Expected F4, but got I
		//IL_03f9: Expected F4, but got I
		//IL_040e: Expected F4, but got I
		//IL_0429: Expected O, but got I
		//IL_044a: Expected O, but got I
		GoalData goalData = this.goalData;
		goalData.displayedCount = goalData.count;
		string text = "Cannot load image: download failed";
		global::TMPro.TextMeshPro textMeshPro = counterText;
		int num = (int)((nint)goalData + 28);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v364 @ X9_v5 (System.String)+E78]");
		string text2 = ((int*)num)->ToString((string)0);
		nint num2 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		nint num3 = (nint)textMeshPro;
		textMeshPro.text = text2;
		global::UnityEngine.MaterialPropertyBlock propBlock = new global::UnityEngine.MaterialPropertyBlock();
		object obj = (nint)this + 40;
		_propBlock = propBlock;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.MeshRenderer[] array = colorMeshRenderers;
		if (array.Length >= 1)
		{
			nint num4 = 0;
			string text3 = "Writing object reference to Id '{0}' for {1}.";
			string text4 = "Writing object reference to Id '{0}' for {1}.";
			int num5 = 0;
			global::UnityEngine.Color rgbColor = default(global::UnityEngine.Color);
			global::UnityEngine.Color value2 = default(global::UnityEngine.Color);
			global::UnityEngine.Color value3 = default(global::UnityEngine.Color);
			do
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v306 @ X0_v27+78]");
				object obj2 = 0;
				GoalData goalData2 = this.goalData;
				int num6 = goalData2.fluidType << 4;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v340 @ X8_v21+28]");
				object obj3 = (nint)0 + (nint)num6;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v23+20]");
				rgbColor.r = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v23+24]");
				rgbColor.g = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v23+28]");
				rgbColor.b = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v342 @ X8_v23+2C]");
				rgbColor.a = 0f;
				global::UnityEngine.Color.RGBToHSV(rgbColor, out var H, out var S, out var V);
				float v = V * 0.75f;
				global::UnityEngine.Color value = global::UnityEngine.Color.HSVToRGB(H, S, v, hdr: true);
				array[num5].GetPropertyBlock(_propBlock, 0);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v308 @ X0_v32+78]");
				object obj4 = 0;
				GoalData goalData3 = this.goalData;
				int num7 = goalData3.fluidType << 4;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v343 @ X8_v24+28]");
				object obj5 = (nint)0 + (nint)num7;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v26+20]");
				value2.r = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v26+24]");
				value2.g = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v26+28]");
				value2.b = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v345 @ X8_v26+2C]");
				value2.a = 0f;
				global::UnityEngine.MaterialPropertyBlock propBlock2 = _propBlock;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X27_v5 (System.String)+900]");
				propBlock2.SetColor((string)0, value2);
				global::UnityEngine.MaterialPropertyBlock propBlock3 = _propBlock;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X25_v5 (System.String)+950]");
				propBlock3.SetColor((string)0, value);
				array[num5].SetPropertyBlock(_propBlock, 0);
				array[num5].GetPropertyBlock(_propBlock, 2);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v310 @ X0_v38+78]");
				object obj6 = 0;
				GoalData goalData4 = this.goalData;
				int num8 = goalData4.fluidType << 4;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v346 @ X8_v27+28]");
				object obj7 = (nint)0 + (nint)num8;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v29+20]");
				value3.r = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v29+24]");
				value3.g = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v29+28]");
				value3.b = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v29+2C]");
				value3.a = 0f;
				global::UnityEngine.MaterialPropertyBlock propBlock4 = _propBlock;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v529 @ X27_v5 (System.String)+900]");
				propBlock4.SetColor((string)0, value3);
				global::UnityEngine.MaterialPropertyBlock propBlock5 = _propBlock;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v530 @ X25_v5 (System.String)+950]");
				propBlock5.SetColor((string)0, value);
				array[num5].SetPropertyBlock(_propBlock, 2);
				num5++;
			}
			while (num5 < array.Length);
		}
		nint num9 = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v12 (Il2CppClass<System.Xml.ValidateNames>)+98]");
		object obj8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v581 @ X8_v14+B8]");
		object obj9 = 0;
		float num10 = global::UnityEngine.Random.Range(-1f, 1f);
		float num11 = global::UnityEngine.Random.Range(2f, 3f);
		bool flag = num10 < 0f;
		object obj10 = num10 ^ num10;
		int num12 = num10 & (nint)obj10;
		bool flag2 = num12 < 0;
		float num13 = ((flag == flag2) ? 1f : (-1f));
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v15+2C]");
		float num14 = 0f * num13;
		float y = num11 * num14;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v349 @ X8_v15+28]");
		float num15 = 0f * num13;
		float x = num11 * num15;
		global::UnityEngine.Vector2 force = default(global::UnityEngine.Vector2);
		force.x = x;
		force.y = y;
		pad.AddForce(force, global::UnityEngine.ForceMode2D.Impulse);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000370")]
	[global::Cpp2ILInjected.Address(RVA = "0x101321C", Offset = "0x101321C", Length = "0xC4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv48 = this.goalData;\n\tv15 = v48.displayedCount - 1;\n\tv48.displayedCount = v15;\n\tgoto L_001B;\n\tv65 = \"Cannot load image: download failed\";\n\tv66 = v65 + 0xE78;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, methodInfo, v22, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64);\n\tv71 = 1;\n\t*([302AAC1]) = v71;\n\tv47 = v13.goalData;\nL_001B:\n\tv69 = \"Cannot load image: download failed\";\n\tv70 = v48 + 0x1C;\n\tv32 = System.Int32::ToString(v70, *([v69 @ X9_v5 (System.String)+E78]));\n\tv94 = TMPro.TMP_Text::set_text(this.counterText, v32);\n\tElasticScale::Pop(this.counterElasticScale);\n\tv50 = this.goalData;\n\tv87 = v50.displayedCount == 0;\n\tif (v87) goto L_0041;\n\treturn;\nL_0041:\n\tLock::Open(this);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 46 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void RecieveParticle()
	{
		//IL_0061: Expected O, but got I
		GoalData goalData = this.goalData;
		int displayedCount = goalData.displayedCount - 1;
		goalData.displayedCount = displayedCount;
		string text = "Cannot load image: download failed";
		int num = (int)((nint)goalData + 28);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X9_v5 (System.String)+E78]");
		string text2 = ((int*)num)->ToString((string)0);
		counterText.text = text2;
		counterElasticScale.Pop();
		GoalData goalData2 = this.goalData;
		if (goalData2.displayedCount == 0)
		{
			Open();
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000371")]
	[global::Cpp2ILInjected.Address(RVA = "0x10131A0", Offset = "0x10131A0", Length = "0x7C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv17 = \"Cannot load image: download failed\";\n\tv18 = v17 + 0xE78;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302AAC1]) = v37;\nL_0015:\n\tv40 = \"Cannot load image: download failed\";\n\tv42 = this.counterText;\n\tv43 = this.goalData + 0x1C;\n\tv46 = System.Int32::ToString(v43, *([v40 @ X9_v2 (System.String)+E78]));\n\tv57 = *([v42 @ X19_v3 (TMPro.TextMeshPro)]);\n\tv58 = *([v57 @ X8_v4 (Il2CppClass<TMPro.TextMeshPro>)+558]);\n\tv59 = *([v57 @ X8_v4 (Il2CppClass<TMPro.TextMeshPro>)+560]);\n\t// 40 IndirectJump v58 @ X3_v1, v42 @ X19_v3 (TMPro.TextMeshPro), v42 @ X19_v3 (TMPro.TextMeshPro), v46 @ X0_v5 (System.String), v59 @ X2_v3, v58 @ X3_v1, v23 @ X4, v24 @ X5, v25 @ X6, v26 @ X7, v27 @ V0, v28 @ V1, v29 @ V2, v30 @ V3, v31 @ V4, v32 @ V5, v33 @ V6, v34 @ V7\n\tthrow System.NullReferenceException;\n\treturn;\n// 27 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe void UpdateCounterText()
	{
		//IL_003e: Expected O, but got I
		//IL_004f: Expected I, but got O
		//IL_005f: Expected O, but got I
		//IL_006f: Expected O, but got I
		string text = "Cannot load image: download failed";
		global::TMPro.TextMeshPro textMeshPro = counterText;
		int num = (int)((nint)goalData + 28);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v40 @ X9_v2 (System.String)+E78]");
		string text2 = ((int*)num)->ToString((string)0);
		nint num2 = (nint)textMeshPro;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<TMPro.TextMeshPro>)+558]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v57 @ X8_v4 (Il2CppClass<TMPro.TextMeshPro>)+560]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect jump: v58 @ X3_v1 (should have been resolved before IL gen)");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000372")]
	[global::Cpp2ILInjected.Address(RVA = "0x10132E0", Offset = "0x10132E0", Length = "0x168")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = Il2CppMethodInfo;\n\tgoto L_0025;\n\tv29 = Il2CppMethodInfo;\n\tv30 = v29 + 0x780;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv54 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv55 = v54 + 0xFD8;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv62 = Il2CppMethodInfo;\n\tv63 = v62 + 0xC90;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv69 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv70 = v69 + 0xA48;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AA73]) = v50;\nL_0025:\n\tv53 = UnityEngine.Component::GetComponentInChildren /* +1 sharing this address */(this, *([v22 @ X22_v1 (Il2CppMethodInfo)+780]));\n\tgoto L_002F;\n\tv65 = \"il2cpp_codegen_runtime_class_init\"(v58, v51, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_002F:\n\tUnityEngine.Object::Destroy(v53);\n\tv147 = this.destroyObjects;\n\tv76 = Il2CppMethodInfo;\n\tgoto L_004A;\nL_003B:\n\tUnityEngine.Object::DestroyImmediate(v147[v115 @ X24_v3 (System.Int32)]);\n\tv115 = v115 + 1;\n\tv147 = this.destroyObjects;\nL_004A:\n\tv84 = v115 >= v147.Length;\n\tif (v84) goto L_005A;\n\tgoto L_003B;\n\tv194 = \"il2cpp_codegen_runtime_class_init\"(v150, v118, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_003B;\nL_005A:\n\tgoto L_005D;\n\tv196 = \"il2cpp_codegen_runtime_class_init\"(v154, v118, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_005D:\n\tv121 = Singleton`1::get_Instance /* +1 sharing this address */(*([v76 @ X22_v4 (Il2CppMethodInfo)+C90]));\n\tFluidPhysicsCoupler::RefreshBodies(*([v121 @ X0_v13+38]));\n\tv202 = UnityEngine.Component::get_gameObject(this);\n\tgoto L_007B;\n\tv206 = \"il2cpp_codegen_runtime_class_init\"(v204, v201, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_007B:\n\tUnityEngine.Object::Destroy(v202, 5f);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 85 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Open()
	{
		//IL_00b1: Expected O, but got I
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C900 (UnityEngine.Component::GetComponentInChildren, and 1 more at this address)");
		global::UnityEngine.Object obj = default(global::UnityEngine.Object);
		global::UnityEngine.Object.Destroy(obj);
		global::UnityEngine.GameObject[] array = destroyObjects;
		nint num2 = 0;
		int num3 = 0;
		while (num3 < array.Length)
		{
			global::UnityEngine.Object.DestroyImmediate(array[num3]);
			num3++;
			array = destroyObjects;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v121 @ X0_v13+38]");
		((FluidPhysicsCoupler)0).RefreshBodies();
		global::UnityEngine.GameObject obj2 = base.gameObject;
		global::UnityEngine.Object.Destroy(obj2, 5f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000373")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013448", Offset = "0x1013448", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Lock()
	{
	}
}
