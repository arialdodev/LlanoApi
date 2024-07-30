using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using MediatR;

namespace LlanoApp.Api.Commands
{
    public class GetAllListResourceTypesQuery : IRequest<List<ResourceTypes>>
    {
    }
}
