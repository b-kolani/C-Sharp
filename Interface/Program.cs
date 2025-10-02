using System;

namespace Interface
{
    interface IAnimal
    {
        void animalSound();
    }

    class Pig : IAnimal
    {
        public void animalSound()
        {
            Console.WriteLine("The pig syas: wee wee");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Pig myPig = new();

            myPig.animalSound();
        }
    }
}