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
	private void Start()
	{
		goalData.displayedCount = goalData.count;
		counterText.text = goalData.displayedCount.ToString("D2");
		_propBlock = new global::UnityEngine.MaterialPropertyBlock();
		global::UnityEngine.MeshRenderer[] array = colorMeshRenderers;
		for (int i = 0; i < array.Length; i++)
		{
			global::UnityEngine.Color baseColor = Singleton<GameManager>.Instance.level.colors[goalData.fluidType];
			global::UnityEngine.Color.RGBToHSV(baseColor, out var h, out var s, out var v);
			global::UnityEngine.Color darkColor = global::UnityEngine.Color.HSVToRGB(h, s, v * 0.75f, hdr: true);
			array[i].GetPropertyBlock(_propBlock, 0);
			_propBlock.SetColor("_Color", baseColor);
			_propBlock.SetColor("_EmissionColor", darkColor);
			array[i].SetPropertyBlock(_propBlock, 0);
			array[i].GetPropertyBlock(_propBlock, 2);
			_propBlock.SetColor("_Color", baseColor);
			_propBlock.SetColor("_EmissionColor", darkColor);
			array[i].SetPropertyBlock(_propBlock, 2);
		}
		float sign = (global::UnityEngine.Random.Range(-1f, 1f) < 0f) ? -1f : 1f;
		float magnitude = global::UnityEngine.Random.Range(2f, 3f);
		global::UnityEngine.Vector2 force = global::UnityEngine.Vector2.right * (sign * magnitude);
		pad.AddForce(force, global::UnityEngine.ForceMode2D.Impulse);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000370")]
	[global::Cpp2ILInjected.Address(RVA = "0x101321C", Offset = "0x101321C", Length = "0xC4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv48 = this.goalData;\n\tv15 = v48.displayedCount - 1;\n\tv48.displayedCount = v15;\n\tgoto L_001B;\n\tv65 = \"Cannot load image: download failed\";\n\tv66 = v65 + 0xE78;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, methodInfo, v22, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64);\n\tv71 = 1;\n\t*([302AAC1]) = v71;\n\tv47 = v13.goalData;\nL_001B:\n\tv69 = \"Cannot load image: download failed\";\n\tv70 = v48 + 0x1C;\n\tv32 = System.Int32::ToString(v70, *([v69 @ X9_v5 (System.String)+E78]));\n\tv94 = TMPro.TMP_Text::set_text(this.counterText, v32);\n\tElasticScale::Pop(this.counterElasticScale);\n\tv50 = this.goalData;\n\tv87 = v50.displayedCount == 0;\n\tif (v87) goto L_0041;\n\treturn;\nL_0041:\n\tLock::Open(this);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 46 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void RecieveParticle()
	{
		goalData.displayedCount--;
		counterText.text = goalData.displayedCount.ToString("D2");
		counterElasticScale.Pop();
		if (goalData.displayedCount == 0)
		{
			Open();
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000371")]
	[global::Cpp2ILInjected.Address(RVA = "0x10131A0", Offset = "0x10131A0", Length = "0x7C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0015;\n\tv17 = \"Cannot load image: download failed\";\n\tv18 = v17 + 0xE78;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302AAC1]) = v37;\nL_0015:\n\tv40 = \"Cannot load image: download failed\";\n\tv42 = this.counterText;\n\tv43 = this.goalData + 0x1C;\n\tv46 = System.Int32::ToString(v43, *([v40 @ X9_v2 (System.String)+E78]));\n\tv57 = *([v42 @ X19_v3 (TMPro.TextMeshPro)]);\n\tv58 = *([v57 @ X8_v4 (Il2CppClass<TMPro.TextMeshPro>)+558]);\n\tv59 = *([v57 @ X8_v4 (Il2CppClass<TMPro.TextMeshPro>)+560]);\n\t// 40 IndirectJump v58 @ X3_v1, v42 @ X19_v3 (TMPro.TextMeshPro), v42 @ X19_v3 (TMPro.TextMeshPro), v46 @ X0_v5 (System.String), v59 @ X2_v3, v58 @ X3_v1, v23 @ X4, v24 @ X5, v25 @ X6, v26 @ X7, v27 @ V0, v28 @ V1, v29 @ V2, v30 @ V3, v31 @ V4, v32 @ V5, v33 @ V6, v34 @ V7\n\tthrow System.NullReferenceException;\n\treturn;\n// 27 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void UpdateCounterText()
	{
		counterText.text = goalData.displayedCount.ToString("D2");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000372")]
	[global::Cpp2ILInjected.Address(RVA = "0x10132E0", Offset = "0x10132E0", Length = "0x168")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv22 = Il2CppMethodInfo;\n\tgoto L_0025;\n\tv29 = Il2CppMethodInfo;\n\tv30 = v29 + 0x780;\n\tv31 = \"il2cpp_codegen_initialize_runtime_metadata\"(v30, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv54 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv55 = v54 + 0xFD8;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v55, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv62 = Il2CppMethodInfo;\n\tv63 = v62 + 0xC90;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv69 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv70 = v69 + 0xA48;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tv50 = 1;\n\t*([302AA73]) = v50;\nL_0025:\n\tv53 = UnityEngine.Component::GetComponentInChildren /* +1 sharing this address */(this, *([v22 @ X22_v1 (Il2CppMethodInfo)+780]));\n\tgoto L_002F;\n\tv65 = \"il2cpp_codegen_runtime_class_init\"(v58, v51, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_002F:\n\tUnityEngine.Object::Destroy(v53);\n\tv147 = this.destroyObjects;\n\tv76 = Il2CppMethodInfo;\n\tgoto L_004A;\nL_003B:\n\tUnityEngine.Object::DestroyImmediate(v147[v115 @ X24_v3 (System.Int32)]);\n\tv115 = v115 + 1;\n\tv147 = this.destroyObjects;\nL_004A:\n\tv84 = v115 >= v147.Length;\n\tif (v84) goto L_005A;\n\tgoto L_003B;\n\tv194 = \"il2cpp_codegen_runtime_class_init\"(v150, v118, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\n\tgoto L_003B;\nL_005A:\n\tgoto L_005D;\n\tv196 = \"il2cpp_codegen_runtime_class_init\"(v154, v118, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_005D:\n\tv121 = Singleton`1::get_Instance /* +1 sharing this address */(*([v76 @ X22_v4 (Il2CppMethodInfo)+C90]));\n\tFluidPhysicsCoupler::RefreshBodies(*([v121 @ X0_v13+38]));\n\tv202 = UnityEngine.Component::get_gameObject(this);\n\tgoto L_007B;\n\tv206 = \"il2cpp_codegen_runtime_class_init\"(v204, v201, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46);\nL_007B:\n\tUnityEngine.Object::Destroy(v202, 5f);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 85 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Open()
	{
		global::UnityEngine.HingeJoint2D joint = GetComponentInChildren<global::UnityEngine.HingeJoint2D>();
		global::UnityEngine.Object.Destroy(joint);
		global::UnityEngine.GameObject[] array = destroyObjects;
		for (int i = 0; i < array.Length; i++)
		{
			global::UnityEngine.Object.DestroyImmediate(array[i]);
		}
		Singleton<GameManager>.Instance.coupler.RefreshBodies();
		global::UnityEngine.Object.Destroy(base.gameObject, 5f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000373")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013448", Offset = "0x1013448", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Lock()
	{
	}
}
