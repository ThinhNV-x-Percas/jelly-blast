[global::Cpp2ILInjected.Token(Token = "0x20000B1")]
public class Ice : Block
{
	[global::Cpp2ILInjected.Token(Token = "0x6000324")]
	[global::Cpp2ILInjected.Address(RVA = "0x100E378", Offset = "0x100E378", Length = "0xF0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tgoto L_001E;\n\tv27 = Il2CppMethodInfo;\n\tv28 = v27 + 0x720;\n\tv29 = \"il2cpp_codegen_initialize_runtime_metadata\"(v28, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv55 = Il2CppMethodInfo;\n\tv56 = v55 + 0xC80;\n\tv57 = \"il2cpp_codegen_initialize_runtime_metadata\"(v56, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv62 = System.Collections.Generic.List`1<UnityEngine.UIElements.StyleSheets.Syntax.Expression>;\n\tv63 = v62 + 0xA40;\n\tv46 = \"il2cpp_codegen_initialize_runtime_metadata\"(v63, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\n\tv48 = 1;\n\t*([302AA5B]) = v48;\nL_001E:\n\tv49 = Il2CppMethodInfo;\n\tgoto L_0027;\n\tv58 = \"il2cpp_codegen_runtime_class_init\"(v51, methodInfo, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41, v42, v43, v44);\nL_0027:\n\tv61 = Singleton`1::get_Instance /* +1 sharing this address */(*([v49 @ X21_v2 (Il2CppMethodInfo)+C80]));\n\tv67 = UnityEngine.Component::get_transform(this);\n\tv69 = Il2CppMethodInfo;\n\tv72 = UnityEngine.Transform::get_position(v67);\n\tv88 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v69 @ X21_v5 (Il2CppMethodInfo)+720]));\n\tv83 = UnityEngine.Rigidbody2D::get_velocity(v88);\n\t// 79 MakeStruct v99 @ AGG100E460_1_v1 (UnityEngine.Vector2), typeof(UnityEngine.Vector2), v72 @ V0_v2 (UnityEngine.Vector3), v72.y (System.Single)\n\tCollectionManager::OnCollectIceBlock(v61, v99, v83);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 59 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public override void OnClear()
	{
		global::UnityEngine.Vector3 position = base.transform.position;
		global::UnityEngine.Rigidbody2D rigidbody2D = GetComponent<global::UnityEngine.Rigidbody2D>();
		global::UnityEngine.Vector2 velocity = rigidbody2D.velocity;
		global::UnityEngine.Vector2 pos = new global::UnityEngine.Vector2(position.x, position.y);
		Singleton<CollectionManager>.Instance.OnCollectIceBlock(pos, velocity);
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000325")]
	[global::Cpp2ILInjected.Address(RVA = "0x100E468", Offset = "0x100E468", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tBlock::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Ice()
	{
	}
}
