using System.Collections.Generic;

namespace EFCoreOefening1
{
    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }

        public override string ToString()
        {
            return $"{CourseId} - {CourseName}";
        }
    }
}
