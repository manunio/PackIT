using PackIT.Shared.Abstractions.Exceptions;
using System.Runtime.Serialization;

namespace PackIT.Domain.Exceptions

{
    public class EmptyPackingListIdException : PackITException
    {
        public EmptyPackingListIdException() : base("Packing list Id cannot be empty.")
        {
        }
    }
}