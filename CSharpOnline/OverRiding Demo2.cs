using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    class Car
    {
        public void CarInfo()
        {
            //100 
            Console.WriteLine("This is parent  CarInfo ...");
        }
        public virtual void car_Color()
        {
            Console.WriteLine("My Car color is Red");
        }
        public virtual void car_Name()
        {
            Console.WriteLine("My Car Name is Honda City");
        }
        public virtual void car_AC_Facility()
        {
            Console.WriteLine("Yes i have Ac with climate control features");
        }
        public virtual void car_Wheels()
        {
            Console.WriteLine("I have Mac Wheels");
        }
    }
    class OverRiding_Demo2 :Car
    {
        public override void car_Name()
        {
            //base.car_Name();
            Console.WriteLine("My car is Alto-800");
        }
        public override void car_Color()
        {
            base.car_Color();
        }
        public override void car_AC_Facility()
        {
            //base.car_AC_Facility();
            Console.WriteLine("I have Ac with no Climate Control");
        }
        public override void car_Wheels()
        {
            //base.car_Wheels();
            Console.WriteLine("I have Normal Wheels.");
        }

        //Method Hiding -- I am hiding the parent class Method and executing the child class Method.

        public new void CarInfo()
        {
            base.CarInfo();
            Console.WriteLine("This is child class carINFO...");
        }
        static void Main()
        {
            OverRiding_Demo2 childobj = new OverRiding_Demo2();
            childobj.car_AC_Facility();
            childobj.car_Color();
            childobj.car_Name();
            childobj.car_Wheels();
            childobj.CarInfo();
        }
    }
}
