// Write a program that asks for your name and age, then print:
// Hello [name], you are [age] years old.

string name;
int age;

Console.Write("Enter your name: ");
name = Console.ReadLine();
Console.Write("Enter your age: ");
age = int.Parse(Console.ReadLine());

Console.WriteLine($"Hello {name}, you are {age} years old.");

// I just put it so the console window doesn't close immediately
Console.ReadKey();

