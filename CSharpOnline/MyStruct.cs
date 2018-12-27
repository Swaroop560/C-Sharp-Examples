using System;
namespace CSharpOnline
{
    interface myInterface1
    {
        void myMethod1();
    }
    interface myInterface : myInterface1
    {
        void myMethod();
    }
    struct MyStruct :myInterface
    {
        
        int x;
        string y;

        //public MyStruct()
        //{

        //}
        public MyStruct(int x,string y)
        {
            this.x = x;
            this.y = y;
        }
        public void Display()
        {
            Console.WriteLine("This is Just Display Method in Struct ");
        }
        static void Main()
        {
            //we are creating the parameterless constructor and assigining values

            MyStruct obj = new MyStruct();
            obj.x = 100;
            obj.y = "Rajesh";
            Console.WriteLine("-----Parameterless Constructor -------------------");
            Console.WriteLine("value of x is :"+obj.x);
            Console.WriteLine("Value of Y is : "+obj.y);
            // we can 
            MyStruct obj1 = new MyStruct(10,"Raj");
            Console.WriteLine("-----Parameterized  Constructor -------------------");
            Console.WriteLine("value of x is :" + obj1.x);
            Console.WriteLine("Value of Y is : " + obj1.y);

            // we are creating the reference variable and assigining values to the variables.
            MyStruct m1 = new MyStruct();
            m1.Display();
            m1.myMethod();
            m1.myMethod1();
        }

        public void myMethod()
        {
            Console.WriteLine("This is myMethod");
        }

        public void myMethod1()
        {
            Console.WriteLine("This is myMethod");
        }
    }
   
}
