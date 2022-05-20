using BugTracker.DAL;
using BugTracker.Models;

namespace BugTracker.BLL
{
    public class UserBLL
    {
        IGenricRepository<Users> repo;
        public UserBLL(IGenricRepository<Users> repoArg)
        {
            repo = repoArg;
        }

        public void UpdateNameAndPassword(Users user)
        {
            repo.Update(user);
            repo.Save();
        }
    }
}
