using AutoMapper;
using PaymentData;
using PaymentSolution.DTO;
using PaymentSolution.Models;

namespace PaymentSolution
{
    public class DataTransactions : IDataTransactions
    {
        private IRepository<Card> m_CardPaymentRepo;
        private IRepository<PaymentState> m_PaymentStateRepo;
        private readonly IMapper m_mapper;
        public DataTransactions(IRepository<Card> cardRepo, IRepository<PaymentState> paymentStateRepo,  IMapper mapper)
        {
            m_CardPaymentRepo = cardRepo;
            m_PaymentStateRepo = paymentStateRepo; 
            m_mapper =  mapper;
        }
        public void InsertCard(CardDTO cardDTO, PaymentStatusInfo paymentStatus)
        {
            var card = m_mapper.Map<Card>(cardDTO);
            m_CardPaymentRepo.Insert(card);
            m_PaymentStateRepo.Insert(new PaymentState { CardId = card.Id, PaymentStatus = (PaymentStatus)paymentStatus });
        }
 
    }
}
