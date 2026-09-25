[global::Cpp2ILInjected.Token(Token = "0x2000067")]
public class ElasticScale : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40001B3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public float scaleStiffness;

	[global::Cpp2ILInjected.Token(Token = "0x40001B4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public float scaleDamping;

	[global::Cpp2ILInjected.Token(Token = "0x40001B5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	private float prevScale;

	[global::Cpp2ILInjected.Token(Token = "0x40001B6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	private float scale;

	[global::Cpp2ILInjected.Token(Token = "0x40001B7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	private float scaleVel;

	[global::Cpp2ILInjected.Token(Token = "0x40001B8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public float popScaleVel;

	[global::Cpp2ILInjected.Token(Token = "0x40001B9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float scaleForce;

	[global::Cpp2ILInjected.Token(Token = "0x40001BA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
	public float targetScale;

	[global::Cpp2ILInjected.Token(Token = "0x6000213")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF6084", Offset = "0xFF6084", Length = "0x74")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.prevScale = this.scale;\n\tv22 = this.targetScale - this.scale;\n\tv23 = v22 * this.scaleStiffness;\n\tv24 = this.scaleForce + v23;\n\tv25 = this.scaleVel * this.scaleDamping;\n\tv26 = v24 - v25;\n\tv28 = UnityEngine.Time::get_fixedDeltaTime();\n\tv29 = v28 * v26;\n\tv30 = this.scaleVel + v29;\n\tthis.scaleVel = v30;\n\tv33 = UnityEngine.Time::get_fixedDeltaTime();\n\tv34 = v30 * v33;\n\tv35 = this.scale + v34;\n\tthis.scale = v35;\n\treturn;\n// 25 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void FixedUpdate()
	{
		prevScale = scale;
		scaleVel += global::UnityEngine.Time.fixedDeltaTime * (scaleForce + (targetScale - scale) * scaleStiffness - scaleVel * scaleDamping);
		scale += scaleVel * global::UnityEngine.Time.fixedDeltaTime;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000214")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF60F8", Offset = "0xFF60F8", Length = "0xF4")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv25 = UnityEngine.Time::get_time();\n\tv28 = UnityEngine.Time::get_fixedTime();\n\tv31 = UnityEngine.Time::get_fixedDeltaTime();\n\tv35 = UnityEngine.Component::get_transform(this);\n\tgoto L_0028;\n\tv43 = System.Xml.ValidateNames;\n\tv44 = v43 + 0xD0;\n\tv45 = \"il2cpp_codegen_initialize_runtime_metadata\"(v44, v34, v46, v47, v48, v49, v50, v51, v31, v52, v53, v54, v55, v56, v57, v58);\n\tv60 = 1;\n\t*([2DD441A]) = v60;\nL_0028:\n\tv63 = System.Xml.ValidateNames;\n\tv65 = *([v63 @ X8_v3 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv66 = *([v65 @ X8_v5+B8]);\n\tv68 = this.scale - this.prevScale;\n\tv69 = v25 - v28;\n\tv70 = v69 / v31;\n\tv74 = v70 - 1f;\n\tv75 = v74 < 0;\n\tv76 = v74 == 0;\n\tv77 = v70 ^ 1f;\n\tv78 = v70 ^ v74;\n\tv79 = v77 & v78;\n\tv80 = v79 < 0;\n\tv81 = v75 == v80;\n\tv82 = ~v76;\n\tv83 = v81 & v82;\n\tv84 = ~v83;\n\tif (v84) goto L_FFFFFFFF;\n\tgoto L_004D;\nL_004D:\n\tv99 = v70 >= 0;\n\tif (v99) goto L_0053;\n\tgoto L_0053;\nL_0053:\n\tv172 = v68 * v171;\n\tv173 = this.prevScale + v172;\n\tv110 = v173 >= 0;\n\tif (v110) goto L_FFFFFFFF;\n\tgoto L_0064;\nL_0064:\n\tv143 = v141 * *([v66 @ X8_v6+14]);\n\tv145 = v141 * *([v66 @ X8_v6+10]);\n\tv162 = v141 * *([v66 @ X8_v6+C]);\n\t// 118 MakeStruct v101 @ AGGFF61E4_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v162 @ V0_v6 (System.Single), v145 @ V1_v4 (System.Single), v143 @ V2_v4 (System.Single)\n\tUnityEngine.Transform::set_localScale(v35, v101);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Update()
	{
		float t = global::UnityEngine.Mathf.Clamp01((global::UnityEngine.Time.time - global::UnityEngine.Time.fixedTime) / global::UnityEngine.Time.fixedDeltaTime);
		base.transform.localScale = global::UnityEngine.Vector3.one * global::UnityEngine.Mathf.Max(0f, prevScale + (scale - prevScale) * t);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000215")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF61EC", Offset = "0xFF61EC", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.prevScale = _scale;\n\tthis.scale = _scale;\n\tv18 = UnityEngine.Component::get_transform(this);\n\tgoto L_001B;\n\tv25 = System.Xml.ValidateNames;\n\tv26 = v25 + 0xD0;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, v17, v28, v29, v30, v31, v32, v33, _scale, v34, v35, v36, v37, v38, v39, v40);\n\tv42 = 1;\n\t*([2DD441A]) = v42;\nL_001B:\n\tv45 = System.Xml.ValidateNames;\n\tv47 = *([v45 @ X8_v3 (Il2CppClass<System.Xml.ValidateNames>)+D0]);\n\tv48 = *([v47 @ X8_v5+B8]);\n\tv50 = this.scale * *([v48 @ X8_v6+14]);\n\tv53 = this.scale * *([v48 @ X8_v6+10]);\n\tv54 = this.scale * *([v48 @ X8_v6+C]);\n\t// 46 MakeStruct v63 @ AGGFF6270_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v54 @ V0_v3 (System.Single), v53 @ V1_v1 (System.Single), v50 @ V2_v1 (System.Single)\n\tUnityEngine.Transform::set_localScale(v18, v63);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 31 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void SetScale(float _scale)
	{
		prevScale = _scale;
		scale = _scale;
		base.transform.localScale = global::UnityEngine.Vector3.one * scale;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000216")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF6278", Offset = "0xFF6278", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.scaleVel = this.popScaleVel;\n\tthis.prevScale = this.scale;\n\tv22 = this.targetScale - this.scale;\n\tv23 = v22 * this.scaleStiffness;\n\tv24 = this.scaleForce + v23;\n\tv25 = this.popScaleVel * this.scaleDamping;\n\tv26 = v24 - v25;\n\tv28 = UnityEngine.Time::get_fixedDeltaTime();\n\tv29 = v28 * v26;\n\tv30 = this.popScaleVel + v29;\n\tthis.scaleVel = v30;\n\tv33 = UnityEngine.Time::get_fixedDeltaTime();\n\tv34 = v30 * v33;\n\tv35 = this.scale + v34;\n\tthis.scale = v35;\n\tElasticScale::Update(this);\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Pop()
	{
		scaleVel = popScaleVel;
		FixedUpdate();
		Update();
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000217")]
	[global::Cpp2ILInjected.Address(RVA = "0xFF62F8", Offset = "0xFF62F8", Length = "0x24")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.scaleStiffness = *([2875990]);\n\tthis.popScaleVel = 20f;\n\tthis.targetScale = 1f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 5 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public ElasticScale()
	{
		scaleStiffness = 400f;
		scaleDamping = 15f;
		popScaleVel = 20f;
		targetScale = 1f;
	}
}
