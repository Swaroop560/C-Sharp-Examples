using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    public interface IDemo
    {
        string Name();
        string Choices();
    }

    class InterfaceDemo1:IDemo
    {
        static void Main()
        {
            InterfaceDemo1 obj = new InterfaceDemo1();
            Console.WriteLine("This is the Main method ");
            Console.WriteLine(obj.Choices());
            Console.WriteLine(obj.Name());
        }

        public string Choices()
        {
            return "Coding is my fav choice";
        }

        public string Name()
        {
            return "My Name is Raju";
        }
    }
}
