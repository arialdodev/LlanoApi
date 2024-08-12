using LlanoApp.Api.Dto;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class GetAllListResourceStatesQuery : IRequest<List<ResourceStatesDto>>
    {
    }
}
