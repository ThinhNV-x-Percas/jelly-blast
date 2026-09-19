namespace PathCreation.Examples
{
	[global::Cpp2ILInjected.Token(Token = "0x2000103")]
	public class CylinderMeshCreator : global::PathCreation.Examples.PathSceneTool
	{
		[global::UnityEngine.Tooltip("Radius of the cylinder and hemisphere caps.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000524")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float thickness;

		[global::UnityEngine.Range(3f, 30f)]
		[global::Cpp2ILInjected.Token(Token = "0x4000525")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int resolutionU;

		[global::UnityEngine.Min(0f)]
		[global::Cpp2ILInjected.Token(Token = "0x4000526")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float resolutionV;

		[global::UnityEngine.Tooltip("Enable to add hemispherical caps at the ends of the cylinder.")]
		[global::Cpp2ILInjected.Token(Token = "0x4000527")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool addCaps;

		[global::UnityEngine.Tooltip("Number of segments from pole to equator for each hemispherical cap.")]
		[global::UnityEngine.Min(1f)]
		[global::Cpp2ILInjected.Token(Token = "0x4000528")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		public int capSegmentsV;

		[global::Cpp2ILInjected.Token(Token = "0x4000529")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public global::UnityEngine.Material material;

		[global::Cpp2ILInjected.Token(Token = "0x400052A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::UnityEngine.MeshFilter meshFilter;

		[global::Cpp2ILInjected.Token(Token = "0x400052B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::UnityEngine.MeshRenderer meshRenderer;

		[global::Cpp2ILInjected.Token(Token = "0x400052C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::UnityEngine.Mesh mesh;

		[global::Cpp2ILInjected.Token(Token = "0x600049B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021AE8", Offset = "0x1021AE8", Length = "0x14C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302AB3D]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_003C;\n\tv23 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv25 = *([v23 @ X0_v33+E0]) == 0;\n\tif (v25) goto L_0047;\nL_0018:\n\tv55 = UnityEngine.Object::op_Inequality(v50, 0);\n\tv63 = ~v55;\n\tif (v63) goto L_0052;\nL_001C:\n\tPathCreation.Examples.CylinderMeshCreator::AssignMeshComponents(this);\n\tv89 = 0x302A000;\n\tv91 = *([302AB3E]) & 1;\n\tv92 = v91 == 0;\n\tif (v92) goto L_0057;\n\tv131 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv133 = *([v131 @ X0_v29+E0]) == 0;\n\tif (v133) goto L_0062;\nL_002A:\n\tv148 = UnityEngine.Object::op_Inequality(v143, 0);\n\tv156 = ~v148;\n\tv157 = ~v156;\n\tif (v157) goto L_006A;\nL_0036:\n\tPathCreation.Examples.CylinderMeshCreator::CreateMesh(this);\n\treturn;\nL_003C:\n\t*([v16 @ X20_v1+B3D]) = 1;\n\tv45 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv62 = *([v45 @ X0_v9+E0]) == 0;\n\tv47 = ~v62;\n\tif (v47) goto L_0018;\nL_0047:\n\tv67 = UnityEngine.Object::op_Inequality(v59, 0);\n\tv88 = ~v67;\n\tv72 = ~v88;\n\tif (v72) goto L_001C;\nL_0052:\n\treturn;\nL_0057:\n\t*([v89 @ X20_v7+B3E]) = 1;\n\tv138 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv155 = *([v138 @ X0_v23+E0]) == 0;\n\tv140 = ~v155;\n\tif (v140) goto L_002A;\nL_0062:\n\tv161 = UnityEngine.Object::op_Inequality(v152, 0);\n\tv163 = ~v161;\n\tif (v163) goto L_0036;\nL_006A:\n\tUnityEngine.Renderer::set_sharedMaterial(this.meshRenderer, this.material);\n\tPathCreation.Examples.CylinderMeshCreator::CreateMesh(this);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		protected override void PathUpdated()
		{
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected I, but got O
			//IL_0196: Expected O, but got I
			//IL_005a: Expected O, but got I
			//IL_00ca: Expected O, but got I4
			//IL_0229: Expected O, but got I
			//IL_010d: Expected O, but got I
			object obj = 50503680;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AB3D]");
			global::UnityEngine.Object obj3;
			global::UnityEngine.Object obj4;
			if ((uint)((nuint)0u & (nuint)1u) != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v33+E0]");
				bool flag = (nint)0 == 0;
				obj3 = pathCreator;
				obj4 = pathCreator;
				if (!flag)
				{
					goto IL_0093;
				}
			}
			else
			{
				_ = 1;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v9+E0]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				obj3 = pathCreator;
				obj4 = pathCreator;
				if (flag3)
				{
					goto IL_0093;
				}
			}
			if (!(obj4 != null))
			{
				return;
			}
			goto IL_00bb;
			IL_0146:
			global::UnityEngine.Object obj6;
			if (!(obj6 != null))
			{
				goto IL_0179;
			}
			goto IL_029a;
			IL_029a:
			meshRenderer.sharedMaterial = material;
			CreateMesh();
			return;
			IL_0179:
			CreateMesh();
			return;
			IL_0093:
			if (obj3 != null)
			{
				goto IL_00bb;
			}
			return;
			IL_00bb:
			AssignMeshComponents();
			object obj7 = 50503680;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AB3E]");
			global::UnityEngine.Object obj9;
			if ((uint)((nuint)0u & (nuint)1u) != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj8 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v131 @ X0_v29+E0]");
				bool flag4 = (nint)0 == 0;
				obj6 = material;
				obj9 = material;
				if (!flag4)
				{
					goto IL_0146;
				}
			}
			else
			{
				_ = 1;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj10 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v138 @ X0_v23+E0]");
				bool flag5 = (nint)0 == 0;
				bool flag6 = !flag5;
				obj6 = material;
				obj9 = material;
				if (flag6)
				{
					goto IL_0146;
				}
			}
			if (!(obj9 != null))
			{
				goto IL_0179;
			}
			goto IL_029a;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600049C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021EC0", Offset = "0x1021EC0", Length = "0xAA0")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv46 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv50 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_0042;\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0x410;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, methodInfo, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74);\n\tv81 = Il2CppMethodInfo;\n\tv82 = v81 + 0xBA0;\n\tv83 = \"il2cpp_codegen_initialize_runtime_metadata\"(v82, methodInfo, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74);\n\tv86 = Il2CppMethodInfo;\n\tv87 = v86 + 0x3F8;\n\tv88 = \"il2cpp_codegen_initialize_runtime_metadata\"(v87, methodInfo, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74);\n\tv92 = Il2CppMethodInfo;\n\tv93 = v92 + 0xB90;\n\tv94 = \"il2cpp_codegen_initialize_runtime_metadata\"(v93, methodInfo, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74);\n\tv97 = Il2CppMethodInfo;\n\tv98 = v97 + 0xBE0;\n\tv99 = \"il2cpp_codegen_initialize_runtime_metadata\"(v98, methodInfo, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74);\n\tv103 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv104 = v103 + 0x110;\n\tv105 = \"il2cpp_codegen_initialize_runtime_metadata\"(v104, methodInfo, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74);\n\tv108 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv109 = v108 + 0x530;\n\tv110 = \"il2cpp_codegen_initialize_runtime_metadata\"(v109, methodInfo, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74);\n\tv115 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv116 = v115 + 0x9E8;\n\tv117 = \"il2cpp_codegen_initialize_runtime_metadata\"(v116, methodInfo, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74);\n\tv119 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv120 = v119 + 0xFD8;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v120, methodInfo, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73, v74);\n\tv78 = 1;\n\t*([302AB01]) = v78;\nL_0042:\n\tv80 = *([v46 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+530]);\n\tv80 = new v80();\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor(v80);\n\tv80 = *([v46 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+530]);\n\tv80 = new v80();\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector3>::.ctor(v80);\n\tv80 = *([v50 @ X22_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+110]);\n\tv102 = new *([v50 @ X22_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+110])();\n\tSystem.Collections.Generic.List`1<System.Int32>::.ctor(v102);\n\tv114 = PathCreation.Examples.PathSceneTool::get_path(this);\n\tv123 = 0x2DD4000;\n\tv125 = *([2DD4417]) == 0;\n\tif (v125) goto L_0089;\n\tv671 = v114.length * this.resolutionV;\n\tv663 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv1038 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv80 = *([v663 @ X23_v27 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv667 = *([v80 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+E0]) == 0;\n\tif (v667) goto L_0096;\nL_0069:\n\tv80 = 0x274AA58(&v683 @ stack_-A8_v7 (System.Double), 0, v61, v132, v130, v135, v65, v66, v671, v68, v69, v263, v258, v253, v218, v74);\n\tv791 = v671 >= 0;\n\tif (v791) goto L_00AD;\nL_007F:\n\tv833 = v815 != -0.5d;\n\tif (v833) goto L_00BF;\n\tgoto L_00B2;\nL_0089:\n\t*([v123 @ X23_v4+417]) = 1;\n\tv671 = v114.length * this.resolutionV;\n\tv693 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv1038 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv80 = *([v693 @ X23_v23 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv694 = *([v80 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+E0]) == 0;\n\tv676 = ~v694;\n\tif (v676) goto L_0069;\nL_0096:\n\tv80 = 0x274AA58(&v683 @ stack_-A8_v7 (System.Double), 0, v61, v132, v130, v135, v65, v66, v686, v68, v69, v263, v258, v253, v218, v74);\n\tv798 = v686 < 0;\n\tif (v798) goto L_007F;\nL_00AD:\n\tv861 = v843 != 0.5d;\n\tif (v861) goto L_00C2;\nL_00B2:\n\tv892 = v514 + v874;\n\tv893 = v891 & 1;\n\tv895 = v893 == 0;\n\tv898 = ~v895;\n\tif (v898) goto L_FFFFFFFF;\n\tgoto L_00BE;\nL_00BE:\n\tgoto L_00C5;\nL_00BF:\n\tv867 = v818 + -0.5d;\n\tv514 = System.Math::Ceiling(v867);\n\tgoto L_00C5;\nL_00C2:\n\tv872 = v846 + 0.5d;\n\tv514 = System.Math::Floor(v872);\nL_00C5:\n\tv915 = v514 + 1;\n\tv918 = v915 - 2;\n\tv919 = v918 < 0;\n\tv920 = v918 == 0;\n\tv921 = v915 ^ 2;\n\tv922 = v915 ^ v918;\n\tv923 = v921 & v922;\n\tv924 = v923 < 0;\n\tv925 = v919 == v924;\n\tv926 = ~v925;\n\tv377 = v926 | v920;\n\tv927 = ~v377;\n\tif (v927) goto L_00D7;\n\tgoto L_00E4;\nL_00D7:\n\tv629 = v514 + 1;\nL_00E4:\n\tv348 = v514 != 0x7FF0000000000000;\n\tif (v348) goto L_00ED;\n\tgoto L_00ED;\nL_00ED:\n\tv956 = PathCreation.Examples.PathSceneTool::get_path(this);\n\tv1006 = Il2CppMethodInfo + 0xBA0;\n\tv943 = v629 + -1f;\n\tv1005 = v629 - 1;\n\tgoto L_0110;\nL_00FD:\n\tv340 = v1007 + 1;\n\tv1060 = v340 == v629;\n\tif (v1060) goto L_0376;\nL_010C:\n\tv956 = PathCreation.Examples.PathSceneTool::get_path(this);\nL_0110:\n\tv535 = v954 / v943;\n\tv516 = PathCreation.VertexPath::GetPointAtTime(v956, v535, 2);\n\tv564 = PathCreation.Examples.PathSceneTool::get_path(this);\n\tv517 = PathCreation.VertexPath::GetNormal(v564, v535, 2);\n\tv1034 = PathCreation.Examples.PathSceneTool::get_path(this);\n\tv1075 = PathCreation.VertexPath::GetDirection(v1034, v535, 2);\n\tv374 = v1075.y;\n\tv294 = v1075.z;\n\tv1041 = this.resolutionU;\n\tv977 = this.resolutionU < 1;\n\tif (v977) goto L_0366;\n\tv979 = v517.y * v1075.z;\n\tv980 = v517.z * v1075.y;\n\tv981 = v979 - v980;\n\tv263 = v517.z * v1075;\n\tv984 = v517 * v1075.z;\n\tv985 = v263 - v984;\n\tv986 = v517 * v1075.y;\n\tv987 = v517.y * v1075;\n\tv988 = v986 - v987;\n\tgoto L_0161;\nL_0150:\n\tv1339 = v617 + 1;\nL_0151:\n\tv1041 = this.resolutionU;\n\tv1012 = v1339 >= this.resolutionU;\n\tif (v1012) goto L_00FD;\nL_0161:\n\tv1047 = v617 / v1041;\n\tv1051 = v1047 * 0x40490FDB;\n\tv1052 = v1051 + v1051;\n\tv80 = 0x274A170(v1034, v1032, v1337, v132, v130, v135, v65, v66, v1052, 0x40490FDB, v294, v263, v1000, v253, v218, v74);\n\tv1073 = *([2DD4410]) == 0;\n\tif (v1073) goto L_0288;\n\tgoto L_0172;\nL_0172:\n\tv1120 = v1052 * this.thickness;\n\tv1121 = 0x40490FDB * this.thickness;\n\tv290 = v517 * v1120;\n\tv263 = v517.y * v1120;\n\tv1123 = v517.z * v1120;\n\tv258 = v981 * v1121;\n\tv253 = v985 * v1121;\n\tv1126 = v988 * v1121;\n\tv530 = v290 + v258;\n\tv215 = v263 + v253;\n\tv210 = v1123 + v1126;\n\tv1127 = v530 * v530;\n\tv1128 = v215 * v215;\n\tv1129 = v1127 + v1128;\n\tv1130 = v210 * v210;\n\tv1131 = v1130 + v1129;\n\tv518 = UnityEngine.Mathf::Sqrt(v1131);\n\tv380 = v518 <= 0x3727C5AC;\n\tif (v380) goto L_019F;\n\tv225 = v530 / v518;\n\tv204 = v215 / v518;\n\tv536 = v210 / v518;\n\tgoto L_01AF;\nL_019F:\n\tgoto L_01A6;\n\tv1178 = System.Xml.ValidateNames;\n\tv1179 = v1178 + 0xD0;\n\tv1180 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1179, v1032, v299, v62, v63, v64, v65, v66, v518, v370, v290, v265, v260, v255, v220, v74);\n\tv1183 = 1;\n\t*([2DD4419]) = v1183;\nL_01A6:\n\tv1184 = System.Xml.ValidateNames;\n\tv1186 = *([v1184 @ X8_v109 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv1176 = *([v1186 @ X8_v111+B8]);\n\tv225 = *([v1176 @ X8_v112]);\n\tv204 = *([v1176 @ X8_v112+4]);\n\tv536 = *([v1176 @ X8_v112+8]);\nL_01AF:\n\tv566 = UnityEngine.Component::get_transform(this);\n\tv1197 = v516 + v530;\n\tv1198 = v516.y + v215;\n\tv1200 = v516.z + v210;\n\t// 441 MakeStruct v199 @ AGG1022348_1_v5 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v1197 @ V0_v35 (System.Single), v1198 @ V1_v22 (System.Single), v1200 @ V2_v13 (System.Single)\n\tv519 = UnityEngine.Transform::InverseTransformPoint(v566, v199);\n\tv1202 = v80._version + 1;\n\tv80._version = v1202;\n\tv355 = v80._items;\n\tv1203 = v80._size < v355.Length;\n\tv503 = ~v1203;\n\tif (v503) goto L_01DB;\n\tv1204 = v80._size + 1;\n\tv80._size = v1204;\n\tv1206 = v80._size * 0xC;\n\tv1207 = v355 + v1206;\n\t*([v1207 @ X8_v105+20]) = v519;\n\tv355[v80._size (System.Int32)].y = v519.y;\n\tv355[v80._size (System.Int3\n// ... truncated")]
		private void CreateMesh()
		{
			//IL_000e: Expected I, but got O
			//IL_001d: Expected I, but got O
			//IL_177b: Expected O, but got I
			//IL_1795: Expected O, but got I
			//IL_0033: Expected O, but got I
			//IL_005a: Expected O, but got I4
			//IL_01c2: Expected I, but got O
			//IL_01d1: Unknown result type (might be due to invalid IL or missing references)
			//IL_01d6: Expected O, but got Unknown
			//IL_01e6: Expected O, but got I
			//IL_00a3: Expected I, but got O
			//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
			//IL_00b7: Expected O, but got Unknown
			//IL_00c7: Expected O, but got I
			//IL_038d: Unknown result type (might be due to invalid IL or missing references)
			//IL_0392: Expected O, but got Unknown
			//IL_039f: Expected O, but got F8
			//IL_17bb: Unknown result type (might be due to invalid IL or missing references)
			//IL_17c0: Expected I4, but got Unknown
			//IL_0445: Expected O, but got I
			//IL_06a8: Expected O, but got I4
			//IL_15dd: Expected O, but got I
			//IL_15eb: Expected I, but got O
			//IL_15fb: Expected O, but got I
			//IL_15c9: Expected O, but got F4
			//IL_16d5: Expected O, but got I4
			//IL_1647: Expected O, but got I4
			//IL_183f: Expected I, but got O
			//IL_184f: Expected O, but got I
			//IL_185f: Expected O, but got I
			//IL_1867: Expected F4, but got O
			//IL_1877: Expected F4, but got I
			//IL_1887: Expected F4, but got I
			//IL_1663: Expected I, but got O
			//IL_1673: Expected O, but got I
			//IL_09c6: Expected O, but got I
			//IL_189a: Expected I, but got O
			//IL_18aa: Expected O, but got I
			//IL_18ba: Expected O, but got I
			//IL_18c2: Expected F4, but got O
			//IL_18d2: Expected F4, but got I
			//IL_18e2: Expected F4, but got I
			//IL_0ca2: Expected O, but got I
			//IL_0cb2: Expected O, but got I
			//IL_0c27: Expected O, but got I
			//IL_1914: Expected O, but got F4
			//IL_0d3e: Expected O, but got I
			//IL_04d7: Expected O, but got F4
			//IL_0e54: Expected O, but got I
			//IL_0e64: Expected O, but got I
			//IL_0e74: Expected O, but got I
			//IL_0e97: Expected O, but got I
			//IL_0fb9: Expected O, but got I
			//IL_0fc9: Expected O, but got I
			//IL_0fd9: Expected O, but got I
			//IL_0ffc: Expected O, but got I
			//IL_10f4: Expected O, but got I
			//IL_1104: Expected O, but got I
			//IL_1114: Expected O, but got I
			//IL_1137: Expected O, but got I
			//IL_1213: Expected O, but got I
			//IL_1223: Expected O, but got I
			//IL_1233: Expected O, but got I
			//IL_1256: Expected O, but got I
			//IL_135f: Expected O, but got I
			//IL_136f: Expected O, but got I
			//IL_137f: Expected O, but got I
			//IL_13a2: Expected O, but got I
			//IL_13de: Unknown result type (might be due to invalid IL or missing references)
			//IL_13e3: Expected O, but got Unknown
			//IL_13ef: Expected O, but got I
			//IL_1339: Unknown result type (might be due to invalid IL or missing references)
			//IL_133e: Expected O, but got Unknown
			//IL_134a: Expected O, but got I
			//IL_1496: Expected O, but got I
			//IL_14a6: Expected O, but got I
			//IL_14b6: Expected O, but got I
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+530]");
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> list = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)0;
			list = new global::System.Collections.Generic.List<global::UnityEngine.Vector3>();
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X21_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+530]");
			list = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)0;
			list = new global::System.Collections.Generic.List<global::UnityEngine.Vector3>();
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v50 @ X22_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+110]");
			list = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)0;
			global::System.Collections.Generic.List<int> triangles = new global::System.Collections.Generic.List<int>();
			global::PathCreation.VertexPath vertexPath = base.path;
			object obj = 48054272;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4417]");
			float num3;
			object obj2;
			float num5;
			object obj3;
			if ((nint)0 != 0)
			{
				num3 = vertexPath.length * resolutionV;
				obj2 = (nint)0 + 2328;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v663 @ X23_v27 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
				list = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+E0]");
				bool flag = (nint)0 == 0;
				num5 = num3;
				obj3 = obj2;
				if (!flag)
				{
					goto IL_00fc;
				}
			}
			else
			{
				_ = 1;
				num3 = vertexPath.length * resolutionV;
				obj2 = (nint)0 + 2328;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v693 @ X23_v23 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
				list = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+E0]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num5 = num3;
				obj3 = obj2;
				if (flag3)
				{
					goto IL_00fc;
				}
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
			bool flag4 = num5 < 0f;
			float num7 = num5;
			float num8 = num5;
			obj2 = obj3;
			float num9 = num5;
			float num10 = num5;
			if (flag4)
			{
				goto IL_0150;
			}
			goto IL_027c;
			IL_17a3:
			double num12;
			double num13;
			double num11 = num12 + num13;
			double num14;
			if ((num14 & 1) != 0)
			{
				num12 = num11;
			}
			goto IL_0332;
			IL_1655:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1162 @ X8_v19 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+9E8]");
			list = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)0;
			global::UnityEngine.Mesh mesh = new global::UnityEngine.Mesh();
			global::PathCreation.Examples.CylinderMeshCreator cylinderMeshCreator;
			cylinderMeshCreator.mesh = mesh;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			goto IL_16f6;
			IL_0150:
			double num16 = default(double);
			if ((double)num7 == -0.5)
			{
				num13 = -1.0;
				num12 = num16;
				num14 = num16;
				goto IL_17a3;
			}
			double a = (double)num8 + -0.5;
			num12 = global::System.Math.Ceiling(a);
			goto IL_0332;
			IL_00fc:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
			bool flag5 = !(num3 < 0f);
			num7 = num3;
			num8 = num3;
			num9 = num3;
			num10 = num3;
			obj3 = obj2;
			if (!flag5)
			{
				goto IL_0150;
			}
			goto IL_027c;
			IL_027c:
			if ((double)num9 == 0.5)
			{
				num13 = 1.0;
				num12 = 0.0;
				obj2 = obj3;
				num14 = 0.0;
				goto IL_17a3;
			}
			double d = (double)num10 + 0.5;
			num12 = global::System.Math.Floor(d);
			obj2 = obj3;
			goto IL_0332;
			IL_16f6:
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> list2;
			cylinderMeshCreator.mesh.SetVertices(list2);
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> normals;
			cylinderMeshCreator.mesh.SetNormals(normals);
			cylinderMeshCreator.mesh.SetTriangles(triangles, 0);
			cylinderMeshCreator.mesh.RecalculateBounds();
			cylinderMeshCreator.meshFilter.sharedMesh = cylinderMeshCreator.mesh;
			return;
			IL_0332:
			double num17 = num12 + double.Epsilon;
			double num18 = num17 - 1E-323;
			bool flag6 = num18 < 0.0;
			bool flag7 = num18 == 0.0;
			object obj4 = num17 ^ 2;
			object obj5 = num17 ^ num18;
			int num19 = (int)((nint)obj4 & (nint)obj5);
			bool flag8 = num19 < 0;
			bool flag9 = flag6 == flag8;
			bool flag10 = !flag9;
			double num20 = ((!(flag10 || flag7)) ? (num12 + double.Epsilon) : 1E-323);
			if (num12 == 9.218868437227405E+18)
			{
				num20 = 1E-323;
			}
			global::PathCreation.VertexPath vertexPath2 = base.path;
			object obj6 = (nint)0 + (nint)2976;
			double num21 = num20 + -1.0;
			double num22 = num20 - double.Epsilon;
			int num23 = 0;
			int num24 = 0;
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> list3 = list;
			float num30 = default(float);
			float num46 = default(float);
			float num36 = default(float);
			global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector3 direction2 = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector3 item2 = default(global::UnityEngine.Vector3);
			float num82 = default(float);
			while (true)
			{
				double num25 = (double)num24 / num21;
				global::UnityEngine.Vector3 pointAtTime = vertexPath2.GetPointAtTime((float)num25, global::PathCreation.EndOfPathInstruction.Stop);
				global::PathCreation.VertexPath vertexPath3 = base.path;
				global::UnityEngine.Vector3 normal = vertexPath3.GetNormal((float)num25, global::PathCreation.EndOfPathInstruction.Stop);
				global::PathCreation.VertexPath vertexPath4 = base.path;
				global::UnityEngine.Vector3 direction = vertexPath4.GetDirection((float)num25, global::PathCreation.EndOfPathInstruction.Stop);
				float y = direction.y;
				float z = direction.z;
				int num26 = resolutionU;
				if (resolutionU >= 1)
				{
					float num27 = normal.y * direction.z;
					float num28 = normal.z * direction.y;
					float num29 = num27 - num28;
					num30 = normal.z * direction.x;
					float num31 = normal.x * direction.z;
					float num32 = num30 - num31;
					float num33 = normal.x * direction.y;
					float num34 = normal.y * direction.x;
					float num35 = num33 - num34;
					num36 = num29;
					global::UnityEngine.Vector3 vector = normal;
					z = num32;
					object obj7 = 0;
					int num37 = num23;
					global::PathCreation.EndOfPathInstruction endOfPathInstruction = global::PathCreation.EndOfPathInstruction.Stop;
					int num38 = 0;
					float num63;
					bool flag13;
					do
					{
						int num39 = num38 / num26;
						int num40 = num39 * 1078530011;
						int num41 = num40 + num40;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A170");
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4410]");
						if ((nint)0 == 0)
						{
							_ = 1;
						}
						float num42 = (float)num41 * thickness;
						float num43 = (float)global::System.Math.PI * thickness;
						float num44 = normal.x * num42;
						num30 = normal.y * num42;
						float num45 = normal.z * num42;
						num46 = num29 * num43;
						num36 = num32 * num43;
						float num47 = num35 * num43;
						float num48 = num44 + num46;
						float num49 = num30 + num36;
						float num50 = num45 + num47;
						float num51 = num48 * num48;
						float num52 = num49 * num49;
						float num53 = num51 + num52;
						float num54 = num50 * num50;
						float f = num54 + num53;
						float num55 = global::UnityEngine.Mathf.Sqrt(f);
						float x;
						float y2;
						float z2;
						if (num55 > 1E-05f)
						{
							x = num48 / num55;
							y2 = num49 / num55;
							z2 = num50 / num55;
						}
						else
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1184 @ X8_v109 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
							object obj8 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1186 @ X8_v111+B8]");
							object obj9 = 0;
							x = (float)obj9;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ X8_v112+4]");
							y2 = 0f;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1176 @ X8_v112+8]");
							z2 = 0f;
						}
						global::UnityEngine.Transform transform = base.transform;
						float x2 = pointAtTime.x + num48;
						float y3 = pointAtTime.y + num49;
						float z3 = pointAtTime.z + num50;
						position.x = x2;
						position.y = y3;
						position.z = z3;
						global::UnityEngine.Vector3 item = transform.InverseTransformPoint(position);
						list.Add(item);
						global::UnityEngine.Transform transform2 = base.transform;
						direction2.x = x;
						direction2.y = y2;
						direction2.z = z2;
						global::UnityEngine.Vector3 vector2 = transform2.InverseTransformDirection(direction2);
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4410]");
						if ((nint)0 != 0)
						{
							list = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)obj2;
						}
						else
						{
							_ = 1;
							list = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)obj2;
						}
						float num58 = vector2.x * vector2.x;
						float num59 = vector2.y * vector2.y;
						float num60 = num58 + num59;
						float num61 = vector2.z * vector2.z;
						float f2 = num61 + num60;
						float num62 = global::UnityEngine.Mathf.Sqrt(f2);
						if (num62 > 1E-05f)
						{
							num63 = vector2.x / num62;
							y = vector2.y / num62;
							z = vector2.z / num62;
						}
						else
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1274 @ X8_v95 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
							object obj11 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1276 @ X8_v97+B8]");
							object obj12 = 0;
							num63 = (float)obj12;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X8_v98+4]");
							y = 0f;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1267 @ X8_v98+8]");
							z = 0f;
						}
						int num66 = 0;
						item2.x = num63;
						item2.y = y;
						item2.z = z;
						list3.Add(item2);
						list = list3;
						if (!((double)num37 < num22))
						{
							goto IL_06c7;
						}
						int num68 = num37 * resolutionU;
						int num69 = num68 + num38;
						triangles.Add(num69);
						int num71 = num38 + 1;
						int num72 = num71 / resolutionU;
						int num73 = num72 * resolutionU;
						int num74 = num71 - num73;
						int num75 = num74 + num68;
						triangles.Add(num75);
						int num77 = num68 + resolutionU;
						int num78 = num77 + num38;
						triangles.Add(num78);
						triangles.Add(num75);
						num66 = num77 + num74;
						triangles.Add(num66);
						triangles.Add(num78);
						num37 = num23;
						num66 = num78;
						vertexPath4 = (global::PathCreation.VertexPath)(object)triangles;
						list3 = list;
						goto IL_18e7;
						IL_18e7:
						num26 = resolutionU;
						flag13 = num71 >= resolutionU;
						num82 = num35;
						vector = (global::UnityEngine.Vector3)num46;
						endOfPathInstruction = (global::PathCreation.EndOfPathInstruction)num66;
						num38 = num71;
						continue;
						IL_06c7:
						num71 = num38 + 1;
						vertexPath4 = (global::PathCreation.VertexPath)(object)list;
						goto IL_18e7;
					}
					while (!flag13);
					num23 = num37 + 1;
					bool flag14 = (double)num23 == num20;
					num82 = num35;
					float num83 = num35;
					float num84 = num36;
					float num85 = num46;
					float num86 = num30;
					direction = (global::UnityEngine.Vector3)num63;
					normals = list3;
					list2 = list;
					cylinderMeshCreator = this;
					if (flag14)
					{
						break;
					}
				}
				else
				{
					num23++;
					if ((double)num23 == num20)
					{
						float num83 = num82;
						float num84 = num36;
						float num85 = num46;
						float num86 = num30;
						normals = list3;
						list2 = list;
						cylinderMeshCreator = this;
						break;
					}
				}
				vertexPath2 = base.path;
				num24 = num23;
			}
			if (cylinderMeshCreator.addCaps)
			{
				cylinderMeshCreator.AddHemisphereCap(0f, startCap: true, ref list, ref list, ref triangles, list2.Count);
				cylinderMeshCreator.AddHemisphereCap(1f, startCap: false, ref list, ref list, ref triangles, list2.Count);
				global::UnityEngine.Vector3 direction = (global::UnityEngine.Vector3)1f;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1107 @ X8_v15 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			list = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v80 @ X0_v3 (System.Collections.Generic.List`1<UnityEngine.Vector3>)+E0]");
			if ((nint)0 != 0)
			{
				bool flag15 = cylinderMeshCreator.mesh == null;
				bool flag16 = !flag15;
				object obj31 = 0;
				if (!flag16)
				{
					goto IL_1655;
				}
			}
			else
			{
				bool flag17 = cylinderMeshCreator.mesh == null;
				bool flag18 = !flag17;
				bool flag19 = !flag18;
				object obj31 = 0;
				if (flag19)
				{
					goto IL_1655;
				}
			}
			cylinderMeshCreator.mesh.Clear();
			goto IL_16f6;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600049D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1022960", Offset = "0x1022960", Length = "0xF04")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002D;\n\tv61 = Il2CppMethodInfo;\n\tv62 = v61 + 0x410;\n\tv63 = \"il2cpp_codegen_initialize_runtime_metadata\"(v62, startCap, verts, normals, triangles, vertOffset, methodInfo, v65, t, v66, v67, v68, v69, v70, v71, v72);\n\tv80 = Il2CppMethodInfo;\n\tv81 = v80 + 0xBA0;\n\tv74 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, startCap, verts, normals, triangles, vertOffset, methodInfo, v65, t, v66, v67, v68, v69, v70, v71, v72);\n\tv76 = 1;\n\t*([302AB02]) = v76;\nL_002D:\n\tv79 = PathCreation.Examples.PathSceneTool::get_path(this);\n\tv86 = PathCreation.VertexPath::GetPointAtTime(v79, t, 2);\n\tv706 = PathCreation.Examples.PathSceneTool::get_path(this);\n\tv696 = PathCreation.VertexPath::GetNormal(v706, t, 2);\n\tv707 = PathCreation.Examples.PathSceneTool::get_path(this);\n\tv697 = PathCreation.VertexPath::GetDirection(v707, t, 2);\n\tv567 = -v697;\n\tv614 = -v697.y;\n\tv603 = -v697.z;\n\tv464 = startCap == 0;\n\tv985 = ~v464;\n\tv986 = ~v985;\n\tif (v986) goto L_FFFFFFFF;\n\tgoto L_0068;\nL_0068:\n\tv989 = ~v464;\n\tv990 = ~v989;\n\tif (v990) goto L_FFFFFFFF;\n\tgoto L_0070;\nL_0070:\n\tv350 = ~v464;\n\tv347 = ~v350;\n\tif (v347) goto L_FFFFFFFF;\n\tgoto L_0079;\nL_0079:\n\tv201 = verts->klass;\n\tv708 = UnityEngine.Component::get_transform(this);\n\tv996 = this.thickness * v1529;\n\tv998 = v86.z + v996;\n\tv999 = this.thickness * v1528;\n\tv1001 = v86.y + v999;\n\tv1002 = this.thickness * v327;\n\tv1003 = v86 + v1002;\n\t// 137 MakeStruct v325 @ AGG1022AB4_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v1003 @ V0_v11 (System.Single), v1001 @ V1_v8 (System.Single), v998 @ V2_v6 (System.Single)\n\tv698 = UnityEngine.Transform::InverseTransformPoint(v708, v325);\n\tv1004 = Il2CppMethodInfo;\n\tv1006 = v201._version + 1;\n\tv201._version = v1006;\n\tv287 = v201._items;\n\tv1007 = v201._size < v287.Length;\n\tv543 = ~v1007;\n\tif (v543) goto L_00AE;\n\tv1008 = v201._size + 1;\n\tv201._size = v1008;\n\tv1010 = v201._size * 0xC;\n\tv1011 = v287 + v1010;\n\t*([v1011 @ X8_v216+20]) = v698;\n\tv287[v201._size (System.Int32)].y = v698.y;\n\tv287[v201._size (System.Int32)].z = v698.z;\n\tgoto L_00B5;\nL_00AE:\n\t;\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector3>::AddWithResize(v201, v698);\nL_00B5:\n\tv229 = normals->klass;\n\tv709 = UnityEngine.Component::get_transform(this);\n\t// 192 MakeStruct v224 @ AGG1022B4C_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v327 @ V11_v2 (UnityEngine.Vector3), v1528 @ V15_v8 (System.Single), v1529 @ V14_v8 (System.Single)\n\tv1025 = UnityEngine.Transform::InverseTransformDirection(v709, v224);\n\tv1029 = *([2DD4410]) == 0;\n\tif (v1029) goto L_0341;\n\tv1030 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv202 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv1362 = *([v1030 @ X25_v22 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tgoto L_00D1;\nL_00D1:\n\tv1049 = v1025 * v1025;\n\tv1050 = v1025.y * v1025.y;\n\tv1051 = v1049 + v1050;\n\tv1052 = v1025.z * v1025.z;\n\tv1053 = v1052 + v1051;\n\tv1054 = UnityEngine.Mathf::Sqrt(v1053);\n\tv351 = v1054 <= 0x3727C5AC;\n\tif (v351) goto L_00EF;\n\tv699 = v1025 / v1054;\n\tv616 = v1025.y / v1054;\n\tv605 = v1025.z / v1054;\n\tgoto L_00FE;\nL_00EF:\n\tgoto L_00F5;\n\tv1078 = System.Xml.ValidateNames;\n\tv1079 = v1078 + 0xD0;\n\tv1080 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1079, v663, v624, normals, triangles, vertOffset, methodInfo, v65, v1061, v1052, v1054, v568, v69, v70, v71, v72);\n\tv1082 = 1;\n\t*([2DD4419]) = v1082;\nL_00F5:\n\tv1083 = System.Xml.ValidateNames;\n\tv1085 = *([v1083 @ X8_v206 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv1077 = *([v1085 @ X8_v208+B8]);\n\tv699 = *([v1077 @ X8_v209]);\n\tv616 = *([v1077 @ X8_v209+4]);\n\tv605 = *([v1077 @ X8_v209+8]);\nL_00FE:\n\tv801 = *([v1004 @ X23_v2 (Il2CppMethodInfo)+BA0]);\n\tv1087 = v229._version + 1;\n\tv229._version = v1087;\n\tv288 = v229._items;\n\tv1090 = v229._size < v288.Length;\n\tv1091 = ~v1090;\n\tif (v1091) goto L_011A;\n\tv1099 = v229._size + 1;\n\tv229._size = v1099;\n\tv1101 = v229._size * 0xC;\n\tv1102 = v288 + v1101;\n\t*([v1102 @ X8_v203+20]) = v699;\n\tv288[v229._size (System.Int32)].y = v616;\n\tv288[v229._size (System.Int32)].z = v605;\n\tgoto L_0121;\nL_011A:\n\tv1103 = *([v801 @ X8_v17+20]);\n\tv1104 = *([v1103 @ X8_v199+C0]);\n\tv1562 = *([v1104 @ X8_v200+70]);\n\t// 286 MakeStruct v1107 @ AGG1022C48_1_v3 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v699 @ V0_v19 (System.Single), v616 @ V1_v14 (System.Single), v605 @ V2_v11 (System.Single)\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector3>::AddWithResize(v229, v1107);\nL_0121:\n\tv1113 = vertOffset + 1;\n\tv1196 = this.capSegmentsV;\n\tv1391 = this.resolutionU;\n\tv1126 = this.capSegmentsV < 1;\n\tif (v1126) goto L_02AD;\n\tv1137 = this.resolutionU < 1;\n\tif (v1137) goto L_03DF;\n\tv1210 = v696.y * v697.z;\n\tv1211 = v696.z * v697.y;\n\tv1560 = v696.z * v697;\n\tv1557 = v696 * v697.z;\n\tv1519 = v696 * v697.y;\n\tv1521 = v696.y * v697;\n\tv1218 = v1210 - v1211;\n\tv1219 = v1560 - v1557;\n\tv1220 = v1519 - v1521;\n\tv1222 = System.Xml.ValidateNames;\n\tgoto L_0167;\nL_0154:\n\tv1196 = this.capSegmentsV;\nL_0156:\n\tv1364 = v1364 + 1;\n\tv1162 = v1364 > v1196;\n\tif (v1162) goto L_02AD;\nL_0167:\n\tv1369 = v1364 / v1196;\n\tv1373 = v1369 * 0x3FC90FDB;\n\tv1362 = 0x274A170(v1362, v1562, 0, normals, triangles, vertOffset, methodInfo, v65, v1373, 0x3FC90FDB, v1560, v1557, v1519, v1521, v1520, v72);\n\tv1434 = v1522 < 1;\n\tif (v1434) goto L_0156;\n\tgoto L_0192;\nL_017D:\n\tv2047 = *([v805 @ X8_v175+20]);\n\tv1570 = *([v2047 @ X8_v179+C0]);\n\tv1465 = *([v1570 @ X8_v180+70]);\n\t// 385 MakeStruct v1518 @ AGG1022D20_1_v7 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v702 @ V0_v52 (System.Single), v619 @ V1_v42 (System.Single), v1560 @ V2_v18 (System.Single)\n\tSystem.Collections.Generic.List`1<UnityEngine.Vector3>::AddWithResize(v120, v1518);\n\tv858 = v858 + 1;\n\tv1444 = this.resolutionU;\n\tv1531 = v858 >= this.resolutionU;\n\tif (v1531) goto L_0154;\nL_0192:\n\tv1577 = v858 / v1522;\n\tv1581 = v1577 * 0x40490FDB;\n\tv1582 = v1581 + v1581;\n\tv1584 = 0x274A170(v1362, v1562, 0, normals, triangles, vertOffset, methodInfo, v65, v1582, 0x40490FDB, v1560, v1557, v1519, v1521, v1520, v72);\n\tv1674 = *([2DD4410]) == 0;\n\tif (v1674) goto L_028E;\n\tv187 = Il2CppMethodInfo + 0xBA0;\n\tgoto L_01A6;\nL_01A6:\n\tv1716 = v1373 * v1582;\n\tv1717 = v1716 * this.thickness;\n\tv1718 = v1373 * 0x40490FDB;\n\tv1719 = v1718 * this.thickness;\n\tv1722 = v696 * v1717;\n\tv1723 = v696.y * v1717;\n\tv1725 = v696.z * v1717;\n\tv1728 = v1218 * v1719;\n\tv1729 = v1219 * v1719;\n\tv1730 = v1220 * v1719;\n\tv606 = v1722 + v1728;\n\tv1557 = v1723 + v1729;\n\tv1731 = v1725 + v1730;\n\tv1733 = 0x3FC90FDB * this.thickness;\n\tv1519 = v327 * v1733;\n\tv1521 = v1528 * v1733;\n\tv1735 = v1529 * v1733;\n\tv341 = v1519 + v606;\n\tv335 = v1521 + v1557;\n\tv852 = v1735 + v1731;\n\tv1736 = v341 * v341;\n\tv1737 = v335 * v335;\n\tv1738 = v1736 + v1737;\n\tv1739 = v852 * v852;\n\tv1740 = v1739 + v1738;\n\tv700 = UnityEngine.Mathf::Sqrt(v1740);\n\tv352 = v700 <= 0x3727C5AC;\n\tif (v352) goto L_01DF;\n\tv329 = v341 / v700;\n\tv218 = v335 / v700;\n\tv212 = v852 / v700;\n\tgoto L_01EA;\nL_01DF:\n\tgoto L_01E4;\n\tv1798 = v230;\n\tv1799 = \"il2cpp_codegen_initialize_runtime_metadata\"(v1798, v1562, v624, normals, triangles, vertOffset, methodInfo, v65, v700, v617, v606, v569, v175, v183, v179, v72);\n\tv1801 = 1;\n\t*([2DD4419]) = v1801;\nL_01E4:\n\tv1802 = *([v1222 @ X26_v9 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv1796 = *([v1802 @ X8_v195+B8]);\n\tv329 = *([v1796 @ X8_v196]);\n\tv218 = *([v1796 @ X8_v196+4]);\n\tv212 = *([v1796 @ X8_v196+8]);\nL_01EA:\n\tv119 = verts->klass;\n\tv711 = UnityEngine.Component::get_transform(this);\n\tv1850 = v86 + v341;\n\tv1851 = v86.y + v335;\n\tv1853 = v86.z + v852;\n\t// 503 MakeStruct v135 @ AGG1022E80_1_v7 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v1850 @ V0_v44 (System.Single), v1851 @ V1_v36 (System.Single), v1853 @ V2_v23 (System.Single)\n\tv701 = UnityEngine.Transform::InverseTransformPoint(v711, v135);\n\tv1874 = v119._version + 1;\n\tv119._version = v1874;\n\tv290 = v119._items;\n\tv1880 = v119._size < v290.Length;\n\tv546 = ~v1880;\n\tif (v546) goto L_0219;\n\tv1889 = v119._size + 1;\n\tv119._size = v1889;\n\tv1891 = v119._size * 0xC;\n\tv1892 = v290 + v1891;\n\t*([v1892 @ X8_v192+20]) = v701;\n\tv290[v119._size (System.Int32)].y = v701.y;\n\tv290[v119._size (System.Int32)].z = v701.z;\n\tgoto L_0222;\nL_\n// ... truncated")]
		private void AddHemisphereCap(float t, bool startCap, ref global::System.Collections.Generic.List<global::UnityEngine.Vector3> verts, ref global::System.Collections.Generic.List<global::UnityEngine.Vector3> normals, ref global::System.Collections.Generic.List<int> triangles, int vertOffset)
		{
			//IL_0069: Unsupported input type for neg.
			//IL_0069: Unknown result type (might be due to invalid IL or missing references)
			//IL_006e: Expected O, but got Unknown
			//IL_026e: Expected O, but got I
			//IL_12a4: Expected I, but got O
			//IL_12b3: Unknown result type (might be due to invalid IL or missing references)
			//IL_12b8: Expected O, but got Unknown
			//IL_12c8: Expected O, but got I
			//IL_0354: Expected I, but got O
			//IL_0363: Unknown result type (might be due to invalid IL or missing references)
			//IL_0368: Expected O, but got Unknown
			//IL_0378: Expected O, but got I
			//IL_22f5: Expected I, but got O
			//IL_2305: Expected O, but got I
			//IL_2315: Expected O, but got I
			//IL_231d: Expected F4, but got O
			//IL_232d: Expected F4, but got I
			//IL_233d: Expected F4, but got I
			//IL_046b: Expected O, but got I
			//IL_0565: Expected O, but got I
			//IL_0575: Expected O, but got I
			//IL_0585: Expected O, but got I
			//IL_050c: Expected O, but got I
			//IL_0550: Expected O, but got I4
			//IL_06f7: Expected I, but got O
			//IL_0eff: Expected O, but got I
			//IL_08c9: Expected O, but got I
			//IL_239c: Expected O, but got I
			//IL_23ac: Expected O, but got I
			//IL_23b4: Expected F4, but got O
			//IL_23c4: Expected F4, but got I
			//IL_23d4: Expected F4, but got I
			//IL_0be1: Expected O, but got I
			//IL_23e9: Expected O, but got I
			//IL_23f9: Expected O, but got I
			//IL_2401: Expected F4, but got O
			//IL_2411: Expected F4, but got I
			//IL_2421: Expected F4, but got I
			//IL_07a6: Expected O, but got I
			//IL_07b6: Expected O, but got I
			//IL_07c6: Expected O, but got I
			//IL_084f: Expected O, but got I
			//IL_0e4b: Expected O, but got I
			//IL_0ebf: Expected O, but got I4
			//IL_0ee0: Expected O, but got I4
			global::PathCreation.VertexPath vertexPath = base.path;
			global::UnityEngine.Vector3 pointAtTime = vertexPath.GetPointAtTime(t, global::PathCreation.EndOfPathInstruction.Stop);
			global::PathCreation.VertexPath vertexPath2 = base.path;
			global::UnityEngine.Vector3 normal = vertexPath2.GetNormal(t, global::PathCreation.EndOfPathInstruction.Stop);
			global::PathCreation.VertexPath vertexPath3 = base.path;
			global::UnityEngine.Vector3 direction = vertexPath3.GetDirection(t, global::PathCreation.EndOfPathInstruction.Stop);
			global::UnityEngine.Vector3 vector = 0 - direction;
			float num = 0f - direction.y;
			float num2 = 0f - direction.z;
			bool flag = !startCap;
			float num3 = (flag ? direction.z : num2);
			float num4 = (flag ? direction.y : num);
			global::UnityEngine.Vector3 vector2 = (flag ? direction : vector);
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> list = verts;
			global::UnityEngine.Transform transform = base.transform;
			float num5 = thickness * num3;
			float z = pointAtTime.z + num5;
			float num6 = thickness * num4;
			float y = pointAtTime.y + num6;
			float num7 = thickness * vector2.x;
			float x = pointAtTime.x + num7;
			global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
			position.x = x;
			position.y = y;
			position.z = z;
			global::UnityEngine.Vector3 item = transform.InverseTransformPoint(position);
			nint num8 = 0;
			list.Add(item);
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> list2 = normals;
			global::UnityEngine.Transform transform2 = base.transform;
			global::UnityEngine.Vector3 direction2 = default(global::UnityEngine.Vector3);
			direction2.x = vector2.x;
			direction2.y = num4;
			direction2.z = num3;
			global::UnityEngine.Vector3 vector3 = transform2.InverseTransformDirection(direction2);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4410]");
			object obj2;
			if ((nint)0 != 0)
			{
				obj2 = (nint)0 + 2328;
			}
			else
			{
				_ = 1;
				obj2 = (nint)0 + 2328;
			}
			float num12 = vector3.x * vector3.x;
			float num13 = vector3.y * vector3.y;
			float num14 = num12 + num13;
			float num15 = vector3.z * vector3.z;
			float f = num15 + num14;
			float num16 = global::UnityEngine.Mathf.Sqrt(f);
			float x2;
			float y2;
			float z2;
			if (num16 > 1E-05f)
			{
				x2 = vector3.x / num16;
				y2 = vector3.y / num16;
				z2 = vector3.z / num16;
			}
			else
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1083 @ X8_v206 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
				object obj3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1085 @ X8_v208+B8]");
				object obj4 = 0;
				x2 = (float)obj4;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X8_v209+4]");
				y2 = 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1077 @ X8_v209+8]");
				z2 = 0f;
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1004 @ X23_v2 (Il2CppMethodInfo)+BA0]");
			object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v801 @ X8_v17+20]");
				object obj8 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1103 @ X8_v199+C0]");
				object obj9 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1104 @ X8_v200+70]");
				object obj7 = 0;
				global::UnityEngine.Vector3 item2 = default(global::UnityEngine.Vector3);
				item2.x = x2;
				item2.y = y2;
				item2.z = z2;
				list2.Add(item2);
				global::System.Collections.Generic.List<global::UnityEngine.Vector3> list3 = list2;
			int num19 = vertOffset + 1;
			int num20 = capSegmentsV;
			int num21 = resolutionU;
			if (capSegmentsV >= 1)
			{
				if (resolutionU < 1)
				{
					goto IL_15fc;
				}
				float num22 = normal.y * direction.z;
				float num23 = normal.z * direction.y;
				float num24 = normal.z * direction.x;
				float num25 = normal.x * direction.z;
				float num26 = normal.x * direction.y;
				float num27 = normal.y * direction.x;
				float num28 = num22 - num23;
				float num29 = num24 - num25;
				float num30 = num26 - num27;
				float num32 = num28;
				int num33 = resolutionU;
				int num34 = 1;
				global::UnityEngine.Vector3 position2 = default(global::UnityEngine.Vector3);
				global::UnityEngine.Vector3 direction3 = default(global::UnityEngine.Vector3);
				global::UnityEngine.Vector3 item4 = default(global::UnityEngine.Vector3);
				bool flag4;
				do
				{
					int num35 = num34 / num20;
					int num36 = num35 * 1070141403;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A170");
					if (num33 >= 1)
					{
						int num37 = 0;
						object obj19 = null;
						int num69;
						global::System.Collections.Generic.List<global::UnityEngine.Vector3> list6;
						while (true)
						{
							int num38 = num37 / num33;
							int num39 = num38 * 1078530011;
							int num40 = num39 + num39;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A170");
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4410]");
							object obj10;
							if ((nint)0 != 0)
							{
								obj10 = (nint)0 + (nint)2976;
							}
							else
							{
								_ = 1;
								obj10 = (nint)0 + (nint)2976;
							}
							int num41 = num36 * num40;
							float num42 = (float)num41 * thickness;
							int num43 = num36 * 1078530011;
							float num44 = (float)num43 * thickness;
							float num45 = normal.x * num42;
							float num46 = normal.y * num42;
							float num47 = normal.z * num42;
							float num48 = num28 * num44;
							float num49 = num29 * num44;
							float num50 = num30 * num44;
							float num51 = num45 + num48;
							num25 = num46 + num49;
							float num52 = num47 + num50;
							float num53 = (float)global::System.Math.PI / 2f * thickness;
							num26 = vector2.x * num53;
							num27 = num4 * num53;
							float num54 = num3 * num53;
							float num55 = num26 + num51;
							float num56 = num27 + num25;
							float num57 = num54 + num52;
							float num58 = num55 * num55;
							float num59 = num56 * num56;
							float num60 = num58 + num59;
							float num61 = num57 * num57;
							float f2 = num61 + num60;
							float num62 = global::UnityEngine.Mathf.Sqrt(f2);
							float x3;
							float y3;
							float z3;
							if (num62 > 1E-05f)
							{
								x3 = num55 / num62;
								y3 = num56 / num62;
								z3 = num57 / num62;
							}
							else
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X26_v9 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
								object obj11 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1802 @ X8_v195+B8]");
								object obj12 = 0;
								x3 = (float)obj12;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1796 @ X8_v196+4]");
								y3 = 0f;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1796 @ X8_v196+8]");
								z3 = 0f;
							}
							global::System.Collections.Generic.List<global::UnityEngine.Vector3> list4 = verts;
							global::UnityEngine.Transform transform3 = base.transform;
							float x4 = pointAtTime.x + num55;
							float y4 = pointAtTime.y + num56;
							float z4 = pointAtTime.z + num57;
							position2.x = x4;
							position2.y = y4;
							position2.z = z4;
							global::UnityEngine.Vector3 item3 = transform3.InverseTransformPoint(position2);
							list4.Add(item3);
							global::System.Collections.Generic.List<global::UnityEngine.Vector3> list5 = normals;
							global::UnityEngine.Transform transform4 = base.transform;
							direction3.x = x3;
							direction3.y = y3;
							direction3.z = z3;
							global::UnityEngine.Vector3 vector4 = transform4.InverseTransformDirection(direction3);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4410]");
							if ((nint)0 != 0)
							{
								list3 = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)obj2;
							}
							else
							{
								_ = 1;
								list3 = (global::System.Collections.Generic.List<global::UnityEngine.Vector3>)obj2;
							}
							float num64 = vector4.x * vector4.x;
							float num65 = vector4.y * vector4.y;
							float num66 = num64 + num65;
							float num67 = vector4.z * vector4.z;
							float f3 = num67 + num66;
							float num68 = global::UnityEngine.Mathf.Sqrt(f3);
							float x5;
							float y5;
							if (num68 > 1E-05f)
							{
								x5 = vector4.x / num68;
								y5 = vector4.y / num68;
								num24 = vector4.z / num68;
							}
							else
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1222 @ X26_v9 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
								object obj14 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2028 @ X8_v184+B8]");
								object obj15 = 0;
								x5 = (float)obj15;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2023 @ X8_v185+4]");
								y5 = 0f;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2023 @ X8_v185+8]");
								num24 = 0f;
							}
							item4.x = x5;
							item4.y = y5;
							item4.z = num24;
							list5.Add(item4);
							num37++;
							num69 = resolutionU;
							bool flag2 = num37 >= resolutionU;
							list6 = list5;
							num32 = num30;
							num33 = resolutionU;
							obj7 = 0;
							list3 = list5;
							if (flag2)
							{
								break;
							}
						}
						num20 = capSegmentsV;
						num32 = num30;
						num33 = num69;
						obj7 = obj19;
						list3 = list6;
					}
					num34++;
					flag4 = num34 > num20;
					num21 = num33;
				}
				while (!flag4);
			}
			if (num21 >= 1)
			{
				if (startCap)
				{
					int num71 = num21;
					int num72 = 1;
					while (true)
					{
						global::System.Collections.Generic.List<int> list7 = triangles;
						list7.Add(vertOffset);
						int num73 = num72 / num71;
						int num74 = num73 * num71;
						int num75 = num72 - num74;
						int num76 = num75 + num19;
						list7.Add(num76);
						int num77 = vertOffset + num72;
						list7.Add(num77);
							num71 = resolutionU;
							int num79 = num72 + 1;
							bool flag6 = num72 < resolutionU;
							num72 = num79;
							if (!flag6)
							{
								num21 = resolutionU;
								break;
							}
					}
				}
				else
				{
					int num80 = num21;
					int num81 = 1;
					while (true)
					{
						global::System.Collections.Generic.List<int> list8 = triangles;
						list8.Add(vertOffset);
						int num82 = vertOffset + num81;
						list8.Add(num82);
						int num83 = num81 / num80;
						int num84 = num83 * num80;
						int num85 = num81 - num84;
						int num86 = num85 + num19;
						list8.Add(num86);
						num80 = resolutionU;
						int num88 = num81 + 1;
						bool flag8 = num81 < resolutionU;
						num81 = num88;
						num21 = resolutionU;
						if (!flag8)
						{
							break;
						}
					}
				}
			}
			goto IL_15fc;
			IL_15fc:
			if (capSegmentsV <= 1 || num21 < 1)
			{
				return;
			}
			int num89 = 1;
			int num90 = 0;
			do
			{
				if (num21 >= 1)
				{
					int num91 = num89 - 1;
					int num92 = num21 * num91;
					int num93 = num19 + num92;
					int num94 = num21 * num89;
					int num95 = num19 + num94;
					int num96 = num21 * num89;
					int num97 = vertOffset + num96;
					int num98 = num21 * num90;
					int num99 = vertOffset + num98;
					if (startCap)
					{
						int num100 = num21;
						int num101 = 1;
						while (true)
						{
							global::System.Collections.Generic.List<int> list9 = triangles;
							int num103 = num101 / num100;
							int num104 = num103 * num100;
							int num105 = num101 - num104;
							int num102 = num97 + num105;
								list9.Add(num102);
								list9 = triangles;
							int version12 = list9._version + 1;
							list9._version = version12;
							int[] items12 = list9._items;
							int num106 = num105 + num93;
							list9.Add(num106);
								list9 = triangles;
								int num107 = num99 + num105;
								list9.Add(num107);
								list9 = triangles;
								list9.Add(num106);
								list9 = triangles;
								int num108 = num99 + num105;
								list9.Add(num108);
								list9 = triangles;
							int version16 = list9._version + 1;
							list9._version = version16;
							int[] items16 = list9._items;
							list9.Add(num107);
								num100 = resolutionU;
								int num110 = num101 + 1;
								bool flag10 = num101 < resolutionU;
								num101 = num110;
								if (!flag10)
								{
									num21 = resolutionU;
									break;
								}
						}
					}
					else
					{
						int num111 = num21;
						int num112 = 1;
						while (true)
						{
							global::System.Collections.Generic.List<int> list10 = triangles;
							int num115 = num112 / num111;
							int num116 = num115 * num111;
							int num117 = num112 - num116;
							int num113 = num97 + num117;
								list10.Add(num113);
								list10 = triangles;
								int num114 = num99 + num117;
								list10.Add(num114);
								list10 = triangles;
							int version19 = list10._version + 1;
							list10._version = version19;
							int[] items19 = list10._items;
							int num118 = num117 + num93;
							list10.Add(num118);
								list10 = triangles;
								list10.Add(num118);
								list10 = triangles;
								list10.Add(num114);
								list10 = triangles;
							int version22 = list10._version + 1;
							list10._version = version22;
							int[] items22 = list10._items;
							int num119 = num117 + num95;
							int count18 = list10.Count;
							if (list10.Count >= items22.Length)
							{
								list10.Add(num119);
								num21 = resolutionU;
								int num120 = num112 + 1;
								bool flag11 = num112 >= resolutionU;
								num111 = resolutionU;
								num112 = num120;
								if (flag11)
								{
									break;
								}
								continue;
							}
							list10.Add(num119);
							num111 = resolutionU;
							int num121 = num112 + 1;
							bool flag12 = num112 < resolutionU;
							num112 = num121;
							if (!flag12)
							{
								num21 = resolutionU;
								break;
							}
						}
					}
				}
				num89++;
				num90++;
			}
			while (num89 < capSegmentsV);
		}

		[global::Cpp2ILInjected.Token(Token = "0x600049E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021C34", Offset = "0x1021C34", Length = "0x1D0")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0022;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0x940;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv46 = Il2CppMethodInfo;\n\tv47 = v46 + 0x948;\n\tv48 = \"il2cpp_codegen_initialize_runtime_metadata\"(v47, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv50 = Il2CppMethodInfo;\n\tv51 = v50 + 0xA78;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v51, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv87 = Il2CppMethodInfo;\n\tv88 = v87 + 0xA80;\n\tv89 = \"il2cpp_codegen_initialize_runtime_metadata\"(v88, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv94 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv95 = v94 + 0xFD8;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v95, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302AB03]) = v42;\nL_0022:\n\tv45 = UnityEngine.Component::get_gameObject(this);\n\tv53 = Il2CppMethodInfo;\n\tv55 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv58 = UnityEngine.GameObject::GetComponent /* +1 sharing this address */(v45, *([v53 @ X8_v4 (Il2CppMethodInfo)+A78]));\n\tv84 = this + 0x50;\n\tthis.meshFilter = v58;\n\tv93 = 0xF3F1B4(v84, v58, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv96 = *([v55 @ X22_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv97 = *([v96 @ X0_v9+E0]) == 0;\n\tif (v97) goto L_0042;\n\tv131 = UnityEngine.Object::op_Equality(this.meshFilter, 0);\n\tv133 = ~v131;\n\tv134 = ~v133;\n\tif (v134) goto L_0047;\n\tgoto L_0054;\nL_0042:\n\tv138 = UnityEngine.Object::op_Equality(this.meshFilter, 0);\n\tv142 = ~v138;\n\tif (v142) goto L_0054;\nL_0047:\n\tv72 = UnityEngine.Component::get_gameObject(this);\n\tv151 = Il2CppMethodInfo;\n\tv153 = UnityEngine.GameObject::AddComponent /* +1 sharing this address */(v72, *([v151 @ X8_v13 (Il2CppMethodInfo)+940]));\n\tthis.meshFilter = v153;\n\tv147 = 0xF3F1B4(v84, v153, v60, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\nL_0054:\n\tv73 = UnityEngine.Component::get_gameObject(this);\n\tv154 = Il2CppMethodInfo;\n\tv157 = UnityEngine.GameObject::GetComponent /* +1 sharing this address */(v73, *([v154 @ X8_v8 (Il2CppMethodInfo)+A80]));\n\tv85 = this + 0x58;\n\tthis.meshRenderer = v157;\n\tv162 = 0xF3F1B4(v85, v157, v61, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv163 = *([v55 @ X22_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv164 = *([v163 @ X0_v16+E0]) == 0;\n\tif (v164) goto L_0085;\n\tv168 = UnityEngine.Object::op_Equality(this.meshRenderer, 0);\n\tv170 = ~v168;\n\tif (v170) goto L_0090;\nL_006E:\n\tv74 = UnityEngine.Component::get_gameObject(this);\n\tv181 = Il2CppMethodInfo;\n\tv183 = UnityEngine.GameObject::AddComponent /* +1 sharing this address */(v74, *([v181 @ X8_v11 (Il2CppMethodInfo)+948]));\n\tthis.meshRenderer = v183;\n\tv113 = 0xF3F1B4(v85, v183, v62, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\treturn;\nL_0085:\n\tv174 = UnityEngine.Object::op_Equality(this.meshRenderer, 0);\n\tv180 = ~v174;\n\tv178 = ~v180;\n\tif (v178) goto L_006E;\nL_0090:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 81 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private void AssignMeshComponents()
		{
			//IL_0019: Expected I, but got O
			//IL_002f: Expected O, but got I
			//IL_0058: Expected O, but got I
			//IL_00f1: Expected O, but got I4
			//IL_00fa: Expected O, but got I4
			//IL_00ac: Expected O, but got I4
			//IL_0173: Expected O, but got I
			//IL_00c3: Expected O, but got I4
			//IL_019c: Expected O, but got I
			//IL_0260: Expected O, but got I4
			//IL_01e5: Expected O, but got I4
			global::UnityEngine.GameObject gameObject = base.gameObject;
			nint num = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @114831C (UnityEngine.GameObject::GetComponent, and 1 more at this address)");
			global::UnityEngine.MeshFilter meshFilter = default(global::UnityEngine.MeshFilter);
			this.meshFilter = meshFilter;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X22_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v96 @ X0_v9+E0]");
			object obj3;
			object obj4;
			if ((nint)0 != 0)
			{
				bool flag = this.meshFilter == null;
				bool flag2 = !flag;
				bool flag3 = !flag2;
				obj3 = 0;
				if (flag3)
				{
					goto IL_0108;
				}
				obj4 = 0;
			}
			else
			{
				bool flag4 = this.meshFilter == null;
				bool flag5 = !flag4;
				obj3 = 0;
				obj4 = 0;
				if (!flag5)
				{
					goto IL_0108;
				}
			}
			goto IL_0148;
			IL_0148:
			global::UnityEngine.GameObject gameObject2 = base.gameObject;
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @114831C (UnityEngine.GameObject::GetComponent, and 1 more at this address)");
			global::UnityEngine.MeshRenderer meshRenderer = default(global::UnityEngine.MeshRenderer);
			this.meshRenderer = meshRenderer;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v55 @ X22_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj6 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v163 @ X0_v16+E0]");
			if ((nint)0 != 0)
			{
				bool flag6 = this.meshRenderer == null;
				bool flag7 = !flag6;
				object obj7 = 0;
				if (flag7)
				{
					return;
				}
			}
			else
			{
				bool flag8 = this.meshRenderer == null;
				bool flag9 = !flag8;
				bool flag10 = !flag9;
				object obj7 = 0;
				if (!flag10)
				{
					return;
				}
			}
			global::UnityEngine.GameObject gameObject3 = base.gameObject;
			nint num4 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11481F4 (UnityEngine.GameObject::AddComponent, and 1 more at this address)");
			global::UnityEngine.MeshRenderer meshRenderer2 = default(global::UnityEngine.MeshRenderer);
			this.meshRenderer = meshRenderer2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			return;
			IL_0108:
			global::UnityEngine.GameObject gameObject4 = base.gameObject;
			nint num5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11481F4 (UnityEngine.GameObject::AddComponent, and 1 more at this address)");
			global::UnityEngine.MeshFilter meshFilter2 = default(global::UnityEngine.MeshFilter);
			this.meshFilter = meshFilter2;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			obj4 = obj3;
			goto IL_0148;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600049F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1021E04", Offset = "0x1021E04", Length = "0xBC")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302AB3E]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_002D;\n\tv23 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv25 = *([v23 @ X0_v16+E0]) == 0;\n\tif (v25) goto L_0038;\nL_0018:\n\tv55 = UnityEngine.Object::op_Inequality(v50, 0);\n\tv63 = ~v55;\n\tif (v63) goto L_0043;\nL_0027:\n\tUnityEngine.Renderer::set_sharedMaterial(this.meshRenderer, this.material);\n\treturn;\nL_002D:\n\t*([v16 @ X20_v1+B3E]) = 1;\n\tv45 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv62 = *([v45 @ X0_v9+E0]) == 0;\n\tv47 = ~v62;\n\tif (v47) goto L_0018;\nL_0038:\n\tv67 = UnityEngine.Object::op_Inequality(v59, 0);\n\tv89 = ~v67;\n\tv72 = ~v89;\n\tif (v72) goto L_0027;\nL_0043:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 45 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		private void AssignMaterials()
		{
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected I, but got O
			//IL_00e2: Expected O, but got I
			//IL_005a: Expected O, but got I
			object obj = 50503680;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AB3E]");
			global::UnityEngine.Object obj3;
			global::UnityEngine.Object obj4;
			if ((uint)((nuint)0u & (nuint)1u) != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v16+E0]");
				bool flag = (nint)0 == 0;
				obj3 = material;
				obj4 = material;
				if (!flag)
				{
					goto IL_0093;
				}
			}
			else
			{
				_ = 1;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v9+E0]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				obj3 = material;
				obj4 = material;
				if (flag3)
				{
					goto IL_0093;
				}
			}
			if (!(obj4 != null))
			{
				return;
			}
			goto IL_00ba;
			IL_00ba:
			meshRenderer.sharedMaterial = material;
			return;
			IL_0093:
			if (obj3 != null)
			{
				goto IL_00ba;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1023864", Offset = "0x1023864", Length = "0x28")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.thickness = 0.15f;\n\tthis.resolutionV = 20f;\n\tthis.capSegmentsV = 0xA;\n\tPathCreation.Examples.PathSceneTool::.ctor(this);\n\treturn;\n// 6 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public CylinderMeshCreator()
		{
			thickness = 0.15f;
			resolutionV = 20f;
			capSegmentsV = 10;
		}
	}
}
