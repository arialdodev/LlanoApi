using LlanoApp.Api.Dto;
using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class ResourceTypesGetAllListQueryHandler : IRequestHandler<ResourceTypesGetAllListQuery, List<ResourceTypesDto>>
    {
        private readonly IRepository<ResourceTypes> _repository;
        public ResourceTypesGetAllListQueryHandler(IRepository<ResourceTypes> repository)
        {
            _repository = repository;
        }

        public async Task<List<ResourceTypesDto>> Handle(ResourceTypesGetAllListQuery request, CancellationToken cancellationToken)
        {
            var resourceTypes = await _repository.GetAll();
            var resourceTypesDto = new List<ResourceTypesDto>();

            foreach (var entidad in resourceTypes)
            {
                var temp = new ResourceTypesDto(entidad.Id, entidad.TypeName);
                resourceTypesDto.Add(temp); 
            }
            return resourceTypesDto;
        }
    }
}
