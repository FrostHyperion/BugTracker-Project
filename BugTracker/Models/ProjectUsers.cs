namespace BugTracker.Models
{
    public class ProjectUsers
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public  Project? project { get; set; }
        public string UserId { get; set; }
        public Users? users { get; set; }

        
    }
}
