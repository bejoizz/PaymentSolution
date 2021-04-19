using PaymentSolution.DTO;
using PaymentSolution.Models; 

namespace PaymentSolution.Utility
{
    public class ApplicationProfile :AutoMapper.Profile
    {
        public ApplicationProfile()
        {
            CreateMap<Card, CardDTO>().ReverseMap();
        }
    }
}
