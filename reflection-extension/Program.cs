using System;
// Bemærk!!
using Teknologisk;

namespace reflection_extension
{
    class Program
    {
        static void Main(string[] args)
        {
            string navn = "miKkel";
            Console.WriteLine(navn.FormatName());
        }
    }
}

namespace Teknologisk
{
    public static class MyString
    {
        public static string FormatName(this string name)
        {
            if (name != null && name != "")
            {
                string res = name.Substring(0, 1).ToUpper() + name.Substring(1);
                return res;
            }
            return name;
        }
    }
}

