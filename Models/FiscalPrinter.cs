using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FiscoPortal.Models
{
    public class FiscalPrinter
    {
        public int Id { get; set; }

        [Required]
        public string Category { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public DateTime ContractDate { get; set; }

        [Required]
        public DateTime ReSignContractDate { get; set; }
    }
}
