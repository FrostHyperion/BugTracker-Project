using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public abstract class Tickets
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public int ProjectId { get; set; }
        [Required]
        public int TicketTypeId { get; set; }
        [Required]
        public int TicketPriorityId { get; set; }
        public int TicketStatusId { get; set; }
        public string OwnerUserId { get; set; }
        public string AssignedToUserId { get; set; }

        public virtual Project Project { get; set; }
        public virtual TicketTypes TicketTypes { get; set; }
        public virtual TicketPriorities TicketPriorities { get; set; }
        public virtual TicketStatuses TicketStatuses { get; set; }
        public virtual Users? OwnerUser { get; set; }
        public virtual Users? Users { get; set; }
        public virtual Users? AssignedToUsers { get; set; }
        public DeadlineStrategy DeadlineStrategy { get; set; }  
        public int Deadline { get; set; }
        public enum Priority
        {
            High,
            Moderate,
            Low,
        }
        public Priority priority { get; set; }


        public virtual ICollection<TicketNotifications> TicketNotifications { get; set; }
        public virtual ICollection<TicketHistories> TicketHistories { get; set; }
        public virtual ICollection<TicketComments> TicketComments { get; set; }
        public virtual ICollection<TicketAttachments> TicketAttachments { get; set; }
        public Tickets(DeadlineStrategy deadlineStrategy, Priority priority)
        {
            TicketNotifications = new List<TicketNotifications>();
            TicketHistories = new List<TicketHistories>();
            TicketComments = new List<TicketComments>();
            TicketAttachments = new List<TicketAttachments>();
            Created = DateTime.Now;
            Updated = Created;
            DeadlineStrategy = deadlineStrategy;
            this.priority = priority;
            if(priority == Priority.High)
            {
                Deadline = 24;
            }
            if(priority == Priority.Low)
            {
                Deadline = 72;
            }
            if(priority != Priority.Moderate)
            {
                Deadline = 48;
            }
        }
        public void SetDeadlineStrategy(DeadlineStrategy deadlineStrategy)
        {
            DeadlineStrategy = deadlineStrategy;
        }
        public abstract int GetDeadline();
        public string GetStrategy()
        {
            return DeadlineStrategy.GetDeadlineStrategy();
        }
        
    }


}
