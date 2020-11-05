using System;

namespace DSA_Class_Work_lesson4
{
    class Program
    {
            private static void Main(string[] args)
            {
                while (true)
                {
                    DisplayMenu();

                    var choice = int.Parse(Console.ReadLine());
                    if (choice == 6)
                    {
                        break;
                    }

                    switch (choice)
                    {
                        case 1:
                            StudentsTester.RunTest();
                            break;

                        case 2:
                            PhonebookTester.RunTest();
                            break;

                       case 3:
                            BigStoreTester.RunTest();
                            break;

                        case 4:
                            PriorityQueueTester.RunTest();
                            break;

                        /*case 5:
                            BigDictionaryTester.RunTest();
                            break;*/
                    }
                }
            }

            private static void DisplayMenu()
            {
                Console.Clear();
                Console.WriteLine(new string('=', 50));
                Console.WriteLine("1. Task 01 - Students");
                Console.WriteLine("2. Task 02 - Phonebook");
                Console.WriteLine("3. Task 03 - Big Store");
                Console.WriteLine("4. Task 04 - Priority queue");
                Console.WriteLine("5. Task 05 - Big Dictionary");
                Console.WriteLine("6. Exit");
                Console.WriteLine(new string('=', 50));
                Console.Write("Please enter your choice: ");
            }
        }
    }
        