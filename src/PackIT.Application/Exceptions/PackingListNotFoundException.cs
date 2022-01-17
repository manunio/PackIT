using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Application.Exceptions
{
    public class PackingListNotFoundException : PackITException
    {
        public Guid Id { get; }

        public PackingListNotFoundException(Guid id) : base($"Packing List with Id '{id}' not found")
            => Id = id;

        protected PackingListNotFoundException(string message) : base(message)
        {
        }
    }
}