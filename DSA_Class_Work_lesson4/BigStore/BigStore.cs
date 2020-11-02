using Magnum.Collections;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Text;
using Magnum.Collections;

namespace DSA_Class_Work_lesson4
{
    class BigStore 
    {
        public static OrderedMultiDictionary<int, Article> D = new OrderedMultiDictionary <int, Article>();

        public static void DisplayArticles()
        {
            Console.Write("Enter price range (min - max): ");
            string [] str = Console.ReadLine().Split(" - ");
            int min = int.Parse(str[0]);
            int max = int.Parse(str[1]);
            foreach (var z in D)
            {
                var price = z.Key;
                if (price <= max && price >= min)
                    Console.WriteLine($"Articles in the diapason {min} - {max}");
                {
                    Console.WriteLine($" {z.Value}, {z.Key} ");
                }
            }
        }
       /* public void Add(TEntry entry)
        {
            D.Add();

        }*/


    }
}
