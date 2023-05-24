using Microsoft.AspNetCore.Mvc;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Customer;
using TWMS.Infrastructure.Services;
using TWMS.Infrastructure.ServiceContracts;
using TWMS.Infrastructure.Exceptions;
using TWMS.DTOs.OutputDTOs;
using TWMS.DTOs.InputDTOs;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TWMS.Presentation.Controllers
{
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CustomersController(IServiceManager serviceManager )
        {
            _serviceManager = serviceManager;
        }

        // Get all customers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerToRetrieve>>> GetAllCustomer()
        {
            var result = await _serviceManager.CustomerService.GetAllCustomers();
            return Ok(result);
        }

        //Get by Id
        [HttpGet("{id:Guid}")]
        public async Task<ActionResult<CustomerToRetrieve>> GetCustomerById(Guid id)
        {
            var customer = await _serviceManager.CustomerService.GetCustomerByIdAsync(id);
            return Ok(customer);
        }

        //Count customers
        [HttpGet("count")]
        public async Task<ActionResult> GetCustomerCount()
        {
            var count =await _serviceManager.CustomerService.GetCustomerCount();
            return Ok(count);
        }

        //Add customer to DB
        [HttpPost]
        public ActionResult AddCustomer([FromBody] CustomerToSave customer)
        {
            if(customer is null || customer.EmailAddress is null||customer.FullName is null)
            {
               return BadRequest("Customer object is not in the correct format");
            }
           var createdCustomer = _serviceManager.CustomerService.AddCustomer(customer);
            return CreatedAtAction(nameof(GetCustomerById), new { id = createdCustomer.Id }, createdCustomer);//Ask ChatGPT for better explanation
        }

        // Update customer on DB//needs more work on my customer model, remove id from auditableBase,  
        //use the oppurtunity to complete all model validation
        [HttpPut("{id:Guid}")]
        public async Task<ActionResult> Put(Guid id,[FromBody] CustomerToSave customer)
        {
            if (customer is null|| customer.EmailAddress is null || customer.FullName is null)
            {
                return BadRequest("Customer is invalid");
            }
             await _serviceManager.CustomerService.UpdateCustomerData(id,customer);
            return Ok($"Successfully updated the customer {id}");
        }
        //Deletes customer from DB
        [HttpDelete("{id:Guid}")]
        public ActionResult RemoveCustomer(Guid id)
        {
            _serviceManager.CustomerService.RemoveCustomer(id);
            return Ok($"Successfully deleted Customer {id}");
        }
        /*[HttpGet("search")]
        public ActionResult Get(string searchTerm) 
        {
            return
        }*/


    }
}
