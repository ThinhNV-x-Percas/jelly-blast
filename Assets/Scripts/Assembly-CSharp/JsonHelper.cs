using Newtonsoft.Json;

public static class JsonHelper
{
    private static readonly JsonSerializerSettings _settings = new JsonSerializerSettings
    {
        ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
        Converters = { new Float3Converter(), new Float2Converter() }
    };

    public static string Serialize<T>(T obj)
    {
        return JsonConvert.SerializeObject(obj, _settings);
    }

    public static T Deserialize<T>(string json)
    {
        return JsonConvert.DeserializeObject<T>(json, _settings);
    }
}
