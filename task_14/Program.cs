using System;

namespace task_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Кошка");
            cat.ShowInfo();
            Dog dog = new Dog("Собака");
            dog.ShowInfo();
            Console.ReadKey();
        }
    }
    abstract class Animal
    {
        public abstract string name { get; set; }
        public Animal(string n)
        {
            name = n;
        }
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(name);
            Say();
        }
    }
    class Cat : Animal
    {
        string n;
        public Cat(string n):base(n)
        {
            name = n;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу");
        }
        public override string name
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }
    }
    class Dog : Animal
    {
        string n;
        public Dog(string n) : base(n)
        {
            name = n;
        }
        public override void Say()
        {
            Console.WriteLine("Гав");
        }
        public override string name
        {
            get
            {
                return n;
            }
            set
            {
                n = value;
            }
        }
    }
}