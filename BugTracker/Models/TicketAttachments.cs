using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TicketAttachments
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        [Required]
        public string FilePath { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public string UserId { get; set; }
        [Required]
        public string FileUrl { get; set; }
        public virtual Tickets Ticket { get; set; }
        public virtual Users User { get; set; }

        public TicketAttachments()
        {
            this.Created = DateTime.Now;
        }

    }
}
