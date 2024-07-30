using LlanoApp.Api.Commands;
using LlanoApp.Api.Dto;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LlanoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ResourceController(IMediator mediator )
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<bool> Create([FromBody] CreateResourceDto createResourceDto) 
        {
            try
            {
                var command = new CreateResourceCommand(createResourceDto);
                var result = await _mediator.Send(command);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
