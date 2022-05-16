using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.DAL;
public class TIcketsRepository : IGenricRepository<Tickets>
{
    private readonly ApplicationDbContext _context;
    public void Create(Tickets? entity)
    {
        if(entity!=null)_context.tickets.Add(entity);
    }

    public void Delete(int? id)
    {
        if (id is not null) _context.tickets.Remove(_context.tickets.First(i => Equals(i, id)));
    }

    public Tickets? Get(Func<Tickets, bool>? firstFunction)
    {
        Tickets? Ticket = null;

        if (firstFunction != null)
        {
            Ticket = _context.tickets.First(firstFunction);

        }
        return Ticket;
    }

    public ICollection<Tickets>? GetList(Func<Tickets, bool>? whereFunction)
    {
        List<Tickets> Ticket = null;
        if (whereFunction != null)
        {
            Ticket = _context.tickets.Where(whereFunction).ToList();
        }
        return Ticket;
    }

    public void save()
    {
        _context.SaveChanges();
    }

    public void Update(Tickets? entity)
    {
        if(entity is not null)_context.tickets.Update(entity);
    }
}
