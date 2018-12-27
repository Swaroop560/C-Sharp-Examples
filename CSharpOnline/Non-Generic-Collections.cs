using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    class Non_Generic_Collections
    {
      
        static void Main()
        {
            //capacity
            //Auto Resizing Feature
            ArrayList alist = new ArrayList();
            Console.WriteLine("The Length of the ArrayList is :"+alist.Capacity);

            alist.Add(10);alist.Add(true);alist.Add("Hello world");

            Console.WriteLine("The Length of the ArrayList is :" + alist.Capacity);
            alist.Add("10.5");alist.Add("Raju");alist.Add("9000");

            Console.WriteLine("The Length of the ArrayList is :" + alist.Capacity);

            Stack st = new Stack();

            //print all the elements in the ArrayList

            for (int i = 0; i < alist.Count; i++)
            {
                Console.Write(alist[i] + " ");
               
            }
            Console.WriteLine();
            //Adding element in the Middle of an Array
            //insert(int index) - 
            alist.Insert(4, "11");

            Console.WriteLine("-----------------------------------------------");
            Console.WriteLine("");
            for (int i = 0; i < alist.Count; i++)
            {
                Console.Write(alist[i] + " ");

            }
            Console.WriteLine("");
            //Deleting the Element in the Middle of an Array

            //Remove(obj) or RemoveAt(int index)

            alist.Remove("11");
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");
            for (int i = 0; i < alist.Count; i++)
            {
                Console.Write(alist[i] + " ");

            }
            //Removing at the Index
            alist.RemoveAt(2);
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("");
            for (int i = 0; i < alist.Count; i++)
            {
                Console.Write(alist[i] + " ");

            }
            Console.WriteLine();
        }
    }
}
