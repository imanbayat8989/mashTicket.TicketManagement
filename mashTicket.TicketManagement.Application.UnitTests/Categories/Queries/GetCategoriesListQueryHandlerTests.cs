using AutoMapper;
using mashTicket.TicketManagement.Application.Contracts.Persistence;
using mashTicket.TicketManagement.Application.Features.Categories.Queries.GetCategoriesList;
using mashTicket.TicketManagement.Application.Features.Profiles;
using mashTicket.TicketManagement.Application.UnitTests.Mocks;
using mashTicket.TicketManagement.Domain.Entities;
using Moq;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace mashTicket.TicketManagement.Application.UnitTests.Categories.Queries
{
    public class GetCategoriesListQueryHandlerTests
    {
        private readonly IMapper _mapper;
        private readonly Mock<IAsyncRepository<Category>> _mockCategoryRepository;

        public GetCategoriesListQueryHandlerTests()
        {
            _mockCategoryRepository = RepositoriesMocks.GetCategoryRepository();
            var configurationProvider = new MapperConfiguration(ctg =>
            {
                ctg.AddProfile<MappingProfile>();
            });

            _mapper = configurationProvider.CreateMapper();
        }

        [Fact]
        public async Task GetCategoriesListTests()
        {
            var handler = new GetCategoriesListQueryHandler(_mapper, _mockCategoryRepository.Object);

            var result = await handler.Handle(new GetCategoriesListQuery(), CancellationToken.None);

            result.ShouldBeOfType<List<CategoryListVm>>();

            result.Count.ShouldBe(4);
        }
    }
}
