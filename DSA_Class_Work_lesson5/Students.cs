using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Class_Work_lesson5
{
    class Students
    {
        public string name;
        public int studentNumber;
        public Students (string name, int studentNumber)
        {
            Name = name;
            StudentNumber = studentNumber;
        }
        public string Name { get; set; }
        public int StudentNumber { get; set; }
    }
}
