using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DisaHeim
{
    internal interface IPersistable
    {

        public void save();
        public void save(string fileName);
        public void load(string fileName);
        public void load();
    }
}
