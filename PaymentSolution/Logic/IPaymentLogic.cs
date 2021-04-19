
using PaymentSolution.DTO;

namespace PaymentSolution.Logic
{
    public interface IPaymentLogic
    {
        void Execute(CardDTO cardDTO);
    }
}
