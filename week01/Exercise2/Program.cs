using System;

class Program
{
    static void Main(string[] args)
    {
        //A >= 90
        //B >= 80
        //C >= 70
        //D >= 60
        //F < 60

        Console.WriteLine("Enter your grade percentage:");
        string input = Console.ReadLine();

        int grade = int.Parse(input);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is: {letter}");

        if (grade >= 70)
        {
            Console.WriteLine("Hooray! You passed the course.");
        }
        else
        {
            Console.WriteLine("Oh.. You did not pass the course, do not give up!");
        }
    }
}