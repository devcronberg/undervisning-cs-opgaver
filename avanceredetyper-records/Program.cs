namespace avanceredetyper_records
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(1, "A", 10, true);
            Person p2 = new Person(1, "A", 10, true);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p1 == p2);

            Person p3 = p1 with { Navn = "B" };
            Console.WriteLine(p3);

        }
    }

    public record Person(int Id, string Navn, int Alder, bool ErDansk);

    public record PersonEkstra(int Id, string Navn, int Alder, bool ErDansk) {
        public string NavnMedStort => Navn.ToUpper();
    }
}
