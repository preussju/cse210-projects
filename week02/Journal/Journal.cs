using System.IO;

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry entry)
    {
        _entries.Add(entry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.DisplayEntry();
            Console.WriteLine(); 
        }
    }
    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"Date: {entry._date}~~ - Prompt: {entry._promptText} ~~{entry._entryText}");
            }
        }
    }
    public void LoadFromFile(string filename)
    {
        if (File.Exists(filename))
        {
            string[] lines = System.IO.File.ReadAllLines(filename);
            foreach (string line in lines)
            {
                string[] parts = line.Split("~~");
            
                Entry loadedEntry = new Entry();
                loadedEntry._date = parts[0];
                loadedEntry._promptText = parts[1];
                loadedEntry._entryText = parts[2];
                AddEntry(loadedEntry); // this is adding to _entries!
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}