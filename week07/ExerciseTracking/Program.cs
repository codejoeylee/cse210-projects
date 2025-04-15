using System;
using System.Collections.Generic;
using Exercise_Tracker;

namespace Exercise_Tracker
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Running run = new Running("03 Feb 2025", 30, 3.0);
            Cycling cycle = new Cycling("03 Mar 2025", 45, 20.0);
            Swimming swim = new Swimming("03 Apr 2025", 25, 40);

            List<Activity> activities = new List<Activity> { run, cycle, swim };

            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}