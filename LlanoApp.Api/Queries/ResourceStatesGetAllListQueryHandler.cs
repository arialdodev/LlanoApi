using LlanoApp.Api.Dto;
using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class GetAllListResourceStatesQueryHandler : IRequestHandler<ResourceStatesGetAllListQuery, List<ResourceStatesDto>>
    {
        private readonly IRepository<ResourceStates> _repository;
        public GetAllListResourceStatesQueryHandler(IRepository<ResourceStates> repository)
        {
            _repository = repository ; 
        }
        public async Task<List<ResourceStatesDto>> Handle(ResourceStatesGetAllListQuery request, CancellationToken cancellationToken)
        {
            var resourceStatesList = await _repository.GetAll();
            var resourcesStatesListDto = new List<ResourceStatesDto>();
            foreach (var item in resourceStatesList)
            {
                var resourcesStatesDto = new ResourceStatesDto(item.Id, item.NameState);
                resourcesStatesListDto.Add(resourcesStatesDto);
            }
            return resourcesStatesListDto;
        }
    }
}
