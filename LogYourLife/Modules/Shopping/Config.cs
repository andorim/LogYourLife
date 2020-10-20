using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogYourLife.Modules.Shopping
{
    class Config
    {
        public static string language = Properties.Settings.Default.Language;
        public static string databaseUri = Environment.GetEnvironmentVariable("LocalAppData") + @"\Andorim\LogYourLife\Shopping\database.sqlite";
    }
}
