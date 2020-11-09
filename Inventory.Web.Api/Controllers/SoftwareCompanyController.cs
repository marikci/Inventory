using Inventory.Model.Interfaces;
using Inventory.Model.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Inventory.Controllers
{
    public class SoftwareCompanyController : ApiController
    {
        private readonly ISoftwareCompanyOperations _softwareCompanyOperations;
        public SoftwareCompanyController(ISoftwareCompanyOperations softwareCompanyOperations)
        {
            _softwareCompanyOperations = softwareCompanyOperations;
        }

        public IEnumerable<SoftwareCompany> Get()
        {
            return _softwareCompanyOperations.GetSoftwareCompanies();
        }
    }
}
