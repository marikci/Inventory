using Inventory.Model.Models;
using System.Collections.Generic;

namespace Inventory.Model.Interfaces
{
    public interface ISoftwareTypeOperations
    {
        IEnumerable<SoftwareType> GetSoftwareTypes();
    }
}
