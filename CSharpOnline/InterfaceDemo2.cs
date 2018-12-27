using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    interface ImyInterfaceDemo
    {
        void Show1();
        void Show2();
    }
    interface Imyinterfacedemo2
    {
        void Show1();
        void Show2();
    }
    interface Imyinterfacedemo3
    {
        void Show13();
        void Show23();
    }

    class myInterfaceDemo
    {
       
       
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
    class InterfaceDemo2 :myInterfaceDemo, ImyInterfaceDemo,Imyinterfacedemo2
    {
     
        static void Main()
        {
            InterfaceDemo2 obj = new InterfaceDemo2();

            obj.Show1();obj.Show2();obj.Show3();

            ImyInterfaceDemo iobj1 = obj;
            iobj1.Show1();
            iobj1.Show2();
            Imyinterfacedemo2 iobj2 = obj;
            iobj2.Show1();
            iobj2.Show2();
           
        }
        //explicit way of implementing Interfaces.
         void ImyInterfaceDemo.Show1()
        {
            Console.WriteLine("This is Show 1 from I-1");
        }
        void ImyInterfaceDemo.Show2()
        {
            Console.WriteLine("This is Show 2 from I-1");
        }
        void Imyinterfacedemo2.Show2()
        {
            Console.WriteLine("This is show 2 from I -2");
        }
        void Imyinterfacedemo2.Show1()
        {
            Console.WriteLine("This is show 1 from I -2");
        }
        
        //public void Show1()
        //{
        //    Console.WriteLine("This is ImyInterfaceDemo Method...");
        //}

        //public void Show2()
        //{
        //    Console.WriteLine("This is Imyinterfacedemo2 Method...");
        //}
        //public void Show3()
        //{
        //    Console.WriteLine("This is Imyinterfacedemo Method - Show3()");
        //}
    }
}
