using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SQLite;

namespace LogYourLife.Modules.Shopping.Database.ObjectClasses
{
    class Price
    {
        [PrimaryKey, AutoIncrement]
        int id { get; set; }
        int articleId { get; set; }
        int storeId { get; set; }
        DateTime date { get; set; }
        double value { get; set; }

        
        
    }
}
