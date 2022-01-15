using PackIT.Domain.ValueObjects;
using PackIT.Shared.Abstractions.Domain;

namespace PackIT.Domain.Entities
{
    public record PackingItemRemoved(PackingList PackingList, PackingItem PackingItem) : IDomainEvent;
}