using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.Extensions.Configuration;
using CommandLine;

namespace ConsoleOpgave_Configuration
{
    class Program
    {
        static void Main(string[] args)
        {
            Parser.Default.ParseArguments<Options>(args)
                .WithParsed(Run);

        }

        static Configuration GetConfiguration()
        {
            var builder = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            var c = new Configuration();
            configuration.Bind(c);
            return c;
        }

        private static void Run(Options o)
        {
            try
            {
                var configuration = GetConfiguration();

                if (!System.IO.File.Exists(o.File))
                {
                    Console.WriteLine(o.File + " does not exists");
                    return;
                }

                if (!System.IO.Directory.Exists(configuration.Directory))
                {
                    Console.WriteLine(configuration.Directory + " does not exists");
                    return;
                }

                string file = Path.GetFileName(o.File);
                File.Copy(o.File, Path.Combine(configuration.Directory, file), true);
                if (o.RemoveFile)
                {
                    File.Delete(o.File);
                }
                Console.WriteLine($"{o.File} is copied to {configuration.Directory}" + (o.RemoveFile ? " and removed" : ""));
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
    }

    class Configuration
    {
        public string Directory { get; set; }
    }
}

