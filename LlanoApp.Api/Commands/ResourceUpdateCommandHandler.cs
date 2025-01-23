using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.Common;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class ResourceUpdateCommandHandler : IRequestHandler<ResourceUpdateCommand, Result<bool>>
    {
        private readonly IRepositoryResource<Resource> _repository;

        public ResourceUpdateCommandHandler(IRepositoryResource<Resource> repository)
        {
            _repository = repository;
        }

        public async Task<Result<bool>> Handle(ResourceUpdateCommand request, CancellationToken cancellationToken)
        {
            var entityOldResult = await _repository.GetById(request.ResourceUpdateDto.Id);

            if (!entityOldResult.IsSuccess || entityOldResult.Value is null)
            {
                return Result<bool>.Failure("No se encontró recurso.", ErrorType.NotFound);
            }

            var entityOld = entityOldResult.Value;

            entityOld.Update(request.ResourceUpdateDto.Description, request.ResourceUpdateDto.Name);

            var updateResult = await _repository.Update(entityOld);

            if (!updateResult.IsSuccess)
            {
                return Result<bool>.Failure("Error al actualizar el recurso", ErrorType.NotFound);
            }
            return Result<bool>.Success(true);
        }
    }
}