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
    }
}
