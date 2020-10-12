using System;
using System.Collections.Generic;
using System.Collections;

namespace DSA_Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Task_01();
            //Task_02();
            //Task_03();
            Task_04();

        }
        static void Task_01()
        {
            float[] Array = new float[10];
            Random r = new Random();
            bool b = false;
            for (int i = 0; i < 10; i++)
            {              
                Array[i] = r.Next(1,10);
            }            
            Console.WriteLine("Please, type the number to check is it in array: ");
            int a = int.Parse(Console.ReadLine());
            for (int j = 0; j<10; j++)
            {
                if (Array[j] == a)
                {
                     b = true;                   
                }                
            }
            if (b)
            {
                Console.WriteLine($"Your number is in array");
            }
            else {Console.WriteLine($"Your number isn't in array");}
            Console.Write("Array: ");
            foreach (int elem in Array)
            {
                Console.Write( + elem + " ");
            }           

        }
        static void Task_02()
        {
            Stack<int> stack = new Stack<int>();            
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(r.Next(1,10));
            }
            Console.WriteLine("Please, type the number to check is it in stack:");
            int a = int.Parse(Console.ReadLine());
            if (stack.Contains(a))
            {
                Console.WriteLine($"Your number is in stack");
            }
            else
            {
                Console.WriteLine($"Your number isn't in stack");
            }
            Console.Write("Stack: ");
            while (stack.Count != 0)
            {
                Console.Write(stack.Pop() + " ");
            }
        }
        static void Task_03()
        {
            Queue<int> Q = new Queue<int>();
            Random r = new Random();            
            for (int i = 0; i < 10; i++)
            {
                Q.Enqueue(r.Next(1,10));
            }
            Console.WriteLine("Please, type the number to check is it in queue:");
            int a = int.Parse(Console.ReadLine());
            if (Q.Contains(a))
            {
                Console.WriteLine($"Your number is in queue");
            }
            else
            {
                Console.WriteLine($"Your number isn't in queue");
            }
            Console.Write("Queue: ");
            foreach (int id in Q)
            {
                Console.Write(id + " ");
            }
        }
        static void Task_04()
        {
            List<int> list = new List<int>();            
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                list.Add(r.Next(1,10));
            }
            Console.WriteLine("Please, type the number to check is it in list:");
            int a = int.Parse(Console.ReadLine());
            if (list.Contains(a))
            {
                Console.WriteLine($"Your number is in list");
            }
            else
            {
                Console.WriteLine($"Your number isn't in list");
            }
            Console.Write("List: ");
            foreach (int id in list)
            {
                Console.Write(id + " ");
            }
        }
    }
}
