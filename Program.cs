using System;

Console.WriteLine("Hello!");
Console.Write("Please guess a number: ");
string userGuess = Console.ReadLine();
double userNumber = Double.Parse(userGuess);
Console.WriteLine($"You entered {userNumber}");