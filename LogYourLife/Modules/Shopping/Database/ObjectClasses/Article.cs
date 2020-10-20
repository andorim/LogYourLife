using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class Article
    {
        [PrimaryKey, AutoIncrement]
        int id { get; set; }
        string name { get; set; }
        
        int currentPriceId { get; set; }

        int brandId { get; set; }
        int measureId { get; set; }
    }
}
