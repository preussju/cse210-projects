using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Julia", "Division");
        Console.WriteLine(assignment.GetSummary());

        Console.WriteLine();

        MathAssignment math = new MathAssignment("Julie", "Multiplication", "7.3", "8-19");
        Console.WriteLine(math.GetSummary());
        Console.WriteLine(math.GetHomeworkList());

        Console.WriteLine();

        WritingAssignment writing = new WritingAssignment("Jules", "History", "The WW2");
        Console.WriteLine(writing.GetSummary());
        Console.WriteLine(writing.GetWritingInformation());
    }
}

//learn and practice the principle of Inheritance