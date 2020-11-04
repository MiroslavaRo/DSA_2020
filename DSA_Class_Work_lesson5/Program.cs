using System;

namespace DSA_Class_Work_lesson5
{
    class Program
    {
        static void Main(string[] args)
        {

            var unsorted = new Students[] {
            new Students("Vlad", 4),
            new Students("Peter", 1),
            new Students("Ivan", 6),
            new Students("Maria", 2),
            new Students("Robert", 5),
            new Students("Bob", 3)
            };
            

            Console.WriteLine("Unsorted:");
            foreach(var s in unsorted)
            {
                Console.Write($"Student: {s.Name}   № {s.StudentNumber}\n");
            }
            Console.WriteLine("\n-----------------------\n");
           
            Console.WriteLine("Sorted by Selection sort:");

            foreach (var s in SortedByBubble(unsorted))
            {
                Console.Write($"Student: {s.Name}   № {s.StudentNumber}\n");
            }
            Console.WriteLine("\n-----------------------\n");
            Console.Write("Enter student number:");
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("Binary Search:");
            Console.WriteLine($"Student № {BinarySearch(SortedByBubble(unsorted),num)+1} is {SortedByBubble(unsorted)[BinarySearch(SortedByBubble(unsorted),num)].Name}");

        }
       
        public static Students [] SortedByBubble(Students[] unsorted)
        {
            Students[] sortedByBubble = unsorted;
            
            
            for (int i = sortedByBubble.Length-1; i>0; i--)
            {
              
                for(int j = 0; j < i; j++)
                {
                    if(sortedByBubble[j].StudentNumber > sortedByBubble[j+1].StudentNumber)
                    {
                        int temp = sortedByBubble[j].StudentNumber;
                        sortedByBubble[j].StudentNumber = sortedByBubble[j + 1].StudentNumber;
                        sortedByBubble[j + 1].StudentNumber = temp;
                    }
                }
            }
            return sortedByBubble;


        }
       /* int binarySearch(int low, int high, int key)
        {
            while (low <= high)
            {
                int mid = (low + high) / 2;
                if (a[mid] < key)
                {
                    low = mid + 1;
                }
                else if (a[mid] > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            return -1;                //key not found
        }*/
        public static int BinarySearch(Students[] SortedByBubble, int key)
        {
            Students[] sortedByBinarySearch = SortedByBubble;
            int low = sortedByBinarySearch[0].StudentNumber;
            int high = sortedByBinarySearch[sortedByBinarySearch.Length - 1].StudentNumber;
            while (low<=high)
            {
                int mid = (low + high) / 2;
                if (sortedByBinarySearch[mid].StudentNumber < key)
                {
                    low = mid + 1;
                }
                else if (sortedByBinarySearch[mid].StudentNumber > key)
                {
                    high = mid - 1;
                }
                else
                {
                    return mid;
                }
            }
            

            return -1;
        }
    }
}
