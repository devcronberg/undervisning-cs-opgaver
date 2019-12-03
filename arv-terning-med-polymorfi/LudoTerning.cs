
using System;

public class LudoTerning : Terning
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

    public override void Skriv()
    {
        if(ErGlobus())
        {
            Console.WriteLine("[G]");
            return;
        }
        
        if(ErStjerne())
        {
            Console.WriteLine("[S]");
            return;
        }
        
        base.Skriv();       
        
    }

}
