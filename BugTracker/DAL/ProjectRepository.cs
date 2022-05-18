using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.DAL;

public class ProjectRepository : IGenricRepository<Project>
{
    private readonly ApplicationDbContext _context; //

    public ProjectRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public ICollection<Project>? GetList(Func<Project, bool>? whereFunction)
    {
        List<Project>? projects = null;
        if (whereFunction != null)
        {
            projects=_context.Projects.Where(whereFunction).ToList();
        }
        return projects;
    }

    public Project? Get(Func<Project, bool>? firstFunction)
    {
        Project? project = null;
        if (firstFunction != null)
        {
            project = _context.Projects.First(firstFunction);

        }  
            return project;
    }
    

    public void Create(Project? entity)
    {
        if(entity != null)_context.Projects.Add(entity);
    }

    public void Delete(int? id)
    {

        if(id is not null)
        {
            _context.Projects.Remove(_context.Projects.First(i=> Equals(i,id)));
        }
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Update(Project? entity)
    {
        if (entity != null) _context.Projects.Update(entity);

    }
}