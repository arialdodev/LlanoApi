using LlanoApp.Api.Validations.Resource;
using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.Common;
using LlanoApp.Domain.SeedWork;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class ResourceCreateCommandHandler : IRequestHandler<ResourceCreateCommand, Result<bool>>
    {
        private readonly IRepositoryResource<Resource> _resource;
        private readonly ResourceCreateDtoValidator _validator;

        public ResourceCreateCommandHandler(
            IRepositoryResource<Resource> resource, 
            ResourceCreateDtoValidator validator
            )
        {
            _resource = resource;
            _validator = validator;
        }

        public async Task<Result<bool>> Handle(ResourceCreateCommand request, CancellationToken cancellationToken)
        {
            var requestValid = _validator.Validate(request.ResourceCreateDto);
            if (!requestValid.IsValid)
            {
                var errorValidation = requestValid.Errors.First().ErrorMessage;
                return Result<bool>.Failure(errorValidation, ErrorType.Validation);
            }

            var entity = new Resource(request.ResourceCreateDto.Name, request.ResourceCreateDto.Description, request.ResourceCreateDto.Image ,request.ResourceCreateDto.ResourceTypesId, 1);
            return await _resource.Create(entity);
        }
    }
}
