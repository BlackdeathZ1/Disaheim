using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public abstract class Merchandise
    {
        public string ItemId;

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }

}
