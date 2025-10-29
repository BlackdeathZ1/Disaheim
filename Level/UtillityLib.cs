using DisaHeim;
namespace UtilityLib
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }
        public double GetValueOfAmulet(Amulet amulet)
        {
            if (amulet.Quality == Level.Low)
            {
                return 12.5;
            }
            else if (amulet.Quality == Level.Medium)
            {
                return 20;
            }
            else
            {
                return 27.5;
            }
        }
        public double GetValueOfCourse(Course course)
        {
            //cause it rounds down the decimal number i think, like 90% sure
            int Hour = course.DurationInMinutes / 60;
            //If returns the remainder lets say 
            int Remainder = course.DurationInMinutes % 60;
            if (Remainder > 0)
            {
                Hour++;
            }
            return 875.00 * Hour;
        }
        public double GetValueOfMerchandise(Merchandise merchandise)
        {
           switch (merchandise)
            {
                case Book book:
                    return GetValueOfBook(book);
                case Amulet amulet:
                    return GetValueOfAmulet(amulet);
                default:
                    return 0;
            }
                   
        }
    }
}