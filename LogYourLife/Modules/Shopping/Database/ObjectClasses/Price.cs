using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogYourLife.Modules.Shopping.Database.FunctionClasses;
using SQLite;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class Price
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public int articleId { get; set; }
        public int storeId { get; set; }
        public DateTime date { get; set; }
        public double value { get; set; }

        public static void CreateTable()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.CreateTable<Price>();
            db.Close();
        }

        public static IEnumerable<Price> getPrice(int articleId, int storeId)
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<Price> pr = db.Query<Price>("SELECT * FROM Price WHERE articleId='" + articleId + "' and storeId='" + storeId + "' ORDER BY date DESC");
            return pr;
        }

        public void Insert()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.Insert(this);
            db.Close();
        }

        public static int getLastId()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            Price pr = db.Query<Price>("SELECT id FROM Price ORDER BY id DESC Limit 1")[0];
            return pr.id;
        }
        
    }
}
