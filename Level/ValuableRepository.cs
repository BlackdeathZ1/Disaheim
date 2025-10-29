using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace DisaHeim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new List<IValuable>();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }
        public IValuable GetValuable(string itemId)
        {

            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise merch && merch.ItemId == itemId)
                {
                    return valuable;
                }
                if (valuable is Course course && course.Name == itemId)
                {
                    return valuable;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double totalValue = 0;

            foreach (IValuable valuable in valuables)
            {

                totalValue += valuable.GetValue();
            }
            return totalValue;
        }
        public int Count()
        {
            int count = 0;
            foreach (IValuable valuable in valuables)
            {
                count++;
            }
            return count;
        }
        public void Save()
        {
            using StreamWriter sw = new StreamWriter("ValuableRepository.txt");
            foreach (IValuable valuable in valuables)
            {
                switch (valuable)
                {
                    case Book book:
                        sw.WriteLine($"Book;{book.ItemId};{book.Title};{book.Price}");
                        break;
                    case Amulet amulet:
                        sw.WriteLine($"Amulet;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                        break;
                    case Course course:
                        sw.WriteLine($"Course;{course.Name};{course.DurationInMinutes}");
                        break;
                }
            }
        }
        public void Save(string FileName)
        {
            using StreamWriter sw = new StreamWriter($"{FileName}");
            foreach (IValuable valuable in valuables)
            {
                switch (valuable)
                {
                    case Book book:
                        sw.WriteLine($"Book;{book.ItemId};{book.Title};{book.Price}");
                        break;
                    case Amulet amulet:
                        sw.WriteLine($"Amulet;{amulet.ItemId};{amulet.Quality};{amulet.Design}");
                        break;
                    case Course course:
                        sw.WriteLine($"Course;{course.Name};{course.DurationInMinutes}");
                        break;
                }
            }
        }
        public void Load()
        {
                var loadedValuables = new List<IValuable>();
                using StreamReader sr = new StreamReader("ValuableRepository.txt");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(';');
                    if (parts.Length == 0) continue;

                    switch (parts[0])
                    {
                        case "Book":
                            valuables.Add(new Book(parts[1], parts[2], double.Parse(parts[3])));
                            break;
                        case "Amulet":
                            valuables.Add(new Amulet(parts[1], Enum.Parse<Level>(parts[2]), parts[3]));
                            break;
                        case "Course":
                            valuables.Add(new Course(parts[1], int.Parse(parts[2])));
                            break;
                    }
                }
            }
        public void Load(string FileName)
        {
            var loadedValuables = new List<IValuable>();
            using StreamReader sr = new StreamReader(FileName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string[] parts = line.Split(';');
                if (parts.Length == 0) continue;

                switch (parts[0])
                {
                    case "Book":
                        valuables.Add(new Book(parts[1], parts[2], double.Parse(parts[3])));
                        break;
                    case "Amulet":
                        valuables.Add(new Amulet(parts[1], Enum.Parse<Level>(parts[2]), parts[3]));
                        break;
                    case "Course":
                        valuables.Add(new Course(parts[1], int.Parse(parts[2])));
                        break;
                }
            }
        }
    }
}
