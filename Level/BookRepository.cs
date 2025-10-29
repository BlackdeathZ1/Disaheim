using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace DisaHeim
{
    public class BookRepository
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }


        public Book GetBook(string itemid)
        {
            Book BookCheck = new Book(itemid);
            foreach (Book book in books)
            {
                if (book.ItemId == BookCheck.ItemId)
                {
                    return book;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            Utility utility = new Utility();

            foreach (Book book in books)
            {

                totalValue += utility.GetValueOfBook(book);
            }
            return totalValue;
        }
    }
}

