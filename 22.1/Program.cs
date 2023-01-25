using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _22._1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            //1
            // Count A = new Count("A", 1000, 10);
            // Count B = new Count("B", 1000, 10);

            //2
            //A = new Count("A", 1000, 100);
            //B = new Count("B", 500, 100);
            //Count c = new Count("C", 250, 100);

            //4
            // MyFileRandomizer Four = new MyFileRandomizer();

            //5
            //Count A = new Count("A", 1000, true);
            //Count B = new Count("B", 1000, true);
            //A.thread.Start();
            //B.thread.Start();

            //6
            THREADRACE tHREADRACE = new THREADRACE(10);
        }
    }
}