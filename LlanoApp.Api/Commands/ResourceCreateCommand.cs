using LlanoApp.Api.Dto;
using LlanoApp.Domain.Common;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class ResourceCreateCommand : IRequest<Result<bool>>
    {
        public ResourceCreateDto ResourceCreateDto { get; private set; }

        public ResourceCreateCommand(ResourceCreateDto resourceCreateDto)
        {
            ResourceCreateDto = resourceCreateDto;
        }
    }
}
