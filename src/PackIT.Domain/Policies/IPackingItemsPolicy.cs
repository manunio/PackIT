using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies
{
    public interface IPackingItemsPolicy
    {
        bool IsApplicable(PolicyData data);
        IEnumerable<PackingItem> GenerateItems(PolicyData data);
    }
}