namespace BugTracker.Models
{
    public class TicketPriorities
    {
        public int Id { get; set; }
        public TicketPriorityLevel Name { get; set; }

        public enum TicketPriorityLevel
        {
            High,
            Medium,
            Low
        }
        public TicketPriorities()
        {
            Ticket = new HashSet<Tickets>();
        }
        public virtual ICollection<Tickets> Ticket { get; set; }


    }
}
