namespace BugTracker.Models
{
    public class TicketHistories
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public virtual Tickets? tickets { get; set; }
        public string Property { get; set; }
        public string OldValue  { get; set; }
        public string NewValue { get; set; }
        public DateTime Changed { get; set; }
        public string UserId { get; set; }
        public virtual Users? Users { get; set; }
    }
}
