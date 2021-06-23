using System;
using System.Collections.Generic;
using System.Text;

namespace ChemistProductStore.Core.Model
{
    public interface IEntity<out TKey>
    {
        TKey Id { get; }
    }
}
