using LlanoApp.Api.Dto;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class GetAllListResourceTypesQuery : IRequest<List<ResourceTypesDto>>
    {
    }
}
