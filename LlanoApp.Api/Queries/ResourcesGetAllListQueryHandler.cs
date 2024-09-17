using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.Common;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class ResourcesGetAllListQueryHandler : IRequestHandler<ResourcesGetAllListQuery, Result<List<Resource>>>
    {
        private readonly IRepositoryResource<Resource> _repository;
        public ResourcesGetAllListQueryHandler(IRepositoryResource<Resource> repository)
        {
            _repository = repository;
        }

        public Task<Result<List<Resource>>> Handle(ResourcesGetAllListQuery request, CancellationToken cancellationToken)
        {
            var resourcesList  = _repository.GetAllByResourceTypeId(request.ResourceTypeId);
            return resourcesList;
        }
    }
}
