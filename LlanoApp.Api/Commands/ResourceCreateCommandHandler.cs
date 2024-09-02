using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class ResourceCreateCommandHandler : IRequestHandler<ResourceCreateCommand, bool>
    {
        private readonly IRepository<Resource> _resource;
        public ResourceCreateCommandHandler(IRepository<Resource> resource)
        {
            _resource = resource;
        }

        public Task<bool> Handle(ResourceCreateCommand request, CancellationToken cancellationToken)
        {
            var createResourceDto = request.ResourceCreateDto;
            var entity = new Resource(request.ResourceCreateDto.Name, request.ResourceCreateDto.Description, request.ResourceCreateDto.Image ,request.ResourceCreateDto.ResourceTypesId, 1);
            return _resource.Create(entity);
        }
    }
}
