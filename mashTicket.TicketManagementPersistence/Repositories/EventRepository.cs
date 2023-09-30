using mashTicket.TicketManagement.Application.Contracts.Persistence;
using mashTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashTicket.TicketManagementPersistence.Repositories
{
    public class EventRepository: BaseRepository<Event>, IEventRepository
    {
        public EventRepository(mashTicketDbContext dbContext): base(dbContext) 
        { 
        }

        public Task<bool> IsEventNameAndDateUnique(string name, DateTime eventdate)
        {
            var matches = _dbContext.Events.Any(e => e.Name.Equals(name) 
            && e.Date.Date.Equals(eventdate.Date));

            return Task.FromResult(matches);
        }
    }
}
