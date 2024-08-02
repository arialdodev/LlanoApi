using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class GetAllListResourcesQuery : IRequest<List<Resource>>
    {
    }
}
