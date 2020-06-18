using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace EFCoreOefening1
{
    class Student
    {
        public int StudentId { get; set; }
        public string Name { get; set; }
        public List<Course> Courses { get; set; }

        private string CoursesToString()
        {
            if (Courses == null) return "";
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
