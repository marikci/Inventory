using Inventory.Data;
using Inventory.Model.Interfaces;
using Inventory.Model.Models;

namespace Inventory.Business
{
    public class StockOperations : IStockOperations
    {
        private readonly IRepository<Stock> _repository;
        public StockOperations()
        {
            _repository = new Repository<Stock>();
        }
        public void SaveStock(Stock stock)
        {
            _repository.Insert(stock);
            _repository.Save();
        }
    }
}
