[global::UnityEngine.RequireComponent(typeof(global::UnityEngine.SpriteRenderer))]
[global::Cpp2ILInjected.Token(Token = "0x2000054")]
public class CollectSprite : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000131")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private global::UnityEngine.SpriteRenderer spriteRenderer;

	[global::Cpp2ILInjected.Token(Token = "0x4000132")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.Vector2 pos;

	[global::Cpp2ILInjected.Token(Token = "0x4000133")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public global::UnityEngine.Vector2 prevPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000134")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::UnityEngine.Vector2 vel;

	[global::Cpp2ILInjected.Token(Token = "0x4000135")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public float startTime;

	[global::Cpp2ILInjected.Token(Token = "0x4000136")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
	public float applyForceDuration;

	[global::Cpp2ILInjected.Token(Token = "0x4000137")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public global::UnityEngine.Vector2 targetPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000138")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public global::UnityEngine.Vector2 startPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000139")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public global::System.Action onComplete;

	[global::Cpp2ILInjected.Token(Token = "0x400013A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public global::System.Func<global::UnityEngine.Vector2> getTargetPos;

	[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEE488", Offset = "0xFEE488", Length = "0x80")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv20 = Il2CppMethodInfo;\n\tgoto L_0019;\n\tv25 = Il2CppMethodInfo;\n\tv26 = v25 + 0x738;\n\tv27 = \"il2cpp_codegen_initialize_runtime_metadata\"(v26, sprite, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tv44 = 1;\n\t*([302A9A0]) = v44;\nL_0019:\n\tv47 = UnityEngine.Component::GetComponent /* +1 sharing this address */(this, *([v20 @ X22_v1 (Il2CppMethodInfo)+738]));\n\tv49 = this + 0x20;\n\tthis.spriteRenderer = v47;\n\tv51 = 0xF3F1B4(v49, v47, methodInfo, v29, v30, v31, v32, v33, v34, v35, v36, v37, v38, v39, v40, v41);\n\tUnityEngine.SpriteRenderer::set_sprite(this.spriteRenderer, sprite);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 32 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void Init(global::UnityEngine.Sprite sprite)
	{
		spriteRenderer = GetComponent<global::UnityEngine.SpriteRenderer>();
		spriteRenderer.sprite = sprite;
	}

	[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
	[global::Cpp2ILInjected.Address(RVA = "0xFEE508", Offset = "0xFEE508", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public CollectSprite()
	{
	}
}
