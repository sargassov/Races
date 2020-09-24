using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class Truck:ICar
    {   public Truck(string marka, int MaxS, int MinS)
        {
            Random rnd = new Random();
            MaxSpeed = MaxS;
            MinSpeed = MinS;
            TypeOfCar = marka;
        }
    }
}
