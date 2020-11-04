using Magnum.Collections;
using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Class_Work_lesson4
{
    class BigStoreTester
    {
        public static void RunTest()
        {
            Console.Clear();


            var art = new Article[]
            {
                new Article("barcode1", "vendor1", "title1", 2000.0),
                new Article("barcode2", "vendor2", "title2", 2500.0),
                new Article("barcode3", "vendor3", "title3", 3000.0),
                new Article("barcode4", "vendor4", "title4", 2600.0),
                new Article("barcode5", "vendor5", "title5", 1999.0)
            };

            
            BigStore bigStore = new BigStore(art);



            BigStore.GetString();

            Console.ReadLine();
        }
    }
}
