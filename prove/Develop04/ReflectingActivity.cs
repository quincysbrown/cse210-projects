using System;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string>();
    private List<string> _questions = new List<string>();

    public ReflectingActivity()
    {
        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
        _name = "Reflecting Activity";
        _description = "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        DisplayPrompt();
        bool loop = true;
        while (loop)
        {
            string input = Console.ReadLine();
            if (input == "")
            {
                Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
                Console.Write("You may begin in: ");
                base.ShowCountDown();
                break;
            }
            else
            {
                Console.WriteLine("Invalid Input. Please press enter to continue.");
                continue;
            }
        }
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            DisplayQuestions();
            base.ShowSpinner(10);
        }
        Console.WriteLine();
        base.DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        Random rnd = new Random();
        int index = rnd.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine("");
        Console.WriteLine($"--- {GetRandomPrompt()} ---");
        Console.WriteLine("");
        Console.WriteLine("When you have something in mind, press enter to continue.");
    }

    public void DisplayQuestions()
    {
        Console.Write($"\n>{GetRandomQuestion()}");
    }
}