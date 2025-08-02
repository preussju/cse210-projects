
public class BreathingActivity : Activity
{
    public BreathingActivity() : base
    ("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",5)
    {
    }

    public void Run()
    {
        DateTime start = DateTime.Now;
        DateTime end = start.AddSeconds(_duration);

        while (DateTime.Now < end)
        {
            Console.Write("Breath in...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("Breath out...");
            ShowCountDown(5);
            Console.WriteLine();
            Console.WriteLine();

        }
    }
}