using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);
        int guessNumber = 0;

         while (guessNumber != magicNumber)
        {
            Console.Write("Enter yout guess: ");
            string guessInput = Console.ReadLine();
            guessNumber = int.Parse(guessInput);

            if (guessNumber > magicNumber)
            {
                Console.WriteLine("Lower");
            }
            else if (guessNumber < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (guessNumber == magicNumber)
            {
                Console.Write("You guessed it!");
            }
        }
    }
}