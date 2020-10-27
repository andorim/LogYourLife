using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogYourLife.Modules.Shopping.Database.FunctionClasses;
using SQLite;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class StoreArticle
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public int storeId { get; set; }
        public int articleId { get; set; }

        public StoreArticle()
        {

        }

        public StoreArticle(int storeId, int articleId)
        {
            this.storeId = storeId;
            this.articleId = articleId;
        }

        public static void CreateTabel()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.CreateTable<StoreArticle>();
            db.Close();
        }

        public void Insert()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.Insert(this);
            db.Close();
        }
    }
}
