using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine();
        Console.WriteLine("Hello World! This is the YouTubeVideos Project.");
        Console.WriteLine();

        List<Video> videos = new List<Video>();

        Video video1 = new Video("Joseph Smith First Vision", "Joseph Smith", 700);
        video1.AddComment("Jeffrey R. Holland", "I know it is true.");
        video1.AddComment("Anselem Samuel", "He definitely saw the living God.");
        video1.AddComment("John Maxwell", "I love the first Vision video");
        video1.AddComment("Stella Maxwell", "Will like to learn more");
        videos.Add(video1);

        Video video2 = new Video("Anxiety Therapy Session", "William Montgomery", 650);
        video2.AddComment("Emily889", "Such a wonderful therapy tips Williams!");
        video2.AddComment("Juice Wrld", "I really needs this!");
        video2.AddComment("Whitney Houston", "Is there a pdf download for the tips?");
        video2.AddComment("John Calvin", "I'm definitely booking a session with y'all.");
        videos.Add(video2);

        Video video3 = new Video("The Chosen", "LDS", 850);
        video3.AddComment("Whitney Houston", "Really learnt so much!");
        video3.AddComment("Jane Jasphat", "Thanks for sharing.");
        video3.AddComment("Philip Dave", "I will be watching this forever.");
        video3.AddComment("Joshua Simon", "I know we could all be better.");
        videos.Add(video3);

        Video video4 = new Video("Tech Savvy Tips", "Emma Hale", 560);
        video4.AddComment("John Stone", "Worth the time!");
        video4.AddComment("Wilson McKean", "Thanks Emma! I learnt alot.");
        video4.AddComment("Philemon Raphael", "I really enjoyed every bit of it.");
        video4.AddComment("Sarah Michael", "I learn so much about tech from this video.");
        videos.Add(video4);

        foreach(var video in videos)
        {
            video.DisplayVideoDetails();
        }
    }
}