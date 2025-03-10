public class Journal 
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(string prompt, string response)
    {
       string date = DateTime.Now.ToShortDateString();
       _entries.Add(new Entry(date, prompt, response));
    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No journal entry found.");
            return;
        }

        Console.WriteLine("\nJournal Entries: ");
        foreach (var entry in _entries)
        {
           Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string file)
    {
       using(StreamWriter writer = new StreamWriter(file))
       {
         foreach (var entry in _entries)
         {
            writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
         }
       } 
    }

    public void LoadFromFile(string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found!");
            return;
        }

        _entries.Clear();
        foreach(var line in File.ReadLines(file))
        {
            string[] parts = line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                Console.WriteLine();
                Console.WriteLine($"{line}");
                Console.WriteLine();
            }
        }
    }
}