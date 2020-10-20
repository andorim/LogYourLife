using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace LogYourLife.Modules.Shopping.Database.FunctionClasses
{
    class DatabaseTools
    {
        public static void Init()
        {
            System.IO.Directory.CreateDirectory(@"%localappdata%\Andorim\LogYourLife\");
        }
        public static SQLiteConnection getConnection()
        {
            return new SQLiteConnection(Config.databaseUri);
        }
    }
}
