using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Cooking", "Mike", 12);
        Video video2 = new Video("Football", "joe", 90);
        Video video3 = new Video("Css Tutorial", "Seth", 60);

        video1.AddComment(new Comment("ben", "nice video"));
        video1.AddComment(new Comment("benjamin", "Long video"));

        video2.AddComment(new Comment("benjamin", "nice video"));
        video2.AddComment(new Comment("benjamina", "good work"));

        video3.AddComment(new Comment("benjamin", "nice video"));
        video3.AddComment(new Comment("benjamina", "good work"));

        List<Video> videos = new List<Video> { video1, video2, video3 };
        foreach (var video in videos)
        {
            video.DisplayInfo();
        }

    }
}

class Comment
{
    public string CommenterName { get; set; }
    public string CommentText { get; set; }

    public Comment(string commenterName, string commentText)
    {
        CommenterName = commenterName;
        CommentText = commentText;
    }

    public string getstring()
    {
        return $"{CommenterName}: {CommentText}";
    }
}



class Video
{
    public string Title { get; set; }
    public string Author { get; set; }
    public int Length { get; set; }
    public List<Comment> Comments { get; set; }

    public Video(string title, string author, int length)
    {
        Title = title;
        Author = author;
        Length = length;
        Comments = new List<Comment>();
    }
    public void AddComment(Comment comment)
    {
        Comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return Comments.Count;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Title: {Title}");
        Console.WriteLine($"Author: {Author}");
        Console.WriteLine($"Length: {Length} seconds");
        Console.WriteLine($"Number of Comments: {GetNumberOfComments()}");
        foreach (var comment in Comments)
        {
            Console.WriteLine($"----{comment.getstring()}");
        }
        Console.WriteLine("");
    }
}
