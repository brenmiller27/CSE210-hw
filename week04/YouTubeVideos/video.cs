using System;

public class Video
{
    public string _title;
    public string _author;
    public string _length;
    public List<Comment> _commentlist = new List<Comment>();

    public void DisplayVideoDetails()
    {
        Console.WriteLine($"Title: {_title}");
        Console.WriteLine($"Author: {_author}");

         Console.WriteLine($"Length: {_length} seconds");
        int commentcount = _commentlist.Count();

        Console.WriteLine($"Comments: {commentcount}");


         foreach (Comment comment in _commentlist)

         {
            comment.DisplayComment();
         }

    }
}