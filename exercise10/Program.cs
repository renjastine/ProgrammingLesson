// Create a program that reverses a word (for example, "apple" becomes "elppa")

string word = "apple";
string reversedWord = "";

for (int i = word.Length - 1; i >= 0; i--)
{
    reversedWord += word[i];
}

Console.WriteLine($"The reversed word of '{word}' is '{reversedWord}'.");