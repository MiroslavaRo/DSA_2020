using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA_Class_Work_lesson_11
{
    internal class _06_NumberDivBy21
    {
        private static readonly Random rnd = new Random();

        public static void RunTest()
        {
            int[] numbers = new int[100];

            for (int i = 0; i < numbers.Length; i++)
                numbers[i] = rnd.Next(200);

            Console.WriteLine("All numbers: {0}", string.Join(", ", numbers));
            Console.WriteLine("\nNumbers divisible by 7 and 3: ");
            Console.WriteLine("\n#1: Using built-in extension method:");

            // Built-in extension method
            var divisibleBy21 = numbers.Where(number => number % 21 == 0);

            Console.WriteLine(string.Join(" ", divisibleBy21));

            Console.WriteLine("\n#2: Using LINQ query:");

            // Linq query
            divisibleBy21 =
                           from number in numbers
                           where number % 21 == 0
                           select number;

            Console.WriteLine(string.Join(" ", divisibleBy21));
        }
    }
}
