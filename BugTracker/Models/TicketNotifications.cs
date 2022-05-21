namespace BugTracker.Models
{
    public class TicketNotifications
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public virtual Tickets ticket { get; set; }
        public string UserId { get; set; }
        public virtual Users User { get; set; }
    }
}
