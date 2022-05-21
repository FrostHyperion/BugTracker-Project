
using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.DAL;

public class ProjectUsersRepository : IGenricRepository<ProjectUsers>
{
    private readonly ApplicationDbContext _context; //

    public ProjectUsersRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public void Create(ProjectUsers? entity)
    {
        if (entity != null) _context.Projectsusers.Add(entity);

    }

    public void Delete(int? id)
    {   
        if (id is not null)
        {
            _context.Projectsusers.Remove(_context.Projectsusers.First(i => Equals(i, id)));
        }
    }

    public ProjectUsers? Get(Func<ProjectUsers, bool>? firstFunction)
    {
        ProjectUsers? projectUsers = null;
        if(firstFunction != null)
        {
            projectUsers = _context.Projectsusers.First(firstFunction);
            
        }
        return projectUsers;
    }

    public ICollection<ProjectUsers>? GetList(Func<ProjectUsers, bool>? whereFunction)
    {
        List<ProjectUsers>? projectsusers = null;
        if (whereFunction != null)
        {
            projectsusers = _context.Projectsusers.Where(whereFunction).ToList();
        }
        return projectsusers;

    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Update(ProjectUsers? entity)
    {
        if(entity != null)_context.Projectsusers.Update(entity);
    }
}