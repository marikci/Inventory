using Inventory.Model.Models;

namespace Inventory.Model.Interfaces
{
    public interface IStockOperations
    {
        void SaveStock(Stock stock);
    }
}
