using System;

class Program
{
    static void Main(string[] args)
    {
        string letter = "";
        Console.Write("What is your grade percentage? ");
        string string_input = Console.ReadLine();
        float percentage = float.Parse(string_input);
        if (percentage >= 90)
        {
            letter = "A";
            if (percentage < 94)
            {
                letter = $"{letter}-";
            }
        }
        else if (percentage >= 80 && percentage < 90)
        {
            letter = "B";
            if (percentage>=87)
            {
                letter = $"{letter}+";

            }
            else if (percentage < 84)
            {
                letter = $"{letter}-";
            }
        }
        else if (percentage < 80 && percentage >= 70)
        {
            letter = "C";
            if (percentage>=77)
            {
                letter = $"{letter}+";

            }
            else if (percentage < 74)
            {
                letter = $"{letter}-";
            }
        }
        else if (percentage < 70 && percentage >= 60)
        {
            letter = "D";
            if (percentage>=67)
            {
                letter = $"{letter}+";

            }
            else if (percentage < 64)
            {
                letter = $"{letter}-";
            }
        }
        else if (percentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (percentage >= 70)
        {
            Console.WriteLine("You have passed this course.");
        }
        else
        {
            Console.WriteLine("You have failed this course.");
        }
    }
}