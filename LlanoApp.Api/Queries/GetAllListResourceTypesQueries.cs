using LlanoApp.Domain.AggregateModel.Events;
using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using MediatR;
using System.Runtime.Serialization;

namespace LlanoApp.Api.Commands
{
    public class GetAllListResourceTypesQueries : IRequest<List<ResourceTypes>>
    {
    }
}
