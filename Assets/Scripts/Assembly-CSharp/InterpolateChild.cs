[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.Rigidbody2D))]
[global::Cpp2ILInjected.Token(Token = "0x20000B5")]
public class InterpolateChild : global::UnityEngine.MonoBehaviour
{
	[global::UnityEngine.Tooltip("The Rigidbody2D whose motion we sample.")]
	[global::Cpp2ILInjected.Token(Token = "0x40003EB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.Rigidbody2D targetRigidbody;

	[global::UnityEngine.Tooltip("The visual Transform (sprite/mesh) to detach and move.")]
	[global::Cpp2ILInjected.Token(Token = "0x40003EC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.Transform visual;

	[global::Cpp2ILInjected.Token(Token = "0x40003ED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private global::UnityEngine.Vector3 prevPos;

	[global::Cpp2ILInjected.Token(Token = "0x40003EE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private global::UnityEngine.Vector3 currPos;

	[global::Cpp2ILInjected.Token(Token = "0x40003EF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	private global::UnityEngine.Quaternion prevRot;

	[global::Cpp2ILInjected.Token(Token = "0x40003F0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private global::UnityEngine.Quaternion currRot;

	[global::Cpp2ILInjected.Token(Token = "0x40003F1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	private float visualZ;

	[global::Cpp2ILInjected.Token(Token = "0x600032F")]
	[global::Cpp2ILInjected.Address(RVA = "0x100E9B4", Offset = "0x100E9B4", Length = "0x23C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302AA5F]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_005E;\n\tv166 = this + 0x20;\n\tv25 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv27 = *([v25 @ X0_v58+E0]) == 0;\n\tif (v27) goto L_006B;\nL_001A:\n\tv59 = UnityEngine.Object::op_Equality(v48, 0);\n\tv69 = ~v59;\n\tv70 = ~v69;\n\tif (v70) goto L_006E;\nL_001F:\n\tv87 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv89 = *([v87 @ X0_v54+E0]) == 0;\n\tif (v89) goto L_0081;\nL_0026:\n\tv120 = UnityEngine.Object::op_Equality(v110, 0);\n\tv134 = ~v120;\n\tif (v134) goto L_008B;\nL_0029:\n\tv151 = \"Hungarian\";\n\tv153 = \" doesn't have _StencilOp property\";\n\tv159 = UnityEngine.Object::get_name(this);\n\tv174 = System.String::Concat(*([v151 @ X20_v10 (System.String)+858]), v159, *([v153 @ X21_v9 (System.String)+920]));\n\tgoto L_0041;\n\tv214 = \"il2cpp_codegen_runtime_class_init\"(v210, v170, v172, v173, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\nL_0041:\n\tUnityEngine.Debug::LogError(v174, this);\n\tUnityEngine.Behaviour::set_enabled(this, 0);\n\treturn;\nL_005E:\n\t*([v16 @ X20_v1+A5F]) = 1;\n\tv166 = this + 0x20;\n\tv47 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv142 = *([v47 @ X0_v39+E0]) == 0;\n\tv51 = ~v142;\n\tif (v51) goto L_001A;\nL_006B:\n\tv74 = UnityEngine.Object::op_Equality(v61, 0);\n\tv83 = ~v74;\n\tif (v83) goto L_001F;\nL_006E:\n\tv97 = Il2CppMethodInfo;\n\tv101 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v97 @ X8_v5 (Il2CppMethodInfo)+720]));\n\tthis.targetRigidbody = v101;\n\tv130 = 0xF3F1B4(v127, v101, v90, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44, v45);\n\tv109 = *([v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv139 = *([v109 @ X0_v19+E0]) == 0;\n\tv113 = ~v139;\n\tif (v113) goto L_0026;\nL_0081:\n\tv138 = UnityEngine.Object::op_Equality(v124, 0);\n\tv169 = ~v138;\n\tv148 = ~v169;\n\tif (v148) goto L_0029;\nL_008B:\n\tUnityEngine.Transform::SetParent(this.visual, 0, 1);\n\tv198 = UnityEngine.Component::get_transform(*([v166 @ X20_v2]));\n\tv187 = UnityEngine.Transform::get_position(v198);\n\tthis.prevPos = v187;\n\tthis.prevPos.y = v187.y;\n\tthis.prevPos.z = v187.z;\n\tthis.currPos = v187;\n\tthis.currPos.y = v187.y;\n\tthis.currPos.z = v187.z;\n\tv200 = UnityEngine.Component::get_transform(this.targetRigidbody);\n\tv188 = UnityEngine.Transform::get_rotation(v200);\n\tthis.prevRot = v188;\n\tthis.prevRot.y = v188.y;\n\tthis.prevRot.z = v188.z;\n\tthis.prevRot.w = v188.w;\n\tthis.currRot = v188;\n\tthis.currRot.y = v188.y;\n\tthis.currRot.z = v188.z;\n\tthis.currRot.w = v188.w;\n\tv225 = UnityEngine.Transform::get_position(this.visual);\n\tthis.visualZ = v225.z;\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 122 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_01da: Expected O, but got I
		//IL_01ea: Expected O, but got I
		//IL_00d4: Expected O, but got I4
		//IL_0056: Expected O, but got I
		//IL_0066: Expected O, but got I
		//IL_02ac: Expected O, but got I
		//IL_00fa: Expected O, but got I
		//IL_0265: Expected O, but got I4
		//IL_019f: Expected O, but got I
		//IL_019f: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA5F]");
		object obj2;
		global::UnityEngine.Object obj4;
		global::UnityEngine.Object obj5;
		object obj6;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			obj2 = (nint)this + 32;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj3 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v25 @ X0_v58+E0]");
			bool flag = (nint)0 == 0;
			obj4 = targetRigidbody;
			obj5 = targetRigidbody;
			obj6 = obj2;
			if (!flag)
			{
				goto IL_00a7;
			}
		}
		else
		{
			_ = 1;
			obj2 = (nint)this + 32;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj7 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v47 @ X0_v39+E0]");
			bool flag2 = (nint)0 == 0;
			bool flag3 = !flag2;
			obj4 = targetRigidbody;
			obj5 = targetRigidbody;
			obj6 = obj2;
			if (flag3)
			{
				goto IL_00a7;
			}
		}
		bool flag4 = obj5 == null;
		bool flag5 = !flag4;
		obj2 = obj6;
		object obj8 = 0;
		if (flag5)
		{
			goto IL_00ea;
		}
		goto IL_0273;
		IL_0162:
		string text = "Hungarian";
		string text2 = " doesn't have _StencilOp property";
		string text3 = base.name;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v151 @ X20_v10 (System.String)+858]");
		nint num2 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v153 @ X21_v9 (System.String)+920]");
		string message = (string)num2 + text3 + (string)0;
		global::UnityEngine.Debug.LogError(message, this);
		base.enabled = false;
		return;
		IL_0337:
		visual.SetParent(null, worldPositionStays: true);
		global::UnityEngine.Transform transform = ((global::UnityEngine.Component)obj2).transform;
		global::UnityEngine.Vector3 vector = (prevPos = transform.position);
		prevPos.y = vector.y;
		prevPos.z = vector.z;
		currPos = vector;
		currPos.y = vector.y;
		currPos.z = vector.z;
		global::UnityEngine.Transform transform2 = targetRigidbody.transform;
		global::UnityEngine.Quaternion quaternion = (prevRot = transform2.rotation);
		prevRot.y = quaternion.y;
		prevRot.z = quaternion.z;
		prevRot.w = quaternion.w;
		currRot = quaternion;
		currRot.y = quaternion.y;
		currRot.z = quaternion.z;
		currRot.w = quaternion.w;
		visualZ = visual.position.z;
		return;
		IL_013b:
		global::UnityEngine.Object obj9;
		if (obj9 == null)
		{
			goto IL_0162;
		}
		goto IL_0337;
		IL_00a7:
		bool flag6 = obj4 == null;
		bool flag7 = !flag6;
		bool flag8 = !flag7;
		obj8 = 0;
		obj6 = obj2;
		if (!flag8)
		{
			goto IL_00ea;
		}
		goto IL_0273;
		IL_0273:
		nint num3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		global::UnityEngine.Rigidbody2D rigidbody2D = default(global::UnityEngine.Rigidbody2D);
		targetRigidbody = rigidbody2D;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj10 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v109 @ X0_v19+E0]");
		bool flag9 = (nint)0 == 0;
		bool flag10 = !flag9;
		obj9 = visual;
		obj2 = obj6;
		global::UnityEngine.Object obj11 = visual;
		if (flag10)
		{
			goto IL_013b;
		}
		goto IL_02f8;
		IL_00ea:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj12 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v87 @ X0_v54+E0]");
		bool flag11 = (nint)0 == 0;
		obj9 = visual;
		obj11 = visual;
		obj6 = obj2;
		if (!flag11)
		{
			goto IL_013b;
		}
		goto IL_02f8;
		IL_02f8:
		bool flag12 = obj11 == null;
		bool flag13 = !flag12;
		bool flag14 = !flag13;
		obj2 = obj6;
		if (flag14)
		{
			goto IL_0162;
		}
		goto IL_0337;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000330")]
	[global::Cpp2ILInjected.Address(RVA = "0x100EBF0", Offset = "0x100EBF0", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.prevPos = this.currPos;\n\tthis.prevPos.z = this.currPos.z;\n\tthis.prevRot = this.currRot;\n\tv18 = UnityEngine.Component::get_transform(this.targetRigidbody);\n\tv37 = UnityEngine.Transform::get_position(v18);\n\tthis.currPos = v37;\n\tthis.currPos.y = v37.y;\n\tthis.currPos.z = v37.z;\n\tv35 = UnityEngine.Component::get_transform(this.targetRigidbody);\n\tv65 = UnityEngine.Transform::get_rotation(v35);\n\tthis.currRot = v65;\n\tthis.currRot.y = v65.y;\n\tthis.currRot.z = v65.z;\n\tthis.currRot.w = v65.w;\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void FixedUpdate()
	{
		prevPos = currPos;
		prevPos.z = currPos.z;
		prevRot = currRot;
		global::UnityEngine.Transform transform = targetRigidbody.transform;
		global::UnityEngine.Vector3 vector = (currPos = transform.position);
		currPos.y = vector.y;
		currPos.z = vector.z;
		global::UnityEngine.Transform transform2 = targetRigidbody.transform;
		global::UnityEngine.Quaternion quaternion = (currRot = transform2.rotation);
		currRot.y = quaternion.y;
		currRot.z = quaternion.z;
		currRot.w = quaternion.w;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000331")]
	[global::Cpp2ILInjected.Address(RVA = "0x100EC70", Offset = "0x100EC70", Length = "0x1F4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001F;\n\tv37 = Il2CppMethodInfo;\n\tv38 = v37 + 0x668;\n\tv39 = \"il2cpp_codegen_initialize_runtime_metadata\"(v38, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv65 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv66 = v65 + 0xFD8;\n\tv56 = \"il2cpp_codegen_initialize_runtime_metadata\"(v66, methodInfo, v41, v42, v43, v44, v45, v46, v47, v48, v49, v50, v51, v52, v53, v54);\n\tv58 = 1;\n\t*([302AA60]) = v58;\nL_001F:\n\tv59 = Il2CppMethodInfo;\n\tv61 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv64 = UnityEngine.Time::get_fixedDeltaTime();\n\tv79 = v64 <= 0;\n\tif (v79) goto L_006B;\n\tv81 = UnityEngine.Time::get_time();\n\tv132 = UnityEngine.Time::get_fixedTime();\n\tv135 = UnityEngine.Time::get_fixedDeltaTime();\n\tv152 = v81 - v132;\n\tv153 = v152 / v135;\n\tv157 = v153 - 1f;\n\tv158 = v157 < 0;\n\tv159 = v157 == 0;\n\tv160 = v153 ^ 1f;\n\tv161 = v153 ^ v157;\n\tv162 = v160 & v161;\n\tv163 = v162 < 0;\n\tv164 = v158 == v163;\n\tv87 = ~v159;\n\tv97 = v164 & v87;\n\tv165 = ~v97;\n\tif (v165) goto L_FFFFFFFF;\n\tgoto L_005A;\nL_005A:\n\tv84 = v153 >= 0;\n\tif (v84) goto L_FFFFFFFF;\n\tgoto L_006B;\nL_006B:\n\tv130 = v114 >= 0;\n\tif (v130) goto L_007D;\n\tgoto L_007D;\nL_007D:\n\t// 125 MakeStruct v149 @ AGG100ED58_0_v1 (UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), this.prevRot (UnityEngine.Quaternion), this.prevRot.y (System.Single), this.prevRot.z (System.Single), this.prevRot.w (System.Single)\n\t// 126 MakeStruct v150 @ AGG100ED58_1_v1 (UnityEngine.Quaternion), typeof(UnityEngine.Quaternion), this.currRot (UnityEngine.Quaternion), this.currRot.y (System.Single), this.currRot.z (System.Single), this.currRot.w (System.Single)\n\tv151 = UnityEngine.Quaternion::Slerp(v149, v150, v114);\n\tv176 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v59 @ X21_v1 (Il2CppMethodInfo)+668]));\n\tv180 = *([v61 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv182 = *([v180 @ X0_v7+E0]) == 0;\n\tif (v182) goto L_009C;\n\tv187 = UnityEngine.Object::op_Inequality(v176, 0);\n\tv189 = ~v187;\n\tv190 = ~v189;\n\tif (v190) goto L_00A1;\n\tgoto L_00BA;\nL_009C:\n\tv194 = UnityEngine.Object::op_Inequality(v176, 0);\n\tv199 = ~v194;\n\tif (v199) goto L_00BA;\nL_00A1:\n\tv202 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v59 @ X21_v1 (Il2CppMethodInfo)+668]));\n\tv207 = *([v202 @ X0_v15+30]) == 0;\n\tif (v207) goto L_00BA;\n\treturn;\nL_00BA:\n\tv213 = this.currPos - this.prevPos;\n\tv215 = v213 * v216;\n\tv217 = this.prevPos + v215;\n\t// 193 MakeStruct v222 @ AGG100EE1C_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v217 @ V0_v10 (System.Single), v219 @ V0.S1, this.visualZ (System.Single)\n\tUnityEngine.Transform::set_position(this.visual, v222);\n\tUnityEngine.Transform::set_rotation(this.visual, v151);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 157 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void LateUpdate()
	{
		//IL_0263: Expected I, but got O
		//IL_03aa: Expected O, but got I
		//IL_0083: Expected O, but got F4
		//IL_0090: Expected O, but got F4
		//IL_021c: Expected F4, but got O
		nint num = 0;
		float fixedDeltaTime = global::UnityEngine.Time.fixedDeltaTime;
		bool flag = !(fixedDeltaTime > 0f);
		float num3 = 1f;
		if (!flag)
		{
			float time = global::UnityEngine.Time.time;
			float fixedTime = global::UnityEngine.Time.fixedTime;
			float fixedDeltaTime2 = global::UnityEngine.Time.fixedDeltaTime;
			float num4 = time - fixedTime;
			float num5 = num4 / fixedDeltaTime2;
			float num6 = num5 - 1f;
			bool flag2 = num6 < 0f;
			bool flag3 = num6 == 0f;
			object obj = num5 ^ 1f;
			object obj2 = num5 ^ num6;
			int num7 = (int)((nint)obj & (nint)obj2);
			bool flag4 = num7 < 0;
			bool flag5 = flag2 == flag4;
			bool flag6 = !flag3;
			float num8 = ((!(flag5 && flag6)) ? num5 : 1f);
			num3 = ((!(num5 < 0f)) ? num8 : 0f);
		}
		if (num3 < 0f)
		{
		}
		global::UnityEngine.Quaternion a = default(global::UnityEngine.Quaternion);
		a.x = prevRot.x;
		a.y = prevRot.y;
		a.z = prevRot.z;
		a.w = prevRot.w;
		global::UnityEngine.Quaternion b = default(global::UnityEngine.Quaternion);
		b.x = currRot.x;
		b.y = currRot.y;
		b.z = currRot.z;
		b.w = currRot.w;
		global::UnityEngine.Quaternion rotation = global::UnityEngine.Quaternion.Slerp(a, b, num3);
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v61 @ X22_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj3 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v180 @ X0_v7+E0]");
		global::UnityEngine.Object obj4 = default(global::UnityEngine.Object);
		if ((nint)0 != 0)
		{
			if (obj4 != null)
			{
				goto IL_018b;
			}
		}
		else if (obj4 != null)
		{
			goto IL_018b;
		}
		goto IL_01c0;
		IL_01c0:
		float num9 = currPos.x - prevPos.x;
		object obj5 = default(object);
		float num10 = num9 * (float)obj5;
		float x = prevPos.x + num10;
		global::UnityEngine.Vector3 position = default(global::UnityEngine.Vector3);
		position.x = x;
		object obj6 = default(object);
		position.y = (float)obj6;
		position.z = visualZ;
		visual.position = position;
		visual.rotation = rotation;
		return;
		IL_018b:
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v202 @ X0_v15+30]");
		if ((nint)0 != 0)
		{
			return;
		}
		goto IL_01c0;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000332")]
	[global::Cpp2ILInjected.Address(RVA = "0x100EE64", Offset = "0x100EE64", Length = "0xF0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv16 = 0x302A000;\n\tv18 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv20 = *([302AA61]) & 1;\n\tv21 = v20 == 0;\n\tif (v21) goto L_0034;\n\tv23 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv25 = *([v23 @ X0_v21+E0]) == 0;\n\tif (v25) goto L_003F;\nL_0018:\n\tv55 = UnityEngine.Object::op_Inequality(v50, 0);\n\tv63 = ~v55;\n\tif (v63) goto L_004A;\nL_001F:\n\tv91 = UnityEngine.Component::get_gameObject(this.visual);\n\tv123 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv107 = *([v123 @ X0_v14+E0]) == 0;\n\tif (v107) goto L_0055;\n\tUnityEngine.Object::Destroy(v91);\n\treturn;\nL_0034:\n\t*([v16 @ X20_v1+A61]) = 1;\n\tv45 = *([v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv62 = *([v45 @ X0_v9+E0]) == 0;\n\tv47 = ~v62;\n\tif (v47) goto L_0018;\nL_003F:\n\tv67 = UnityEngine.Object::op_Inequality(v59, 0);\n\tv89 = ~v67;\n\tv72 = ~v89;\n\tif (v72) goto L_001F;\nL_004A:\n\treturn;\nL_0055:\n\tUnityEngine.Object::Destroy(v91);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 58 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void OnDestroy()
	{
		//IL_0009: Expected O, but got I4
		//IL_0017: Expected I, but got O
		//IL_011e: Expected O, but got I
		//IL_005a: Expected O, but got I
		//IL_00d9: Expected O, but got I
		object obj = 50503680;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [302AA61]");
		global::UnityEngine.Object obj3;
		global::UnityEngine.Object obj4;
		if ((uint)((nuint)0u & (nuint)1u) != 0)
		{
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
			object obj2 = 0;
			global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v23 @ X0_v21+E0]");
			bool flag = (nint)0 == 0;
			obj3 = visual;
			obj4 = visual;
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
			obj3 = visual;
			obj4 = visual;
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
		global::UnityEngine.GameObject obj6 = visual.gameObject;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v18 @ X21_v1 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]");
		object obj7 = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Unmanaged memory load: [v123 @ X0_v14+E0]");
		if ((nint)0 != 0)
		{
			global::UnityEngine.Object.Destroy(obj6);
		}
		else
		{
			global::UnityEngine.Object.Destroy(obj6);
		}
		return;
		IL_0093:
		if (obj3 != null)
		{
			goto IL_00ba;
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000333")]
	[global::Cpp2ILInjected.Address(RVA = "0x100EF54", Offset = "0x100EF54", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public InterpolateChild()
	{
	}
}
