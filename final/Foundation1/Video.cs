using System;
using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments = new List<Comment>();

    public int DisplayNum()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine(_title);
        Console.WriteLine($"--Author: {_author}");
        Console.WriteLine($"{_length} seconds --Comments: {DisplayNum()}");
        Console.WriteLine("Comments: ");
        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
    }
}