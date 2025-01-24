using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int userSquare = SquareNumber(userNumber);

        DisplayResult(userName, userSquare);

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        static string PromptUserName()
        { 
            Console.Write("What is your name? ");
            string userName = Console.ReadLine();
            return userName;
        }
        static int PromptUserNumber()
        {
            Console.Write("What is your favorite number? ");
            string userInput = Console.ReadLine();
            int userNumber = int.Parse(userInput);
            return userNumber;
        }
        static int SquareNumber(int userNumber)
        {
            int userSquare = (userNumber*userNumber);
            return userSquare;
        }
        static void DisplayResult(string userName, int userSquare)
        {
            Console.Write($"Your name is {userName} and your favorite number squared is {userSquare}.");
        }
    }
}