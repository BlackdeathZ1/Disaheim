using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtilityLib;

namespace DisaHeim
{
    public class CourseRepository
    {
        private List<Course> courses = new List<Course>();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }
        public Course GetCourse(string name)
        {
            Course CourseCheck = new Course(name);
            foreach (Course course in courses)
            {
                if (course.Name == CourseCheck.Name)
                {
                    return course;
                }
            }
            return null;
        }
        public double GetTotalValue()
        {
            double totalValue = 0;
            Utility utility = new Utility();

            foreach (Course course in courses)
            {

                totalValue += utility.GetValueOfCourse(course);
            }
            return totalValue;
        }
    }
}
