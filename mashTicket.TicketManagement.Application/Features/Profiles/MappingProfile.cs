using AutoMapper;
using mashTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using mashTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using mashTicket.TicketManagement.Application.Features.Events.Commands.CreateEvent;
using mashTicket.TicketManagement.Application.Features.Events.Commands.DeleteEvent;
using mashTicket.TicketManagement.Application.Features.Events.Commands.UpdateEvent;
using mashTicket.TicketManagement.Application.Features.Events.Queries.GetEventDetail;
using mashTicket.TicketManagement.Application.Features.Events.Queries.GetEventsList;
using mashTicket.TicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mashTicket.TicketManagement.Application.Features.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();

            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, DeleteEventCommand>().ReverseMap();
        }
    }
}
