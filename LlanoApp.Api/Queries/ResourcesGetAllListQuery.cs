using LlanoApp.Domain.AggregateModel.ResourceAggregate;
using LlanoApp.Domain.Common;
using MediatR;

namespace LlanoApp.Api.Queries
{
    public class ResourcesGetAllListQuery : IRequest<Result<List<Resource>>>
    {
        public int? ResourceTypeId { get; private set; }

        public ResourcesGetAllListQuery(int? resourceTypeId)
        {
            ResourceTypeId = resourceTypeId;
        }
    }
}
