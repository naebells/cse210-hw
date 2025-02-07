using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        bool yup = true;
        while (yup == true)
        {
            Console.WriteLine("\nJournal Menu:");
            Console.WriteLine("1. Write a New Entry. ");
            Console.WriteLine("2. Display the Current Journal. ");
            Console.WriteLine("3. Save the Journal to a File. ");
            Console.WriteLine("4. Load the Journal from a File. ");
            Console.WriteLine("5. Exit. ");
            Console.Write("Choose an option by typing the corresponding number: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                journal.WriteNewEntry();
            }
            else if (choice == "2")
            {
                journal.DisplayJournal();
            }
            else if (choice == "3")
            {
                journal.SaveToFile();
            }
            else if (choice == "4")
            {
                journal.LoadFromFile();
            }
            else if (choice == "5")
            {
                yup = false;
                break;
            }
            else
            {
                Console.WriteLine("Sorry, that is not one of the provided answer choices. Please try again.");

            }
        }
    }
}