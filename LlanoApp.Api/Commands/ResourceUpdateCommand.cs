using MediatR;
using LlanoApp.Api.Dto;

namespace LlanoApp.Api.Commands
{
    public class ResourceUpdateCommand : IRequest<bool>
    {
        public ResourceUpdateDto ResourceUpdateDto { get; set; }

        public ResourceUpdateCommand(ResourceUpdateDto resourceUpdateDto)
        {
            ResourceUpdateDto = resourceUpdateDto;
        }
    }
}
