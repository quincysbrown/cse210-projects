using System;
using System.IO; 
public class Journal
{
    //Creating list for Entries.
    public List<Entry> _entries = new List<Entry>();
    public void AddEntry(Entry newEntry)
    {
        //This method adds a new entry to the _entries list.
        _entries.Add(newEntry);
    }
    public void DisplayAll()
    {
        //declaring boolean for check condition.
        bool isEmpty = !_entries.Any();
        //Check conditon for whether anything is currently populated in the journal if not it displays the message below.
        if (isEmpty)
        {
            Console.WriteLine("Uh-Oh! You have no entries in your journal.");
            Console.WriteLine("We recommend writing in your journal now by choosing 1, or loading your journal from a file by choosing 3.");
        }
        else
        {
            //If there is something populated in the journal it will display each index within _entries list.
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
        //using StreamWriter to export each stored entry in each of it's parts within a .csv fashion.
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~|~{entry._promptText}~|~{entry._entryText}");
            }
            //Closing the instance of Steamwriter.
            outputFile.Close();
        }

    }
    public void LoadFromFile(string file)
    {
        //Declaring filename for check.
        string filename = file;
        //Check if the filename exists.
        if (System.IO.File.Exists(filename))
        {
            //If it exists then read all the lines from the file and create an instance of Entry class to store the entries. that come in.
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
            //If no file exists prints this message.
            Console.WriteLine("No such file exists.");
        }
    }
}