using BugTracker.Data;
using BugTracker.Models;

namespace BugTracker.DAL
{
    public class TicketTypesRepository : IGenricRepository<TicketTypes>
    {
        private readonly ApplicationDbContext _context;
        public void Create(TicketTypes? entity)
        {
            if(entity != null)_context.tickettypes.Add(entity);
        }

        public void Delete(int? id)
        {
            if(id is not null)_context.tickettypes.Remove(_context.tickettypes.First(i => Equals(i, id)));
        }

        public TicketTypes? Get(Func<TicketTypes, bool>? firstFunction)
        {
            TicketTypes? Tickettypes = null;

            if (firstFunction != null)
            {
                Tickettypes = _context.tickettypes.First(firstFunction);

            }
            return Tickettypes;
        }

        public ICollection<TicketTypes>? GetList(Func<TicketTypes, bool>? whereFunction)
        {
            List<TicketTypes> Tickettypes = null;
            if (whereFunction != null)
            {
                Tickettypes = _context.tickettypes.Where(whereFunction).ToList();
            }
            return Tickettypes;
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public void Update(TicketTypes? entity)
        {
            if(entity!= null)_context.tickettypes.Update(entity);  
        }
    }
}
