using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int myNum = 42;
            float myFloat = 42.5F;
            double myDouble = 15.2D;
            string myString = "Learning C-Sharp";
            char myChar = 'A';
            string firstName = "Biman";
            string lastName = "KOLANI";

            Console.WriteLine("Int var: " + myNum);
            Console.WriteLine("Float var: " + myFloat);
            Console.WriteLine("Double var: " + myDouble);
            Console.WriteLine("String var: " + myString);
            Console.WriteLine("Char var: " + myChar);
            Console.WriteLine("My fullname: " + lastName + " " + firstName);
        }
    }
}
