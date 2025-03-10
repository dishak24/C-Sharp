using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Animal
    {
        /*public String Name 
        { 
            get; 
            set; 
        }*/

        public Animal()
        {
            Console.WriteLine("Animal Class Constructor");
        }

        ~Animal()
        {
            Console.WriteLine("Animal Destructor");
        }

    }

    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("In Dog Constructor ");
        }

        ~Dog()
        {
            Console.WriteLine("Dog Destructor");
        }

    }



}
