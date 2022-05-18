namespace BugTracker.Models
{
    public class TicketAttachments
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public virtual Tickets? tickets { get; set; }
        public string FilePath { get; set; }
        public string Description  { get; set; }
        public DateTime Created { get; set; }
        public virtual string UserId   { get; set; }
        public virtual Users? users { get; set; }
        public string FileUrl { get; set; }

    }
}
