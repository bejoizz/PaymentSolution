

using PaymentSolution.DTO;
using PaymentSolution.Services;

namespace PaymentSolution.Logic
{
    public class ServiceLogic : IServiceLogic
    {

        private IPremiumPaymentService m_premiumPaymentService;
        private IExpensivePaymentGateway m_expensivePaymentGateway;
        private ICheapPaymentGateway m_cheapPaymentGateway;

        public ServiceLogic(IPremiumPaymentService premiumPaymentService,
            IExpensivePaymentGateway expensivePaymentGateway,ICheapPaymentGateway cheapPaymentGateway)
        {
            m_premiumPaymentService = premiumPaymentService;
            m_expensivePaymentGateway = expensivePaymentGateway;
            m_cheapPaymentGateway = cheapPaymentGateway;
        }

        public PaymentStatusInfo CallService(CardDTO cardDTO)
        {
            if (cardDTO.Amount <= 20)
            {
               return m_cheapPaymentGateway.ProcessPayment(cardDTO);
            }

            if (cardDTO.Amount > 20 && cardDTO.Amount < 500)
            {
                return InterMediatePayment(cardDTO);
            }
            return PremiumPayment(cardDTO);
        }

        private PaymentStatusInfo InterMediatePayment(CardDTO cardDTO)
        {
            try
            {
              return m_expensivePaymentGateway.ProcessPayment(cardDTO);
            }
            catch{
                return m_cheapPaymentGateway.ProcessPayment(cardDTO);

            }
        }

        private PaymentStatusInfo PremiumPayment(CardDTO cardDTO)
        {

            var attempts = 0;
            do
            {
                try
                {
                    attempts++;
                    return m_premiumPaymentService.ProcessPayment(cardDTO);
                    
                }
                catch  
                {
                    if (attempts > 3)
                        throw;
                    return m_premiumPaymentService.ProcessPayment(cardDTO);
                }
            } while (true); 
        }
    }
}

