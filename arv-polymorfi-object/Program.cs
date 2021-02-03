using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json; // Kun til JSON (ekstra opgaven)

namespace arv_polymorfi_object
{
    class Program
    {
        static void Main(string[] args)
        {

            Faktura f = new Faktura() { Nr = 1, Kunde = "abc", Dato = DateTime.Now.Date };
            Console.WriteLine(f.ToString());

        }
    }

    class Faktura
    {
        public int Nr { get; set; }
        public string Kunde { get; set; }
        public DateTime Dato { get; set; }

        public override string ToString()
        {
            return $"Faktura til {Kunde} nr {Nr} fra {Dato:D}.";
        }
        
        // public override string ToString()
        // {
        //    return JsonSerializer.Serialize(this);
        // }
    }

}
