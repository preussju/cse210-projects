using System;

class Program
{
    static void Main(string[] args)
    {

        string choice = "";
        while (choice != "4")
        {
            Console.WriteLine();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start listing activity");
            Console.WriteLine("3. Start reflecting activity");
            Console.WriteLine("4. quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity breathing = new BreathingActivity();
                breathing.DisplayStartingMessage();
                breathing.Run();
                breathing.DisplayEndingMessage();
                breathing.ShowSpinner(5);

            }
            if (choice == "2")
            {
                ListingActivity listing = new ListingActivity();
                listing.DisplayStartingMessage();
                listing.Run();
                listing.DisplayEndingMessage();
                listing.ShowSpinner(5);

            }
            if (choice == "3")
            {
                ReflectingActivity reflecting = new ReflectingActivity();
                reflecting.DisplayStartingMessage();
                reflecting.Run();
                reflecting.DisplayEndingMessage();
                reflecting.ShowSpinner(5);
            }
        }

    }
}