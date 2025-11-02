// Make a simple guessing game where the program picks a random number between 1 and 100 and the user tries to guess it

Random random = new Random();
int randomNumber = random.Next(1, 101);

while (true)
{
    Console.Write("Guess a number between 1 and 100: ");
    int userGuess = int.Parse(Console.ReadLine());
    if (userGuess == randomNumber)
    {
        Console.WriteLine("Congratulations! You guessed the correct number.");
        break;
    }
    else if(userGuess < randomNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else
    {
        Console.WriteLine("Too high! Try again.");
    }
}