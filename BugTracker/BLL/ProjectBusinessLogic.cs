using BugTracker.DAL;
using BugTracker.Models;
using Microsoft.AspNetCore.Identity;

namespace BugTracker.BLL
{
    public class ProjectBusinessLogic
    {
        IGenricRepository<ProjectUsers> repo;
        IGenricRepository<Project> repos;
        private readonly UserManager<Users> _userManager;
        public ProjectBusinessLogic(IGenricRepository<ProjectUsers> repoArg, IGenricRepository<Project> repoArgs, UserManager<Users> userManager)
        {
            repo = repoArg;
            _userManager = userManager;
            repos = repoArgs;
        }

        public void AddProject(Project project)
        {
            repos.Create(project);
            repos.Save();
        }
        public void UsersAssign(string userId, int projectId)
        {
            ProjectUsers pu = new()
            {
                ProjectId = projectId,
                UserId = userId
            };

            repo.Create(pu);
        }

    }
}


