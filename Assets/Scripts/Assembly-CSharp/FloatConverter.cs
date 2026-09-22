[global::Cpp2ILInjected.Token(Token = "0x20000B6")]
public abstract class FloatConverter<T> : global::Newtonsoft.Json.JsonConverter
{
	[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
	protected abstract int ComponentCount
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000335")]
		get;
	}

	[global::Cpp2ILInjected.Token(Token = "0x6000334")]
	protected abstract T CreateInstance(float x, float y, float z = 0f);

	public override void WriteJson(global::Newtonsoft.Json.JsonWriter writer, object value, global::Newtonsoft.Json.JsonSerializer serializer)
	{
		global::Newtonsoft.Json.Linq.JObject jObject = new global::Newtonsoft.Json.Linq.JObject();
		if (value != null)
		{
			global::System.Type type = value.GetType();
			float x = (float)type.GetField("x").GetValue(value);
			float y = (float)type.GetField("y").GetValue(value);
			jObject["x"] = x;
			jObject["y"] = y;
			if (ComponentCount == 3)
			{
				float z = (float)type.GetField("z").GetValue(value);
				jObject["z"] = z;
			}
		}
		jObject.WriteTo(writer);
	}

	public override object ReadJson(global::Newtonsoft.Json.JsonReader reader, global::System.Type objectType, object existingValue, global::Newtonsoft.Json.JsonSerializer serializer)
	{
		global::Newtonsoft.Json.Linq.JObject jObject = global::Newtonsoft.Json.Linq.JObject.Load(reader);
		float x = (float?)jObject["x"] ?? 0f;
		float y = (float?)jObject["y"] ?? 0f;
		float z = 0f;
		if (ComponentCount == 3)
		{
			z = (float?)jObject["z"] ?? 0f;
		}
		return CreateInstance(x, y, z);
	}

	public override bool CanConvert(global::System.Type objectType)
	{
		global::System.Type typeFromHandle = typeof(T);
		return objectType == typeFromHandle;
	}

	protected internal FloatConverter()
	{
	}
}
