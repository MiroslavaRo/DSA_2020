using System;

namespace DSA_Homework_2
{
    class Program
    {
        static void Main(string[] args)
        {
            task01();
           //task02();


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
      
        /* static void task02()
         {

         }*/
        /* static void task03()
        {

        }*/
        /* static void task04()
        {

        }*/
        /* static void task05()
        {

        }*/

    }
}
