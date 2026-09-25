[global::Cpp2ILInjected.Token(Token = "0x2000044")]
public class Butterfly : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float damping;

	[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float collectForce;

	[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float applyForceDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40000FE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float scaleUpDuration;

	[global::Cpp2ILInjected.Token(Token = "0x40000FF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float startTime;

	[global::Cpp2ILInjected.Token(Token = "0x4000100")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	private global::UnityEngine.Vector2 startPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000101")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	private global::UnityEngine.Vector2 pos;

	[global::Cpp2ILInjected.Token(Token = "0x4000102")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public global::UnityEngine.Vector2 prevPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000103")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public global::UnityEngine.Vector2 vel;

	[global::Cpp2ILInjected.Token(Token = "0x4000104")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private global::System.Func<global::UnityEngine.Vector2> getTargetPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000105")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	private global::System.Action onComplete;

	[global::Cpp2ILInjected.Token(Token = "0x600017C")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE8D9C", Offset = "0xFE8D9C", Length = "0x160")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001C;\n\tv33 = Il2CppMethodInfo;\n\tv34 = v33 + 0x630;\n\tv35 = \"il2cpp_codegen_initialize_runtime_metadata\"(v34, _getTargetPos, _onComplete, methodInfo, v37, v38, v39, v40, _position, v0, v41, v42, v43, v44, v45, v46);\n\tv49 = 1;\n\t*([302A975]) = v49;\nL_001C:\n\tv51 = UnityEngine.Time::get_time();\n\tthis.startTime = v51;\n\tthis.pos = _position;\n\tthis.pos.y = _position.y;\n\tthis.startPos = this.pos;\n\tthis.prevPos = this.pos;\n\tv54 = this + 0x58;\n\tthis.getTargetPos = _getTargetPos;\n\tv56 = 0xF3F1B4(v54, _getTargetPos, _onComplete, methodInfo, v37, v38, v39, v40, v51, _position.y, v41, v42, v43, v44, v45, v46);\n\tv58 = this + 0x60;\n\tthis.onComplete = _onComplete;\n\tv60 = 0xF3F1B4(v58, _onComplete, _onComplete, methodInfo, v37, v38, v39, v40, v51, _position.y, v41, v42, v43, v44, v45, v46);\n\tv63 = UnityEngine.Component::get_transform(this);\n\tv67 = UnityEngine.Transform::GetChild(v63, 0);\n\tv108 = UnityEngine.Component::get_transform(v67);\n\tgoto L_0046;\n\tv141 = System.Xml.ValidateNames;\n\tv142 = v141 + 0xD0;\n\tv143 = \"il2cpp_codegen_initialize_runtime_metadata\"(v142, v87, v66, methodInfo, v37, v38, v39, v40, v51, v0, v41, v42, v43, v44, v45, v46);\n\tv144 = 1;\n\t*([2DD441A]) = v144;\nL_0046:\n\tv145 = Il2CppMethodInfo;\n\tv146 = System.Xml.ValidateNames;\n\tv148 = *([v146 @ X8_v7 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv98 = *([v148 @ X8_v9+B8]);\n\tv74 = *([v98 @ X8_v10+14]) * 0x3EE66666;\n\tv106 = *([v98 @ X8_v10+10]) * 0x3EE66666;\n\tv81 = *([v98 @ X8_v10+C]) * 0x3EE66666;\n\t// 87 MakeStruct v70 @ AGGFE8EB0_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v81 @ V0_v5, v106 @ V1_v3, v74 @ V2_v2\n\tUnityEngine.Transform::set_localScale(v108, v70);\n\tv89 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v145 @ X21_v4 (Il2CppMethodInfo)+630]));\n\tElasticScale::SetScale(v89, 0f);\n\tv90 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v145 @ X21_v4 (Il2CppMethodInfo)+630]));\n\tElasticScale::Pop(v90);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 73 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Init(global::UnityEngine.Vector2 _position, global::System.Func<global::UnityEngine.Vector2> _getTargetPos = null, global::System.Action _onComplete = null)
	{
		startTime = global::UnityEngine.Time.time;
		pos = _position;
		startPos = pos;
		prevPos = pos;
		getTargetPos = _getTargetPos;
		onComplete = _onComplete;
		transform.GetChild(0).localScale = global::UnityEngine.Vector3.one * 0.45f;
		ElasticScale elasticScale = GetComponent<ElasticScale>();
		elasticScale.SetScale(0f);
		elasticScale.Pop();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600017D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE8EFC", Offset = "0xFE8EFC", Length = "0x250")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.prevPos = this.pos;\n\tv20 = this.getTargetPos;\n\tv20.invoke_impl(v26, v20.method_code, v20.method, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv44 = UnityEngine.Time::get_time();\n\tv48 = v44 - this.startTime;\n\tv51 = v48 / this.applyForceDuration;\n\tv55 = v51 - 1f;\n\tv56 = v55 < 0;\n\tv57 = v55 == 0;\n\tv58 = v51 ^ 1f;\n\tv59 = v51 ^ v55;\n\tv60 = v58 & v59;\n\tv61 = v60 < 0;\n\tv62 = v56 == v61;\n\tv63 = ~v57;\n\tv64 = v62 & v63;\n\tv65 = ~v64;\n\tif (v65) goto L_003A;\n\tgoto L_003A;\nL_003A:\n\tv89 = v51 >= 0;\n\tif (v89) goto L_0044;\n\tgoto L_0044;\nL_0044:\n\tv170 = 0x2DD4000;\n\tv172 = *([2DD4421]) == 0;\n\tif (v172) goto L_00D7;\n\tv182 = v33 - this.pos;\n\tgoto L_0050;\nL_0050:\n\tv197 = v182 * v182;\n\t// 81 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv198 = UnityEngine.Mathf::Sqrt(v197);\n\tv218 = v198 <= 0x3727C5AC;\n\tif (v218) goto L_006A;\n\t// 99 NotImplemented \"Instruction DUP not yet implemented.\"\n\tv225 = v182 / v198;\n\tgoto L_0076;\nL_006A:\n\tgoto L_0070;\n\tv235 = System.Xml.ValidateNames;\n\tv236 = v235 + 0x98;\n\tv237 = \"il2cpp_codegen_initialize_runtime_metadata\"(v236, v25, v27, v28, v29, v30, v31, v32, v198, v206, v35, v36, v37, v38, v39, v40);\n\tv239 = 1;\n\t*([2DD4424]) = v239;\nL_0070:\n\tv240 = System.Xml.ValidateNames;\n\tv242 = *([v240 @ X8_v20 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv229 = *([v242 @ X8_v22+B8]);\n\tv225 = *([v229 @ X8_v23]);\nL_0076:\n\tv231 = v225 * v169;\n\tv234 = UnityEngine.Time::get_fixedDeltaTime();\n\tv243 = v231 * v244;\n\tv245 = this.vel + v243;\n\tthis.vel = v245;\n\tv247 = v245 * v244;\n\tv249 = UnityEngine.Time::get_fixedDeltaTime();\n\tv250 = v247 * v244;\n\tv251 = v245 - v250;\n\tthis.vel = v251;\n\tv253 = UnityEngine.Time::get_fixedDeltaTime();\n\tv254 = v251 * v244;\n\tv255 = this.pos + v254;\n\tthis.pos = v255;\n\tv256 = v255 - v33;\n\tv124 = v33 - this.startPos;\n\tv126 = v256 * v124;\n\t// 143 NotImplemented \"Instruction FADDP not yet implemented.\"\n\tv94 = v126 <= 0;\n\tif (v94) goto L_00D1;\n\tgoto L_00AA;\n\tv266 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv267 = v266 + 0xFD8;\n\tv268 = \"il2cpp_codegen_initialize_runtime_metadata\"(v267, v25, v27, v28, v29, v30, v31, v32, v126, v124, v78, v36, v37, v38, v39, v40);\n\tv271 = 1;\n\t*([302A976]) = v271;\nL_00AA:\n\tv274 = this.onComplete;\n\tv275 = this.onComplete == 0;\n\tif (v275) goto L_00B3;\n\tv274.invoke_impl(v279, v274.method_code, v274.method, v27, v28, v29, v30, v31, v32, v126, v124, v33, v36, v37, v38, v39, v40);\nL_00B3:\n\tv284 = UnityEngine.Component::get_gameObject(this);\n\tgoto L_00C6;\n\tv288 = \"il2cpp_codegen_runtime_class_init\"(v286, v283, v27, v28, v29, v30, v31, v32, v126, v124, v78, v36, v37, v38, v39, v40);\nL_00C6:\n\tUnityEngine.Object::Destroy(v284);\n\treturn;\nL_00D1:\n\treturn;\nL_00D7:\n\t*([v170 @ X20_v1+421]) = 1;\n\tv182 = v33 - this.pos;\n\tgoto L_0050;\n\tv190 = \"il2cpp_codegen_runtime_class_init\"(v199, v25, v27, v28, v29, v30, v31, v32, v187, v166, v35, v36, v37, v38, v39, v40);\n\tgoto L_0050;\n\tthrow System.NullReferenceException;\n\treturn;\n// 140 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void FixedUpdate()
	{
		prevPos = pos;
		global::UnityEngine.Vector2 target = getTargetPos != null ? getTargetPos() : startPos;
		float t = global::UnityEngine.Mathf.Clamp01((global::UnityEngine.Time.time - startTime) / applyForceDuration);
		global::UnityEngine.Vector2 delta = target - pos;
		float length = delta.magnitude;
		global::UnityEngine.Vector2 dir = length > 1E-05f ? delta / length : global::UnityEngine.Vector2.zero;
		float dt = global::UnityEngine.Time.fixedDeltaTime;
		vel += dir * collectForce * t * dt;
		vel -= vel * damping * dt;
		pos += vel * dt;
		if (global::UnityEngine.Vector2.Dot(pos - target, target - startPos) <= 0f)
		{
			return;
		}
		onComplete?.Invoke();
		Destroy(gameObject);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600017E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE914C", Offset = "0xFE914C", Length = "0x98")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_0012;\n\tv17 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv18 = v17 + 0xFD8;\n\tv19 = \"il2cpp_codegen_initialize_runtime_metadata\"(v18, methodInfo, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\n\tv37 = 1;\n\t*([302A976]) = v37;\nL_0012:\n\tv38 = Facebook.Unity.Windows.IWindowsFacebook;\n\tv40 = this.onComplete;\n\tv41 = this.onComplete == 0;\n\tif (v41) goto L_001D;\n\tv40.invoke_impl(v45, v40.method_code, v40.method, v21, v22, v23, v24, v25, v26, v27, v28, v29, v30, v31, v32, v33, v34);\nL_001D:\n\tv52 = UnityEngine.Component::get_gameObject(this);\n\tv54 = *([v38 @ X20_v2 (Il2CppClass<Facebook.Unity.Windows.IWindowsFacebook>)+FD8]);\n\tv56 = *([v54 @ X0_v5+E0]) == 0;\n\tif (v56) goto L_0034;\n\tUnityEngine.Object::Destroy(v52);\n\treturn;\nL_0034:\n\tUnityEngine.Object::Destroy(v52);\n\treturn;\n// 35 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Complete()
	{
		onComplete?.Invoke();
		Destroy(gameObject);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600017F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE91E4", Offset = "0xFE91E4", Length = "0x170")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv25 = UnityEngine.Time::get_time();\n\tv28 = UnityEngine.Time::get_fixedTime();\n\tv31 = UnityEngine.Time::get_fixedDeltaTime();\n\tv34 = UnityEngine.Time::get_time();\n\tv45 = v34 >= this.startTime;\n\tif (v45) goto L_0066;\n\tv50 = UnityEngine.Component::get_transform(this);\n\tv59 = UnityEngine.Transform::get_position(v50);\n\tv90 = UnityEngine.Component::get_transform(this);\n\t// 57 MakeStruct v69 @ AGGFE9278_1_v2 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), this.pos (UnityEngine.Vector2), this.pos.y (System.Single), v59.z (System.Single)\n\tUnityEngine.Transform::set_position(v90, v69);\n\tv209 = UnityEngine.Component::get_transform(this);\n\tgoto L_004B;\n\tv217 = System.Xml.ValidateNames;\n\tv218 = v217 + 0xD0;\n\tv219 = \"il2cpp_codegen_initialize_runtime_metadata\"(v218, v79, v95, v96, v97, v98, v99, v100, v88, v82, v73, v101, v102, v103, v104, v105);\n\tv220 = 1;\n\t*([2DD4419]) = v220;\nL_004B:\n\tv221 = System.Xml.ValidateNames;\n\tv223 = *([v221 @ X8_v4 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv150 = *([v223 @ X8_v6+B8]);\n\t// 95 MakeStruct v135 @ AGGFE92E4_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), [v150 @ X8_v7], [v150 @ X8_v7+4], [v150 @ X8_v7+8]\n\tUnityEngine.Transform::set_localScale(v209, v135);\n\treturn;\nL_0066:\n\tv55 = UnityEngine.Component::get_transform(this);\n\tv106 = this.pos - this.prevPos;\n\tv107 = v25 - v28;\n\tv108 = v107 / v31;\n\tv112 = v108 - 1f;\n\tv113 = v112 < 0;\n\tv114 = v112 == 0;\n\tv115 = v108 ^ 1f;\n\tv116 = v108 ^ v112;\n\tv117 = v115 & v116;\n\tv118 = v117 < 0;\n\tv119 = v113 == v118;\n\tv120 = ~v114;\n\tv121 = v119 & v120;\n\tv122 = ~v121;\n\tif (v122) goto L_0089;\n\tgoto L_0089;\nL_0089:\n\tv131 = v108 >= 0;\n\tif (v131) goto L_008F;\n\tgoto L_008F;\nL_008F:\n\tv211 = v106 * v212;\n\tv193 = this.prevPos + v211;\n\t// 159 MakeStruct v128 @ AGGFE934C_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v193 @ V0_v8 (System.Single), v213 @ V0.S1, -6f\n\tUnityEngine.Transform::set_position(v55, v128);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 113 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Update()
	{
		if (global::UnityEngine.Time.time < startTime)
		{
			transform.position = new global::UnityEngine.Vector3(pos.x, pos.y, transform.position.z);
			transform.localScale = global::UnityEngine.Vector3.zero;
			return;
		}
		float t = global::UnityEngine.Mathf.Clamp01((global::UnityEngine.Time.time - global::UnityEngine.Time.fixedTime) / global::UnityEngine.Time.fixedDeltaTime);
		global::UnityEngine.Vector2 p = global::UnityEngine.Vector2.Lerp(prevPos, pos, t);
		transform.position = new global::UnityEngine.Vector3(p.x, p.y, -6f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000180")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE9354", Offset = "0xFE9354", Length = "0x14")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.damping = *([2875900]);\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 3 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Butterfly()
	{
	}
}
