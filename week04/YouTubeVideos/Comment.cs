
public class Comment
{
    public string _person;
    public string _text;

    public void DisplayComment()
    {
        Console.WriteLine($"Author: {_person} - {_text}");
    }
}