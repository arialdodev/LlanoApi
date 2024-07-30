using LlanoApp.Api.Commands;
using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LlanoApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourcesTypesController : ControllerBase
    {

        private readonly IMediator _mediator;
        public ResourcesTypesController(IMediator mediator)
        {
            _mediator = mediator;
        }


        [HttpGet]
        public async Task<List<ResourceTypes>> GetAllAsync()
        {
            var commandResult = await _mediator.Send(new GetAllListResourceTypesQuery());
            return commandResult;
        }

       
    }
}
