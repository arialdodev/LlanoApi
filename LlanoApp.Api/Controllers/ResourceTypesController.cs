using LlanoApp.Api.Dto;
using LlanoApp.Api.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LlanoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceTypesController : ControllerBase
    {

        private readonly IMediator _mediator;
        public ResourceTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<List<ResourceTypesDto>> GetAll()
        {
            var query = new GetAllListResourceTypesQuery();
            var result = await _mediator.Send(query);
            return result;

        }
    }
}
