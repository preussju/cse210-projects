using System;

class Program
{
    static void Main(string[] args)
    {
        // Call the DisplayWelcome method
        DisplayWelcome();
        // Call the PromptUserName method and store the result
        string userName = PromptUserName();
        // Call the PromptUserNumber method and store the result
        int userNumber = PromptUserNumber();
        // Call the SquareNumber method with the user's number and store the result
        int squaredNumber = SquareNumber(userNumber);
        // Call the DisplayResult method with the user's name and the squared number
        DisplayResult(userName, squaredNumber);
    }
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        return Console.ReadLine();
    }
    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        string input = Console.ReadLine();
        int number = int.Parse(input);
        return number;
    }
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    static void DisplayResult(string userName, int squaredNumber)
    {
        Console.WriteLine($"{userName}, the square of your number is {squaredNumber}.");
    }   
}
