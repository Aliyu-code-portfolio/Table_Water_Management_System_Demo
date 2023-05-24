using Microsoft.AspNetCore.Mvc;
using TWMS.DTOs.InputDTOs;
using TWMS.Infrastructure.ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TWMS.Presentation.Controllers
{
    [Route("api/customers/{customerId}/address")]
    [ApiController]
    public class CustomerAddressController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        public CustomerAddressController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }
        // GET: api/<OrdersController>
        [HttpGet(Name = "GetCustomerAddress")]
        public async Task<ActionResult> GetCustomerAddress(Guid customerId)
        {
            var address= await _serviceManager.CustomerAddressService.GetCustomerAddress(customerId);
            return Ok(address);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public async Task<ActionResult> AddAddress(Guid customerId, [FromBody] AddressToSave addressToSave)
        {
            if(addressToSave is null)
            {
                return BadRequest("Address object is null");
            }
            var address = await _serviceManager.CustomerAddressService.AddCustomerAddress(customerId,addressToSave);
            return CreatedAtAction(nameof(GetCustomerAddress),new {customerId, id=address.CustomerId }, address);
        }
        //Update customer addresss
        [HttpPut]
        public async Task<ActionResult> Put(Guid customerId, [FromBody] AddressToSave addressToSave)
        {
            await _serviceManager.CustomerAddressService.UpdateCustomerAddress(customerId, addressToSave);
            return Ok($"Address for customer {customerId} has been updated on the database");
        }

        /*// DELETE customer address
        [HttpDelete]
        public ActionResult Delete(Guid customerId)
        {
        }
*//*
        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }*/

        // PUT api/<OrdersController>/5
    }
}
