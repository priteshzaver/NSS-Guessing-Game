using System;


Console.WriteLine("Hello!");
Console.Write($"Please guess a number: ");

string userGuess = Console.ReadLine();
double userNumber = Double.Parse(userGuess);

int tryNumber = 4;
Random r = new Random();
int secretNumber = r.Next(1, 100);


while (userNumber != secretNumber && tryNumber > 1)
{
    tryNumber--;
    if (userNumber > secretNumber)
    {
        Console.WriteLine("Your guess is too high!");
    }
    else
    {
        Console.WriteLine("Your guess is too low!");
    }
    Console.Write($"Try again ({tryNumber} trie(s) left): ");
    userGuess = Console.ReadLine();
    userNumber = Double.Parse(userGuess);

}
if (userNumber == secretNumber)
{
    Console.WriteLine("Your guess is correct!");
}
