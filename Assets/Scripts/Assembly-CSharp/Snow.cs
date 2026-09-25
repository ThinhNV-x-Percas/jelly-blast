[global::Cpp2ILInjected.Token(Token = "0x20000CE")]
public class Snow : SpecialFluid
{
	[global::Cpp2ILInjected.Token(Token = "0x60003AC")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015EE8", Offset = "0x1015EE8", Length = "0x94")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSpecialFluid::OnPreComputeUpdate(this);\n\tv19 = UnityEngine.Component::get_transform(this);\n\tv22 = UnityEngine.Transform::get_position(v19);\n\tv40 = UnityEngine.Component::get_transform(this);\n\tv88 = this.id * 0x36A7C5AC;\n\tv71 = v88 + 0xBF4CCCCD;\n\t// 47 MakeStruct v57 @ AGG1015F74_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v22 @ V0_v2 (UnityEngine.Vector3), v22.y (System.Single), v71 @ V2_v3 (System.Int32)\n\tUnityEngine.Transform::set_position(v40, v57);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 41 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		base.OnPreComputeUpdate();
		global::UnityEngine.Vector3 pos = transform.position;
		transform.position = new global::UnityEngine.Vector3(pos.x, pos.y, id * depthStride - 0.8f);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60003AD")]
	[global::Cpp2ILInjected.Address(RVA = "0x1015F7C", Offset = "0x1015F7C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSpecialFluid::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Snow()
	{
	}
}
