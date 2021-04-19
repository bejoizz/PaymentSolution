using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSolution.DTO
{
    public class CardDTO : IValidatableObject
    {
        [CreditCard]
        [Required] 
        public string CreditCardNumber { get; set; }
        [Required]
        public string CardHolder { get; set; }
        [Required]
        public DateTime ExpirationDate { get; set; }
        public string SecurityCode { get; set; }
        [Required] 
        public decimal Amount { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if (!string.IsNullOrEmpty(SecurityCode) && SecurityCode.Length !=3 )
            {
                yield return new ValidationResult("Invalid Security Code");
            }
            if (ExpirationDate < DateTime.Now)
            { 
                yield return new ValidationResult("Expiration Date cannot be in the past");

            }
        }
    }
}
