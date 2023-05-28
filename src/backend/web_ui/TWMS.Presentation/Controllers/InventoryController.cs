using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TWMS.Presentation.Controllers
{
        public class InventoryController : ControllerBase
        {
            // GET: api/<OrdersController>
            [HttpGet]
            public IEnumerable<string> Get()
            {
                return new string[] { "value1", "value2" };
            }

            // GET api/<OrdersController>/5
            [HttpGet("{id}")]
            public string Get(int id)
            {
                return "value";
            }

            // POST api/<OrdersController>
            [HttpPost]
            public void Post([FromBody] string value)
            {
            }

            // PUT api/<OrdersController>/5
            [HttpPut("{id}")]
            public void Put(int id, [FromBody] string value)
            {
            }

            // DELETE api/<OrdersController>/5
            [HttpDelete("{id}")]
            public void Delete(int id)
            {
            }
        
    }
}
