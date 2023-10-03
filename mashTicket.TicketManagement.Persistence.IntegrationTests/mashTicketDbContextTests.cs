using mashTicket.TicketManagement.Application.Contracts;
using mashTicket.TicketManagement.Domain.Entities;
using mashTicket.TicketManagementPersistence;
using Microsoft.EntityFrameworkCore;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace mashTicket.TicketManagement.Persistence.IntegrationTests
{
    public class mashTicketDbContextTests
    {
        private readonly mashTicketDbContext _mashTicketDbContext;
        private readonly Mock<ILoggedInUserService> _loggedInUserServiceMock;
        private readonly string _loggedInUserId;

        public mashTicketDbContextTests()
        {
            var dbContextOptions = new DbContextOptionsBuilder<mashTicketDbContext>().UseInMemoryDatabase
                (Guid.NewGuid().ToString()).Options;

            _loggedInUserId = "00000000-0000-0000-0000-000000000000";
            _loggedInUserServiceMock = new Mock<ILoggedInUserService>();
            _loggedInUserServiceMock.Setup(m => m.UserId).Returns(_loggedInUserId);

            _mashTicketDbContext = new mashTicketDbContext(dbContextOptions, _loggedInUserServiceMock.Object);
        }

        [Fact]
        public async void Save_SetCreatedByProperty()
        {
            var ev = new Event() { EventId = Guid.NewGuid(), Name = "Test event" };

            _mashTicketDbContext.Events.Add(ev);
            await _mashTicketDbContext.SaveChangesAsync();

            ev.CreatedBy.ShouldBe(_loggedInUserId);
        }
    }
}
