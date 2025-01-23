using MediatR;
using LlanoApp.Api.Dto;
using LlanoApp.Domain.Common;

namespace LlanoApp.Api.Commands
{
    public class ResourceUpdateCommand : IRequest<Result<bool>>
    {
        public ResourceUpdateDto ResourceUpdateDto { get; set; }

        public ResourceUpdateCommand(ResourceUpdateDto resourceUpdateDto)
        {
            ResourceUpdateDto = resourceUpdateDto;
        }
    }
}
