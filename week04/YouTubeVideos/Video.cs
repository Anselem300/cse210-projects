using System.ComponentModel.DataAnnotations;
using System.Diagnostics.Contracts;
using System.Transactions;

public class Video{
    public string _title;
    public string _author;
    public int _length;
    public List<Comments> _Comment;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _Comment = new List<Comments>();
    }

    public void AddComment(string name, string text)
    {
        _Comment.Add(new Comments(name, text));
    }

    public int NumberOfComment()
    {
        return _Comment.Count();
    }

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Video Title: {_title}");
        Console.WriteLine($"Video Author: {_author}");
        Console.WriteLine($"Video Length: {_length} secs.");
        Console.WriteLine($"Number of Comments added: {NumberOfComment()}");
        Console.WriteLine("Comments: ");
        foreach(var Comment in _Comment)
        {
            Console.WriteLine($"{Comment._name} - {Comment._text}");
        }

        Console.WriteLine();
    }
}