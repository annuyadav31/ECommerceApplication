using System.ComponentModel.DataAnnotations;

namespace ECommerceApplication.CustomValidators
{
    public class MinimumDateValidatorAttribute : ValidationAttribute
    {

        public DateTime minimumDate { get; set; }
        public string defaultErrorMessage { get; set; } = "Order date should be greater than or equal to {0}";

        public MinimumDateValidatorAttribute(string minimumDateString)
        {
            minimumDate = Convert.ToDateTime(minimumDateString);
        }

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if(value != null)
            {
                DateTime orderDate = (DateTime)value;

                if(orderDate < minimumDate)
                {
                    return new ValidationResult(string.Format(ErrorMessage ?? defaultErrorMessage, minimumDate.ToString("yyyy-MM-dd")), new string[] { nameof(validationContext.MemberName) });
                }

                return ValidationResult.Success;
            }
            return null;
        }

    }
}
