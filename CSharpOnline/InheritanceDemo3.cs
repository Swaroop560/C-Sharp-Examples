using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    abstract class parentInherit
    {
        public string name = "";

       // public abstract void Show();

        public virtual void Show1()
        {
            //re- implementing -- rewriting
            Console.WriteLine("THis is Show-1");
        }
        public void Show2()
        {
            Console.WriteLine("This is Show-2");
        }
        public void Show3()
        {
            Console.WriteLine("This is Show-3");
        }
    }
    class InheritanceDemo3 :parentInherit
    {
       
        static void Main()
        {
            //1. i can create the child class obj and consume the parent class methods

            InheritanceDemo3 obj = new InheritanceDemo3();
            Console.WriteLine(obj.name);
      
            //2. i am creating the parent class object and calling the parent class methods.

            //parentInherit ob1 = new parentInherit();
            //ob1.name = "Hello world";
        }
    }
    //abstract class myTestClass 
    //{
    //    // A method that is declared as abstract is called as abstract method
    //    // A class declared as abstract is called as Abstract Class or a class that contains the Abstract method is called as Abstract Class.
    //    // Abstract Method
    //    public abstract void myDisplay();

    //    //Non -Abstract Methods

    //    public void myDisplay1()
    //    {
    //        Console.WriteLine("This is my Display Mrthod.");
    //    }
    //}
}
