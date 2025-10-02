int[,] myNumbers = { { 5, 7, 8 }, { 9, 10, 7} };

Console.WriteLine(myNumbers[1, 1]);

foreach (var number in myNumbers)
    Console.WriteLine(number);

Console.WriteLine(myNumbers.GetLength(0));