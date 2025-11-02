// Show the multiplication table of a number

int number = 10;
int multiplier = 1;

for (int i = 1; i <= number; i++)
{
    for(int j = 1; j <= 10; j++)
    {   
        int product = j * multiplier;
        Console.Write($"{product}\t");
    }
    multiplier++;
    Console.WriteLine();
}