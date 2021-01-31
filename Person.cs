using System;
using System.Collections.Generic;
using System.Text;

namespace PersonalApp
{/// <summary>
/// Parent Class for Person.
/// </summary>
    public class Person
    {
        private string name;

        private int age;
        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public virtual string Name
        {
            get { return name; }
            set 
            {
                if (value.Length < 3)
                    throw new ArgumentException("Name must be longer " +
                        "than three letters!");
                else
                name = value; }
        }

        public virtual int Age
        {
            get { return age; }
            set {
                if (value < 0)
                    throw new ArgumentException("Age cannot be negative.");
                else
                    age = value; }
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
            this.Name,
            this.Age));
            return stringBuilder.ToString();
        }

    }
}
