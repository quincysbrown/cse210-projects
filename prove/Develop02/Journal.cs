using System;
using System.IO; 
public class Journal
{
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        bool isEmpty = !_entries.Any();
        if (isEmpty)
        {
            Console.WriteLine("Uh-Oh! You have no entries in your journal.");
            Console.WriteLine("We recommend writing in your journal now by choosing 1, or loading your journal from a file by choosing 3.");
        }
        else
        {

            foreach (Entry entry in _entries)
            {
                entry.Display();
                Console.WriteLine();
            }
        }
    }
    public void SaveToFile(string file)
    {
        
        string filename = file; 

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
            outputFile.Close();
        }

    }
    public void LoadFromFile(string file)
    {
        string filename = file;
        if (System.IO.File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            _entries = new List<Entry>();
            Entry entry;

            foreach (string line in lines)
            {
                entry = new Entry();
                string[] parts = line.Split("~|~");

                entry._date = parts[0];
                entry._promptText = parts[1];
                entry._entryText = parts[2];
                _entries.Add(entry);
            }
        }
        else
        {
            Console.WriteLine("No such file exists.");
        }
    }
}