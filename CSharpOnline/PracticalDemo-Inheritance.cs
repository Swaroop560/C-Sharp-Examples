using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1. why we are using Inheritance
//2. using the constructor chaining.(base keyword).
//3. Method Overriding concept. (Late Binding or runtime polymorphism).

/*
    1. there is a school which has a functionality to calculate the average of 3 subjects namely Maths,science,social.
    2. They also need to print the details of the student like id,name and standard.
    3. we are declaring a class called as student with the members like is,name,standard and subjects like maths,science,social and a method to calculate the average that he scored.

    school-2: --> student contact , telugu , print the grade() - A,A+ A-,B+
    1. There came another school which wanted the same functionality but with some added constraints in the application.

 */

namespace CSharpOnline
{
    #region
    class Student
    {
        //application we developed to calculate the avg and print the student details.

        // i am using protected keyword to declare the variable.
        protected int sid;
        protected string sname;
        protected string s_standard;

        public Student()
        {
            //this is a default construtor.
        }
        //2. we need to define constructor to initialize the members of the class
        public Student(int sid, string sname, string s_standard)
        {
            this.sid = sid;
            this.sname = sname;
            this.s_standard = s_standard;
        }

        //3. i will declare the subjects are private variables and expose them as properties.
        private int maths, science, social;
        public int _maths
        {
            get { return maths; }
            set { maths = value; }
        }
        public int _science
        {
            get { return science; }
            set { science = value; }
        }
        public int _social
        {
            get { return social; }
            set
            {
                social = value;
            }
        }
        public void getDetails()
        {
            Console.WriteLine("Id of the Student is :" + sid);
            Console.WriteLine("Name of the student is :" + sname);
            Console.WriteLine("Standard of the student is " + s_standard);
        }
        public void getAvg()
        {
            Console.WriteLine("The Average is : " + (maths + science + social) / 3);
        }
    }
    #endregion

    class OtherStudent :Student
    {
        protected string scontact;
        public OtherStudent(int sid,string sname,string s_standard,string scontact):base(sid,sname,s_standard)
        {
            //this.sid = sid;
            //this.sname = sname;
            //this.s_standard = s_standard;
            this.scontact = scontact;

        }
        private int telugu;
        public int _telugu
        {
            get { return telugu; }
            set { telugu = value; }
        }
        public void getDetails() // implementation is different. - method name and signature is same --> method overriding
        {
            //Console.WriteLine("Student ID :"+sid);
            //Console.WriteLine("Student Name :"+sname);
            //Console.WriteLine("Student Standard :"+s_standard);

            base.getDetails(); // to refer to the parent class hidden methods we use base keyword.
            Console.WriteLine("Student Contact :"+scontact);
        }
        public void getAvg()
        {
            int average = (_maths + _science + _social + _telugu) / 4;
            if (average < 35)
                Console.WriteLine("Student is Fail");
            else if(average< 75)
                Console.WriteLine("student is passed");
            else if(average<90)
                Console.WriteLine("student scored Distinction");
        }
    }
    class PracticalDemo_Inheritance
    {
        //Student obj = new Student(1,"","");
      
        // client class
        // we are now passing the values to the student class and get the details and the average he scored.
        static void Main()
        {
            Console.WriteLine("------------ Student -- 1 Details --------------------- ");
            Student sobj = new Student(101,"Rajesh","X");
            Console.WriteLine("------------Student Details -----------");
            sobj.getDetails();
            sobj._maths = 90;
            sobj._science = 79;
            sobj._social = 89;
            Console.WriteLine("-------- Student Average --------------");
            sobj.getAvg();
            Console.WriteLine("------------ Student -- 2 Details --------------------- ");
            OtherStudent otherobj = new OtherStudent(102,"Rahul","XII","123456789");
            otherobj._maths = 95;
            otherobj._science = 85;
            otherobj._social = 89;
            otherobj._telugu = 80;
            otherobj.getDetails();
            otherobj.getAvg();

        }
    }
}
