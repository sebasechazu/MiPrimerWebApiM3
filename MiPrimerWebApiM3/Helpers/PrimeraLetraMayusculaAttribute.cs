using System.ComponentModel.DataAnnotations;

namespace MiPrimerWebApiM3.Helpers
{
    class PrimeraLetraMayusculaAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            return base.IsValid(value, validationContext);
        }

    }
}