[global::Cpp2ILInjected.Token(Token = "0x2000066")]
public class SpriteCollectDisplay : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40001AA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::System.Collections.Generic.List<CollectSprite> sprites;

	[global::Cpp2ILInjected.Token(Token = "0x40001AB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float damping;

	[global::Cpp2ILInjected.Token(Token = "0x40001AC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float maxStartSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x40001AD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float collectForce;

	[global::Cpp2ILInjected.Token(Token = "0x40001AE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float minApplyForceDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40001AF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float maxApplyForceDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40001B0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float scaleUpDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40001B1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float spriteScale;

	[global::Cpp2ILInjected.Token(Token = "0x40001B2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public CollectSprite spritePrefab;

	[global::Cpp2ILInjected.Token(Token = "0x600020E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF5664", Offset = "0xFF5664", Length = "0x270")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0023;\n\tv45 = Il2CppMethodInfo;\n\tv46 = v45 + 0xA38;\n\tv47 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv69 = Il2CppMethodInfo;\n\tv70 = v69 + 0xA40;\n\tv64 = \"il2cpp_codegen_initialize_runtime_metadata\"(v70, methodInfo, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58, v59, v60, v61, v62);\n\tv66 = 1;\n\t*([302A9D2]) = v66;\nL_0023:\n\tv67 = this.sprites;\n\tv180 = v67._size;\n\tv75 = v67._size < 1;\n\tif (v75) goto L_010E;\n\tv183 = Il2CppMethodInfo;\n\tv184 = System.Xml.ValidateNames;\n\tgoto L_004F;\nL_004A:\n\tv212 = v180 <= 0;\n\tif (v212) goto L_010E;\nL_004F:\n\tv180 = v180 - 1;\n\tv303 = System.Collections.Generic.List`1<CollectSprite>::get_Item(this.sprites, v180);\n\tv105 = UnityEngine.Time::get_time();\n\tv303.prevPos = v303.pos;\n\tv159 = v105 < v303.startTime;\n\tif (v159) goto L_004A;\n\tgoto L_006C;\n\tv346 = v131;\n\tv347 = \"il2cpp_codegen_initialize_runtime_metadata\"(v346, v111, v114, v50, v51, v52, v53, v54, v105, v102, v96, v58, v59, v60, v61, v62);\n\t*([2DD4424]) = v129;\nL_006C:\n\tv178 = v303.getTargetPos;\n\tv178.invoke_impl(v349, v178.method_code, v178.method, *([v183 @ X24_v4 (Il2CppMethodInfo)+A40]), v50, v51, v52, v53, v54, v105, v303.startTime, v303.startPos, v58, v59, v60, v61, v62);\n\tv303.targetPos = v105;\n\tv303.targetPos.y = v303.startTime;\n\tv351 = UnityEngine.Time::get_time();\n\tv354 = v351 - v303.startTime;\n\tv355 = v354 / v303.applyForceDuration;\n\tv358 = v355 - 1f;\n\tv359 = v358 < 0;\n\tv360 = v358 == 0;\n\tv361 = v355 ^ 1f;\n\tv362 = v355 ^ v358;\n\tv363 = v361 & v362;\n\tv364 = v363 < 0;\n\tv365 = v359 == v364;\n\tv314 = ~v360;\n\tv366 = v365 & v314;\n\tv367 = ~v366;\n\tif (v367) goto L_0096;\n\tgoto L_0096;\nL_0096:\n\tv313 = v355 >= 0;\n\tif (v313) goto L_00A0;\n\tgoto L_00A0;\nL_00A0:\n\tv385 = *([2DD4421]) == 0;\n\tif (v385) goto L_00F3;\n\tgoto L_00A6;\nL_00A6:\n\tv400 = v303.targetPos - v303.pos;\n\tv401 = v400 * v400;\n\t// 168 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv402 = UnityEngine.Mathf::Sqrt(v401);\n\tv417 = v402 <= 0x3727C5AC;\n\tif (v417) goto L_00BE;\n\t// 184 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv422 = v400 / v402;\n\tgoto L_00C6;\nL_00BE:\n\tgoto L_00C2;\n\tv433 = v131;\n\tv434 = \"il2cpp_codegen_initialize_runtime_metadata\"(v433, v319, v114, v50, v51, v52, v53, v54, v400, v402, v405, v58, v59, v60, v61, v62);\n\t*([2DD4424]) = v129;\nL_00C2:\n\tv435 = *([v184 @ X21_v4 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv426 = *([v435 @ X8_v16+B8]);\n\tv422 = *([v426 @ X8_v17]);\nL_00C6:\n\tv428 = v422 * v429;\n\tv432 = UnityEngine.Time::get_fixedDeltaTime();\n\tv436 = v428 * v437;\n\tv438 = v303.vel + v436;\n\tv303.vel = v438;\n\tv440 = v438 * v437;\n\tv442 = UnityEngine.Time::get_fixedDeltaTime();\n\tv443 = v440 * v437;\n\tv312 = v438 - v443;\n\tv303.vel = v312;\n\tv444 = UnityEngine.Time::get_fixedDeltaTime();\n\tv445 = v312 * v437;\n\tv446 = v303.pos + v445;\n\tv303.pos = v446;\n\tv448 = v446 - v303.targetPos;\n\tv317 = v303.targetPos - v303.startPos;\n\tv318 = v448 * v317;\n\t// 223 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv322 = v318 <= 0;\n\tif (v322) goto L_004A;\n\tSpriteCollectDisplay::RemoveSprite(this, v303);\n\tgoto L_004A;\nL_00F3:\n\t*([2DD4421]) = 1;\n\tgoto L_00A6;\n\tv393 = \"il2cpp_codegen_runtime_class_init\"(v403, v319, v114, v50, v51, v52, v53, v54, v355, v370, v353, v58, v59, v60, v61, v62);\n\tgoto L_00A6;\nL_010E:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 174 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void FixedUpdate()
	{
		//IL_0048: Expected I, but got O
		//IL_00ed: Expected O, but got F4
		//IL_0175: Expected O, but got F4
		//IL_0182: Expected O, but got F4
		//IL_0459: Expected O, but got I
		//IL_0469: Expected O, but got I
		//IL_0471: Expected F4, but got O
		//IL_03f8: Expected O, but got F4
		//IL_043b: Expected O, but got F4
		//IL_02b1: Expected O, but got F4
		global::System.Collections.Generic.List<CollectSprite> list = sprites;
		int num = list.Count;
		if (list.Count < 1)
		{
			return;
		}
		nint num2 = 0;
		object obj5 = default(object);
		object obj6 = default(object);
		do
		{
			num--;
			CollectSprite collectSprite = sprites[num];
			float time = global::UnityEngine.Time.time;
			collectSprite.prevPos = collectSprite.pos;
			if (!(time < collectSprite.startTime))
			{
				global::System.Func<global::UnityEngine.Vector2> getTargetPos = collectSprite.getTargetPos;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v178.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
				collectSprite.targetPos = (global::UnityEngine.Vector2)time;
				collectSprite.targetPos.y = collectSprite.startTime;
				float time2 = global::UnityEngine.Time.time;
				float num4 = time2 - collectSprite.startTime;
				float num5 = num4 / collectSprite.applyForceDuration;
				float num6 = num5 - 1f;
				bool flag = num6 < 0f;
				bool flag2 = num6 == 0f;
				object obj = num5 ^ 1f;
				object obj2 = num5 ^ num6;
				int num7 = (int)((nint)obj & (nint)obj2);
				bool flag3 = num7 < 0;
				bool flag4 = flag == flag3;
				bool flag5 = !flag2;
				if (flag4 && flag5)
				{
				}
				if (num5 < 0f)
				{
				}
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4421]");
				if ((nint)0 == 0)
				{
					_ = 1;
				}
				float num8 = collectSprite.targetPos.x - collectSprite.pos.x;
				float f = num8 * num8;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				float num9 = global::UnityEngine.Mathf.Sqrt(f);
				float num10;
				if (num9 > 1E-05f)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
					num10 = num8 / num9;
				}
				else
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v184 @ X21_v4 (Il2CppClass<System.Xml.ValidateNames>)+98]");
					object obj3 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v435 @ X8_v16+B8]");
					object obj4 = 0;
					num10 = (float)obj4;
				}
				float num11 = num10 * (float)obj5;
				float fixedDeltaTime = global::UnityEngine.Time.fixedDeltaTime;
				float num12 = num11 * (float)obj6;
				float num13 = collectSprite.vel.x + num12;
				collectSprite.vel = (global::UnityEngine.Vector2)num13;
				float num14 = num13 * (float)obj6;
				float fixedDeltaTime2 = global::UnityEngine.Time.fixedDeltaTime;
				float num15 = num14 * (float)obj6;
				float num16 = num13 - num15;
				collectSprite.vel = (global::UnityEngine.Vector2)num16;
				float fixedDeltaTime3 = global::UnityEngine.Time.fixedDeltaTime;
				float num17 = num16 * (float)obj6;
				float num18 = collectSprite.pos.x + num17;
				collectSprite.pos = (global::UnityEngine.Vector2)num18;
				float num19 = num18 - collectSprite.targetPos.x;
				float num20 = collectSprite.targetPos.x - collectSprite.startPos.x;
				float num21 = num19 * num20;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
				if (num21 > 0f)
				{
					RemoveSprite(collectSprite);
				}
			}
		}
		while (num > 0);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600020F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF59AC", Offset = "0xFF59AC", Length = "0x3CC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002B;\n\tv41 = Il2CppMethodInfo;\n\tv42 = v41 + 0x698;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv68 = Il2CppMethodInfo;\n\tv69 = v68 + 0x6A0;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv74 = Il2CppMethodInfo;\n\tv75 = v74 + 0x6A8;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv80 = Il2CppMethodInfo;\n\tv81 = v80 + 0xA28;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv62 = 1;\n\t*([302A9D3]) = v62;\nL_002B:\n\tv67 = UnityEngine.Time::get_time();\n\tv73 = UnityEngine.Time::get_fixedTime();\n\tv180 = UnityEngine.Time::get_fixedDeltaTime();\n\tv83 = this.sprites == 0;\n\tif (v83) goto L_0142;\n\tv86 = Il2CppMethodInfo;\n\tv176 = Il2CppMethodInfo + 0x698;\n\tv308 = v67 - v73;\n\tv92 = v308 / v180;\n\tv95 = System.Collections.Generic.List`1<CollectSprite>::GetEnumerator(this.sprites);\n\tv199 = v92 - 1f;\n\tv200 = v199 < 0;\n\tv201 = v199 == 0;\n\tv202 = v92 ^ 1f;\n\tv203 = v92 ^ v199;\n\tv204 = v202 & v203;\n\tv205 = v204 < 0;\n\tv206 = v200 == v205;\n\tv207 = ~v201;\n\tv208 = v206 & v207;\n\tv209 = ~v208;\n\tif (v209) goto L_0064;\n\tgoto L_0064;\nL_0064:\n\tv233 = v92 >= 0;\n\tif (v233) goto L_006C;\n\tgoto L_006C;\nL_006C:\n\tv255 = System.Xml.ValidateNames;\nL_0070:\n\tv238 = *([v86 @ X23_v4 (Il2CppMethodInfo)+6A0]);\n\tv331 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v94 @ stack_-B8_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv333 = v331 == 0;\n\tif (v333) goto L_0121;\n\tv180 = UnityEngine.Time::get_time();\n\tv441 = v195 == 0;\n\tif (v441) goto L_0134;\n\tv175 = *([v195 @ stack_-A8 (UnityEngine.Component)+40]);\n\tv279 = v180 >= *([v195 @ stack_-A8 (UnityEngine.Component)+40]);\n\tif (v279) goto L_00B9;\n\tv447 = UnityEngine.Component::get_transform(this);\n\tv451 = v447 == 0;\n\tif (v451) goto L_013A;\n\tv467 = UnityEngine.Transform::get_position(v447);\n\tv483 = UnityEngine.Component::get_transform(v195);\n\tv476 = v483 == 0;\n\tif (v476) goto L_013C;\n\t// 156 MakeStruct v264 @ AGGFF5B2C_1_v5 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v195 @ stack_-A8 (UnityEngine.Component)+28], [v195 @ stack_-A8 (UnityEngine.Component)+2C], v467.z (System.Single)\n\tUnityEngine.Transform::set_position(v483, v264);\n\tv496 = UnityEngine.Component::get_transform(v195);\n\tgoto L_00A9;\n\tv518 = v191;\n\tv519 = \"il2cpp_codegen_initialize_runtime_metadata\"(v518, v457, v45, v46, v47, v48, v49, v50, v465, v461, v453, v111, v55, v56, v57, v58);\n\t*([2DD4419]) = v102;\nL_00A9:\n\tv324 = v496 == 0;\n\tif (v324) goto L_0136;\n\tv523 = *([v255 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv327 = *([v523 @ X8_v16+B8]);\n\tv308 = *([v327 @ X8_v17+4]);\n\tv124 = *([v327 @ X8_v17+8]);\n\t// 178 MakeStruct v262 @ AGGFF5B70_1_v4 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v327 @ X8_v17], [v327 @ X8_v17+4], [v327 @ X8_v17+8]\n\tUnityEngine.Transform::set_localScale(v496, v262);\n\tgoto L_0070;\nL_00B9:\n\tv450 = UnityEngine.Component::get_transform(this);\n\tv468 = UnityEngine.Transform::get_position(v450);\n\tv485 = UnityEngine.Component::get_transform(v195);\n\tv477 = v485 == 0;\n\tif (v477) goto L_013E;\n\tv487 = *([v195 @ stack_-A8 (UnityEngine.Component)+28]) - *([v195 @ stack_-A8 (UnityEngine.Component)+30]);\n\tv489 = v487 * v490;\n\tv491 = *([v195 @ stack_-A8 (UnityEngine.Component)+30]) + v489;\n\t// 205 MakeStruct v261 @ AGGFF5BC4_1_v5 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v491 @ V0_v15, v493 @ V0.S1, v468.z (System.Single)\n\tUnityEngine.Transform::set_position(v485, v261);\n\tv498 = UnityEngine.Time::get_time();\n\tv502 = v498 - *([v195 @ stack_-A8 (UnityEngine.Component)+40]);\n\tv319 = this.spriteScale;\n\tv505 = v502 / this.scaleUpDuration;\n\tv508 = v505 - 1f;\n\tv509 = v508 < 0;\n\tv510 = v508 == 0;\n\tv511 = v505 ^ 1f;\n\tv512 = v505 ^ v508;\n\tv513 = v511 & v512;\n\tv514 = v513 < 0;\n\tv515 = v509 == v514;\n\tv277 = ~v510;\n\tv516 = v515 & v277;\n\tv517 = ~v516;\n\tif (v517) goto L_FFFFFFFF;\n\tgoto L_00F1;\nL_00F1:\n\tv275 = v505 >= 0;\n\tif (v275) goto L_FFFFFFFF;\n\tgoto L_0100;\nL_0100:\n\tv280 = v466 >= 1f;\n\tif (v280) goto L_0107;\n\tv466 = EasingFunction::EaseOutElastic(v466);\n\tv319 = v319 * v466;\nL_0107:\n\tv542 = UnityEngine.Component::get_transform(v195);\n\tgoto L_0110;\n\tv545 = v191;\n\tv546 = \"il2cpp_codegen_initialize_runtime_metadata\"(v545, v458, v45, v46, v47, v48, v49, v50, v466, v462, v454, v111, v55, v56, v57, v58);\n\t*([2DD441A]) = v102;\nL_0110:\n\tv325 = v542 == 0;\n\tif (v325) goto L_0138;\n\tv548 = *([v255 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv328 = *([v548 @ X8_v13+B8]);\n\tv124 = v319 * *([v328 @ X8_v14+14]);\n\tv308 = v319 * *([v328 @ X8_v14+10]);\n\tv316 = v319 * *([v328 @ X8_v14+C]);\n\t// 284 MakeStruct v258 @ AGGFF5C50_1_v4 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v316 @ V0_v23 (System.Single), v308 @ V1_v4 (System.Single), v124 @ V2_v4 (System.Single)\n\tUnityEngine.Transform::set_localScale(v542, v258);\n\tgoto L_0070;\nL_0121:\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v94 @ stack_-B8_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\nL_0133:\n\treturn;\nL_0134:\n\tv444 = new System.NullReferenceException();\n\tgoto L_0141;\nL_0136:\n\tv471 = new System.NullReferenceException();\n\tgoto L_0141;\nL_0138:\n\tv472 = new System.NullReferenceException();\n\tgoto L_0141;\nL_013A:\n\tv473 = new System.NullReferenceException();\n\tgoto L_0141;\nL_013C:\n\tv474 = new System.NullReferenceException();\n\tgoto L_0141;\nL_013E:\n\tv475 = new System.NullReferenceException();\n\tgoto L_0141;\n\tv470 = new System.NullReferenceException();\nL_0141:\n\t// 321 Interrupt\nL_0142:\n\tv192 = new System.NullReferenceException();\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\nL_0165:\n\tv222 = v238 != 1;\n\tif (v222) goto L_0175;\n\tv235 = 0x274A080(v192, v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\tv251 = 0x274A098(v235, v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\tv238 = *([v176 @ X22_v1]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v94 @ stack_-B8_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv243 = *([v235 @ X0_v15]) == 0;\n\tif (v243) goto L_0133;\n\tv241 = new System.OutOfMemoryException();\nL_0175:\n\tv247 = 0xBF0AE4(&v171 @ stack_-B8 (System.Int32), v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\tv253 = 0x27498DC(v244, v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\tv257 = 0xD6F8(v253, v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\treturn;\n// 200 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Update()
	{
		//IL_0038: Expected O, but got I
		//IL_00a5: Expected O, but got F4
		//IL_00b2: Expected O, but got F4
		//IL_075a: Expected I, but got O
		//IL_06b7: Expected I, but got O
		//IL_06ee: Expected I4, but got O
		//IL_0587: Expected I, but got O
		//IL_014f: Expected F4, but got I
		//IL_05fd: Expected I, but got O
		//IL_0640: Expected I, but got O
		//IL_032d: Expected O, but got I
		//IL_033c: Expected O, but got I
		//IL_0352: Expected O, but got I
		//IL_035f: Expected F4, but got O
		//IL_036c: Expected F4, but got O
		//IL_040b: Expected O, but got F4
		//IL_0418: Expected O, but got F4
		//IL_0620: Expected I, but got O
		//IL_01f0: Expected F4, but got I
		//IL_0205: Expected F4, but got I
		//IL_024b: Expected O, but got I
		//IL_025b: Expected O, but got I
		//IL_026b: Expected F4, but got I
		//IL_027b: Expected F4, but got I
		//IL_0288: Expected F4, but got O
		//IL_029d: Expected F4, but got I
		//IL_02b2: Expected F4, but got I
		//IL_05bd: Expected I, but got O
		//IL_05cd: Expected F4, but got I
		//IL_05dd: Expected F4, but got I
		//IL_04dc: Expected O, but got I
		//IL_04ec: Expected O, but got I
		float time = global::UnityEngine.Time.time;
		float fixedTime = global::UnityEngine.Time.fixedTime;
		float fixedDeltaTime = global::UnityEngine.Time.fixedDeltaTime;
		object obj = default(object);
		global::System.Collections.Generic.List<object>.Enumerator enumerator2 = default(global::System.Collections.Generic.List<object>.Enumerator);
		nint num7 = default(nint);
		if (sprites != null)
		{
			nint num = 0;
			obj = (nint)0 + (nint)1688;
			float num2 = time - fixedTime;
			float num3 = num2 / fixedDeltaTime;
			global::System.Collections.Generic.List<CollectSprite>.Enumerator enumerator = sprites.GetEnumerator();
			float num4 = num3 - 1f;
			bool flag = num4 < 0f;
			bool flag2 = num4 == 0f;
			object obj2 = num3 ^ 1f;
			object obj3 = num3 ^ num4;
			int num5 = (int)((nint)obj2 & (nint)obj3);
			bool flag3 = num5 < 0;
			bool flag4 = flag == flag3;
			bool flag5 = !flag2;
			if (flag4 && flag5)
			{
			}
			if (num3 < 0f)
			{
			}
			global::UnityEngine.Component component = default(global::UnityEngine.Component);
			global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector3 position2 = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector3 position3 = default(global::UnityEngine.Vector3);
			float num11 = default(float);
			float num12 = default(float);
			object obj8 = default(object);
			global::UnityEngine.Vector3 position4 = default(global::UnityEngine.Vector3);
			object obj10 = default(object);
			global::UnityEngine.Vector3 localScale2 = default(global::UnityEngine.Vector3);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v86 @ X23_v4 (Il2CppMethodInfo)+6A0]");
				num7 = 0;
				if (enumerator2.MoveNext())
				{
					fixedDeltaTime = global::UnityEngine.Time.time;
					if ((object)component != null)
					{
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+40]");
						float num8 = 0f;
						float num9 = fixedDeltaTime;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+40]");
						float num10;
						if (num9 < 0f)
						{
							global::UnityEngine.Transform transform = base.transform;
							if ((object)transform != null)
							{
								position = transform.position;
								global::UnityEngine.Transform transform2 = component.transform;
								if ((object)transform2 != null)
								{
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+28]");
									position2.x = 0f;
									global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+2C]");
									position2.y = 0f;
									position2.z = position.z;
									transform2.position = position2;
									global::UnityEngine.Transform transform3 = component.transform;
									if ((object)transform3 != null)
									{
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
										object obj4 = 0;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v523 @ X8_v16+B8]");
										object obj5 = 0;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v17+4]");
										num2 = 0f;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v17+8]");
										num10 = 0f;
										localScale.x = (float)obj5;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v17+4]");
										localScale.y = 0f;
										global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v327 @ X8_v17+8]");
										localScale.z = 0f;
										transform3.localScale = localScale;
										continue;
									}
									global::System.NullReferenceException ex = new global::System.NullReferenceException();
									num8 = num2;
									break;
								}
								global::System.NullReferenceException ex2 = new global::System.NullReferenceException();
								num7 = unchecked((nint)null);
								break;
							}
							global::System.NullReferenceException ex3 = new global::System.NullReferenceException();
							num10 = position3.z;
							num7 = unchecked((nint)null);
							num8 = num11;
							fixedDeltaTime = num12;
							break;
						}
						global::UnityEngine.Transform transform4 = base.transform;
						position3 = transform4.position;
						global::UnityEngine.Transform transform5 = component.transform;
						if ((object)transform5 != null)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+28]");
							nint num13 = 0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+30]");
							object obj6 = num13 - 0;
							object obj7 = (nint)obj6 * (nint)obj8;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+30]");
							object obj9 = 0 + (nint)obj7;
							position4.x = (float)obj9;
							position4.y = (float)obj10;
							position4.z = position3.z;
							transform5.position = position4;
							float time2 = global::UnityEngine.Time.time;
							float num14 = time2;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+40]");
							float num15 = num14 - 0f;
							float num16 = spriteScale;
							float num17 = num15 / scaleUpDuration;
							float num18 = num17 - 1f;
							bool flag6 = num18 < 0f;
							bool flag7 = num18 == 0f;
							object obj11 = num17 ^ 1f;
							object obj12 = num17 ^ num18;
							int num19 = (int)((nint)obj11 & (nint)obj12);
							bool flag8 = num19 < 0;
							bool flag9 = flag6 == flag8;
							bool flag10 = !flag7;
							num11 = ((!(flag9 && flag10)) ? num17 : 1f);
							num12 = ((!(num17 < 0f)) ? num11 : 0f);
							if (num12 < 1f)
							{
								num12 = EasingFunction.EaseOutElastic(num12);
								num16 *= num12;
							}
							global::UnityEngine.Transform transform6 = component.transform;
							if ((object)transform6 != null)
							{
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v255 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
								object obj13 = 0;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v548 @ X8_v13+B8]");
								object obj14 = 0;
								float num20 = num16;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v14+14]");
								num10 = num20 * 0f;
								float num21 = num16;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v14+10]");
								num2 = num21 * 0f;
								float num22 = num16;
								global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v328 @ X8_v14+C]");
								float x = num22 * 0f;
								localScale2.x = x;
								localScale2.y = num2;
								localScale2.z = num10;
								transform6.localScale = localScale2;
								continue;
							}
							global::System.NullReferenceException ex4 = new global::System.NullReferenceException();
							num10 = position.z;
							num7 = unchecked((nint)null);
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+2C]");
							num8 = 0f;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v195 @ stack_-A8 (UnityEngine.Component)+28]");
							fixedDeltaTime = 0f;
							break;
						}
						global::System.NullReferenceException ex5 = new global::System.NullReferenceException();
						num10 = position.z;
						num7 = unchecked((nint)null);
						num8 = position.y;
						fixedDeltaTime = position.x;
						break;
					}
					global::System.NullReferenceException ex6 = new global::System.NullReferenceException();
					num7 = unchecked((nint)null);
					break;
				}
				enumerator2.Dispose();
				return;
			}
			int num23 = 0;
		}
		global::System.NullReferenceException ex7 = new global::System.NullReferenceException();
		bool flag11 = num7 != 1;
		global::System.NullReferenceException ex8 = ex7;
		if (!flag11)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A080 (inside System.__Il2CppComDelegate::Finalize +0xF54)");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A098 (inside System.__Il2CppComDelegate::Finalize +0xF6C)");
			num7 = (nint)obj;
			enumerator2.Dispose();
			object obj15 = default(object);
			if (obj15 == null)
			{
				return;
			}
			global::System.OutOfMemoryException ex9 = new global::System.OutOfMemoryException();
			int num23 = (int)obj15;
			ex8 = (global::System.NullReferenceException)(object)ex9;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @BF0AE4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @27498DC (inside System.__Il2CppComDelegate::Finalize +0x7B0)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @D6F8");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000210")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF5D78", Offset = "0xFF5D78", Length = "0x264")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv52 = 0x302A000;\n\tv54 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv56 = *([302A9D4]) & 1;\n\tv57 = v56 == 0;\n\tif (v57) goto L_003C;\n\tv76 = Il2CppMethodInfo + 0x48;\n\tv82 = this.spritePrefab;\n\tv61 = *([v54 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv63 = *([v61 @ X0_v42+E0]) == 0;\n\tif (v63) goto L_0048;\nL_002D:\n\tv105 = UnityEngine.Object::Instantiate /* +1 sharing this address */(v82, *([v76 @ X25_v9]));\n\tv96 = v105 == 0;\n\tv97 = ~v96;\n\tif (v97) goto L_004D;\n\tgoto L_00D9;\nL_003C:\n\t*([v52 @ X22_v1+9D4]) = 1;\n\tv76 = Il2CppMethodInfo + 0x48;\n\tv82 = this.spritePrefab;\n\tv75 = *([v54 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv116 = *([v75 @ X0_v38+E0]) == 0;\n\tv79 = ~v116;\n\tif (v79) goto L_002D;\nL_0048:\n\tv105 = UnityEngine.Object::Instantiate /* +1 sharing this address */(v91, *([v88 @ X25_v6]));\nL_004D:\n\tv113 = UnityEngine.Component::get_transform(v105);\n\tgoto L_005B;\n\tv162 = System.Xml.ValidateNames;\n\tv163 = v162 + 0xD0;\n\tv164 = \"il2cpp_codegen_initialize_runtime_metadata\"(v163, v112, getTargetPos, onComplete, methodInfo, v68, v69, v70, position, v0, vel, v2, delay, v71, v72, v73);\n\tv165 = 1;\n\t*([2DD4419]) = v165;\nL_005B:\n\tv264 = System.Xml.ValidateNames;\n\tv266 = *([v264 @ X8_v6 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv151 = *([v266 @ X8_v8+B8]);\n\t// 100 MakeStruct v127 @ AGGFF5EAC_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v151 @ X8_v9], [v151 @ X8_v9+4], [v151 @ X8_v9+8]\n\tUnityEngine.Transform::set_localScale(v113, v127);\n\tCollectSprite::Init(v105, sprite);\n\t*([v105 @ X0_v3 (UnityEngine.Component)+28]) = position;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+2C]) = position.y;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+30]) = position;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+34]) = position.y;\n\tv138 = UnityEngine.Component::get_transform(v105);\n\t// 119 MakeStruct v122 @ AGGFF5EE8_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), position @ V0 (UnityEngine.Vector2), position.y (System.Single), 0\n\tUnityEngine.Transform::set_position(v138, v122);\n\t*([v105 @ X0_v3 (UnityEngine.Component)+38]) = vel;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+3C]) = vel.y;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+50]) = position;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+54]) = position.y;\n\tv277 = UnityEngine.Random::Range(this.minApplyForceDuration, this.maxApplyForceDuration);\n\t*([v105 @ X0_v3 (UnityEngine.Component)+44]) = v277;\n\tv279 = UnityEngine.Time::get_time();\n\tv130 = v279 + delay;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+40]) = v130;\n\tv281 = v105 + 0x58;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+58]) = onComplete;\n\tv283 = 0xF3F1B4(v281, onComplete, 0, onComplete, methodInfo, v68, v69, v70, v130, this.maxApplyForceDuration, 0, vel.y, delay, v71, v72, v73);\n\tv285 = v105 + 0x60;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+60]) = getTargetPos;\n\tv286 = 0xF3F1B4(v285, getTargetPos, 0, onComplete, methodInfo, v68, v69, v70, v130, this.maxApplyForceDuration, 0, vel.y, delay, v71, v72, v73);\n\tv139 = this.sprites;\n\tv290 = v139._version + 1;\n\tv139._version = v290;\n\tv119 = v139._items;\n\tv291 = v139._size < v119.Length;\n\tv200 = ~v291;\n\tif (v200) goto L_00C2;\n\tv228 = v139._size + 1;\n\tv139._size = v228;\n\tv176 = v139._size << 3;\n\tv292 = v119 + v176;\n\tv293 = v292 + 0x20;\n\t*([v293 @ X0_v20]) = v105;\n\tv219 = 0xF3F1B4(v293, v105, 0, onComplete, methodInfo, v68, v69, v70, v130, this.maxApplyForceDuration, 0, vel.y, delay, v71, v72, v73);\n\treturn;\nL_00C2:\n\t;\n\tSystem.Collections.Generic.List`1<CollectSprite>::AddWithResize(v139, v105);\n\treturn;\nL_00D9:\n\tthrow System.NullReferenceException;\n// 142 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddSprite(global::UnityEngine.Sprite sprite, global::UnityEngine.Vector2 position, global::UnityEngine.Vector2 vel, float delay, global::System.Func<global::UnityEngine.Vector2> getTargetPos = null, global::System.Action onComplete = null)
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00f0: Expected O, but got I
		//IL_010a: Expected O, but got I
		//IL_0056: Expected O, but got I
		//IL_0070: Expected O, but got I
		//IL_017b: Expected I, but got O
		//IL_018b: Expected O, but got I
		//IL_019b: Expected O, but got I
		//IL_01a8: Expected F4, but got O
		//IL_01bd: Expected F4, but got I
		//IL_01d2: Expected F4, but got I
		//IL_02c9: Expected O, but got I
		//IL_02ec: Expected O, but got I
		//IL_03ad: Expected O, but got I
		//IL_03bc: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A9D4]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			object obj2 = (nint)0 + (nint)72;
			CollectSprite collectSprite = spritePrefab;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X0_v42+E0]");
			bool flag = (nint)0 == 0;
			object obj4 = obj2;
			CollectSprite collectSprite2 = spritePrefab;
			if (!flag)
			{
				goto IL_00a7;
			}
		}
		else
		{
			_ = 1;
			object obj2 = (nint)0 + (nint)72;
			CollectSprite collectSprite = spritePrefab;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v54 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj5 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v75 @ X0_v38+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			object obj4 = obj2;
			CollectSprite collectSprite2 = spritePrefab;
			if (flag3)
			{
				goto IL_00a7;
			}
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1171058 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		goto IL_015b;
		IL_015b:
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		global::UnityEngine.Transform transform = component.transform;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v264 @ X8_v6 (Il2CppClass<System.Xml.ValidateNames>)+D0]");
		object obj6 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v266 @ X8_v8+B8]");
		object obj7 = 0;
		global::UnityEngine.Vector3 localScale = default(global::UnityEngine.Vector3);
		localScale.x = (float)obj7;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+4]");
		localScale.y = 0f;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X8_v9+8]");
		localScale.z = 0f;
		transform.localScale = localScale;
		((CollectSprite)component).Init(sprite);
		_ = position.y;
		_ = position.y;
		global::UnityEngine.Transform transform2 = component.transform;
		global::UnityEngine.Vector3 position2 = default(global::UnityEngine.Vector3);
		global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
		position2.x = vector.x;
		position2.y = position.y;
		position2.z = 0f;
		transform2.position = position2;
		_ = vel.y;
		_ = position.y;
		float num3 = global::UnityEngine.Random.Range(minApplyForceDuration, maxApplyForceDuration);
		float time = global::UnityEngine.Time.time;
		float num4 = time + delay;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::System.Collections.Generic.List<CollectSprite> list = sprites;
		list.Add((CollectSprite)component);
		return;
		IL_00a7:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @1171058 (UnityEngine.Object::Instantiate, and 1 more at this address)");
		if ((object)component == null)
		{
			throw new global::System.NullReferenceException();
		}
		goto IL_015b;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000211")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF58D4", Offset = "0xFF58D4", Length = "0xD8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0xA30;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, sprite, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv46 = v45 + 0xFD8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, sprite, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A9D5]) = v43;\nL_001A:\n\tv47 = sprite.onComplete;\n\tv48 = sprite.onComplete == 0;\n\tif (v48) goto L_0024;\n\tv47.invoke_impl(v63, v47.method_code, v47.method, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_0024:\n\t;\n\tv67 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv71 = System.Collections.Generic.List`1<CollectSprite>::Remove(this.sprites, sprite);\n\tv104 = UnityEngine.Component::get_gameObject(sprite);\n\tv106 = *([v67 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv87 = *([v106 @ X0_v9+E0]) == 0;\n\tif (v87) goto L_0048;\n\tUnityEngine.Object::Destroy(v104);\n\treturn;\nL_0048:\n\tUnityEngine.Object::Destroy(v104);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 50 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void RemoveSprite(CollectSprite sprite)
	{
		//IL_0052: Expected I, but got O
		//IL_0087: Expected O, but got I
		global::System.Action onComplete = sprite.onComplete;
		if (sprite.onComplete != null)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Indirect call: v47.invoke_impl (System.IntPtr) (should have been resolved before IL gen)");
		}
		bool flag = sprites.Remove(sprite);
		global::UnityEngine.GameObject obj = sprite.gameObject;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v67 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v106 @ X0_v9+E0]");
		if ((nint)0 != 0)
		{
			global::UnityEngine.Object.Destroy(obj);
		}
		else
		{
			global::UnityEngine.Object.Destroy(obj);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000212")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF5FDC", Offset = "0xFF5FDC", Length = "0xA8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xA18;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv50 = v49 + 0xF20;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A9D6]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+F20])();\n\tSystem.Collections.Generic.List`1<CollectSprite>::.ctor(v48);\n\tv54 = this + 0x20;\n\tthis.sprites = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tthis.damping = *([2875910]);\n\tthis.maxApplyForceDuration = 0f;\n\tthis.spriteScale = 0.25f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SpriteCollectDisplay()
	{
		//IL_0014: Expected I, but got O
		//IL_0059: Expected O, but got I
		//IL_002c: Expected F4, but got I
		base._002Ector();
		global::System.Collections.Generic.List<CollectSprite> list = new global::System.Collections.Generic.List<CollectSprite>();
		sprites = list;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2875910]");
		damping = 0f;
		maxApplyForceDuration = 0f;
		spriteScale = 0.25f;
	}
}
