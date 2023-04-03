using System.ComponentModel.DataAnnotations;

namespace ECommerceApplication.Models
{
    public class Product
    {
        [Required(ErrorMessage ="{0} cannot be null or empty")]
        [Display(Name = "Product Code")]
        [Range(1,int.MaxValue,ErrorMessage ="Please enter a valid number for {0}")]
        public int ProductCode { get; set; }

        [Required(ErrorMessage = "{0} cannot be null or empty")]
        [Display(Name = "Product Price")]
        [Range(1, double.MaxValue, ErrorMessage = "Please enter a valid number for {0}")]
        public double Price { get; set; }

        [Required(ErrorMessage = "{0} cannot be null or empty")]
        [Display(Name = "Product Quantity")]
        [Range(1, int.MaxValue, ErrorMessage = "Please enter a valid number for {0}")]
        public int Quantity { get; set; }
    }
}
