using System.ComponentModel.DataAnnotations;

namespace BugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }

        public virtual ICollection<ProjectUsers> ProjectUsers { get; set; }

        public Project()
        {
            Tickets = new HashSet<Tickets>();
            ProjectUsers = new HashSet<ProjectUsers>();
        }
    }
}
