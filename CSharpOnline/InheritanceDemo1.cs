using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    class myClassParent
    {
        public myClassParent()
        {
            Console.WriteLine("I am Parent class Constructor : ");
        }
        public void ShowParent()
        {
            Console.WriteLine("This is Parent class Method");
        }
    }
    class InheritanceDemo1 : myClassParent
    {
        public InheritanceDemo1(int age,string name) : base()// we can pass hard coded value & a parameter from ch
        {                                                           // child class constructor.
            Console.WriteLine("I am Child Class Constructor");
        }
        public void showChild()
        {
            Console.WriteLine("This is a child class Method");
        }
        static void Main()
        {
            InheritanceDemo1 childobj = new InheritanceDemo1(45,"Hello World");
            //childobj.
            

            childobj.ShowParent();childobj.showChild();
        }

    }
}
 //1. this situation should be handled explicitly by the programmer
 //2. it is the responsibility of the programmer to pass the parameter from the child class constructor to the parent class constructor 
 //3. using the base keyword, we can pass the parameters to the parent class constructor.
 //4. base keyword is used to call the parent class constructor explicitly.(programatically)

    //Object class is the base class for all the classes in .Net


