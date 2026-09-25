using System.Threading;

public static class IdGenerator
{
    private static int _nextId;

    public static int Next()
    {
        return Interlocked.Increment(ref _nextId);
    }

    public static void Reset()
    {
        _nextId = 0;
    }
}
