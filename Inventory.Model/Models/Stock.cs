using System.ComponentModel.DataAnnotations;

namespace Inventory.Model.Models
{
    public class Stock
    {
        public int Id { get; set; }
        [Required]
        public int Piece { get; set; }
        [Required]
        public double Fee { get; set; }
        [Required]
        public string SoftwareName { get; set; }
        [Required]
        public int SoftwareCompanyId { get; set; }
        [Required]
        public int SoftwareTypeId { get; set; }
        public virtual SoftwareCompany SoftwareCompany { get; set; }
        public virtual SoftwareType SoftwareType { get; set; }
    }
}
