using LlanoApp.Api.Queries;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace LlanoApp.Api.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class ResourceStatesController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ResourceStatesController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllAsync()
        {
            try
            {
                var listResourceStatesQuery = new ResourceStatesGetAllListQuery();
                var commandResult = await _mediator.Send(listResourceStatesQuery);
                return StatusCode(200, commandResult);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
            
        }
    }
}
