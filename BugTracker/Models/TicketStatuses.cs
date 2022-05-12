namespace BugTracker.Models
{
    public class TicketStatuses
    {
        public int Id { get; set; }
        public TicketStatus Name { get; set; }


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