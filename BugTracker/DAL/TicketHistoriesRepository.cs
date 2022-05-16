using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.DAL;
    public class TicketHistoriesRepository : IGenricRepository<TicketHistories>
{
    private readonly ApplicationDbContext _context; //

    public void Create(TicketHistories? entity)
    {
        if(entity != null) _context.tickethistories.Add(entity);
    }

    public void Delete(int? id)
    {
        if (id is not null) _context.tickethistories.Remove(_context.tickethistories.First(i => Equals(i, id)));
    }

    public TicketHistories? Get(Func<TicketHistories, bool>? firstFunction)
    {
        TicketHistories? Tickethistories = null;

        if (firstFunction != null)
        {
            Tickethistories = _context.tickethistories.First(firstFunction);

        }
        return Tickethistories;
    }

    public ICollection<TicketHistories>? GetList(Func<TicketHistories, bool>? whereFunction)
    {
        List<TicketHistories> Tickethistories = null;
        if (whereFunction != null)
        {
            Tickethistories = _context.tickethistories.Where(whereFunction).ToList();
        }
        return Tickethistories;
    }

    public void save()
    {
        _context.SaveChanges();
    }

    public void Update(TicketHistories? entity)
    {
        if (entity != null) _context.tickethistories.Update(entity);

    }
}