using System;
using System.Collections;
using System.Collections.Generic;

namespace DSA_Class_Work_lesson2
{
    class Program
    {

        private static List<int> ListItem = new List<int>();


        static void Main(string[] args)
        {
            // StudentMarks();
            // StudentMarks2();
            // SortedDict();
            // MenuList();
            // task02();
             //task03();
           


       /*     static void StudentMarks()
            {
                Dictionary<string, int> studentMarks = new Dictionary<string, int>();
                studentMarks.Add("Jane", 90);
                studentMarks.Add("Jojo", 80);
                studentMarks.Add("Peter", 70);
                studentMarks.Add("Jay", 30);

                while (true) {
                    Console.WriteLine("--------------------------------------");
                    foreach ( var studentMark in studentMarks)
                    {
                        Console.WriteLine($"Student {studentMark.Key}, mark = {studentMark.Value} ");
                    }
                    Console.WriteLine("--------------------------------------");
                Console.Write("Student name (type 'exit' to exit): ");
                string name = Console.ReadLine();
                    if (name == "exit")
                    {
                        break;
                    }
                    if (studentMarks.ContainsKey(name))
                    {
                        Console.WriteLine($"Student '{name}' score is {studentMarks[name]}.");
                    }
                    else
                    {
                        Console.WriteLine($"Student '{name}' dosen't exist.");
                    }
                }

            }
            static void StudentMarks2()
            {
                Dictionary<string, int> studentMarks = new Dictionary<string, int>();
                studentMarks.Add("Jane", 90);
                studentMarks.Add("Jojo", 80);
                studentMarks.Add("Peter", 70);
                studentMarks.Add("Jay", 30);

                while (true)
                {
                    Console.WriteLine("--------------------------------------");
                    foreach (var studentMark in studentMarks)
                    {
                        Console.WriteLine($"Student {studentMark.Key}, mark = {studentMark.Value} ");
                    }
                    Console.WriteLine("--------------------------------------");
                    Console.Write("Student name (type 'exit' to exit): ");
                    string name = Console.ReadLine();
                    if (name == "exit")
                    {
                        break;
                    }
                    
                    if (studentMarks.TryGetValue(name, out int value))
                    {
                        Console.WriteLine($"Student '{name}' score is {value}.");
                    }
                    else
                    {
                        Console.WriteLine($"Student '{name}' dosen't exist.");
                    }
                }

            }
             static void SortedDict()
             {
                string text = " text some a text just some text";
                IDictionary<string, int> wordsCount = new SortedDictionary<string, int>();

                string[] words = text.Split(' ');
                foreach (string word in words)
                {
                    int count = 1;
                    if (wordsCount.ContainsKey(word))
                    {
                        count = wordsCount[word] + 1;
                    }
                    wordsCount[word] = count;
                }

                foreach (var w in wordsCount)
                {
                    Console.WriteLine($"Word {w.Key}, count={w.Value} ");
                }
            }

             static void MenuList()
            {
                while (true)
                {
                    Console.WriteLine("1. Add item");
                    Console.WriteLine("1. Remove item");
                    Console.WriteLine("3. List of all item");
                    Console.WriteLine("4. Exit");

                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            AddItem();
                            break;
                        case "2":
                            RemoveItem();
                            break;
                        case "3":
                            DisplayItem();
                            break;
                        case "4":
                            return;

                    }                   
                    
                }

            }

            static void AddItem()
            {
                Console.Write("Item = ");
                int item = int.Parse(Console.ReadLine());
                ListItem.Add(item);
            }

            static void RemoveItem()
            {
                Console.WriteLine("Item to remove = ");
                int item = int.Parse(Console.ReadLine());
                ListItem.Remove(item);
            }

            static void DisplayItem()
            {
                Console.WriteLine();
                foreach(var item in ListItem)
                {
                    Console.WriteLine($"Item = {item}");
                }
                Console.WriteLine("\nPress Enter to countinue...");
                Console.ReadLine();
            }

             static void task02()
            {
                int [] array = { 3, 4, 4, 2, 3, 3, 4, 3, 2};
                IDictionary<int, int> numberCount = new SortedDictionary<int, int>();
                foreach (var n in array)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();
                foreach (int num in array)
                {
                    int count = 1;
                    if (numberCount.ContainsKey(num))
                    {
                        count = numberCount[num] + 1;
                    }
                    numberCount[num] = count;
                }
                foreach (var n in numberCount)
                {
                    Console.WriteLine($"{n.Key} -> {n.Value} times");
                }

            }

             static void task03()
            {
                int[] array = { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6, 2 };
                IDictionary<int, int> numberCount = new SortedDictionary<int, int>();
                foreach (var n in array)
                {
                    Console.Write($"{n} ");
                }
                Console.WriteLine();

                foreach (int num in array)
                {
                    int count = 1;
                    if (numberCount.ContainsKey(num))
                    {
                        count = numberCount[num] + 1;
                    }
                    numberCount[num] = count;
                }
                
                List <int> list= new List<int>();
                foreach(var w in array)
                {
                    if (numberCount[w] % 2 == 0)
                    {
                        list.Add(w);
                    }
                }
                Console.Write("List: ");
                foreach(var w in list)
                {
                    Console.Write(w+" ");
                }
            }*/


        }
    }
}
