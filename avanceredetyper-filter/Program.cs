using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace avanceredetyper_filter
{
    class Program
    {
        static async Task Main(string[] args)
        {

            Kennel k = new Kennel();
            k.HundInd("a", 10);
            k.HundInd("b", 15);
            k.HundInd("c", 20);
            foreach (var item in k)
                Console.WriteLine(item);
            Console.WriteLine();
            foreach (var item in k.FindHunde(i => i.Alder >= 15))
                Console.WriteLine(item);

        }

    }


    public class Hund
    {
        public int Id { get; set; }
        public string Navn { get; set; }
        public int Alder { get; set; }

        public override string ToString()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this);
        }
    }

    public class Kennel : IEnumerable<Hund>
    {

        private List<Hund> _hunde = new List<Hund>();

        public IEnumerator<Hund> GetEnumerator()
        {
            return ((IEnumerable<Hund>)_hunde).GetEnumerator();
        }

        public void HundInd(string navn, int alder)
        {
            int id = _hunde.Count > 0 ? _hunde.Max(i => i.Id) + 1 : 0;
            _hunde.Add(new Hund() { Alder = alder, Navn = navn });
        }

        public Hund HundUd(int id)
        {
            Hund h = _hunde.Find(i => i.Id == id);
            if (h != null)
            {
                _hunde.Remove(h);
                return h;
            }
            throw new ApplicationException($"Hund {id} findes ikke");
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return ((IEnumerable<Hund>)_hunde).GetEnumerator();
        }

        public List<Hund> FindHunde(Predicate<Hund> filter)
        {
            List<Hund> h = new List<Hund>();
            foreach (var item in _hunde)
                if (filter(item))
                    h.Add(item);
            return h;

            // eller med LINQ
            return _hunde.Where(new Func<Hund, bool>(filter)).ToList();
        }
    }


}
