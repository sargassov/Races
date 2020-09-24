using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{

    public delegate void Message(string str);
    class Game
    {
        public List<ICar> cars;
        public int FinishDistance = 100;
        public bool isfinish = false;
        public Game()
        {
            cars = new List<ICar>() { new SportCar("Sport car", 35, 10), new Bus("Bus", 15, 7), 
                new Sedan("Sedan", 20, 14), new Truck("Truck", 13, 8)};
          
        }
        public void ToStart()
        {
            int Period = 1;
            while (true)
            {
                Console.WriteLine("\t\t\t\t\tIn the " + Period + " Period.\n");
                foreach (ICar car in cars)
                {

                    car.ToRide(car.RandomSpeedValue());
                    Console.WriteLine(car.DistanceAhead());
                    if (car.Distance >= FinishDistance)
                    {
                        isfinish = true;

                    }
                }
                if (isfinish) { break; }
                Period++;
                System.Threading.Thread.Sleep(3000);
            }
        }
    }
}
