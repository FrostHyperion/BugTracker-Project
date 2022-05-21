using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class TicketComments
    {
        public int Id { get; set; }
        [Required]
        public string Comment { get; set; }
        public DateTime Created { get; set; }
        public int TicketId { get; set; }
        public virtual Tickets ticket { get; set; }
        public string UserId { get; set; }
        public virtual Users user { get; set; }
        public TicketComments()
        {
            this.Created = DateTime.Now;
        }
    }
}
