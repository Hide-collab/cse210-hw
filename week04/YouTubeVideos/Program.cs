using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        // Video 1
        Video video1 = new Video("Learn C# in 20 Minutes", "Programming Hub", 1200);
        video1.AddComment(new Comment("Kuda", "Very helpful!"));
        video1.AddComment(new Comment("Brian", "Thanks for explaining clearly."));
        video1.AddComment(new Comment("Cindy", "Awesome tutorial!"));
        videos.Add(video1);

        // Video 2
        Video video2 = new Video("Top 10 Football Skills", "Soccer World", 850);
        video2.AddComment(new Comment("Munashe", "Amazing skills!"));
        video2.AddComment(new Comment("Pnashe", "Loved every second."));
        video2.AddComment(new Comment("Frank", "Great editing."));
        videos.Add(video2);

        // Video 3
        Video video3 = new Video("How to Cook Fried Rice", "Chef Mike", 900);
        video3.AddComment(new Comment("Takunda", "Looks delicious!"));
        video3.AddComment(new Comment("Tafadzwa", "Woow. Trying this tonight."));
        video3.AddComment(new Comment("Tinotenda", "Nice Recipe."));
        videos.Add(video3);

        // Video 4
        Video video4 = new Video("Temple and Family History Tips", "Church Learning", 780);
        video4.AddComment(new Comment("John", "Very inspiring."));
        video4.AddComment(new Comment("Prince", "Thank you for sharing."));
        video4.AddComment(new Comment("Luke", "I learned something new."));
        videos.Add(video4);

        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Title: {video.GetTitle()}");
            Console.WriteLine($"Author: {video.GetAuthor()}");
            Console.WriteLine($"Length: {video.GetLength()} seconds");
            Console.WriteLine($"Comments: {video.GetNumberOfComments()}");

            Console.WriteLine("\nComment List:");

            foreach (Comment comment in video.GetComments())
            {
                Console.WriteLine($"{comment.GetCommenterName()}: {comment.GetText()}");
            }

            Console.WriteLine();
        }
    }
}