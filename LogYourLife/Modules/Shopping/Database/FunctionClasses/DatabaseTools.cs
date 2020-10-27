using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

using LogYourLife.Modules.Shopping.Database.ObjectClasses;
using System.Windows;

namespace LogYourLife.Modules.Shopping.Database.FunctionClasses
{
    class DatabaseTools
    {
        public static void Init()
        {
            try
            {
                String path = Environment.GetEnvironmentVariable("LocalAppData") + @"\Andorim\LogYourLife\Shopping\";
                System.IO.Directory.CreateDirectory(path);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
        public static SQLiteConnection getConnection()
        {
            return new SQLiteConnection(Config.databaseUri);
        }
        public static void CreateTables()
        {
            Store.CreateTable();
            Brand.CreateTable();
            MeasureUnit.CreateTable();
            Article.CreateTable();
            StoreArticle.CreateTabel();
            Price.CreateTable();
        }
    }
}
