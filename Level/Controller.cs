using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class Controller
    {
        public List<Book> Books;
        public List<Amulet> Amulets;
    public Controller()
        {
            Books = new();
            Amulets = new();
        }
        public void AddToList(Book book)
        {
            Books.Add(book);
        }
        public void AddToList(Amulet amulet)
        {
            Amulets.Add(amulet);
        }
    } 
}
