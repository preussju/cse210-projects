
using System.Globalization;

public class ReflectingActivity : Activity
{
    private List<String> _prompts = new List<string>();
    private List<String> _questions = new List<string>();

    public ReflectingActivity(): base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", 5)
    {
    }

    public void Run()
    {

        DisplayPrompt();
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience ");
        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.Clear();
        DisplayQuestions();
        Console.WriteLine();
        Console.WriteLine("Well Done!");
    }

    public string GetRandomPrompt()
    {
        _prompts = [
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless." ];

        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        return _prompts[index];
    }

    public string GetRandomQuestion()
    {
        _questions = [
            "Why was this experience meaningful to you?",
            "Have you ever done anything like this before?",
            "How did you get started?", "How did you feel when it was complete?",
            "What made this time different than other times when you were not as successful?",
            "What is your favorite thing about this experience?",
            "What could you learn from this experience that applies to other situations?",
            "What did you learn about yourself through this experience?",
            "How can you keep this experience in mind in the future?" ];

        Random randomQuestion = new Random();
        int index = randomQuestion.Next(_questions.Count);
        return _questions[index];
    }

    public void DisplayPrompt()
    {
        Console.WriteLine();
        Console.WriteLine("Consider the following prompt: ");
        Console.WriteLine();
        Console.WriteLine("---"+ GetRandomPrompt() + "---");
        Console.WriteLine();
        Console.Write("When you have something in mind, press enter to continue.");
    }

    public void DisplayQuestions()
    {  
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.WriteLine(GetRandomPrompt());
            ShowSpinner(6);
        }
    }
}