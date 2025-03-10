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
       using(StreamWriter _writer = new StreamWriter(file))
       {
         foreach (var entry in _entries)
         {
            _writer.WriteLine($"{entry._date} | {entry._promptText} | {entry._entryText}");
         }
       } 
    }

    public void LoadFromFile(string _file)
    {
        if (!File.Exists(_file))
        {
            Console.WriteLine("File not found!");
            return;
        }

        _entries.Clear();
        foreach(var _line in File.ReadLines(_file))
        {
            string[] parts = _line.Split('|');
            if (parts.Length == 3)
            {
                _entries.Add(new Entry(parts[0], parts[1], parts[2]));
                Console.WriteLine();
                Console.WriteLine($"{_line}");
                Console.WriteLine();
            }
        }
    }
}