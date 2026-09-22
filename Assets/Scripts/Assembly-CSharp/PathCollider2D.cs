[global::UnityEngine.RequireComponent(typeof(global::PathCreation.PathCreator))]
[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.PolygonCollider2D))]
[global::UnityEngine.ExecuteAlways]
[global::Cpp2ILInjected.Token(Token = "0x20000C3")]
public class PathCollider2D : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.Tooltip("Total width of the collider.")]
	[global::Cpp2ILInjected.Token(Token = "0x400043B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float thickness;

	[global::UnityEngine.Range(2f, 200f)]
	[global::UnityEngine.Tooltip("Number of segments along the path (minimum 2).")]
	[global::Cpp2ILInjected.Token(Token = "0x400043C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public int resolution;

	[global::Cpp2ILInjected.Token(Token = "0x400043D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private global::PathCreation.PathCreator pathCreator;

	[global::Cpp2ILInjected.Token(Token = "0x400043E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private global::UnityEngine.PolygonCollider2D polyCollider;

	[global::Cpp2ILInjected.Token(Token = "0x6000377")]
	[global::Cpp2ILInjected.Address(RVA = "0x101364C", Offset = "0x101364C", Length = "0x94")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Il2CppMethodInfo;\n\tv20 = Il2CppMethodInfo;\n\tgoto L_001D;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x6C0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = Il2CppMethodInfo;\n\tv51 = v50 + 0x6C8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA76]) = v46;\nL_001D:\n\tv49 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v18 @ X22_v1 (Il2CppMethodInfo)+6C0]));\n\tv54 = this + 0x28;\n\tthis.pathCreator = v49;\n\tv55 = 0xF3F1B4(v54, v49, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv58 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v20 @ X20_v1 (Il2CppMethodInfo)+6C8]));\n\tv60 = this + 0x30;\n\tthis.polyCollider = v58;\n\tv68 = 0xF3F1B4(v60, v58, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		pathCreator = GetComponent<global::PathCreation.PathCreator>();
		polyCollider = GetComponent<global::UnityEngine.PolygonCollider2D>();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000378")]
	[global::Cpp2ILInjected.Address(RVA = "0x10136E0", Offset = "0x10136E0", Length = "0x9C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = CollectParticleData[];\n\tv20 = Il2CppMethodInfo;\n\tgoto L_001D;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0x990;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = Il2CppMethodInfo;\n\tv51 = v50 + 0x4B0;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA77]) = v46;\nL_001D:\n\tv49 = new *([v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v49, this, *([v20 @ X22_v1 (Il2CppMethodInfo)+4B0]));\n\tPathCreation.PathCreator::add_pathUpdated(this.pathCreator, v49);\n\tPathCollider2D::UpdateCollider(this);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnEnable()
	{
		pathCreator.pathUpdated += UpdateCollider;
		UpdateCollider();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000379")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013B84", Offset = "0x1013B84", Length = "0x94")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = CollectParticleData[];\n\tv20 = Il2CppMethodInfo;\n\tgoto L_001D;\n\tv25 = CollectParticleData[];\n\tv26 = v25 + 0x990;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv50 = Il2CppMethodInfo;\n\tv51 = v50 + 0x4B0;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA78]) = v46;\nL_001D:\n\tv49 = new *([v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+990])();\n\tSystem.Action::.ctor(v49, this, *([v20 @ X22_v1 (Il2CppMethodInfo)+4B0]));\n\tPathCreation.PathCreator::remove_pathUpdated(this.pathCreator, v49);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnDisable()
	{
		pathCreator.pathUpdated -= UpdateCollider;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600037A")]
	[global::Cpp2ILInjected.Address(RVA = "0x101377C", Offset = "0x101377C", Length = "0x408")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0030;\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0xB70;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv69 = Il2CppMethodInfo;\n\tv70 = v69 + 0xB68;\n\tv71 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv266 = Il2CppMethodInfo;\n\tv267 = v266 + 0xB78;\n\tv268 = \"il2cpp_codegen_initialize_runtime_metadata\"(v267, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv270 = Il2CppMethodInfo;\n\tv271 = v270 + 0xB60;\n\tv272 = \"il2cpp_codegen_initialize_runtime_metadata\"(v271, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv377 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv378 = v377 + 0x528;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v378, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv66 = 1;\n\t*([302AA79]) = v66;\nL_0030:\n\tv73 = PathCreation.PathCreator::get_path(this.pathCreator);\n\tv269 = v73 == 0;\n\tif (v269) goto L_014E;\n\tv284 = this.resolution < 2;\n\tif (v284) goto L_014E;\n\tv384 = v73.isClosedLoop == 0;\n\tv391 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv394 = new *([v391 @ X25_v3 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+528])();\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector2>::.ctor(v394, this.resolution);\n\tv401 = new *([v391 @ X25_v3 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+528])();\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector2>::.ctor(v401, this.resolution);\n\tv147 = this.resolution;\n\tv415 = this.resolution < 1;\n\tif (v415) goto L_014F;\n\tv149 = v384 << 1;\n\tv135 = this.thickness * 0.5f;\n\tgoto L_0089;\nL_0075:\n\t;\n\t// 121 MakeStruct v424 @ AGG10138B4_1_v4 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v425 @ V0_v17 (System.Single), v423 @ V1_v13 (System.Single)\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector2>::AddWithResize(v401, v424);\n\tv143 = v143 + 1;\n\tv146 = this.resolution;\n\tv431 = v143 >= this.resolution;\n\tif (v431) goto L_014F;\nL_0089:\n\tv256 = v146 - 1;\n\tv475 = v143 / v256;\n\tv480 = PathCreation.VertexPath::GetPointAtTime(v73, v475, v149);\n\tv138 = PathCreation.VertexPath::GetDirection(v73, v475, v149);\n\tv238 = UnityEngine.Component::get_transform(this);\n\tv492 = UnityEngine.Transform::InverseTransformPoint(v238, v480);\n\tv498 = *([2DD4421]) == 0;\n\tif (v498) goto L_0133;\n\tgoto L_00B5;\nL_00B5:\n\tv514 = v138 * v138;\n\tv515 = v138.y * v138.y;\n\tv516 = v514 + v515;\n\tv517 = UnityEngine.Mathf::Sqrt(v516);\n\tv178 = v517 <= 0x3727C5AC;\n\tif (v178) goto L_00D0;\n\tv139 = v138 / v517;\n\tv127 = v138.y / v517;\n\tgoto L_00DF;\nL_00D0:\n\tgoto L_00D7;\n\tv539 = System.Xml.ValidateNames;\n\tv540 = v539 + 0x98;\n\tv541 = \"il2cpp_codegen_initialize_runtime_metadata\"(v540, v231, v153, v50, v51, v52, v53, v54, v523, v517, v119, v58, v59, v60, v61, v62);\n\tv544 = 1;\n\t*([2DD4424]) = v544;\nL_00D7:\n\tv545 = System.Xml.ValidateNames;\n\tv547 = *([v545 @ X8_v36 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv538 = *([v547 @ X8_v38+B8]);\n\tv139 = *([v538 @ X8_v39]);\n\tv127 = *([v538 @ X8_v39+4]);\nL_00DF:\n\t;\n\tv549 = v394._version + 1;\n\tv394._version = v549;\n\tv96 = v394._items;\n\tv550 = v127 * v135;\n\tv123 = -v550;\n\tv108 = v135 * v139;\n\tv140 = v492 + v123;\n\tv128 = v492.y + v108;\n\tv551 = v394._size < v96.Length;\n\tv226 = ~v551;\n\tif (v226) goto L_00FE;\n\tv552 = v394._size + 1;\n\tv394._size = v552;\n\tv553 = v394._size << 3;\n\tv554 = v96 + v553;\n\t*([v554 @ X8_v32+20]) = v140;\n\tv96[v91 @ X10_v4 (System.Int32)].y = v128;\n\tgoto L_0106;\nL_00FE:\n\t;\n\t// 258 MakeStruct v559 @ AGG1013A1C_1_v5 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v140 @ V0_v16 (System.Single), v128 @ V1_v12 (System.Single)\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector2>::AddWithResize(v394, v559);\nL_0106:\n\t;\n\tv561 = v401._version + 1;\n\tv401._version = v561;\n\tv97 = v401._items;\n\tv425 = v492 - v123;\n\tv423 = v492.y - v108;\n\tv562 = v401._size < v97.Length;\n\tv563 = ~v562;\n\tif (v563) goto L_0075;\n\tv571 = v401._size + 1;\n\tv401._size = v571;\n\tv420 = v401._size << 3;\n\tv456 = v97 + v420;\n\t*([v456 @ X8_v26+20]) = v425;\n\tv97[v422 @ X10_v5 (System.Int32)].y = v423;\n\tv143 = v143 + 1;\n\tv146 = this.resolution;\n\tv432 = v143 < this.resolution;\n\tif (v432) goto L_0089;\n\tgoto L_014F;\nL_0133:\n\t*([2DD4421]) = 1;\n\tgoto L_00B5;\n\tv507 = \"il2cpp_codegen_runtime_class_init\"(v518, v231, v153, v50, v51, v52, v53, v54, v492, v496, v119, v58, v59, v60, v61, v62);\n\tgoto L_00B5;\nL_014E:\n\treturn;\nL_014F:\n\tv457 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv241 = new *([v457 @ X8_v6 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+528])();\n\tv233 = v147 << 1;\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector2>::.ctor(v241, v233);\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector2>::AddRange(v241, v394);\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector2>::Reverse(v401);\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector2>::AddRange(v241, v401);\n\tUnityEngine.PolygonCollider2D::set_pathCount(this.polyCollider, 1);\n\tUnityEngine.PolygonCollider2D::SetPath(this.polyCollider, 0, v241);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 269 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void UpdateCollider()
	{
		global::PathCreation.VertexPath path = pathCreator.path;
		if (path == null || resolution < 2)
		{
			return;
		}
		bool open = !path.isClosedLoop;
		global::PathCreation.EndOfPathInstruction endOfPathInstruction = open ? global::PathCreation.EndOfPathInstruction.Stop : global::PathCreation.EndOfPathInstruction.Loop;
		global::System.Collections.Generic.List<global::UnityEngine.Vector2> left = new global::System.Collections.Generic.List<global::UnityEngine.Vector2>(resolution);
		global::System.Collections.Generic.List<global::UnityEngine.Vector2> right = new global::System.Collections.Generic.List<global::UnityEngine.Vector2>(resolution);
		float halfThickness = thickness * 0.5f;
		for (int i = 0; i < resolution; i++)
		{
			float t = (float)i / (float)(resolution - 1);
			global::UnityEngine.Vector3 pointAtTime = path.GetPointAtTime(t, endOfPathInstruction);
			global::UnityEngine.Vector3 direction = path.GetDirection(t, endOfPathInstruction);
			global::UnityEngine.Vector3 localPoint = base.transform.InverseTransformPoint(pointAtTime);
			float len = global::UnityEngine.Mathf.Sqrt(direction.x * direction.x + direction.y * direction.y);
			float nx;
			float ny;
			if (len > 1E-05f)
			{
				nx = direction.x / len;
				ny = direction.y / len;
			}
			else
			{
				nx = 1f;
				ny = 0f;
			}
			float offsetX = 0f - ny * halfThickness;
			float offsetY = nx * halfThickness;
			left.Add(new global::UnityEngine.Vector2(localPoint.x + offsetX, localPoint.y + offsetY));
			right.Add(new global::UnityEngine.Vector2(localPoint.x - offsetX, localPoint.y - offsetY));
		}
		global::System.Collections.Generic.List<global::UnityEngine.Vector2> combined = new global::System.Collections.Generic.List<global::UnityEngine.Vector2>(resolution * 2);
		combined.AddRange(left);
		right.Reverse();
		combined.AddRange(right);
		polyCollider.pathCount = 1;
		polyCollider.SetPath(0, combined);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600037B")]
	[global::Cpp2ILInjected.Address(RVA = "0x1013C18", Offset = "0x1013C18", Length = "0x18")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.thickness = 0.2f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 4 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public PathCollider2D()
	{
		thickness = 0.2f;
	}
}
