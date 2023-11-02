namespace Person.Models
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name,int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        
        public string Name { get; set; }
        public int Age{ get; set; }
        
        public override string ToString() => $"Name: {this.Name}, Age: {this.Age}";

        }
    }
}
