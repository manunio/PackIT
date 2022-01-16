using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackIT.Shared.Abstractions.Commands
{
    public interface ICommandDispatcher
    {
        Task DispatchAsync<T>(T command) where T : class, ICommand;
    }
}