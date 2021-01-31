using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA_Class_Work_lesson_11
{
    public static class Students
    {
        public static void StudentsTest()
        {
            var students = new[]
            {
                new { FirstName = "Filip", LastName = "Georgiev", Age = 23 },
                new { FirstName = "Dimityr", LastName = "Cvetkov", Age = 17 },
                new { FirstName = "Cvetelina", LastName = "Dimitrova", Age = 45 },
                new { FirstName = "Boris", LastName = "Angelov", Age = 18 },
                new { FirstName = "Angel", LastName = "Borisov", Age = 20 },
            };

            // Linq query
            var linqQuery =
                       from student in students
                       where student.FirstName.CompareTo(student.LastName) < 0
                       select new { student.FirstName, student.LastName };

            // Extension method
            var extensionMethod = students
                .Where(student => student.FirstName.CompareTo(student.LastName) < 0);

            Console.WriteLine("#1: Using LINQ query: ");
            Console.WriteLine(string.Join(Environment.NewLine, linqQuery));

            Console.WriteLine("\n#2: Using Extension method: ");
            Console.WriteLine(string.Join(Environment.NewLine, extensionMethod));

            // Linq query
            var query =
                       from student in students
                       where student.Age >= 18 && student.Age <= 24
                       select new { student.FirstName, student.LastName };

            Console.WriteLine("#1: Using LINQ query: ");
            Console.WriteLine(string.Join(Environment.NewLine, query));

            // Extension methods
            var orderedStudents = students.OrderByDescending(x => x.FirstName).ThenBy(y => y.LastName);

            Console.WriteLine("#1: Using extension methods: ");
            Console.WriteLine(string.Join(Environment.NewLine, orderedStudents));

            // Linq query
            orderedStudents =
                             from student in students
                             orderby student.FirstName descending, student.LastName descending
                             select student;

            Console.WriteLine("\n#2: Using LINQ: ");
            Console.WriteLine(string.Join(Environment.NewLine, orderedStudents));
        }
    }

}
