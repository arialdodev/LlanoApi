using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.Common;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class ResourceCreateCommandHandler : IRequestHandler<ResourceCreateCommand, Result<bool>>
    {
        private readonly IRepositoryResource<Resource> _resource;
        public ResourceCreateCommandHandler(IRepositoryResource<Resource> resource)
        {
            _resource = resource;
        }

        public Task<Result<bool>> Handle(ResourceCreateCommand request, CancellationToken cancellationToken)
        {
            var requestValid = request.Validate();
            if (!requestValid.IsSuccess)
            {
                return Task.FromResult(requestValid);
            }

            var entity = new Resource(request.ResourceCreateDto.Name, request.ResourceCreateDto.Description, request.ResourceCreateDto.Image ,request.ResourceCreateDto.ResourceTypesId, 1);
            return _resource.Create(entity);
        }
    }
}
