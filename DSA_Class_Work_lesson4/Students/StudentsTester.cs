using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Class_Work_lesson_6
{
    public class StudentsTester
    {
        public static void RunTest()
        {
            Console.Clear();

            Students.ReadStudents();

            Students.DisplayStudents();

            Console.ReadLine();
        }
    }
}
