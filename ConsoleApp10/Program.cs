using System;

namespace ConsoleApp10
{

    public delegate void VoidDelegate();
    public delegate void AnotherVoidDelegate(string str);
    public delegate string ReturnStringDelegate();
    class Program
    {

        static public event AnotherVoidDelegate SomeEvent;
        static void Main(string[] args)
        {
            SomeEvent = MethodForEvent;
            Console.WriteLine("\t\t\t\t\tWelcome to a RIDE!\n\n");
            Game game = new Game();
            VoidDelegate startdelegate = game.ToStart;
            ReturnStringDelegate message;
            startdelegate();
            foreach(ICar car in game.cars)
            {
                if (car.Distance >= 100)
                {
                    message = car.Finish;
                    Console.WriteLine(message);
                }
            }
        }

        static void MethodForEvent(string SomeString)
        {
            Console.WriteLine(SomeString);
        }
    }
}
