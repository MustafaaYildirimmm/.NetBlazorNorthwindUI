
using System.ComponentModel.DataAnnotations;

namespace BlazorNorthwindUI.Models
{
    public class ProductListVM
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public string QuantityPerUnit { get; set; }
        [Required]
        public decimal UnitPrice { get; set; }
        [Range(0,10)]
        public short UnitsInStock { get; set; }

    }
}
