[global::Cpp2ILInjected.Token(Token = "0x200001E")]
public class FBWindowsExampleTabsManager : global::UnityEngine.MonoBehaviour
{
	[global::Cpp2ILInjected.Token(Token = "0x4000086")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public global::UnityEngine.GameObject[] sections;

	[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDD2A0", Offset = "0xFDD2A0", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tFBWindowsExampleTabsManager::ShowTab(this, 0);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	private void Start()
	{
		ShowTab(0);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDD2A8", Offset = "0xFDD2A8", Length = "0xA0")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tv117 = this.sections;\n\tv34 = v117.Length < 1;\n\tif (v34) goto L_0052;\nL_0023:\n\tUnityEngine.GameObject::SetActive(v117[v54 @ X22_v6 (System.Int32)], 0);\n\tv54 = v54 + 1;\n\tv63 = v54 < v117.Length;\n\tif (v63) goto L_0023;\n\tv117 = this.sections;\nL_0052:\n\tUnityEngine.GameObject::SetActive(v117[id @ X1 (System.Int32)], 1);\n\treturn;\n\tv118 = new System.NullReferenceException();\n\tthrow System.IndexOutOfRangeException;\n\treturn;\n// 74 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public void ShowTab(int id)
	{
		global::UnityEngine.GameObject[] array = sections;
		if (array.Length >= 1)
		{
			int num = 0;
			do
			{
				array[num].SetActive(value: false);
				num++;
			}
			while (num < array.Length);
			array = sections;
		}
		array[id].SetActive(value: true);
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDD348", Offset = "0xFDD348", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tUnityEngine.MonoBehaviour::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public FBWindowsExampleTabsManager()
	{
	}
}
