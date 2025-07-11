using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal();

        string input = "";
        while (input != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");
            input = Console.ReadLine();

            if (input == "1")
            {
                string promptText = prompt.GetRandomPrompt();
                Console.Write("> ");
                string userAnswer = Console.ReadLine();

                Entry entry = new Entry(); //new entry so it does not overwrite 
                entry._promptText = promptText;
                entry._entryText = userAnswer;
                entry._date = dateText;

                journal.AddEntry(entry);
            }
            else if (input == "2")
            {
                journal.DisplayAll();
            }
            else if (input == "3")
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);           
            }
            else if (input == "4")
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
            else if (input != "5")
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}