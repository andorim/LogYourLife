using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class Shopping_Item
    {
        [PrimaryKey, AutoIncrement]
        int id { get; set; }
        int shoppingID { get; set; }
        int articleID { get; set; }
        int amount { get; set; }
        double article_price { get; set; }
        double line_price { get; set; }


        


    }
}
