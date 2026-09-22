[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.UI.Image))]
[global::Cpp2ILInjected.Token(Token = "0x20000B3")]
public class ImageSliceWithUV : global::UnityEngine.UI.BaseMeshEffect
{
	[global::Cpp2ILInjected.Token(Token = "0x6000328")]
	[global::Cpp2ILInjected.Address(RVA = "0x100E470", Offset = "0x100E470", Length = "0xC4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0018;\n\tv23 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv24 = v23 + 0xFD8;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA5C]) = v43;\nL_0018:\n\tv46 = UnityEngine.UI.BaseMeshEffect::get_graphic(this);\n\tv48 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv50 = *([v48 @ X0_v4+E0]) == 0;\n\tif (v50) goto L_0038;\n\tv54 = UnityEngine.Object::op_Inequality(v46, 0);\n\tv56 = ~v54;\n\tif (v56) goto L_0043;\nL_0026:\n\tv68 = UnityEngine.UI.BaseMeshEffect::get_graphic(this);\n\tv95 = *([v68 @ X0_v11 (UnityEngine.UI.Graphic)]);\n\tv86 = *([v95 @ X8_v4 (Il2CppClass<UnityEngine.UI.Graphic>)+2F8]);\n\tv88 = *([v95 @ X8_v4 (Il2CppClass<UnityEngine.UI.Graphic>)+300]);\n\t// 51 IndirectJump v86 @ X2_v4, v68 @ X0_v11 (UnityEngine.UI.Graphic), v68 @ X0_v11 (UnityEngine.UI.Graphic), v88 @ X1_v6, v86 @ X2_v4, v28 @ X3, v29 @ X4, v30 @ X5, v31 @ X6, v32 @ X7, v33 @ V0, v34 @ V1, v35 @ V2, v36 @ V3, v37 @ V4, v38 @ V5, v39 @ V6, v40 @ V7\nL_0038:\n\tv60 = UnityEngine.Object::op_Inequality(v46, 0);\n\tv79 = ~v60;\n\tv65 = ~v79;\n\tif (v65) goto L_0026;\nL_0043:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 44 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	protected override void Start()
	{
		global::UnityEngine.UI.Graphic graphic = base.graphic;
		if (graphic != null)
		{
			graphic.SetVerticesDirty();
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000329")]
	[global::Cpp2ILInjected.Address(RVA = "0x100E534", Offset = "0x100E534", Length = "0x3F4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0047;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x728;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0x790;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv275 = Il2CppMethodInfo;\n\tv276 = v275 + 0x838;\n\tv277 = \"il2cpp_codegen_initialize_runtime_metadata\"(v276, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv354 = Il2CppMethodInfo;\n\tv355 = v354 + 0xB38;\n\tv356 = \"il2cpp_codegen_initialize_runtime_metadata\"(v355, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv358 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv359 = v358 + 0x3D0;\n\tv360 = \"il2cpp_codegen_initialize_runtime_metadata\"(v359, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv363 = Il2CppMethodInfo;\n\tv364 = v363 + 0xAB0;\n\tv365 = \"il2cpp_codegen_initialize_runtime_metadata\"(v364, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv366 = Il2CppMethodInfo;\n\tv367 = v366 + 0xAD0;\n\tv368 = \"il2cpp_codegen_initialize_runtime_metadata\"(v367, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv369 = Il2CppMethodInfo;\n\tv370 = v369 + 0xAD8;\n\tv371 = \"il2cpp_codegen_initialize_runtime_metadata\"(v370, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv377 = Il2CppMethodInfo;\n\tv378 = v377 + 0xAE8;\n\tv379 = \"il2cpp_codegen_initialize_runtime_metadata\"(v378, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv385 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv386 = v385 + 0x510;\n\tv387 = \"il2cpp_codegen_initialize_runtime_metadata\"(v386, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv417 = Il2CppMethodInfo;\n\tv418 = v417 + 0xF40;\n\tv419 = \"il2cpp_codegen_initialize_runtime_metadata\"(v418, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv429 = Il2CppMethodInfo;\n\tv430 = v429 + 0xF48;\n\tv431 = \"il2cpp_codegen_initialize_runtime_metadata\"(v430, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv445 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv446 = v445 + 0xE48;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v446, vh, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv63 = 1;\n\t*([302AA5D]) = v63;\nL_0047:\n\tv68 = UnityEngine.EventSystems.UIBehaviour::IsActive(this);\n\tv69 = ~v68;\n\tif (v69) goto L_01C6;\n\tv73 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv78 = new *([v73 @ X8_v5 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+510])();\n\tSystem.Collections.Generic.List`1<UnityEngine.UIVertex>::.ctor(v78);\n\tUnityEngine.UI.VertexHelper::GetUIVertexStream(vh, v78);\n\tv251 = v78._size == 0;\n\tif (v251) goto L_01C6;\n\tv372 = Facebook.Unity.AsyncRequestString+<Start>d__9;\n\tv374 = *([v372 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+E48]);\n\tv376 = *([v374 @ X0_v10+E0]) == 0;\n\tif (v376) goto L_006B;\n\tv434 = *([v374 @ X0_v10+B8]);\n\tv407 = *([v434 @ X8_v33+8]);\n\tv382 = *([v434 @ X8_v33+8]) == 0;\n\tv383 = ~v382;\n\tif (v383) goto L_008A;\n\tgoto L_0074;\nL_006B:\n\tv400 = *([v372 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+E48]);\n\tv434 = *([v400 @ X0_v52+B8]);\n\tv407 = *([v434 @ X8_v33+8]);\n\tv416 = *([v434 @ X8_v33+8]) == 0;\n\tv403 = ~v416;\n\tif (v403) goto L_008A;\nL_0074:\n\tgoto L_0079;\n\tv432 = \"il2cpp_codegen_runtime_class_init\"(v420, v245, v242, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv447 = *([v373 @ X23_v4]);\n\tv435 = *([v447 @ X8_v39+B8]);\nL_0079:\n\tv436 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv439 = new *([v436 @ X8_v34 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+3D0])();\n\tv448 = Il2CppMethodInfo;\n\tSystem.Func`2<UnityEngine.UIVertex, System.Single>::.ctor(v439, *([v434 @ X8_v33]), *([v448 @ X8_v36 (Il2CppMethodInfo)+F40]));\n\tv405 = *([v372 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+E48]);\n\tv484 = *([v405 @ X8_v38+B8]) + 8;\n\t*([v484 @ X0_v48]) = v439;\n\tv399 = 0xF3F1B4(v484, v439, *([v448 @ X8_v36 (Il2CppMethodInfo)+F40]), 0, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\nL_008A:\n\t;\n\tv415 = System.Linq.Enumerable::OrderBy(v78, v407);\n\tv428 = System.Linq.Enumerable::ToList(v415);\n\tv443 = &v770 @ stack_-EC_v8 (UnityEngine.Vector3);\n\tv444 = System.Linq.Enumerable::First(v428);\n\tv770 = *([v443 @ X8_v10]);\n\tv480 = &v770 @ stack_-EC_v8 (UnityEngine.Vector3);\n\tv482 = System.Linq.Enumerable::Last(v428);\n\tv770 = *([v480 @ X8_v11]);\n\tv513 = *([v372 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+E48]);\n\tv515 = *([v513 @ X0_v18+E0]) == 0;\n\tif (v515) goto L_00E3;\n\tv555 = *([v513 @ X0_v18+B8]);\n\tv538 = *([v555 @ X8_v22+10]);\n\tv518 = *([v555 @ X8_v22+10]) == 0;\n\tv519 = ~v518;\n\tif (v519) goto L_0105;\n\tgoto L_00EC;\nL_00E3:\n\tv532 = *([v372 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+E48]);\n\tv555 = *([v532 @ X0_v42+B8]);\n\tv538 = *([v555 @ X8_v22+10]);\n\tv545 = *([v555 @ X8_v22+10]) == 0;\n\tv534 = ~v545;\n\tif (v534) goto L_0105;\nL_00EC:\n\tgoto L_00F1;\n\tv553 = \"il2cpp_codegen_runtime_class_init\"(v546, v479, v412, v390, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\n\tv565 = *([v373 @ X23_v4]);\n\tv556 = *([v565 @ X8_v28+B8]);\nL_00F1:\n\tv557 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv560 = new *([v557 @ X8_v23 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+3D0])();\n\tv566 = Il2CppMethodInfo;\n\tSystem.Func`2<UnityEngine.UIVertex, System.Single>::.ctor(v560, *([v555 @ X8_v22]), *([v566 @ X8_v25 (Il2CppMethodInfo)+F48]));\n\tv536 = *([v372 @ X23_v3 (Il2CppClass<Facebook.Unity.AsyncRequestString+<Start>d__9>)+E48]);\n\tv602 = *([v536 @ X8_v27+B8]) + 0x10;\n\t*([v602 @ X0_v38]) = v560;\n\tv531 = 0xF3F1B4(v602, v560, *([v566 @ X8_v25 (Il2CppMethodInfo)+F48]), 0, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59);\nL_0105:\n\tv544 = System.Linq.Enumerable::OrderBy(v78, v538);\n\tv552 = System.Linq.Enumerable::ToList(v544);\n\tv563 = &v770 @ stack_-EC_v8 (UnityEngine.Vector3);\n\tv564 = System.Linq.Enumerable::First(v552);\n\tv770 = *([v563 @ X8_v14]);\n\tv600 = System.Linq.Enumerable::Last(v552);\n\tv641 = v78._size < 1;\n\tif (v641) goto L_01B0;\n\tv644 = &v770 @ stack_-EC_v8 (UnityEngine.Vector3) + 0xC;\n\tv645 = &v770 @ stack_-EC_v8 (UnityEngine.Vector3) + 0x4C;\nL_0163:\n\tv769 = System.Collections.Generic.List`1<UnityEngine.UIVertex>::get_Item(v78, v764);\n\tv770 = v769.position;\n\t*([v644 @ X22_v6]) = *([v644 @ X22_v6]);\n\t*([v644 @ X22_v6+10]) = *([v644 @ X22_v6+10]);\n\t*([v644 @ X22_v6+20]) = *([v644 @ X22_v6+20]);\n\t*([v645 @ X23_v7]) = *([v645 @ X23_v7]);\n\t*([v645 @ X23_v7+10]) = *([v645 @ X23_v7+10]);\n\tSystem.Collections.Generic.List`1<UnityEngine.UIVertex>::set_Item(v78, v764, &v770 @ stack_-EC_v8 (UnityEngine.Vector3));\n\tv764 = v764 + 1;\n\tv664 = v764 < v78._size;\n\tif (v664) goto L_0163;\nL_01B0:\n\tUnityEngine.UI.VertexHelper::Clear(vh);\n\tUnityEngine.UI.VertexHelper::AddUIVertexTriangleStream(vh, v78);\nL_01C6:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 316 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void ModifyMesh(global::UnityEngine.UI.VertexHelper vh)
	{
		if (!base.IsActive())
		{
			return;
		}
		global::System.Collections.Generic.List<global::UnityEngine.UIVertex> list = new global::System.Collections.Generic.List<global::UnityEngine.UIVertex>();
		vh.GetUIVertexStream(list);
		if (list.Count == 0)
		{
			return;
		}
		float minX = float.MaxValue;
		float maxX = float.MinValue;
		float minY = float.MaxValue;
		float maxY = float.MinValue;
		for (int i = 0; i < list.Count; i++)
		{
			global::UnityEngine.Vector3 position = list[i].position;
			if (position.x < minX) { minX = position.x; }
			if (position.x > maxX) { maxX = position.x; }
			if (position.y < minY) { minY = position.y; }
			if (position.y > maxY) { maxY = position.y; }
		}
		float rangeX = maxX - minX;
		float rangeY = maxY - minY;
		for (int j = 0; j < list.Count; j++)
		{
			global::UnityEngine.UIVertex vertex = list[j];
			global::UnityEngine.Vector3 position2 = vertex.position;
			float u = (rangeX > 0f) ? ((position2.x - minX) / rangeX) : 0f;
			float v = (rangeY > 0f) ? ((position2.y - minY) / rangeY) : 0f;
			vertex.uv0 = new global::UnityEngine.Vector2(u, v);
			list[j] = vertex;
		}
		vh.Clear();
		vh.AddUIVertexTriangleStream(list);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600032A")]
	[global::Cpp2ILInjected.Address(RVA = "0x100E928", Offset = "0x100E928", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.UI.BaseMeshEffect::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public ImageSliceWithUV()
	{
	}
}
