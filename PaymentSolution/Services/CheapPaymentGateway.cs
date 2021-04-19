using PaymentSolution.DTO;
using System;

namespace PaymentSolution.Services
{
    public class CheapPaymentGateway : ICheapPaymentGateway
    {
        public PaymentStatusInfo ProcessPayment(CardDTO cardDTO)
        {
            return PaymentStatusInfo.Processed;
        }
    }
}
