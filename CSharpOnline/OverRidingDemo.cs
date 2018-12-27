using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    class myClass
    {
        public void Test() //no permission
        {
            Console.WriteLine("This is a  Parent Test Method...");
        }
        public virtual void Show() // virtual means that this method can be overridden by the child class (permission)
        {
            Console.WriteLine("This is a Parent Show Method...");
        }
        public void Display() // no permission
        {
            Console.WriteLine("This is a Parent Display Method...");
        }
    }
    class OverRidingDemo :myClass
    {
        public void childTest()
        {
            Console.WriteLine("This is Child Test Method...");
        }
        public void childShow()
        {
            Console.WriteLine("This is a Child Show Method...");
        }
        static void Main()
        {

        }
    }
}
