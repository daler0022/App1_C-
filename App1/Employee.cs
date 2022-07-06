using System;
using Base;

namespace App1
{
    class Person
    {
        int age = 1;
        public virtual int Age
        {
            get => age;
            set { if (value > 0 && value < 110) age = value; }
        }
        public string Name { get; set; }
        public Person(string name)
        {
            Name = name;
        }
        public virtual void Print() => Console.WriteLine(Name);
    }
    class Employee : Person
    {
        public override int Age
        {
            get => base.Age;
            set { if (value > 17 && value < 110) base.Age = value; }
        }
        public string Company { get; set; }
        public Employee(string name, string company)
            : base(name)
        {
            Company = company;
            base.Age = 18; 
        }

        public override void Print() => Console.WriteLine(Company);
    }
}
