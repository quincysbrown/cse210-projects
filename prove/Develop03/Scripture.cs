using System;
using System.Text;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>();

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        string[] splitTextArray = text.Split(' ');
        
        foreach (string wordsInString in splitTextArray)
        {
            Word word = new Word(wordsInString);
            _words.Add(word);
        }

    }    

    public void HideRandomWords(int numberToHide)
    {
        Random rnd = new Random();
        for (int i = 0; i < numberToHide; i++)
        {
            bool wordfound = false;
            while(!wordfound)
            {
                if (IsCompletelyHidden())
                {
                    return;
                }
                int index = rnd.Next(_words.Count);
                if (!_words[index].IsHidden())
                {
                    _words[index].Hide();
                    wordfound =true;
                }
            }
        }
    }

    public string GetDisplayText()
    {
        StringBuilder result = new StringBuilder();
        result.Append(_reference.GetDisplayText()+" ");
        foreach (Word word in _words)
        {
            result.Append(word.GetDisplayText()+" ");
        }
        return result.ToString();
    }
    public bool IsCompletelyHidden()
    {
        bool result = true;
        foreach (Word word in _words)
        {
            result = word.IsHidden();
            if (!result)
            {
                return result;
            }
        }
        
        return result;
    }
}