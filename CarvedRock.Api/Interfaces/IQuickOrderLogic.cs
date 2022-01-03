using CarvedRock.Api.ApiModels;
using System;

namespace CarvedRock.Api.Interfaces
{
    public interface IQuickOrderLogic
    {
        Guid PlaceQuickOrder(QuickOrder order, int customerId);
    }
}
