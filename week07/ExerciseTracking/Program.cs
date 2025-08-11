using System;

class Program
{
    static void Main(string[] args)
    {
        RunningActivity running = new RunningActivity("08 AGO 2025", 30, 4.8d);
        SwimmingActivity swimming = new SwimmingActivity("08 AGO 2025", 60, 10d);
        CyclingActivity cycling = new CyclingActivity("08 AGO 2025", 40, 12d);

        List<Activity> activities = new List<Activity>();
        activities.Add(running);
        activities.Add(swimming);
        activities.Add(cycling);

        foreach (Activity act in activities)
        {
            Console.WriteLine(act.GetSummary());
        }

    }
}