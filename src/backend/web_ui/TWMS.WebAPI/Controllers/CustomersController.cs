using Microsoft.AspNetCore.Mvc;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Customer;
using System.Text.Json;
using TWMS.Infrastructure_Help.Post_Model.Customer;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TWMS.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;
        public CustomersController(ICustomerService customerService )
        {
            _customerService = customerService;
        }

        // Get all customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customers>>> GetAllCustomer()
        {
            var result = await _customerService.GetAllAsync(false);
            return Ok(result);
        }

        //Get by Id
        [HttpGet("{id}")]
        public async Task<ActionResult<Customers>> GetCustomerById(int id)
        {
            var customer = await _customerService.GetByIdAsync(false, id);
            if(customer is null)
            {
                return NotFound();
            }
            return Ok(customer);
        }

        //Add customer to DB
        [HttpPost]
        public ActionResult AddCustomer([FromBody] CustomerRecord record )
        {
            Customers customer = new()
            {
                FullName = record.fullName,
                Birthday = record.birthday,
                PhoneNo = record.phoneNo,
                EmailAddress = record.emailAddress,
                CustomerAddress =
                 new CustomerAddress()
                 {
                     BuildingNumber = record.buildingNumber,
                     StreetName = record.streetName,
                     AreaLocality = record.areaLocality,
                     Landmark = record.landmark,
                     City = record.city,
                     Zip_PostalCode = record.zipCode,
                     State_Province = record.stateProvince,

                 }
            };
            _customerService.Add(customer);
            return CreatedAtAction(nameof(GetCustomerById), new {id=customer.Id}, customer);//Ask ChatGPT for better explanation
        }
        //Deletes customer from DB
        [HttpDelete("{id}")]
        public void RemoveCustomer(int id)
        {
            _customerService.DeleteById(id);
        }

        // Update customer on DB
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Customers customer )
        {
            if(id!=customer.Id)
            {
                return BadRequest();
            }
            _customerService.Update(customer);
            return NoContent();
        }
        [HttpGet("count")]
        public Task<int> GetCustomerCount() 
        {
            var count = _customerService.GetTotalNumberOfCustomersAsync();
            return count;
        }
        /*[HttpGet("search")]
        public ActionResult Get(string searchTerm) 
        {
            return
        }*/

        
    }
}
