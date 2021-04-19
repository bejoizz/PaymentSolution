using PaymentData.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PaymentSolution.Models
{
    public class Card : BaseEntity
    {  
        public string CreditCardNumber { get; set; }
        public string CardHolder { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string SecurityCode { get; set; } 
        public decimal Amount { get; set; }
        public virtual ICollection<PaymentState> PaymentStates {  get;  set;  }
    }
}
