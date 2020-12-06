using System;
using System.Collections.Generic;
using System.IO;

using CommandLine;

namespace ConsoleOpgave_Parser
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(Run);                
        }

        private static void Run(Options o)
        {
            if (!System.IO.File.Exists(o.File))
            {
                Console.WriteLine(o.File + " does not exists");
                return;
            }

            if (!System.IO.Directory.Exists(o.Directory))
            {
                Console.WriteLine(o.Directory + " does not exists");
                return;
            }

            try
            {
                string file = Path.GetFileName(o.File);
                File.Copy(o.File, Path.Combine(o.Directory, file), true);
                if (o.RemoveFile)
                {
                    File.Delete(o.File);
                }
                Console.WriteLine($"{o.File} is copied to {o.Directory}" + (o.RemoveFile ? " and removed" : ""));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }

        }
    }

    class Options
    {
        [Option('r', "remove", Required = false, HelpText = "Remove file after copy")]
        public bool RemoveFile { get; set; }

        [Option('f', "file", Required = true, HelpText = "File to copy")]
        public string File { get; set; }

        [Option('d', "directory", Required = true, HelpText = "Directory to copy file to")]
        public string Directory { get; set; }
    }
}
