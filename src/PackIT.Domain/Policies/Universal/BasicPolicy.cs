using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies.Universal
{
    internal sealed class BasicPolicy : IPackingItemsPolicy
    {
        private const uint MaximumQuantityOfClohtes = 7;

        public IEnumerable<PackingItem> GenerateItems(PolicyData data)
            => new List<PackingItem>
            {
                new("Pants", Math.Min(data.Days, MaximumQuantityOfClohtes)),
                new("Socks", Math.Min(data.Days, MaximumQuantityOfClohtes)),
                new("T-Shirt", Math.Min(data.Days, MaximumQuantityOfClohtes)),
                new("Trousers", data.Days < 7 ? 1u : 2u),
                new("Shampoo", 1),
                new("Toothbrush", 1),
                new("Toothpaste", 1),
                new("Towel", 1),
                new("Bag Pack", 1),
                new("Passport", 1),
                new("Phone Charger", 1)
            };

        public bool IsApplicable(PolicyData _)
            => true;
    }
}