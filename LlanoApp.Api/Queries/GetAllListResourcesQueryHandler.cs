using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class GetAllListResourcesQueryHandler : IRequestHandler<GetAllListResourcesQuery, List<Resource>>
    {
        private readonly IRepository<Resource> _repository;
        public GetAllListResourcesQueryHandler(IRepository<Resource> repository)
        {
            _repository = repository;
        }

        public Task<List<Resource>> Handle(GetAllListResourcesQuery request, CancellationToken cancellationToken)
        {
            var listResources = _repository.GetAll();
            return listResources;
        }
    }
}
