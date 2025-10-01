using System;

namespace Casting
{
    class Program
    {
        static void Main(string[] args)
        {
            int myInt = 9;
            double myDouble = myInt; // Automatic casting; int to double 
            float myFloat = 9.78F;
            int myInt2 = (int)myFloat;
            int myInt3 = 10;
            double myDouble2 = 5.25;
            bool myBool = true;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myFloat);
            Console.WriteLine(myInt2);
            Console.WriteLine("Int to String : " + Convert.ToString(myInt3));
            Console.WriteLine(Convert.ToDouble(myInt));
            Console.WriteLine(Convert.ToInt32(myDouble2));
            Console.WriteLine(Convert.ToString(myBool));
        }
    }
}