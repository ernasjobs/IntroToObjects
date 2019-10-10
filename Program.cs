using System;

namespace IntroToObjects
{
    class Program
    {
        public static Bicycle bike1=new Bicycle();
        static void Main(string[] args)
        {
            bike1.GetStates();
            bike1.Accelerate();
            bike1.GetStates();
            Console.ReadKey(true);
        }
    }
}
