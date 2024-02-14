using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace FiscoPortal.Models
{
    [Table("FiscalPrinter")]
    public class FiscalPrinter
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MinLength(8)]
        [MaxLength(8)]
        public string FiscalPrinterNumber { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Мanufacturer { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Model { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        public string Client { get; set; }

        [Required]
        public DateTime PurchaseDate { get; set; }

        [Required]
        public DateTime ContractDate { get; set; }

        [Required]
        public DateTime ReSignContractDate { get; set; }
    }
}
