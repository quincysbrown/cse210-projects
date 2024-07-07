using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _count = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        base.DisplayStartingMessage();
        GetRandomPrompt();
        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items!");
        base.DisplayEndingMessage();
    }

    public void GetRandomPrompt()
    {
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine($"--- {_prompts[index]} ---");
        Console.Write("You may begin in: ");
        base.ShowCountDown();
    }

    public List<string> GetListFromUser()
    {
        List<string> list = new List<string>();
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("\n>");
            list.Add(Console.ReadLine());
        }
        return list;
    }
}