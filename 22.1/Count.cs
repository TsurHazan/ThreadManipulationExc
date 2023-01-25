using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22._1
{
    public class Count
    {
        public Count(string text, int sleepTime, int loopLength)
        { Text = text; SleepTime = sleepTime; LoopLength = loopLength; thread = new Thread(MyLoop); thread.Start(); }

        public Count(string text, int sleepTime, bool isInfinity)
        { Text = text; SleepTime = sleepTime; Infinity = isInfinity; thread = new Thread(MyInfiniteLoop); }

        public static bool Infinity { get; set; }
        public string Text { get; set; }
        public int SleepTime { get; set; }
        public int LoopLength { get; set; }
        public Thread thread;
        public object obj = new object();

        public void MyLoop()
        {
            for (int i = 1; i <= LoopLength; i++)
            {
                Console.WriteLine($" {Text} {i}");
                Thread.Sleep(SleepTime);
            }
        }

        public void MyInfiniteLoop()
        {
            int i = 0;
            while (Infinity)
            {
                Console.WriteLine($" {Text} {i++}");
                Thread.Sleep(SleepTime);
                if (i % 10 == 0)
                {
                    if (Infinity == false) return;
                    string answer = Console.ReadLine();
                    if (answer.Equals("0")) Infinity = false;
                }
            }
        }
    }
}