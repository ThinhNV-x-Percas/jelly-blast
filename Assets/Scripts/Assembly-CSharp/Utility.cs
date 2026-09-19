[global::Cpp2ILInjected.Token(Token = "0x2000015")]
public class Utility
{
	[global::Cpp2ILInjected.Token(Token = "0x400006E")]
	private static global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Texture> _textures;

	[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
	public static global::System.Collections.IEnumerator GetTexture(string id, string url, global::System.Action<global::UnityEngine.Texture> callback)
	{
		if (_textures.ContainsKey(id))
		{
			callback(_textures[id]);
			yield break;
		}
		global::UnityEngine.Networking.UnityWebRequest www = global::UnityEngine.Networking.UnityWebRequestTexture.GetTexture(url);
		yield return www.SendWebRequest();
		if (www.responseCode == 200)
		{
			global::UnityEngine.Texture2D content = global::UnityEngine.Networking.DownloadHandlerTexture.GetContent(www);
			callback(content);
		}
		else
		{
			global::UnityEngine.Debug.Log(www.error);
		}
	}

	[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
	[global::Cpp2ILInjected.Address(RVA = "0xFDBC6C", Offset = "0xFDBC6C", Length = "0x8")]
	[global::AssetRipperInjected.NativeSource(Body = "// Approximate reconstruction from native code. Reads as C#; does not compile.\n\tSystem.Object::.ctor(this);\n\treturn;\n// 1 bookkeeping instructions omitted: flag registers, address bases and no-ops.\n")]
	public Utility()
	{
	}

	static Utility()
	{
		_textures = new global::System.Collections.Generic.Dictionary<string, global::UnityEngine.Texture>();
	}
}
