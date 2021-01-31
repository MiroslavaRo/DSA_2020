using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DSA_Class_Work_lesson_11
{
    class Program
    {
        public bool T { get; private set; }

        static void Main(string[] args)
        {
            //ExtensionsDemo();

            //AnnonymousTypesDemo();

            //DelegatesDemo();

            //LambdaExpressionsDemo();

            // LinqQueriesDemo();

            StringBuilder initialString = new StringBuilder();
            initialString.Append("LambdaExpressionsDemo");
            var resultString = initialString.Substring(6, 7);

            //DelegatesExample.Display();

            // FindSubString();
            //Numbers();
            Students.StudentsTest();


        }
        #region delegate
        // Declaration of a delegate
        public delegate void SimpleDelegate(string param);
        public class DelegatesExample
        {
            static void TestMethod(string param)
            {
                Console.WriteLine("I was called by a delegate.");
                Console.WriteLine("I got parameter: {0}.", param);
            }
            public static void Display()
            {
                // Instantiate the delegate
                SimpleDelegate d = new SimpleDelegate(TestMethod);
                // Invocation of the method, pointed by delegate
                d("test");
            }
        }
        #endregion delegate
               
        //Homework

        #region task1   
       /* public static void FindSubString()
        {
            StringBuilder str = new StringBuilder("You are my dearest friend! Yes, you are.");
            int index1 = 4;
            int index2 = 27;
            int length = 9;
            StringBuilder substring = new StringBuilder();
            substring.Append("1: " + str.Substring(index1, length));
            substring.Append("\n2: "+str.Substring(index2));
            Console.WriteLine(str.ToString());
            Console.WriteLine("\nSearched substrings:");
            Console.WriteLine(substring.ToString());

        }
        */
        #endregion task1

        private delegate int StringDelegate<T>(T value);

        private static void DelegatesDemo()
        {
            StringDelegate<string> d = MultiDelegates.PrintString;
            d += new MultiDelegates().PrintStringLength;

            int result = d("some string value");
            Console.WriteLine("Returned result: {0}", result);
        }

        private static void LinqQueriesDemo()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var querySmallNums =
                from num in numbers
                where num < 5
                select num;

            foreach (var num in querySmallNums)
            {
                Console.Write(num.ToString() + " ");
            }
            // The result is 4 1 3 2 0
            Console.WriteLine();
            Console.WriteLine();

            string[] towns = { "Sofia", "Varna", "Pleven", "Ruse", "Bourgas" };

            var townPairs =
              from t1 in towns
              from t2 in towns
              select new { T1 = t1, T2 = t2 };

            foreach (var townPair in townPairs)
            {
                Console.WriteLine(townPair);
            }

            Console.WriteLine();

            string[] fruits = { "cherry", "apple", "blueberry", "banana" };

            // Sort in ascending sort
            var fruitsAscending =
                from fruit in fruits
                orderby fruit
                select fruit;

            foreach (string fruit in fruitsAscending)
            {
                Console.WriteLine(fruit);
            }

            Console.WriteLine();
        }

        private static void LambdaExpressionsDemo()
        {
            List<int> list = new List<int>() { 1, 2, 3, 4 };
            List<int> evenNumbers = list.FindAll(x => (x % 2) == 0);
            foreach (var num in evenNumbers)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            // 2 4

            Console.WriteLine();

            list.RemoveAll(x => x > 3);
            foreach (var num in list)
            {
                Console.Write("{0} ", num);
            }
            Console.WriteLine();
            // 1 2 3

            Console.WriteLine();

            var pets = new Pet[]
            {
                  new Pet { Name="Sharo", Age=8 },
                  new Pet { Name="Rex", Age=4 },
                  new Pet { Name="Strela", Age=1 },
                  new Pet { Name="Bora", Age=3 }
            };

            var sortedPets = pets.OrderBy(pet => pet.Age);
            sortedPets = sortedPets.ThenBy(pet => pet.Name);

            foreach (Pet pet in sortedPets)
            {
                Console.WriteLine("{0} -> {1}",
                  pet.Name, pet.Age);
            }

            Console.WriteLine();

            list = new List<int>() { 20, 1, 4, 8, 9, 44 };

            // Process each argument with code statements
            evenNumbers = list.FindAll((i) =>
            {
                Console.WriteLine("value of i is: {0}", i);
                return (i % 2) == 0;
            });

            Console.WriteLine("Here are your even numbers:");
            foreach (int even in evenNumbers)
                Console.Write("{0} ", even);

            Console.WriteLine();
            Console.WriteLine();

            Func<bool> boolFunc = () => true;
            Func<int, bool> intFunc = (x) => x < 10;
            if (boolFunc() && intFunc(5))
            {
                Console.WriteLine("5 < 10");
            }
        }

        private static void AnnonymousTypesDemo()
        {
            var myCar = new { Color = "Red", Brand = "BMW", Speed = 180 };

            Console.WriteLine("My car is a {0} {1}.", myCar.Color, myCar.Brand);
            Console.WriteLine("It runs {0} km/h.", myCar.Speed);
            Console.WriteLine();

            var p = new { X = 3, Y = 5 };
            var q = new { X = 3, Y = 5 };

            Console.WriteLine(p);
            Console.WriteLine(q);
            Console.WriteLine(p == q); // false
            Console.WriteLine(p.Equals(q)); // true
            Console.WriteLine();

            var combined = new { P = p, Q = q };

            Console.WriteLine(combined.P.X);
            Console.WriteLine();

            var arr = new[] {
                new { X = 3, Y = 5 },
                new { X = 1, Y = 2 },
                new { X = 0, Y = 7 }
            };

            foreach (var item in arr)
            {
                Console.WriteLine("({0}, {1})", item.X, item.Y);
            }
        }

        private static void ExtensionsDemo()
        {
            string s = "Hello Extension Methods";
            int i = s.WordCount();
            Console.WriteLine(i);

            List<int> ints = new List<int> { 1, 2, 3, 4, 5 };
            Console.WriteLine(ints.ToString());
            Console.WriteLine(ints.ToString<int>());

            ints.IncreaseWidth(5);
            Console.WriteLine(ints.ToString<int>());

            List<string> letters = new List<string> { "a", "b", "c" };
            Console.WriteLine(letters.ToString<string>());
        }
    }
}
