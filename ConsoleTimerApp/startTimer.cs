using System;
using System.Diagnostics;
namespace ConsoleTimerApp
{

    public class startTimer
    {
        public bool EndTimerCount = true;
        public void consoleTimerCount(int WorkDuration, int RestDuration)
        {

            DateTime StartTime = DateTime.Now;
            while (EndTimerCount)
            {
                Stopwatch WorkStopwatch = new();
                if (WorkDuration > 0)
                {
                    int WorkTimeInMinutes = WorkDuration * 1000 * 60;
                    WorkStopwatch.Start();
                    Console.WriteLine("Work Timer Active...");
                    Thread.Sleep(WorkTimeInMinutes);
                    WorkStopwatch.Stop();
                }
                else
                {
                    Console.WriteLine("Worktime you entered is invalid");
                }
                TimeSpan workTimeStop = WorkStopwatch.Elapsed;
                Console.WriteLine("Your WorkTime has completed");
                Console.WriteLine("\n");
                Stopwatch RestStopwatch = new();
                if (RestDuration > 0)
                {
                    int RestTimeInMinutes = RestDuration * 1000 * 60;
                    RestStopwatch.Start();
                    Console.WriteLine("Rest Timer Active...");
                    Thread.Sleep(RestTimeInMinutes);
                    RestStopwatch.Stop();
                }
                else
                {
                    Console.WriteLine("The RestTime you entered is invalid");
                }
                TimeSpan RestTimeStop = RestStopwatch.Elapsed;
                Console.WriteLine("\n");
                Console.WriteLine("Your RestTime Have Ended");
                Console.WriteLine("Do you want to continue this cycle? (y/n) ");
                string CheckTimer = Console.ReadLine();
                if (CheckTimer == "y")
                {
                    EndTimerCount = true;
                }
                else if (CheckTimer == "n")
                {
                    EndTimerCount = false;
                }
                else
                {
                    EndTimerCount = true;
                }
            }
            DateTime EndTime = DateTime.Now;
            Console.WriteLine("Your session has ended: ");
            Console.WriteLine($"Start Time: {StartTime.ToShortTimeString()}, \n  End Time: {EndTime.ToShortTimeString()}.");






        }
    }



}