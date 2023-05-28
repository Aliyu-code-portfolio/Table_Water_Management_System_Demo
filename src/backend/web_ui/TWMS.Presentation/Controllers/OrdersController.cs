using Microsoft.AspNetCore.Mvc;
using TWMS.DTOs.InputDTOs;
using TWMS.Infrastructure.ServiceContracts;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TWMS.Presentation.Controllers
{
    [Route("api/customers/{customerId}/orders")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private IServiceManager _serviceManager;

        public OrdersController(IServiceManager serviceManager)=> _serviceManager = serviceManager;


        // GET: api/<OrdersController>
        [HttpGet]
        public async Task<ActionResult> GetAllCustomerOrder(Guid customerId)
        {
            var orders = await _serviceManager.OrderOrderItemService.GetAllOrders(customerId);
            return Ok(orders);
        }

        // GET api/<OrdersController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult> GetOrderById(int id)
        {
            var order = await _serviceManager.OrderOrderItemService.GetOrderById(id);
            return Ok(order);
        }

        // POST api/<OrdersController>
        [HttpPost]
        public ActionResult Post(Guid customerId, [FromBody] OrderToSave order)
        {
            int idNotCorrect = _serviceManager.OrderOrderItemService.CreateOrder(customerId, order);
            return CreatedAtAction(nameof(Post),new { customerId,id=idNotCorrect }, order);
        }

        // PUT api/<OrdersController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(Guid customerId, int id, [FromBody] OrderToSave order)
        {
            await _serviceManager.OrderOrderItemService.UpdateOrder(customerId, id, order);
            return Ok($"Your order with id: {id} has been updated successfully updated");
        }

        // DELETE api/<OrdersController>/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(Guid customerId, int id)
        {
            await _serviceManager.OrderOrderItemService.RemoveOrder(customerId, id);
            return Ok($"Your order with id: {id} has been successfully removed from the database");
        }
    }
}
