namespace BugTracker.Models
{
    public class Tickets
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Descripiton { get; set; }
        public DateTime Created { get; set; }
        public  DateTime Updated { get; set; }
        public int? ProjectId { get; set; }
        public virtual TicketTypes tickettype { get; set; }
        public int? TickedTypeId  { get; set; }

        public TicketPriorities ticketpriorities { get; set; }
        public int? TicketPriorityId { get; set; }
        public TicketStatuses ticketstatuses { get; set; }

        public int? TicketStatusId { get; set; }
        public string? OwnerUserId { get; set; }
        public string? AssignedToUserId { get; set; }
        public virtual ICollection<TicketComments> TicketComments { get; set; }
        public virtual ICollection<TicketNotifications> TicketNotifications { get; set; }
        public virtual ICollection<TicketHistories> TicketHistories { get; set; }
        public virtual ICollection<TicketAttachments> TicketAttachments { get; set; }

    }
}
