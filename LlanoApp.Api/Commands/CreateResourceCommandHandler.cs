using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class CreateResourceCommandHandler : IRequestHandler<CreateResourceCommand, bool>
    {
        private readonly IRepository<Resource> _resource;
        public CreateResourceCommandHandler(IRepository<Resource> resource)
        {
            _resource = resource;
        }

        public Task<bool> Handle(CreateResourceCommand request, CancellationToken cancellationToken)
        {
            var createResourceDto = request.CreateResourceDto;
            var entity = new Resource(request.CreateResourceDto.Name, request.CreateResourceDto.Description, request.CreateResourceDto.Image ,request.CreateResourceDto.ResourceTypesId, 1);
            return _resource.Create(entity);
        }
    }
}
