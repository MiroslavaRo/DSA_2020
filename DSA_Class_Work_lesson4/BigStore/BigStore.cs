using Magnum.Collections;
using System;
using System.Collections.Generic;
using System.Text;



namespace DSA_Class_Work_lesson4
{
    class BigStore 
    {
        public static OrderedMultiDictionary<double, Article> D = new OrderedMultiDictionary<double, Article>(true);
        
        public BigStore (Article[] article)
        {
            Console.Write("Enter price range (min - max): ");
            string[] str = Console.ReadLine().Split(" - ");
            double min = double.Parse(str[0]);
            double max = double.Parse(str[1]);
             Console.WriteLine($"Articles in the diapason {min} - {max}");
            foreach (var z in article)
            {
               
                if (z.Price <= max && z.Price >= min)                    
                {
                    D.Add(z.Price, z);
                                  
                }
            }
            
        }
        public static void GetString()
        {
            foreach (var d in D)
            {
                foreach (var item in d.Value)
                {
                    Console.Write($"Barcode: {item.Barcode}, Vendor: {item.Vendor}, Title: {item.Title}, Price: {item.Price}");
                }
                Console.WriteLine();
            }

        }





    }
}
