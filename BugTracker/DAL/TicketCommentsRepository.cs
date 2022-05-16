using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.DAL;

public class TicketCommentsRepository : IGenricRepository<TicketComments>
{
    private readonly ApplicationDbContext _context; //

    public void Create(TicketComments? entity)
    {
        if (entity != null) _context.ticketcomments.Add(entity);

    }

    public void Delete(int? id)
    {
        if (id is not null)
        {
            _context.ticketcomments.Remove(_context.ticketcomments.First(i => Equals(i, id)));
        }
    }

    public TicketComments? Get(Func<TicketComments, bool>? firstFunction)
    {
        TicketComments? Ticketcomments = null;

        if (firstFunction != null)
        {
            Ticketcomments = _context.ticketcomments.First(firstFunction);

        }
        return Ticketcomments;
    }

        public ICollection<TicketComments>? GetList(Func<TicketComments, bool>? whereFunction)
    {
        List<TicketComments> Ticketcomments = null;
        if (whereFunction != null)
        {
            Ticketcomments = _context.ticketcomments.Where(whereFunction).ToList();
        }
        return Ticketcomments;
    }

    public void save()
    {
        _context.SaveChanges();

    }

    public void Update(TicketComments? entity)
    {
        if (entity != null) _context.ticketcomments.Update(entity);
    }
}