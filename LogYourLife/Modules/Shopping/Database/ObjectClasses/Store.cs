﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogYourLife.Modules.Shopping.Database.FunctionClasses;
using SQLite;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class Store
    {
        [PrimaryKey, AutoIncrement]
        public int id { get; set; }
        public string name { get; set; }


        public static void CreateTable()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.CreateTable<Store>();
            db.Close();
        }

        public static IEnumerable<Store> getAll()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<Store> result = db.Query<Store>("SELECT * FROM Store Order By id");
            db.Close();
            return result;
        }

        public static Store getById(int id)
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            IEnumerable<Store> result = db.Query<Store>("SELECT * FROM Store WHERE id = " + id);
            foreach(Store st in result)
            {
                return st;
            }
            return null;
        }

        override
        public string ToString()
        {
            return id +" "+name;
        }

        public void Insert()
        {
            SQLiteConnection db = DatabaseTools.getConnection();
            db.Insert(this);
            db.Close();
        }
    }
}
