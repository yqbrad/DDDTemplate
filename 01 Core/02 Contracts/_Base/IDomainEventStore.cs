﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Framework.Domain.Events;

namespace DDD.Contracts._Base
{
    public interface IDomainEventStore
    {
        void Save<TEvent>(string aggregateName, string aggregateId, IEnumerable<TEvent> events)
            where TEvent : IEvent;

        Task SaveAsync<TEvent>(string aggregateName, string aggregateId, IEnumerable<TEvent> events)
            where TEvent : IEvent;
    }
}