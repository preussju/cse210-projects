using System;
using System.Collections.Generic;

// "convenant path" option was added. record the user's progress in reading the scriptures. They can
// register the chapter they read at that day, they cannot register more than once a day
// "convenant path history" displays the user record. 
// Journal - SaveDailyScriptureToFile(string filename) function is used inside SaveToFile() function. to make sure this record is not deleted nor duplicated.

class Program
{
    static void Main(string[] args)
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();  //getting todays date

        PromptGenerator prompt = new PromptGenerator();
        Journal journal = new Journal(); // new journal for the prompts

        Journal journal2 = new Journal(); // new journal for convenant path entries
        string scriptureFilePath = Path.Combine(Directory.GetCurrentDirectory(), "scripture.txt"); //construct the full file path (making sure is not a problem)
        journal2.LoadFromFile(scriptureFilePath);  // loads scripture.txt so option "6" can display convenant path

        string input = "";
        while (input != "7")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Convenant Path");
            Console.WriteLine("6. Convenant Path History");
            Console.WriteLine("7. Quit");
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

                journal.AddEntry(entry); // keeping users answers
            }
            else if (input == "2")
            {
                journal.DisplayAll(); // displays user's prompt answers
            }
            else if (input == "3")
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.LoadFromFile(file); // loads the user's file 
            }
            else if (input == "4")
            {
                Console.WriteLine("What is the filename? ");
                string file = Console.ReadLine();
                journal.SaveToFile(file); // saves user's file
            }
            else if (input == "5")
            // "convenant path" record the user's progress in reading the scriptures. They can
            // register the chapter they read at that day | the file is loaded up there 
            {
                if (!journal2._entries.Any(e => e._date == dateText))  // checks if answer already been given
                {
                    Console.WriteLine("This is your daily reminder to read the scriptures!");
                    Console.Write("Register the chapter you have read today: ");
                    string userAnswer = Console.ReadLine();

                    Entry chapterEntry = new Entry();
                    chapterEntry._promptText = "Scripture of the day!";
                    chapterEntry._date = dateText;
                    chapterEntry._entryText = userAnswer;

                    journal2.AddEntry(chapterEntry);
                    journal2.SaveToFile(scriptureFilePath);
                    Console.WriteLine("Entry saved!");
                }
                else
                {
                    Console.WriteLine("You have already registered the scripture of the day!");
                }
            }
            else if (input == "6")
            {
                journal2.DisplayAll(); // displays only the convenant path progress
            }
            else if (input != "7")
            {
                Console.WriteLine("Please enter a valid number.");
            }
        }
    }
}