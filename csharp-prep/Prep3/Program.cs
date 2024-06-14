using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("This game generates a random number from 1 to 100 and has you guess what it is.");
        string response = "yes";
        while (response == "yes")
        {
            bool guess_loop = true;
            Random randomGenerator = new Random();
            int guess_count = 0;
            int number = randomGenerator.Next(1, 101);
            while (guess_loop)
            {
                Console.Write("What is your guess? ");
                string answer = Console.ReadLine();
                int guess_num = int.Parse(answer);
                guess_count ++;
                if (guess_num < number)
                {
                    Console.WriteLine("Higher");
                }
                else if (guess_num > number)
                {
                    Console.WriteLine("Lower");
                }
                else if (guess_num == number)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"It took you {guess_count} tries!");
                    guess_loop = false;
                }
            }
            Console.Write("Do you want to continue? ");
            response = Console.ReadLine();    
        }

    }
}