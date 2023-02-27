using System;


Console.WriteLine("Hello!");
Console.Write($"Please guess a number: ");

string userGuess = Console.ReadLine();
double userNumber = Double.Parse(userGuess);
int secretNumber = 42;
int tryNumber = 1;

while (userNumber != secretNumber && tryNumber < 4)
{
    tryNumber++;
    Console.WriteLine("Your guess is wrong!");
    Console.Write($"Try again (TRY #{tryNumber}): ");
    userGuess = Console.ReadLine();
}
if (userNumber == secretNumber)
{
    Console.WriteLine("Your guess is correct!");
}
