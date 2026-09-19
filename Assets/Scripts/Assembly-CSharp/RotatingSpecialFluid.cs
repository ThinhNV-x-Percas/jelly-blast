[global::Cpp2ILInjected.Token(Token = "0x20000CA")]
public class RotatingSpecialFluid : SpecialFluid
{
	[global::Cpp2ILInjected.Token(Token = "0x4000459")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public float zRotation;

	[global::Cpp2ILInjected.Token(Token = "0x400045A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	private readonly global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector2> prevOffset;

	[global::Cpp2ILInjected.Token(Token = "0x400045B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
	private float filteredDelta;

	[global::Cpp2ILInjected.Token(Token = "0x600039D")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015238", Offset = "0x1015238", Length = "0x3A8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0041;\n\tv49 = Il2CppMethodInfo;\n\tv50 = v49 + 0x530;\n\tv51 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv78 = Il2CppMethodInfo;\n\tv79 = v78 + 0x538;\n\tv80 = \"il2cpp_codegen_initialize_runtime_metadata\"(v79, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv83 = Il2CppMethodInfo;\n\tv84 = v83 + 0x968;\n\tv85 = \"il2cpp_codegen_initialize_runtime_metadata\"(v84, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv251 = Il2CppMethodInfo;\n\tv252 = v251 + 0x970;\n\tv253 = \"il2cpp_codegen_initialize_runtime_metadata\"(v252, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv352 = Il2CppMethodInfo;\n\tv353 = v352 + 0x978;\n\tv354 = \"il2cpp_codegen_initialize_runtime_metadata\"(v353, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv401 = Il2CppMethodInfo;\n\tv402 = v401 + 0x998;\n\tv403 = \"il2cpp_codegen_initialize_runtime_metadata\"(v402, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv465 = Il2CppMethodInfo;\n\tv466 = v465 + 0xC28;\n\tv467 = \"il2cpp_codegen_initialize_runtime_metadata\"(v466, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv481 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv482 = v481 + 0x8C8;\n\tv483 = \"il2cpp_codegen_initialize_runtime_metadata\"(v482, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv510 = \"Writing object reference to Id '{0}' for {1}.\";\n\tv511 = v510 + 0x8E0;\n\tv68 = \"il2cpp_codegen_initialize_runtime_metadata\"(v511, methodInfo, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62, v63, v64, v65, v66);\n\tv70 = 1;\n\t*([302AA85]) = v70;\nL_0041:\n\tSpecialFluid::OnPreComputeUpdate(this);\n\tv88 = Il2CppMethodInfo;\n\tv90 = Il2CppMethodInfo;\n\tv92 = Il2CppMethodInfo;\n\tv94 = Il2CppMethodInfo;\n\tv449 = \"Writing object reference to Id '{0}' for {1}.\" + 0x8E0;\n\tv448 = \"Writing object reference to Id '{0}' for {1}.\" + 0x8C8;\n\tv100 = Il2CppMethodInfo;\n\tv447 = Il2CppMethodInfo + 0x968;\n\tv107 = System.Collections.Generic.HashSet`1<System.Int32>::GetEnumerator(this.particleIds);\nL_0067:\n\tv400 = System.Collections.Generic.HashSet`1+Enumerator::MoveNext /* +1 sharing this address */(&v106 @ stack_-E8_v7 (System.Single), *([v88 @ X24_v6 (Il2CppMethodInfo)+970]));\n\tv404 = v400 & 1;\n\tv405 = v404 == 0;\n\tif (v405) goto L_00BD;\n\tv460 = this.solver == 0;\n\tif (v460) goto L_0109;\n\tv484 = this.solver + 0x1F8;\n\tv433 = *([v90 @ X25_v6 (Il2CppMethodInfo)+C28]);\n\tv392 = Unity.Collections.NativeHashMap`2::TryGetValue /* +1 sharing this address */(v484, v257, &v313 @ stack_-C4_v7, *([v90 @ X25_v6 (Il2CppMethodInfo)+C28]));\n\tv512 = v392 & 1;\n\tv394 = v512 == 0;\n\tif (v394) goto L_0067;\n\tv463 = this.solver;\n\tv309 = v313 << 3;\n\tv348 = v463.positions + v309;\n\t// 129 MakeStruct v305 @ AGG10153D8_0_v6 (Unity.Mathematics.float2), typeof(Unity.Mathematics.float2), [v348 @ X8_v18], [v348 @ X8_v18+4]\n\tv442 = Unity.Mathematics.float2::op_Implicit(v305);\n\tv461 = this.prevOffset == 0;\n\tif (v461) goto L_010E;\n\tv605 = System.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Vector2>::TryGetValue(this.prevOffset, v257, &v299 @ stack_-D0_v7 (UnityEngine.Vector2));\n\tv330 = v442 - this.position;\n\tv307 = v442.y - this.position.y;\n\tv291 = v605 == 0;\n\tv610 = ~v291;\n\tv611 = ~v610;\n\tif (v611) goto L_FFFFFFFF;\n\tgoto L_00A1;\nL_00A1:\n\tv277 = ~v291;\n\tv275 = ~v277;\n\tif (v275) goto L_FFFFFFFF;\n\tgoto L_00A8;\nL_00A8:\n\tv618 = v330 * v330;\n\tv619 = v307 * v307;\n\tv269 = v618 + v619;\n\tv620 = v269 * v617;\n\tv267 = v330 * v620;\n\tv319 = v434 + v267;\n\tv621 = v307 * v620;\n\tv321 = v435 + v621;\n\tv622 = v269 * v614;\n\tv281 = v330 * v622;\n\tv323 = v436 + v281;\n\tv279 = v307 * v622;\n\tv325 = v437 + v279;\n\tv346 = this.prevOffset == 0;\n\tif (v346) goto L_010C;\n\tv185 = *([v94 @ X27_v6 (Il2CppMethodInfo)+538]);\n\t// 186 MakeStruct v357 @ AGG1015458_2_v6 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v330 @ V0_v16 (System.Single), v307 @ V1_v13 (System.Single)\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Vector2>::set_Item(this.prevOffset, v257, v357);\n\tgoto L_0067;\nL_00BD:\n\tv502 = *([v100 @ X23_v6 (Il2CppMethodInfo)+968]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(&v106 @ stack_-E8_v7 (System.Single), *([v100 @ X23_v6 (Il2CppMethodInfo)+968]));\nL_00C0:\n\tv496 = v435 - v436;\n\tv497 = v437 + v434;\n\tv498 = 0x274A290(v490, v502, v185, v190, v55, v56, v57, v58, v496, v497, v413, v414, v407, v406, v65, v66);\n\tv514 = v496 - this.filteredDelta;\n\tv516 = v514 * 0x3F59999A;\n\tv517 = this.filteredDelta + v516;\n\tthis.filteredDelta = v517;\n\tv207 = this.zRotation + v517;\n\tthis.zRotation = v207;\n\tv518 = 0x274A170(v498, v502, v185, v190, v55, v56, v57, v58, v207, this.zRotation, 0x3F59999A, v414, v407, v406, v65, v66);\n\tUnityEngine.Renderer::GetPropertyBlock(this.mr, this._propBlock);\n\t// 224 MakeStruct v119 @ AGG10154E0_2_v5 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), this.position (UnityEngine.Vector2), this.position.y (System.Single), 0, 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v449 @ X22_v1]), v119);\n\t// 235 MakeStruct v115 @ AGG1015504_2_v5 (UnityEngine.Vector4), typeof(UnityEngine.Vector4), v207 @ V0_v9 (System.Single), this.zRotation (System.Single), 0, 0\n\tUnityEngine.MaterialPropertyBlock::SetVector(this._propBlock, *([v448 @ X21_v1]), v115);\n\tUnityEngine.Renderer::SetPropertyBlock(this.mr, this._propBlock);\n\treturn;\nL_0109:\n\tv456 = new System.NullReferenceException();\n\tgoto L_0111;\n\tv250 = new System.NullReferenceException();\nL_010C:\n\tv454 = new System.NullReferenceException();\n\tgoto L_0111;\nL_010E:\n\tv457 = new System.NullReferenceException();\n\tgoto L_0111;\n\tv455 = new System.NullReferenceException();\nL_0111:\n\t// 273 Interrupt\n\tgoto L_0124;\n\tgoto L_0124;\n\tgoto L_0124;\n\tgoto L_0124;\n\tgoto L_0124;\n\tgoto L_0124;\n\tgoto L_0124;\n\tgoto L_0124;\nL_0124:\n\tv480 = v502 != 1;\n\tif (v480) goto L_0134;\n\tv500 = 0x274A080(v454, v502, v432, v433, v55, v56, v57, v58, v441, v427, v413, v414, v407, v406, v65, v66);\n\tv519 = 0x274A098(v500, v502, v432, v433, v55, v56, v57, v58, v441, v427, v413, v414, v407, v406, v65, v66);\n\tv502 = *([v447 @ X23_v1]);\n\tSystem.Collections.Generic.HashSet`1+Enumerator::Dispose /* +1 sharing this address */(v438, *([v447 @ X23_v1]));\n\tv493 = *([v500 @ X0_v12]) == 0;\n\tif (v493) goto L_00C0;\n\tv504 = new System.OutOfMemoryException();\nL_0134:\n\tv509 = 0xBF092C(&v501 @ stack_-E8_v2 (System.Int32), v502, v432, v433, v55, v56, v57, v58, v441, v427, v413, v414, v407, v406, v65, v66);\n\tv521 = 0x27498DC(v506, v502, v432, v433, v55, v56, v57, v58, v441, v427, v413, v414, v407, v406, v65, v66);\n\tv522 = 0xD6F8(v521, v502, v432, v433, v55, v56, v57, v58, v441, v427, v413, v414, v407, v406, v65, v66);\n\treturn;\n// 174 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		base.OnPreComputeUpdate();
		float crossSum = 0f;
		foreach (int particleId in particleIds)
		{
			if (solver == null || !solver.idToIndex.TryGetValue(particleId, out int solverIndex))
			{
				continue;
			}
			global::Unity.Mathematics.float2 solverPos = solver.positions[solverIndex];
			float offsetX = solverPos.x - position.x;
			float offsetY = solverPos.y - position.y;
			if (prevOffset.TryGetValue(particleId, out var prevOff))
			{
				crossSum += prevOff.x * offsetY - prevOff.y * offsetX;
			}
			prevOffset[particleId] = new global::UnityEngine.Vector2(offsetX, offsetY);
		}
		float delta = crossSum - filteredDelta;
		filteredDelta += delta * 0.85f;
		zRotation += filteredDelta;
		mr.GetPropertyBlock(_propBlock);
		_propBlock.SetVector("_Position", new global::UnityEngine.Vector4(position.x, position.y, 0f, 0f));
		_propBlock.SetVector("_Rotation", new global::UnityEngine.Vector4(zRotation, filteredDelta, 0f, 0f));
		mr.SetPropertyBlock(_propBlock);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600039E")]
	[global::Cpp2ILInjected.Address(RVA = "0x10155E0", Offset = "0x10155E0", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x528;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv50 = v49 + 0x4F0;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA86]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+4F0])();\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Vector2>::.ctor(v48);\n\tv54 = this + 0xB8;\n\tthis.prevOffset = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tSpecialFluid::.ctor(this);\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public RotatingSpecialFluid()
	{
		prevOffset = new global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector2>();
	}
}
