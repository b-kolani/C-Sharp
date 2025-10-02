
using System.Linq;
string[] cars = ["Volvo", "Mazda", "BMW", "Audi"];
Console.WriteLine($"Array's length: {cars.Length}");

int[] cars1 = new int[4] {1, 5, 0, -9};
string[] cars2 = new string[4] { "BMW", "Volvo", "Ford", "Audi" };
Array.Sort(cars2);
foreach (string car in cars2)
    Console.WriteLine(car);
Array.Sort(cars1);
foreach (int i in cars1)
    Console.WriteLine(i);

Console.WriteLine("Max number in the array: " + cars1.Max());
Console.WriteLine("Min number in the array: " + cars.Min());
Console.WriteLine("Sum of the array: " + cars1.Sum());
Console.WriteLine("Min of the second array: " + cars2.Min());