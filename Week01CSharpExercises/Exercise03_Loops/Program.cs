using System;

class Program
{
    static void Main()
    {
        Random random = new Random();
        int magicNumber = random.Next(1, 101);
        int guess = 0;
        int guessCount = 0;

        Console.WriteLine("Welcome to the guessing game!");

        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            guessCount++;

            if (guess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guess > magicNumber)
            {
                Console.WriteLine("Lower");
            }
        }

        Console.WriteLine($"You guessed it! The number was {magicNumber}.");
        Console.WriteLine($"It took you {guessCount} guesses.");
    }
}
