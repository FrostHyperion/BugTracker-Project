namespace BugTracker.Models
{
    public class TicketStatuses
    {
        public int Id { get; set; }
        public TicketStatus Name { get; set; }
        public TicketStatuses()
        {
            Tickets = new HashSet<Tickets>();
        }


        public enum TicketStatus
        {
            Assigned,
            UnAssigned,
            InProgress,
            Completed
        }
        public virtual ICollection<Tickets> Tickets { get; set; }

    }

}