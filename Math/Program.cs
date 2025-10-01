using System;

namespace MathObj
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Max(1, -1));
            Console.WriteLine(Math.Min(0, 42));
            Console.WriteLine(Math.Sqrt(9));
            Console.WriteLine(Math.Abs(-7));
            Console.WriteLine(Math.Floor(42.7));
            Console.WriteLine(Math.Round(42.6));
        }
    }
}