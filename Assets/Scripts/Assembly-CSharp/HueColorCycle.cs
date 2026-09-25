[global::Cpp2ILInjected.Token(Token = "0x2000032")]
public class HueColorCycle : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.Renderer _renderer;

	[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.Color baseColor;

	[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public float colorLerpSpeed;

	[global::Cpp2ILInjected.Token(Token = "0x600012D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE59E4", Offset = "0xFE59E4", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Il2CppMethodInfo;\n\tgoto L_0018;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x710;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302A955]) = v43;\nL_0018:\n\tv46 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v18 @ X21_v1 (Il2CppMethodInfo)+710]));\n\tv48 = this + 0x20;\n\tthis._renderer = v46;\n\tv56 = 0xF3F1B4(v48, v46, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		_renderer = GetComponent<global::UnityEngine.Renderer>();
	}

	[global::Cpp2ILInjected.Token(Token = "0x600012E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5A48", Offset = "0xFE5A48", Length = "0xF0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv21 = UnityEngine.Time::get_time();\n\tv23 = v21 * this.colorLerpSpeed;\n\tv25 = v23 * 0.5f;\n\tv26 = UnityEngine.Mathf::Floor(v25);\n\tv27 = v26 + v26;\n\tv28 = v23 - v27;\n\tv48 = v28 + -1f;\n\tv34 = v28 - 2f;\n\tv35 = v34 < 0;\n\tv36 = v34 == 0;\n\tv37 = v28 ^ 2f;\n\tv38 = v28 ^ v34;\n\tv39 = v37 & v38;\n\tv40 = v39 < 0;\n\tv42 = v35 == v40;\n\tv43 = ~v36;\n\tv44 = v42 & v43;\n\tv45 = ~v44;\n\tif (v45) goto L_0033;\n\tgoto L_0033;\nL_0033:\n\tv58 = v28 >= 0;\n\tif (v58) goto L_FFFFFFFF;\n\tgoto L_0039;\nL_0039:\n\tv62 = UnityEngine.Mathf::Abs(v61);\n\tv63 = 1f - v62;\n\t// 64 MakeStruct v69 @ AGGFE5ABC_0_v1 (UnityEngine.Color), typeof(UnityEngine.Color), this.baseColor (UnityEngine.Color), this.baseColor.g (System.Single), this.baseColor.b (System.Single), this.baseColor.a (System.Single)\n\tv70 = HSBColor::FromColor(v69);\n\tHSBColor::.ctor(&v77 @ stack_-50_v2 (HSBColor), v63, v70.s, v70.b);\n\t// 80 MakeStruct v87 @ AGGFE5AE0_0_v1 (HSBColor), typeof(HSBColor), v77 @ stack_-50_v2 (HSBColor), v82 @ stack_-4C, 0, v85 @ stack_-44\n\tv88 = HSBColor::ToColor(v87);\n\tv98 = UnityEngine.Renderer::get_material(this._renderer);\n\t// 100 MakeStruct v122 @ AGGFE5B18_1_v1 (UnityEngine.Color), typeof(UnityEngine.Color), v88 @ V0_v10 (UnityEngine.Color), v88.g (System.Single), v88.b (System.Single), this.baseColor.a (System.Single)\n\tUnityEngine.Material::set_color(v98, v122);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 78 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Update()
	{
		float h = 1f - global::UnityEngine.Mathf.Abs(global::UnityEngine.Mathf.Repeat(global::UnityEngine.Time.time * colorLerpSpeed, 2f) - 1f);
		HSBColor hsb = HSBColor.FromColor(baseColor);
		global::UnityEngine.Color color = HSBColor.ToColor(new HSBColor(h, hsb.s, hsb.b));
		color.a = baseColor.a;
		_renderer.material.color = color;
	}

	[global::Cpp2ILInjected.Token(Token = "0x600012F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE5B38", Offset = "0xFE5B38", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.colorLerpSpeed = 2f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public HueColorCycle()
	{
		colorLerpSpeed = 2f;
	}
}
