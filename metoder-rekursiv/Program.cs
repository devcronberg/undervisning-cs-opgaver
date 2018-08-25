using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            LøkkeSomMetode(1, 10);


            // Hold console åben ved debug
            if (System.Diagnostics.Debugger.IsAttached)
            {
                Console.Write("Press any key to continue . . . ");
                Console.ReadKey();
            }


        }

        public static void LøkkeSomMetode(int start, int stop)
        {
            Console.WriteLine(start);
            if (start == stop)
                return;
            start++;
            LøkkeSomMetode(start, stop);
        }
    }
}
