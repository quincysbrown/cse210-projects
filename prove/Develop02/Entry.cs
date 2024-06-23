using System;
public class Entry
{
    //Declaring variables for date, prompt and entry.
    public string _date;
    public string _promptText;
    public string _entryText;
    public void Display()
    {
        //Prints and formats the stored data with Date followed by prompt and then the entry on the next line.
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine($">{_entryText}");
    }
}