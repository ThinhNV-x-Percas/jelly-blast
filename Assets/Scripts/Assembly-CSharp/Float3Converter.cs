using Unity.Mathematics;

public class Float3Converter : FloatConverter<float3>
{
    protected override int ComponentCount => 3;

    protected override float3 CreateInstance(float x, float y, float z = 0f)
    {
        return new float3(x, y, z);
    }
}
