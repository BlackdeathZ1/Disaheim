using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisaHeim
{
    public class Course : IValuable
    {
        public string Name;
        public int DurationInMinutes;
        static public double CourseHourValue = 875.0;
        public Course(string name)
        {
            Name = name;
        }
        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public double GetValue()
        {
                 int Hour = DurationInMinutes / 60;
                 int Remainder = DurationInMinutes % 60;
                 if (Remainder > 0)
                 {
                     Hour++;
                 }
                 return CourseHourValue * Hour;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}" ;
            ;
        }
    }
}
