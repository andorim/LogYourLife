using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

using LogYourLife.Modules.Shopping.Database.FunctionClasses;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class MeasureUnit
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }

        public static void CreateTable()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.CreateTable<MeasureUnit>();
            db.Close();
        }

        public static IEnumerable<MeasureUnit> getAll()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<MeasureUnit> result = db.Query<MeasureUnit>("SELECT * FROM MeasureUnit Order By id");
            db.Close();
            return result;
        }

        public static MeasureUnit getById(int id)
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<MeasureUnit> result = db.Query<MeasureUnit>("SELECT * FROM MeasureUnit WHERE id = " + id);
            foreach (MeasureUnit st in result)
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
