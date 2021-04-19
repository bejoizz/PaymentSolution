using PaymentSolution.DTO; 

namespace PaymentSolution.Services
{
    public class PremiumPaymentService : IPremiumPaymentService
    {
        public PaymentStatusInfo ProcessPayment(CardDTO cardDTO)
        {
            return PaymentStatusInfo.Processed;
        }
    }
}
