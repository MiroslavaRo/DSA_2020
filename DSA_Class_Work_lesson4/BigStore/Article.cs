
using System;


namespace DSA_Class_Work_lesson4
{
    class Article
    {
        private string barcode;
        private string vendor;
        private string title;
        public double price;
        public Article(string barcode, string vendor, string title, double price)
        {
           
            Barcode = barcode;
            Vendor = vendor;
            Title = title;
        }
        public string Vendor {
            get=>vendor;
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Battery can`t be empty!");
                }
                vendor = value;
            }
        }

        public string Barcode
        {
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

        public string Title
        {
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

        public double Price
        {
            get => price;
            set
            {
                bool checkprice = true;
                while (checkprice)
                {
                    try
                    {

                        if (value < 0)
                        {
                            throw new ArgumentNullException("Price can`t be negative!" + "\nPlease, enter again.");
                        }
                    }

                    catch (OverflowException of)
                    {
                        throw new Exception("Price should be numeric!" + of + "\nPlease, enter again.");
                    }
                    catch (FormatException fe)
                    {
                        throw new Exception("Price should be numeric!" + fe + "\nPlease, enter again.");

                    }
                    price = value;
                    checkprice = false;
                } 
               
            }
        }
        

    }
}
