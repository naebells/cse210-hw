using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is the grade percentage? ");
        string userInput = Console.ReadLine();
        int grade = int.Parse(userInput);

        string letterGrade = "";

        if (grade >= 90 && grade <= 100)
        {
            letterGrade = "A";
        }
        else if (grade >= 80 && grade < 90)
        {
            letterGrade = "B";
        }
        else if (grade >= 70 && grade < 80)
        {
            letterGrade = "C";
        }
        else if (grade >= 60 && grade < 70)
        {
            letterGrade = "D";
        }
        else if (grade >= 0 && grade < 60)
        {
            letterGrade = "F";
        }
        else
        {
            Console.WriteLine("This grade is not on the grading scale. Please run the program again and check for mistakes.");
        }
        Console.WriteLine($"With a grade of {grade}, your Letter Grade is {letterGrade}.");

        if (grade >= 70 && grade <= 100)
        {
            Console.Write("Congrats, you passed the class with this grade.");
        }
        else if (grade >= 0 && grade <= 70)
        {
            Console.Write("Unfortunately, you've failed this class with this grade.");
        }
    }
}