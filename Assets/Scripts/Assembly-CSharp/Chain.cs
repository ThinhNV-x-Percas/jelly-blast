[global::Cpp2ILInjected.Token(Token = "0x2000047")]
public class Chain : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.Header("Endpoints (drag to move)")]
	[global::Cpp2ILInjected.Token(Token = "0x400010A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.Rigidbody2D startPoint;

	[global::Cpp2ILInjected.Token(Token = "0x400010B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.Rigidbody2D endPoint;

	[global::UnityEngine.Tooltip("World-space sag beneath the mid-point.")]
	[global::UnityEngine.Min(0f)]
	[global::Cpp2ILInjected.Token(Token = "0x400010C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float sagDepth;

	[global::UnityEngine.Header("Link Geometry")]
	[global::UnityEngine.Tooltip("Half-length of a prefab (centre → joint attach).")]
	[global::Cpp2ILInjected.Token(Token = "0x400010D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float anchorOffset;

	[global::UnityEngine.Tooltip("Rigidbody2D prefab for a single link.")]
	[global::Cpp2ILInjected.Token(Token = "0x400010E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.Rigidbody2D linkPrefab;

	[global::Cpp2ILInjected.Token(Token = "0x400010F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	private readonly global::System.Collections.Generic.List<global::UnityEngine.Rigidbody2D> _links;

	[global::Cpp2ILInjected.Token(Token = "0x4000110")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::UnityEngine.Vector2 _lastStartPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000111")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	private global::UnityEngine.Vector2 _lastEndPos;

	[global::Cpp2ILInjected.Token(Token = "0x6000187")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE9CFC", Offset = "0xFE9CFC", Length = "0x94")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = CollectParticleData[];\n\tv20 = *([302A97B]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0026;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv24 = *([v22 @ X0_v15+E0]) == 0;\n\tif (v24) goto L_002E;\nL_0015:\n\tv50 = UnityEngine.Application::get_isPlaying();\n\tv57 = ~v50;\n\tif (v57) goto L_0039;\nL_0020:\n\tChain::RebuildRuntime(this);\n\treturn;\nL_0026:\n\t*([v16 @ X20_v1+97B]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv56 = *([v44 @ X0_v9+E0]) == 0;\n\tv46 = ~v56;\n\tif (v46) goto L_0015;\nL_002E:\n\tv59 = UnityEngine.Application::get_isPlaying();\n\tv80 = ~v59;\n\tv62 = ~v80;\n\tif (v62) goto L_0020;\nL_0039:\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_00be: Expected O, but got I
		//IL_005a: Expected O, but got I
		object obj = 50503680;
		nint num = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A97B]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v15+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v9+E0]");
			if ((nint)0 != 0)
			{
				goto IL_007f;
			}
		}
		if (!global::UnityEngine.Application.isPlaying)
		{
			return;
		}
		goto IL_00a1;
		IL_00a1:
		RebuildRuntime();
		return;
		IL_007f:
		if (global::UnityEngine.Application.isPlaying)
		{
			goto IL_00a1;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000188")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEA17C", Offset = "0xFEA17C", Length = "0x114")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = CollectParticleData[];\n\tv20 = *([302A97C]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_001E;\n\tv22 = *([v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv24 = *([v22 @ X0_v20+E0]) == 0;\n\tif (v24) goto L_0026;\nL_0015:\n\tv50 = UnityEngine.Application::get_isPlaying();\n\tv57 = ~v50;\n\tv58 = ~v57;\n\tif (v58) goto L_002D;\n\tgoto L_006F;\nL_001E:\n\t*([302A97C]) = 1;\n\tv44 = *([v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]);\n\tv56 = *([v44 @ X0_v16+E0]) == 0;\n\tv46 = ~v56;\n\tif (v46) goto L_0015;\nL_0026:\n\tv60 = UnityEngine.Application::get_isPlaying();\n\tv63 = ~v60;\n\tif (v63) goto L_006F;\nL_002D:\n\tv117 = UnityEngine.Rigidbody2D::get_position(this.startPoint);\n\tv195 = v117 - this._lastStartPos;\n\tv196 = v117.y - this._lastStartPos.y;\n\tv197 = v195 * v195;\n\tv198 = v196 * v196;\n\tv142 = v197 + v198;\n\tv69 = v142 >= 0x2EDBE6FE;\n\tif (v69) goto L_0066;\n\tv202 = UnityEngine.Rigidbody2D::get_position(this.endPoint);\n\tv204 = v202 - this._lastEndPos;\n\tv205 = v202.y - this._lastEndPos.y;\n\tv206 = v204 * v204;\n\tv207 = v205 * v205;\n\tv101 = v206 + v207;\n\tv87 = v101 < 0x2EDBE6FE;\n\tif (v87) goto L_006F;\nL_0066:\n\tChain::RebuildRuntime(this);\n\treturn;\nL_006F:\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Update()
	{
		//IL_000e: Expected I, but got O
		//IL_00be: Expected O, but got I
		//IL_0051: Expected O, but got I
		nint num = (nint)typeof(CollectParticleData[]);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302A97C]");
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v22 @ X0_v20+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<CollectParticleData[]>)+B30]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v44 @ X0_v16+E0]");
			if ((nint)0 != 0)
			{
				goto IL_0076;
			}
		}
		if (global::UnityEngine.Application.isPlaying)
		{
			goto IL_0115;
		}
		return;
		IL_0115:
		global::UnityEngine.Vector2 position = startPoint.position;
		float num2 = position.x - _lastStartPos.x;
		float num3 = position.y - _lastStartPos.y;
		float num4 = num2 * num2;
		float num5 = num3 * num3;
		float num6 = num4 + num5;
		if (num6 < 9.9999994E-11f)
		{
			global::UnityEngine.Vector2 position2 = endPoint.position;
			float num7 = position2.x - _lastEndPos.x;
			float num8 = position2.y - _lastEndPos.y;
			float num9 = num7 * num7;
			float num10 = num8 * num8;
			float num11 = num9 + num10;
			if (num11 < 9.9999994E-11f)
			{
				return;
			}
		}
		RebuildRuntime();
		return;
		IL_0076:
		if (!global::UnityEngine.Application.isPlaying)
		{
			return;
		}
		goto IL_0115;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000189")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE9D90", Offset = "0xFE9D90", Length = "0x3EC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv24 = &v25 @ stack_-10_v2;\n\tgoto L_0023;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0x68;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv57 = Il2CppMethodInfo;\n\tv58 = v57 + 0x70;\n\tv59 = \"il2cpp_codegen_initialize_runtime_metadata\"(v58, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv171 = Il2CppMethodInfo;\n\tv172 = v171 + 0x78;\n\tv173 = \"il2cpp_codegen_initialize_runtime_metadata\"(v172, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv192 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv193 = v192 + 0xFD8;\n\tv52 = \"il2cpp_codegen_initialize_runtime_metadata\"(v193, methodInfo, v37, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302A97D]) = v54;\nL_0023:\n\tv165 = this._links;\n\tv167 = v165._size;\n\tv64 = v165._size < 1;\n\tif (v64) goto L_005E;\n\tgoto L_0049;\nL_0038:\n\tUnityEngine.Object::Destroy(v325);\n\tv95 = v167 <= 0;\n\tif (v95) goto L_0059;\nL_0049:\n\tv167 = v167 - 1;\n\tv152 = System.Collections.Generic.List`1<UnityEngine.Rigidbody2D>::get_Item(this._links, v167);\n\tv325 = UnityEngine.Component::get_gameObject(v152);\n\tgoto L_0038;\n\tv342 = \"il2cpp_codegen_runtime_class_init\"(v328, v324, v91, v38, v39, v40, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50);\n\tgoto L_0038;\nL_0059:\n\tv165 = this._links;\nL_005E:\n\tv84 = v165._version + 1;\n\tv165._size = 0;\n\tv165._version = v84;\n\tv96 = v165._size < 1;\n\tif (v96) goto L_0075;\n\tSystem.Array::Clear(v165._items, 0, v165._size);\nL_0075:\n\tv576 = UnityEngine.Rigidbody2D::get_position(this.startPoint);\n\tv327 = UnityEngine.Rigidbody2D::get_position(this.endPoint);\n\tv335 = v576 + v327;\n\tv337 = v335 * 0x3F;\n\tgoto L_0095;\n\tv344 = System.Xml.ValidateNames;\n\tv345 = v344 + 0x98;\n\tv346 = \"il2cpp_codegen_initialize_runtime_metadata\"(v345, v326, v92, v81, v39, v40, v41, v42, v335, v336, v332, v46, v331, v48, v49, v50);\n\tv348 = v256;\n\tv351 = 1;\n\t*([2DD4423]) = v351;\nL_0095:\n\tv352 = System.Xml.ValidateNames;\n\tv354 = *([v352 @ X8_v8 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv355 = *([v354 @ X8_v10+B8]);\n\tv358 = *([v355 @ X8_v11+18]) * v359;\n\tv360 = v337 + v358;\n\tv412 = *([2DD4425]);\n\tv367 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_00C8;\nL_00B0:\n\tv438 = v382 * v333;\n\tv439 = v360 * v334;\n\tv440 = v438 + v439;\n\tv441 = v327 * v359;\n\tv386 = v441 + v440;\n\tv442 = v373 - v386;\n\tv443 = v442 * v442;\n\t// 185 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv384 = UnityEngine.Mathf::Sqrt(v443);\n\tv377 = v377 + v384;\n\tv389 = v389 + 1;\n\tv400 = v389 == 0x11;\n\tif (v400) goto L_00DF;\nL_00C8:\n\tv413 = v412 == 0;\n\tif (v413) goto L_00D4;\n\tgoto L_00B0;\n\tgoto L_FFFFFFFF;\nL_00D4:\n\t*([2DD4425]) = 1;\n\tgoto L_00B0;\n\tv421 = v256;\n\tv429 = *([2DD4425]);\n\tgoto L_00B0;\nL_00DF:\n\tv450 = this.anchorOffset + this.anchorOffset;\n\tv453 = *([2DD4417]) == 0;\n\tif (v453) goto L_010E;\n\tv454 = *([v367 @ X20_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv461 = v377 / v450;\n\tv457 = *([v454 @ X0_v37+E0]) == 0;\n\tif (v457) goto L_0117;\nL_00EA:\n\tv470 = &v25 @ stack_-10_v2 - 0x58;\n\tv472 = 0x274AA58(v470, 0, v165._size, 0, v39, v40, v41, v42, v461, v384, v327, v360, v382, v48, v49, v50);\n\tv489 = v461 >= 0;\n\tif (v489) goto L_0132;\nL_0104:\n\tv530 = v496 != -0.5d;\n\tif (v530) goto L_0144;\n\tv599 = *([v24 @ X29_v1-58]);\n\tgoto L_0137;\nL_010E:\n\t*([2DD4417]) = 1;\n\tv464 = *([v367 @ X20_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv461 = v377 / v450;\n\tv479 = *([v464 @ X0_v32+E0]) == 0;\n\tv466 = ~v479;\n\tif (v466) goto L_00EA;\nL_0117:\n\tv491 = &v25 @ stack_-10_v2 - 0x58;\n\tv493 = 0x274AA58(v491, 0, v165._size, 0, v39, v40, v41, v42, v473, v384, v327, v360, v382, v48, v49, v50);\n\tv498 = v473 < 0;\n\tif (v498) goto L_0104;\nL_0132:\n\tv558 = v533 != 0.5d;\n\tif (v558) goto L_0147;\n\tv599 = *([v24 @ X29_v1-58]);\nL_0137:\n\tv589 = v599 + v574;\n\tv590 = v588 & 1;\n\tv592 = v590 == 0;\n\tv595 = ~v592;\n\tif (v595) goto L_FFFFFFFF;\n\tgoto L_FFFFFFFF;\n\tgoto L_014C;\nL_0144:\n\tv564 = v494 + -0.5d;\n\tv599 = System.Math::Ceiling(v564);\n\tgoto L_014C;\nL_0147:\n\tv569 = v531 + 0.5d;\n\tv599 = System.Math::Floor(v569);\nL_014C:\n\tv619 = v599 + 1;\n\tv631 = v619 < 0x40;\n\tif (v631) goto L_015C;\n\tgoto L_0160;\nL_015C:\n\tv317 = v599 + 1;\nL_0160:\n\tv639 = v317 - 2;\n\tv640 = v639 < 0;\n\tv641 = v639 == 0;\n\tv642 = v317 ^ 2;\n\tv643 = v317 ^ v639;\n\tv644 = v642 & v643;\n\tv645 = v644 < 0;\n\tv646 = v640 == v645;\n\tv217 = ~v641;\n\tv289 = v646 & v217;\n\tv647 = ~v289;\n\tif (v647) goto L_FFFFFFFF;\n\tgoto L_017C;\nL_017C:\n\tv242 = v599 != 0x7FF0000000000000;\n\tif (v242) goto L_FFFFFFFF;\n\tgoto L_0187;\nL_0187:\n\t// 391 MakeStruct v209 @ AGGFEA11C_0_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v603 @ V0_v16 (UnityEngine.Vector2), v602 @ V1_v17 (System.Single)\n\t// 392 MakeStruct v206 @ AGGFEA11C_1_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v360 @ V0_v7 (System.Single), v618 @ V2.S1\n\tv659 = Chain::EvenTByArc(v209, v206, v327, v654, v377, 0x3C);\n\t// 406 MakeStruct v234 @ AGGFEA13C_2_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v360 @ V0_v7 (System.Single), v618 @ V2.S1\n\tChain::SpawnLinks(this, v576, v234, v327, v659, this.startPoint, this.endPoint);\n\tthis._lastStartPos = v576;\n\tthis._lastStartPos.y = v576.y;\n\tthis._lastEndPos.x = v327;\n\tthis._lastEndPos.y = v327.y;\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 282 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void RebuildRuntime()
	{
		//IL_060d: Expected I, but got O
		//IL_061d: Expected O, but got I
		//IL_062d: Expected O, but got I
		//IL_0671: Expected I, but got O
		//IL_023f: Expected O, but got F4
		//IL_03d8: Expected O, but got I
		//IL_031e: Expected O, but got I
		//IL_02d3: Expected O, but got I
		//IL_042e: Expected O, but got I
		//IL_04b2: Expected F8, but got I
		//IL_04cf: Expected F8, but got I
		//IL_06a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ad: Expected I4, but got Unknown
		//IL_03a0: Expected F8, but got I
		//IL_03bd: Expected F8, but got I
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_073b: Expected O, but got Unknown
		//IL_0748: Expected O, but got F8
		//IL_05eb: Expected I4, but got F8
		//IL_0804: Expected F4, but got O
		//IL_0840: Expected F4, but got O
		object obj2 = default(object);
		object obj = obj2;
		global::System.Collections.Generic.List<global::UnityEngine.Rigidbody2D> links = _links;
		int num = links.Count;
		if (links.Count >= 1)
		{
			do
			{
				num--;
				global::UnityEngine.Component component = _links[num];
				global::UnityEngine.GameObject obj3 = component.gameObject;
				global::UnityEngine.Object.Destroy(obj3);
			}
			while (num > 0);
			links = _links;
		}
		int version = links._version + 1;
		links._size = 0;
		links._version = version;
		if (links.Count >= 1)
		{
			global::System.Array.Clear(links._items, 0, links.Count);
		}
		global::UnityEngine.Vector2 position = startPoint.position;
		global::UnityEngine.Vector2 position2 = endPoint.position;
		float num2 = position.x + position2.x;
		float num3 = num2 * 8.8E-44f;
		global::UnityEngine.Vector2 vector = position;
		nint num4 = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v352 @ X8_v8 (Il2CppClass<System.Xml.ValidateNames>)+98]");
		object obj4 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v354 @ X8_v10+B8]");
		object obj5 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v355 @ X8_v11+18]");
		object obj6 = default(object);
		float num5 = 0f * (float)obj6;
		float num6 = num3 + num5;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4425]");
		int num7 = 0;
		nint num8 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		global::UnityEngine.Vector2 vector2 = position;
		float num9 = 0f;
		int num10 = 1;
		object obj7 = default(object);
		object obj8 = default(object);
		bool flag;
		do
		{
			if (num7 == 0)
			{
				_ = 1;
				vector = position;
				num7 = 1;
			}
			float num11 = vector.x * (float)obj7;
			float num12 = num6 * (float)obj8;
			float num13 = num11 + num12;
			float num14 = position2.x * (float)obj6;
			float num15 = num14 + num13;
			float num16 = vector2.x - num15;
			float f = num16 * num16;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FADDP not yet implemented.\"");
			float num17 = global::UnityEngine.Mathf.Sqrt(f);
			num9 += num17;
			num10++;
			flag = num10 == 17;
			vector2 = (global::UnityEngine.Vector2)num15;
		}
		while (!flag);
		float num18 = anchorOffset + anchorOffset;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4417]");
		float num19;
		float num20;
		if ((nint)0 != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
			object obj9 = 0;
			num19 = num9 / num18;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v454 @ X0_v37+E0]");
			bool flag2 = (nint)0 == 0;
			num20 = num19;
			if (!flag2)
			{
				goto IL_030f;
			}
		}
		else
		{
			_ = 1;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v367 @ X20_v6 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
			object obj10 = 0;
			num19 = num9 / num18;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X0_v32+E0]");
			bool flag3 = (nint)0 == 0;
			bool flag4 = !flag3;
			num20 = num19;
			if (flag4)
			{
				goto IL_030f;
			}
		}
		object obj11 = (nint)obj2 - 88;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
		bool flag5 = num20 < 0f;
		float num21 = num20;
		float num22 = num20;
		float num23 = num20;
		float num24 = num20;
		if (flag5)
		{
			goto IL_036a;
		}
		goto IL_047c;
		IL_0690:
		double num26;
		double num27;
		double num25 = num26 + num27;
		double num28;
		if ((num28 & 1) != 0)
		{
			num26 = num25;
		}
		float y = position.y;
		global::UnityEngine.Vector2 vector3 = position;
		goto IL_055c;
		IL_055c:
		double num29 = num26 + double.Epsilon;
		double num30 = ((num29 < 3.16E-322) ? (num26 + double.Epsilon) : 3.16E-322);
		double num31 = num30 - 1E-323;
		bool flag6 = num31 < 0.0;
		bool flag7 = num31 == 0.0;
		object obj12 = num30 ^ 2;
		object obj13 = num30 ^ num31;
		int num32 = (int)((nint)obj12 & (nint)obj13);
		bool flag8 = num32 < 0;
		bool flag9 = flag6 == flag8;
		bool flag10 = !flag7;
		if (!(flag9 && flag10))
		{
			num30 = 1E-323;
		}
		int linkCount = ((num26 != 9.218868437227405E+18) ? ((int)num30) : 2);
		global::UnityEngine.Vector2 a = default(global::UnityEngine.Vector2);
		a.x = vector3.x;
		a.y = y;
		global::UnityEngine.Vector2 b = default(global::UnityEngine.Vector2);
		b.x = num6;
		object obj14 = default(object);
		b.y = (float)obj14;
		float[] ts = EvenTByArc(a, b, position2, linkCount, num9);
		global::UnityEngine.Vector2 p = default(global::UnityEngine.Vector2);
		p.x = num6;
		p.y = (float)obj14;
		SpawnLinks(position, p, position2, ts, startPoint, endPoint);
		_lastStartPos = position;
		_lastStartPos.y = position.y;
		_lastEndPos.x = position2.x;
		_lastEndPos.y = position2.y;
		return;
		IL_047c:
		if ((double)num24 == 0.5)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			num26 = 0.0;
			num27 = 1.0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			num28 = 0.0;
			goto IL_0690;
		}
		double d = (double)num23 + 0.5;
		num26 = global::System.Math.Floor(d);
		y = position.y;
		vector3 = position;
		goto IL_055c;
		IL_036a:
		if ((double)num22 == -0.5)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			num26 = 0.0;
			num27 = -1.0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v24 @ X29_v1-58]");
			num28 = 0.0;
			goto IL_0690;
		}
		double a2 = (double)num21 + -0.5;
		num26 = global::System.Math.Ceiling(a2);
		y = position.y;
		vector3 = position;
		goto IL_055c;
		IL_030f:
		object obj15 = (nint)obj2 - 88;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274AA58");
		bool flag11 = !(num19 < 0f);
		num21 = num19;
		num22 = num19;
		num23 = num19;
		num24 = num19;
		if (!flag11)
		{
			goto IL_036a;
		}
		goto IL_047c;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600018A")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEA8AC", Offset = "0xFEA8AC", Length = "0x3EC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0042;\n\tv67 = Il2CppMethodInfo;\n\tv68 = v67 + 0x60;\n\tv69 = \"il2cpp_codegen_initialize_runtime_metadata\"(v68, ts, rbStart, rbEnd, methodInfo, v71, v72, v73, p0, v0, p1, v2, p2, v4, v74, v75);\n\tv81 = Il2CppMethodInfo;\n\tv82 = v81 + 0x70;\n\tv83 = \"il2cpp_codegen_initialize_runtime_metadata\"(v82, ts, rbStart, rbEnd, methodInfo, v71, v72, v73, p0, v0, p1, v2, p2, v4, v74, v75);\n\tv252 = Il2CppMethodInfo;\n\tv253 = v252 + 0x78;\n\tv77 = \"il2cpp_codegen_initialize_runtime_metadata\"(v253, ts, rbStart, rbEnd, methodInfo, v71, v72, v73, p0, v0, p1, v2, p2, v4, v74, v75);\n\tv79 = 1;\n\t*([302A97E]) = v79;\nL_0042:\n\tv96 = ts.Length < 1;\n\tif (v96) goto L_0130;\n\tv180 = p1 - p0;\n\tv177 = p1.y - p0.y;\n\tv174 = p2 - p1;\n\tv171 = p2.y - p1.y;\n\tv259 = Facebook.Unity.Windows.IWindowsFacebook;\n\tgoto L_0068;\nL_0053:\n\tv578 = *([v234 @ X8_v32+20]);\n\tv579 = *([v578 @ X8_v35+C0]);\n\tv309 = *([v579 @ X8_v36+70]);\n\tSystem.Collections.Generic.List`1<UnityEngine.Rigidbody2D>::AddWithResize(v226, v550);\n\tv186 = v186 + 1;\n\tv271 = v186 >= ts.Length;\n\tif (v271) goto L_0130;\nL_0068:\n\t;\n\tv328 = *([2DD4421]) == 0;\n\tif (v328) goto L_0128;\n\tv479 = *([v259 @ X25_v4 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tgoto L_0070;\nL_0070:\n\tv440 = 1f - ts[v186 @ X23_v5 (System.Int32)];\n\tv441 = v180 * v440;\n\tv442 = v177 * v440;\n\tv443 = v174 * ts[v186 @ X23_v5 (System.Int32)];\n\tv444 = v171 * ts[v186 @ X23_v5 (System.Int32)];\n\tv445 = v443 + v441;\n\tv446 = v444 + v442;\n\tv447 = v445 + v445;\n\tv448 = v446 + v446;\n\tv449 = v447 * v447;\n\tv450 = v448 * v448;\n\tv451 = v449 + v450;\n\tv452 = UnityEngine.Mathf::Sqrt(v451);\n\tv189 = v452 <= 0x3727C5AC;\n\tif (v189) goto L_0093;\n\tv483 = v447 / v452;\n\tv476 = v448 / v452;\n\tgoto L_009F;\nL_0093:\n\tgoto L_0099;\n\tv503 = System.Xml.ValidateNames;\n\tv504 = v503 + 0x98;\n\tv505 = \"il2cpp_codegen_initialize_runtime_metadata\"(v504, v308, v309, rbEnd, methodInfo, v71, v72, v73, v447, v467, v448, v452, v303, v323, v302, v301);\n\tv507 = 1;\n\t*([2DD4424]) = v507;\nL_0099:\n\tv508 = System.Xml.ValidateNames;\n\tv510 = *([v508 @ X8_v47 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv482 = *([v510 @ X8_v49+B8]);\n\tv483 = *([v482 @ X8_v50]);\n\tv476 = *([v482 @ X8_v50+4]);\nL_009F:\n\tv485 = v440 * v440;\n\tv488 = p0 * v485;\n\tv489 = p0.y * v485;\n\tv490 = v440 + v440;\n\tv491 = ts[v186 @ X23_v5 (System.Int32)] * v490;\n\tv492 = p1 * v491;\n\tv493 = p1.y * v491;\n\tv494 = v488 + v492;\n\tv495 = v489 + v493;\n\tv496 = ts[v186 @ X23_v5 (System.Int32)] * ts[v186 @ X23_v5 (System.Int32)];\n\tv499 = p2 * v496;\n\tv500 = p2.y * v496;\n\tv501 = v499 + v494;\n\tv150 = v500 + v495;\n\tv502 = 0x274A290(v479, v308, v309, rbEnd, methodInfo, v71, v72, v73, v476, v483, v495, v494, v500, v499, p2.y, v301);\n\tv514 = v476 * 0x42652EE1;\n\tv517 = v514 + 0x42B40000;\n\tv521 = v517 * 0x3C8EFA35;\n\t// 192 MakeStruct v143 @ AGGFEAACC_0_v4 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), 0, 0, v521 @ V2_v10 (System.Single)\n\tv525 = UnityEngine.Quaternion::Internal_FromEulerRad(v143);\n\t// 210 MakeStruct v130 @ AGGFEAB04_1_v4 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v501 @ V14_v6 (System.Single), v150 @ V15_v6 (System.Single), 0\n\tv550 = Chain::CreateLink(this, v130, v525, v186);\n\tv539 = v162 & 1;\n\tv540 = v539 == 0;\n\tif (v540) goto L_00EB;\n\tgoto L_00E3;\n\tv547 = System.Xml.ValidateNames;\n\tv548 = v547 + 0x98;\n\tv549 = \"il2cpp_codegen_initialize_runtime_metadata\"(v548, v537, v309, rbEnd, methodInfo, v71, v72, v73, v534, v535, v532, v536, v140, v243, v137, v134);\n\tv552 = 1;\n\t*([2DD4424]) = v552;\nL_00E3:\n\tv553 = System.Xml.ValidateNames;\n\tv555 = *([v553 @ X8_v40 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv556 = *([v555 @ X8_v42+B8]);\n\tv147 = *([v556 @ X8_v43]);\n\tv246 = *([v556 @ X8_v43+4]);\n\tgoto L_00F1;\nL_00EB:\n\tv246 = this.anchorOffset * -0.5f;\nL_00F1:\n\t// 241 MakeStruct v102 @ AGGFEAB64_3_v4 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), 0, this.anchorOffset (System.Single)\n\t// 242 MakeStruct v98 @ AGGFEAB64_4_v4 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v147 @ V2_v13 (UnityEngine.Vector2), v246 @ V3_v14 (System.Single)\n\tChain::ConnectRope(v560, v550, v240, v102, v98);\n\tv226 = this._links;\n\tv562 = Il2CppMethodInfo;\n\tv234 = *([v562 @ X8_v30 (Il2CppMethodInfo)+60]);\n\tv565 = v226._version + 1;\n\tv226._version = v565;\n\tv119 = v226._items;\n\tv566 = v226._size < v119.Length;\n\tv567 = ~v566;\n\tif (v567) goto L_0053;\n\tv575 = v226._size + 1;\n\tv226._size = v575;\n\tv261 = v226._size << 3;\n\tv576 = v119 + v261;\n\tv577 = v576 + 0x20;\n\t*([v577 @ X0_v26]) = v550;\n\tv290 = 0xF3F1B4(v577, v550, v240, rbEnd, methodInfo, v71, v72, v73, 0, this.anchorOffset, v147, v246, v525.y, v525.z, v525.w, v525.w);\n\tv186 = v186 + 1;\n\tv272 = v186 < ts.Length;\n\tif (v272) goto L_0068;\n\tgoto L_0130;\nL_0128:\n\t*([2DD4421]) = 1;\n\tv479 = *([v259 @ X25_v4 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tgoto L_0070;\n\tv432 = \"il2cpp_codegen_runtime_class_init\"(v453, v308, v309, rbEnd, methodInfo, v71, v72, v73, v310, v325, v305, v324, v303, v323, v302, v301);\n\tgoto L_0070;\nL_0130:\n\tv227 = this._links;\n\tv332 = v227._size - 1;\n\tv334 = System.Collections.Generic.List`1<UnityEngine.Rigidbody2D>::get_Item(v227, v332);\n\tgoto L_0145;\n\tv456 = System.Xml.ValidateNames;\n\tv457 = v456 + 0x98;\n\tv458 = \"il2cpp_codegen_initialize_runtime_metadata\"(v457, v332, v333, rbEnd, methodInfo, v71, v72, v73, v184, v250, v148, v247, v141, v244, v138, v135);\n\tv460 = 1;\n\t*([2DD4424]) = v460;\nL_0145:\n\tv420 = this.anchorOffset * -0.5f;\n\tv462 = System.Xml.ValidateNames;\n\tv464 = *([v462 @ X8_v10 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv401 = *([v464 @ X8_v12+B8]);\n\t// 356 MakeStruct v341 @ AGGFEAC90_3_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), 0, v420 @ V1_v4 (System.Single)\n\t// 357 MakeStruct v338 @ AGGFEAC90_4_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), [v401 @ X8_v13], [v401 @ X8_v13+4]\n\tChain::ConnectRope(v334, v334, rbEnd, v341, v338);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 216 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void SpawnLinks(global::UnityEngine.Vector2 p0, global::UnityEngine.Vector2 p1, global::UnityEngine.Vector2 p2, float[] ts, global::UnityEngine.Rigidbody2D rbStart, global::UnityEngine.Rigidbody2D rbEnd)
	{
		//IL_0096: Expected I, but got O
		//IL_071e: Expected I, but got O
		//IL_072e: Expected O, but got I
		//IL_073e: Expected O, but got I
		//IL_0766: Expected F4, but got O
		//IL_077b: Expected F4, but got I
		//IL_045a: Expected O, but got I
		//IL_0186: Expected O, but got I
		//IL_066e: Expected I, but got O
		//IL_067e: Expected O, but got I
		//IL_068e: Expected O, but got I
		//IL_0696: Expected F4, but got O
		//IL_06a6: Expected F4, but got I
		//IL_0321: Expected O, but got I
		//IL_06b9: Expected I, but got O
		//IL_06c9: Expected O, but got I
		//IL_06d9: Expected O, but got I
		//IL_06f1: Expected F4, but got I
		//IL_00cd: Expected O, but got I
		//IL_00dd: Expected O, but got I
		//IL_00ed: Expected O, but got I
		//IL_03c3: Expected O, but got I
		//IL_03d2: Expected O, but got I
		if (ts.Length >= 1)
		{
			global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
			global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
			float num = vector.x - vector2.x;
			float num2 = p1.y - p0.y;
			global::UnityEngine.Vector2 vector3 = default(global::UnityEngine.Vector2);
			float num3 = vector3.x - vector.x;
			float num4 = p2.y - p1.y;
			nint num5 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
			float[] array = ts;
			int num6 = 1;
			int num7 = 0;
			global::UnityEngine.Rigidbody2D rigidbody2D2 = default(global::UnityEngine.Rigidbody2D);
			global::UnityEngine.Rigidbody2D rigidbody2D = rigidbody2D2;
			global::UnityEngine.Vector3 vector4 = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector3 pos = default(global::UnityEngine.Vector3);
			global::UnityEngine.Vector2 localAnchor = default(global::UnityEngine.Vector2);
			global::UnityEngine.Vector2 targetAnchor = default(global::UnityEngine.Vector2);
			while (true)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4421]");
				if ((nint)0 != 0)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X25_v4 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
					object obj = 0;
				}
				else
				{
					_ = 1;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v259 @ X25_v4 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
					object obj = 0;
				}
				float num8 = 1f - ts[num7];
				float num9 = num * num8;
				float num10 = num2 * num8;
				float num11 = num3 * ts[num7];
				float num12 = num4 * ts[num7];
				float num13 = num11 + num9;
				float num14 = num12 + num10;
				float num15 = num13 + num13;
				float num16 = num14 + num14;
				float num17 = num15 * num15;
				float num18 = num16 * num16;
				float f = num17 + num18;
				float num19 = global::UnityEngine.Mathf.Sqrt(f);
				float num21;
				if (num19 > 1E-05f)
				{
					float num20 = num15 / num19;
					num21 = num16 / num19;
				}
				else
				{
					nint num22 = (nint)typeof(global::System.Xml.ValidateNames);
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v508 @ X8_v47 (Il2CppClass<System.Xml.ValidateNames>)+98]");
					object obj2 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v510 @ X8_v49+B8]");
					object obj3 = 0;
					float num20 = (float)obj3;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v482 @ X8_v50+4]");
					num21 = 0f;
				}
				float num23 = num8 * num8;
				float num24 = vector2.x * num23;
				float num25 = p0.y * num23;
				float num26 = num8 + num8;
				float num27 = ts[num7] * num26;
				float num28 = vector.x * num27;
				float num29 = p1.y * num27;
				float num30 = num24 + num28;
				float num31 = num25 + num29;
				float num32 = ts[num7] * ts[num7];
				float num33 = vector3.x * num32;
				float num34 = p2.y * num32;
				float x = num33 + num30;
				float y = num34 + num31;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @274A290");
				float num35 = num21 * 57.29578f;
				float num36 = num35 + 90f;
				float z = num36 * ((float)global::System.Math.PI / 180f);
				vector4.x = 0f;
				vector4.y = 0f;
				vector4.z = z;
				global::UnityEngine.Quaternion rot = global::UnityEngine.Quaternion.Euler(vector4 * 57.29578f);
				pos.x = x;
				pos.y = y;
				pos.z = 0f;
				global::UnityEngine.Rigidbody2D rigidbody2D3 = CreateLink(pos, rot, num7);
				float y2;
				global::UnityEngine.Vector2 vector5;
				Chain chain;
				if ((num6 & 1) == 0)
				{
					y2 = anchorOffset * -0.5f;
					vector5 = default(global::UnityEngine.Vector2);
					chain = (Chain)(object)rigidbody2D3;
				}
				else
				{
					nint num37 = (nint)typeof(global::System.Xml.ValidateNames);
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v553 @ X8_v40 (Il2CppClass<System.Xml.ValidateNames>)+98]");
					object obj4 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v555 @ X8_v42+B8]");
					object obj5 = 0;
					vector5 = (global::UnityEngine.Vector2)obj5;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v556 @ X8_v43+4]");
					y2 = 0f;
					chain = (Chain)(object)rigidbody2D3;
				}
				localAnchor.x = 0f;
				localAnchor.y = anchorOffset;
				targetAnchor.x = vector5.x;
				targetAnchor.y = y2;
				chain.ConnectRope(rigidbody2D3, rigidbody2D, localAnchor, targetAnchor);
				global::System.Collections.Generic.List<global::UnityEngine.Rigidbody2D> links = _links;
				nint num38 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v562 @ X8_v30 (Il2CppMethodInfo)+60]");
				object obj6 = 0;
				int version = links._version + 1;
				links._version = version;
				global::UnityEngine.Rigidbody2D[] items = links._items;
				float w;
				if (links.Count >= items.Length)
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v234 @ X8_v32+20]");
					object obj7 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v578 @ X8_v35+C0]");
					object obj8 = 0;
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v579 @ X8_v36+70]");
					rigidbody2D2 = (global::UnityEngine.Rigidbody2D)0;
					links.Add(rigidbody2D3);
					num7++;
					bool flag = num7 >= ts.Length;
					w = rot.w;
					array = (float[])(object)rigidbody2D3;
					num6 = 0;
					rigidbody2D = rigidbody2D3;
					if (flag)
					{
						break;
					}
					continue;
				}
				int size = links.Count + 1;
				links._size = size;
				int num39 = links.Count << 3;
				object obj9 = (nint)items + num39;
				object obj10 = (nint)obj9 + 32;
				obj10 = rigidbody2D3;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
				num7++;
				bool flag2 = num7 < ts.Length;
				w = rot.w;
				array = (float[])(object)rigidbody2D3;
				rigidbody2D2 = rigidbody2D;
				num6 = 0;
				rigidbody2D = rigidbody2D3;
				if (!flag2)
				{
					break;
				}
			}
		}
		global::System.Collections.Generic.List<global::UnityEngine.Rigidbody2D> links2 = _links;
		int index = links2.Count - 1;
		global::UnityEngine.Rigidbody2D rigidbody2D4 = links2[index];
		float y3 = anchorOffset * -0.5f;
		nint num40 = (nint)typeof(global::System.Xml.ValidateNames);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v462 @ X8_v10 (Il2CppClass<System.Xml.ValidateNames>)+98]");
		object obj11 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v464 @ X8_v12+B8]");
		object obj12 = 0;
		global::UnityEngine.Vector2 localAnchor2 = default(global::UnityEngine.Vector2);
		localAnchor2.x = 0f;
		localAnchor2.y = y3;
		global::UnityEngine.Vector2 targetAnchor2 = default(global::UnityEngine.Vector2);
		targetAnchor2.x = (float)obj12;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v401 @ X8_v13+4]");
		targetAnchor2.y = 0f;
		((Chain)(object)rigidbody2D4).ConnectRope(rigidbody2D4, rbEnd, localAnchor2, targetAnchor2);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600018B")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEAE84", Offset = "0xFEAE84", Length = "0x108")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0023;\n\tv39 = Il2CppMethodInfo;\n\tv40 = v39 + 0x908;\n\tv41 = \"il2cpp_codegen_initialize_runtime_metadata\"(v40, rb, target, methodInfo, v43, v44, v45, v46, localAnchor, v0, targetAnchor, v2, v47, v48, v49, v50);\n\tv54 = 1;\n\t*([302A97F]) = v54;\nL_0023:\n\tv58 = UnityEngine.Component::get_gameObject(rb);\n\tv69 = Il2CppMethodInfo;\n\tv62 = UnityEngine.GameObject::AddComponent /* +1 sharing this address */(v58, *([v69 @ X8_v4 (Il2CppMethodInfo)+908]));\n\tUnityEngine.AnchoredJoint2D::set_autoConfigureConnectedAnchor(v62, 0);\n\tUnityEngine.AnchoredJoint2D::set_anchor(v62, localAnchor);\n\tUnityEngine.Joint2D::set_connectedBody(v62, target);\n\tUnityEngine.AnchoredJoint2D::set_connectedAnchor(v62, targetAnchor);\n\tUnityEngine.DistanceJoint2D::set_autoConfigureDistance(v62, 1);\n\tUnityEngine.DistanceJoint2D::set_maxDistanceOnly(v62, 1);\n\tUnityEngine.Joint2D::set_enableCollision(v62, 0);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 71 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void ConnectRope(global::UnityEngine.Rigidbody2D rb, global::UnityEngine.Rigidbody2D target, global::UnityEngine.Vector2 localAnchor, global::UnityEngine.Vector2 targetAnchor)
	{
		global::UnityEngine.GameObject gameObject = rb.gameObject;
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @11481F4 (UnityEngine.GameObject::AddComponent, and 1 more at this address)");
		global::UnityEngine.AnchoredJoint2D anchoredJoint2D = default(global::UnityEngine.AnchoredJoint2D);
		anchoredJoint2D.autoConfigureConnectedAnchor = false;
		anchoredJoint2D.anchor = localAnchor;
		anchoredJoint2D.connectedBody = target;
		anchoredJoint2D.connectedAnchor = targetAnchor;
		((global::UnityEngine.DistanceJoint2D)anchoredJoint2D).autoConfigureDistance = true;
		((global::UnityEngine.DistanceJoint2D)anchoredJoint2D).maxDistanceOnly = true;
		anchoredJoint2D.enableCollision = false;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600018C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEAC98", Offset = "0xFEAC98", Length = "0x44")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv7 = 1f - t;\n\tv9 = v7 * v7;\n\tv10 = a * v9;\n\tv12 = v7 + v7;\n\tv13 = v12 * t;\n\tv14 = b * v13;\n\tv16 = v10 + v14;\n\tv18 = t * t;\n\tv19 = c * v18;\n\treturnVal1 = v19 + v16;\n\treturn returnVal1;\n// 9 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private static global::UnityEngine.Vector2 Bezier(global::UnityEngine.Vector2 a, global::UnityEngine.Vector2 b, global::UnityEngine.Vector2 c, float t)
	{
		float num = 1f - t;
		float num2 = num * num;
		global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
		float num3 = vector.x * num2;
		float num4 = num + num;
		float num5 = num4 * t;
		global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
		float num6 = vector2.x * num5;
		float num7 = num3 + num6;
		float num8 = t * t;
		global::UnityEngine.Vector2 vector3 = default(global::UnityEngine.Vector2);
		float num9 = vector3.x * num8;
		float x = num9 + num7;
		global::UnityEngine.Vector2 result = default(global::UnityEngine.Vector2);
		result.x = x;
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600018D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEACDC", Offset = "0xFEACDC", Length = "0x3C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv6 = b - a;\n\tv9 = 1f - t;\n\tv11 = v6 * v9;\n\tv13 = c - b;\n\tv15 = v13 * t;\n\tv17 = v11 + v15;\n\treturnVal1 = v17 + v17;\n\treturn returnVal1;\n// 10 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private static global::UnityEngine.Vector2 BezierDeriv(global::UnityEngine.Vector2 a, global::UnityEngine.Vector2 b, global::UnityEngine.Vector2 c, float t)
	{
		global::UnityEngine.Vector2 vector = default(global::UnityEngine.Vector2);
		global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
		float num = vector.x - vector2.x;
		float num2 = 1f - t;
		float num3 = num * num2;
		global::UnityEngine.Vector2 vector3 = default(global::UnityEngine.Vector2);
		float num4 = vector3.x - vector.x;
		float num5 = num4 * t;
		float num6 = num3 + num5;
		float x = num6 + num6;
		global::UnityEngine.Vector2 result = default(global::UnityEngine.Vector2);
		result.x = x;
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600018E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEA290", Offset = "0xFEA290", Length = "0x158")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv49 = n < 1;\n\tif (v49) goto L_FFFFFFFF;\n\tv57 = 1f / n;\n\tv91 = *([2DD4425]);\n\tgoto L_005D;\nL_0033:\n\tv188 = v57 * v88;\n\tv190 = 1f - v188;\n\tv191 = v190 * v190;\n\tv192 = a * v191;\n\tv193 = a.y * v191;\n\tv194 = v190 + v190;\n\tv195 = v188 * v194;\n\tv196 = b * v195;\n\tv197 = b.y * v195;\n\tv198 = v192 + v196;\n\tv199 = v193 + v197;\n\tv200 = v188 * v188;\n\tv202 = c * v200;\n\tv203 = c.y * v200;\n\tv81 = v202 + v198;\n\tv93 = v203 + v199;\n\tv204 = v82 - v93;\n\tv205 = v84 - v81;\n\tv113 = v205 * v205;\n\tv206 = v204 * v204;\n\tv207 = v113 + v206;\n\tv115 = UnityEngine.Mathf::Sqrt(v207);\n\tv86 = v86 + v115;\n\tv88 = v88 + 1;\n\tv95 = v88 > n;\n\tif (v95) goto L_0082;\nL_005D:\n\tv116 = v91 == 0;\n\tif (v116) goto L_0068;\n\tgoto L_0033;\n\tgoto L_006F;\nL_0068:\n\t*([2DD4425]) = 1;\n\tgoto L_0033;\nL_006F:\n\tv186 = *([2DD4425]);\n\tgoto L_0033;\nL_0082:\n\treturn v126;\n// 91 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private static float ApproxQuadLen(global::UnityEngine.Vector2 a, global::UnityEngine.Vector2 b, global::UnityEngine.Vector2 c, int n = 16)
	{
		//IL_0212: Expected O, but got F4
		float result;
		if (n >= 1)
		{
			float num = 1f / (float)n;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4425]");
			int num2 = 0;
			float num3 = a.y;
			global::UnityEngine.Vector2 vector = a;
			float num4 = 0f;
			int num5 = 1;
			global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
			global::UnityEngine.Vector2 vector3 = default(global::UnityEngine.Vector2);
			global::UnityEngine.Vector2 vector4 = default(global::UnityEngine.Vector2);
			bool flag;
			do
			{
				if (num2 == 0)
				{
					_ = 1;
					num2 = 1;
				}
				float num6 = num * (float)num5;
				float num7 = 1f - num6;
				float num8 = num7 * num7;
				float num9 = vector2.x * num8;
				float num10 = a.y * num8;
				float num11 = num7 + num7;
				float num12 = num6 * num11;
				float num13 = vector3.x * num12;
				float num14 = b.y * num12;
				float num15 = num9 + num13;
				float num16 = num10 + num14;
				float num17 = num6 * num6;
				float num18 = vector4.x * num17;
				float num19 = c.y * num17;
				float num20 = num18 + num15;
				float num21 = num19 + num16;
				float num22 = num3 - num21;
				float num23 = vector.x - num20;
				float num24 = num23 * num23;
				float num25 = num22 * num22;
				float f = num24 + num25;
				float num26 = global::UnityEngine.Mathf.Sqrt(f);
				num4 += num26;
				num5++;
				flag = num5 > n;
				num3 = num21;
				vector = (global::UnityEngine.Vector2)num20;
				result = num4;
			}
			while (!flag);
		}
		else
		{
			result = 0f;
		}
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600018F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEA3E8", Offset = "0xFEA3E8", Length = "0x4C4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv453 = b.y;\n\tv58 = CollectParticleData[];\n\tgoto L_002E;\n\tv63 = CollectParticleData[];\n\tv64 = v63 + 0x4B8;\n\tv65 = \"il2cpp_codegen_initialize_runtime_metadata\"(v64, table, methodInfo, v67, v68, v69, v70, v71, a, v0, b, v2, c, v4, bezLen, v72);\n\tv75 = 1;\n\t*([302A980]) = v75;\nL_002E:\n\tv77 = table + 1;\n\tv78 = \"SzArrayNew\"(*([v58 @ X24_v1 (Il2CppClass<CollectParticleData[]>)+4B8]), v77, methodInfo, v67, v68, v69, v70, v71, a, a.y, b, b.y, v301, v301.y, bezLen, v72);\n\tv208 = 1f / table;\n\tv205 = v78 + 0x20;\n\t*([v205 @ X23_v4]) = 0;\n\tv249 = table < 1;\n\tif (v249) goto L_00AA;\n\tv504 = *([2DD4425]);\n\tv468 = Facebook.Unity.Windows.IWindowsFacebook;\nL_0051:\n\tv644 = v504 == 0;\n\tif (v644) goto L_0067;\n\tv657 = *([v468 @ X22_v7 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv659 = *([v657 @ X0_v21+E0]) == 0;\n\tif (v659) goto L_006E;\nL_0058:\n\tv709 = v324 < *([v78 @ X0_v3+18]);\n\tv421 = ~v709;\n\tv329 = ~v421;\n\tif (v329) goto L_007B;\n\tgoto L_0192;\nL_0067:\n\t*([2DD4425]) = 1;\n\tv706 = *([v468 @ X22_v7 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]);\n\tv713 = *([v706 @ X0_v19+E0]) == 0;\n\tv707 = ~v713;\n\tif (v707) goto L_0058;\nL_006E:\n\tv504 = *([2DD4425]);\nL_007B:\n\tv749 = v208 * v324;\n\tv751 = 1f - v749;\n\tv752 = v751 * v751;\n\tv753 = a * v752;\n\tv754 = a.y * v752;\n\tv755 = v751 + v751;\n\tv756 = v749 * v755;\n\tv757 = b * v756;\n\tv758 = v453 * v756;\n\tv759 = v753 + v757;\n\tv760 = v754 + v758;\n\tv761 = v749 * v749;\n\tv763 = v301 * v761;\n\tv764 = v301.y * v761;\n\tv473 = v763 + v759;\n\tv498 = v764 + v760;\n\tv765 = v320 - v473;\n\tv766 = v765 * v765;\n\tv767 = v318 - v498;\n\tv231 = v767 * v767;\n\tv768 = v766 + v231;\n\tv507 = UnityEngine.Mathf::Sqrt(v768);\n\tv448 = v448 + v507;\n\tv471 = v324 << 2;\n\tv475 = v78 + v471;\n\t*([v475 @ X9_v12+20]) = v448;\n\tv324 = v324 + 1;\n\tv480 = v324 <= table;\n\tif (v480) goto L_0051;\nL_00AA:\n\treturnVal2 = \"SzArrayNew\"(*([v58 @ X24_v1 (Il2CppClass<CollectParticleData[]>)+4B8]), linkCount, methodInfo, v67, v68, v69, v70, v71, v497, v507, v146, v231, v305, v301.y, bezLen, v72);\n\tv655 = linkCount < 1;\n\tif (v655) goto L_028E;\n\tv662 = linkCount + 1;\n\tv211 = bezLen / v662;\n\tv510 = table < 2;\n\tif (v510) goto L_01A2;\n\tv714 = *([v78 @ X0_v3+18]) < 1;\n\tv715 = ~v714;\n\tv716 = *([v78 @ X0_v3+18]) - 1;\n\tv718 = v716 == 0;\n\tv723 = ~v718;\n\tv724 = v715 & v723;\n\tv132 = ~v724;\n\tif (v132) goto L_00DB;\n\tgoto L_00DB;\nL_00DB:\n\tv104 = table - 1;\n\tv218 = returnVal2 == 0;\n\tif (v218) goto L_028F;\n\tv283 = v78 + 0x24;\n\tgoto L_0115;\nL_00F1:\n\tv674 = v208 * v261;\n\tv1143 = v208 * v278;\n\tv702 = v1143 - v674;\n\tv671 = v1166 >= 0;\n\tif (v671) goto L_0104;\n\tgoto L_0104;\nL_0104:\n\tv1167 = v702 * v1166;\n\tv703 = v674 + v1167;\n\treturnVal2[v268 @ X10_v20 (System.Int32)] = v703;\n\tv691 = v276 == linkCount;\n\tif (v691) goto L_028E;\nL_0115:\n\tv276 = v268 + 1;\n\tv457 = v211 * v276;\nL_0122:\n\tv305 = *([v283 @ X12_v17+v279 @ X16_v7 (System.Int32)*4]);\n\tv979 = *([v283 @ X12_v17+v279 @ X16_v7 (System.Int32)*4]) >= v457;\n\tif (v979) goto L_013C;\n\tv279 = v279 + 1;\n\tv914 = v104 != v279;\n\tif (v914) goto L_0122;\n\tgoto L_013D;\nL_013C:\n\tv278 = v279 + 1;\nL_013D:\n\tv261 = v278 - 1;\n\tv1100 = v261 << 2;\n\tv1101 = v78 + v1100;\n\tv297 = v278 << 2;\n\tv1102 = v78 + v297;\n\tv1107 = *([v1101 @ X1_v8+20]) == *([v1102 @ X1_v9+20]);\n\tif (v1107) goto L_FFFFFFFF;\n\tv1112 = v457 - *([v1101 @ X1_v8+20]);\n\tv1113 = *([v1102 @ X1_v9+20]) - *([v1101 @ X1_v8+20]);\n\tv1114 = v1112 / v1113;\n\tv1117 = v1114 - 1f;\n\tv1118 = v1117 < 0;\n\tv1119 = v1117 == 0;\n\tv1120 = v1114 ^ 1f;\n\tv1121 = v1114 ^ v1117;\n\tv1122 = v1120 & v1121;\n\tv1123 = v1122 < 0;\n\tv1124 = v1118 == v1123;\n\tv272 = ~v1119;\n\tv1125 = v1124 & v272;\n\tv1126 = ~v1125;\n\tif (v1126) goto L_FFFFFFFF;\n\tgoto L_0180;\nL_0180:\n\tv289 = v1114 >= 0;\n\tif (v289) goto L_FFFFFFFF;\n\tgoto L_0187;\nL_0187:\n\tv1170 = v268 < returnVal2.Length;\n\tv420 = ~v1170;\n\tv328 = ~v420;\n\tif (v328) goto L_00F1;\nL_0192:\n\tv216 = new System.IndexOutOfRangeException();\nL_01A2:\n\tv463 = v208 * 0;\n\tv311 = v208 - v463;\n\tv779 = linkCount - 1;\n\tv727 = v779 < v216._message;\n\tv728 = ~v727;\n\tv736 = ~v728;\n\tv737 = ~v736;\n\tif (v737) goto L_FFFFFFFF;\n\tgoto L_01B7;\nL_01B7:\n\tv780 = v779 < 4;\n\tv781 = ~v780;\n\tv789 = ~v781;\n\tif (v789) goto L_FFFFFFFF;\n\tv1047 = v216 + 0x20;\n\tv791 = v78 + 0x28;\n\tv792 = v1047 < v791;\n\tv793 = ~v792;\n\tif (v793) goto L_01DD;\n\tv805 = v779 << 2;\n\tv857 = v216 + v805;\n\tv803 = v857 + 0x24;\n\tv858 = v205 < v803;\n\tv821 = ~v858;\n\tif (v821) goto L_01DD;\n\tgoto L_021B;\nL_01DD:\n\tv869 = v779 + 1;\n\tv982 = v869 & 3;\n\tv872 = v982 == 0;\n\tv876 = ~v872;\n\tif (v876) goto L_01EA;\n\tgoto L_01EA;\nL_01EA:\n\tv270 = v869 - v982;\n\t// 491 NotImplemented \"Instruction DUP not yet implemented.\"\n\t// 493 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\t// 495 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\tv912 = v985 - v305;\n\t// 501 NotImplemented \"Instruction FCMEQ not yet implemented.\"\nL_01F9:\n\t// 505 NotImplemented \"Instruction UZP1 not yet implemented.\"\n\tv1060 = v1044 + 1;\n\t// 507 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\tv1061 = v1060 * v1062;\n\tv1063 = v1061 - v305;\n\tv1064 = v1063 / v912;\n\t// 511 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\t// 512 NotImplemented \"Instruction FCMGT not yet implemented.\"\n\t// 513 NotImplemented \"Instruction BIT not yet implemented.\"\n\tv1043 = v985 | v1043;\n\tv1065 = ~v1043;\n\tv1066 = v1064 & v1065;\n\t// 517 NotImplemented \"Instruction UNIMPLEMENTED not yet implemented.\"\n\tv910 = ~v1043;\n\tv1067 = v1066 & v910;\n\tv1068 = v1067 * v1069;\n\tv1044 = v231 + v1068;\n\t*([v1047 @ X11_v8]) = v1044;\n\tv1047 = v1047 + 0x10;\n\t// 524 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv890 = v1048 - 4;\n\tv893 = v1048 != 4;\n\tif (v893) goto L_01F9;\nL_021B:\n\tv266 = v216 + 0x20;\nL_021E:\n\t;\n\tv964 = *([v78 @ X0_v3+20]) == *([v78 @ X0_v3+24]);\n\tif (v964) goto L_0265;\n\tv991 = v270 + 1;\n\tv993 = v211 * v991;\n\tv994 = v993 - *([v78 @ X0_v3+20]);\n\tv995 = *([v78 @ X0_v3+24]) - *([v78 @ X0_v3+20]);\n\tv996 = v994 / v995;\n\tv999 = v996 - 1f;\n\tv1000 = v999 < 0;\n\tv1001 = v999 == 0;\n\tv1002 = v996 ^ 1f;\n\tv1003 = v996 ^ v999;\n\tv1004 = v1002 & v1003;\n\tv1005 = v1004 < 0;\n\tv1006 = v1000 == v1005;\n\tv1007 = ~v1001;\n\tv1008 = v1006 & v1007;\n\tv1009 = ~v1008;\n\tif (v1009) goto L_FFFFFFFF;\n\tgoto L_024C;\nL_024C:\n\tv1011 = v996 >= 0;\n\tif (v1011) goto L_FFFFFFFF;\n\tgoto L_0265;\nL_0265:\n\tv670 = v1097 >= 0;\n\tif (v670) goto L_026B;\n\tgoto L_026B;\nL_026B:\n\tv1098 = v311 * v1097;\n\tv701 = v463 + v1098;\n\t*([v266 @ X11_v5+v270 @ X10_v7 (System.Int32)*4]) = v701;\n\tv669 = v270 + 1;\n\tv680 = linkCount != v669;\n\tif (v680) goto L_021E;\nL_028E:\n\treturn returnVal2;\nL_028F:\n\tv124 = v78 + 0x24;\nL_02A5:\n\tv941 = *([v124 @ X12_v16+v269 @ X10_v16 (System.Int32)*4]) >= v211;\n\tif (v941) goto L_02CA;\n\tv269 = v269 + 1;\n\tv839 = v104 != v269;\n\tif (v839) goto L_02A5;\n\tgoto L_02CA;\nL_02CA:\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 477 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private static float[] EvenTByArc(global::UnityEngine.Vector2 a, global::UnityEngine.Vector2 b, global::UnityEngine.Vector2 c, int linkCount, float bezLen, int table = 60)
	{
		//IL_001b: Expected I, but got O
		//IL_0040: Expected O, but got I
		//IL_0049: Expected O, but got I4
		//IL_00b2: Expected I, but got O
		//IL_0175: Expected O, but got I
		//IL_0832: Expected I4, but got O
		//IL_0467: Expected O, but got I
		//IL_00ee: Expected O, but got I
		//IL_0356: Expected O, but got I
		//IL_0387: Expected O, but got F4
		//IL_038f: Expected O, but got F4
		//IL_0397: Expected I4, but got F4
		//IL_03a7: Expected O, but got F4
		//IL_0ac7: Expected O, but got I
		//IL_093d: Expected O, but got I
		//IL_0846: Expected O, but got I
		//IL_0855: Expected O, but got I
		//IL_04bb: Expected O, but got I
		//IL_0794: Expected O, but got F4
		//IL_0898: Expected O, but got I
		//IL_08a7: Expected O, but got I
		//IL_0572: Expected O, but got I
		//IL_0994: Expected O, but got I
		//IL_09e3: Expected O, but got F4
		//IL_09f0: Expected O, but got F4
		//IL_0e2d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e32: Expected I4, but got Unknown
		//IL_0e60: Expected O, but got I
		//IL_0e77: Expected O, but got F4
		//IL_0e86: Expected O, but got I
		//IL_0604: Expected O, but got I
		//IL_0621: Expected O, but got I
		//IL_06d3: Expected O, but got F4
		//IL_06e0: Expected O, but got F4
		//IL_0bf0: Expected O, but got F4
		float num = b.y;
		nint num2 = (nint)typeof(CollectParticleData[]);
		int num3 = table + 1;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		float num4 = 1f / (float)table;
		object obj2 = default(object);
		object obj = (nint)obj2 + 32;
		obj = 0;
		bool flag = table < 1;
		global::UnityEngine.Vector2 vector2 = default(global::UnityEngine.Vector2);
		global::UnityEngine.Vector2 vector = vector2;
		global::UnityEngine.Vector2 vector3 = b;
		int num5 = table;
		float num6 = b.y;
		float num7 = 1f;
		if (flag)
		{
			goto IL_03b5;
		}
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4425]");
		int num8 = 0;
		nint num9 = (nint)typeof(global::Facebook.Unity.Windows.IWindowsFacebook);
		float num10 = a.y;
		global::UnityEngine.Vector2 vector4 = a;
		int num11 = 1;
		float num12 = 0f;
		global::UnityEngine.Vector2 vector5 = default(global::UnityEngine.Vector2);
		global::UnityEngine.Vector2 vector6 = default(global::UnityEngine.Vector2);
		while (true)
		{
			if (num8 != 0)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X22_v7 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
				object obj3 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v657 @ X0_v21+E0]");
				if ((nint)0 != 0)
				{
					goto IL_0113;
				}
			}
			else
			{
				_ = 1;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v468 @ X22_v7 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+918]");
				object obj4 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v706 @ X0_v19+E0]");
				bool flag2 = (nint)0 == 0;
				bool flag3 = !flag2;
				num8 = 1;
				if (flag3)
				{
					goto IL_0113;
				}
			}
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [2DD4425]");
			num8 = 0;
			goto IL_01c3;
			IL_0113:
			int num13 = num11;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
			if ((nint)num13 >= (nint)0)
			{
				break;
			}
			goto IL_01c3;
			IL_01c3:
			float num14 = num4 * (float)num11;
			float num15 = 1f - num14;
			float num16 = num15 * num15;
			float num17 = vector5.x * num16;
			float num18 = a.y * num16;
			float num19 = num15 + num15;
			float num20 = num14 * num19;
			float num21 = vector6.x * num20;
			float num22 = num * num20;
			float num23 = num17 + num21;
			float num24 = num18 + num22;
			float num25 = num14 * num14;
			float num26 = vector2.x * num25;
			float num27 = vector2.y * num25;
			float num28 = num26 + num23;
			float num29 = num27 + num24;
			float num30 = vector4.x - num28;
			float num31 = num30 * num30;
			float num32 = num10 - num29;
			num6 = num32 * num32;
			float f = num31 + num6;
			num7 = global::UnityEngine.Mathf.Sqrt(f);
			num12 += num7;
			int num33 = num11 << 2;
			object obj5 = (nint)obj2 + num33;
			num11++;
			bool flag4 = num11 <= table;
			vector = (global::UnityEngine.Vector2)vector2.y;
			vector3 = (global::UnityEngine.Vector2)num28;
			num5 = (int)num29;
			num10 = num29;
			vector4 = (global::UnityEngine.Vector2)num28;
			if (flag4)
			{
				continue;
			}
			goto IL_03b5;
		}
		float num34 = vector5.x;
		goto IL_0773;
		IL_092e:
		global::System.IndexOutOfRangeException ex;
		object obj6 = (nint)ex + 32;
		int num38;
		float num48;
		float num50;
		bool flag11;
		float[] array = default(float[]);
		do
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+20]");
			nint num35 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+24]");
			bool flag5 = num35 == 0;
			float num36 = 0f;
			if (!flag5)
			{
				int num37 = num38 + 1;
				float num39 = num34 * (float)num37;
				float num40 = num39;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+20]");
				float num41 = num40 - 0f;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+24]");
				nint num42 = 0;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+20]");
				object obj7 = num42 - 0;
				float num43 = num41 / (float)obj7;
				float num44 = num43 - 1f;
				bool flag6 = num44 < 0f;
				bool flag7 = num44 == 0f;
				object obj8 = num43 ^ 1f;
				object obj9 = num43 ^ num44;
				int num45 = (int)((nint)obj8 & (nint)obj9);
				bool flag8 = num45 < 0;
				bool flag9 = flag6 == flag8;
				bool flag10 = !flag7;
				float num46 = ((!(flag9 && flag10)) ? num43 : 1f);
				num36 = ((!(num43 < 0f)) ? num46 : 0f);
			}
			if (num36 < 0f)
			{
				num36 = 0f;
			}
			float num47 = num48 * num36;
			float num49 = num50 + num47;
			int num51 = num38 + 1;
			flag11 = linkCount != num51;
			array = (float[])(object)ex;
			num38 = num51;
		}
		while (flag11);
		goto IL_0ab3;
		IL_03b5:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unknown call target operand: \"SzArrayNew\"");
		int num54 = default(int);
		float num56 = default(float);
		float num75 = default(float);
		int num53;
		float num55;
		if (linkCount >= 1)
		{
			int num52 = linkCount + 1;
			num34 = bezLen / (float)num52;
			bool flag12 = table < 2;
			num53 = num54;
			num55 = num56;
			ex = (global::System.IndexOutOfRangeException)(object)array;
			if (!flag12)
			{
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
				bool flag13 = (nint)0 < (nint)1;
				bool flag14 = !flag13;
				global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v78 @ X0_v3+18]");
				object obj10 = -1;
				bool flag15 = obj10 == null;
				bool flag16 = !flag15;
				if (flag14 && flag16)
				{
				}
				int num57 = table - 1;
				if (array != null)
				{
					object obj11 = (nint)obj2 + 36;
					int num58 = 0;
					while (true)
					{
						int num59 = num58 + 1;
						float num60 = num34 * (float)num59;
						int num61 = 0;
						int num62;
						while (true)
						{
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X12_v17+v279 @ X16_v7 (System.Int32)*4]");
							vector = (global::UnityEngine.Vector2)0;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v283 @ X12_v17+v279 @ X16_v7 (System.Int32)*4]");
							if (0f < num60)
							{
								num61++;
								if (num57 == num61)
								{
									num62 = table;
									break;
								}
								continue;
							}
							num62 = num61 + 1;
							break;
						}
						int num63 = num62 - 1;
						int num64 = num63 << 2;
						object obj12 = (nint)obj2 + num64;
						int num65 = num62 << 2;
						object obj13 = (nint)obj2 + num65;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X1_v8+20]");
						nint num66 = 0;
						global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ X1_v9+20]");
						float num67;
						if (num66 == 0)
						{
							num67 = 0f;
						}
						else
						{
							float num68 = num60;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X1_v8+20]");
							float num69 = num68 - 0f;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1102 @ X1_v9+20]");
							float num70 = 0f;
							global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v1101 @ X1_v8+20]");
							float num71 = num70 - 0f;
							float num72 = num69 / num71;
							float num73 = num72 - 1f;
							bool flag17 = num73 < 0f;
							bool flag18 = num73 == 0f;
							object obj14 = num72 ^ 1f;
							object obj15 = num72 ^ num73;
							int num74 = (int)((nint)obj14 & (nint)obj15);
							bool flag19 = num74 < 0;
							bool flag20 = flag17 == flag19;
							bool flag21 = !flag18;
							num75 = ((!(flag20 && flag21)) ? num72 : 1f);
							num67 = ((!(num72 < 0f)) ? num75 : 0f);
							bool flag22 = num58 < array.Length;
							bool flag23 = !flag22;
							bool flag24 = !flag23;
							num = num67;
							if (!flag24)
							{
								break;
							}
						}
						float num76 = num4 * (float)num63;
						float num77 = num4 * (float)num62;
						float num78 = num77 - num76;
						if (num67 < 0f)
						{
							num67 = 0f;
						}
						float num79 = num78 * num67;
						float num80 = num76 + num79;
						array[num58] = num80;
						bool flag25 = num59 == linkCount;
						num58 = num59;
						vector = (global::UnityEngine.Vector2)num76;
						if (!flag25)
						{
							continue;
						}
						goto IL_0ab3;
					}
					goto IL_0773;
				}
				object obj16 = (nint)obj2 + 36;
				int num81 = 0;
				do
				{
					global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v124 @ X12_v16+v269 @ X10_v16 (System.Int32)*4]");
					if (!(0f < num34))
					{
						break;
					}
					num81++;
				}
				while (num57 != num81);
				return (float[])(object)new global::System.NullReferenceException();
			}
			goto IL_07b1;
		}
		goto IL_0ab3;
		IL_07b1:
		num50 = num4 * 0f;
		num48 = num4 - num50;
		int num82 = linkCount - 1;
		if (num82 >= (nint)((global::System.Exception)ex)._message)
		{
			num82 = (int)((global::System.Exception)ex)._message;
		}
		if (num82 < 4)
		{
			goto IL_08ce;
		}
		object obj17 = (nint)ex + 32;
		object obj18 = (nint)obj2 + 40;
		if (global::System.Runtime.CompilerServices.Unsafe.As<object, global::System.UIntPtr>(ref obj17) < global::System.Runtime.CompilerServices.Unsafe.As<object, global::System.UIntPtr>(ref obj18))
		{
			int num83 = num82 << 2;
			object obj19 = (nint)ex + num83;
			object obj20 = (nint)obj19 + 36;
			if (global::System.Runtime.CompilerServices.Unsafe.As<object, global::System.UIntPtr>(ref obj) < global::System.Runtime.CompilerServices.Unsafe.As<object, global::System.UIntPtr>(ref obj20))
			{
				goto IL_08ce;
			}
		}
		int num84 = num82 + 1;
		int num85 = num84 & 3;
		if (num85 == 0)
		{
			num85 = 4;
		}
		num38 = num84 - num85;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
		object obj21 = default(object);
		float num86 = (float)obj21 - vector.x;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMEQ not yet implemented.\"");
		int num87 = num38;
		num53 = num54;
		num55 = num56;
		object obj22 = default(object);
		obj17 = obj22;
		int num88 = default(int);
		num87 = num88;
		object obj23 = default(object);
		object obj25 = default(object);
		bool flag26;
		do
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UZP1 not yet implemented.\"");
			float num89 = num55 + float.Epsilon;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			float num90 = num89 * (float)obj23;
			float num91 = num90 - vector.x;
			float num92 = num91 / num86;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction FCMGT not yet implemented.\"");
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction BIT not yet implemented.\"");
			num53 = (int)((nint)obj21 | num53);
			int num93 = ~num53;
			int num94 = num92 & num93;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction UNIMPLEMENTED not yet implemented.\"");
			int num95 = ~num53;
			int num96 = num94 & num95;
			object obj24 = num96 * (nint)obj25;
			num55 = num6 + (float)obj24;
			obj17 = num55;
			obj17 = (nint)obj17 + 16;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Not implemented instruction: \"Instruction DUP not yet implemented.\"");
			int num97 = num87 - 4;
			flag26 = num87 != 4;
			num87 = num97;
		}
		while (flag26);
		goto IL_092e;
		IL_0ab3:
		return array;
		IL_0773:
		ex = new global::System.IndexOutOfRangeException();
		num53 = num54;
		num55 = num56;
		vector = (global::UnityEngine.Vector2)num75;
		obj = obj;
		num4 = num4;
		num6 = num;
		goto IL_07b1;
		IL_08ce:
		num38 = 0;
		goto IL_092e;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000190")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEAD18", Offset = "0xFEAD18", Length = "0x16C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0033;\n\tv59 = Il2CppMethodInfo;\n\tv60 = v59 + 0x788;\n\tv61 = \"il2cpp_codegen_initialize_runtime_metadata\"(v60, i, methodInfo, v63, v64, v65, v66, v67, pos, v0, v2, rot, v3, v5, v6, v68);\n\tv79 = Il2CppMethodInfo;\n\tv80 = v79 + 0x118;\n\tv81 = \"il2cpp_codegen_initialize_runtime_metadata\"(v80, i, methodInfo, v63, v64, v65, v66, v67, pos, v0, v2, rot, v3, v5, v6, v68);\n\tv87 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv88 = v87 + 0xFD8;\n\tv70 = \"il2cpp_codegen_initialize_runtime_metadata\"(v88, i, methodInfo, v63, v64, v65, v66, v67, pos, v0, v2, rot, v3, v5, v6, v68);\n\tv72 = 1;\n\t*([302A981]) = v72;\nL_0033:\n\tv73 = Il2CppMethodInfo;\n\tv78 = UnityEngine.Component::get_transform(this);\n\tgoto L_004C;\n\tv89 = \"il2cpp_codegen_runtime_class_init\"(v83, v77, methodInfo, v63, v64, v65, v66, v67, pos, v0, v2, rot, v3, v5, v6, v68);\nL_004C:\n\tv103 = UnityEngine.Object::Instantiate /* +1 sharing this address */(this.linkPrefab, pos, rot, v78, *([v73 @ X23_v1 (Il2CppMethodInfo)+118]));\n\tv106 = Il2CppMethodInfo;\n\tv109 = UnityEngine.Component::GetComponentInChildren /* +1 sharing this address */(v103, *([v106 @ X8_v5 (Il2CppMethodInfo)+788]));\n\tv149 = UnityEngine.Component::get_transform(v109);\n\tv201 = i & 1;\n\tv124 = v201 == 0;\n\tv115 = ~v124;\n\tif (v115) goto L_FFFFFFFF;\n\tgoto L_006B;\nL_006B:\n\t// 107 MakeStruct v112 @ AGGFEAE44_0_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), 0, v207 @ V1_v5 (System.Int32), 0\n\tv133 = UnityEngine.Quaternion::Internal_FromEulerRad(v112);\n\tUnityEngine.Transform::set_localRotation(v149, v133);\n\treturn v103;\n\treturnVal1 = new System.NullReferenceException();\n\treturn returnVal1;\n// 108 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private global::UnityEngine.Rigidbody2D CreateLink(global::UnityEngine.Vector3 pos, global::UnityEngine.Quaternion rot, int i)
	{
		nint num = 0;
		global::UnityEngine.Transform transform = base.transform;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @117145C (UnityEngine.Object::Instantiate, and 1 more at this address)");
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C900 (UnityEngine.Component::GetComponentInChildren, and 1 more at this address)");
		global::UnityEngine.Component component = default(global::UnityEngine.Component);
		global::UnityEngine.Transform transform2 = component.transform;
		int num3 = (((i & 1) == 0) ? 1070141403 : 0);
		global::UnityEngine.Vector3 vector = default(global::UnityEngine.Vector3);
		vector.x = 0f;
		vector.y = num3;
		vector.z = 0f;
		global::UnityEngine.Quaternion localRotation = global::UnityEngine.Quaternion.Euler(vector * 57.29578f);
		transform2.localRotation = localRotation;
		global::UnityEngine.Rigidbody2D result = default(global::UnityEngine.Rigidbody2D);
		return result;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000191")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEAF8C", Offset = "0xFEAF8C", Length = "0x98")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tgoto L_001D;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x58;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv51 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv52 = v51 + 0x348;\n\tv44 = \"il2cpp_codegen_initialize_runtime_metadata\"(v52, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42);\n\tv46 = 1;\n\t*([302A982]) = v46;\nL_001D:\n\tthis.sagDepth = 1.490116691496568E-09d;\n\tv50 = new *([v18 @ X20_v1 (Il2CppClass<System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>>)+348])();\n\tSystem.Collections.Generic.List`1<UnityEngine.Rigidbody2D>::.ctor(v50);\n\tv56 = this + 0x40;\n\tthis._links = v50;\n\tv58 = 0xF3F1B4(v56, v50, v29, v30, v31, v32, v33, v34, 1.490116691496568E-09d, v36, v37, v38, v39, v40, v41, v42);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 33 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Chain()
	{
		//IL_000e: Expected I, but got O
		//IL_0047: Expected O, but got I
		nint num = (nint)typeof(global::System.Collections.Generic.List<global::UnityEngine.UIElements.StyleSheets.Syntax.Expression>);
		sagDepth = 0.25f;
		anchorOffset = 0.15f;
		global::System.Collections.Generic.List<global::UnityEngine.Rigidbody2D> links = new global::System.Collections.Generic.List<global::UnityEngine.Rigidbody2D>();
		object obj = (nint)this + 64;
		_links = links;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		base._002Ector();
	}
}
