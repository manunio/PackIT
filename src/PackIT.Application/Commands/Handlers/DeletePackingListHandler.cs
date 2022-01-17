using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackIT.Application.Exceptions;
using PackIT.Domain.Repositories;
using PackIT.Shared.Abstractions.Commands;

namespace PackIT.Application.Commands.Handlers
{
    public class DeletePackingListHandler : ICommandHandler<DeletePackingList>
    {
        public readonly IPackingListRepository _repository;

        public DeletePackingListHandler(IPackingListRepository repository)
        {
            _repository = repository;
        }

        public async Task HandleAsync(DeletePackingList command)
        {
            var packingList = await _repository.GetAsync(command.Id);

            if (packingList is null)
            {
                throw new PackingListNotFoundException(command.Id);
            }

            await _repository.DeleteAsync(packingList);
        }
    }
}