using Inventory.Model.Interfaces;
using Inventory.Model.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace Inventory.Controllers
{
    public class SoftwareTypeController : ApiController
    {
        private readonly ISoftwareTypeOperations _softwareTypeOperations;
        public SoftwareTypeController(ISoftwareTypeOperations softwareTypeOperations)
        {
            _softwareTypeOperations = softwareTypeOperations;
        }

        public IEnumerable<SoftwareType> Get()
        {
            return _softwareTypeOperations.GetSoftwareTypes();
        }
    }
}
