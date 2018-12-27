using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    class Parent
    {
        public class myClass
        {
            public myClass()
            {
                Console.WriteLine("THis is a nested class constructor");
            }
        }
       
        public Parent()
        {
            Console.WriteLine("Hello from parent constructor");
        }
        public void parentDisplay()
        {
            Console.WriteLine("Parent class Method...");
        }
        private void parentDisplay1()
        {
            Console.WriteLine("Parent class Method...");
        }
    }
    class InheritanceDemo : Parent
    {
        public InheritanceDemo()
        {
            // explicit const and parameterless const
            Console.WriteLine("Hello From the Child Constructor...");
        }
        public void childDisplay()
        {
            Console.WriteLine("Child class Method...");
        }
        static void Main()
        {
           
            InheritanceDemo obj = new InheritanceDemo();
            
            obj.parentDisplay();

           //  myClass m = new myClass();
               
           

            //parent class obj

           // parent parentobj; // parent class ref variable

           // parentobj = obj; // we are assigning child clas obj to parent class ref var

          //  InheritanceDemo childobj;

           // Parent parentobj = new Parent();

           // childobj = parentobj;

            obj.parentDisplay();obj.childDisplay();

            Console.WriteLine("Hello from Main Method");
            //object shud be created for the class


        }
    }
}
