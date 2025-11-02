
int sum = 0;
for (int i = 1; i <= 50; i++)
{
    sum += (i % 2 == 0) ? i : 0;
}
Console.WriteLine($"The sum of even numbers from 1 to 50 is: {sum}");