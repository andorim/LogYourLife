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
    class Article
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string barcode { get; set; }
        public string name { get; set; }       
        public int currentPriceId { get; set; }
        public int brandId { get; set; }
        public double amount { get; set; }
        public int measureId { get; set; }

        public static void CreateTable()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.CreateTable<Article>();
            db.Close();
        }

        public void Insert()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.Insert(this);
            db.Close();
        }

        public void Update()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.Update(this);
            db.Close();
        }

        /*public static IEnumerable<Article> getArticleByStoreId(int storeId)
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<Article> art = db.Query<Article>("")
        }*/

        public static int getLastId()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            Article art = db.Query<Article>("SELECT id FROM Article ORDER BY id DESC Limit 1")[0];
            return art.id;
        }

        public static IEnumerable<Article> getAll()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<Article> art = db.Query<Article>("SELECT * FROM Article ORDER BY id");
            db.Close();
            return art;
        }

        override
        public string ToString()
        {
            return id + " " + name + " " + currentPriceId + " " + brandId + " " + amount + " " + measureId;
        }
    }
}
