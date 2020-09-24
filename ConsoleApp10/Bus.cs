using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Bus:ICar
    {
        public Bus(string marka, int MaxS, int MinS)
        {
            Random rnd = new Random();
            MaxSpeed = MaxS;
            MinSpeed = MinS;
            TypeOfCar = marka;
        }
    }
}
