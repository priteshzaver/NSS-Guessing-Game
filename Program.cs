using System;


for (int i = 1; i <= 4; i++)
{
    Console.WriteLine("Hello!");
    Console.Write("Please guess a number: ");

    string userGuess = Console.ReadLine();
    double userNumber = Double.Parse(userGuess);
    int secretNumber = 42;

    if (userNumber == secretNumber)
    {
        Console.WriteLine("Your guess is correct!");
    }
    else
    {
        Console.WriteLine("Your guess is wrong!");
    }
}