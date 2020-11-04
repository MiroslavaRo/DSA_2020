using System;
using Wintellect.PowerCollections;


namespace DSA_Class_Work_lesson4
{
    class BigStoreTester
    {
        public static OrderedMultiDictionary<double, Article> D = new OrderedMultiDictionary<double, Article>(true);

        public static void RunTest()
        {
            Console.Clear();

            var MyArticles = new Article[]
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

            Console.WriteLine("Enter price range: ");
            Console.Write("min: ");
            Console.Write("max: ");
            double min = double.Parse(Console.ReadLine());
            double max = double.Parse(Console.ReadLine());
            Console.WriteLine($"Articles in the diapason {min} - {max}");

            var articlesInGivenRange = D.Range(min, true, max, true);
            foreach (var article in articlesInGivenRange)
            {
                foreach (var item in article.Value)
                {
                    Console.WriteLine(article.Value.ToString());
                }
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}