using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{

    class PolyDemo
    {
        //constructor overloading
        public PolyDemo() // implicit constructor
        {
            Console.WriteLine("This is Parameterless Constructor...");
        }
        public PolyDemo(int age) // int parameter constructor
        {
            Console.WriteLine("The age of the person is :"+age);
        }
        public PolyDemo(string name,int age)
        {
            Console.WriteLine("{0} 's age is {1}",name,age);
        }
        public PolyDemo(int age,string name)
        {
            Console.WriteLine("MY Name is : {0} and my age is : {1}", name,age);
        }
        //Method Overloading

        public void Display()
        {
            Console.WriteLine("Hai i m display method");
        }
        public void Display(string name)
        {
            Console.WriteLine("Hai i m display method and My name is : "+name);
        }
        public void Display(int age)
        {
            Console.WriteLine("Hai i m display method and my age is :"+age);
        }
        public void Display(string name,int age)
        {
            Console.WriteLine("Hai i m display method and my name is : {0} and my age is :{1}",name,age);
        }
    }
    class PolymorphismDemo1 : PolyDemo
    {
        PolymorphismDemo1() // base("Hrithik",100) // implicit constructor
        {
            Console.WriteLine("This is Child Class Constructor");
        }
        PolymorphismDemo1(string name,int age) : base(name, age) //explicit constructor
        {
            Console.WriteLine("This is Child Class Constructor and Age :"+age);
        }
        static void Main()
        {
            //PolyDemo obj1 = new PolyDemo(); // we are calling the parameterless constructor
            //PolyDemo obj2 = new PolyDemo(100); // we are calling the parameterized constructor
            //PolyDemo obj3 = new PolyDemo("Hero", 100);
            //PolyDemo obj4 = new PolyDemo(100, "Hero");

            PolymorphismDemo1 obj1 = new PolymorphismDemo1();
            PolymorphismDemo1 obj2 = new PolymorphismDemo1("Hrithik",100);
            Console.WriteLine();
            Console.WriteLine("------------Method Overloading ------------------------------");
            Console.WriteLine();
            obj1.Display();
            obj1.Display(100);
            obj1.Display("Hrithik");
            obj1.Display("Hrithik",100);



        }
    }
}
