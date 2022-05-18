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
            Tickets = new HashSet<Tickets>();
        }
        public virtual ICollection<Tickets> Tickets { get; set; }


    }
}
