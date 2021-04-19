
using PaymentSolution.DTO;

namespace PaymentSolution
{
    public interface IDataTransactions
    {
        void InsertCard(CardDTO cardDTO, PaymentStatusInfo paymentStatus);
    }
}
