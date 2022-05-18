using BugTracker.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BugTracker.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<ProjectUsers> Projectsusers { get; set; }
        public virtual DbSet<TicketAttachments> Ticketattachments { get; set; }
        public virtual DbSet<Tickets> tickets { get; set; }
        public virtual DbSet<TicketComments> ticketcomments { get; set; }
        public virtual DbSet<TicketHistories> tickethistories { get; set; }
        public virtual DbSet<TicketNotifications> ticketnotifications { get; set; }
        public virtual DbSet<TicketStatuses> ticketstatuses { get; set; }
        public virtual DbSet<TicketTypes> tickettypes { get; set; }
        public virtual DbSet<Users> users { get; set; }

    }
}