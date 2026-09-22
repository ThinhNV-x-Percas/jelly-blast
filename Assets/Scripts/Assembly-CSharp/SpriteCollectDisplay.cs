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
		for (int i = sprites.Count - 1; i >= 0; i--)
		{
			CollectSprite collectSprite = sprites[i];
			float time = global::UnityEngine.Time.time;
			collectSprite.prevPos = collectSprite.pos;
			if (time < collectSprite.startTime)
			{
				continue;
			}
			collectSprite.targetPos = collectSprite.getTargetPos();
			float dt = global::UnityEngine.Time.fixedDeltaTime;
			global::UnityEngine.Vector2 toTarget = collectSprite.targetPos - collectSprite.pos;
			float dist = toTarget.magnitude;
			global::UnityEngine.Vector2 dir = (dist > 1E-05f) ? (toTarget / dist) : global::UnityEngine.Vector2.zero;
			collectSprite.vel += dir * collectForce * dt;
			collectSprite.vel -= collectSprite.vel * dt * damping;
			collectSprite.pos += collectSprite.vel * dt;
			float dot = global::UnityEngine.Vector2.Dot(collectSprite.pos - collectSprite.targetPos, collectSprite.targetPos - collectSprite.startPos);
			if (dot > 0f)
			{
				RemoveSprite(collectSprite);
			}
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x600020F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF59AC", Offset = "0xFF59AC", Length = "0x3CC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_002B;\n\tv41 = Il2CppMethodInfo;\n\tv42 = v41 + 0x698;\n\tv43 = \"il2cpp_codegen_initialize_runtime_metadata\"(v42, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv68 = Il2CppMethodInfo;\n\tv69 = v68 + 0x6A0;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v69, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv74 = Il2CppMethodInfo;\n\tv75 = v74 + 0x6A8;\n\tv76 = \"il2cpp_codegen_initialize_runtime_metadata\"(v75, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv80 = Il2CppMethodInfo;\n\tv81 = v80 + 0xA28;\n\tv60 = \"il2cpp_codegen_initialize_runtime_metadata\"(v81, methodInfo, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54, v55, v56, v57, v58);\n\tv62 = 1;\n\t*([302A9D3]) = v62;\nL_002B:\n\tv67 = UnityEngine.Time::get_time();\n\tv73 = UnityEngine.Time::get_fixedTime();\n\tv180 = UnityEngine.Time::get_fixedDeltaTime();\n\tv83 = this.sprites == 0;\n\tif (v83) goto L_0142;\n\tv86 = Il2CppMethodInfo;\n\tv176 = Il2CppMethodInfo + 0x698;\n\tv308 = v67 - v73;\n\tv92 = v308 / v180;\n\tv95 = System.Collections.Generic.List`1<CollectSprite>::GetEnumerator(this.sprites);\n\tv199 = v92 - 1f;\n\tv200 = v199 < 0;\n\tv201 = v199 == 0;\n\tv202 = v92 ^ 1f;\n\tv203 = v92 ^ v199;\n\tv204 = v202 & v203;\n\tv205 = v204 < 0;\n\tv206 = v200 == v205;\n\tv207 = ~v201;\n\tv208 = v206 & v207;\n\tv209 = ~v208;\n\tif (v209) goto L_0064;\n\tgoto L_0064;\nL_0064:\n\tv233 = v92 >= 0;\n\tif (v233) goto L_006C;\n\tgoto L_006C;\nL_006C:\n\tv255 = System.Xml.ValidateNames;\nL_0070:\n\tv238 = *([v86 @ X23_v4 (Il2CppMethodInfo)+6A0]);\n\tv331 = System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::MoveNext(&v94 @ stack_-B8_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv333 = v331 == 0;\n\tif (v333) goto L_0121;\n\tv180 = UnityEngine.Time::get_time();\n\tv441 = v195 == 0;\n\tif (v441) goto L_0134;\n\tv175 = *([v195 @ stack_-A8 (UnityEngine.Component)+40]);\n\tv279 = v180 >= *([v195 @ stack_-A8 (UnityEngine.Component)+40]);\n\tif (v279) goto L_00B9;\n\tv447 = UnityEngine.Component::get_transform(this);\n\tv451 = v447 == 0;\n\tif (v451) goto L_013A;\n\tv467 = UnityEngine.Transform::get_position(v447);\n\tv483 = UnityEngine.Component::get_transform(v195);\n\tv476 = v483 == 0;\n\tif (v476) goto L_013C;\n\t// 156 MakeStruct v264 @ AGGFF5B2C_1_v5 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v195 @ stack_-A8 (UnityEngine.Component)+28], [v195 @ stack_-A8 (UnityEngine.Component)+2C], v467.z (System.Single)\n\tUnityEngine.Transform::set_position(v483, v264);\n\tv496 = UnityEngine.Component::get_transform(v195);\n\tgoto L_00A9;\n\tv518 = v191;\n\tv519 = \"il2cpp_codegen_initialize_runtime_metadata\"(v518, v457, v45, v46, v47, v48, v49, v50, v465, v461, v453, v111, v55, v56, v57, v58);\n\t*([2DD4419]) = v102;\nL_00A9:\n\tv324 = v496 == 0;\n\tif (v324) goto L_0136;\n\tv523 = *([v255 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv327 = *([v523 @ X8_v16+B8]);\n\tv308 = *([v327 @ X8_v17+4]);\n\tv124 = *([v327 @ X8_v17+8]);\n\t// 178 MakeStruct v262 @ AGGFF5B70_1_v4 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v327 @ X8_v17], [v327 @ X8_v17+4], [v327 @ X8_v17+8]\n\tUnityEngine.Transform::set_localScale(v496, v262);\n\tgoto L_0070;\nL_00B9:\n\tv450 = UnityEngine.Component::get_transform(this);\n\tv468 = UnityEngine.Transform::get_position(v450);\n\tv485 = UnityEngine.Component::get_transform(v195);\n\tv477 = v485 == 0;\n\tif (v477) goto L_013E;\n\tv487 = *([v195 @ stack_-A8 (UnityEngine.Component)+28]) - *([v195 @ stack_-A8 (UnityEngine.Component)+30]);\n\tv489 = v487 * v490;\n\tv491 = *([v195 @ stack_-A8 (UnityEngine.Component)+30]) + v489;\n\t// 205 MakeStruct v261 @ AGGFF5BC4_1_v5 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v491 @ V0_v15, v493 @ V0.S1, v468.z (System.Single)\n\tUnityEngine.Transform::set_position(v485, v261);\n\tv498 = UnityEngine.Time::get_time();\n\tv502 = v498 - *([v195 @ stack_-A8 (UnityEngine.Component)+40]);\n\tv319 = this.spriteScale;\n\tv505 = v502 / this.scaleUpDuration;\n\tv508 = v505 - 1f;\n\tv509 = v508 < 0;\n\tv510 = v508 == 0;\n\tv511 = v505 ^ 1f;\n\tv512 = v505 ^ v508;\n\tv513 = v511 & v512;\n\tv514 = v513 < 0;\n\tv515 = v509 == v514;\n\tv277 = ~v510;\n\tv516 = v515 & v277;\n\tv517 = ~v516;\n\tif (v517) goto L_FFFFFFFF;\n\tgoto L_00F1;\nL_00F1:\n\tv275 = v505 >= 0;\n\tif (v275) goto L_FFFFFFFF;\n\tgoto L_0100;\nL_0100:\n\tv280 = v466 >= 1f;\n\tif (v280) goto L_0107;\n\tv466 = EasingFunction::EaseOutElastic(v466);\n\tv319 = v319 * v466;\nL_0107:\n\tv542 = UnityEngine.Component::get_transform(v195);\n\tgoto L_0110;\n\tv545 = v191;\n\tv546 = \"il2cpp_codegen_initialize_runtime_metadata\"(v545, v458, v45, v46, v47, v48, v49, v50, v466, v462, v454, v111, v55, v56, v57, v58);\n\t*([2DD441A]) = v102;\nL_0110:\n\tv325 = v542 == 0;\n\tif (v325) goto L_0138;\n\tv548 = *([v255 @ X20_v5 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv328 = *([v548 @ X8_v13+B8]);\n\tv124 = v319 * *([v328 @ X8_v14+14]);\n\tv308 = v319 * *([v328 @ X8_v14+10]);\n\tv316 = v319 * *([v328 @ X8_v14+C]);\n\t// 284 MakeStruct v258 @ AGGFF5C50_1_v4 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v316 @ V0_v23 (System.Single), v308 @ V1_v4 (System.Single), v124 @ V2_v4 (System.Single)\n\tUnityEngine.Transform::set_localScale(v542, v258);\n\tgoto L_0070;\nL_0121:\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v94 @ stack_-B8_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\nL_0133:\n\treturn;\nL_0134:\n\tv444 = new System.NullReferenceException();\n\tgoto L_0141;\nL_0136:\n\tv471 = new System.NullReferenceException();\n\tgoto L_0141;\nL_0138:\n\tv472 = new System.NullReferenceException();\n\tgoto L_0141;\nL_013A:\n\tv473 = new System.NullReferenceException();\n\tgoto L_0141;\nL_013C:\n\tv474 = new System.NullReferenceException();\n\tgoto L_0141;\nL_013E:\n\tv475 = new System.NullReferenceException();\n\tgoto L_0141;\n\tv470 = new System.NullReferenceException();\nL_0141:\n\t// 321 Interrupt\nL_0142:\n\tv192 = new System.NullReferenceException();\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\n\tgoto L_0165;\nL_0165:\n\tv222 = v238 != 1;\n\tif (v222) goto L_0175;\n\tv235 = 0x274A080(v192, v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\tv251 = 0x274A098(v235, v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\tv238 = *([v176 @ X22_v1]);\n\tSystem.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>::Dispose(&v94 @ stack_-B8_v5 (System.Collections.Generic.List`1<System.Object>+Enumerator<System.Object>));\n\tv243 = *([v235 @ X0_v15]) == 0;\n\tif (v243) goto L_0133;\n\tv241 = new System.OutOfMemoryException();\nL_0175:\n\tv247 = 0xBF0AE4(&v171 @ stack_-B8 (System.Int32), v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\tv253 = 0x27498DC(v244, v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\tv257 = 0xD6F8(v253, v238, v45, v46, v47, v48, v49, v50, v180, v175, v124, *([v328 @ X8_v14+C]), v55, v56, v57, v58);\n\treturn;\n// 200 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Update()
	{
		if (sprites == null)
		{
			return;
		}
		float t = global::UnityEngine.Mathf.Clamp01((global::UnityEngine.Time.time - global::UnityEngine.Time.fixedTime) / global::UnityEngine.Time.fixedDeltaTime);
		foreach (CollectSprite collectSprite in sprites)
		{
			global::UnityEngine.Vector2 pos = global::UnityEngine.Vector2.Lerp(collectSprite.prevPos, collectSprite.pos, t);
			global::UnityEngine.Transform spriteTransform = collectSprite.transform;
			global::UnityEngine.Vector3 position = spriteTransform.position;
			spriteTransform.position = new global::UnityEngine.Vector3(pos.x, pos.y, position.z);
			if (global::UnityEngine.Time.time < collectSprite.startTime)
			{
				continue;
			}
			float progress = global::UnityEngine.Mathf.Clamp01((global::UnityEngine.Time.time - collectSprite.startTime) / scaleUpDuration);
			float scale = spriteScale;
			if (progress < 1f)
			{
				scale *= EasingFunction.EaseOutElastic(progress);
			}
			spriteTransform.localScale = new global::UnityEngine.Vector3(scale, scale, scale);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000210")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF5D78", Offset = "0xFF5D78", Length = "0x264")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv52 = 0x302A000;\n\tv54 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv56 = *([302A9D4]) & 1;\n\tv57 = v56 == 0;\n\tif (v57) goto L_003C;\n\tv76 = Il2CppMethodInfo + 0x48;\n\tv82 = this.spritePrefab;\n\tv61 = *([v54 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv63 = *([v61 @ X0_v42+E0]) == 0;\n\tif (v63) goto L_0048;\nL_002D:\n\tv105 = UnityEngine.Object::Instantiate /* +1 sharing this address */(v82, *([v76 @ X25_v9]));\n\tv96 = v105 == 0;\n\tv97 = ~v96;\n\tif (v97) goto L_004D;\n\tgoto L_00D9;\nL_003C:\n\t*([v52 @ X22_v1+9D4]) = 1;\n\tv76 = Il2CppMethodInfo + 0x48;\n\tv82 = this.spritePrefab;\n\tv75 = *([v54 @ X24_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv116 = *([v75 @ X0_v38+E0]) == 0;\n\tv79 = ~v116;\n\tif (v79) goto L_002D;\nL_0048:\n\tv105 = UnityEngine.Object::Instantiate /* +1 sharing this address */(v91, *([v88 @ X25_v6]));\nL_004D:\n\tv113 = UnityEngine.Component::get_transform(v105);\n\tgoto L_005B;\n\tv162 = System.Xml.ValidateNames;\n\tv163 = v162 + 0xD0;\n\tv164 = \"il2cpp_codegen_initialize_runtime_metadata\"(v163, v112, getTargetPos, onComplete, methodInfo, v68, v69, v70, position, v0, vel, v2, delay, v71, v72, v73);\n\tv165 = 1;\n\t*([2DD4419]) = v165;\nL_005B:\n\tv264 = System.Xml.ValidateNames;\n\tv266 = *([v264 @ X8_v6 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv151 = *([v266 @ X8_v8+B8]);\n\t// 100 MakeStruct v127 @ AGGFF5EAC_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v151 @ X8_v9], [v151 @ X8_v9+4], [v151 @ X8_v9+8]\n\tUnityEngine.Transform::set_localScale(v113, v127);\n\tCollectSprite::Init(v105, sprite);\n\t*([v105 @ X0_v3 (UnityEngine.Component)+28]) = position;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+2C]) = position.y;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+30]) = position;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+34]) = position.y;\n\tv138 = UnityEngine.Component::get_transform(v105);\n\t// 119 MakeStruct v122 @ AGGFF5EE8_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), position @ V0 (UnityEngine.Vector2), position.y (System.Single), 0\n\tUnityEngine.Transform::set_position(v138, v122);\n\t*([v105 @ X0_v3 (UnityEngine.Component)+38]) = vel;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+3C]) = vel.y;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+50]) = position;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+54]) = position.y;\n\tv277 = UnityEngine.Random::Range(this.minApplyForceDuration, this.maxApplyForceDuration);\n\t*([v105 @ X0_v3 (UnityEngine.Component)+44]) = v277;\n\tv279 = UnityEngine.Time::get_time();\n\tv130 = v279 + delay;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+40]) = v130;\n\tv281 = v105 + 0x58;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+58]) = onComplete;\n\tv283 = 0xF3F1B4(v281, onComplete, 0, onComplete, methodInfo, v68, v69, v70, v130, this.maxApplyForceDuration, 0, vel.y, delay, v71, v72, v73);\n\tv285 = v105 + 0x60;\n\t*([v105 @ X0_v3 (UnityEngine.Component)+60]) = getTargetPos;\n\tv286 = 0xF3F1B4(v285, getTargetPos, 0, onComplete, methodInfo, v68, v69, v70, v130, this.maxApplyForceDuration, 0, vel.y, delay, v71, v72, v73);\n\tv139 = this.sprites;\n\tv290 = v139._version + 1;\n\tv139._version = v290;\n\tv119 = v139._items;\n\tv291 = v139._size < v119.Length;\n\tv200 = ~v291;\n\tif (v200) goto L_00C2;\n\tv228 = v139._size + 1;\n\tv139._size = v228;\n\tv176 = v139._size << 3;\n\tv292 = v119 + v176;\n\tv293 = v292 + 0x20;\n\t*([v293 @ X0_v20]) = v105;\n\tv219 = 0xF3F1B4(v293, v105, 0, onComplete, methodInfo, v68, v69, v70, v130, this.maxApplyForceDuration, 0, vel.y, delay, v71, v72, v73);\n\treturn;\nL_00C2:\n\t;\n\tSystem.Collections.Generic.List`1<CollectSprite>::AddWithResize(v139, v105);\n\treturn;\nL_00D9:\n\tthrow System.NullReferenceException;\n// 142 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void AddSprite(global::UnityEngine.Sprite sprite, global::UnityEngine.Vector2 position, global::UnityEngine.Vector2 vel, float delay, global::System.Func<global::UnityEngine.Vector2> getTargetPos = null, global::System.Action onComplete = null)
	{
		CollectSprite instance = global::UnityEngine.Object.Instantiate(spritePrefab, base.transform);
		instance.transform.localScale = global::UnityEngine.Vector3.zero;
		instance.Init(sprite);
		instance.pos = position;
		instance.prevPos = position;
		instance.transform.position = new global::UnityEngine.Vector3(position.x, position.y, 0f);
		instance.vel = vel;
		instance.startPos = position;
		instance.applyForceDuration = global::UnityEngine.Random.Range(minApplyForceDuration, maxApplyForceDuration);
		instance.startTime = global::UnityEngine.Time.time + delay;
		instance.onComplete = onComplete;
		instance.getTargetPos = getTargetPos;
		sprites.Add(instance);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000211")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF58D4", Offset = "0xFF58D4", Length = "0xD8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001A;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0xA30;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, sprite, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv45 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv46 = v45 + 0xFD8;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v46, sprite, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\n\tv43 = 1;\n\t*([302A9D5]) = v43;\nL_001A:\n\tv47 = sprite.onComplete;\n\tv48 = sprite.onComplete == 0;\n\tif (v48) goto L_0024;\n\tv47.invoke_impl(v63, v47.method_code, v47.method, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39);\nL_0024:\n\t;\n\tv67 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv71 = System.Collections.Generic.List`1<CollectSprite>::Remove(this.sprites, sprite);\n\tv104 = UnityEngine.Component::get_gameObject(sprite);\n\tv106 = *([v67 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv87 = *([v106 @ X0_v9+E0]) == 0;\n\tif (v87) goto L_0048;\n\tUnityEngine.Object::Destroy(v104);\n\treturn;\nL_0048:\n\tUnityEngine.Object::Destroy(v104);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 50 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void RemoveSprite(CollectSprite sprite)
	{
		sprite.onComplete?.Invoke();
		sprites.Remove(sprite);
		global::UnityEngine.Object.Destroy(sprite.gameObject);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000212")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF5FDC", Offset = "0xFF5FDC", Length = "0xA8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tgoto L_001C;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0xA18;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv49 = System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>;\n\tv50 = v49 + 0xF20;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v50, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A9D6]) = v46;\nL_001C:\n\tv48 = new *([v18 @ X22_v1 (Il2CppClass<System.Func`1<UnityEngine.UIElements.ValidateCommandEvent>>)+F20])();\n\tSystem.Collections.Generic.List`1<CollectSprite>::.ctor(v48);\n\tv54 = this + 0x20;\n\tthis.sprites = v48;\n\tv56 = 0xF3F1B4(v54, v48, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tthis.damping = *([2875910]);\n\tthis.maxApplyForceDuration = 0f;\n\tthis.spriteScale = 0.25f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SpriteCollectDisplay()
	{
		sprites = new global::System.Collections.Generic.List<CollectSprite>();
		damping = 0f;
		maxApplyForceDuration = 0f;
		spriteScale = 0.25f;
	}
}
