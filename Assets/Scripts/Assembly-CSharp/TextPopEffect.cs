[global::Cpp2ILInjected.Token(Token = "0x20000DD")]
public class TextPopEffect : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000492")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::TMPro.TextMeshProUGUI _text;

	[global::Cpp2ILInjected.Token(Token = "0x4000493")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float letterDelay;

	[global::Cpp2ILInjected.Token(Token = "0x4000494")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float jumpHeight;

	[global::Cpp2ILInjected.Token(Token = "0x4000495")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float transitionStartTime;

	[global::Cpp2ILInjected.Token(Token = "0x4000496")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float scaleDamping;

	[global::Cpp2ILInjected.Token(Token = "0x4000497")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float scaleFrequency;

	[global::Cpp2ILInjected.Token(Token = "0x4000498")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float bounceDamping;

	[global::Cpp2ILInjected.Token(Token = "0x4000499")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float bounceFrequency;

	[global::Cpp2ILInjected.Token(Token = "0x400049A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public bool show;

	[global::Cpp2ILInjected.Token(Token = "0x400049B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::UnityEngine.Vector3[][] cachedVertexPositions;

	[global::Cpp2ILInjected.Token(Token = "0x17000046")]
	private global::TMPro.TextMeshProUGUI text
	{
		[global::Cpp2ILInjected.Token(Token = "0x60003EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x101967C", Offset = "0x101967C", Length = "0xE0")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302AAC8]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_002D;\n\tv82 = this + 0x20;\n\tv25 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv27 = *([v25 @ X0_v23+E0]) == 0;\n\tif (v27) goto L_0039;\nL_0019:\n\tv58 = UnityEngine.Object::op_Implicit(v48);\n\tv69 = v58 == 0;\n\tif (v69) goto L_003E;\nL_0025:\n\treturn *([v82 @ X20_v7]);\nL_002D:\n\t*([v16 @ X20_v1+AC8]) = 1;\n\tv82 = this + 0x20;\n\tv47 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv75 = *([v47 @ X0_v17+E0]) == 0;\n\tv51 = ~v75;\n\tif (v51) goto L_0019;\nL_0039:\n\tv72 = UnityEngine.Object::op_Implicit(v60);\n\tv102 = v72 == 0;\n\tv80 = ~v102;\n\tif (v80) goto L_0025;\nL_003E:\n\tv96 = Il2CppMethodInfo;\n\tv100 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v96 @ X8_v3 (Il2CppMethodInfo)+760]));\n\tthis._text = v100;\n\tv122 = 0xF3F1B4(v95, v100, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\treturn *([v95 @ X20_v2]);\n// 52 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		get
		{
			if (_text == null)
			{
				_text = GetComponent<global::TMPro.TextMeshProUGUI>();
			}
			return _text;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F0")]
	[global::Cpp2ILInjected.Address(RVA = "0x101975C", Offset = "0x101975C", Length = "0x150")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302A000;\n\tv22 = *([302AAC9]) & 1;\n\tv23 = v22 == 0;\n\tif (v23) goto L_0052;\n\tv28 = *([302AAC8]) & 1;\n\tv29 = v28 == 0;\n\tif (v29) goto L_0062;\nL_0018:\n\tv88 = this + 0x20;\n\tgoto L_001E;\nL_001E:\n\tv91 = System.Collections.Generic.NullableComparer`1;\n\tv93 = Il2CppMethodInfo;\n\tv97 = UnityEngine.Object::op_Implicit(v77);\n\tv107 = v97 == 0;\n\tv108 = ~v107;\n\tif (v108) goto L_0032;\n\tv112 = Il2CppMethodInfo;\n\tv116 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v112 @ X8_v12 (Il2CppMethodInfo)+760]));\n\tthis._text = v116;\n\tv120 = 0xF3F1B4(v88, v116, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\nL_0032:\n\tv122 = this._text;\n\tv124 = new *([v91 @ X23_v1 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D60])();\n\tSystem.Action`1<System.Object>::.ctor(v124, this, *([v93 @ X22_v6 (Il2CppMethodInfo)+AE0]));\n\tv130 = this._text == 0;\n\tif (v130) goto L_006D;\n\tv131 = *([v122 @ X20_v8 (TMPro.TextMeshProUGUI)]);\n\t// 74 IndirectJump [v131 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+618], this._text (TMPro.TextMeshProUGUI), this._text (TMPro.TextMeshProUGUI), v124 @ X0_v22, [v131 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+620], [v131 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+618], v36 @ X4, v37 @ X5, v38 @ X6, v39 @ X7, v40 @ V0, v41 @ V1, v42 @ V2, v43 @ V3, v44 @ V4, v45 @ V5, v46 @ V6, v47 @ V7\nL_0052:\n\t*([v20 @ X20_v1+AC9]) = 1;\n\tv104 = *([302AAC8]) & 1;\n\tv105 = v104 == 0;\n\tv53 = ~v105;\n\tif (v53) goto L_0018;\nL_0062:\n\t*([302AAC8]) = 1;\n\tv88 = this + 0x20;\n\tgoto L_001E;\n\tv76 = \"il2cpp_codegen_runtime_class_init\"(v98, methodInfo, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tgoto L_001E;\nL_006D:\n\tthrow v124;\n// 74 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnEnable()
	{
		text.OnPreRenderText += OnPreRenderText;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F1")]
	[global::Cpp2ILInjected.Address(RVA = "0x10198AC", Offset = "0x10198AC", Length = "0x150")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = 0x302A000;\n\tv22 = *([302AACA]) & 1;\n\tv23 = v22 == 0;\n\tif (v23) goto L_0052;\n\tv28 = *([302AAC8]) & 1;\n\tv29 = v28 == 0;\n\tif (v29) goto L_0062;\nL_0018:\n\tv88 = this + 0x20;\n\tgoto L_001E;\nL_001E:\n\tv91 = System.Collections.Generic.NullableComparer`1;\n\tv93 = Il2CppMethodInfo;\n\tv97 = UnityEngine.Object::op_Implicit(v77);\n\tv107 = v97 == 0;\n\tv108 = ~v107;\n\tif (v108) goto L_0032;\n\tv112 = Il2CppMethodInfo;\n\tv116 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v112 @ X8_v12 (Il2CppMethodInfo)+760]));\n\tthis._text = v116;\n\tv120 = 0xF3F1B4(v88, v116, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\nL_0032:\n\tv122 = this._text;\n\tv124 = new *([v91 @ X23_v1 (Il2CppClass<System.Collections.Generic.NullableComparer`1>)+D60])();\n\tSystem.Action`1<System.Object>::.ctor(v124, this, *([v93 @ X22_v6 (Il2CppMethodInfo)+AE0]));\n\tv130 = this._text == 0;\n\tif (v130) goto L_006D;\n\tv131 = *([v122 @ X20_v8 (TMPro.TextMeshProUGUI)]);\n\t// 74 IndirectJump [v131 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+628], this._text (TMPro.TextMeshProUGUI), this._text (TMPro.TextMeshProUGUI), v124 @ X0_v22, [v131 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+630], [v131 @ X8_v10 (Il2CppClass<TMPro.TextMeshProUGUI>)+628], v36 @ X4, v37 @ X5, v38 @ X6, v39 @ X7, v40 @ V0, v41 @ V1, v42 @ V2, v43 @ V3, v44 @ V4, v45 @ V5, v46 @ V6, v47 @ V7\nL_0052:\n\t*([v20 @ X20_v1+ACA]) = 1;\n\tv104 = *([302AAC8]) & 1;\n\tv105 = v104 == 0;\n\tv53 = ~v105;\n\tif (v53) goto L_0018;\nL_0062:\n\t*([302AAC8]) = 1;\n\tv88 = this + 0x20;\n\tgoto L_001E;\n\tv76 = \"il2cpp_codegen_runtime_class_init\"(v98, methodInfo, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tgoto L_001E;\nL_006D:\n\tthrow v124;\n// 74 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnDisable()
	{
		text.OnPreRenderText -= OnPreRenderText;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
	[global::Cpp2ILInjected.Address(RVA = "0x10199FC", Offset = "0x10199FC", Length = "0x150")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv31 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv32 = v31 + 0xF28;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, textInfo, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv53 = CollectParticleData[];\n\tv54 = v53 + 0x650;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, textInfo, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv51 = 1;\n\t*([302AAA0]) = v51;\nL_001E:\n\tv55 = textInfo.meshInfo;\n\tv165 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv168 = \"SzArrayNew\"(*([v165 @ X9_v3 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+F28]), v55.Length, methodInfo, v62, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv163 = this + 0x48;\n\tthis.cachedVertexPositions = v168;\n\tv142 = 0xF3F1B4(v163, v168, methodInfo, v62, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv191 = textInfo.meshInfo;\n\tv247 = CollectParticleData[];\nL_0033:\n\t;\n\tv58 = v161 >= v191.Length;\n\tif (v58) goto L_008D;\n\tv157 = *([v191 @ X8_v7 (TMPro.TMP_MeshInfo[])+v123 @ X24_v5 (System.Int32)]);\n\tv144 = \"SzArrayNew\"(*([v247 @ X22_v4 (Il2CppClass<CollectParticleData[]>)+650]), v157.normals, *([v141 @ X0_v16 (System.Array)+18]), 0, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv264 = this.cachedVertexPositions + v126;\n\t*([v264 @ X0_v14]) = v144;\n\tv145 = 0xF3F1B4(v264, v144, *([v141 @ X0_v16 (System.Array)+18]), 0, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv158 = textInfo.meshInfo;\n\tv136 = this.cachedVertexPositions;\n\tv141 = *([v158 @ X8_v11 (TMPro.TMP_MeshInfo[])+v123 @ X24_v5 (System.Int32)]);\n\tSystem.Array::Copy(*([v158 @ X8_v11 (TMPro.TMP_MeshInfo[])+v123 @ X24_v5 (System.Int32)]), *([v136 @ X9_v9 (UnityEngine.Vector3[][])+v126 @ X23_v5 (System.Int32)]), *([v141 @ X0_v16 (System.Array)+18]));\n\tv161 = v161 + 1;\n\tv191 = textInfo.meshInfo;\n\tv126 = v126 + 8;\n\tv123 = v123 + 0x50;\n\tv269 = textInfo.meshInfo == 0;\n\tv147 = ~v269;\n\tif (v147) goto L_0033;\n\tthrow System.NullReferenceException;\nL_008D:\n\treturn;\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 104 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void CacheVertexPositions(global::TMPro.TMP_TextInfo textInfo)
	{
		global::TMPro.TMP_MeshInfo[] meshInfo = textInfo.meshInfo;
		cachedVertexPositions = new global::UnityEngine.Vector3[meshInfo.Length][];
		for (int i = 0; i < meshInfo.Length; i++)
		{
			global::UnityEngine.Vector3[] vertices = meshInfo[i].vertices;
			cachedVertexPositions[i] = new global::UnityEngine.Vector3[vertices.Length];
			global::System.Array.Copy(vertices, cachedVertexPositions[i], vertices.Length);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
	[global::Cpp2ILInjected.Address(RVA = "0x1019B4C", Offset = "0x1019B4C", Length = "0x3C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = textInfo.characterCount < 1;\n\tif (v20) goto L_0025;\nL_0025:\n\treturn;\n\tv46 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnPreRenderText(global::TMPro.TMP_TextInfo textInfo)
	{
		if (textInfo.characterCount < 1)
		{
			return;
		}
		CacheVertexPositions(textInfo);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
	[global::Cpp2ILInjected.Address(RVA = "0x1019B88", Offset = "0x1019B88", Length = "0x1C0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.show = 1;\n\tv22 = UnityEngine.Time::get_time();\n\tthis.transitionStartTime = v22;\n\tv25 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv27 = *([302AAC8]) & 1;\n\tv28 = v27 == 0;\n\tif (v28) goto L_0031;\n\tv117 = this + 0x20;\n\tv32 = *([v25 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv34 = *([v32 @ X0_v52+E0]) == 0;\n\tif (v34) goto L_003C;\nL_001F:\n\tv110 = Il2CppMethodInfo + 0x760;\n\tv66 = UnityEngine.Object::op_Implicit(v52);\n\tv77 = v66 == 0;\n\tif (v77) goto L_0046;\nL_0026:\n\tv115 = this._text;\n\tv94 = *([v117 @ X20_v3]) == 0;\n\tv95 = ~v94;\n\tif (v95) goto L_004E;\n\tgoto L_0096;\nL_0031:\n\t*([302AAC8]) = 1;\n\tv117 = this + 0x20;\n\tv59 = *([v25 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv84 = *([v59 @ X0_v46+E0]) == 0;\n\tv55 = ~v84;\n\tif (v55) goto L_001F;\nL_003C:\n\tv110 = Il2CppMethodInfo + 0x760;\n\tv82 = UnityEngine.Object::op_Implicit(v67);\n\tv107 = v82 == 0;\n\tv89 = ~v107;\n\tif (v89) goto L_0026;\nL_0046:\n\tv105 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v97 @ X24_v4]));\n\tthis._text = v105;\n\tv128 = 0xF3F1B4(v102, v105, v39, v40, v41, v42, v43, v44, v22, v45, v46, v47, v48, v49, v50, v51);\n\tv115 = *([v102 @ X20_v5]);\nL_004E:\n\tv118 = *([v115 @ X0_v4]);\n\t*([v118 @ X8_v4+7D8])(v123, v115, 0, 0, *([v118 @ X8_v4+7E0]), v41, v42, v43, v44, v22, v45, v46, v47, v48, v49, v50, v51);\n\tv125 = *([302AAC8]) & 1;\n\tv126 = v125 == 0;\n\tif (v126) goto L_007C;\n\tv158 = this._text;\n\tv152 = *([v25 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv154 = *([v152 @ X0_v29+E0]) == 0;\n\tif (v154) goto L_0086;\nL_005F:\n\tv168 = UnityEngine.Object::op_Implicit(v158);\n\tv205 = v168 == 0;\n\tif (v205) goto L_008D;\nL_0063:\n\tv193 = this._text;\nL_0068:\n\tTextPopEffect::CacheVertexPositions(this, *([v193 @ X8_v11+368]));\n\tTextPopEffect::Update(this);\n\treturn;\nL_007C:\n\t*([302AAC8]) = 1;\n\tv158 = this._text;\n\tv165 = *([v25 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv210 = *([v165 @ X0_v21+E0]) == 0;\n\tv161 = ~v210;\n\tif (v161) goto L_005F;\nL_0086:\n\tv208 = UnityEngine.Object::op_Implicit(v169);\n\tv222 = v208 == 0;\n\tv212 = ~v222;\n\tif (v212) goto L_0063;\nL_008D:\n\tv220 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v110 @ X24_v2]));\n\tthis._text = v220;\n\tv147 = 0xF3F1B4(v117, v220, 0, *([v118 @ X8_v4+7E0]), v41, v42, v43, v44, v22, v45, v46, v47, v48, v49, v50, v51);\n\tv193 = this._text;\n\tv228 = *([v117 @ X20_v3]) == 0;\n\tv141 = ~v228;\n\tif (v141) goto L_0068;\nL_0096:\n\tthrow System.NullReferenceException;\n// 83 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void StartTransition()
	{
		show = true;
		transitionStartTime = global::UnityEngine.Time.time;
		text.ForceMeshUpdate(false, false);
		CacheVertexPositions(text.textInfo);
		Update();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
	[global::Cpp2ILInjected.Address(RVA = "0x1019D48", Offset = "0x1019D48", Length = "0x62C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv44 = ~this.show;\n\tif (v44) goto L_0282;\n\tv47 = this.cachedVertexPositions == 0;\n\tif (v47) goto L_0282;\n\tv259 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv261 = *([302AAC8]) & 1;\n\tv262 = v261 == 0;\n\tif (v262) goto L_003D;\n\tv223 = this + 0x20;\n\tv371 = *([v259 @ X22_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv373 = *([v371 @ X0_v86+E0]) == 0;\n\tif (v373) goto L_0049;\nL_002D:\n\tv394 = UnityEngine.Object::op_Implicit(v384);\n\tv405 = v394 == 0;\n\tif (v405) goto L_004E;\nL_0031:\n\tv437 = this._text;\n\tv420 = *([v223 @ X21_v4]) == 0;\n\tv421 = ~v420;\n\tif (v421) goto L_005A;\n\tgoto L_026C;\nL_003D:\n\t*([302AAC8]) = 1;\n\tv223 = this + 0x20;\n\tv383 = *([v259 @ X22_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv411 = *([v383 @ X0_v80+E0]) == 0;\n\tv389 = ~v411;\n\tif (v389) goto L_002D;\nL_0049:\n\tv408 = UnityEngine.Object::op_Implicit(v396);\n\tv434 = v408 == 0;\n\tv417 = ~v434;\n\tif (v417) goto L_0031;\nL_004E:\n\tv428 = Il2CppMethodInfo;\n\tv432 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v428 @ X8_v50 (Il2CppMethodInfo)+760]));\n\tthis._text = v432;\n\tv453 = 0xF3F1B4(v425, v432, v201, v205, v377, v378, v379, v380, v194, v131, v127, v75, v63, v59, v107, v381);\n\tv437 = *([v425 @ X21_v5]);\nL_005A:\n\tv443 = *([v437 @ X0_v4]);\n\tv206 = *([v443 @ X8_v7+7E0]);\n\t*([v443 @ X8_v7+7D8])(v448, v437, 0, 0, *([v443 @ X8_v7+7E0]), v377, v378, v379, v380, v194, v131, v127, v75, v63, v59, v107, v381);\n\tv450 = *([302AAC8]) & 1;\n\tv451 = v450 == 0;\n\tif (v451) goto L_007B;\n\tv636 = this._text;\n\tv628 = *([v259 @ X22_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv630 = *([v628 @ X0_v63+E0]) == 0;\n\tif (v630) goto L_0085;\nL_006B:\n\tv644 = UnityEngine.Object::op_Implicit(v636);\n\tv654 = v644 == 0;\n\tif (v654) goto L_008A;\nL_006F:\n\tv619 = this._text;\n\tv663 = *([v223 @ X21_v4]) == 0;\n\tv603 = ~v663;\n\tif (v603) goto L_0096;\n\tgoto L_026C;\nL_007B:\n\t*([302AAC8]) = 1;\n\tv636 = this._text;\n\tv635 = *([v259 @ X22_v3 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv659 = *([v635 @ X0_v58+E0]) == 0;\n\tv639 = ~v659;\n\tif (v639) goto L_006B;\nL_0085:\n\tv657 = UnityEngine.Object::op_Implicit(v646);\n\tv674 = v657 == 0;\n\tv661 = ~v674;\n\tif (v661) goto L_006F;\nL_008A:\n\tv668 = Il2CppMethodInfo;\n\tv672 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v668 @ X8_v39 (Il2CppMethodInfo)+760]));\n\tthis._text = v672;\n\tv582 = 0xF3F1B4(v223, v672, 0, v206, v377, v378, v379, v380, v194, v131, v127, v75, v63, v59, v107, v381);\n\tv619 = this._text;\nL_0096:\n\tv198 = this._text.m_textInfo;\n\tv596 = this._text.m_textInfo.characterCount;\n\tv559 = UnityEngine.Time::get_time();\n\tv500 = *([v198 @ X26_v4+18]) < 1;\n\tif (v500) goto L_01FD;\n\tv496 = this._text.m_textInfo.characterInfo;\n\tgoto L_00BA;\nL_00B3:\n\tv496 = v496 + 0x178;\n\tv720 = v596 - 1;\n\tv723 = v596 == 1;\n\tif (v723) goto L_01FD;\nL_00BA:\n\t;\n\tv766 = *([v496 @ X24_v15+194]) == 0;\n\tif (v766) goto L_00B3;\n\tv486 = *([v496 @ X24_v15+58]);\n\tv484 = this.letterDelay * v706;\n\tv883 = this.transitionStartTime + v484;\n\tv482 = v559 - v883;\n\tv540 = v482 < 0;\n\tif (v540) goto L_00E4;\n\tv899 = v482 * this.scaleFrequency;\n\tv900 = 0x274A170(v910, v575, 0, v206, v377, v378, v379, v380, v899, v484, this.letterDelay, v685, v682, v681, v693, v381);\n\tv918 = this.scaleDamping * v482;\n\tv919 = -v918;\n\tv910 = 0x274A548(v900, v575, 0, v206, v377, v378, v379, v380, v919, v484, this.letterDelay, v685, v682, v681, v693, v381);\n\tv928 = this.scaleDamping / this.scaleFrequency;\n\tv929 = v928 * v899;\n\tv930 = v484 + v929;\n\tv931 = v919 * v930;\n\tv908 = 1f - v931;\nL_00E4:\n\tv913 = v482 * this.bounceFrequency;\n\tv914 = 0x274B058(v910, v575, 0, v206, v377, v378, v379, v380, v913, v484, this.letterDelay, v685, v682, v681, v693, v381);\n\tv920 = this.bounceDamping * v482;\n\tv560 = -v920;\n\tv910 = 0x274A548(v914, v575, 0, v206, v377, v378, v379, v380, v560, v484, this.letterDelay, v685, v682, v681, v693, v381);\n\tv620 = this.cachedVertexPositions;\n\tv621 = v620[v486 @ X25_v9];\n\tv568 = *([v496 @ X24_v15+6C]) & 0xFFFFFFFF;\n\tv469 = *([v496 @ X24_v15+6C]) + 1;\n\tv467 = v568 + 2;\n\tv465 = v568 + 3;\n\tv984 = v486 * 0x50;\n\tv985 = *([v198 @ X26_v4+60]) + v984;\n\tv986 = v621.Length < *([v496 @ X24_v15+6C]);\n\tv987 = ~v986;\n\tv996 = ~v987;\n\tv777 = ~v996;\n\tif (v777) goto L_015F;\n\tgoto L_015F;\nL_015F:\n\tv773 = v620[v486 @ X25_v9] + 0x20;\n\tv1003 = *([v496 @ X24_v15+6C]) * 0xC;\n\tv772 = v773 + v1003;\n\tv1005 = v469 * 0xC;\n\tv1006 = v773 + v1005;\n\tv1008 = *([v772 @ X17_v6+8]) + *([v1006 @ X13_v7+8]);\n\tv1009 = v467 * 0xC;\n\tv780 = v773 + v1009;\n\tv1011 = v1008 + *([v780 @ X14_v7+8]);\n\tv1012 = v465 * 0xC;\n\tv779 = v773 + v1012;\n\tv1014 = v1011 + *([v779 @ X15_v7+8]);\n\tv1017 = *([v772 @ X17_v6]) + *([v1006 @ X13_v7]);\n\tv1019 = v1017 + *([v780 @ X14_v7]);\n\tv1021 = v1019 + *([v779 @ X15_v7]);\n\tv874 = v1021 * 0;\n\tv792 = v1014 * v489;\n\tv1022 = *([v772 @ X17_v6+8]) - v792;\n\tv1023 = v908 * v1022;\n\tv1024 = v792 + v1023;\n\tv878 = *([v496 @ X24_v15+6C]) * 0xC;\n\tv783 = *([v985 @ X10_v7+30]) + v878;\n\tv1025 = *([v772 @ X17_v6]) - v874;\n\tv1026 = v1025 * v1027;\n\tv769 = v874 + v1026;\n\t*([v783 @ X13_v8+20]) = v769;\n\t*([v783 @ X13_v8+28]) = v1024;\n\tv784 = v568 + 1;\n\tv789 = v784 << 1;\n\tv1032 = v784 + v789;\n\tv1033 = v1032 << 2;\n\tv781 = v620[v486 @ X25_v9] + v1033;\n\tv1035 = *([v781 @ X14_v8+28]) - v792;\n\tv1036 = v908 * v1035;\n\tv1037 = v792 + v1036;\n\tv785 = *([v985 @ X10_v7+30]) + v1033;\n\tv1039 = *([v781 @ X14_v8+20]) - v874;\n\tv1040 = v1039 * v1027;\n\tv1041 = v874 + v1040;\n\t*([v785 @ X13_v13+20]) = v1041;\n\t*([v785 @ X13_v13+28]) = v1037;\n\tv786 = v568 + 2;\n\tv790 = v786 << 1;\n\tv1045 = v786 + v790;\n\tv1046 = v1045 << 2;\n\tv782 = v620[v486 @ X25_v9] + v1046;\n\tv1048 = *([v782 @ X14_v9+28]) - v792;\n\tv1049 = v908 * v1048;\n\tv1050 = v792 + v1049;\n\tv787 = *([v985 @ X10_v7+30]) + v1046;\n\tv1052 = *([v782 @ X14_v9+20]) - v874;\n\tv1053 = v1052 * v1027;\n\tv682 = v874 + v1053;\n\t*([v787 @ X13_v18+20]) = v682;\n\t*([v787 @ X13_v18+28]) = v1050;\n\tv875 = v568 + 3;\n\tv887 = v875 << 1;\n\tv1058 = v875 + v887;\n\tv1059 = v1058 << 2;\n\tv893 = v620[v486 @ X25_v9] + v1059;\n\tv1061 = *([v893 @ X8_v36+28]) - v792;\n\tv1062 = v908 * v1061;\n\tv700 = v792 + v1062;\n\tv891 = *([v985 @ X10_v7+30]) + v1059;\n\tv1065 = *([v893 @ X8_v36+20]) - v874;\n\tv685 = v1065 * v1027;\n\tv717 = v874 + v685;\n\t*([v891 @ X9_v19+20]) = v717;\n\t*([v891 @ X9_v19+28]) = v700;\n\tv706 = v706 + 1;\n\tgoto L_00B3;\nL_01FD:\n\tv236 = this._text.m_textInfo.meshInfo;\n\tv726 = Facebook.Unity.Windows.IWindowsFacebook;\nL_0206:\n\t;\n\tv159 = v220 >= *([v236 @ X8_v13+18]);\n\tif (v159) goto L_0282;\n\tv623 = v236 + 0x20;\n\tv570 = v220 * 0x50;\n\tv894 = v220 * 0x50;\n\tv895 = v623 + v894;\n\tUnityEngine.Mesh::set_vertices(*([v623 @ X8_v14+v570 @ X9_v8 (System.Int32)]), *([v895 @ X8_v15+10]));\n\tv916 = *([302AAC8]) & 1;\n\tv917 = v916 == 0;\n\tif (v917) goto L_0236;\n\tv932 = this._text;\n\tv922 = *([v726 @ X28_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv924 = *([v922 @ X0_v35+E0]) == 0;\n\tif (v924) goto L_0240;\nL_0228:\n\tv942 = UnityEngine.Object::op_Implicit(v932);\n\tv952 = v942 == 0;\n\tif (v952) goto L_0245;\nL_022C:\n\tv626 = this._text.m_textInfo.meshInfo;\n\tv960 = *([v198 @ X26_v4+60]) == 0;\n\tv613 = ~v960;\n\tif (v613) goto L_025C;\n\tgoto L_026C;\nL_0236:\n\t*([302AAC8]) = 1;\n\tv932 = this._text;\n\tv935 = *([v726 @ X28_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv956 = *([v935 @ X0_v30+E0]) == 0;\n\tv937 = ~v956;\n\tif (v937) goto L_0228;\nL_0240:\n\tv955 = UnityEngine.Object::op_Implicit(v943);\n\tv971 = v955 == 0;\n\tv958 = ~v971;\n\tif (v958) goto L_022C;\nL_0245:\n\tv965 = Il2CppMethodInfo;\n\tv969 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v965 @ X8_v22 (Il2CppMethodInfo)+760]));\n\tthis._text = v969;\n\tv589 = 0xF3F1B4(v223, v969, 0, v206, v377, v378, v379, v380, v195, v700, v699, v685, v682, v681, v693, v381);\n\tv626 = this._text.m_textInfo.meshInfo;\nL_025C:\n\tv590 = this._text;\n\tv977 = v220 * 0x50;\n\tv978 = v626 + v977;\n\tv979 = this._text->klass;\n\tv206 = this._text->klass->vtable[107];\n\t*([v979 @ X8_v19+7E8])(v580, v590, *([v978 @ X8_v18+20]), v220, *([v979 @ X8_v19+7F0]), v377, v378, v379, v380, v195, v700, v699, v685, v682, v681, v693, v381);\n\tv220 = v220 + 1;\n\tv236\n// ... truncated")]
	private void Update()
	{
		if (!show || cachedVertexPositions == null)
		{
			return;
		}
		global::TMPro.TMP_TextInfo textInfo = text.textInfo;
		float time = global::UnityEngine.Time.time;
		for (int i = 0; i < textInfo.characterCount; i++)
		{
			global::TMPro.TMP_CharacterInfo characterInfo = textInfo.characterInfo[i];
			if (!characterInfo.isVisible)
			{
				continue;
			}
			float t = time - (transitionStartTime + letterDelay * i);
			float scaleFactor = 0f;
			float bounceOffset = 0f;
			if (t >= 0f)
			{
				float decay = global::UnityEngine.Mathf.Exp(-scaleDamping * t);
				scaleFactor = 1f - decay * (1f + scaleDamping * t);
				bounceOffset = jumpHeight * global::UnityEngine.Mathf.Sin(t * bounceFrequency) * global::UnityEngine.Mathf.Exp(-bounceDamping * t);
			}
			int materialIndex = characterInfo.materialReferenceIndex;
			int vertexIndex = characterInfo.vertexIndex;
			global::UnityEngine.Vector3[] sourceVertices = cachedVertexPositions[materialIndex];
			global::UnityEngine.Vector3[] destVertices = textInfo.meshInfo[materialIndex].vertices;
			global::UnityEngine.Vector3 center = (sourceVertices[vertexIndex] + sourceVertices[vertexIndex + 1] + sourceVertices[vertexIndex + 2] + sourceVertices[vertexIndex + 3]) * 0.25f;
			for (int v = 0; v < 4; v++)
			{
				global::UnityEngine.Vector3 offsetFromCenter = sourceVertices[vertexIndex + v] - center;
				global::UnityEngine.Vector3 newPos = center + offsetFromCenter * scaleFactor;
				newPos.y += bounceOffset;
				destVertices[vertexIndex + v] = newPos;
			}
		}
		for (int i = 0; i < textInfo.meshInfo.Length; i++)
		{
			textInfo.meshInfo[i].mesh.vertices = textInfo.meshInfo[i].vertices;
			text.UpdateGeometry(textInfo.meshInfo[i].mesh, i);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
	[global::Cpp2ILInjected.Address(RVA = "0x101A374", Offset = "0x101A374", Length = "0x20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.letterDelay = 524288.1197265625d;\n\tthis.scaleDamping = *([2875A90]);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 5 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public TextPopEffect()
	{
		letterDelay = 0.05f;
		jumpHeight = 10f;
		scaleDamping = 5f;
	}
}
