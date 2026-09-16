[global::Cpp2ILInjected.Token(Token = "0x2000057")]
public struct CollectParticleData
{
	[global::Cpp2ILInjected.Token(Token = "0x400014B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
	public CollectParticleMode mode;

	[global::Cpp2ILInjected.Token(Token = "0x400014C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
	public global::UnityEngine.Vector2 prevPos;

	[global::Cpp2ILInjected.Token(Token = "0x400014D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
	public global::UnityEngine.Vector2 vel;

	[global::Cpp2ILInjected.Token(Token = "0x400014E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public float startTime;

	[global::Cpp2ILInjected.Token(Token = "0x400014F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public float applyForceDuration;

	[global::Cpp2ILInjected.Token(Token = "0x4000150")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public global::UnityEngine.Vector2 targetPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000151")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
	public global::UnityEngine.Vector2 startPos;

	[global::Cpp2ILInjected.Token(Token = "0x4000152")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
	public float innerRadius;

	[global::Cpp2ILInjected.Token(Token = "0x4000153")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float explodeDuration;

	[global::Cpp2ILInjected.Token(Token = "0x4000154")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
	public int particleId;

	[global::Cpp2ILInjected.Token(Token = "0x4000155")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public global::System.Action onComplete;

	[global::Cpp2ILInjected.Token(Token = "0x4000156")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public global::System.Func<global::UnityEngine.Vector2> getTargetPos;
}
