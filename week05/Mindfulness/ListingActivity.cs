
using System.Runtime.CompilerServices;

public class ListingActivity : Activity
{
    private int _count;
    private List<String> _prompts;

    public ListingActivity() : base ("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",5)
    {
    }

    public void Run()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine("---"+ GetRandomPrompt() +"---");
        Console.Write("You may begin in:");
        ShowCountDown(5);
        Console.WriteLine();
        _count = GetListFromUser().Count;
        Console.WriteLine($"You listed {_count}!");
    }

    public string GetRandomPrompt()
    {
        _prompts = [
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"];

        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

    public List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            string response = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(response))
            {
                userList.Add(response);
            }
        }
        return userList;
    }

}