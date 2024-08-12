using LlanoApp.Api.Dto;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class CreateResourceCommand : IRequest<bool>
    {
        public CreateResourceDto CreateResourceDto { get; private set ; }

        public CreateResourceCommand(CreateResourceDto createResourceDto)
        {
            CreateResourceDto = createResourceDto;
        }
    }
}
