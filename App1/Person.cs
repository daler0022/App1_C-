using System;

namespace Base
{
    abstract class Transport
    {
        public string Name { get; }
        public Transport(string name)
        {
            Name = name;
        }
        public void Move() => Console.WriteLine($"{Name} движется");
    }
    class Ship : Transport
    {
        public Ship(string name) : base(name) { }
    }
    class Aircraft : Transport
    {
        public Aircraft(string name) : base(name) { }
    }
    class Car : Transport
    {
        public Car(string name) : base(name) { }
    }
}
