using LlanoApp.Api.Dto;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class ResourceStatesGetAllListQuery : IRequest<List<ResourceStatesDto>>
    {
    }
}
