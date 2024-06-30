using System;
using System.Timers;

class Program
{
    static void Main(string[] args)
    {
        bool _continue = true;
        ScriptureLibrary library = new ScriptureLibrary();
        Scripture scripture = library.GetRandomScripture();
        while (_continue)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("Press enter to continue or type 'quit' to finish.");
            string input = Console.ReadLine();
            if (input.ToLower()== "quit")
            {
                _continue = false;
            }
            else if (input == "")
            {
                if (scripture.IsCompletelyHidden())
                {
                    _continue = false;
                    break;
                }
                scripture.HideRandomWords(3);
            }
            
        }
    }
}