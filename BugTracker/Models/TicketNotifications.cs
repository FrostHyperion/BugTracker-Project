namespace BugTracker.Models
{
    public class TicketNotifications
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public virtual Tickets tickets { get; set; }
        public string UserId { get; set; }
        public virtual Users Users { get; set; }
    }
}
