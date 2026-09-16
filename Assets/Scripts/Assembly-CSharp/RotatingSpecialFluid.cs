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
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_0037: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Expected O, but got Unknown
		//IL_004e: Expected O, but got I
		//IL_0315: Expected O, but got F4
		//IL_0495: Expected O, but got F4
		//IL_049d: Expected O, but got F4
		//IL_00be: Expected O, but got I
		//IL_00ce: Expected O, but got I
		//IL_010e: Expected O, but got I
		//IL_0147: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_015b: Expected F4, but got O
		//IL_0170: Expected F4, but got I
		//IL_05cf: Expected I4, but got O
		//IL_0563: Expected O, but got F4
		//IL_061f: Expected I4, but got O
		//IL_024c: Expected O, but got F4
		//IL_04d4: Expected O, but got F4
		//IL_04dc: Expected O, but got F4
		//IL_0261: Expected O, but got I
		//IL_02c6: Expected O, but got I
		base.OnPreComputeUpdate();
		nint num = 0;
		nint num2 = 0;
		nint num3 = 0;
		nint num4 = 0;
		object obj = "Writing object reference to Id '{0}' for {1}." + 2272;
		object obj2 = "Writing object reference to Id '{0}' for {1}." + 2248;
		nint num5 = 0;
		object obj3 = (nint)0 + (nint)2408;
		global::System.Collections.Generic.HashSet<int>.Enumerator enumerator = particleIds.GetEnumerator();
		float num6 = 0f;
		float num7 = 0f;
		float num8 = 0f;
		float num9 = 0f;
		float num11 = default(float);
		float num10 = num11;
		object obj4 = default(object);
		object obj6 = default(object);
		object obj7 = default(object);
		object obj9 = default(object);
		global::Unity.Mathematics.float2 float5 = default(global::Unity.Mathematics.float2);
		int num14 = default(int);
		float num18 = default(float);
		global::UnityEngine.Vector2 value2 = default(global::UnityEngine.Vector2);
		object obj13 = default(object);
		object obj14 = default(object);
		global::System.NullReferenceException ex = default(global::System.NullReferenceException);
		float num39 = default(float);
		float num40 = default(float);
		float num41 = default(float);
		float num42 = default(float);
		float num43 = default(float);
		object obj15 = default(object);
		float num44 = default(float);
		float num45 = default(float);
		float num46 = default(float);
		float num47 = default(float);
		float num48 = default(float);
		object obj16 = default(object);
		object obj17 = default(object);
		object obj18 = default(object);
		global::System.NullReferenceException ex2 = default(global::System.NullReferenceException);
		object obj19 = default(object);
		int num38 = default(int);
		global::UnityEngine.Vector4 value3 = default(global::UnityEngine.Vector4);
		global::UnityEngine.Vector4 value4 = default(global::UnityEngine.Vector4);
		while (true)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C8 (System.Collections.Generic.HashSet`1+Enumerator::MoveNext, and 1 more at this address)");
			if ((int)((nint)obj4 & 1) != 0)
			{
				object obj8;
				object obj10;
				if ((object)solver != null)
				{
					object obj5 = (nint)solver + 504;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X25_v6 (Il2CppMethodInfo)+C28]");
					obj6 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @17E754C (Unity.Collections.NativeHashMap`2::TryGetValue, and 1 more at this address)");
					int num12 = (int)((nint)obj7 & 1);
					bool flag = num12 == 0;
					obj8 = obj9;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v90 @ X25_v6 (Il2CppMethodInfo)+C28]");
					obj10 = 0;
					if (flag)
					{
						continue;
					}
					FluidSolver fluidSolver = solver;
					int num13 = (int)((nint)obj9 << 3);
					object obj11 = fluidSolver.positions + num13;
					float5.x = (float)obj11;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v348 @ X8_v18+4]");
					float5.y = 0f;
					global::UnityEngine.Vector2 vector = float5;
					if (prevOffset != null)
					{
						bool flag2 = prevOffset.TryGetValue(num14, out var value);
						float num15 = vector.x - position.x;
						float num16 = vector.y - position.y;
						bool flag3 = !flag2;
						float num17 = (flag3 ? num16 : num18);
						object obj12 = (flag3 ? ((object)num15) : value);
						float num19 = num15 * num15;
						float num20 = num16 * num16;
						float num21 = num19 + num20;
						float num22 = num21 * (float)obj12;
						float num23 = num15 * num22;
						float num24 = num6 + num23;
						float num25 = num16 * num22;
						float num26 = num7 + num25;
						float num27 = num21 * num17;
						float num28 = num15 * num27;
						float num29 = num8 + num28;
						float num30 = num16 * num27;
						float num31 = num9 + num30;
						if (prevOffset != null)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v94 @ X27_v6 (Il2CppMethodInfo)+538]");
							obj8 = 0;
							value2.x = num15;
							value2.y = num16;
							prevOffset[num14] = value2;
							float num32 = num23;
							float num33 = num21;
							float num34 = num30;
							float num35 = num28;
							float num36 = num16;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v92 @ X26_v6 (Il2CppMethodInfo)+530]");
							obj10 = 0;
							num6 = num24;
							num7 = num26;
							num8 = num29;
							num9 = num31;
							num10 = num15;
							continue;
						}
						ex = new global::System.NullReferenceException();
						obj13 = obj8;
						obj6 = obj10;
						obj14 = num11;
						global::UnityEngine.Vector2 vector2 = (global::UnityEngine.Vector2)num10;
						int num37 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v88 @ X24_v6 (Il2CppMethodInfo)+970]");
						num38 = 0;
						ex = ex2;
					}
					else
					{
						global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
						float num32 = num39;
						float num33 = num40;
						float num34 = num41;
						float num35 = num42;
						float num36 = num43;
						obj6 = obj15;
						num6 = num44;
						num7 = num45;
						num8 = num46;
						num9 = num47;
						global::UnityEngine.Vector2 vector2 = (global::UnityEngine.Vector2)num48;
						obj3 = obj16;
						obj2 = obj17;
						obj = obj18;
					}
				}
				else
				{
					ex2 = new global::System.NullReferenceException();
					obj13 = obj9;
					obj14 = num11;
					global::UnityEngine.Vector2 vector2 = (global::UnityEngine.Vector2)num10;
					int num37 = 0;
					num38 = num14;
				}
				bool flag4 = num38 != 1;
				global::System.NullReferenceException ex4 = ex;
				if (flag4)
				{
					break;
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
				num38 = (int)obj3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				bool flag5 = obj19 == null;
				obj8 = obj13;
				obj10 = obj6;
				object obj20 = obj14;
				if (!flag5)
				{
					global::System.OutOfMemoryException ex5 = new global::System.OutOfMemoryException();
					int num37 = (int)obj19;
					ex4 = (global::System.NullReferenceException)(object)ex5;
					break;
				}
			}
			else
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v100 @ X23_v6 (Il2CppMethodInfo)+968]");
				num38 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @14993C4 (System.Collections.Generic.HashSet`1+Enumerator::Dispose, and 1 more at this address)");
				object obj20 = num11;
			}
			float num49 = num7 - num8;
			float num50 = num9 + num6;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A290");
			float num51 = num49 - filteredDelta;
			float num52 = num51 * 0.85f;
			float num53 = (filteredDelta += num52);
			float x = (zRotation += num53);
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A170");
			mr.GetPropertyBlock(_propBlock);
			value3.x = position.x;
			value3.y = position.y;
			value3.z = 0f;
			value3.w = 0f;
			_propBlock.SetVector((string)obj, value3);
			value4.x = x;
			value4.y = zRotation;
			value4.z = 0f;
			value4.w = 0f;
			_propBlock.SetVector((string)obj2, value4);
			mr.SetPropertyBlock(_propBlock);
			return;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF092C");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x600039E")]
	[global::Cpp2ILInjected.Address(RVA = "0x10155E0", Offset = "0x10155E0", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x528;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>;\n\tv50 = v49 + 0x4F0;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302AA86]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Linq.Expressions.Interpreter.CastInstruction+CastInstructionT`1<System.Char>>)+4F0])();\n\tSystem.Collections.Generic.Dictionary`2<System.Int32, UnityEngine.Vector2>::.ctor(v48);\n\tv54 = this + 0xB8;\n\tthis.prevOffset = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tSpecialFluid::.ctor(this);\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public RotatingSpecialFluid()
	{
		//IL_000e: Expected I, but got O
		//IL_0031: Expected O, but got I
		nint num = (nint)typeof(global::System.Linq.Expressions.Interpreter.CastInstruction.CastInstructionT<char>);
		global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector2> dictionary = new global::System.Collections.Generic.Dictionary<int, global::UnityEngine.Vector2>();
		object obj = (nint)this + 184;
		prevOffset = dictionary;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		base._002Ector();
	}
}
