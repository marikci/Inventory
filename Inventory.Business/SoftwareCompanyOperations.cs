using Inventory.Data;
using Inventory.Model.Interfaces;
using Inventory.Model.Models;
using System.Collections.Generic;

namespace Inventory.Business
{
    public class SoftwareCompanyOperations: ISoftwareCompanyOperations
    {
        private readonly IListRepository<SoftwareCompany> _repository;
        public SoftwareCompanyOperations()
        {
            _repository = new Repository<SoftwareCompany>();
        }
        public IEnumerable<SoftwareCompany> GetSoftwareCompanies()
        {
            return _repository.GetAll();
        }
    }
}
