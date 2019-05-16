using System.Web.Http;
using TechnicalAsignment.Domain.DTO;
using TechnicalAsignment.Domain.Requests;
using TechnicalAsignment.Services;

namespace TechnicalAsignment.Controllers
{
    [RoutePrefix("api/Customers")]
    public class CustomersController : ApiController
    {
        private readonly CustomersService _customersService;

        public CustomersController()
        {
            _customersService = new CustomersService();
        }

        public IHttpActionResult Get()
        {          
            var customers = _customersService.GetAllCustomers();
            return Ok(customers);
        }

        [Route("by-inquiry")]
        public IHttpActionResult GetByInquiry([FromUri]InquiryCriteriaRequest inquiry)
        {
            if (inquiry == null)
            {
                ModelState.AddModelError("Inquiry", "No inquiry criteria");
                return BadRequest(ModelState);
            }                        
            
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            CustomerDTO customer;
            if (inquiry.CustomerId.HasValue)
                customer = _customersService.GetCustomerById(inquiry.CustomerId.Value);
            else
                customer = _customersService.GetCustomerByEmail(inquiry.Email);

            if (customer == null)
                return NotFound();
            else
                return Ok(customer);
        }
    }
}
