using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    class Customer
    {
        public int custID { get; set; }
        public string custName { get; set; }
        public string  custLoc { get; set; }


        public string compareMethod<T>(T a ,T b) //this works only for strings 
        {
            
            if (a.Equals(b)) 
                return "Both are Equal";
            else
                return "Both are Not Equal";
        }
    }
    class GenericCollections
    {

        static void Main()
        {
            List<string> custList1 = new List<string>()
            {
                //pre-defined Collection of type string


            };
            List<Customer> custList = new List<Customer>()
            {
                //user defined collection of type Customer. 
                //collection of Customer Objects

                new Customer{ custID=101,custName="Rajesh",custLoc="Hyd"},
                new Customer{ custID=102,custName="Suresh",custLoc="Chennai"},
                new Customer{ custID=103,custName="Raj",custLoc="Hyd"},
                new Customer{ custID=104,custName="Raju",custLoc="Mumbai"},

            };
        }
    }
}
