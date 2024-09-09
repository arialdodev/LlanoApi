using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class ResourceUpdateCommandHandler : IRequestHandler<ResourceUpdateCommand, bool>
    {
        private readonly IRepository<Resource> _repository;

        public ResourceUpdateCommandHandler(IRepository<Resource> repository)
        {
            _repository = repository;
        }

        public async Task<bool> Handle(ResourceUpdateCommand request, CancellationToken cancellationToken)
        {
            var entityOld = await _repository.GetById(request.ResourceUpdateDto.Id);
            if (entityOld is not null)
            {
                entityOld.Update(request.ResourceUpdateDto.Description, request.ResourceUpdateDto.Name);
                _repository.Update(entityOld);
                return true;
            }
            return false;
        }
    }
}