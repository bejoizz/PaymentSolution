using PaymentSolution.DTO; 

namespace PaymentSolution.Logic
{
    public interface IServiceLogic
    {
        PaymentStatusInfo CallService(CardDTO cardDTO);
    }
}
