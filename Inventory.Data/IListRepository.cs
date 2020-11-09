using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public interface IListRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
    }
}
