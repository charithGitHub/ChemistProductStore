using System.Threading.Tasks;
using ChemistProductStore.Core.Model;

namespace ChemistProductStore.Core
{
    public interface IEventsService<TA, TKey>
        where TA : class, IAggregateRoot<TKey>
    {
        Task PersistAsync(TA aggregateRoot);
        Task<TA> RehydrateAsync(TKey key);
    }
}
