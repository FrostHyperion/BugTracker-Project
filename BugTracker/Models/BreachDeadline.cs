namespace BugTracker.Models
{
    public class BreachDeadline : DeadlineStrategy
    {
        string DeadlineStrategy.GetDeadlineStrategy()
        {
            return "BreachDeadline";
        }
    }
}
