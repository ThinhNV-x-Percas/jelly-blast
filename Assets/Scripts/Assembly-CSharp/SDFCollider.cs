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
		//IL_0dee: Expected I, but got O
		//IL_0dfe: Expected O, but got I
		//IL_0e0e: Expected O, but got I
		//IL_0022: Expected I, but got O
		//IL_0032: Expected O, but got I
		//IL_00b6: Expected O, but got I
		//IL_00d3: Expected O, but got I4
		//IL_0069: Expected O, but got I
		//IL_00ff: Expected O, but got I
		//IL_0135: Expected O, but got F4
		//IL_013d: Expected O, but got F4
		//IL_009a: Expected O, but got I4
		//IL_0534: Expected I, but got O
		//IL_0544: Expected O, but got I
		//IL_0319: Expected I, but got O
		//IL_0329: Expected O, but got I
		//IL_0417: Expected I, but got O
		//IL_0427: Expected O, but got I
		//IL_01fc: Expected I, but got O
		//IL_020c: Expected O, but got I
		//IL_0c9b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca0: Expected I4, but got Unknown
		//IL_0d4b: Expected O, but got I
		//IL_0d5b: Expected O, but got I
		//IL_0d89: Expected O, but got I8
		//IL_0d93: Expected F8, but got I4
		//IL_0dba: Expected O, but got I8
		//IL_0dc4: Expected F8, but got I4
		//IL_0c56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5b: Expected I4, but got Unknown
		//IL_0cde: Expected O, but got I
		//IL_0cee: Expected O, but got I
		//IL_0d24: Expected F8, but got I4
		//IL_0d31: Expected O, but got I8
		//IL_0883: Expected I, but got O
		//IL_089a: Expected I4, but got F8
		//IL_089a: Expected I4, but got F8
		//IL_06f7: Expected F8, but got I4
		//IL_070c: Expected O, but got I8
		//IL_08c2: Expected O, but got I
		//IL_0932: Expected I, but got O
		//IL_0959: Expected O, but got I
		//IL_09fd: Expected I, but got O
		//IL_0a0b: Expected I, but got O
		//IL_0a1b: Expected O, but got I
		//IL_0a2b: Expected O, but got I
		//IL_0a38: Expected F4, but got O
		//IL_0a4d: Expected F4, but got I
		//IL_0a62: Expected F4, but got I
		//IL_0a77: Expected F4, but got I
		//IL_0b8b: Expected O, but got I
		//IL_0bd1: Expected O, but got I
		nint num = 0;
		nint num2 = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v77 @ X8_v5 (Il2CppClass<System.Xml.ValidateNames>)+98]");
		object obj = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X8_v7+B8]");
		object obj2 = 0;
		sdfCenter = (global::UnityEngine.Vector2)obj2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @18AB640 (Singleton`1::get_Instance, and 1 more at this address)");
		nint num3 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v103 @ X0_v9+E0]");
		object obj4;
		global::UnityEngine.Object obj5;
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+78]");
			if ((global::UnityEngine.Object)0 != null)
			{
				goto IL_00e6;
			}
			obj4 = 0;
			obj5 = null;
		}
		else
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+78]");
			bool flag = (global::UnityEngine.Object)0 != null;
			bool flag2 = !flag;
			obj4 = 0;
			obj5 = null;
			if (!flag2)
			{
				goto IL_00e6;
			}
		}
		goto IL_0142;
		IL_0875:
		nint num4 = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		double num5;
		double num6;
		global::UnityEngine.RenderTexture renderTexture = new global::UnityEngine.RenderTexture((int)num5, (int)num6, 0, global::UnityEngine.RenderTextureFormat.ARGBHalf);
		string text = "Parent table name is missing in relation '{0}'.";
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v847 @ X8_v16 (System.String)+DF0]");
		renderTexture.name = (string)0;
		renderTexture.filterMode = default(global::UnityEngine.FilterMode);
		renderTexture.wrapMode = global::UnityEngine.TextureWrapMode.Clamp;
		renderTexture.useMipMap = false;
		renderTexture.autoGenerateMips = false;
		object obj6 = renderTexture;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		nint num7 = (nint)typeof(global::UnityEngine.UIElements.EnumFieldHelpers);
		string text2 = "Parent table name is missing in relation '{0}'.";
		bool flag3 = ((global::UnityEngine.RenderTexture)obj6).Create();
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v866 @ X22_v6 (System.String)+DE8]");
		global::UnityEngine.GameObject obj7 = new global::UnityEngine.GameObject((string)0);
		nint num8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11481F4 (UnityEngine.GameObject::AddComponent, and 1 more at this address)");
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		global::UnityEngine.Transform transform = component.transform;
		global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
		position.x = sdfCenter.x;
		position.y = sdfCenter.y;
		position.z = -10f;
		transform.position = position;
		global::UnityEngine.Transform transform2 = component.transform;
		nint num9 = 0;
		nint num10 = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		nint num11 = (nint)typeof(global::System.Runtime.Serialization.ObjectHolderList);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v884 @ X8_v22 (Il2CppClass<System.Runtime.Serialization.ObjectHolderList>)+538]");
		object obj8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v886 @ X8_v24+B8]");
		object obj9 = 0;
		global::UnityEngine.Quaternion rotation = default(global::UnityEngine.Quaternion);
		rotation.x = (float)obj9;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v25+4]");
		rotation.y = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v25+8]");
		rotation.z = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v887 @ X8_v25+C]");
		rotation.w = 0f;
		transform2.rotation = rotation;
		((global::UnityEngine.Camera)component).orthographic = true;
		float num12;
		float orthographicSize = num12 * 0.5f;
		((global::UnityEngine.Camera)component).orthographicSize = orthographicSize;
		((global::UnityEngine.Camera)component).nearClipPlane = 0.01f;
		((global::UnityEngine.Camera)component).farClipPlane = 20f;
		((global::UnityEngine.Camera)component).clearFlags = global::UnityEngine.CameraClearFlags.Color;
		global::UnityEngine.Color backgroundColor = default(global::UnityEngine.Color);
		backgroundColor.r = 0f;
		backgroundColor.g = 0f;
		backgroundColor.b = 0f;
		backgroundColor.a = 0f;
		((global::UnityEngine.Camera)component).backgroundColor = backgroundColor;
		int cullingMask = collisionMask;
		((global::UnityEngine.Camera)component).cullingMask = cullingMask;
		((global::UnityEngine.Camera)component).targetTexture = outputSDF;
		((global::UnityEngine.Camera)component).depth = -100f;
		global::UnityEngine.Shader shader = whiteMaskShader;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v882 @ X26_v2 (Il2CppFieldInfo)+960]");
		((global::UnityEngine.Camera)component).SetReplacementShader(shader, (string)0);
		((global::UnityEngine.Camera)component).Render();
		((global::UnityEngine.Camera)component).targetTexture = null;
		global::UnityEngine.Object.DestroyImmediate(obj7);
		SDFTextureGenerator sDFTextureGenerator = new SDFTextureGenerator();
		object obj10 = (nint)this + 64;
		generator = sDFTextureGenerator;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		generator.Update(outputSDF, sourceValueThreshold, downSampling, precision);
		SDFTextureGenerator sDFTextureGenerator2 = generator;
		obj6 = sDFTextureGenerator2.SdfTexture;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		return;
		IL_0c83:
		double num14;
		double num15;
		double num13 = num14 + num15;
		double num16;
		if ((num16 & 1) != 0)
		{
			num14 = num13;
		}
		goto IL_0747;
		IL_00e6:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X0_v6+78]");
		((Level)0).GetColliderYExtents(out var minY, out var maxY);
		float num17 = minY + maxY;
		float y = num17 * 0.5f;
		sdfCenter.y = y;
		obj4 = maxY;
		obj5 = (global::UnityEngine.Object)minY;
		goto IL_0142;
		IL_0747:
		double num18 = ((num14 != 9.218868437227405E+18) ? num14 : 1.0609978955E-314);
		object obj11 = (nint)this + 40;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj12 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v775 @ X0_v71+E0]");
		bool flag4 = (nint)0 == 0;
		global::UnityEngine.Object obj13 = outputSDF;
		object obj14 = 9218868437227405312L;
		double num19 = maxResolution;
		global::UnityEngine.Object obj15 = outputSDF;
		num6 = num18;
		double num20 = num14;
		object obj16 = 9218868437227405312L;
		num5 = maxResolution;
		obj6 = obj11;
		if (!flag4)
		{
			goto IL_078c;
		}
		goto IL_07eb;
		IL_0142:
		float num21 = coupler.halfBounds.x + coupler.halfBounds.x;
		num12 = coupler.halfBounds.y + coupler.halfBounds.y;
		float num22 = num21 / num12;
		float num23;
		float num27;
		float num28;
		float num29;
		float num30;
		double num31;
		double num32 = default(double);
		if (num21 < num12)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4417]");
			float num25;
			if ((nint)0 != 0)
			{
				num23 = num22 * (float)maxResolution;
				nint num24 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v399 @ X8_v66 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
				object obj17 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X0_v102+E0]");
				bool flag5 = (nint)0 == 0;
				num25 = num23;
				if (!flag5)
				{
					goto IL_0239;
				}
			}
			else
			{
				_ = 1;
				num23 = num22 * (float)maxResolution;
				nint num26 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v60 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
				object obj18 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v419 @ X0_v97+E0]");
				bool flag6 = (nint)0 == 0;
				bool flag7 = !flag6;
				num25 = num23;
				if (flag7)
				{
					goto IL_0239;
				}
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
			bool flag8 = num25 < 0f;
			num27 = num25;
			num28 = num25;
			num29 = num25;
			num30 = num25;
			num31 = num32;
			if (flag8)
			{
				goto IL_028d;
			}
			goto IL_04b5;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4417]");
		float num33;
		float num35;
		if ((nint)0 != 0)
		{
			num33 = (float)maxResolution / num22;
			nint num34 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v408 @ X8_v49 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
			object obj19 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v410 @ X0_v85+E0]");
			bool flag9 = (nint)0 == 0;
			num35 = num33;
			if (!flag9)
			{
				goto IL_0356;
			}
		}
		else
		{
			_ = 1;
			num33 = (float)maxResolution / num22;
			nint num36 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v457 @ X8_v43 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
			object obj20 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v441 @ X0_v80+E0]");
			bool flag10 = (nint)0 == 0;
			bool flag11 = !flag10;
			num35 = num33;
			if (flag11)
			{
				goto IL_0356;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
		bool flag12 = num35 < 0f;
		float num37 = num35;
		float num38 = num35;
		float num39 = num35;
		float num40 = num35;
		double num42 = default(double);
		double num41 = num42;
		if (flag12)
		{
			goto IL_03aa;
		}
		goto IL_05d2;
		IL_07eb:
		bool flag13 = obj15 != null;
		bool flag14 = !flag13;
		num18 = num6;
		num14 = num20;
		obj14 = obj16;
		num19 = num5;
		obj11 = obj6;
		if (!flag14)
		{
			goto IL_083f;
		}
		goto IL_0875;
		IL_069e:
		num19 = ((num14 != 9.218868437227405E+18) ? num14 : 1.0609978955E-314);
		obj11 = (nint)this + 40;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X24_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj21 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v767 @ X0_v88+E0]");
		bool flag15 = (nint)0 == 0;
		bool flag16 = !flag15;
		obj13 = outputSDF;
		num18 = maxResolution;
		obj14 = 9218868437227405312L;
		if (flag16)
		{
			goto IL_078c;
		}
		obj15 = outputSDF;
		num6 = maxResolution;
		num20 = num14;
		obj16 = 9218868437227405312L;
		num5 = num19;
		obj6 = obj11;
		goto IL_07eb;
		IL_04b5:
		double num43;
		double num44;
		if ((double)num30 == 0.5)
		{
			num14 = num31;
			num43 = 1.0;
			num44 = num31;
			goto IL_0c3e;
		}
		double d = (double)num29 + 0.5;
		num14 = global::System.Math.Floor(d);
		goto IL_069e;
		IL_0c3e:
		double num45 = num14 + num43;
		if ((num44 & 1) != 0)
		{
			num14 = num45;
		}
		goto IL_069e;
		IL_0356:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
		bool flag17 = !(num33 < 0f);
		num37 = num33;
		num38 = num33;
		num39 = num33;
		num40 = num33;
		num41 = num42;
		if (!flag17)
		{
			goto IL_03aa;
		}
		goto IL_05d2;
		IL_05d2:
		if ((double)num40 == 0.5)
		{
			num14 = num41;
			num15 = 1.0;
			num16 = num41;
			goto IL_0c83;
		}
		double d2 = (double)num39 + 0.5;
		num14 = global::System.Math.Floor(d2);
		goto IL_0747;
		IL_078c:
		if (obj13 != null)
		{
			goto IL_083f;
		}
		num6 = num18;
		num20 = num14;
		obj16 = obj14;
		num5 = num19;
		obj6 = obj11;
		goto IL_0875;
		IL_0239:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
		bool flag18 = !(num23 < 0f);
		num27 = num23;
		num28 = num23;
		num29 = num23;
		num30 = num23;
		num31 = num32;
		if (!flag18)
		{
			goto IL_028d;
		}
		goto IL_04b5;
		IL_03aa:
		if ((double)num38 == -0.5)
		{
			num14 = num42;
			num15 = -1.0;
			num16 = num42;
			goto IL_0c83;
		}
		double a = (double)num37 + -0.5;
		num14 = global::System.Math.Ceiling(a);
		goto IL_0747;
		IL_028d:
		if ((double)num28 == -0.5)
		{
			num14 = num32;
			num43 = -1.0;
			num44 = num32;
			goto IL_0c3e;
		}
		double a2 = (double)num27 + -0.5;
		num14 = global::System.Math.Ceiling(a2);
		goto IL_069e;
		IL_083f:
		((global::UnityEngine.RenderTexture)obj11).Release();
		num6 = num18;
		num20 = num14;
		obj16 = obj14;
		num5 = num19;
		obj6 = obj11;
		goto IL_0875;
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
