using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Class_Work_lesson_6
{
    public class SuperHero : IPrioritizable
    {
        public SuperHero(double priority, string name, string superPower)
        {
            Priority = priority;
            Name = name;
            SuperPower = superPower;
        }

        public string SuperPower;

        public string Name;

        public double Priority { get; set; }
    }
}
