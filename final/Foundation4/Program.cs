using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();
        RunningActivity running = new RunningActivity("07 Jul 2024", 30, 3.0);
        activities.Add(running);
        CyclingActivity cycling = new CyclingActivity("14 Jul 2024", 30, 17.4);
        activities.Add(cycling);
        SwimmingActivity swimming = new SwimmingActivity("22 Jul 2024", 30, 20);
        activities.Add(swimming);

        foreach (Activity activity in activities)
        {
            activity.GetSummary();
        }
    }
}