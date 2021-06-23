using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ChemistProductStore.Core.Model;

namespace ChemistProductStore.Core
{
    public interface IEventsRepository<TA, TKey>
       where TA : class, IAggregateRoot<TKey>
    {
        Task AppendAsync(TA aggregateRoot);
        Task<TA> RehydrateAsync(TKey key);
    }
}
