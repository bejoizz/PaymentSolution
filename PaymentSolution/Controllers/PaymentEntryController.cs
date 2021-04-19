using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PaymentSolution.DTO;
using PaymentSolution.Logic;
using PaymentSolution.Models; 

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PaymentSolution.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PaymentEntryController : ControllerBase
    { 
        private IPaymentLogic m_paymentLogic;
        public PaymentEntryController(IPaymentLogic paymentLogic)
        {
            m_paymentLogic = paymentLogic; 
        }


        [HttpGet]
        public string Get()
        { 
            return "Only Post is Avilable";
        }


        [HttpPost]
        public IActionResult Post([FromBody] CardDTO cardDTO)
        {
            try
            {

                if (!ModelState.IsValid)
                    return BadRequest();

                m_paymentLogic.Execute(cardDTO);
                return Ok();
            }
            catch (System.Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        } 
    }
}
