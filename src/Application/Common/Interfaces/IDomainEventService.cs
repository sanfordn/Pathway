using Pathway.Domain.Common;

namespace Pathway.Application.Common.Interfaces;

public interface IDomainEventService
{
    Task Publish(DomainEvent domainEvent);
}
