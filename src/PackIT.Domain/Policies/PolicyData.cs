using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PackIT.Domain.Consts;
using PackIT.Domain.ValueObjects;

namespace PackIT.Domain.Policies
{
    public record PolicyData(
        TravelDays Days,
        Consts.Gender Gender,
        ValueObjects.Temperature Temperature,
        Localization Localization);
}