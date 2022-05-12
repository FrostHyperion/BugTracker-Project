using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace BugTracker.Models
{
    public class Users : IdentityUser
    {
        public virtual ICollection<Tickets> Tickets { get; set; }
        public virtual ICollection<TicketComments> TicketComments { get; set; }
        public virtual ICollection<ProjectUsers> ProjectUsers { get; set; }
        public virtual ICollection<TicketNotifications> TicketNotifications { get; set; }
        public virtual ICollection<TicketHistories> TicketHistories { get; set; }
        public virtual ICollection<TicketAttachments> TicketAttachments { get; set; }
    }
    }

