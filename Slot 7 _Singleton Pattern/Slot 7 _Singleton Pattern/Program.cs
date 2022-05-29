using System;

namespace Slot_7__Singleton_Pattern
{
    public sealed class Singleton
    {
        private static readonly Singleton Instance;
        private static int TotalInstances = 0;
        private Singleton() => Console.WriteLine("--Private constructor is called.");
        static Singleton()
        {
            Console.WriteLine("--Static constructor is called.");
            Instance = new Singleton();
            TotalInstances++;
            Console.WriteLine($"--Single instance is created. Number of instance:{TotalInstances}");
            Console.WriteLine("--Exit from static constructor.");

            
        }
        public static Singleton GetInstance => Instance;
        public int GetTotalInstances => TotalInstances;
        public void Print() => Console.WriteLine("Hello World.");
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#1.Trying to get a Singleton instance, called firstInstance.");
            Singleton firstInstance = Singleton.GetInstance;
            Console.WriteLine("--Invoke Print() method : ");
            firstInstance.Print();
            Console.WriteLine("#2.Trying to get another Singleton instance, called secondInstance.");
            Singleton secondInstance = Singleton.GetInstance;
            Console.WriteLine($"--Number of instances:{secondInstance.GetTotalInstances}");
            Console.Write("--Invoke Print() method : ");
            secondInstance.Print();
            if (firstInstance.Equals(secondInstance))
            {
                Console.WriteLine("=> The firstInstance and secondInstance are the same.");

            }
            else
            {
                Console.WriteLine("=> Different instances exist.");
            }
            Console.Read();
        }
    }
}
