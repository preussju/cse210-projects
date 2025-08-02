
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration; 
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine();
        Console.WriteLine(_description);
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.Write("Get Ready");
        ShowSpinner(5);
        Console.Clear();

    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine($"You have completed {_duration} seconds of {_name}!");
    }

    public void ShowSpinner(int seconds)
    {
        List<string> animation = new List<string>();
        animation = ["|", "/", "-", "\\"];

        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(seconds);
        int i = 0;

        while (DateTime.Now < end)
        {
            string a = animation[i];
            Console.Write(a);
            Thread.Sleep(700);
            Console.Write("\b \b");
            i++;

            if (i >= animation.Count) {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}