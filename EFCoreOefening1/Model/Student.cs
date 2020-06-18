using System.Collections.Generic;
using System.Text;

namespace EFCoreOefening1
{
    public class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public virtual List<Course> Courses { get; set; }

        private string CoursesToString()
        {
            if (Courses == null)
            {
                return "";
            }

            StringBuilder stringBuilder = new StringBuilder();
            Courses.ForEach(c => stringBuilder.AppendLine(c.CourseName));
            return stringBuilder.ToString();
        }

        public override string ToString()
        {
            return $"{StudentId} - {Name} volgt: {CoursesToString()}";
        }
    }
}
