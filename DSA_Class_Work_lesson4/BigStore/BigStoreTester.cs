using System;
using Wintellect.PowerCollections;

namespace DSA_Class_Work_lesson_6
{
    class BigStoreTester
    {


        public static void RunTest()
        {
            Console.Clear();
            OrderedMultiDictionary<double, string> articles = new OrderedMultiDictionary<double, string>(true);

            int max = 4000;
            int min = 1000;
            var r = new Random();
            for (int i = 1; i <= 10; i++)
            {
                var article = new Article("Barcode: b" + i, "Vendor: v" + i, "Title: t" + i, r.Next(min, max));
                articles.Add(article.Price, article.Title);
                articles.Add(article.Price, article.Vendor);
                articles.Add(article.Price, article.Barcode);
            }
            var GivenRange = articles.Range(min, true, max, true);
            foreach (var article in GivenRange)
            {
                Console.WriteLine($"Price: {article.Key}");
                foreach (var item in article.Value)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine();
            }
            Console.WriteLine("------------------------------");
            Console.WriteLine("Enter price range: ");
            Console.Write("min: ");
            int from = int.Parse(Console.ReadLine());
            Console.Write("max: ");
            int to = int.Parse(Console.ReadLine());

            Console.Clear();

            Console.WriteLine($"Articles in the diapason {from} - {to}: \n");
            var articlesInGivenRange = articles.Range(from, true, to, true);
            foreach (var article in articlesInGivenRange)
            {
                Console.WriteLine($"Price: {article.Key}");
                foreach (var item in article.Value)
                {
                    Console.WriteLine($"{item}");
                }
                Console.WriteLine();
            }
              
                Console.ReadLine();
            }
        }
    }
