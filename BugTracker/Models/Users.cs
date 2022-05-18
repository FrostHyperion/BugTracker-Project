using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BugTracker.Models
{
    public class Users : IdentityUser
    {
        public virtual ICollection<TicketComments> TicketComments { get; set; }
        public virtual ICollection<ProjectUsers> ProjectUsers { get; set; }
        public virtual ICollection<TicketNotifications> TicketNotifications { get; set; }
        public virtual ICollection<TicketHistories> TicketHistories { get; set; }
        public virtual ICollection<TicketAttachments> TicketAttachments { get; set; }
        [InverseProperty("OwnerUser")]
        public virtual ICollection<Tickets> OwnedTickets { get; set; }

        [InverseProperty("AssignedToUsers")]
        public virtual ICollection<Tickets> AssignedTickets { get; set; }

        public Users()
        {
            this.TicketComments = new HashSet<TicketComments>();
            this.ProjectUsers = new HashSet<ProjectUsers>();
            this.TicketNotifications = new HashSet<TicketNotifications>();
            this.TicketHistories = new HashSet<TicketHistories>();
        }
    }

    }

