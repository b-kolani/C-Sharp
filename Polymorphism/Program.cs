using System;

namespace Polymorphism
{
    class Animal
    {
        public virtual void AnimalSound()
        {
            Console.WriteLine("The animal makes sound");
        }
    }

    class Pig: Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The pig says: wee wee");
        }
    }

    class Dog: Animal
    {
        public override void AnimalSound()
        {
            Console.WriteLine("The dog says: bow bow");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Animal myAnimal = new();
            Animal myPig = new Pig();
            Animal myDog = new Dog();
            Pig pig = new();
            Dog dog = new();

            myAnimal.AnimalSound();
            myPig.AnimalSound();
            myDog.AnimalSound();
            pig.AnimalSound();
            dog.AnimalSound();
        }
    }
}