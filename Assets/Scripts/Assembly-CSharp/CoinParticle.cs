[global::Cpp2ILInjected.Token(Token = "0x20000D7")]
public class CoinParticle : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400047D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.RectTransform rt;

	[global::Cpp2ILInjected.Token(Token = "0x400047E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.Vector2 acceleration;

	[global::Cpp2ILInjected.Token(Token = "0x400047F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.Vector2 velocity;

	[global::Cpp2ILInjected.Token(Token = "0x4000480")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.Vector2 position;

	[global::Cpp2ILInjected.Token(Token = "0x4000481")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::UnityEngine.Vector2 prevPosition;

	[global::Cpp2ILInjected.Token(Token = "0x4000482")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public float value;

	[global::Cpp2ILInjected.Token(Token = "0x4000483")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C")]
	public float damping;

	[global::Cpp2ILInjected.Token(Token = "0x4000484")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public float rotation;

	[global::Cpp2ILInjected.Token(Token = "0x4000485")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
	public float angularVelocity;

	[global::Cpp2ILInjected.Token(Token = "0x4000486")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	private float prevRotation;

	[global::Cpp2ILInjected.Token(Token = "0x60003D1")]
	[global::Cpp2ILInjected.Address(RVA = "0x1018418", Offset = "0x1018418", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Il2CppMethodInfo;\n\tgoto L_0018;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x708;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA99]) = v43;\nL_0018:\n\tv46 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v18 @ X21_v1 (Il2CppMethodInfo)+708]));\n\tv48 = this + 0x20;\n\tthis.rt = v46;\n\tv56 = 0xF3F1B4(v48, v46, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		rt = GetComponent<global::UnityEngine.RectTransform>();
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003D2")]
	[global::Cpp2ILInjected.Address(RVA = "0x101847C", Offset = "0x101847C", Length = "0x44")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv15 = UnityEngine.RectTransform::get_anchoredPosition(this.rt);\n\tthis.position = v15;\n\tthis.position.y = v15.y;\n\tthis.prevPosition = this.position;\n\tthis.prevRotation = this.rotation;\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 19 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		position = rt.anchoredPosition;
		prevPosition = position;
		prevRotation = rotation;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003D3")]
	[global::Cpp2ILInjected.Address(RVA = "0x10184C0", Offset = "0x10184C0", Length = "0xD0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.prevPosition = this.position;\n\tv20 = UnityEngine.Time::get_deltaTime();\n\tv21 = this.acceleration * v22;\n\tv23 = this.velocity + v21;\n\tthis.velocity = v23;\n\tv25 = v23 * v22;\n\tv27 = UnityEngine.Time::get_deltaTime();\n\tv28 = v25 * v22;\n\tv52 = v23 - v28;\n\tthis.velocity = v52;\n\tgoto L_0024;\n\tv34 = System.Xml.ValidateNames;\n\tv35 = v34 + 0x98;\n\tv36 = \"il2cpp_codegen_initialize_runtime_metadata\"(v35, methodInfo, v38, v39, v40, v41, v42, v43, v28, v44, v45, v46, v47, v48, v49, v50);\n\tv55 = 1;\n\t*([2DD4424]) = v55;\n\tv53 = *([v14 @ X19_v1 (CoinParticle)+30]);\nL_0024:\n\tv56 = System.Xml.ValidateNames;\n\tv58 = *([v56 @ X8_v4 (Il2CppClass<System.Xml.ValidateNames>)+98]);\n\tv59 = *([v58 @ X8_v6+B8]);\n\tthis.acceleration = *([v59 @ X8_v7]);\n\tv63 = UnityEngine.Time::get_deltaTime();\n\tv64 = v52 * v22;\n\tv65 = this.position + v64;\n\tthis.position = v65;\n\tthis.prevRotation = this.rotation;\n\tv69 = UnityEngine.Time::get_deltaTime();\n\tv70 = this.angularVelocity * v69;\n\tv71 = this.rotation + v70;\n\tthis.rotation = v71;\n\treturn;\n// 33 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void UpdatePhysics()
	{
		prevPosition = position;
		velocity += acceleration * global::UnityEngine.Time.deltaTime;
		velocity -= velocity * damping * global::UnityEngine.Time.deltaTime;
		acceleration = global::UnityEngine.Vector2.zero;
		position += velocity * global::UnityEngine.Time.deltaTime;
		prevRotation = rotation;
		rotation += angularVelocity * global::UnityEngine.Time.deltaTime;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003D4")]
	[global::Cpp2ILInjected.Address(RVA = "0x1018590", Offset = "0x1018590", Length = "0x108")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv17 = UnityEngine.Time::get_time();\n\tv20 = UnityEngine.Time::get_fixedTime();\n\tv23 = UnityEngine.Time::get_fixedDeltaTime();\n\tv26 = v17 - v20;\n\tv27 = v26 / v23;\n\tv31 = v27 - 1f;\n\tv32 = v31 < 0;\n\tv33 = v31 == 0;\n\tv34 = v27 ^ 1f;\n\tv35 = v27 ^ v31;\n\tv36 = v34 & v35;\n\tv37 = v36 < 0;\n\tv38 = v32 == v37;\n\tv39 = ~v33;\n\tv40 = v38 & v39;\n\tv41 = ~v40;\n\tif (v41) goto L_FFFFFFFF;\n\tgoto L_0033;\nL_0033:\n\tv56 = v27 >= 0;\n\tif (v56) goto L_FFFFFFFF;\n\tgoto L_003B;\nL_003B:\n\tv172 = this.position - this.prevPosition;\n\tv173 = v172 * v174;\n\tv93 = this.prevPosition + v173;\n\t// 65 MakeStruct v44 @ AGG101860C_1_v2 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v93 @ V0_v7 (System.Single), v175 @ V0.S1\n\tUnityEngine.RectTransform::set_anchoredPosition(this.rt, v44);\n\tv178 = this.rotation - this.prevRotation;\n\tv181 = v178 / 0x43B40000;\n\tv182 = UnityEngine.Mathf::Floor(v181);\n\tv184 = v182 * 0xC3B40000;\n\tv185 = v178 + v184;\n\tv188 = v185 - 0x43B40000;\n\tv189 = v188 < 0;\n\tv190 = v188 == 0;\n\tv191 = v185 ^ 0x43B40000;\n\tv192 = v185 ^ v188;\n\tv193 = v191 & v192;\n\tv194 = v193 < 0;\n\tv195 = v189 == v194;\n\tv196 = ~v190;\n\tv197 = v195 & v196;\n\tv198 = ~v197;\n\tif (v198) goto L_FFFFFFFF;\n\tgoto L_006C;\nL_006C:\n\tv211 = v185 >= 0;\n\tif (v211) goto L_FFFFFFFF;\n\tgoto L_0072;\nL_0072:\n\tv215 = v220 + 0xC3B40000;\n\tv151 = v220 - 0x43340000;\n\tv149 = v151 < 0;\n\tv147 = v151 == 0;\n\tv145 = v220 ^ 0x43340000;\n\tv143 = v220 ^ v151;\n\tv141 = v145 & v143;\n\tv139 = v141 < 0;\n\tv217 = v149 == v139;\n\tv135 = ~v147;\n\tv137 = v217 & v135;\n\tv133 = ~v137;\n\tif (v133) goto L_0088;\n\tgoto L_0088;\nL_0088:\n\tv222 = v53 * v220;\n\tv131 = this.prevRotation + v222;\n\t// 148 MakeStruct v113 @ AGG1018690_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), 0, 0, v131 @ V2_v7 (System.Single)\n\tUnityEngine.Transform::set_localEulerAngles(this.rt, v113);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 85 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Update()
	{
		float t = global::UnityEngine.Mathf.Clamp01((global::UnityEngine.Time.time - global::UnityEngine.Time.fixedTime) / global::UnityEngine.Time.fixedDeltaTime);
		rt.anchoredPosition = global::UnityEngine.Vector2.Lerp(prevPosition, position, t);
		float delta = global::UnityEngine.Mathf.DeltaAngle(prevRotation, rotation);
		float z = prevRotation + t * delta;
		rt.localEulerAngles = new global::UnityEngine.Vector3(0f, 0f, z);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003D5")]
	[global::Cpp2ILInjected.Address(RVA = "0x1018698", Offset = "0x1018698", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.damping = 100f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public CoinParticle()
	{
		damping = 100f;
	}
}
