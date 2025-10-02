// void MyMethod()
// {
//     Console.WriteLine("I just got executed!");
// }

// MyMethod();

namespace MyMethod
{
    class Program
    {
        static void MyMethod(string fname, int age)
        {
            Console.WriteLine(fname +  " is " + age);
        }
        static void MyMethod2(string country = "Norway")
        {
            Console.WriteLine(country);
        }
        static void MyMethod3(string child1, string child2, string child3)
        {
            Console.WriteLine("The youngest child is: " + child3);
        }
        static void Main(string[] args)
        {
            MyMethod("Liam", 18);
            MyMethod("Jenny", 22);
            MyMethod("Alfred", 30);
            MyMethod2("Togo");
            MyMethod2();
            MyMethod3(child2: "Liam", child3: "Jenny", child1: "Zena");
        }
    }
}