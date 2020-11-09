using Inventory.Model.Interfaces;
using Inventory.Model.Models;
using System.Web.Http;

namespace Inventory.Controllers
{
    public class StockController : ApiController
    {
        private readonly IStockOperations _stockOperations;
        public StockController(IStockOperations stockOperations)
        {
            _stockOperations = stockOperations;
        }

        public void Post([FromBody] Stock value)
        {
            _stockOperations.SaveStock(value);
        }
    }
}
