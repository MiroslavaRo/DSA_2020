using System;
using System.Threading.Tasks;

namespace DSA_Class_Work_lesson3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task01();
            //Task02();
            //Task03();
            Task04();
        }
        private static void Task01()
        {
            /*1. Start
            2. define array, it length, randomazer, max, min
            3. full array
            4. 1) check if current element of array is bigger then max;
               2.1) if yes => max = current element
               2.2) if no = max = max 
               3) go to following element of array until the last
            5. 1) check if current element of array is smaller then min;
               2.1) if yes => min = current element
               2.2) if nomin = min
               3) go to following element of array until the last
            6. print max, min
            7. end
             
             
             */
            int[] array = new int[10];
            Random r = new Random();
            int max = 0;
            int min = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 11);
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }

            }
            Console.WriteLine($"max = {max}\nmin = {min}");
        }
        private static void Task02()
        {


            /*1. Start
            2. define array, it length, randomazer, sum, average
            3. full array
            4.1. sum=sum+ current element of array 
            4.2. go to next element of array until last elem
            5. average = sum/length of array
            6. print average
            7. end
             
             
             */
            int[] array = new int[10];
            Random r = new Random();
            int sum = 0;
            int average = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 11);
                sum += array[i];                

            }
            average = sum / array.Length;
            Console.WriteLine($"average = {average}");
        }
        private static void Task03()
        {

            /*1. Start
            2. define array, it length,temp
            3. full array Ex:(1,2,3)
            4.1. temp = current element 
            4.2. current element = last element Ex:(3,2,3)
            4.3 last element = temp Ex:(3,2,1)
            5. go to next element of array until last elem 
            6. print array
            7. end
             
             
             */

            int[] array = new int[10];
            int temp = 0;
            for (int i=0; i < array.Length; i++)
            {    
                array[i] = i+1;
               
            }
            foreach(var e in array)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            for (int j = 0; j < (array.Length)/2; j++)
            {
                temp=array[array.Length - 1 - j];
                array[array.Length - 1-j]= array[j];
                array[j]=temp;

            }
            foreach (var e in array)
            {
                Console.Write($"{e} ");
            }


        }
        private static void Task04()
        {

        }
    }
}
