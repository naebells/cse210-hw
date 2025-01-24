using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished:");
        string done = "no";
        int count = 0;
        while (done == "no")
        {
            Console.Write("Enter a Number: ");
            string userInput = Console.ReadLine();
            int number = int.Parse(userInput);
            if (number != 0)
            {
                numbers.Add(number);
                count += 1;
                done = "no";
            }
            else if (number == 0)
            {
                done = "yes";

                int sum = numbers.Sum();
                Console.WriteLine($"Sum: {sum}");

                float average = ((float)sum / count);
                Console.WriteLine($"Average: {average}");

                int max = numbers.Max();
                Console.WriteLine($"Maximum: {max}");
            }
        }
    }
}