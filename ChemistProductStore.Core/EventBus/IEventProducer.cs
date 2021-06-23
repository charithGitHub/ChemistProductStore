using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ChemistProductStore.Core.Model;

namespace ChemistProductStore.Core.EventBus
{
    public interface IEventProducer<in TA, in TKey>
        where TA : IAggregateRoot<TKey>
    {
        Task DispatchAsync(TA aggregateRoot);
    }
}
