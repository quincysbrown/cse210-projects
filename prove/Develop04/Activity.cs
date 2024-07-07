using System;
using System.Net;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {
        _name = "";
        _description = "";
        _duration = 0;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine($"{_description}");
        Console.WriteLine();
        Console.Write("How long in seconds, would you like for your session? ");
        bool loop = true;
        while (loop)
        {
            if (!int.TryParse(Console.ReadLine(), out _duration))
            {
                Console.WriteLine("Invalid Input. Please enter as an integer.");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Get ready...");
                ShowSpinner();
                loop = false;
            }
        }
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!");
        ShowSpinner();
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_name}.");
        ShowSpinner();
    }

    public void ShowSpinner(int seconds = 5)
    {
        List<string> animationStrings = new List<string>();
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(seconds);
        int i = 0;
        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b \b");
            i++;
            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds = 5)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}