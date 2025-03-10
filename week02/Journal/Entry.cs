using System.Dynamic;

public class Entry 
{
    public string _date {get;}
    public string _promptText {get;}
    public string _entryText {get;}
    public Entry (string date, string prompt, string response)
    {
        _date = date;
        _promptText = prompt;
        _entryText = response;
    }
    public override string ToString()
    {
       return $"Date: {_date}\nPrompt: {_promptText}\nResponse: {_entryText}\n" + new string('-', 40);
    }
}