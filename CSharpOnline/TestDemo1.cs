using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    class TestClass10
    {
        public int ID = 101;
        public string name = "Abc";

        int sal = 1000;

        //accessor Method -- getter method
        //public int getEmpSalary()
        //{
        //    return sal;
        //}
        ////Mutators - setting a value -- setter
        //public void setSalary(int s)
        //{
        //    sal = s;
        //}


        //public int Salary
        //{
        //    get { return sal; }
        //   // set { sal = value; }
        //}
    }
    class TestDemo1
    {
        static void Main()
        {
            TestClass10 obj = new TestClass10();
            Console.WriteLine( "Employee Name is : {0}",obj.name);
            Console.WriteLine("This is Read Operation..");
            Console.WriteLine();
          //  Console.WriteLine("Employee Salary is : {0}",obj.getEmpSalary());
            Console.WriteLine();
            Console.WriteLine("This is Write Operation..");
            //obj.setSalary(5000);
            //Console.WriteLine("Employee Salary is : {0}", obj.getEmpSalary());
        }
    }
}

// we cannot access private variable oustside the class.