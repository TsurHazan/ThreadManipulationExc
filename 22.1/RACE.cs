using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22._1
{
    public class RACE
    {
        public RACE(string carName)
        {
            random = new Random(DateTime.Now.Millisecond);
            CarName = carName;
            KM = 0;
            thread = new Thread(MainLoop);
            thread.Start();
        }

        public Thread thread;
        private Random random;
        public bool Stop { get; set; } = false;
        public string CarName;
        public int KM { get; set; }

        public void Drive()
        {
            KM = KM + random.Next(100);
            Console.WriteLine($"car: {CarName}  KM: {KM}");
        }

        public void MainLoop()
        {
            while (!Stop)
            {
                if (KM >= 100)
                {
                    Stop = true;
                    THREADRACE.Places.Add(this);
                    if (THREADRACE.Places.ToArray().Length == THREADRACE.Places.Capacity && this == THREADRACE.Places.ToArray().Last())
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Place {i + 1} is {THREADRACE.Places[i].CarName}!");
                        }
                    }
                }
                else
                {
                    Drive();
                    Thread.Sleep(1000);
                }
            }
        }
    }
}