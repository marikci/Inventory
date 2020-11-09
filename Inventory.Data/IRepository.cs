using System.Collections.Generic;

namespace Inventory.Data
{
    public interface IRepository<T> where T:class
    {
        void Insert(T val);
        void Save();
    }
}
