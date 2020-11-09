using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Inventory.Data
{
    public sealed class Repository<T> : IRepository<T>, IListRepository<T> where T : class
    {
        private InventoryContext _db;
        private readonly DbSet<T> _dbSet;
        public Repository()
        {
            _db = new InventoryContext();
            _dbSet = _db.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public void Insert(T val)
        {
            _dbSet.Add(val);
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        private void Dispose(bool disposing)
        {
            if (!disposing || _db == null) return;
            _db.Dispose();
            _db = null;
        }
        
    }
}
