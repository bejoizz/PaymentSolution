using PaymentSolution.DTO; 
namespace PaymentSolution.Services
{
    public interface IPaymentGateway
    {
        PaymentStatusInfo ProcessPayment(CardDTO  cardDTO);
    }
}
