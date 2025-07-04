using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        List<int> numList = new List<int>();
        int number = -1;
        int sum = 0;
        while (number != 0)
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            number = int.Parse(input);

            if (number != 0)
            {
                numList.Add(number);
            }
        }
        //sum the numbers
        foreach (int num in numList)
        {
            sum += num;
        }
        Console.WriteLine($"The sum is: {sum}");

        // Calculate the average
        float average = (float)sum / numList.Count;
        Console.WriteLine($"The average is: {average}");

        // Find the maximum number
        int max = numList[0];
        foreach (int num in numList)
        {
            if (num > max)
            {
                max = num;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }
}