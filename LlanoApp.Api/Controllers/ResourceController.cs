using LlanoApp.Api.Commands;
using LlanoApp.Api.Dto;
using LlanoApp.Api.Queries;
using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Create([FromBody] ResourceCreateDto createResourceDto)
        {
            try
            {
                var command = new CreateResourceCommand(createResourceDto);
                var result = await _mediator.Send(command);
                return StatusCode(200, result);
            }
            catch (ArgumentException ex)
            {
                return StatusCode(400, new { Message = ex.Message });
            }
            catch(Exception ex)
            {
                return StatusCode(500, new { Message = ex.Message });
            }
        }

        [HttpGet]
        public Task<List<Resource>> GetAll()
        {
            var listResources = _mediator.Send(new GetAllListResourcesQuery());
            return listResources;
        }
    }
}
