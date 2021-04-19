using PaymentData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PaymentSolution.Models
{
    public enum PaymentStatus
    { 
        Pending, 
        Processed,
        Failed
    }
    public class PaymentState:BaseEntity
    { 
        public long CardId { get; set; } 
        public PaymentStatus PaymentStatus { get; set; }
        public virtual Card Card { get; set; }


    }
}
