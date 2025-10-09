using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class Book
    {
       public string ItemId;
       public string Title;
       public double Price;

        public Book(string itemid, string title, double price)
        {
            this.ItemId = itemid;
            this.Title = title;
            this.Price = price;

        }

        public Book(string itemid, string title): 
            this(itemid,title,0)
        {}
        public Book(string itemid): 
            this(itemid, null, 0)
        {} 

        
        

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Title: {Title}, Price: {Price}";
        }



    }
}
