namespace BugTracker.Models
{
    public class TicketTypes
    {
        public int Id { get; set; }
        public TicketTypeCheck Name { get; set; }

        public enum TicketTypeCheck
        {
            Incident,
            LostRequest,
            LostResponse,
            
        }
        public virtual ICollection<Tickets> Tickets { get; set; }

    }
}
