namespace BugTracker.Models
{
    public class TicketTypes
    {
        public int Id { get; set; }
        public TicketTypeCheck Name { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }
        public TicketTypes()
        {
            Tickets = new HashSet<Tickets>();
        }

        public enum TicketTypeCheck
        {
            Incident,
            LostRequest,
            LostResponse,

        }
    }
}
