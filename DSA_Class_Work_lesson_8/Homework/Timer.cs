using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DSA_Class_Work_lesson_11
{
    public delegate void Ticker();

    public static class Timer
    {
        public static readonly Action Action = new Action(() => Console.WriteLine(++Seconds));

        public static int Seconds { get; private set; }
    }

    public static class TimeTester
    {
        public static void TimerTest()
        {
            Ticker ticker = new Ticker(Timer.Action); // delegate -> action

            while (true)
            {
                Thread.Sleep(1000);
                ticker();
            }
        }
    }
}
