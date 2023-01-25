using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._1
{
    public class MyFileRandomizer
    {
        public MyFileRandomizer()
        {
            A = new MyFile("A", 10000);
            B = new MyFile("B", 10000);
            C = new MyFile("C", 10000);
            D = new MyFile("D", 10000);

            A.thread.Start();
            B.thread.Start();
            C.thread.Start();
            D.thread.Start();
        }

        private MyFile A { get; set; }
        private MyFile B { get; set; }
        private MyFile C { get; set; }
        private MyFile D { get; set; }
    }
}