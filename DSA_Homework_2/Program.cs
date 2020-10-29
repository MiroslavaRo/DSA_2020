using System;
using System.Collections;
using System.Collections.Generic;

namespace DSA_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //task01();
            Phonebook();


        }
        static void task01()
         {
            string cont = "";
            do
            {
                Console.WriteLine("\t-----------Minesweeper Game-----------\n");
                int n = 0;
                int m = 0;
                while (true)
                {
                    Console.Write("Define the size of the battlefield: ");

                    if (int.TryParse(Console.ReadLine(), out int x))
                    {
                        n = x;
                        m = x;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Not integer vallue can`t be the size.");
                    }

                }
                int[,] battlefield = new int[n, m];
                int w = 0;
                int h = 0;
                Random ran = new Random();
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        battlefield[i, j] = ran.Next(0, 2);
                    }
                }
                Console.WriteLine("\nYour battlefield: \n");
                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < m; j++)
                    {
                        if (battlefield[i, j] == 1)
                        {
                            Console.Write("X ");
                        }
                        else
                        {
                            Console.Write("O ");
                        }
                    }
                    Console.WriteLine();
                }

                Console.WriteLine();
                Console.WriteLine("\t(Press 'ex' if you want to end a game)\n");
                bool b = true;
                bool c = true;
                while (b)
                {
                    while (c)
                    {
                        bool col = false;
                        bool row = false;


                        do
                        {
                            Console.Write("Enter the vertical coordinate:  ");
                            string str = Console.ReadLine();
                            if (str != "ex")
                            {
                                if (int.TryParse(str, out int y))
                                {
                                    if (y < n)
                                    {
                                        h = y - 1;
                                        col = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vallue which is larger than size can`t be the coordinate. Please, try again.");
                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Not integer vallue can`t be the coordinate. Please, try again.");
                                }
                            }
                            else
                            {
                                goto breakOut;

                            }
                        } while (col == false);


                        do
                        {
                            Console.Write("Enter the horizontal coordinate: ");
                            string str = Console.ReadLine();
                            if (str != "ex")
                            {
                                if (int.TryParse(str, out int x))
                                {
                                    if (x < m)
                                    {
                                        w = x - 1;
                                        row = true;
                                    }
                                    else
                                    {
                                        Console.WriteLine("Vallue which is larger than size can`t be the coordinate. Please, try again.");

                                    }

                                }
                                else
                                {
                                    Console.WriteLine("Not integer vallue can`t be the coordinate. Please, try again.");
                                }
                            }
                            else
                            {
                                goto breakOut;
                            }
                        }
                        while (row == false);

                        if (battlefield[h, w] == 0)
                        {
                            Console.WriteLine("YEAH!");

                        }
                        else
                        {
                            Console.WriteLine("BOOM!");
                            break;
                        }
                    }

                    breakOut:
                    Console.WriteLine("\n\t ------End of the game------");

                    b = false;
                }
                Console.Write("\n Please press any button to continue or 'ex' to exit: ");
                cont = Console.ReadLine();
            } while (cont != "ex");

         }
      
         static void Phonebook()
         {
            Console.WriteLine("----------Phonebook----------\n");
            Dictionary<string, string> Phonebook = new Dictionary<string, string>();
            Phonebook.Add("Jane", "380982298904982");
            Phonebook.Add("Jojo", "380949945989049");
            Phonebook.Add("Luis", "477575849490405");

            while (true)
            {
                Console.WriteLine("1. Add delete dictionary entry");
                Console.WriteLine("2. Delete dictionary entry");
                Console.WriteLine("3. Search dictionary entry");
                Console.WriteLine("4. List dictionary entry");
                Console.WriteLine("5. Exit");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Insert(Phonebook);
                        break;
                    case "2":
                        Delete(Phonebook);
                        break;
                    case "3":
                        Search(Phonebook);
                        break;
                    case "4":
                        Display(Phonebook);
                        break;
                    case "5":
                        return;
                    default:
                        Console.WriteLine( "Please, try again. Enter a number of dispalied operation.");
                        break;
                }

            }

        }
         static void Insert(Dictionary <string, string> Phonebook)
        {
            Console.Write("Name = ");
            string name = Console.ReadLine();
            Console.Write("Phone = ");
            string phone = Console.ReadLine();
            Phonebook.Add(name, phone);            

        }
        static void Delete(Dictionary<string, string> Phonebook)
        {
            Console.Write("Name = ");
            string name = Console.ReadLine();
            Phonebook.Remove(name);

        }
        static void Search(Dictionary<string, string> Phonebook)
        {
            Console.Write("Name = ");
            string name = Console.ReadLine();
            if( Phonebook.ContainsKey(name))
            {
                Console.WriteLine($"Person '{name}' \t phone: {Phonebook[name]}.");
            }
            else
            {
                Console.WriteLine("This person dosen't exit in Phonebook");
            }

        }
        static void Display(Dictionary<string, string> Phonebook)
        {
            foreach (var e in Phonebook)
            {
                Console.WriteLine($"{ e.Key} \t phone: { e.Value} ");
            }

        }
        /* static void task04()
        {

        }*/
        /* static void task05()
        {

        }*/

    }
}
