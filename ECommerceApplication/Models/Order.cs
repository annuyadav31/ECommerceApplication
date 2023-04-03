using System.ComponentModel.DataAnnotations;
using ECommerceApplication.CustomValidators;

namespace ECommerceApplication.Models
{
    public class Order
    {
        [Display(Name ="Order Number")]
        public int OrderNo { get; set; }

        [Required(ErrorMessage ="{0} cannot be null or empty")]
        [Display(Name ="Order Date")]
        [MinimumDateValidatorAttribute("2001-01-01",ErrorMessage= "{0} should be greater than or equal to 2000")] //custom Validator
        public DateTime OrderDate { get; set; }

        [Required(ErrorMessage = "{0} cannot be null or empty")]
        [Display(Name = "Order Invoice Price")]
        [InvoicePriceValidatorAttribute] //custom validator
        [Range(1, double.MaxValue, ErrorMessage = "{0} should be between a valid number")]
        public double InvoicePrice { get; set; }

        [ProductsListValidatorAttribute]//custom validator
        [Display(Name = "Product List")]
        public List<Product> Products { get; set; }

    }
}
