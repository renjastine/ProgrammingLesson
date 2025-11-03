// Ask the user to enter 5 numbers, store them in an array, and show their average.
Console.WriteLine("NOTE: No Space, Separated by Comma ONLY");
Console.Write("Enter numbers: ");
string input = Console.ReadLine();

int[] numbers = Array.ConvertAll(input.Split(','), int.Parse);

int sum = 0;
foreach(int num in numbers)
{
    sum += num;
}

Console.WriteLine($"The average is: {(double)sum / numbers.Length}");
