
string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
Console.WriteLine("Text length: " + text.Length);
string helloWorld = "Hello, World!";
Console.WriteLine(helloWorld.ToUpper());
Console.WriteLine(helloWorld.ToLower());
string firstname = "Biman", lastname = "KOLANI";
Console.WriteLine(string.Concat(firstname, " ", lastname));
Console.WriteLine(firstname.IndexOf('B'));
Console.WriteLine(firstname.Substring(firstname.IndexOf("m")));
Console.WriteLine($"Fullname: {firstname} {lastname}");