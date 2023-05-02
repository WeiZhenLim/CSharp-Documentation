using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 20000;

        // member - public field
        public int age;

        public string JobTitle
        {
            get 
            { 
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }

        // public member Method - can be called from other classes

        public void Introducing(bool isFriend)
        {
            if(isFriend)
            {
                SharingPrivateInto();
            }
            else
            {
                Console.WriteLine("Hi, my name is {0} and my job title is {1}. I'm {2} years old.",memberName,jobTitle,age);
            }
        }

        private void SharingPrivateInto()
        {
            Console.WriteLine("My salary is {0}",salary);
        }

        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        // member - finalizer - destructor
        ~Members()
        {
            // cleanup statements
            Console.WriteLine("Deconstruction of Members object");
        }
    }
}
