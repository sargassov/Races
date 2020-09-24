using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    abstract class ICar
    {
        public int MinSpeed;
        public int MaxSpeed;
        public int CurrentSpeed;
        public string TypeOfCar;
        public int Distance = 0;
        public string AutoFinish = " is WON of the race!";

        public ICar() { }
        public int ToRide(int Distance)
        {
            return this.Distance += Distance;
        }
        public string Finish()
        {
            string mes = "\n\n\t\t\t\t";
            mes += TypeOfCar;
            return mes + AutoFinish;
        }

        public int RandomSpeedValue()
        {
            Random rnd = new Random();
            CurrentSpeed = rnd.Next(MinSpeed, MaxSpeed);
            return CurrentSpeed;
        }

        public string DistanceAhead()
        {
            string result = this.TypeOfCar + " was riding " + this.Distance;
            result += "\nCurrent Speed = ";
            result += CurrentSpeed;
            result += "\n\n";
            return result;
        }
    }
}
