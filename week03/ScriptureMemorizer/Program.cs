using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Mosiah", 2, 41);
        Scripture scripture = new Scripture(reference, "And moreover, I would desire that ye should consider on the blessed and happy state of those that keep the commandments of God. For behold, they are blessed in all things, both temporal and spiritual; and if they hold out faithful to the end they are received into heaven, that thereby they may dwell with God in a state of never-ending happiness. O remember, remember that these things are true; for the Lord God hath spoken it.");

        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.Write("Press enter to continue or type 'quit' to finish: ");
        string input = Console.ReadLine();

        while (input != "quit" && !scripture.IsCompletelyHidden())
        {
            //clear the console and display the complete scripture
            // runs until the user chooses to quit or the scripture is all hidden
            Console.Clear();
            scripture.HideRandomWords(1);
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press enter to continue or type 'quit' to finish: ");
            input = Console.ReadLine();

        }
    }
}