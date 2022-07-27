using System;

namespace App1
{
    class Person
    {
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }

    public Person (string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;
        }
    public void Print()
        {
            Console.WriteLine($"Имя: {Name}, Фамилия: {Surname}, Возраст: {Age}");
        }
    }
}
