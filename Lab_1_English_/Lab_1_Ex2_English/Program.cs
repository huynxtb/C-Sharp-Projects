using System;

namespace Lab_1_English_Ex2
{

    public abstract class Animal
    {
        public string type { get; set; }

        public Animal(string type) { this.type = type; }

        public abstract void sound();
        public abstract void info();
    }

    public class Dog : Animal
    {
        string name { get; set; }
        string breed { get; set; }
        public Dog(string type, string name, string breed) : base(type)
        {
            this.name = name;
            this.breed = breed;
        }
        public override void sound()
        {
            Console.WriteLine("Gau gau...");
            Console.WriteLine();
        }

        public override void info()
        {
            Console.WriteLine("Animal type: " + type);
            Console.WriteLine("Dog name: " + name);
            Console.WriteLine("Dog breed: " + breed);
        }
    }


    public class Cat : Animal
    {
        string name { get; set; }
        public Cat(string type, string name) : base(type) { this.name = name; }
        public override void sound()
        {
            Console.WriteLine("Meo meo...");
            Console.WriteLine();
        }

        public override void info()
        {
            Console.WriteLine("Animal type: " + type);
            Console.WriteLine("Cat name: " + name);
        }

        public void climb()
        {
            Console.WriteLine(name + " is climbing");
        }
    }


    public class Duck : Animal
    {
        string name { get; set; }
        string place { get; set; }
        public Duck(string type, string name, string place) : base(type)
        {
            this.name = name;
            this.place = name;
        }
        public override void sound()
        {
            Console.WriteLine("Quac quac...");
            Console.WriteLine();
        }

        public override void info()
        {
            Console.WriteLine("Animal type: " + type);
            Console.WriteLine("Duck name: " + name);
        }

        public void swim() { Console.WriteLine(name + " is swimming in " + place); }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Animal dog = new Dog("Mammal", "Cau Vang", "Cho co");
            Animal cat = new Cat("Mammal", "Mon leo");
            Animal duck = new Duck("Bird", "Dodo", "Dool");
            dog.info();
            dog.sound();
            ((Cat)cat).climb();
            cat.info();
            cat.sound();
            ((Duck)duck).swim();
            duck.info();
            duck.sound();
            Console.ReadKey();
        }
    }
}
