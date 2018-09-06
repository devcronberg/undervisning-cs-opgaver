using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasser_singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            AppSettings appSettings = AppSettings.HentAppSettings();
            appSettings.AppId = 10;
            Console.WriteLine(appSettings.AppId);   // 10
            appSettings = AppSettings.HentAppSettings();
            Console.WriteLine(appSettings.AppId);   // 10
        }
    }

    class AppSettings
    {
        public int AppId;
        private static AppSettings o = null;

        public static AppSettings HentAppSettings()
        {
            if (o == null)
                o = new AppSettings();
            return o;
        }
    }
}
