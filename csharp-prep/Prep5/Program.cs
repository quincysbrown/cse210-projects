using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        //Calling DisplayWelcome function.
        DisplayWelcome();

        //Calling PromptUserName function.
        string user_name = PromptUserName();
        
        //Calling PromptUserNumber function.
        int user_num = PromptUserNumber();

        //Calling SquareNumber function.
        int square_user_num = SquareNumber(user_num);

        //Calling DisplayResult function.
        DisplayResult(user_name, square_user_num);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());
        
        return number;
    }

    static int SquareNumber(int number)
    {
        int squared_num = number*number;
        return squared_num;
    }

    static void DisplayResult(string name, int square_num)
    {
        Console.WriteLine($"{name}, the square of your number is {square_num}");
    }
    
}