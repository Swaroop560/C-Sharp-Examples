using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
   
    // to prevent any class from being inherited we can mark the class as Sealed.
     class mySealedClass
    {
        public  virtual void m1()
        {
            Console.WriteLine("M-1");
        }
        public virtual void m2()
        {
            Console.WriteLine("M-2");
        }
    }
    class mySealedClass2 : mySealedClass
    {
        public override void m1()
        {
            Console.WriteLine("This is overridden m-1");
        }
        public sealed override void m2()
        {
            Console.WriteLine("This is overridden m-2");
        }
    }
    class SealedClassDemo :mySealedClass2
    {
        public override void m1()
        {
            Console.WriteLine("This is double overridden method");
        }
       
        static void Main()
        {
            //eventhough we cannot inherit the sealed class we can create the object for the sealed class
            SealedClassDemo objsealed = new SealedClassDemo();
            objsealed.m1();
            objsealed.m2();
        }
    }
}
