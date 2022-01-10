using PackIT.Domain.Entities;
using PackIT.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackIT.Domain.Factories
{
    internal interface IPackingListFactory
    {
        PackingList Create(PackingListId id, PackingListName name, Localization localization);
        PackingList CreateWithDefaultItems(PackingListId id, PackingListName name);
    }
}
