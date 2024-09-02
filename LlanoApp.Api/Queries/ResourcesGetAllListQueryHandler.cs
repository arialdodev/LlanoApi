using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class ResourcesGetAllListQueryHandler : IRequestHandler<ResourcesGetAllListQuery, List<Resource>>
    {
        private readonly IRepository<Resource> _repository;
        public ResourcesGetAllListQueryHandler(IRepository<Resource> repository)
        {
            _repository = repository;
        }

        public Task<List<Resource>> Handle(ResourcesGetAllListQuery request, CancellationToken cancellationToken)
        {
            var resourcesList = _repository.GetAll();
            return resourcesList;
        }
    }
}
