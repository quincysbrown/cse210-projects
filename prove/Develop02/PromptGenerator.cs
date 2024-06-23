using System;
public class PromptGenerator
{
    //Creating _prompts list for the class
    public List<string> _prompts = new List<string>();
    public string GetRandomPrompt()
    {
        //Generate prompt from _prompts list.
        Random rnd = new Random();
        int index = rnd.Next(_prompts.Count);
        //return the random prompt to the program.
        return _prompts[index];
    }

}