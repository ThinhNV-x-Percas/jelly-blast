[global::Cpp2ILInjected.Token(Token = "0x2000040")]
public class Bee : RotatingSpecialFluid
{
	[global::Cpp2ILInjected.Token(Token = "0x600016D")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7E20", Offset = "0xFE7E20", Length = "0xC")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.id = _id;\n\tSpecialFluid::Init(this, _solver, _particleIds, _fluidType, _compute);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Init(FluidSolver _solver, global::System.Collections.Generic.HashSet<int> _particleIds, int _fluidType, FluidCompute _compute, int _id)
	{
		id = _id;
		base.Init(_solver, _particleIds, _fluidType, _compute);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600016E")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7E2C", Offset = "0xFE7E2C", Length = "0x8C")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tRotatingSpecialFluid::OnPreComputeUpdate(this);\n\tv19 = UnityEngine.Component::get_transform(this);\n\tv22 = UnityEngine.Transform::get_position(v19);\n\tv40 = UnityEngine.Component::get_transform(this);\n\tv87 = this.id * 0x36A7C5AC;\n\tv71 = v87 + -6.25f;\n\t// 45 MakeStruct v57 @ AGGFE7EB0_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v22 @ V0_v2 (UnityEngine.Vector3), v22.y (System.Single), v71 @ V2_v3 (System.Single)\n\tUnityEngine.Transform::set_position(v40, v57);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 39 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		base.OnPreComputeUpdate();
		global::UnityEngine.Vector3 pos = transform.position;
		transform.position = new global::UnityEngine.Vector3(pos.x, pos.y, id * depthStride - 6.25f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x600016F")]
	[global::Cpp2ILInjected.Address(RVA = "0xFE7EB8", Offset = "0xFE7EB8", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tRotatingSpecialFluid::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Bee()
	{
	}
}
