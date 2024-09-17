using LlanoApp.Api.Commands;
using LlanoApp.Api.Dto;
using LlanoApp.Api.Queries;
using LlanoApp.Domain.Common;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LlanoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ResourceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ResourceCreateDto createResourceDto)
        {
            var command = new ResourceCreateCommand(createResourceDto);
            var result = await _mediator.Send(command);

            if (!result.IsSuccess)
            {
                switch (result.ErrorType)
                {
                    case ErrorType.Validation:
                        return StatusCode(400, result);

                    default:
                        return StatusCode(500, result);
                }
            }
            return StatusCode(200, result);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ResourceUpdateDto resourceUpdateDto)
        {
            var entity = new ResourceUpdateCommand(resourceUpdateDto);
            var result = await _mediator.Send(entity);
            return StatusCode(200, result);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllByResourceTypeId(int? resourceTypeId)
        {
            var query = new ResourcesGetAllListQuery(resourceTypeId);
            var listResources = await _mediator.Send(query);
            if (listResources.IsSuccess)
            {
                return Ok(listResources.Value);
            }
            return BadRequest(listResources.Error);
        }
    }
}
