using LlanoApp.Api.Dto;
using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class GetAllListResourceStatesQueryHandler : IRequestHandler<GetAllListResourceStatesQuery ,List<ResourceStatesDto>>
    {
        private readonly IRepository<ResourceStates> _repository;
        public GetAllListResourceStatesQueryHandler(IRepository<ResourceStates> repository)
        {
            _repository = repository ; 
        }
        public async Task<List<ResourceStatesDto>> Handle(GetAllListResourceStatesQuery request, CancellationToken cancellationToken)
        {
            var listResourceStates = await _repository.GetAll();
            var listResourcesStatesDto = new List<ResourceStatesDto>();
            foreach (var item in listResourceStates)
            {
                var resourcesStatesDto = new ResourceStatesDto(item.Id, item.State);
                listResourcesStatesDto.Add(resourcesStatesDto);
            }
            return listResourcesStatesDto;
        }
    }
}
