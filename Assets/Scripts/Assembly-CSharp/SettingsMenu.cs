[global::Cpp2ILInjected.Token(Token = "0x2000013")]
public class SettingsMenu : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x400006C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	private bool showSettings;

	[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDBBF0", Offset = "0xFDBBF0", Length = "0x40")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv13 = this.showSettings ^ 1;\n\tthis.showSettings = v13;\n\tv15 = UnityEngine.Component::get_gameObject(this);\n\tUnityEngine.GameObject::SetActive(v15, this.showSettings);\n\treturn;\n\tthrow System.NullReferenceException;\n\treturn;\n// 18 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ToggleActive()
	{
		int num = (showSettings ? 1 : 0) ^ 1;
		showSettings = (byte)num != 0;
		global::UnityEngine.GameObject gameObject = base.gameObject;
		gameObject.SetActive(showSettings);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDBC30", Offset = "0xFDBC30", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public SettingsMenu()
	{
	}
}
