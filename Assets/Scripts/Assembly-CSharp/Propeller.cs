[global::Cpp2ILInjected.Token(Token = "0x20000C7")]
public class Propeller : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000451")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.Rigidbody2D rb;

	[global::Cpp2ILInjected.Token(Token = "0x4000452")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public float angularVel;

	[global::Cpp2ILInjected.Token(Token = "0x6000392")]
	[global::Cpp2ILInjected.Address(RVA = "0x10144F0", Offset = "0x10144F0", Length = "0x64")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv18 = Il2CppMethodInfo;\n\tgoto L_0018;\n\tv23 = Il2CppMethodInfo;\n\tv24 = v23 + 0x720;\n\tv25 = \"il2cpp_codegen_initialize_runtime_metadata\"(v24, methodInfo, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\tv43 = 1;\n\t*([302AA7E]) = v43;\nL_0018:\n\tv46 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v18 @ X21_v1 (Il2CppMethodInfo)+720]));\n\tv48 = this + 0x20;\n\tthis.rb = v46;\n\tv56 = 0xF3F1B4(v48, v46, v27, v28, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40);\n\treturn;\n// 26 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Awake()
	{
		//IL_0021: Expected O, but got I
		nint num = 0;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @111C708 (UnityEngine.Component::GetComponent, and 1 more at this address)");
		object obj = (nint)this + 32;
		global::UnityEngine.Rigidbody2D rigidbody2D = default(global::UnityEngine.Rigidbody2D);
		rb = rigidbody2D;
		global::Cpp2ILInjected.Cpp2ILHelpers.NoteDecompilerIssue("Method not found @F3F1B4");
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000393")]
	[global::Cpp2ILInjected.Address(RVA = "0x1014554", Offset = "0x1014554", Length = "0x28")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.Rigidbody2D::set_angularVelocity(this.rb, this.angularVel);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 13 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void FixedUpdate()
	{
		rb.angularVelocity = angularVel;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000394")]
	[global::Cpp2ILInjected.Address(RVA = "0x101457C", Offset = "0x101457C", Length = "0x10")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tthis.angularVel = 100f;\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 2 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Propeller()
	{
		angularVel = 100f;
	}
}
