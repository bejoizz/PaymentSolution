using PaymentSolution.DTO; 

namespace PaymentSolution.Services
{
    public class ExpensivePaymentGateway : IExpensivePaymentGateway
    {
        public PaymentStatusInfo ProcessPayment(CardDTO cardDTO)
        {
            return PaymentStatusInfo.Processed;
        }
    }
}
