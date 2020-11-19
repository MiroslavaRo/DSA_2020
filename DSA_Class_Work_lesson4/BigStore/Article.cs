using System;


namespace DSA_Class_Work_lesson_6
{
    class Article
    {
        public Article(string barcode, string vendor, string title, double price)
        {

            Barcode = barcode;
            Vendor = vendor;
            Title = title;
            Price = price;
        }
        public string Vendor { get; set; }
      /*  {
            get => vendor;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery can`t be empty!");
                }
                vendor = value;
            }
        }*/

        public string Barcode { get; set; }
        /*{
            get => barcode;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery can`t be empty!");
                }
                barcode = value;
            }
        }
        */
        public string Title { get; set; }
        /*  {
              get => title;
              set
              {
                  if (string.IsNullOrEmpty(value))
                  {
                      throw new ArgumentNullException("Battery can`t be empty!");
                  }
                  title = value;
              }
          }
        */
          public double Price { get; set; }
        /*{
            get => price;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Price can`t be negative!" + "\nPlease, enter again.");
                }                  
                    price = value;
                }

        }*/
       /* public override string ToString()
        {
            return $"Barcode: {barcode}, Vendor: {vendor}, Title: {title}, Price: {price}";
        }*/


    }
}