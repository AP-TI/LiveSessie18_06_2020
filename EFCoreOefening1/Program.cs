using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace EFCoreOefening1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // SearchStudent("a").ForEach(Console.WriteLine);
            // SearchStudent1WithSelect("a").ForEach(Console.WriteLine);
            // SearchStudentEager("a").ForEach(Console.WriteLine);
            using SchoolContext context = new SchoolContext();
            SearchStudentLazy("a", context).ForEach(Console.WriteLine);
                        
        }

        private static void AddStudent(string name)
        {
            using SchoolContext context = new SchoolContext();
            var std = new Student
            {
                Name = name,
                Courses = new List<Course>() { new Course { CourseName = "Programmeren in .NET" } }
            };

            context.Students.Add(std);
            context.SaveChanges();
        }

        private static List<Student> SearchStudent(string name)
        {
            using SchoolContext context = new SchoolContext();
            IQueryable<Student> result = from student in context.Students where student.Name.Contains("a") select student;
            return result.ToList();
        }

        private static List<Student> SearchStudentEager(string name)
        {
            using SchoolContext context = new SchoolContext();
            return context.Students.Include(s => s.Courses).Where(s => s.Name.Contains(name)).ToList();
        }

        private static List<Student> SearchStudentLazy(string name, SchoolContext context)
        {
            return context.Students.Where(s => s.Name.Contains(name)).ToList();
        }
        /*        private static List<Student> SearchStudent1(string name, SchoolContext context)
                {
                    return context.Students.Where(s => s.Name.Contains(name)).ToList();
                }*/

        private static List<Student> SearchStudent1WithSelect(string name)
        {
            using SchoolContext context = new SchoolContext();
            return context.Students.Select(s => new Student { StudentId = s.StudentId, Name = s.Name, Courses = s.Courses }).Where(s => s.Name.Contains(name)).ToList();
        }
    }
}
