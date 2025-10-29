using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;
//
//
//namespace DisaHeim
//{
//    public class AmuletRepository
//    {
//        private List<Amulet> amulets = new List<Amulet>();
//
//        public void AddAmulet(Amulet amulet)
//        {
//            amulets.Add(amulet);
//        }
//        public Amulet GetAmulet(string itemid)
//        {
//            Amulet AmuletCheck = new Amulet(itemid);
//            foreach (Amulet amulet in amulets) 
//            {
//                if (amulet.ItemId == AmuletCheck.ItemId)
//                {
//                    return amulet;
//                }
//            }
//            return null;
//        }
//        public double GetTotalValue()
//        {
//            double totalValue = 0;
//            Utility utility = new Utility();
//            
//            foreach (Amulet amulet in amulets)
//            {
//
//               totalValue += utility.GetValueOfAmulet(amulet);
//            }
//            return totalValue;
//        }
//    }
//}
//