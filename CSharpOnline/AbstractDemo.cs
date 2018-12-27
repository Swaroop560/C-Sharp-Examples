using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    abstract class AbstractParent1
    {
         public abstract void myAbsmethod();

        public abstract void myAbsmethod11();

        public  void myAbsMethod1()
        {
            Console.WriteLine("M-1");
        }
        public void myAbsMethod2()
        {
            Console.WriteLine("M-2");
        }
        public void myAbsMethod3()
        {
            Console.WriteLine("M-3");
        }

    }
    abstract class AbstractDemoParent
    {
        public abstract void Show2();
        public static void Display1()
        {
            Console.WriteLine("This is Abstract Demo Parent -1");
        }
        public void Display2()
        {
            Console.WriteLine("This is Abstract Demo Parent -2");
        }
    }
    class AbstractDemo : AbstractParent1
    {
        static void Main()
        {
            AbstractDemo absobj = new AbstractDemo();
            absobj.myAbsmethod();absobj.myAbsMethod1();absobj.myAbsMethod2();absobj.myAbsmethod11();

          //  Display1();absobj.Display2();

            // problem starts when i have the scope to create the parent class object and cosume the parent class members.
            //AbstractDemoParent objparent = new AbstractDemoParent();                        
        }
        public new void myAbsMethod1()
        {
            //base.myAbsMethod1();
            Console.WriteLine("M-1 New Implementation");

        }
        public override void myAbsmethod()
        {
            Console.WriteLine("This is abstract method implementation");
        }
        public override void myAbsmethod11()
        {
            Console.WriteLine("This is abstract method implementation -2");
        }
    }
}
// you are calling the method with out object.

// i am adking abt the parent class object

    // inheritance shud happen
    // child class obj shud be able to access all the parent class methods
    // i shud prevent the parent class obje to b created.

    // a non-concrete method is an abstract method.

