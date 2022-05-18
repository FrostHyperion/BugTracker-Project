using BugTracker.Data;
using BugTracker.Models;


namespace BugTracker.DAL;

    public class TicketAttachmentsRepository: IGenricRepository<TicketAttachments>
    {
        private readonly ApplicationDbContext _context; //

        public void Create(TicketAttachments? entity)
        {
        if (entity != null) _context.Ticketattachments.Add(entity);
            
        }

        public void Delete(int? id)
        {
        if (id is not null)
        {
            _context.Ticketattachments.Remove(_context.Ticketattachments.First(i => Equals(i, id)));
        }
    }

        public TicketAttachments? Get(Func<TicketAttachments, bool>? firstFunction)
        {
        TicketAttachments? ticketAttachments = null;
        if (firstFunction != null)
        {
           ticketAttachments = _context.Ticketattachments.First(firstFunction);

        }
        return ticketAttachments;
    }


        public ICollection<TicketAttachments>? GetList(Func<TicketAttachments, bool>? whereFunction)
        {
        List<TicketAttachments>? ticketAttachments = null;
        if (whereFunction != null)
        {
            ticketAttachments = _context.Ticketattachments.Where(whereFunction).ToList();
        }
        return ticketAttachments;
    }

        public void Save()
        {
                 _context.SaveChanges();

    }

    public void Update(TicketAttachments? entity)
        {
        if (entity != null) _context.Ticketattachments.Update(entity);

    }
}
