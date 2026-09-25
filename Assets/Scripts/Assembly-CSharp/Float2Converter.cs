using Unity.Mathematics;

public class Float2Converter : FloatConverter<float2>
{
    protected override int ComponentCount => 2;

    protected override float2 CreateInstance(float x, float y, float z = 0f)
    {
        return new float2(x, y);
    }
}
