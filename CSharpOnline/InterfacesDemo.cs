using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpOnline
{
    interface IEmployee
    {

        void Display(string name);
        void Show();
        // int x = 0;
        //  abstract void Show1();
        // private void Show1();
        // protected void Show1();
        string DisplayName();
    }
    class InterfacesDemo 
    {
        // Default scope of the members of the class is private.
        //<access specifier> <Return Type> [Name of the Method] (list of parameters){//body of method}
    }
}
//1. The default scope for the members of the interface is public.We cannot declare a method as private;
//2. Interfaces cannot contain fields like variables.
//3. We need not define the methods declared in the interface as abstract. By Default the members of the interface are abstract.