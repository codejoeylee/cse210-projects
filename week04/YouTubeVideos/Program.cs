using System;
using System.Collections.Generic;

class Comment
{
    public string CommenterName;
    public string CommentText;

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
    public string Title;
    public string Author;
    public int Length;
    public List<Comment> Comments;

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
        Console.WriteLine($"Number of comments : {GetNumberOfComments()}");
        Console.WriteLine("Comments: ");
        foreach (var comment in Comments)
        {
            Console.WriteLine($" - {comment.getstring()}");
        }
        Console.WriteLine("");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video("Absraction lessions", "Joeylee", 200);
        Video video2 = new Video("Web Development", "Kojolee", 400);
        Video video3 = new Video("Microbiology", "Prof.Dave", 600);


        video1.AddComment(new Comment("Benjamin Asante", "This is so good"));
        video1.AddComment(new Comment("Elizbet Asante", "Nice tutorials"));
        video1.AddComment(new Comment("Melvin Asante", "Good work."));


        video2.AddComment(new Comment("Benjamin Asante", "This is so good"));
        video2.AddComment(new Comment("Elizbet Asante", "Nice tutorials"));
        video2.AddComment(new Comment("Benjamin ", "Good work."));

        video3.AddComment(new Comment("Seth", "Nice work, The only lession I need for this semester"));
        video3.AddComment(new Comment("Sandra", "All i need to pass my GEMP test"));
        video3.AddComment(new Comment("Lordina", "Good work."));

        List<Video> videos = new List<Video> { video1, video2, video3 };

        foreach (var video in videos)
        {
            video.DisplayInfo();
        }
    }
}