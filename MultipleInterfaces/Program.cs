using System;

namespace MultipleInterfaces
{
    interface IFirstInterface
    {
        void myMethod();
    };

    interface ISecondInterface
    {
        void myOtherMethod();
    };
    class DemoClass : IFirstInterface, ISecondInterface
    {
        public void myMethod()
        {
            Console.WriteLine("Some text...");
        }
        public void myOtherMethod()
        {
            Console.WriteLine("Some other text...");
        }
    };

    class Program
    {
        static void Main(string[] args)
        {
            DemoClass demo = new();

            demo.myMethod();
            demo.myOtherMethod();
        }
    }
}