using NerdStore.Core.Messages;
using System;

namespace NerdStore.Core.DomainObjects
{
    public abstract class DomainEvent : Event
    {
        protected DomainEvent(Guid aggregateId)
        {
            AggregateId = aggregateId;
        }
    }
}