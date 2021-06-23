using System;
using System.Collections.Generic;
using System.Text;
using ChemistProductStore.Core.Model;

namespace ChemistProductStore.Core.EventBus
{
    public interface IEventConsumerFactory
    {
        IEventConsumer Build<TA, TKey>() where TA : IAggregateRoot<TKey>;
    }
}
