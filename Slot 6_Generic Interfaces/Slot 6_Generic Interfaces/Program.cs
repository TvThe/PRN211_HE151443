using System;

namespace Slot_6_Generic_Interfaces
{
    interface IBasic<T> where T : struct
    {
        T Add(T a, T b);
    }
    class MyFirstClass : IBasic<int>
    {
        public int Add(int a, int b) => a + b;
    }
    class MySecondClass : IBasic<double>
    {
        public double Add(double a, double b) => a + b;
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyFirstClass firstClass = new MyFirstClass();
            dynamic r = firstClass.Add(10, 20);
            Console.WriteLine(r);
            MySecondClass secondClass = new MySecondClass();
            r = secondClass.Add(10.5, 20.5);
            Console.WriteLine(r);
            Console.ReadLine();
        }
    }
}
