using System;
using System.Collections.Generic;
public class PromptGenerator
{
    public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("What did I learn today?");
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("A challenge I faced and how I overcame it.");
        _prompts.Add("If I had one thing I could do over today, what would it be?");

        Random randomPrompt = new Random();
        int index = randomPrompt.Next(_prompts.Count);
        string prompt = _prompts[index];
        Console.WriteLine(prompt);
        return prompt;
    }

}