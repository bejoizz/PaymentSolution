using PaymentSolution.DTO; 

namespace PaymentSolution.Logic
{
    public class PaymentLogic : IPaymentLogic
    {
        private IServiceLogic m_serviceLogic;
        private IDataTransactions m_dataTransactions;
        public PaymentLogic(IServiceLogic serviceLogic, IDataTransactions dataTransactions)
        {
            m_serviceLogic = serviceLogic;
            m_dataTransactions = dataTransactions;
        }
        public void Execute(CardDTO cardDTO)
        {
            var status =  m_serviceLogic.CallService(cardDTO);
            try
            {
                m_dataTransactions.InsertCard(cardDTO, status);
            }
            catch
            {
                throw new System.Exception($"Payment : {status.GetEnumDescription()}, Internal error Occured");
            }
        }
        
    }
}
