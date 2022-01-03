using CarvedRock.Api.ApiModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarvedRock.Api.Interfaces;
using Serilog;

namespace CarvedRock.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IProductLogic _productLogic;

        // The constructor. Takes the definition of the IProductLogic interface. This interface instance passed into
        // the constructor is used to call the method defined in the interface, GetProductsForCategory.
        public ProductsController(IProductLogic productLogic)
        {
            _productLogic = productLogic;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts(string category = "all")
        {
            Log.ForContext("Category", category)
                .Information("Starting controller action GetProducts");

            return _productLogic.GetProductsForCategory(category);
        }
    }
}
