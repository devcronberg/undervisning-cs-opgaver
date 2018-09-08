using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SetFooter
{
    class Program
    {
        static string root = @"c:\git\undervisning-cs-opgaver";
        static void Main(string[] args)
        {
            string text = "> Denne opgave må ikke benyttes uden tilladelse fra Michell Cronberg (michell@cronberg.dk)";
            var files = System.IO.Directory.GetFiles(root, "index.md", System.IO.SearchOption.AllDirectories);
            foreach (var file in files)
            {                
                string content = System.IO.File.ReadAllText(file);
                if (content.Contains("<!-- footerstart -->") && content.Contains("<!-- footerslut -->"))
                { }
                else
                {
                    string append = $"\r\n<!-- footerstart -->\r\n{text}\r\n<!-- footerslut -->";
                    System.IO.File.AppendAllText(file, append);                    
                }
            }
        }
    }
}
