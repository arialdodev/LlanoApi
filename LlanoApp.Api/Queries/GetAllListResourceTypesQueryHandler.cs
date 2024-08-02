using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class GetAllListResourceTypesQueryHandler : IRequestHandler<GetAllListResourceTypesQuery, List<ResourceTypes>>
    {
        private readonly IRepository<ResourceTypes> _repository;
        public GetAllListResourceTypesQueryHandler(IRepository<ResourceTypes> repository)
        {
            _repository = repository;
        }

        public Task<List<ResourceTypes>> Handle(GetAllListResourceTypesQuery request, CancellationToken cancellationToken)
        {
            var listResourceTypes = _repository.GetAll();
            return listResourceTypes;
        }
    }
}
