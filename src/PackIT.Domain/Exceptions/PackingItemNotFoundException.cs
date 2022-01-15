using PackIT.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace PackIT.Domain.Entities
{
    public class PackingItemNotFoundException : PackITException
    {
        public PackingItemNotFoundException(string itemName) 
            : base($"Packing item 'itemName' was not found.")
          => ItemName = itemName;
        public string ItemName { get; }
    }
}