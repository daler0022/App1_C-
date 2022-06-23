using System;

namespace Base
{
    class Person
    {
        public string name;
        public int age;

        public Person()
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }

        public Person(string name)
        {
            this.age = 19;
            this.name = name;
            int doubleAge = age * 2;
            Console.WriteLine($"Имя: {name}  Возраст: {age} {doubleAge}");
        }
        public Person(string name, int age)
        {
            this.age = age;
            this.name = name;
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }

        public void Hello()
        {
            Console.WriteLine($"Здравствуйте {name}! В следуюшем году вам будем {++age}");
        }
    }

    struct People
    {
        public string name;
        public int age;

        public People(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void Print() => Console.WriteLine($"Имя: {name}  Возраст: {age}");
    }
}
