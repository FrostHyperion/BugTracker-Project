using static BugTracker.Models.Tickets;

namespace BugTracker.Models
{
    public class Program
    {
        public static void main()
        {
            DeadlineStrategy ResponseDeadline = new ResponseDeadline();
            DeadlineStrategy BreachDeadline = new BreachDeadline();
            Tickets BugReports =  new BugReport(ResponseDeadline,Priority.High);
            Console.WriteLine(BugReports.GetStrategy());
        }
    }
}
