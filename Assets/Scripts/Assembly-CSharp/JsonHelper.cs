[global::Cpp2ILInjected.Token(Token = "0x20000B9")]
public static class JsonHelper
{
	[global::Cpp2ILInjected.Token(Token = "0x40003F2")]
	private static readonly global::Newtonsoft.Json.JsonSerializerSettings _settings;

	public static string Serialize<T>(T obj)
	{
		return global::Newtonsoft.Json.JsonConvert.SerializeObject(obj, _settings);
	}

	public static T Deserialize<T>(string json)
	{
		return global::Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json, _settings);
	}

	static JsonHelper()
	{
		global::Newtonsoft.Json.JsonSerializerSettings jsonSerializerSettings = new global::Newtonsoft.Json.JsonSerializerSettings();
		jsonSerializerSettings.ReferenceLoopHandling = global::Newtonsoft.Json.ReferenceLoopHandling.Ignore;
		jsonSerializerSettings.Converters.Add(new Float3Converter());
		jsonSerializerSettings.Converters.Add(new Float2Converter());
		_settings = jsonSerializerSettings;
	}
}
