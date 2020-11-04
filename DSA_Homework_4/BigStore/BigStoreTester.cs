using System.Collections;
using System;
using System.Collections.Generic;


namespace DSA_Class_Work_lesson4
{
    class BigStoreTester
    {
        public static Dictionary<double, Article> D = new Dictionary<double, Article>();

        public static void RunTest()
        {
            Console.Clear();

            var MyArticles = new Article[5]
            {
            new Article("barcode1", "vendor1", "title1", 2000.0),
            new Article("barcode2", "vendor2", "title2", 2500.0),
            new Article("barcode3", "vendor3", "title3", 3000.0),
            new Article("barcode4", "vendor4", "title4", 2600.0),
            new Article("barcode5", "vendor5", "title5", 1999.0)
            };
            foreach (var article in MyArticles)
            {
                D.Add(article.price, article);
            }

            Console.Write("Enter price range (min - max): ");
            string[] str = Console.ReadLine().Split(" - ");
            double min = double.Parse(str[0]);
            double max = double.Parse(str[1]);
            Console.WriteLine($"Articles in the diapason {min} - {max}");

            foreach (var article in D)
            {
                if (article.Key <= max && article.Key >= min)
                {
                    Console.WriteLine(article.Value.ToString());
                }
            }


            Console.ReadLine();
        }
    }
}