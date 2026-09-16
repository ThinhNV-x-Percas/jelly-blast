[global::System.Serializable]
[global::Cpp2ILInjected.Token(Token = "0x20000AB")]
public class GoalData
{
	[global::Cpp2ILInjected.Token(Token = "0x40003D1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public GoalType goalType;

	[global::Cpp2ILInjected.Token(Token = "0x40003D2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
	public int fluidType;

	[global::Cpp2ILInjected.Token(Token = "0x40003D3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public int count;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x40003D4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
	public int displayedCount;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x40003D5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool isComplete;

	[global::UnityEngine.HideInInspector]
	[global::Cpp2ILInjected.Token(Token = "0x40003D6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public global::UnityEngine.Sprite sprite;

	[global::Cpp2ILInjected.Token(Token = "0x6000310")]
	[global::Cpp2ILInjected.Address(RVA = "0x100CDC0", Offset = "0x100CDC0", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public GoalData()
	{
	}
}
