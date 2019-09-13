using System;

namespace arrays_todim
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] navne = new string[4, 2];
            navne[0, 0] = "1";
            navne[0, 1] = "Navn1";
            navne[1, 0] = "2";
            navne[1, 1] = "Navn2";
            navne[2, 0] = "3";
            navne[2, 1] = "Navn3";
            navne[3, 0] = "4";
            navne[3, 1] = "Navn4";
            Console.WriteLine(FindNavn(navne, "2"));

        }

        static string FindNavn(string[,] array, string id) {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                if (array[i, 0] == id)
                    return array[i, 1];
            }
            return "?";
        }

    }
}
