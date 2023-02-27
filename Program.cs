using System;

Main();

void Main()
{
    Console.WriteLine("Hello! To play the Guessing Game, please select a difficulty.");
    Console.WriteLine("Easy - this gives the user eight guesses.");
    Console.WriteLine("Medium - this gives the user six guesses.");
    Console.WriteLine("Hard - this gives the user four guesses.");
    string difficulty = Console.ReadLine().ToLower();
    int tryNumber = 0;

    switch (difficulty)
    {
        case "easy":
            tryNumber = 8;
            break;
        case "medium":
            tryNumber = 6;
            break;
        case "hard":
            tryNumber = 4;
            break;
    }

    Console.WriteLine("Please enter your guess:");
    string userGuess = Console.ReadLine();
    double userNumber = Double.Parse(userGuess);
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
    else
    {
        Console.WriteLine("You lose!");
    }

}






