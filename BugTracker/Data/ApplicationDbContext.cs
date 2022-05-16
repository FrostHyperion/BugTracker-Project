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

        public virtual DbSet<Project> Projects { get; set; } = null;
        public virtual DbSet<ProjectUsers> Projectsusers { get; set; } = null;
        public virtual DbSet<TicketAttachments> Ticketattachments { get; set; } = null;


        public virtual DbSet<Tickets> tickets { get; set; } = null;


        public virtual DbSet<TicketComments> ticketcomments { get; set; } = null;
        public virtual DbSet<TicketHistories> tickethistories { get; set; } = null;
        public virtual DbSet<TicketNotifications> ticketnotifications { get; set; } = null;

        public virtual DbSet<TicketStatuses> ticketstatuses { get; set; } = null;
        public virtual DbSet<TicketTypes> tickettypes { get; set; } = null;


    }
}