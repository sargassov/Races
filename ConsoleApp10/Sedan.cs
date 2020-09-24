using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Sedan:ICar
    {
        public Sedan(string marka, int MaxS, int MinS)
        {
            Random rnd = new Random();
            MaxSpeed = MaxS;
            MinSpeed = MinS;
            TypeOfCar = marka;
        }

        
    }
}
