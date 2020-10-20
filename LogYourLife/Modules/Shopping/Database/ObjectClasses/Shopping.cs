using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LogYourLife.Modules.Shopping.Database.FunctionClasses;
using SQLite;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class Shopping
    {
        [PrimaryKey, AutoIncrement]
        int id { get; set; }
        int storeId { get; set; }
        double balance { get; set; }
        DateTime date { get; set; }

        static public void CreateTable()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.CreateTable<Shopping>();
            db.Close();
        }

        public void Insert()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.Insert(this);
            db.Close();
        }

        public IEnumerable<Shopping> GetAll()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<Shopping> result = db.Query<Shopping>("SELECT * FROM Shopping ORDER BY date");
            db.Close();
            return result;
        }
    }
}
