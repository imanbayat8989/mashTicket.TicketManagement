using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashTicket.TicketManagement.Application.Features.Events
{
    public class GetEventDetailQuary: IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}
