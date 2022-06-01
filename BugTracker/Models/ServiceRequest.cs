namespace BugTracker.Models
{
    public class ServiceRequest: Tickets
    {
        public ServiceRequest(DeadlineStrategy deadlineStrategy, Priority priority) : base(deadlineStrategy,priority)
        {
        }

        public TypeofRequest Name { get; set; }

        public override int GetDeadline()
        {
            if (DeadlineStrategy.GetDeadlineStrategy() == "ResponseDeadline")
            {
                return Deadline + 10 + 24;
            }
            if (DeadlineStrategy.GetDeadlineStrategy() == "BreachDeadline")
            {
                return Deadline + 10 + 72;
            }
            return Deadline + 10;
        }

        public enum TypeofRequest
        {
            Servicerequest,
            Incident,
            Problem,
            Changerequest,
        }
    }
}
