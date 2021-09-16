using Pathway.Domain.Common;
using System.Threading.Tasks;

namespace Pathway.Application.Common.Interfaces
{
    public interface IDomainEventService
    {
        Task Publish(DomainEvent domainEvent);
    }
}
