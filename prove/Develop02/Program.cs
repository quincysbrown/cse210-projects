using System;
using System.CodeDom.Compiler;
using System.Linq.Expressions;

class Program
{
    static void Main(string[] args)
    {

        int loop = 1;

        Journal theJournal = new Journal();

        Entry anEntry;

        PromptGenerator prompt = new PromptGenerator();
        prompt._prompts.Add("Who was the most interesting person I interacted with today?");
        prompt._prompts.Add("What was the best part of my day?");
        prompt._prompts.Add("How did I see the hand of the Lord in my life today?");
        prompt._prompts.Add("What was the strongest emotion I felt today?");
        prompt._prompts.Add("If I had one thing I could do over today, what would it be?");
        prompt._prompts.Add("What are ten things I am grateful for today?");
        prompt._prompts.Add("What did I learn from my personal study today?");

        Console.WriteLine("Welcome to the Journal Program!");

        do
        {

            anEntry = new Entry();
            anEntry._date = DateTime.Now.ToString("M/d/yyyy");
            //Prompt for user options.
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            //Getting user input at prompt.
            Console.Write("What would you like to do? ");
            int option = int.Parse(Console.ReadLine());
            //Conditional statements to determine what the user wants to do.
            if (option == 1)
            {
                
                anEntry._promptText = prompt.GetRandomPrompt();
                Console.WriteLine(anEntry._promptText);
                anEntry._entryText = Console.ReadLine();
                theJournal.AddEntry(anEntry);
            }
            else if (option == 2)
            {
                theJournal.DisplayAll();
            }
            else if (option == 3)
            {
                Console.Write("What is the filename?");
                string filename = Console.ReadLine();
                theJournal.LoadFromFile(filename);
            }
            else if (option == 4)
            {
                Console.Write("What is the filename?");
                string filename = Console.ReadLine();
                theJournal.SaveToFile(filename);
            }
            else if (option == 5)
            {
                break;
            }
            else
            {
                Console.WriteLine("Please enter a number from 1-5.");
            }
        } while(loop == 1);
    }
}