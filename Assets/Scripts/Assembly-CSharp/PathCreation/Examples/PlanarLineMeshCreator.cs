namespace PathCreation.Examples
{
	[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.MeshFilter), typeof(global::UnityEngine.MeshRenderer))]
	[global::Cpp2ILInjected.Token(Token = "0x2000104")]
	public class PlanarLineMeshCreator : global::PathCreation.Examples.PathSceneTool
	{
		[global::UnityEngine.Tooltip("Half-width of the ribbon (world units).")]
		[global::UnityEngine.Header("Shape")]
		[global::Cpp2ILInjected.Token(Token = "0x400052D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		public float thickness;

		[global::UnityEngine.Range(1f, 20f)]
		[global::UnityEngine.Tooltip("Sub-samples per repeat segment (smoothness).")]
		[global::Cpp2ILInjected.Token(Token = "0x400052E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public int subdivisionsPerSegment;

		[global::UnityEngine.Header("Layering")]
		[global::UnityEngine.Tooltip("Local-space Z written into every vertex.")]
		[global::Cpp2ILInjected.Token(Token = "0x400052F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		public float localZ;

		[global::UnityEngine.Header("UV Options")]
		[global::Cpp2ILInjected.Token(Token = "0x4000530")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		public bool flipU;

		[global::Cpp2ILInjected.Token(Token = "0x4000531")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		public bool flipV;

		[global::Cpp2ILInjected.Token(Token = "0x4000532")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private global::UnityEngine.MeshFilter mf;

		[global::Cpp2ILInjected.Token(Token = "0x4000533")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private global::UnityEngine.MeshRenderer mr;

		[global::Cpp2ILInjected.Token(Token = "0x4000534")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private global::UnityEngine.Mesh mesh;

		[global::Cpp2ILInjected.Token(Token = "0x4000535")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		public float innerSegmentLengthRatio;

		[global::Cpp2ILInjected.Token(Token = "0x60004A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x102388C", Offset = "0x102388C", Length = "0x19C")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302AB04]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0048;\n\tv23 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv25 = *([v23 @ X0_v49+E0]) == 0;\n\tif (v25) goto L_0052;\nL_0017:\n\tv54 = UnityEngine.Object::op_Implicit(v50);\n\tv63 = ~v54;\n\tif (v63) goto L_005D;\nL_001B:\n\tv77 = this + 0x48;\n\tv79 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv81 = *([v79 @ X0_v17+E0]) == 0;\n\tif (v81) goto L_0061;\n\tv98 = UnityEngine.Object::op_Implicit(this.mf);\n\tv131 = v98 == 0;\n\tif (v131) goto L_0066;\nL_0028:\n\tv194 = this + 0x50;\n\tv142 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv144 = *([v142 @ X0_v43+E0]) == 0;\n\tif (v144) goto L_007A;\nL_0030:\n\tv169 = UnityEngine.Object::op_Implicit(v155);\n\tv180 = v169 == 0;\n\tif (v180) goto L_007F;\nL_003C:\n\tPathCreation.Examples.PlanarLineMeshCreator::BuildMesh(this);\n\treturn;\nL_0048:\n\t*([v16 @ X20_v1+B04]) = 1;\n\tv45 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv95 = *([v45 @ X0_v15+E0]) == 0;\n\tv47 = ~v95;\n\tif (v47) goto L_0017;\nL_0052:\n\tv66 = UnityEngine.Object::op_Implicit(v58);\n\tv93 = ~v66;\n\tv73 = ~v93;\n\tif (v73) goto L_001B;\nL_005D:\n\treturn;\nL_0061:\n\tv134 = UnityEngine.Object::op_Implicit(this.mf);\n\tv154 = v134 == 0;\n\tv138 = ~v154;\n\tif (v138) goto L_0028;\nL_0066:\n\tv148 = Il2CppMethodInfo;\n\tv152 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v148 @ X8_v12 (Il2CppMethodInfo)+6A0]));\n\tthis.mf = v152;\n\tv178 = 0xF3F1B4(v77, v152, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tv194 = this + 0x50;\n\tv160 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv185 = *([v160 @ X0_v33+E0]) == 0;\n\tv162 = ~v185;\n\tif (v162) goto L_0030;\nL_007A:\n\tv183 = UnityEngine.Object::op_Implicit(v170);\n\tv200 = v183 == 0;\n\tv188 = ~v200;\n\tif (v188) goto L_003C;\nL_007F:\n\tv195 = Il2CppMethodInfo;\n\tv198 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v195 @ X8_v9 (Il2CppMethodInfo)+6A8]));\n\tthis.mr = v198;\n\tv202 = 0xF3F1B4(v194, v198, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43);\n\tPathCreation.Examples.PlanarLineMeshCreator::BuildMesh(this);\n\treturn;\n// 86 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		protected override void PathUpdated()
		{
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected I, but got O
			//IL_01cb: Expected O, but got I
			//IL_005a: Expected O, but got I
			//IL_00c5: Expected O, but got I
			//IL_00d5: Expected O, but got I
			//IL_0132: Expected O, but got I
			//IL_0142: Expected O, but got I
			//IL_02b7: Expected O, but got I
			//IL_02c7: Expected O, but got I
			object obj = 50503680;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AB04]");
			global::UnityEngine.Object obj3;
			global::UnityEngine.Object obj4;
			if ((uint)((nuint)0u & (nuint)1u) != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj2 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v49+E0]");
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
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj5 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v45 @ X0_v15+E0]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				obj3 = pathCreator;
				obj4 = pathCreator;
				if (flag3)
				{
					goto IL_0093;
				}
			}
			if (!obj4)
			{
				return;
			}
			goto IL_00b9;
			IL_0313:
			global::UnityEngine.Object obj6;
			bool flag4 = obj6;
			bool flag5 = !flag4;
			bool flag6 = !flag5;
			object obj8;
			object obj7 = obj8;
			if (flag6)
			{
				goto IL_01ae;
			}
			goto IL_0356;
			IL_0126:
			obj7 = (nint)this + 80;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj9 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v142 @ X0_v43+E0]");
			bool flag7 = (nint)0 == 0;
			global::UnityEngine.Object obj10 = mr;
			obj6 = mr;
			obj8 = obj7;
			if (!flag7)
			{
				goto IL_0183;
			}
			goto IL_0313;
			IL_0183:
			if ((bool)obj10)
			{
				goto IL_01ae;
			}
			goto IL_0356;
			IL_0093:
			if ((bool)obj3)
			{
				goto IL_00b9;
			}
			return;
			IL_00b9:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj12 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v79 @ X0_v17+E0]");
			if ((nint)0 != 0)
			{
				if ((bool)mf)
				{
					goto IL_0126;
				}
			}
			else if ((bool)mf)
			{
				goto IL_0126;
			}
			nint num2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
			global::UnityEngine.MeshFilter meshFilter = default(global::UnityEngine.MeshFilter);
			mf = meshFilter;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			obj7 = (nint)this + 80;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj13 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v160 @ X0_v33+E0]");
			bool flag8 = (nint)0 == 0;
			bool flag9 = !flag8;
			obj10 = mr;
			obj6 = mr;
			obj8 = obj7;
			if (flag9)
			{
				goto IL_0183;
			}
			goto IL_0313;
			IL_01ae:
			BuildMesh();
			return;
			IL_0356:
			nint num3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
			global::UnityEngine.MeshRenderer meshRenderer = default(global::UnityEngine.MeshRenderer);
			mr = meshRenderer;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			BuildMesh();
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004A2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1023A28", Offset = "0x1023A28", Length = "0x14C4")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv44 = 0x302A000;\n\tv46 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv48 = *([302AB05]) & 1;\n\tv49 = v48 == 0;\n\tif (v49) goto L_006F;\n\tv967 = this + 0x58;\n\tv53 = *([v46 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv55 = *([v53 @ X0_v233+E0]) == 0;\n\tif (v55) goto L_007C;\nL_0028:\n\tv87 = UnityEngine.Object::op_Equality(v82, 0);\n\tv98 = ~v87;\n\tif (v98) goto L_0085;\nL_002C:\n\tv116 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv119 = new *([v116 @ X8_v259 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+9E8])();\n\tUnityEngine.Mesh::.ctor(v119);\n\t*([v967 @ X21_v2]) = v119;\n\tv1095 = 0xF3F1B4(v967, v119, v864, v61, v62, v63, v64, v65, v66, v67, v68, v69, v70, v71, v72, v73);\n\tgoto L_008A;\nL_006F:\n\t*([v44 @ X19_v1+B05]) = 1;\n\tv967 = this + 0x58;\n\tv75 = *([v46 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv1477 = *([v75 @ X0_v224+E0]) == 0;\n\tv79 = ~v1477;\n\tif (v79) goto L_0028;\nL_007C:\n\tv102 = UnityEngine.Object::op_Equality(v92, 0);\n\tv130 = ~v102;\n\tv111 = ~v130;\n\tif (v111) goto L_002C;\nL_0085:\n\tUnityEngine.Mesh::Clear(*([v123 @ X21_v23]));\nL_008A:\n\tv928 = PathCreation.PathCreator::get_path(v1028.pathCreator);\n\tv1201 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv1203 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv1205 = v1028.thickness + v1028.thickness;\n\tv1206 = v928.length - v1205;\n\tv1217 = v1206 >= 0;\n\tif (v1217) goto L_FFFFFFFF;\n\tgoto L_00B5;\nL_00B5:\n\tv1237 = v498 <= 0;\n\tif (v1237) goto L_FFFFFFFF;\n\tv1242 = v1028.thickness * v1028.innerSegmentLengthRatio;\n\tv1245 = *([2DD4417]) == 0;\n\tif (v1245) goto L_00E9;\n\tv1250 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv1252 = *([v1250 @ X8_v251 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv1288 = v498 / v1242;\n\tv1255 = *([v1252 @ X0_v163+E0]) == 0;\n\tif (v1255) goto L_00F6;\nL_00C7:\n\tv1300 = 0x274AA58(&v1298 @ stack_-B0_v8 (System.Double), 0, v864, v61, v62, v63, v64, v65, v1288, v67, v68, v69, v70, v71, v72, v73);\n\tv1323 = v1288 >= 0;\n\tif (v1323) goto L_010D;\nL_00DD:\n\tv1369 = v1355 != -0.5d;\n\tif (v1369) goto L_011F;\n\tgoto L_0112;\n\tgoto L_014C;\nL_00E9:\n\t*([2DD4417]) = 1;\n\tv1307 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv1291 = *([v1307 @ X8_v245 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv1288 = v498 / v1242;\n\tv1309 = *([v1291 @ X0_v158+E0]) == 0;\n\tv1293 = ~v1309;\n\tif (v1293) goto L_00C7;\nL_00F6:\n\tv1328 = 0x274AA58(&v1298 @ stack_-B0_v8 (System.Double), 0, v864, v61, v62, v63, v64, v65, v1301, v67, v68, v69, v70, v71, v72, v73);\n\tv1335 = v1301 < 0;\n\tif (v1335) goto L_00DD;\nL_010D:\n\tv1396 = v1382 != 0.5d;\n\tif (v1396) goto L_0122;\nL_0112:\n\tv1434 = v1452 + v1417;\n\tv1435 = v1433 & 1;\n\tv1437 = v1435 == 0;\n\tv1440 = ~v1437;\n\tif (v1440) goto L_FFFFFFFF;\n\tgoto L_011E;\nL_011E:\n\tgoto L_0127;\nL_011F:\n\tv1406 = v1338 + -0.5d;\n\tv1452 = System.Math::Ceiling(v1406);\n\tgoto L_0127;\nL_0122:\n\tv1411 = v1373 + 0.5d;\n\tv1452 = System.Math::Floor(v1411);\nL_0127:\n\tv1458 = v1452 - 1;\n\tv1459 = v1458 < 0;\n\tv1460 = v1458 == 0;\n\tv1461 = v1452 ^ 1;\n\tv1462 = v1452 ^ v1458;\n\tv1463 = v1461 & v1462;\n\tv1464 = v1463 < 0;\n\tv1465 = v1459 == v1464;\n\tv1260 = ~v1460;\n\tv1466 = v1465 & v1260;\n\tv1467 = ~v1466;\n\tif (v1467) goto L_FFFFFFFF;\n\tgoto L_013B;\nL_013B:\n\tv1275 = v1452 - 0x7FF0000000000000;\n\tv1273 = v1275 == 0;\n\tv1263 = ~v1273;\n\tv1267 = ~v1263;\n\tif (v1267) goto L_FFFFFFFF;\n\tgoto L_014A;\nL_014A:\n\tv517 = v498 / v1261;\nL_014C:\n\tv1284 = new *([v1201 @ X22_v2 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+390])();\n\tSystem.Collections.Generic.List`1<System.Single>::.ctor(v1284);\n\tv1330 = new *([v1201 @ X22_v2 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+390])();\n\tSystem.Collections.Generic.List`1<System.Single>::.ctor(v1330);\n\tv929 = new *([v1203 @ X24_v2 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+110])();\n\tSystem.Collections.Generic.List`1<System.Int32>::.ctor(v929);\n\tv1481 = v1284._version + 1;\n\tv1284._version = v1481;\n\tv381 = v1284._items;\n\tv349 = v1284._size;\n\tv1484 = v1284._size < v381.Length;\n\tv765 = ~v1484;\n\tif (v765) goto L_0177;\n\tv1485 = v1284._size + 1;\n\tv1284._size = v1485;\n\tv381[v349 @ X10_v2 (System.Int32)] = 0;\n\tgoto L_017F;\nL_0177:\n\t;\n\tSystem.Collections.Generic.List`1<System.Single>::AddWithResize(v1284, 0f);\nL_017F:\n\t;\n\tv1494 = v1330._version + 1;\n\tv1330._version = v1494;\n\tv382 = v1330._items;\n\tv350 = v1330._size;\n\tv1495 = v1330._size < v382.Length;\n\tv766 = ~v1495;\n\tif (v766) goto L_0198;\n\tv1496 = v1330._size + 1;\n\tv1330._size = v1496;\n\tv382[v350 @ X10_v3 (System.Int32)] = v1028.thickness;\n\tgoto L_01A1;\nL_0198:\n\t;\n\tSystem.Collections.Generic.List`1<System.Single>::AddWithResize(v1330, v1028.thickness);\nL_01A1:\n\t;\n\tv1507 = v929._version + 1;\n\tv929._version = v1507;\n\tv383 = v929._items;\n\tv1508 = v929._size;\n\tv1510 = v929._size < v383.Length;\n\tv1511 = ~v1510;\n\tif (v1511) goto L_01C0;\n\tv1519 = v929._size + 1;\n\tv929._size = v1519;\n\tv383[v1508 @ X10_v4 (System.Int32)] = 0;\n\tv1522 = v436 == 0;\n\tv1523 = ~v1522;\n\tif (v1523) goto L_FFFFFFFF;\n\tgoto L_023E;\nL_01C0:\n\t;\n\tSystem.Collections.Generic.List`1<System.Int32>::AddWithResize(v929, 0);\n\tv1532 = v436 == 0;\n\tif (v1532) goto L_023E;\n\tgoto L_01D8;\nL_01C9:\n\t;\n\tSystem.Collections.Generic.List`1<System.Int32>::AddWithResize(v929, v968);\n\tv1549 = v436 == v968;\n\tif (v1549) goto L_023E;\nL_01D8:\n\t;\n\tv1569 = v1284._version + 1;\n\tv1284._version = v1569;\n\tv384 = v1284._items;\n\tv1573 = v517 * v968;\n\tv489 = v1028.thickness + v1573;\n\tv373 = v1284._size;\n\tv1575 = v1284._size < v384.Length;\n\tv790 = ~v1575;\n\tif (v790) goto L_01F4;\n\tv1583 = v1284._size + 1;\n\tv1284._size = v1583;\n\tv384[v373 @ X10_v70 (System.Int32)] = v489;\n\tgoto L_01FC;\nL_01F4:\n\t;\n\tSystem.Collections.Generic.List`1<System.Single>::AddWithResize(v1284, v489);\nL_01FC:\n\tv1598 = v1330._version + 1;\n\tv1330._version = v1598;\n\tv409 = v1330._items;\n\tv801 = v517 + v489;\n\tv352 = v1330._size;\n\tv1600 = v1330._size < v409.Length;\n\tv768 = ~v1600;\n\tif (v768) goto L_0214;\n\tv1609 = v1330._size + 1;\n\tv1330._size = v1609;\n\tv409[v352 @ X10_v71 (System.Int32)] = v801;\n\tgoto L_021A;\nL_0214:\n\t;\n\tSystem.Collections.Generic.List`1<System.Single>::AddWithResize(v1330, v801);\nL_021A:\n\t;\n\tv1623 = v929._version + 1;\n\tv929._version = v1623;\n\tv385 = v929._items;\n\tv968 = v968 + 1;\n\tv1537 = v929._size;\n\tv1633 = v929._size < v385.Length;\n\tv1634 = ~v1633;\n\tif (v1634) goto L_01C9;\n\tv1649 = v929._size + 1;\n\tv929._size = v1649;\n\tv385[v1537 @ X10_v72 (System.Int32)] = v968;\n\tv1539 = v436 != v968;\n\tif (v1539) goto L_01D8;\nL_023E:\n\t;\n\tv1564 = v1284._version + 1;\n\tv1284._version = v1564;\n\tv386 = v1284._items;\n\tv819 = v928.length - v1028.thickness;\n\tv374 = v1284._size;\n\tv1571 = v1284._size < v386.Length;\n\tv791 = ~v1571;\n\tif (v791) goto L_0258;\n\tv1576 = v1284._size + 1;\n\tv1284._size = v1576;\n\tv386[v374 @ X10_v6 (System.Int32)] = v819;\n\tgoto L_025F;\nL_0258:\n\t;\n\tSystem.Collections.Generic.List`1<System.Single>::AddWithResize(v1284, v819);\nL_025F:\n\tv1594 = v1330._version + 1;\n\tv1330._version = v1594;\n\tv410 = v1330._items;\n\tv354 = v1330._size;\n\tv1599 = v1330._size < v410.Length;\n\tv770 = ~v1599;\n\tif (v770) goto L_0276;\n\tv1601 = v1330._size + 1;\n\tv1330._size = v1601;\n\tv410[v354 @ X10_v7 (System.Int32)] = v928.length;\n\tgoto L_027D;\nL_0276:\n\t;\n\tSystem.Collections.Generic.List`1<System.Single>::AddWithResize(v1330, v928.length);\nL_027D:\n\t;\n\tv1619 = v929._version + 1;\n\tv929._version = v1619;\n\tv387 = v929._items;\n\tv970 = v436 + 1;\n\tv358 = v929._size;\n\tv1624 = v929._size < v387.Length;\n\tv1625 = ~v1624;\n\tif (v1625) goto L_0297;\n\tv1642 = v929._size + 1;\n\tv929._size = v1642;\n\tv387[v358 @ X10_v8 (System.Int32)] = v970;\n\tgoto L_029E;\nL_0297:\n\t;\n\tSystem.Collections.Generic.List`1<System.Int32>::AddWithResize(v929, v970);\nL_029E:\n\tv1655 = new *([v1201 @ X22_v2 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+390])();\n\tSystem.Collections.Generic.List`1<System.Single>::.ctor(v1655);\n\tv1658 = System.Collections.Generic.List`1<Uni\n// ... truncated")]
		private void BuildMesh()
		{
			//IL_0009: Expected O, but got I4
			//IL_0017: Expected I, but got O
			//IL_0138: Expected O, but got I
			//IL_0148: Expected O, but got I
			//IL_00c9: Expected O, but got I4
			//IL_00d7: Expected O, but got I4
			//IL_0056: Expected O, but got I
			//IL_0066: Expected O, but got I
			//IL_0100: Expected I, but got O
			//IL_01c6: Expected O, but got I4
			//IL_01dc: Expected O, but got I4
			//IL_023a: Expected I, but got O
			//IL_0249: Expected I, but got O
			//IL_040b: Expected I, but got O
			//IL_041b: Expected O, but got I
			//IL_0300: Expected I, but got O
			//IL_0310: Expected O, but got I
			//IL_059d: Unknown result type (might be due to invalid IL or missing references)
			//IL_05a2: Expected O, but got Unknown
			//IL_05af: Expected O, but got F8
			//IL_2bb9: Unknown result type (might be due to invalid IL or missing references)
			//IL_2bbe: Expected I4, but got Unknown
			//IL_2c67: Expected I4, but got F8
			//IL_0d90: Expected I, but got O
			//IL_136d: Expected I, but got O
			//IL_137c: Expected I, but got O
			//IL_13d8: Expected I, but got O
			//IL_140a: Expected I4, but got I8
			//IL_142e: Expected I, but got O
			//IL_143e: Expected O, but got I
			//IL_144e: Expected O, but got I
			//IL_1463: Expected F4, but got I
			//IL_1478: Expected F4, but got I
			//IL_148d: Expected F4, but got I
			//IL_2a30: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a35: Expected I4, but got Unknown
			//IL_2a3d: Unknown result type (might be due to invalid IL or missing references)
			//IL_2a42: Expected I4, but got Unknown
			//IL_2d4e: Expected I, but got O
			//IL_2d5e: Expected O, but got I
			//IL_2d6e: Expected O, but got I
			//IL_2d76: Expected F4, but got O
			//IL_2d86: Expected F4, but got I
			//IL_2daa: Expected F4, but got I
			//IL_1147: Unknown result type (might be due to invalid IL or missing references)
			//IL_114c: Expected I4, but got Unknown
			//IL_1154: Unknown result type (might be due to invalid IL or missing references)
			//IL_1159: Expected I4, but got Unknown
			//IL_2df6: Expected I, but got O
			//IL_2e06: Expected O, but got I
			//IL_2e16: Expected O, but got I
			//IL_2e1e: Expected F4, but got O
			//IL_2e2e: Expected F4, but got I
			//IL_2e3e: Expected F4, but got I
			//IL_1748: Expected O, but got F4
			//IL_1956: Expected O, but got I
			//IL_1ab4: Expected O, but got I
			//IL_1bd5: Expected O, but got I
			//IL_1d1a: Expected O, but got I
			//IL_2002: Expected O, but got F4
			//IL_200f: Expected O, but got F4
			//IL_1ea9: Expected O, but got F4
			//IL_1eb6: Expected O, but got F4
			//IL_2ee2: Expected O, but got F4
			//IL_2eef: Expected O, but got F4
			//IL_218b: Expected O, but got I
			//IL_22a4: Expected O, but got I
			object obj = 50503680;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AB05]");
			global::UnityEngine.Object obj4;
			object obj5;
			global::UnityEngine.Object obj6;
			object obj2;
			if ((uint)((nuint)0u & (nuint)1u) != 0)
			{
				obj2 = (nint)this + 88;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v53 @ X0_v233+E0]");
				bool flag = (nint)0 == 0;
				obj4 = this.mesh;
				obj5 = obj2;
				obj6 = this.mesh;
				if (!flag)
				{
					goto IL_00a7;
				}
			}
			else
			{
				_ = 1;
				obj2 = (nint)this + 88;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v46 @ X20_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
				object obj7 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v224+E0]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				obj4 = this.mesh;
				obj5 = obj2;
				obj6 = this.mesh;
				if (flag3)
				{
					goto IL_00a7;
				}
			}
			bool flag4 = obj6 == null;
			bool flag5 = !flag4;
			bool flag6 = !flag5;
			object obj8 = 0;
			obj2 = obj5;
			global::PathCreation.Examples.PlanarLineMeshCreator planarLineMeshCreator = this;
			object obj9 = 0;
			global::PathCreation.Examples.PlanarLineMeshCreator planarLineMeshCreator2 = this;
			if (flag6)
			{
				goto IL_00f2;
			}
			goto IL_01ef;
			IL_2976:
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> list;
			((global::UnityEngine.Mesh)obj2).SetVertices(list);
			global::System.Collections.Generic.List<global::UnityEngine.Vector2> uvs;
			((global::UnityEngine.Mesh)obj2).SetUVs(0, uvs);
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> normals;
			((global::UnityEngine.Mesh)obj2).SetNormals(normals);
			global::System.Collections.Generic.List<int> list2;
			((global::UnityEngine.Mesh)obj2).SetTriangles(list2, 0);
			((global::UnityEngine.Mesh)obj2).RecalculateBounds();
			mf.sharedMesh = (global::UnityEngine.Mesh)obj2;
			return;
			IL_15eb:
			int num2 = 0;
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> list3;
			list = list3;
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> list5;
			global::System.Collections.Generic.List<global::UnityEngine.Vector3> list4 = list5;
			int num3 = 0;
			global::PathCreation.Examples.PlanarLineMeshCreator planarLineMeshCreator3 = this;
			global::System.Collections.Generic.List<float> list6;
			global::PathCreation.VertexPath vertexPath;
			global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector3 position2 = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector3 item = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector3 item2 = default(global::UnityEngine.Vector3);
			float y3;
			float z3;
			global::UnityEngine.Vector3 item3 = default(global::UnityEngine.Vector3);
			float x3;
			global::UnityEngine.Vector3 item4 = default(global::UnityEngine.Vector3);
			global::System.Collections.Generic.List<int> list7;
			global::System.Collections.Generic.List<int> list8;
			global::System.Collections.Generic.List<float> list9;
			float num37;
			int num45 = 0;
			global::System.Collections.Generic.List<global::UnityEngine.Vector2> list10;
			int num56 = default(int);
			global::UnityEngine.Vector2 item5 = default(global::UnityEngine.Vector2);
			global::UnityEngine.Vector2 item6 = default(global::UnityEngine.Vector2);
			while (true)
			{
				float num4 = list6[num3];
				global::UnityEngine.Vector3 pointAtDistance = vertexPath.GetPointAtDistance(num4, global::PathCreation.EndOfPathInstruction.Stop);
				global::UnityEngine.Vector3 directionAtDistance = vertexPath.GetDirectionAtDistance(num4, global::PathCreation.EndOfPathInstruction.Stop);
				float num5 = directionAtDistance.y * directionAtDistance.y;
				float num6 = directionAtDistance.x * directionAtDistance.x;
				float f = num5 + num6;
				float num7 = global::UnityEngine.Mathf.Sqrt(f);
				float num8;
				float num9;
				float num10;
				if (num7 > 1E-05f)
				{
					object obj10 = 0f - directionAtDistance.y;
					num8 = (float)obj10 / num7;
					num9 = directionAtDistance.x / num7;
					num10 = (float)num2 / num7;
				}
				else
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2250 @ X8_v140 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
					object obj11 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2252 @ X8_v142+B8]");
					object obj12 = 0;
					num8 = (float)obj12;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2242 @ X8_v143+4]");
					num9 = 0f;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2242 @ X8_v143+8]");
					num10 = 0f;
				}
				global::UnityEngine.Transform transform = planarLineMeshCreator3.transform;
				float num12 = num8 * planarLineMeshCreator3.thickness;
				float num13 = num9 * planarLineMeshCreator3.thickness;
				float num14 = num10 * planarLineMeshCreator3.thickness;
				float z = pointAtDistance.z - num14;
				float y = pointAtDistance.y - num13;
				float x = pointAtDistance.x - num12;
				position.x = x;
				position.y = y;
				position.z = z;
				global::UnityEngine.Vector3 vector = transform.InverseTransformPoint(position);
				global::UnityEngine.Transform transform2 = planarLineMeshCreator3.transform;
				float x2 = pointAtDistance.x + num12;
				float y2 = pointAtDistance.y + num13;
				float z2 = pointAtDistance.z + num14;
				position2.x = x2;
				position2.y = y2;
				position2.z = z2;
				global::UnityEngine.Vector3 vector2 = transform2.InverseTransformPoint(position2);
					item.x = vector.x;
					item.y = vector.y;
					item.z = planarLineMeshCreator3.localZ;
					list.Add(item);
					item2.x = vector2.x;
					item2.y = vector2.y;
					item2.z = planarLineMeshCreator3.localZ;
					list.Add(item2);
					item3.x = x3;
					item3.y = y3;
					item3.z = z3;
					list4.Add(item3);
					item4.x = x3;
					item4.y = y3;
					item4.z = z3;
					list4.Add(item4);
				float num21 = planarLineMeshCreator3.innerSegmentLengthRatio + planarLineMeshCreator3.innerSegmentLengthRatio;
				float num22 = num21 + 1f;
				float num23 = 1f / num22;
				int index = list7[num3];
				float num44;
				if (list8[index] != 0)
				{
					float num24 = 1f - num23;
					int num25 = list8[index];
					float num26 = list9[index];
					float num27 = num4 - num26;
					float num28 = num27 / planarLineMeshCreator.thickness;
					float num29 = num28 - 1f;
					bool flag7 = num29 < 0f;
					bool flag8 = num29 == 0f;
					object obj17 = num28 ^ 1f;
					object obj18 = num28 ^ num29;
					int num30 = (int)((nint)obj17 & (nint)obj18);
					bool flag9 = num30 < 0;
					bool flag10 = flag7 == flag9;
					bool flag11 = !flag8;
					float num31 = ((!(flag10 && flag11)) ? num28 : 1f);
					float num32 = ((!(num28 < 0f)) ? num31 : 0f);
					float num33 = 1f - num24;
					float num34 = num33 * num32;
					float num35 = num24 + num34;
					float num36 = num27 / num37;
					float num38 = num36 - 1f;
					bool flag12 = num38 < 0f;
					bool flag13 = num38 == 0f;
					object obj19 = num36 ^ 1f;
					object obj20 = num36 ^ num38;
					int num39 = (int)((nint)obj19 & (nint)obj20);
					bool flag14 = num39 < 0;
					bool flag15 = flag12 == flag14;
					bool flag16 = !flag13;
					float num40 = ((!(flag15 && flag16)) ? num36 : 1f);
					float num41 = ((!(num36 < 0f)) ? num40 : 0f);
					float num42 = num24 - num23;
					float num43 = num42 * num41;
					num44 = num23 + num43;
					if (num25 == num45)
					{
						num44 = num35;
					}
					planarLineMeshCreator3 = this;
				}
				else
				{
					float num46 = list9[index];
					float num47 = num4 - num46;
					float num48 = num47 / planarLineMeshCreator.thickness;
					float num49 = num48 - 1f;
					bool flag17 = num49 < 0f;
					bool flag18 = num49 == 0f;
					object obj21 = num48 ^ 1f;
					object obj22 = num48 ^ num49;
					int num50 = (int)((nint)obj21 & (nint)obj22);
					bool flag19 = num50 < 0;
					bool flag20 = flag17 == flag19;
					bool flag21 = !flag18;
					float num51 = ((!(flag20 && flag21)) ? num48 : 1f);
					float num52 = ((!(num48 < 0f)) ? num51 : 0f);
					num44 = num23 * num52;
				}
				float num53 = 1f - num44;
				float x4 = (planarLineMeshCreator3.flipU ? num53 : num44);
				float y4 = (planarLineMeshCreator3.flipV ? 1f : 0f);
				float y5 = (planarLineMeshCreator3.flipV ? 0f : 1f);
					item5.x = x4;
					item5.y = y4;
					list10.Add(item5);
					item6.x = x4;
					item6.y = y5;
					list10.Add(item6);
					num3++;
					bool flag22 = list6.Count == num3;
					num2 = 0;
					list4 = list5;
					if (flag22)
					{
						break;
					}
					continue;
			}
			bool flag24 = list6.Count < 2;
			uvs = list10;
			normals = list5;
			if (!flag24)
			{
				if (list2 == null)
				{
					int num58 = 1;
					while (true)
					{
						int num59 = list7[num58];
						int num60 = num58 - 1;
						int num61 = list7[num60];
						if (num59 == num61)
						{
							break;
						}
						num58 = num60 + 2;
						bool flag25 = num58 != list6.Count;
						uvs = list10;
						normals = list5;
						if (flag25)
						{
							continue;
						}
						goto IL_2976;
					}
					goto IL_2b79;
				}
				int num62 = 0;
				int num63 = 1;
				bool flag26;
				do
				{
					int num64 = list7[num63];
					int num65 = num63 - 1;
					int num66 = list7[num65];
					if (num64 == num66)
					{
							list2.Add(num62);
						int num67 = num62 + 1;
						list2.Add(num67);
						int num68 = num62 + 2;
						list2.Add(num68);
						list2.Add(num68);
						list2.Add(num67);
						int num69 = num62 + 3;
						list2.Add(num69);
					}
					num62 += 2;
					num63 = num65 + 2;
					flag26 = num63 == list6.Count;
					uvs = list10;
					normals = list5;
				}
				while (!flag26);
			}
			goto IL_2976;
			IL_04b0:
			float num70;
			double num71;
			double num72;
			double num73 = default(double);
			double num74;
			if ((double)num70 == 0.5)
			{
				num71 = 1.0;
				num72 = num73;
				num74 = num73;
				goto IL_2ba1;
			}
			float num75;
			double d = (double)num75 + 0.5;
			num72 = global::System.Math.Floor(d);
			goto IL_0556;
			IL_00a7:
			bool flag27 = obj4 == null;
			bool flag28 = !flag27;
			obj8 = 0;
			planarLineMeshCreator = this;
			obj9 = 0;
			obj5 = obj2;
			planarLineMeshCreator2 = this;
			if (!flag28)
			{
				goto IL_00f2;
			}
			goto IL_01ef;
			IL_01ef:
			((global::UnityEngine.Mesh)obj5).Clear();
			obj8 = obj9;
			obj2 = obj5;
			planarLineMeshCreator = planarLineMeshCreator2;
			goto IL_0215;
			IL_00f2:
			global::UnityEngine.Mesh mesh = new global::UnityEngine.Mesh();
			obj2 = mesh;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
			goto IL_0215;
			IL_0215:
			vertexPath = planarLineMeshCreator.pathCreator.path;
			float num79 = planarLineMeshCreator.thickness + planarLineMeshCreator.thickness;
			float num80 = vertexPath.length - num79;
			float num81 = ((!(num80 < 0f)) ? num80 : 0f);
			float num84;
			float num87;
			float num88;
			if (num81 > 0f)
			{
				float num82 = planarLineMeshCreator.thickness * planarLineMeshCreator.innerSegmentLengthRatio;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4417]");
				float num85;
				if ((nint)0 != 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1250 @ X8_v251 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
					object obj25 = 0;
					num84 = num81 / num82;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1252 @ X0_v163+E0]");
					bool flag29 = (nint)0 == 0;
					num85 = num84;
					if (!flag29)
					{
						goto IL_034c;
					}
				}
				else
				{
					_ = 1;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1307 @ X8_v245 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
					object obj26 = 0;
					num84 = num81 / num82;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1291 @ X0_v158+E0]");
					bool flag30 = (nint)0 == 0;
					bool flag31 = !flag30;
					num85 = num84;
					if (flag31)
					{
						goto IL_034c;
					}
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
				bool flag32 = num85 < 0f;
				num87 = num85;
				num88 = num85;
				num75 = num85;
				num70 = num85;
				if (flag32)
				{
					goto IL_0398;
				}
				goto IL_04b0;
			}
			int num89 = 0;
			num37 = 0f;
			goto IL_2be6;
			IL_08d6:
			int num90 = 0;
			global::System.Collections.Generic.List<float> list11;
			while (true)
			{
				float num92 = 0f;
				list9.Add(num92);
				float num93 = 0f;
				list11.Add(num93);
				num90++;
				list8.Add(num90);
				if (num89 == num90)
				{
					break;
				}
			}
			goto IL_0b4c;
			IL_135f:
			int capacity = default(int);
			list3 = new global::System.Collections.Generic.List<global::UnityEngine.Vector3>(capacity);
			capacity = list6.Count << 1;
			list10 = new global::System.Collections.Generic.List<global::UnityEngine.Vector2>(capacity);
			list5 = new global::System.Collections.Generic.List<global::UnityEngine.Vector3>(capacity);
			int capacity2 = default(int);
			list2 = new global::System.Collections.Generic.List<int>(capacity2);
			int num97 = list6.Count * 6;
			capacity2 = (int)(4294967290L + num97);
			global::UnityEngine.Transform transform3 = base.transform;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1880 @ X8_v31 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
			object obj27 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1882 @ X8_v33+B8]");
			object obj28 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1883 @ X8_v34+48]");
			global::UnityEngine.Vector3 direction = default(global::UnityEngine.Vector3);
			direction.x = 0f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1883 @ X8_v34+4C]");
			direction.y = 0f;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1883 @ X8_v34+50]");
			direction.z = 0f;
			global::UnityEngine.Vector3 vector3 = transform3.InverseTransformDirection(direction);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4410]");
			if ((nint)0 == 0)
			{
				_ = 1;
			}
			float num99 = vector3.x * vector3.x;
			float num100 = vector3.y * vector3.y;
			float num101 = num99 + num100;
			float num102 = vector3.z * vector3.z;
			float f2 = num102 + num101;
			float num103 = global::UnityEngine.Mathf.Sqrt(f2);
			if (num103 > 1E-05f)
			{
				x3 = vector3.x / num103;
				float num104 = vector3.y / num103;
				z3 = vector3.z / num103;
				bool flag33 = list6.Count >= 1;
				y3 = num104;
				if (flag33)
				{
					goto IL_15eb;
				}
				uvs = list10;
				list = list3;
				normals = list5;
			}
			else
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2047 @ X8_v148 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
				object obj29 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2049 @ X8_v150+B8]");
				object obj30 = 0;
				x3 = (float)obj30;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2050 @ X8_v151+8]");
				z3 = 0f;
				bool flag34 = list6.Count < 1;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v2050 @ X8_v151+4]");
				y3 = 0f;
				uvs = list10;
				list = list3;
				normals = list5;
				if (!flag34)
				{
					goto IL_15eb;
				}
			}
			goto IL_2976;
			IL_0398:
			if ((double)num88 == -0.5)
			{
				num71 = -1.0;
				num72 = 0.0;
				num74 = 0.0;
				goto IL_2ba1;
			}
			double a = (double)num87 + -0.5;
			num72 = global::System.Math.Ceiling(a);
			goto IL_0556;
			IL_2be6:
			list9 = new global::System.Collections.Generic.List<float>();
			list11 = new global::System.Collections.Generic.List<float>();
			list8 = new global::System.Collections.Generic.List<int>();
			list9.Add(0f);
			list11.Add(planarLineMeshCreator.thickness);
			list8.Add(0);
				if (num89 != 0)
				{
					goto IL_08d6;
				}
			goto IL_0b4c;
			IL_2ba1:
			double num106 = num72 + num71;
			if ((num74 & 1) != 0)
			{
				num72 = num106;
			}
			goto IL_0556;
			IL_0b4c:
			float num107 = 0f;
			list9.Add(num107);
			list11.Add(vertexPath.length);
			list8.Add(0);
			list6 = new global::System.Collections.Generic.List<float>();
			list7 = new global::System.Collections.Generic.List<int>();
			if (list9.Count < 1)
			{
				goto IL_135f;
			}
			int num109 = 0;
			float num110;
			int num116;
			float num117;
			while (true)
			{
				num110 = list9[num109];
				float num111 = list11[num109];
				int num112 = subdivisionsPerSegment - 1;
				bool flag35 = num112 < 0;
				bool flag36 = num112 == 0;
				int num113 = subdivisionsPerSegment ^ 1;
				int num114 = subdivisionsPerSegment ^ num112;
				int num115 = num113 & num114;
				bool flag37 = num115 < 0;
				bool flag38 = flag35 == flag37;
				bool flag39 = !flag36;
				num116 = ((!(flag38 && flag39)) ? 1 : subdivisionsPerSegment);
				int num118;
				int num119;
				if (num109 != 0)
				{
					list6.Add(num110);
					list7.Add(num109);
					num117 = num111 - num110;
					num118 = num116;
					num119 = 1;
				}
				else
				{
					num117 = num111 - num110;
					if (list7 == null)
					{
						break;
					}
					num118 = num116;
					num119 = 0;
				}
				while (true)
				{
					int num120 = num119 / num118;
					float num121 = (float)num120 - 1f;
					bool flag40 = num121 < 0f;
					bool flag41 = num121 == 0f;
					int num122 = num120 ^ 1f;
					int num123 = num120 ^ num121;
					int num124 = num122 & num123;
					bool flag42 = num124 < 0;
					bool flag43 = flag40 == flag42;
					bool flag44 = !flag41;
					float num125 = ((!(flag43 && flag44)) ? ((float)num120) : 1f);
					float num126 = ((num120 >= 0) ? num125 : 0f);
					list6.Add(num126);
					list7.Add(num109);
					num119++;
					if (num119 > num116)
					{
						break;
					}
				}
				num109++;
				if (num109 < list9.Count)
				{
					continue;
				}
				goto IL_135f;
			}
			int num129 = 0 / num116;
			float num130 = (float)num129 - 1f;
			bool flag45 = num130 < 0f;
			bool flag46 = num130 == 0f;
			int num131 = num129 ^ 1f;
			int num132 = num129 ^ num130;
			int num133 = num131 & num132;
			bool flag47 = num133 < 0;
			bool flag48 = flag45 == flag47;
			bool flag49 = !flag46;
			float num134 = ((!(flag48 && flag49)) ? ((float)num129) : 1f);
			float num135 = ((num129 >= 0) ? num134 : 0f);
			float num136 = num117 * num135;
			float num137 = num110 + num136;
			list6.Add(num137);
			goto IL_2b79;
			IL_2b79:
			throw new global::System.NullReferenceException();
			IL_0556:
			double num138 = num72 - double.Epsilon;
			bool flag50 = num138 < 0.0;
			bool flag51 = num138 == 0.0;
			object obj31 = num72 ^ 1;
			object obj32 = num72 ^ num138;
			int num139 = (int)((nint)obj31 & (nint)obj32);
			bool flag52 = num139 < 0;
			bool flag53 = flag50 == flag52;
			bool flag54 = !flag51;
			double num140 = ((!(flag53 && flag54)) ? double.Epsilon : num72);
			double num141 = num72 - 9.218868437227405E+18;
			double num142 = ((num141 == 0.0) ? double.Epsilon : num140);
			num37 = num81 / (float)num142;
			num89 = (int)num142;
			goto IL_2be6;
			IL_034c:
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
			bool flag55 = !(num84 < 0f);
			num87 = num84;
			num88 = num84;
			num75 = num84;
			num70 = num84;
			if (!flag55)
			{
				goto IL_0398;
			}
			goto IL_04b0;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60004A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1024EEC", Offset = "0x1024EEC", Length = "0x20")]
		[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.thickness = 0.05f;\n\tthis.innerSegmentLengthRatio = 4f;\n\tPathCreation.Examples.PathSceneTool::.ctor(this);\n\treturn;\n// 5 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
		public PlanarLineMeshCreator()
		{
			thickness = 0.05f;
			innerSegmentLengthRatio = 4f;
		}
	}
}
