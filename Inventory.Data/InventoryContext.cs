using Inventory.Model.Models;
using System.Data.Entity;

namespace Inventory.Data
{
    public sealed class InventoryContext: DbContext
    {
        public InventoryContext() : base("InventoryContext")
        {
            Database.SetInitializer<InventoryContext>(new InventoryInitializer<InventoryContext>());
        }

        public DbSet<Stock> Stocks { get; set; }
        public DbSet<SoftwareCompany> SoftwareCompanies { get; set; }
        public DbSet<SoftwareType> SoftwareTypes { get; set; }

    }
}
