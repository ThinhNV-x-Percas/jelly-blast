using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Unity.Mathematics;

public abstract class FloatConverter<T> : JsonConverter
{
    protected abstract int ComponentCount { get; }

    protected abstract T CreateInstance(float x, float y, float z = 0f);

    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        var jObject = new JObject();
        if (value is float2 f2)
        {
            jObject["x"] = f2.x;
            jObject["y"] = f2.y;
        }
        else if (value is float3 f3)
        {
            jObject["x"] = f3.x;
            jObject["y"] = f3.y;
            jObject["z"] = f3.z;
        }
        jObject.WriteTo(writer);
    }

    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        JObject jObject = JObject.Load(reader);
        float x = jObject["x"]?.Value<float>() ?? 0f;
        float y = jObject["y"]?.Value<float>() ?? 0f;
        float z = ComponentCount == 3 ? jObject["z"]?.Value<float>() ?? 0f : 0f;
        return CreateInstance(x, y, z);
    }

    public override bool CanConvert(Type objectType)
    {
        return objectType == typeof(T);
    }
}
