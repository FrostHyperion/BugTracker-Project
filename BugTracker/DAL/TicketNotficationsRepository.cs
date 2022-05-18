using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.DAL;
public class TicketNotificationsRepository : IGenricRepository<TicketNotifications>
{
    private readonly ApplicationDbContext _context;

   
    public void Create(TicketNotifications? entity)
    {
       if(entity != null) _context.ticketnotifications.Add(entity);
    }

    public void Delete(int? id)
    {
        if (id != null) _context.ticketnotifications.Remove(_context.ticketnotifications.First(i => Equals(i, id)));
    }

    public TicketNotifications? Get(Func<TicketNotifications, bool>? firstFunction)
    {
        TicketNotifications? Ticketnotifications = null;

        if (firstFunction != null)
        {
            Ticketnotifications = _context.ticketnotifications.First(firstFunction);

        }
        return Ticketnotifications;
    }

    public ICollection<TicketNotifications>? GetList(Func<TicketNotifications, bool>? whereFunction)
    {
        List<TicketNotifications> Ticketnotifications = null;
        if (whereFunction != null)
        {
            Ticketnotifications = _context.ticketnotifications.Where(whereFunction).ToList();
        }
        return Ticketnotifications;
    }

    public void save()
    {
        _context.SaveChanges();
    }

    public void Update(TicketNotifications? entity)
    {
        if(entity!=null)_context.ticketnotifications.Update(entity);
    }
}