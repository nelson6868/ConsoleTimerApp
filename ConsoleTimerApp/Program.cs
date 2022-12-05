using ConsoleTimerApp;
using System.Diagnostics;
namespace Time_Alert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter a Worktime duration in minutes: ");
                int WorkDuration = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter a Resttime duration in minutes: ");
                int RestDuration = Convert.ToInt32(Console.ReadLine());
                startTimer st = new startTimer();
                st.consoleTimerCount(WorkDuration, RestDuration);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error in input format, please try again");
                Console.WriteLine(ex.ToString());
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
            }

        }
    }
}