using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Tickets> Ticket { get; set; }

        public virtual ICollection<ProjectUsers> ProjectUser { get; set; }

        public Project()
        {
            Ticket = new HashSet<Tickets>();
            ProjectUser = new HashSet<ProjectUsers>();
        }
    }
}
