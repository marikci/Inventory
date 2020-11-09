using Inventory.Data;
using Inventory.Model.Interfaces;
using Inventory.Model.Models;
using System.Collections.Generic;

namespace Inventory.Business
{
    public class SoftwareTypeOperations: ISoftwareTypeOperations
    {
        private readonly IListRepository<SoftwareType> _repository;
        public SoftwareTypeOperations()
        {
            _repository = new Repository<SoftwareType>();
        }
        public IEnumerable<SoftwareType> GetSoftwareTypes()
        {
            return _repository.GetAll();
        }
    }
}
