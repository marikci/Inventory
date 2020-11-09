using Inventory.Model.Models;
using System.Collections.Generic;
using System.Data.Entity;

namespace Inventory.Data
{
    public class InventoryInitializer<T>:CreateDatabaseIfNotExists<InventoryContext>
    {
        protected override void Seed(InventoryContext context)
        {
            var softwareCompanies = new List<SoftwareCompany>
            {
                new SoftwareCompany() {Id = 1, Text = "Microsoft"},
                new SoftwareCompany() {Id = 2, Text = "Oracle"},
                new SoftwareCompany() {Id = 3, Text = "Atlassian"}
            };
            context.SoftwareCompanies.AddRange(softwareCompanies);

            var softwareTypes = new List<SoftwareType>
            {
                new SoftwareType() {Id = 1, Text = "Yıllık üyelik"},
                new SoftwareType() {Id = 2, Text = "Aylık üyelik"},
                new SoftwareType() {Id = 3, Text = "On Prem"}
            };
            context.SoftwareTypes.AddRange(softwareTypes);

            base.Seed(context);
        }
    }
}
