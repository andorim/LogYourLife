using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class Store
    {
        [PrimaryKey, AutoIncrement]
        int id { get; set; }
        string name { get; set; }

    }
}
