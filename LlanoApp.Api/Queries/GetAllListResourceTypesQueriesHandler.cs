using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class GetAllListResourceTypesQueriesHandler : IRequestHandler<GetAllListResourceTypesQueries, List<ResourceTypes>>
    {
        private readonly IRepository<ResourceTypes> _repository;
        public GetAllListResourceTypesQueriesHandler(IRepository<ResourceTypes> repository)
        {
            _repository = repository;
        }

        public Task<List<ResourceTypes>> Handle(GetAllListResourceTypesQueries request, CancellationToken cancellationToken)
        {
            var listResourceTypes = _repository.GetAll();
            return listResourceTypes;
        }
    }
}
