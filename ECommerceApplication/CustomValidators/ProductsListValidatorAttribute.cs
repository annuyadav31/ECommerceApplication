using ECommerceApplication.Models;
using System.ComponentModel.DataAnnotations;

namespace ECommerceApplication.CustomValidators
{
    public class ProductsListValidatorAttribute : ValidationAttribute
    {
        public string defaultErrorMessage = "{0} should have atlease one product";
        public ProductsListValidatorAttribute() { }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value != null)
            {
                List<Product> products = (List<Product>)value;

                if(products.Count ==0)
                {
                    return new ValidationResult(defaultErrorMessage, new string[] { nameof(validationContext.MemberName) });
                }

                return ValidationResult.Success;
            }
            return null;
        }
    }
}
