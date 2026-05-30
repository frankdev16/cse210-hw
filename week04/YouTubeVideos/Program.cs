using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videoLibrary = new List<Video>();

        Video vid1 = new Video("C# Encapsulation in 10 Minutes", "CodeNinja", 600);
        vid1.AddComment(new Comment("DevStudent99", "This finally made sense!"));
        vid1.AddComment(new Comment("CodePro", "Great explanation of the database analogy."));
        vid1.AddComment(new Comment("NoobCoder", "Can you do one on Abstraction next?"));
        videoLibrary.Add(vid1);

        Video vid2 = new Video("Top 5 Backend Frameworks in 2026", "TechTalks", 950);
        vid2.AddComment(new Comment("PythonFan", "Django should be number 1."));
        vid2.AddComment(new Comment("JS_Dev", "Node.js is faster."));
        vid2.AddComment(new Comment("FranklinA", "Python and Django is the core stack!"));
        videoLibrary.Add(vid2);

        Video vid3 = new Video("FPL Gameweek 38 Transfer Tips", "Santino FC", 1200);
        vid3.AddComment(new Comment("SoccerFan", "Who is the best captain choice?"));
        vid3.AddComment(new Comment("FPL_Manager", "Taking a -4 hit this week."));
        vid3.AddComment(new Comment("Gunner", "Great analysis as always."));
        videoLibrary.Add(vid3);

        Console.WriteLine("YOUTUBE VIDEO TRACKER");
        foreach (Video video in videoLibrary)
        {
            video.DisplayInfo();
        }
    }
}