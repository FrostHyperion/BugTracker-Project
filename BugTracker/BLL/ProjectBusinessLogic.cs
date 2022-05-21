using BugTracker.DAL;
using BugTracker.Models;

namespace BugTracker.BLL
{
    public class ProjectBusinessLogic
    {
        IGenricRepository<Project> repo;
        public ProjectBusinessLogic(IGenricRepository<Project> repoArg)
        {
            repo = repoArg;
        }

        public void AddProject(Project project)
        {
            repo.Create(project);
            repo.Save();
        }
        public void UsersAssign()
        {

        }

    }
}
