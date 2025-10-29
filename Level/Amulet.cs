using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class Amulet : Merchandise
    {
        public string Design;
        public Level? Quality;
        public static double LowQualityValue = 12.5;
        public static double MediumQualityValue = 20;
        public static double HighQualityValue = 27.5; 

        public Amulet(string itemid, Level? quality, string design) 
        {
            this.ItemId = itemid;
            this.Quality = quality;
            this.Design = design;
        }

        public Amulet(string itemid, Level? quality): 
            this(itemid,quality,null)
        {}

        public Amulet(string itemid):
            this(itemid,Level.Medium,null)
       
        {}


        public override double GetValue()
        {
            if (Quality == Level.Low)
            {
                return 12.5;
            }
            else if (Quality == Level.Medium)
            {
                return 20;
            }
            else
            {
                return 27.5;
            }
        }

        public override string ToString()
        {
            return $"ItemId: {ItemId}, Quality: {Quality}, Design: {Design}";
        }
    }
    
}
