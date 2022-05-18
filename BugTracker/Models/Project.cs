namespace BugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public virtual ICollection<Tickets> Tickets { get; set; }

        public virtual ICollection<ProjectUsers> ProjectUsers { get; set; }
        public Project(string name)
        {
            Name = name;
            Tickets = new HashSet<Tickets>();
            ProjectUsers = new HashSet<ProjectUsers>();
        }
    }
}
