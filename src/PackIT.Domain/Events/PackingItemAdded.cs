using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Domain;

namespace PackIT.Domain.Events
{
    internal record PackingItemAdded(PackingList PackingList, PackingItem PackingItem) : IDomainEvent;
}
