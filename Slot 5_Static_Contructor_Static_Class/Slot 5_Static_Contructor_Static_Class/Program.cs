using System;

namespace Slot_5_Static_Contructor_Static_Class
{
    class MyClass
    {
        public static int x = 1;
        static MyClass()
        {
            x = 2;
            Console.WriteLine("Static constructor: x = {0}", x);
        }
        public MyClass()
        {
            x++;
            Console.WriteLine("Object contructor: x = {0}", x);
        }
    }
    static class UtilityClass
    {
        public static void PrintTime()
        {
            Console.WriteLine(DateTime.Now.ToShortTimeString());
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            MyClass m1 = new MyClass();
            Console.WriteLine();
            MyClass m2 = new MyClass();
            Console.WriteLine();
            UtilityClass.PrintTime();
        }
    }
}
