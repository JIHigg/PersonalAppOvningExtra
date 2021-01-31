using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalApp
{/// <summary>
/// Sub Class for a Child.
/// </summary>
    class Child:Person
    {


        public  Child(string name, int age): base (name, age)
        {
            if (age > 15)
                throw new ArgumentException("Child cannot be older than 15");
            else
                Age = age;
            Name = name;
        }

    }
}
