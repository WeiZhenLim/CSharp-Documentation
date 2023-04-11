using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Section6
{
    internal class Human
    {
        // member variable
        public string firstName;
        public string lastName;
        private string eyeColor;
        private int age;

        // constructor
        public Human (string  myFirstName, string lastName, string eyeColor, int age)
        {
            firstName = myFirstName; // method 1
            this.lastName = lastName; // method 2
            this.eyeColor = eyeColor;
            this.age = age;
        }

        // member method
        public void IntroductMyself()
        {
            Console.WriteLine($"Hi, I'm {firstName + " " + lastName} and {age} years old. My eye color is {eyeColor}.");
        }
          
    }
}
