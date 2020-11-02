using System;
using System.Collections.Generic;
using System.Text;

namespace DSA_Class_Work_lesson4
{
    class Article
    {
        public Article(int price, string barcode, string vendor, string title)
        {
            Price = price;
            Barcode = barcode;
            Vendor = vendor;
            Title = title;
        }
        public string Vendor;

        public string Barcode;

        public string Title;
        public double Price { get; set; }


    }
}
