using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CSharpOnline
{
    class HashTableDemo
    {
        static string name = "Gopi";
        static void Main()
        {
            



            int[] arr = new int[5] { 1, 2, 3, 4, 5 };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i] + " "); // 5 arr[5]
            }
            Console.Write("-------------------------------------------------------");
            Hashtable ht = new Hashtable();
            ht.Add("empID", 1001);
            ht.Add("empName", "Raj");
            ht.Add("empDesig", "SWE");
            ht.Add("empLoc", "Chennai");
            foreach (var v in ht.Values)
            {
                Console.WriteLine(v);
            }
            Console.Write("-------------------------------------------------------");
            foreach (var i in ht.Keys)
            {
                Console.Write(i + " : " + ht[i] + "\n");
            }

            //Console.WriteLine("The Hashcode of the Name is : "+name.GetHashCode());
            //#endregion
            #region
            //Stack Example
            Console.Write("-----------------------------------------------------------------"+ "\n");

            Stack st = new Stack();

            st.Push("1001");
            st.Push("Rajesh");
            st.Push("Mahesh");
            st.Push(true);

            foreach(var i in st)
            {
                Console.WriteLine(i);
            }
            #endregion

            Queue q = new Queue();

            q.Enqueue("1111");
            q.Enqueue("Mahesh");
            q.Enqueue("Hyderabad");
            q.Enqueue(false);

            foreach (var q1 in q)
            {
                Console.WriteLine(q1);
            }
        }
    }
}
