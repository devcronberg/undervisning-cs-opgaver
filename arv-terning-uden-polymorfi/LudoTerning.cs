
public sealed class LudoTerning : Terning
{
    public bool ErGlobus()
    {
        return this.Værdi == 3;
    }
    public bool ErStjerne()
    {
        return this.Værdi == 5;
    }
    public LudoTerning() : base()
    { }

    public LudoTerning(int værdi) : base(værdi)
    { }
}
