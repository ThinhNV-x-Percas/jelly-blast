[global::Cpp2ILInjected.Token(Token = "0x20000CB")]
public class SDFCollider : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400045C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.LayerMask collisionMask;

	[global::Cpp2ILInjected.Token(Token = "0x400045D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.RenderTexture outputSDF;

	[global::Cpp2ILInjected.Token(Token = "0x400045E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public int maxResolution;

	[global::Cpp2ILInjected.Token(Token = "0x400045F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public global::UnityEngine.Vector2 sdfCenter;

	[global::Cpp2ILInjected.Token(Token = "0x4000460")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private SDFTextureGenerator generator;

	[global::Cpp2ILInjected.Token(Token = "0x4000461")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float sourceValueThreshold;

	[global::Cpp2ILInjected.Token(Token = "0x4000462")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public SDFTextureGenerator.DownSampling downSampling;

	[global::Cpp2ILInjected.Token(Token = "0x4000463")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public SDFTextureGenerator.Precision precision;

	[global::Cpp2ILInjected.Token(Token = "0x4000464")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public global::UnityEngine.Shader whiteMaskShader;

	[global::Cpp2ILInjected.Token(Token = "0x600039F")]
	[global::Cpp2ILInjected.Address(RVA = "0x101566C", Offset = "0x101566C", Length = "0x700")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_003E;\n\tv39 = Il2CppMethodInfo;\n\tv40 = v39 + 0x8D8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv66 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv67 = v66 + 0x520;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v67, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv86 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv87 = v86 + 0xFD8;\n\tv88 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv93 = System.Runtime.Serialization.ObjectHolderList;\n\tv94 = v93 + 0xB00;\n\tv95 = \"il2cpp_codegen_initialize_runtime_metadata\"(v94, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv97 = System.Runtime.Serialization.ObjectHolderList;\n\tv98 = v97 + 0xCE8;\n\tv99 = \"il2cpp_codegen_initialize_runtime_metadata\"(v98, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv280 = Il2CppMethodInfo;\n\tv281 = v280 + 0xC90;\n\tv282 = \"il2cpp_codegen_initialize_runtime_metadata\"(v281, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv288 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv289 = v288 + 0xA48;\n\tv290 = \"il2cpp_codegen_initialize_runtime_metadata\"(v289, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv355 = \"Parent table name is missing in relation '{0}'.\";\n\tv356 = v355 + 0xDE8;\n\tv357 = \"il2cpp_codegen_initialize_runtime_metadata\"(v356, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv360 = \"Parent table name is missing in relation '{0}'.\";\n\tv361 = v360 + 0xDF0;\n\tv362 = \"il2cpp_codegen_initialize_runtime_metadata\"(v361, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv373 = Il2CppFieldInfo;\n\tv374 = v373 + 0x960;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v374, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv59 = 1;\n\t*([302AA87]) = v59;\nL_003E:\n\tgoto L_0044;\n\tv69 = System.Xml.ValidateNames;\n\tv70 = v69 + 0x98;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, coupler, methodInfo, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55);\n\tv74 = 1;\n\t*([2DD4424]) = v74;\nL_0044:\n\tv75 = Il2CppMethodInfo;\n\tv77 = System.Xml.ValidateNames;\n\tv79 = *([v77 @ X8_v5 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv80 = *([v79 @ X8_v7+B8]);\n\tthis.sdfCenter = *([v80 @ X8_v8]);\n\tgoto L_0053;\n\tv89 = \"il2cpp_codegen_runtime_class_init\"(v82, coupler, methodInfo, v43, v44, v45, v46, v47, v81, v49, v50, v51, v52, v53, v54, v55);\nL_0053:\n\tv92 = Singleton`1::get_Instance /* +1 sharing this address */(*([v75 @ X22_v2 (Il2CppMethodInfo)+C90]));\n\tv100 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv103 = *([v100 @ X24_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv105 = *([v103 @ X0_v9+E0]) == 0;\n\tif (v105) goto L_0069;\n\tv286 = UnityEngine.Object::op_Inequality(*([v92 @ X0_v6+78]), 0);\n\tv291 = ~v286;\n\tv292 = ~v291;\n\tif (v292) goto L_0073;\n\tgoto L_007E;\nL_0069:\n\tv296 = UnityEngine.Object::op_Inequality(*([v92 @ X0_v6+78]), 0);\n\tv359 = ~v296;\n\tif (v359) goto L_007E;\nL_0073:\n\tLevel::GetColliderYExtents(*([v92 @ X0_v6+78]), &v365 @ stack_-78_v20 (System.Single), &v366 @ stack_-7C_v4 (System.Single));\n\tv395 = v365 + v366;\n\tv363 = v395 * 0.5f;\n\tthis.sdfCenter.y = v363;\nL_007E:\n\tv377 = coupler.halfBounds + coupler.halfBounds;\n\tv196 = coupler.halfBounds.y + coupler.halfBounds.y;\n\tv378 = v377 / v196;\n\tv392 = v377 >= v196;\n\tif (v392) goto L_00B8;\n\tv396 = *([2DD4417]) == 0;\n\tif (v396) goto L_00E4;\n\tv416 = v378 * this.maxResolution;\n\tv399 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv401 = *([v399 @ X8_v66 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv403 = *([v401 @ X0_v102+E0]) == 0;\n\tif (v403) goto L_00F1;\nL_009C:\n\tv428 = 0x274AA58(&v511 @ stack_-78_v17 (System.Double), v237, v226, v43, v44, v45, v46, v47, v416, coupler.halfBounds.y, v50, v51, v52, v53, v54, v55);\n\tv469 = v416 >= 0;\n\tif (v469) goto L_0108;\nL_00B2:\n\tv525 = v510 != -0.5d;\n\tif (v525) goto L_0154;\n\tgoto L_010D;\nL_00B8:\n\tv397 = *([2DD4417]) == 0;\n\tif (v397) goto L_011E;\n\tv438 = this.maxResolution / v378;\n\tv408 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv410 = *([v408 @ X8_v49 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv412 = *([v410 @ X0_v85+E0]) == 0;\n\tif (v412) goto L_012B;\nL_00C4:\n\tv450 = 0x274AA58(&v576 @ stack_-78_v11 (System.Double), v237, v226, v43, v44, v45, v46, v47, v438, coupler.halfBounds.y, v50, v51, v52, v53, v54, v55);\n\tv484 = v438 >= 0;\n\tif (v484) goto L_0142;\nL_00DA:\n\tv590 = v575 != -0.5d;\n\tif (v590) goto L_0157;\n\tgoto L_0147;\nL_00E4:\n\t*([2DD4417]) = 1;\n\tv416 = v378 * this.maxResolution;\n\tv435 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv419 = *([v435 @ X8_v60 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv437 = *([v419 @ X0_v97+E0]) == 0;\n\tv421 = ~v437;\n\tif (v421) goto L_009C;\nL_00F1:\n\tv474 = 0x274AA58(&v511 @ stack_-78_v17 (System.Double), v237, v226, v43, v44, v45, v46, v47, v429, coupler.halfBounds.y, v50, v51, v52, v53, v54, v55);\n\tv491 = v429 < 0;\n\tif (v491) goto L_00B2;\nL_0108:\n\tv552 = v537 != 0.5d;\n\tif (v552) goto L_015A;\nL_010D:\n\tv657 = v198 + v652;\n\tv658 = v656 & 1;\n\tv660 = v658 == 0;\n\tv663 = ~v660;\n\tif (v663) goto L_FFFFFFFF;\n\tgoto L_0119;\nL_0119:\n\tgoto L_016A;\nL_011E:\n\t*([2DD4417]) = 1;\n\tv438 = this.maxResolution / v378;\n\tv457 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv441 = *([v457 @ X8_v43 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv459 = *([v441 @ X0_v80+E0]) == 0;\n\tv443 = ~v459;\n\tif (v443) goto L_00C4;\nL_012B:\n\tv489 = 0x274AA58(&v576 @ stack_-78_v11 (System.Double), v237, v226, v43, v44, v45, v46, v47, v451, coupler.halfBounds.y, v50, v51, v52, v53, v54, v55);\n\tv556 = v451 < 0;\n\tif (v556) goto L_00DA;\nL_0142:\n\tv617 = v602 != 0.5d;\n\tif (v617) goto L_0179;\nL_0147:\n\tv715 = v198 + v710;\n\tv716 = v714 & 1;\n\tv718 = v716 == 0;\n\tv721 = ~v718;\n\tif (v721) goto L_FFFFFFFF;\n\tgoto L_0153;\nL_0153:\n\tgoto L_0188;\nL_0154:\n\tv623 = v509 + -0.5d;\n\tv198 = System.Math::Ceiling(v623);\n\tgoto L_016A;\nL_0157:\n\tv633 = v574 + -0.5d;\n\tv198 = System.Math::Ceiling(v633);\n\tgoto L_0188;\nL_015A:\n\tv628 = v536 + 0.5d;\n\tv198 = System.Math::Floor(v628);\nL_016A:\n\tv697 = v198 != 0x7FF0000000000000;\n\tif (v697) goto L_FFFFFFFF;\n\tgoto L_0171;\nL_0171:\n\tv277 = this + 0x28;\n\tv767 = *([v100 @ X24_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv769 = *([v767 @ X0_v88+E0]) == 0;\n\tv770 = ~v769;\n\tif (v770) goto L_0198;\n\tgoto L_01A1;\nL_0179:\n\tv638 = v601 + 0.5d;\n\tv198 = System.Math::Floor(v638);\nL_0188:\n\tv754 = v198 != 0x7FF0000000000000;\n\tif (v754) goto L_FFFFFFFF;\n\tgoto L_018F;\nL_018F:\n\tv277 = this + 0x28;\n\tv775 = *([v100 @ X24_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv777 = *([v775 @ X0_v71+E0]) == 0;\n\tif (v777) goto L_01A1;\nL_0198:\n\tv804 = UnityEngine.Object::op_Inequality(v778, 0);\n\tv829 = ~v804;\n\tv830 = ~v829;\n\tif (v830) goto L_01A8;\n\tgoto L_01A9;\nL_01A1:\n\tv834 = UnityEngine.Object::op_Inequality(v805, 0);\n\tv837 = ~v834;\n\tif (v837) goto L_01A9;\nL_01A8:\n\tUnityEngine.RenderTexture::Release(*([v277 @ X20_v6]));\nL_01A9:\n\tv845 = System.Runtime.Serialization.ObjectHolderList;\n\tv243 = new *([v845 @ X8_v14 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+B00])();\n\tUnityEngine.RenderTexture::.ctor(v243, v273, v145, 0, 2);\n\tv847 = \"Parent table name is missing in relation '{0}'.\";\n\tUnityEngine.Object::set_name(v243, *([v847 @ X8_v16 (System.String)+DF0]));\n\tUnityEngine.Texture::set_filterMode(v243, 0);\n\tUnityEngine.Texture::set_wrapMode(v243, 1);\n\tUnityEngine.RenderTexture::set_useMipMap(v243, 0);\n\tUnityEngine.RenderTexture::set_autoGenerateMips(v243, 0);\n\t*([v278 @ X20_v4]) = v243;\n\tv863 = 0xF3F1B4(v278, v243, 0, 0, 2, 0, v46, v47, v199, v206, v50, v51, v52, v53, v54, v55);\n\tv864 = UnityEngine.UIElements.EnumFieldHelpers;\n\tv866 = \"Parent table name is missing in relation\n// ... truncated")]
	public void Init(FluidPhysicsCoupler coupler)
	{
		sdfCenter = global::UnityEngine.Vector2.zero;
		if (Singleton<GameManager>.Instance.level != null)
		{
			Singleton<GameManager>.Instance.level.GetColliderYExtents(out var minY, out var maxY);
			sdfCenter.y = (minY + maxY) * 0.5f;
		}
		float width = coupler.halfBounds.x * 2f;
		float height = coupler.halfBounds.y * 2f;
		float aspect = width / height;
		int texWidth;
		int texHeight;
		if (aspect < 1f)
		{
			texWidth = global::UnityEngine.Mathf.RoundToInt(aspect * maxResolution);
			texHeight = maxResolution;
		}
		else
		{
			texWidth = maxResolution;
			texHeight = global::UnityEngine.Mathf.RoundToInt(maxResolution / aspect);
		}
		if (outputSDF != null)
		{
			outputSDF.Release();
		}
		outputSDF = new global::UnityEngine.RenderTexture(texWidth, texHeight, 0, global::UnityEngine.RenderTextureFormat.ARGBHalf);
		outputSDF.name = "SDFOutput";
		outputSDF.filterMode = global::UnityEngine.FilterMode.Point;
		outputSDF.wrapMode = global::UnityEngine.TextureWrapMode.Clamp;
		outputSDF.useMipMap = false;
		outputSDF.autoGenerateMips = false;
		outputSDF.Create();
		global::UnityEngine.GameObject cameraObject = new global::UnityEngine.GameObject("SDFRenderCamera");
		global::UnityEngine.Camera camera = cameraObject.AddComponent<global::UnityEngine.Camera>();
		camera.transform.position = new global::UnityEngine.Vector3(sdfCenter.x, sdfCenter.y, -10f);
		camera.transform.rotation = global::UnityEngine.Quaternion.identity;
		camera.orthographic = true;
		camera.orthographicSize = coupler.halfBounds.y;
		camera.nearClipPlane = 0.01f;
		camera.farClipPlane = 20f;
		camera.clearFlags = global::UnityEngine.CameraClearFlags.Color;
		camera.backgroundColor = new global::UnityEngine.Color(0f, 0f, 0f, 0f);
		camera.cullingMask = collisionMask;
		camera.targetTexture = outputSDF;
		camera.depth = -100f;
		camera.SetReplacementShader(whiteMaskShader, "");
		camera.Render();
		camera.targetTexture = null;
		global::UnityEngine.Object.DestroyImmediate(cameraObject);
		generator = new SDFTextureGenerator();
		generator.Update(outputSDF, sourceValueThreshold, downSampling, precision);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A0")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015D6C", Offset = "0x1015D6C", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv2 = this.generator == 0;\n\tif (v2) goto L_0006;\n\tSDFTextureGenerator::Release(this.generator);\n\treturn;\nL_0006:\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnDisable()
	{
		if (generator != null)
		{
			generator.Release();
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003A1")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015D80", Offset = "0x1015D80", Length = "0x20")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.maxResolution = 0x200;\n\tthis.sourceValueThreshold = 0.5f;\n\tthis.precision = 1;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 4 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SDFCollider()
	{
		maxResolution = 512;
		sourceValueThreshold = 0.5f;
		precision = SDFTextureGenerator.Precision._32;
	}
}
