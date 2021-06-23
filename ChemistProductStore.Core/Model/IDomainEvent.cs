using System;
using System.Collections.Generic;
using System.Text;

namespace ChemistProductStore.Core.Model
{
    public interface IDomainEvent<out TKey>
    {
        long AggregateVersion { get; }
        TKey AggregateId { get; }
        DateTime Timestamp { get; }
    }
}
