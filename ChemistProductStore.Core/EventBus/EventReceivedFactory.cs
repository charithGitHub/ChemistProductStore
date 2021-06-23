using System;
using System.Collections.Generic;
using System.Text;

namespace ChemistProductStore.Core.EventBus
{
    public static class EventReceivedFactory
    {
        public static EventReceived<TE> Create<TE>(TE @event)
        {
            return new EventReceived<TE>(@event);
        }
    }
}
