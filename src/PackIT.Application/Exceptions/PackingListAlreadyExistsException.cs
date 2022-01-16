using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackIT.Shared.Abstractions.Exceptions;

namespace PackIT.Application.Exceptions
{
    public class PackingListAlreadyExistsException : PackITException
    {
        public string Name { get; }

        public PackingListAlreadyExistsException(string name) : base($"Packing List with name '{name}' already exists")
        {
            Name = name;
        }
    }
}