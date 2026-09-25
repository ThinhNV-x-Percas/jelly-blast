using System.Runtime.CompilerServices;

internal static class HashUtil
{
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static uint Hash(int x, int y)
    {
        return (uint)(x * 0x3DCF + y * 0x949475);
    }
}
