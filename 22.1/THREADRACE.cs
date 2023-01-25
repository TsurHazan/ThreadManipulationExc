using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22._1
{
    public class THREADRACE
    {
        public THREADRACE(int numOfCars)
        {
            Places = new List<RACE>(numOfCars);
            Races = new RACE[numOfCars];
            for (int i = 0; i < Races.Length; i++)
            {
                Races[i] = new RACE(i.ToString());
            }
        }

        public RACE[] Races;
        public static List<RACE> Places;
    }
}