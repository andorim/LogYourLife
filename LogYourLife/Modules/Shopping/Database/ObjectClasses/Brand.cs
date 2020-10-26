using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

using LogYourLife.Modules.Shopping.Database.FunctionClasses;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class Brand
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }

        public static void CreateTable()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.CreateTable<Brand>();
            db.Close();
        }

        public static IEnumerable<Brand> getAll()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<Brand> result = db.Query<Brand>("SELECT * FROM Brand Order By id");
            db.Close();
            return result;
        }

        public static Brand getById(int id)
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<Brand> result = db.Query<Brand>("SELECT * FROM Brand WHERE id = " + id);
            foreach (Brand st in result)
            {
                return st;
            }
            return null;
        }

        override
        public string ToString()
        {
            return id + " " + name;
        }

        public void Insert()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.Insert(this);
            db.Close();
        }

    }
}
