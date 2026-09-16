[global::Cpp2ILInjected.Token(Token = "0x200005D")]
public class Octopus : SpecialFluid
{
	[global::Cpp2ILInjected.Token(Token = "0x4000183")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public global::System.Collections.Generic.HashSet<int> headParticleIds;

	[global::Cpp2ILInjected.Token(Token = "0x4000184")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public int splitIndex;

	[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF24D4", Offset = "0xFF24D4", Length = "0x68")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.id = _id;\n\tv31 = this + 0xB0;\n\tthis.headParticleIds = _headIds;\n\tv34 = 0xF3F1B4(v31, _headIds, _particleIds, _fluidType, _compute, _id, _headIds, _splitIndex, v35, v36, v37, v38, v39, v40, v41, v42);\n\tthis.splitIndex = _splitIndex;\n\tSpecialFluid::Init(this, _solver, _particleIds, _fluidType, _compute);\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Init(FluidSolver _solver, global::System.Collections.Generic.HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, int _id, global::System.Collections.Generic.HashSet<int> _headIds, int _splitIndex)
	{
		//IL_0016: Expected O, but got I
		id = _id;
		object obj = (nint)this + 176;
		headParticleIds = _headIds;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		splitIndex = _splitIndex;
		base.Init(_solver, _particleIds, _fluidType, _compute);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF28F4", Offset = "0xFF28F4", Length = "0x130")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0018;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xC68;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv44 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv45 = v44 + 0x978;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v45, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A9C1]) = v42;\nL_0018:\n\tSpecialFluid::OnPreComputeUpdate(this);\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv102 = this.solver + 0x3B8;\n\tv103 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::get_Item(v102, this.id);\n\tv69 = Unity.Mathematics.float2::op_Implicit(v103);\n\tv137 = \"Writing object reference to Id '{0}' for {1}.\";\n\t// 55 MakeStruct v56 @ AGGFF299C_2_v2 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v69 @ V0_v3 (UnityEngine.Vector2), v69.y (System.Single), 0, 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v137 @ X8_v5 (System.String)+978]), v56);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\tv86 = UnityEngine.Component::get_transform(this);\n\tv70 = UnityEngine.Transform::get_position(v86);\n\tv87 = UnityEngine.Component::get_transform(this);\n\tv146 = this.id * 0x36A7C5AC;\n\tv116 = v146 + -1f;\n\t// 97 MakeStruct v105 @ AGGFF2A1C_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v70 @ V0_v4 (UnityEngine.Vector3), v70.y (System.Single), v116 @ V2_v4 (System.Single)\n\tUnityEngine.Transform::set_position(v87, v105);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 74 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public unsafe override void OnPreComputeUpdate()
	{
		//IL_002d: Expected O, but got I
		//IL_00b6: Expected O, but got I
		base.OnPreComputeUpdate();
		mr.GetPropertyBlock(_propBlock);
		global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2> nativeParallelHashMap = (global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>)((nint)solver + 952);
		global::Unity.Mathematics.float2 float5 = (*(global::Unity.Collections.NativeHashMap<int, global::Unity.Mathematics.float2>*)nativeParallelHashMap)[id];
		global::UnityEngine.Vector2 vector = float5;
		string text = "Writing object reference to Id '{0}' for {1}.";
		global::UnityEngine.Vector4 value = default(global::UnityEngine.Vector4);
		value.x = vector.x;
		value.y = vector.y;
		value.z = 0f;
		value.w = 0f;
		global::UnityEngine.MaterialPropertyBlock propBlock = _propBlock;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v137 @ X8_v5 (System.String)+978]");
		propBlock.SetVector((string)0, value);
		mr.SetPropertyBlock(_propBlock);
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Vector3 vector2 = transform.position;
		global::UnityEngine.Transform transform2 = base.transform;
		int num = id * 916964780;
		float z = (float)num + -1f;
		global::UnityEngine.Vector3 vector3 = default(global::UnityEngine.Vector3);
		vector3.x = vector2.x;
		vector3.y = vector2.y;
		vector3.z = z;
		transform2.position = vector3;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF2A24", Offset = "0xFF2A24", Length = "0x554")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv38 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_004B;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x7D0;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0x978;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv75 = Il2CppMethodInfo;\n\tv76 = v75 + 0x988;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv80 = Il2CppMethodInfo;\n\tv81 = v80 + 0xA90;\n\tv82 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv195 = Il2CppMethodInfo;\n\tv196 = v195 + 0x968;\n\tv197 = \"il2cpp_codegen_initialize_runtime_metadata\"(v196, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv198 = Il2CppMethodInfo;\n\tv199 = v198 + 0x970;\n\tv200 = \"il2cpp_codegen_initialize_runtime_metadata\"(v199, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv212 = Il2CppMethodInfo;\n\tv213 = v212 + 0x978;\n\tv214 = \"il2cpp_codegen_initialize_runtime_metadata\"(v213, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv253 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv254 = v253 + 0x1E8;\n\tv255 = \"il2cpp_codegen_initialize_runtime_metadata\"(v254, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv265 = Il2CppMethodInfo;\n\tv266 = v265 + 0x998;\n\tv267 = \"il2cpp_codegen_initialize_runtime_metadata\"(v266, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv288 = Il2CppMethodInfo;\n\tv289 = v288 + 0x9B0;\n\tv290 = \"il2cpp_codegen_initialize_runtime_metadata\"(v289, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv293 = Il2CppMethodInfo;\n\tv294 = v293 + 0xC30;\n\tv295 = \"il2cpp_codegen_initialize_runtime_metadata\"(v294, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv350 = Il2CppMethodInfo;\n\tv351 = v350 + 0x3C0;\n\tv352 = \"il2cpp_codegen_initialize_runtime_metadata\"(v351, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv442 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv443 = v442 + 0x678;\n\tv444 = \"il2cpp_codegen_initialize_runtime_metadata\"(v443, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv457 = System.Xml.ValidateNames;\n\tv458 = v457 + 0xD40;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v458, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv64 = 1;\n\t*([302A9C2]) = v64;\nL_004B:\n\tv69 = new *([v38 @ X20_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+678])();\n\tSystem.Object::.ctor(v69);\n\tv78 = this.solver;\n\tv79 = this.solver == 0;\n\tif (v79) goto L_017F;\n\tv83 = v69 == 0;\n\tif (v83) goto L_017F;\n\tv192 = this.particleIds;\n\t*([v69 @ X0_v3 (System.Object)+10]) = v78.positions;\n\tv188 = this.solver;\n\tv182 = this.solver == 0;\n\tif (v182) goto L_017F;\n\t*([v69 @ X0_v3 (System.Object)+20]) = v188.idToIndex;\n\tv183 = this.particleIds == 0;\n\tif (v183) goto L_017F;\n\tv215 = System.Xml.ValidateNames;\n\tv219 = Il2CppMethodInfo;\n\tv221 = Il2CppMethodInfo;\n\tv225 = Il2CppMethodInfo;\n\tv164 = Il2CppMethodInfo + 0x968;\n\tv227 = v69 + 0x20;\n\tv229 = *([v215 @ X8_v37 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv230 = *([v229 @ X8_v39+B8]);\n\t*([v69 @ X0_v3 (System.Object)+30]) = *([v230 @ X8_v40]);\n\tv236 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.particleIds);\nL_007E:\n\tv284 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v157 @ stack_-B8 (System.Int32), *([v219 @ X28_v4 (Il2CppMethodInfo)+970]));\n\tv291 = v284 & 1;\n\tv279 = v291 == 0;\n\tif (v279) goto L_008E;\n\tv324 = *([v221 @ X23_v6 (Il2CppMethodInfo)+C30]);\n\tv277 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v227, v259, *([v221 @ X23_v6 (Il2CppMethodInfo)+C30]));\n\tv281 = *([v69 @ X0_v3 (System.Object)+10]);\n\tv273 = *([v69 @ X0_v3 (System.Object)+30]) + *([v281 @ X8_v51+v277 @ X0_v61*8]);\n\t*([v69 @ X0_v3 (System.Object)+30]) = v273;\n\tgoto L_007E;\nL_008E:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v157 @ stack_-B8 (System.Int32), *([v225 @ X26_v4 (Il2CppMethodInfo)+968]));\nL_008F:\n\t;\n\t// 146 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv356 = *([v69 @ X0_v3 (System.Object)+30]) / v192._count;\n\t*([v69 @ X0_v3 (System.Object)+30]) = v356;\n\tv361 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.particleIds);\nL_00A5:\n\tv472 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v157 @ stack_-B8 (System.Int32), *([v219 @ X28_v4 (Il2CppMethodInfo)+970]));\n\tv489 = v472 & 1;\n\tv340 = v489 == 0;\n\tif (v340) goto L_00B8;\n\tv324 = *([v221 @ X23_v6 (Il2CppMethodInfo)+C30]);\n\tv467 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v227, v259, *([v221 @ X23_v6 (Il2CppMethodInfo)+C30]));\n\tv469 = *([v69 @ X0_v3 (System.Object)+10]);\n\tv526 = *([v469 @ X8_v50+v467 @ X0_v59*8]) - *([v69 @ X0_v3 (System.Object)+30]);\n\tv527 = v526 * v526;\n\tv325 = v325 + v527;\n\tv463 = v526 * v371;\n\tv460 = v139 + v463;\n\tgoto L_00A5;\nL_00B8:\n\tv245 = *([v225 @ X26_v4 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v157 @ stack_-B8 (System.Int32), *([v225 @ X26_v4 (Il2CppMethodInfo)+968]));\nL_00C0:\n\tgoto L_00C9;\n\tv362 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv363 = v362 + 0x918;\n\tv364 = \"il2cpp_codegen_initialize_runtime_metadata\"(v363, v335, v323, v302, v49, v50, v51, v52, v333, v321, v317, v347, v307, v306, v59, v60);\n\tv366 = v142;\n\tv369 = 1;\n\t*([2DD4420]) = v369;\nL_00C9:\n\tv90 = v139 / v192._count;\n\tgoto L_00D3;\n\tv451 = \"il2cpp_codegen_runtime_class_init\"(v374, v335, v323, v302, v49, v50, v51, v52, v370, v321, v317, v365, v307, v306, v59, v60);\n\tv453 = v142;\nL_00D3:\n\tv455 = v325 / v192._count;\n\tv456 = UnityEngine.Mathf::Abs(v90);\n\tv485 = v371 / v192._count;\n\tv488 = v456 <= 0x358637BD;\n\tif (v488) goto L_00FC;\n\tv490 = v485 + v455;\n\tv491 = v485 * v455;\n\tv492 = v90 * v90;\n\tv105 = v490 * v490;\n\tv495 = v491 - v492;\n\tv496 = v105 * 0.25f;\n\tv497 = v496 - v495;\n\tv499 = v490 * 0.5f;\n\tv500 = UnityEngine.Mathf::Sqrt(v497);\n\tv517 = v499 + v500;\n\tv325 = v517 - v485;\n\t*([v341 @ X20_v5 (System.Object)+38]) = v325;\n\t*([v341 @ X20_v5 (System.Object)+3C]) = v90;\n\tgoto L_011F;\n\tgoto L_0117;\nL_00FC:\n\tv503 = v455 - v485;\n\tv504 = v503 < 0;\n\tv505 = v503 == 0;\n\tv506 = v455 ^ v485;\n\tv507 = v455 ^ v503;\n\tv508 = v506 & v507;\n\tv509 = v508 < 0;\n\tv512 = v504 == v509;\n\tv513 = ~v505;\n\tv514 = v512 & v513;\n\tv515 = ~v514;\n\tif (v515) goto L_FFFFFFFF;\n\tgoto L_010E;\nL_010E:\n\t*([v341 @ X20_v5 (System.Object)+38]) = v574;\n\tv535 = v574 >> 0x20;\n\tgoto L_011F;\nL_0117:\n\tv578 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv563 = \"il2cpp_codegen_initialize_runtime_metadata\"(v578, v245, v324, v302, v49, v50, v51, v52, v485, v559, v556, v557, v537, v536, v59, v60);\n\t*([2DD4420]) = 1;\nL_011F:\n\tgoto L_0121;\n\tv579 = \"il2cpp_codegen_runtime_class_init\"(v570, v335, v323, v302, v49, v50, v51, v52, v485, v558, v134, v136, v105, v103, v59, v60);\nL_0121:\n\tv581 = v325 * v325;\n\tv582 = v90 * v90;\n\tv583 = v581 + v582;\n\tv584 = UnityEngine.Mathf::Sqrt(v583);\n\tv586 = 1f / v584;\n\tv143 = v325 * v586;\n\tv173 = v90 * v586;\n\t*([v341 @ X20_v5 (System.Object)+38]) = v143;\n\t*([v341 @ X20_v5 (System.Object)+3C]) = v173;\n\tv587 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv590 = new *([v587 @ X8_v13 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1E8])();\n\tv592 = Il2CppMethodInfo;\n\tSystem.Func`2<System.Int32, System.Single>::.ctor(v590, v341, *([v592 @ X8_v15 (Il2CppMethodInfo)+3C0]));\n\tv601 = System.Linq.Enumerable::OrderBy(v344, v590);\n\tv603 = System.Linq.Enumerable::ToList(v601);\n\tv126 = v192._c\n// ... truncated")]
	public void Split()
	{
		//IL_000e: Expected I, but got O
		//IL_0082: Expected F4, but got O
		//IL_0099: Expected I4, but got O
		//IL_0761: Expected I4, but got O
		//IL_0769: Expected O, but got I4
		//IL_00cf: Expected F4, but got O
		//IL_00e6: Expected I4, but got O
		//IL_0790: Expected I4, but got O
		//IL_0102: Expected I, but got O
		//IL_0122: Expected O, but got I
		//IL_0131: Expected O, but got I
		//IL_0141: Expected O, but got I
		//IL_0151: Expected O, but got I
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_042f: Expected I4, but got Unknown
		//IL_043c: Expected I4, but got F4
		//IL_04b2: Expected F4, but got I8
		//IL_0896: Expected I4, but got F4
		//IL_08b5: Expected F4, but got I4
		//IL_017a: Expected O, but got I
		//IL_0194: Expected O, but got I
		//IL_01b1: Expected O, but got I
		//IL_0590: Expected I, but got O
		//IL_02b8: Expected O, but got I
		//IL_0229: Expected O, but got I
		//IL_0243: Expected O, but got I
		//IL_0260: Expected O, but got I
		//IL_026f: Expected O, but got I
		//IL_028d: Expected O, but got I
		//IL_0905: Expected O, but got I
		nint num = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
		object obj = new object();
		FluidSolver fluidSolver = solver;
		bool flag = (object)solver == null;
		global::System.Collections.Generic.List<int> list = null;
		object obj2 = obj;
		int num2 = 50503680;
		global::System.Collections.Generic.HashSet<int> hashSet = default(global::System.Collections.Generic.HashSet<int>);
		object obj3 = default(object);
		int num10 = default(int);
		float num11 = default(float);
		object obj16 = default(object);
		global::System.Collections.Generic.IEnumerable<int> source;
		float num3;
		object obj8;
		if (!flag)
		{
			bool flag2 = obj == null;
			list = null;
			obj2 = obj;
			num2 = 50503680;
			if (!flag2)
			{
				hashSet = particleIds;
				_ = fluidSolver.positions;
				FluidSolver fluidSolver2 = solver;
				bool flag3 = (object)solver == null;
				num3 = (float)fluidSolver.positions;
				list = null;
				obj2 = obj;
				num2 = (int)particleIds;
				if (!flag3)
				{
					_ = fluidSolver2.idToIndex;
					bool flag4 = particleIds == null;
					num3 = (float)fluidSolver2.idToIndex;
					list = null;
					obj2 = obj;
					num2 = (int)particleIds;
					if (!flag4)
					{
						nint num4 = (nint)typeof(global::System.Xml.ValidateNames);
						nint num5 = 0;
						nint num6 = 0;
						nint num7 = 0;
						obj3 = (nint)0 + (nint)2408;
						object obj4 = (nint)obj + 32;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v215 @ X8_v37 (Il2CppClass<System.Xml.ValidateNames>)+D40]");
						object obj5 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v229 @ X8_v39+B8]");
						object obj6 = 0;
						global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = particleIds.GetEnumerator();
						object obj7 = default(object);
						while (true)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
							if ((int)((nint)obj7 & 1) == 0)
							{
								break;
							}
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X23_v6 (Il2CppMethodInfo)+C30]");
							obj8 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E75E4 (Unity.Collections.NativeHashMap`2::get_Item, and 1 more at this address)");
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+10]");
							object obj9 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+30]");
							nint num8 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v281 @ X8_v51+v277 @ X0_v61*8]");
							object obj10 = num8 + 0;
						}
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+30]");
						int num9 = (int)((nint)0 / (nint)hashSet.Count);
						global::System.Collections.Generic.HashSet<int>.Enumerator enumerator2 = particleIds.GetEnumerator();
						num10 = 0;
						num11 = 0f;
						object obj11 = default(object);
						while (true)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
							if ((int)((nint)obj11 & 1) == 0)
							{
								break;
							}
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v221 @ X23_v6 (Il2CppMethodInfo)+C30]");
							obj8 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E75E4 (Unity.Collections.NativeHashMap`2::get_Item, and 1 more at this address)");
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+10]");
							object obj12 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v469 @ X8_v50+v467 @ X0_v59*8]");
							nint num12 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v69 @ X0_v3 (System.Object)+30]");
							object obj13 = num12 - 0;
							object obj14 = (nint)obj13 * (nint)obj13;
							num11 += (float)obj14;
							object obj15 = (nint)obj13 * (nint)obj16;
							int num13 = (int)(num10 + (nint)obj15);
							num10 = num13;
						}
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v225 @ X26_v4 (Il2CppMethodInfo)+968]");
						list = (global::System.Collections.Generic.List<int>)0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
						int num14 = 0;
						obj2 = obj;
						source = particleIds;
						goto IL_0864;
					}
				}
			}
		}
		goto IL_06e8;
		IL_0864:
		float num15 = (float)num10 / (float)hashSet.Count;
		float num16 = num11 / (float)hashSet.Count;
		float num17 = global::UnityEngine.Mathf.Abs(num15);
		int num18 = (int)((nint)obj16 / hashSet.Count);
		if (num17 > 1E-06f)
		{
			float num19 = (float)num18 + num16;
			float num20 = (float)num18 * num16;
			float num21 = num15 * num15;
			float num22 = num19 * num19;
			float num23 = num20 - num21;
			float num24 = num22 * 0.25f;
			float f = num24 - num23;
			float num25 = num19 * 0.5f;
			float num26 = global::UnityEngine.Mathf.Sqrt(f);
			float num27 = num25 + num26;
			num11 = num27 - (float)num18;
			float num28 = 0.25f;
			float num29 = 0.5f;
		}
		else
		{
			float num30 = num16 - (float)num18;
			bool flag5 = num30 < 0f;
			bool flag6 = num30 == 0f;
			int num31 = num16 ^ num18;
			int num32 = num16 ^ num30;
			int num33 = num31 & num32;
			bool flag7 = num33 < 0;
			bool flag8 = flag5 == flag7;
			bool flag9 = !flag6;
			float num34 = ((!(flag8 && flag9)) ? 4.5756572E+18f : 1f);
			int num35 = num34 >> 32;
			num15 = num35;
			float num25 = 1E-06f;
			float num29 = hashSet.Count;
			num11 = num34;
		}
		float num36 = num11 * num11;
		float num37 = num15 * num15;
		float f2 = num36 + num37;
		float num38 = global::UnityEngine.Mathf.Sqrt(f2);
		float num39 = 1f / num38;
		float num40 = num11 * num39;
		num3 = num15 * num39;
		nint num41 = (nint)typeof(global::System.Func<global::UnityEngine.UIElements.ValidateCommandEvent>);
		object obj17 = obj2;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v592 @ X8_v15 (Il2CppMethodInfo)+3C0]");
		global::System.Func<int, float> keySelector = new global::System.Func<int, float>(obj17, (global::System.IntPtr)0);
		nint num42 = 0;
		global::System.Linq.IOrderedEnumerable<int> source2 = global::System.Linq.Enumerable.OrderBy(source, keySelector);
		global::System.Collections.Generic.List<int> list2 = global::System.Linq.Enumerable.ToList(source2);
		bool flag10 = hashSet.Count < 0;
		int num43 = hashSet.Count ^ hashSet.Count;
		int num44 = hashSet.Count & num43;
		bool flag11 = num44 < 0;
		int num45 = ((flag10 == flag11) ? hashSet.Count : (hashSet.Count + 1));
		num2 = num45 >> 1;
		nint num46 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @113AAE0 (System.Linq.Enumerable::Take, and 1 more at this address)");
		global::System.Collections.Generic.IEnumerable<int> source3 = default(global::System.Collections.Generic.IEnumerable<int>);
		global::System.Collections.Generic.List<int> ids = global::System.Linq.Enumerable.ToList(source3);
		nint num47 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v617 @ X8_v22 (Il2CppMethodInfo)+978]");
		obj8 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @113A748 (System.Linq.Enumerable::Skip, and 1 more at this address)");
		global::System.Collections.Generic.IEnumerable<int> source4 = default(global::System.Collections.Generic.IEnumerable<int>);
		global::System.Collections.Generic.List<int> list3 = global::System.Linq.Enumerable.ToList(source4);
		AddOctopus(ids);
		AddOctopus(list3);
		bool flag12 = (object)solver == null;
		list = list3;
		obj2 = list3;
		if (!flag12)
		{
			solver.RemoveOctopus(this);
			return;
		}
		goto IL_06e8;
		IL_06e8:
		global::System.NullReferenceException ex = new global::System.NullReferenceException();
		bool flag13 = (nint)list != 1;
		global::System.NullReferenceException ex2 = ex;
		if (!flag13)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			list = (global::System.Collections.Generic.List<int>)obj3;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
			object obj18 = default(object);
			bool flag14 = obj18 == null;
			int num14 = (int)obj18;
			source = (global::System.Collections.Generic.IEnumerable<int>)num2;
			if (flag14)
			{
				goto IL_0864;
			}
			global::System.OutOfMemoryException ex3 = new global::System.OutOfMemoryException();
			ex2 = (global::System.NullReferenceException)(object)ex3;
			num14 = (int)obj18;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF2F80", Offset = "0xFF2F80", Length = "0x1C0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0024;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x480;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, ids, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x488;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, ids, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv156 = Il2CppMethodInfo;\n\tv157 = v156 + 0xC30;\n\tv158 = \"il2cpp_codegen_initialize_runtime_metadata\"(v157, ids, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv196 = CollectParticleData[];\n\tv197 = v196 + 0x718;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v197, ids, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv51 = 1;\n\t*([302AA2C]) = v51;\nL_0024:\n\tv56 = CollectParticleData[];\n\tv60 = \"SzArrayNew\"(*([v56 @ X8_v5 (Il2CppClass<CollectParticleData[]>)+718]), ids._size, methodInfo, v35, v36, v37, v38, v39, v64, v41, v42, v43, v44, v45, v46, v47);\n\tv170 = ids._size < 1;\n\tif (v170) goto L_006A;\n\tv199 = Il2CppMethodInfo;\n\tv82 = Il2CppMethodInfo + 0xC30;\n\tv200 = v60 == 0;\n\tif (v200) goto L_009C;\n\tv76 = v60 + 0x20;\nL_0042:\n\tv140 = System.Collections.Generic.List`1<System.Int32>::get_Item(ids, v80);\n\tv72 = this.solver;\n\tv290 = this.solver + 0x1F8;\n\tv215 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v290, v140, *([v199 @ X23_v5 (Il2CppMethodInfo)+C30]));\n\tv301 = v72.positions;\n\t*([v76 @ X25_v6+v80 @ X22_v7 (System.Int32)*8]) = *([v301 @ X8_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v215 @ X0_v31*8]);\n\tv80 = v80 + 1;\n\tv204 = v80 < ids._size;\n\tif (v204) goto L_0042;\nL_006A:\n\tv69 = this.splitIndex - 1;\n\tv142 = FluidSolver::AddOctopus(this.solver, v60, v69);\n\tv286 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_007E;\n\tv291 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv292 = v291 + 0xFF0;\n\tv293 = \"il2cpp_codegen_initialize_runtime_metadata\"(v292, v137, v69, v35, v36, v37, v38, v39, v64, v41, v42, v43, v44, v45, v46, v47);\n\tv295 = 1;\n\t*([302AA2D]) = v295;\nL_007E:\n\tv297 = new *([v286 @ X21_v5 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+FF0])();\n\tSystem.Object::.ctor(v297);\n\t*([v297 @ X0_v15 (System.Object)+10]) = 0;\n\tv305 = v297 + 0x20;\n\t*([v297 @ X0_v15 (System.Object)+20]) = v142;\n\tv307 = 0xF3F1B4(v305, v142, v69, v35, v36, v37, v38, v39, *([v301 @ X8_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v215 @ X0_v31*8]), v41, v42, v43, v44, v45, v46, v47);\n\tv270 = UnityEngine.MonoBehaviour::StartCoroutine(v142, v297);\n\treturn;\n\tthrow System.IndexOutOfRangeException;\nL_009C:\n\tv139 = System.Collections.Generic.List`1<System.Int32>::get_Item(ids, 0);\n\tv242 = this.solver == 0;\n\tv144 = ~v242;\n\tif (v144) goto L_00A3;\n\tv155 = new System.NullReferenceException();\nL_00A3:\n\tv193 = v190 + 0x1F8;\n\tv195 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v193, v139, *([v176 @ X23_v1]));\n\tthrow System.NullReferenceException;\n\treturn;\n// 108 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void AddOctopus(global::System.Collections.Generic.List<int> ids)
	{
		//IL_0013: Expected I, but got O
		//IL_012f: Expected I, but got O
		//IL_0052: Expected O, but got I
		//IL_021a: Expected O, but got I
		//IL_01cb: Expected O, but got I
		//IL_007e: Expected O, but got I
		//IL_01ad: Expected I4, but got O
		//IL_009d: Expected O, but got I
		nint num = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		global::Unity.Mathematics.float2[] array = default(global::Unity.Mathematics.float2[]);
		if (ids.Count >= 1)
		{
			nint num2 = 0;
			object obj = (nint)0 + (nint)3120;
			if (array == null)
			{
				int num3 = ids[0];
				bool flag = (object)solver == null;
				bool flag2 = !flag;
				object obj2 = obj;
				FluidSolver fluidSolver = solver;
				if (!flag2)
				{
					global::System.NullReferenceException ex = new global::System.NullReferenceException();
					obj2 = obj;
					num3 = (int)ex;
					fluidSolver = solver;
				}
				object obj3 = (nint)fluidSolver + 504;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E75E4 (Unity.Collections.NativeHashMap`2::get_Item, and 1 more at this address)");
				throw new global::System.NullReferenceException();
			}
			object obj4 = (nint)array + 32;
			int num4 = 0;
			do
			{
				int num5 = ids[num4];
				FluidSolver fluidSolver2 = solver;
				object obj5 = (nint)solver + 504;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E75E4 (Unity.Collections.NativeHashMap`2::get_Item, and 1 more at this address)");
				global::Unity.Collections.NativeArray<global::Unity.Mathematics.float2> nativeArray = fluidSolver2.positions;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v301 @ X8_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v215 @ X0_v31*8]");
				_ = 0;
				num4++;
			}
			while (num4 < ids.Count);
		}
		int num6 = splitIndex - 1;
		Octopus octopus = solver.AddOctopus(array, num6);
		nint num7 = (nint)typeof(global::TMPro.KerningTable._003C_003Ec__DisplayClass3_0);
		object obj6 = new object();
		_ = 0;
		object obj7 = (nint)obj6 + 32;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::UnityEngine.Coroutine coroutine = octopus.StartCoroutine((global::System.Collections.IEnumerator)obj6);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF35FC", Offset = "0xFF35FC", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x968;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv50 = v49 + 0x5D8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A9C3]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v48);\n\tv54 = this + 0xB0;\n\tthis.headParticleIds = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tthis.zPos = -1f;\n\tthis.particleSize = 0.8f;\n\tthis.particleBoundsRadius = 0.4f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Octopus()
	{
		//IL_0014: Expected I, but got O
		//IL_0052: Expected O, but got I
		base._002Ector();
		nint num = (nint)typeof(global::System.Func<global::UnityEngine.UIElements.ValidateCommandEvent>);
		global::System.Collections.Generic.HashSet<int> hashSet = new global::System.Collections.Generic.HashSet<int>();
		object obj = (nint)this + 176;
		headParticleIds = hashSet;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		zPos = -1f;
		particleSize = 0.8f;
		particleBoundsRadius = 0.4f;
	}
}
