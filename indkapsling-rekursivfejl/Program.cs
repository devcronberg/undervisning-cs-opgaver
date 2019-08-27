namespace indkapsling_rekursivfejl
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.Navn = "x";
            System.Console.WriteLine(p.Navn);
        }
    }

    class Person
    {
        private string navn;

        public string Navn
        {
            get { return navn; }
            set {
                // value skal tildeles feltet og ikke set-delen af egenskaben (skaber 
                // et rekursivt kald)
                navn = value;   // ikke Navn = value;
            }
        }
    }
}
