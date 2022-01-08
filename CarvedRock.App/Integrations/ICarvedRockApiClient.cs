using CarvedRock.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarvedRock.App.Integrations
{
    public interface ICarvedRockApiClient
    {
        Task<List<Product>> GetProducts(string category = null);
        Task<Guid> PlaceQuickOrder(QuickOrder order);
    }
}
