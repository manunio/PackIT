using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PackIT.Shared.Abstractions.Commands
{
    public interface ICommandHandler<in T> where T : class, ICommand
    {
        Task HandleAsync(T command);
    }
}