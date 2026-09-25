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
		id = _id;
		headParticleIds = _headIds;
		splitIndex = _splitIndex;
		base.Init(_solver, _particleIds, _fluidType, _compute);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF28F4", Offset = "0xFF28F4", Length = "0x130")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0018;\n\tv21 = Il2CppMethodInfo;\n\tv22 = v21 + 0xC68;\n\tv23 = \"il2cpp_codegen_initialize_runtime_metadata\"(v22, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv44 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv45 = v44 + 0x978;\n\tv40 = \"il2cpp_codegen_initialize_runtime_metadata\"(v45, methodInfo, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38);\n\tv42 = 1;\n\t*([302A9C1]) = v42;\nL_0018:\n\tSpecialFluid::OnPreComputeUpdate(this);\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\tv102 = this.solver + 0x3B8;\n\tv103 = Unity.Collections.NativeHashMap`2<System.Int32, Unity.Mathematics.float2>::get_Item(v102, this.id);\n\tv69 = Unity.Mathematics.float2::op_Implicit(v103);\n\tv137 = \"Writing object reference to Id '{0}' for {1}.\";\n\t// 55 MakeStruct v56 @ AGGFF299C_2_v2 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v69 @ V0_v3 (UnityEngine.Vector2), v69.y (System.Single), 0, 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v137 @ X8_v5 (System.String)+978]), v56);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\tv86 = UnityEngine.Component::get_transform(this);\n\tv70 = UnityEngine.Transform::get_position(v86);\n\tv87 = UnityEngine.Component::get_transform(this);\n\tv146 = this.id * 0x36A7C5AC;\n\tv116 = v146 + -1f;\n\t// 97 MakeStruct v105 @ AGGFF2A1C_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v70 @ V0_v4 (UnityEngine.Vector3), v70.y (System.Single), v116 @ V2_v4 (System.Single)\n\tUnityEngine.Transform::set_position(v87, v105);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 74 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		base.OnPreComputeUpdate();
		mr.GetPropertyBlock(_propBlock);
		if (solver.octopusHeadMidpoints.TryGetValue(id, out global::Unity.Mathematics.float2 headMidpoint))
		{
			_propBlock.SetVector("_HeadPosition", new global::UnityEngine.Vector4(headMidpoint.x, headMidpoint.y, 0f, 0f));
		}
		mr.SetPropertyBlock(_propBlock);
		global::UnityEngine.Vector3 position = base.transform.position;
		position.z = id * depthStride - 1f;
		base.transform.position = position;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF2A24", Offset = "0xFF2A24", Length = "0x554")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv38 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_004B;\n\tv43 = Il2CppMethodInfo;\n\tv44 = v43 + 0x7D0;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv70 = Il2CppMethodInfo;\n\tv71 = v70 + 0x978;\n\tv72 = \"il2cpp_codegen_initialize_runtime_metadata\"(v71, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv75 = Il2CppMethodInfo;\n\tv76 = v75 + 0x988;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v76, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv80 = Il2CppMethodInfo;\n\tv81 = v80 + 0xA90;\n\tv82 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv195 = Il2CppMethodInfo;\n\tv196 = v195 + 0x968;\n\tv197 = \"il2cpp_codegen_initialize_runtime_metadata\"(v196, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv198 = Il2CppMethodInfo;\n\tv199 = v198 + 0x970;\n\tv200 = \"il2cpp_codegen_initialize_runtime_metadata\"(v199, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv212 = Il2CppMethodInfo;\n\tv213 = v212 + 0x978;\n\tv214 = \"il2cpp_codegen_initialize_runtime_metadata\"(v213, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv253 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv254 = v253 + 0x1E8;\n\tv255 = \"il2cpp_codegen_initialize_runtime_metadata\"(v254, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv265 = Il2CppMethodInfo;\n\tv266 = v265 + 0x998;\n\tv267 = \"il2cpp_codegen_initialize_runtime_metadata\"(v266, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv288 = Il2CppMethodInfo;\n\tv289 = v288 + 0x9B0;\n\tv290 = \"il2cpp_codegen_initialize_runtime_metadata\"(v289, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv293 = Il2CppMethodInfo;\n\tv294 = v293 + 0xC30;\n\tv295 = \"il2cpp_codegen_initialize_runtime_metadata\"(v294, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv350 = Il2CppMethodInfo;\n\tv351 = v350 + 0x3C0;\n\tv352 = \"il2cpp_codegen_initialize_runtime_metadata\"(v351, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv442 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv443 = v442 + 0x678;\n\tv444 = \"il2cpp_codegen_initialize_runtime_metadata\"(v443, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv457 = System.Xml.ValidateNames;\n\tv458 = v457 + 0xD40;\n\tv62 = \"il2cpp_codegen_initialize_runtime_metadata\"(v458, methodInfo, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60);\n\tv64 = 1;\n\t*([302A9C2]) = v64;\nL_004B:\n\tv69 = new *([v38 @ X20_v1 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+678])();\n\tSystem.Object::.ctor(v69);\n\tv78 = this.solver;\n\tv79 = this.solver == 0;\n\tif (v79) goto L_017F;\n\tv83 = v69 == 0;\n\tif (v83) goto L_017F;\n\tv192 = this.particleIds;\n\t*([v69 @ X0_v3 (System.Object)+10]) = v78.positions;\n\tv188 = this.solver;\n\tv182 = this.solver == 0;\n\tif (v182) goto L_017F;\n\t*([v69 @ X0_v3 (System.Object)+20]) = v188.idToIndex;\n\tv183 = this.particleIds == 0;\n\tif (v183) goto L_017F;\n\tv215 = System.Xml.ValidateNames;\n\tv219 = Il2CppMethodInfo;\n\tv221 = Il2CppMethodInfo;\n\tv225 = Il2CppMethodInfo;\n\tv164 = Il2CppMethodInfo + 0x968;\n\tv227 = v69 + 0x20;\n\tv229 = *([v215 @ X8_v37 (Il2CppClass<System.Xml.ValidateNames>)+D40]);\n\tv230 = *([v229 @ X8_v39+B8]);\n\t*([v69 @ X0_v3 (System.Object)+30]) = *([v230 @ X8_v40]);\n\tv236 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.particleIds);\nL_007E:\n\tv284 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v157 @ stack_-B8 (System.Int32), *([v219 @ X28_v4 (Il2CppMethodInfo)+970]));\n\tv291 = v284 & 1;\n\tv279 = v291 == 0;\n\tif (v279) goto L_008E;\n\tv324 = *([v221 @ X23_v6 (Il2CppMethodInfo)+C30]);\n\tv277 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v227, v259, *([v221 @ X23_v6 (Il2CppMethodInfo)+C30]));\n\tv281 = *([v69 @ X0_v3 (System.Object)+10]);\n\tv273 = *([v69 @ X0_v3 (System.Object)+30]) + *([v281 @ X8_v51+v277 @ X0_v61*8]);\n\t*([v69 @ X0_v3 (System.Object)+30]) = v273;\n\tgoto L_007E;\nL_008E:\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v157 @ stack_-B8 (System.Int32), *([v225 @ X26_v4 (Il2CppMethodInfo)+968]));\nL_008F:\n\t;\n\t// 146 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv356 = *([v69 @ X0_v3 (System.Object)+30]) / v192._count;\n\t*([v69 @ X0_v3 (System.Object)+30]) = v356;\n\tv361 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.particleIds);\nL_00A5:\n\tv472 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v157 @ stack_-B8 (System.Int32), *([v219 @ X28_v4 (Il2CppMethodInfo)+970]));\n\tv489 = v472 & 1;\n\tv340 = v489 == 0;\n\tif (v340) goto L_00B8;\n\tv324 = *([v221 @ X23_v6 (Il2CppMethodInfo)+C30]);\n\tv467 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v227, v259, *([v221 @ X23_v6 (Il2CppMethodInfo)+C30]));\n\tv469 = *([v69 @ X0_v3 (System.Object)+10]);\n\tv526 = *([v469 @ X8_v50+v467 @ X0_v59*8]) - *([v69 @ X0_v3 (System.Object)+30]);\n\tv527 = v526 * v526;\n\tv325 = v325 + v527;\n\tv463 = v526 * v371;\n\tv460 = v139 + v463;\n\tgoto L_00A5;\nL_00B8:\n\tv245 = *([v225 @ X26_v4 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v157 @ stack_-B8 (System.Int32), *([v225 @ X26_v4 (Il2CppMethodInfo)+968]));\nL_00C0:\n\tgoto L_00C9;\n\tv362 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv363 = v362 + 0x918;\n\tv364 = \"il2cpp_codegen_initialize_runtime_metadata\"(v363, v335, v323, v302, v49, v50, v51, v52, v333, v321, v317, v347, v307, v306, v59, v60);\n\tv366 = v142;\n\tv369 = 1;\n\t*([2DD4420]) = v369;\nL_00C9:\n\tv90 = v139 / v192._count;\n\tgoto L_00D3;\n\tv451 = \"il2cpp_codegen_runtime_class_init\"(v374, v335, v323, v302, v49, v50, v51, v52, v370, v321, v317, v365, v307, v306, v59, v60);\n\tv453 = v142;\nL_00D3:\n\tv455 = v325 / v192._count;\n\tv456 = UnityEngine.Mathf::Abs(v90);\n\tv485 = v371 / v192._count;\n\tv488 = v456 <= 0x358637BD;\n\tif (v488) goto L_00FC;\n\tv490 = v485 + v455;\n\tv491 = v485 * v455;\n\tv492 = v90 * v90;\n\tv105 = v490 * v490;\n\tv495 = v491 - v492;\n\tv496 = v105 * 0.25f;\n\tv497 = v496 - v495;\n\tv499 = v490 * 0.5f;\n\tv500 = UnityEngine.Mathf::Sqrt(v497);\n\tv517 = v499 + v500;\n\tv325 = v517 - v485;\n\t*([v341 @ X20_v5 (System.Object)+38]) = v325;\n\t*([v341 @ X20_v5 (System.Object)+3C]) = v90;\n\tgoto L_011F;\n\tgoto L_0117;\nL_00FC:\n\tv503 = v455 - v485;\n\tv504 = v503 < 0;\n\tv505 = v503 == 0;\n\tv506 = v455 ^ v485;\n\tv507 = v455 ^ v503;\n\tv508 = v506 & v507;\n\tv509 = v508 < 0;\n\tv512 = v504 == v509;\n\tv513 = ~v505;\n\tv514 = v512 & v513;\n\tv515 = ~v514;\n\tif (v515) goto L_FFFFFFFF;\n\tgoto L_010E;\nL_010E:\n\t*([v341 @ X20_v5 (System.Object)+38]) = v574;\n\tv535 = v574 >> 0x20;\n\tgoto L_011F;\nL_0117:\n\tv578 = Facebook.Unity.Windows.IWindowsFacebook + 0x918;\n\tv563 = \"il2cpp_codegen_initialize_runtime_metadata\"(v578, v245, v324, v302, v49, v50, v51, v52, v485, v559, v556, v557, v537, v536, v59, v60);\n\t*([2DD4420]) = 1;\nL_011F:\n\tgoto L_0121;\n\tv579 = \"il2cpp_codegen_runtime_class_init\"(v570, v335, v323, v302, v49, v50, v51, v52, v485, v558, v134, v136, v105, v103, v59, v60);\nL_0121:\n\tv581 = v325 * v325;\n\tv582 = v90 * v90;\n\tv583 = v581 + v582;\n\tv584 = UnityEngine.Mathf::Sqrt(v583);\n\tv586 = 1f / v584;\n\tv143 = v325 * v586;\n\tv173 = v90 * v586;\n\t*([v341 @ X20_v5 (System.Object)+38]) = v143;\n\t*([v341 @ X20_v5 (System.Object)+3C]) = v173;\n\tv587 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv590 = new *([v587 @ X8_v13 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+1E8])();\n\tv592 = Il2CppMethodInfo;\n\tSystem.Func`2<System.Int32, System.Single>::.ctor(v590, v341, *([v592 @ X8_v15 (Il2CppMethodInfo)+3C0]));\n\tv601 = System.Linq.Enumerable::OrderBy(v344, v590);\n\tv603 = System.Linq.Enumerable::ToList(v601);\n\tv126 = v192._c\n// ... truncated")]
	public void Split()
	{
		if (solver == null || particleIds == null)
		{
			return;
		}
		float meanX = 0f;
		float meanY = 0f;
		foreach (int particleId in particleIds)
		{
			if (!solver.idToIndex.TryGetValue(particleId, out int index))
			{
				continue;
			}
			global::Unity.Mathematics.float2 pos = solver.positions[index];
			meanX += pos.x;
			meanY += pos.y;
		}
		int count = particleIds.Count;
		meanX /= count;
		meanY /= count;
		float sxx = 0f;
		float sxy = 0f;
		float syy = 0f;
		foreach (int particleId2 in particleIds)
		{
			if (!solver.idToIndex.TryGetValue(particleId2, out int index2))
			{
				continue;
			}
			global::Unity.Mathematics.float2 pos2 = solver.positions[index2];
			float dx = pos2.x - meanX;
			float dy = pos2.y - meanY;
			sxx += dx * dx;
			sxy += dx * dy;
			syy += dy * dy;
		}
		sxx /= count;
		sxy /= count;
		syy /= count;
		float axisX;
		float axisY;
		if (global::UnityEngine.Mathf.Abs(sxy) > 1E-06f)
		{
			float trace = sxx + syy;
			float det = sxx * syy - sxy * sxy;
			float discriminant = global::UnityEngine.Mathf.Sqrt(trace * trace * 0.25f - det);
			float lambda = trace * 0.5f + discriminant;
			axisX = lambda - syy;
			axisY = sxy;
		}
		else if (sxx >= syy)
		{
			axisX = 1f;
			axisY = 0f;
		}
		else
		{
			axisX = 0f;
			axisY = 1f;
		}
		float len = global::UnityEngine.Mathf.Sqrt(axisX * axisX + axisY * axisY);
		axisX /= len;
		axisY /= len;
		global::System.Collections.Generic.List<int> sorted = new global::System.Collections.Generic.List<int>(particleIds);
		global::System.Collections.Generic.Dictionary<int, float> keys = new global::System.Collections.Generic.Dictionary<int, float>(sorted.Count);
		foreach (int particleId3 in sorted)
		{
			keys[particleId3] = solver.idToIndex.TryGetValue(particleId3, out int index3) ? (solver.positions[index3].x - meanX) * axisX + (solver.positions[index3].y - meanY) * axisY : 0f;
		}
		sorted.Sort((a, b) => keys[a].CompareTo(keys[b]));
		int half = (count + 1) >> 1;
		AddOctopus(sorted.GetRange(0, half));
		AddOctopus(sorted.GetRange(half, sorted.Count - half));
		solver.RemoveOctopus(this);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF2F80", Offset = "0xFF2F80", Length = "0x1C0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0024;\n\tv31 = Il2CppMethodInfo;\n\tv32 = v31 + 0x480;\n\tv33 = \"il2cpp_codegen_initialize_runtime_metadata\"(v32, ids, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv53 = Il2CppMethodInfo;\n\tv54 = v53 + 0x488;\n\tv55 = \"il2cpp_codegen_initialize_runtime_metadata\"(v54, ids, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv156 = Il2CppMethodInfo;\n\tv157 = v156 + 0xC30;\n\tv158 = \"il2cpp_codegen_initialize_runtime_metadata\"(v157, ids, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv196 = CollectParticleData[];\n\tv197 = v196 + 0x718;\n\tv49 = \"il2cpp_codegen_initialize_runtime_metadata\"(v197, ids, methodInfo, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47);\n\tv51 = 1;\n\t*([302AA2C]) = v51;\nL_0024:\n\tv56 = CollectParticleData[];\n\tv60 = \"SzArrayNew\"(*([v56 @ X8_v5 (Il2CppClass<CollectParticleData[]>)+718]), ids._size, methodInfo, v35, v36, v37, v38, v39, v64, v41, v42, v43, v44, v45, v46, v47);\n\tv170 = ids._size < 1;\n\tif (v170) goto L_006A;\n\tv199 = Il2CppMethodInfo;\n\tv82 = Il2CppMethodInfo + 0xC30;\n\tv200 = v60 == 0;\n\tif (v200) goto L_009C;\n\tv76 = v60 + 0x20;\nL_0042:\n\tv140 = System.Collections.Generic.List`1<System.Int32>::get_Item(ids, v80);\n\tv72 = this.solver;\n\tv290 = this.solver + 0x1F8;\n\tv215 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v290, v140, *([v199 @ X23_v5 (Il2CppMethodInfo)+C30]));\n\tv301 = v72.positions;\n\t*([v76 @ X25_v6+v80 @ X22_v7 (System.Int32)*8]) = *([v301 @ X8_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v215 @ X0_v31*8]);\n\tv80 = v80 + 1;\n\tv204 = v80 < ids._size;\n\tif (v204) goto L_0042;\nL_006A:\n\tv69 = this.splitIndex - 1;\n\tv142 = FluidSolver::AddOctopus(this.solver, v60, v69);\n\tv286 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tgoto L_007E;\n\tv291 = TMPro.KerningTable+<>c__DisplayClass3_0;\n\tv292 = v291 + 0xFF0;\n\tv293 = \"il2cpp_codegen_initialize_runtime_metadata\"(v292, v137, v69, v35, v36, v37, v38, v39, v64, v41, v42, v43, v44, v45, v46, v47);\n\tv295 = 1;\n\t*([302AA2D]) = v295;\nL_007E:\n\tv297 = new *([v286 @ X21_v5 (Il2CppClass<TMPro.KerningTable+<>c__DisplayClass3_0>)+FF0])();\n\tSystem.Object::.ctor(v297);\n\t*([v297 @ X0_v15 (System.Object)+10]) = 0;\n\tv305 = v297 + 0x20;\n\t*([v297 @ X0_v15 (System.Object)+20]) = v142;\n\tv307 = 0xF3F1B4(v305, v142, v69, v35, v36, v37, v38, v39, *([v301 @ X8_v17 (Unity.Collections.NativeArray`1<Unity.Mathematics.float2>)+v215 @ X0_v31*8]), v41, v42, v43, v44, v45, v46, v47);\n\tv270 = UnityEngine.MonoBehaviour::StartCoroutine(v142, v297);\n\treturn;\n\tthrow System.IndexOutOfRangeException;\nL_009C:\n\tv139 = System.Collections.Generic.List`1<System.Int32>::get_Item(ids, 0);\n\tv242 = this.solver == 0;\n\tv144 = ~v242;\n\tif (v144) goto L_00A3;\n\tv155 = new System.NullReferenceException();\nL_00A3:\n\tv193 = v190 + 0x1F8;\n\tv195 = Unity.Collections.NativeHashMap`2::get_Item /* +1 sharing this address */(v193, v139, *([v176 @ X23_v1]));\n\tthrow System.NullReferenceException;\n\treturn;\n// 108 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void AddOctopus(global::System.Collections.Generic.List<int> ids)
	{
		global::Unity.Mathematics.float2[] array = new global::Unity.Mathematics.float2[ids.Count];
		for (int i = 0; i < ids.Count; i++)
		{
			if (solver.idToIndex.TryGetValue(ids[i], out int index))
			{
				array[i] = solver.positions[index];
			}
		}
		int newSplitIndex = splitIndex - 1;
		solver.AddOctopus(array, newSplitIndex);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF35FC", Offset = "0xFF35FC", Length = "0xAC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x968;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv50 = v49 + 0x5D8;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A9C3]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+5D8])();\n\tSystem.Collections.Generic.HashSet`1<System.Int32>::.ctor(v48);\n\tv54 = this + 0xB0;\n\tthis.headParticleIds = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tthis.zPos = -1f;\n\tthis.particleSize = 0.8f;\n\tthis.particleBoundsRadius = 0.4f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 36 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Octopus()
	{
		headParticleIds = new global::System.Collections.Generic.HashSet<int>();
		zPos = -1f;
		particleSize = 0.8f;
		particleBoundsRadius = 0.4f;
	}
}
