public readonly struct ParticleInitData
{
    public readonly int Index;
    public readonly int Id;
    public readonly int Local;

    public ParticleInitData(int index, int id, int local)
    {
        Index = index;
        Id = id;
        Local = local;
    }
}
