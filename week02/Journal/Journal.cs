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
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), filename); //construct the full file path
        using (StreamWriter outputFile = new StreamWriter(filePath)) // not true to not duplicate
        {
            foreach (Entry entry in _entries)
            {
                if (entry._promptText != "Scripture of the day!") // checks if is not the convenant path file being saved
                {
                    outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
                }
            }
        }
        SaveDailyScriptureToFile("scripture.txt"); // calls this function to save the convenant path files
    }
    public void LoadFromFile(string filename)
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), filename); //construct the full file path
        if (File.Exists(filePath))
        {
            _entries.Clear(); //clear entries to not duplicate

            using (StreamReader file = new StreamReader(filePath))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    string[] parts = line.Split("~~");

                    if (parts.Length == 3) // Check if the line is a valid entry
                    {
                        Entry loadedEntry = new Entry();
                        loadedEntry._date = parts[0];
                        loadedEntry._promptText = parts[1];
                        loadedEntry._entryText = parts[2];
                        _entries.Add(loadedEntry);
                    }
                }
            }
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }

    public void SaveDailyScriptureToFile(string filename)  //new function very similar to SaveToFile
    {
        string filePath = Path.Combine(Directory.GetCurrentDirectory(), filename);
        using (StreamWriter outputFile = new StreamWriter(filePath, true)) // true to not erase 
        {
            foreach (Entry entry in _entries)
            {
                if (entry._promptText == "Scripture of the day!")
                {
                    outputFile.WriteLine($"{entry._date}~~{entry._promptText}~~{entry._entryText}");
                }
            }
        }
    }

}