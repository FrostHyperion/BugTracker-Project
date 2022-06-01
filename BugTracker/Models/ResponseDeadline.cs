namespace BugTracker.Models
{
    public class ResponseDeadline : DeadlineStrategy
    {
        string DeadlineStrategy.GetDeadlineStrategy()
        {
            return "ResponseDeadline";
        }
    }
}
