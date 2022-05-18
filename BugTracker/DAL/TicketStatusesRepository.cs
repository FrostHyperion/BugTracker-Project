using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.DAL;
public class TicketStatusesRepository : IGenricRepository<TicketStatuses>
{
    private readonly ApplicationDbContext _context;
    public void Create(TicketStatuses? entity)
    {
        if(entity != null)_context.ticketstatuses.Add(entity);
    }

    public void Delete(int? id)
    {
        if(id is not null)_context.ticketstatuses.Remove(_context.ticketstatuses.First(i => Equals(i, id)));
    }

    public TicketStatuses? Get(Func<TicketStatuses, bool>? firstFunction)
    {
        TicketStatuses? Ticketstatuses = null;

        if (firstFunction != null)
        {
            Ticketstatuses = _context.ticketstatuses.First(firstFunction);

        }
        return Ticketstatuses;
    }

    public ICollection<TicketStatuses>? GetList(Func<TicketStatuses, bool>? whereFunction)
    {
        List<TicketStatuses> Ticketstatuses = null;
        if (whereFunction != null)
        {
            Ticketstatuses = _context.ticketstatuses.Where(whereFunction).ToList();
        }
        return Ticketstatuses;
    }

    public void Save()
    {
        _context.SaveChanges();
    }

    public void Update(TicketStatuses? entity)
    {
        if(entity is not null)_context?.ticketstatuses.Update(entity);
    }
}
