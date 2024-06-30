using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = 0;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        string ref_text;
        if (_endVerse == 0)
        {
            ref_text = _book+" "+_chapter+":"+_verse;
        }
        else
        {
            ref_text = _book+" "+_chapter+":"+_verse+"-"+_endVerse;
        }
        return ref_text;
    }
}
