using System;

namespace Props
{
    class Person1
    {
        private string? name;

        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
    }
    class Person2
    {
        private string? name;
        public string? Name { get; set; }
    };
    class Program
    {

        static void Main(string[] args)
        {
            Person1 person1 = new();
            Person2 person2 = new();

            person1.Name = "John Doe";
            person2.Name = "Jane Doe";
            Console.WriteLine(person1.Name);
            Console.WriteLine(person2.Name);
        }
    }
}