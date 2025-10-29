using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace DisaHeim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandise = new List<Merchandise>();

        public void AddMerchandise(Merchandise merch)
        {
            merchandise.Add(merch);
        }

        public Merchandise GetMerchandise(string itemId)
        {

            foreach (Merchandise merch in merchandise)
            {
                if (merch.ItemId.Equals(itemId))
                {
                    return merch;
                }
            }
            return null;
        }

        public double GetTotalValue()
        {
            double totalvalue = 0;
            Utility utiltiy = new Utility();
            foreach (Merchandise merch in merchandise)
            {
                totalvalue += utiltiy.GetValueOfMerchandise(merch);
            }
            return totalvalue;
        }
    }
}

