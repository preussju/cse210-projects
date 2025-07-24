
public class Video
{
    public string _title;
    public string _author;
    public int _length;
    public List<Comment> _comments;

    public int CommentNumber()
    {
        int num = 0;
        foreach (var com in _comments)
        {
            num++;
        }
        return num;
    }

    public void DisplayVideo()
    {
        Console.WriteLine($"Title: {_title} | Author: {_author}");
        Console.WriteLine($"Video Length: {_length}s | Comments Number: {CommentNumber()}");
        Console.WriteLine("Comments:");

        foreach ( var com in _comments) {
            com.DisplayComment();
        }
    }

}