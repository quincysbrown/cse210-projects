using System;
using System.ComponentModel.DataAnnotations;

public class Comment
{
    public string _name;
    public string _text;

    public void Display()
    {

        Console.WriteLine($"{_name}:");
        Console.WriteLine(_text);
        Console.WriteLine();
    }
}