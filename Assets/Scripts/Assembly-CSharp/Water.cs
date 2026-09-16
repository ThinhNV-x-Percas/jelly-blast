[global::Cpp2ILInjected.Token(Token = "0x20000FD")]
public class Water : SpecialFluid
{
	[global::Cpp2ILInjected.Token(Token = "0x600048F")]
	[global::Cpp2ILInjected.Address(RVA = "0x1021918", Offset = "0x1021918", Length = "0x70")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSpecialFluid::OnPreComputeUpdate(this);\n\tv19 = UnityEngine.Component::get_transform(this);\n\tv22 = UnityEngine.Transform::get_position(v19);\n\tv38 = UnityEngine.Component::get_transform(this);\n\t// 38 MakeStruct v55 @ AGG1021980_1_v1 (UnityEngine.Vector3), typeof(UnityEngine.Vector3), v22 @ V0_v2 (UnityEngine.Vector3), v22.y (System.Single), -9f\n\tUnityEngine.Transform::set_position(v38, v55);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 34 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnPreComputeUpdate()
	{
		base.OnPreComputeUpdate();
		global::UnityEngine.Transform transform = base.transform;
		global::UnityEngine.Vector3 vector = transform.position;
		global::UnityEngine.Transform transform2 = base.transform;
		global::UnityEngine.Vector3 vector2 = default(global::UnityEngine.Vector3);
		vector2.x = vector.x;
		vector2.y = vector.y;
		vector2.z = -9f;
		transform2.position = vector2;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000490")]
	[global::Cpp2ILInjected.Address(RVA = "0x1021988", Offset = "0x1021988", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSpecialFluid::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Water()
	{
	}
}
