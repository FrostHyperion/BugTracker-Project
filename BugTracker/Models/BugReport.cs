namespace BugTracker.Models
{
    public class BugReport:Tickets
    {
        public BugReport(DeadlineStrategy deadlineStrategy, Priority priority) : base(deadlineStrategy,priority)
        {           
        }

        public string ErrorCode { get; set; }
        public string ErrorLog { get; set; }

        public override int GetDeadline()
        {
           if (DeadlineStrategy.GetDeadlineStrategy() == "ResponseDeadline")
            {
                return Deadline + 5 + 24;
            }
           if (DeadlineStrategy.GetDeadlineStrategy() == "BreachDeadline")
            {
                return Deadline + 5 + 72;
            }
            return Deadline + 5 ;
        }
    }
}
