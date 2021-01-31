using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Class_Work_lesson_11
{
    public class MultiDelegates
    {
        public static int PrintString(string str)
        {
            Console.WriteLine("Str: {0}", str);
            return 1;
        }

        public int PrintStringLength(string value)
        {
            Console.WriteLine("Length: {0}", value.Length);
            return 2;
        }
    }
}
