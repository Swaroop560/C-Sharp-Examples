using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    class myClassParent1
    {
        public virtual void myMethod()
        {
            Console.WriteLine("This is Parent class Method");
        }
    }
    class myClassParent2 :myClassParent1
    {
        public sealed override void myMethod()
        {
            //base.myMethod();
            Console.WriteLine("This is overridden in myClassparent2");
        }
    }
    class OverRidingDemo3 :myClassParent2
    {
        public new void myMethod()
        {
            base.myMethod();
            Console.WriteLine("This is overridden in Main() Class");
        }
        static void Main()
        {
            OverRidingDemo3 childobj = new OverRidingDemo3();
            childobj.myMethod();
        }
    }
}
