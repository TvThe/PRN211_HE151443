using System;

namespace Slot_4_5_OOP_inheritance
{ 

    class Person
{
    private string name;
    private int age;
    private string address;

    public Person(string name, int age, string address)
    {
        this.name = name;
        this.age = age;
        this.address = address;
    }
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }
    public string Address
    {
        get { return address; }
        set { address = value; }
    }
}
    class Student:Person
    {
        private string program;
        private int year;
        private double fee;

        public Student(string name, int age,string address,string program, int year, double fee):base( name,age, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }
        public string Program
        {
            get { return program; }
            set { program = value; }

        }
        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public override string ToString()
        {
            return $"Name:{Name}, Age:{Age}, Address:{Address}, Program:{Program}, Year:{Year}, Fee:{Fee}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("Viet", 21, "Ha Noi", "PRN211",2022, 1000);
            Console.WriteLine(s);
            Console.ReadLine();

        }
    }
}
