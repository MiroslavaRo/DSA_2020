using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace DSA_Class_Work_lesson_6
{
    public static class Students
    {
        public static SortedDictionary<string, SortedSet<string>> courses = new SortedDictionary<string, SortedSet<string>>();

        public static void DisplayStudents()
        {
            foreach (var course in courses)
            {
                Console.Write(course.Key);
                foreach (var student in course.Value)
                {
                    Console.Write($" {student}, ");
                }
                Console.WriteLine();
            }
        }

        public static void ReadStudents()
        {
            // Create instance of StreamReader to read from file
            StreamReader reader = new StreamReader(@"D:\VUM STUDY\Data Structure and Algorithms\DSA 2020\DSA_Class_Work_lesson4\students.txt");
            
            // Read first line
            string line = reader.ReadLine();

            // Read other lines
            while (line != null)
            {
                var data = line.Split("|");

                var firstName = data[0].Trim();
                var lastName = data[1].Trim();
                var course = data[2].Trim();

                if (!courses.ContainsKey(course))
                {
                    courses.Add(course, new SortedSet<string> { firstName + " " + lastName });
                }
                else
                {
                    courses[course].Add(firstName + " " + lastName);
                }

                line = reader.ReadLine();
            }

            reader.Close();
        }
    }
}
