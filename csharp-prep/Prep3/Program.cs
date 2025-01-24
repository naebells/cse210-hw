using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        string guessed = "no";
        int guesses = 0;
        while (guessed == "no")
        {
            Console.Write("What is your guess? ");
            string userGuess = Console.ReadLine();
            int guess = int.Parse(userGuess);
            if (guess > magicNumber)
            {
                Console.WriteLine("Lower!");
                guesses += 1;
            }
            else if (guess < magicNumber)
            {
                Console.WriteLine("Higher!");
                guesses += 1;
            }
            else if (guess == magicNumber)
            {
                guesses += 1;
                Console.WriteLine($"You got it in {guesses} guesses!");
                guessed = "yes";
            }   
        }

    }
}