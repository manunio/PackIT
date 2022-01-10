using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Entities
{
    internal class PackingList
    {
        public Guid Id { get; private set; }

        private PackingListName _name;
        private Localization _localization;

        public PackingList(Guid id, PackingListName name, Localization localization)
        {
            Id = id;
            _name = name;
            _localization = localization;
        }



    }
}
