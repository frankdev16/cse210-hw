using System;
using System.Collections.Generic;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }

    public void AddComment(Comment newComment)
    {
        _comments.Add(newComment);
    }

    public int GetCommentCount()
    {
        return _comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"\nTitle: {_title}");
        Console.WriteLine($"Author: {_author} | Length: {_length} seconds");
        Console.WriteLine($"Comments ({GetCommentCount()}):");

        foreach (Comment comment in _comments)
        {
            Console.WriteLine(comment.GetDisplayText());
        }
        Console.WriteLine("---------------------------------------------");
    }
}