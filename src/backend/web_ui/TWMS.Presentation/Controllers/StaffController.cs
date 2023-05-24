using Microsoft.AspNetCore.Mvc;
using TWMS.Application.Contracts;
using TWMS.Domain.Models.Customer;
using TWMS.Domain.Models.Staff;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TWMS.Presentation.Controllers
{
    [Route("api/staffs")]
    [ApiController]
    public class StaffController : ControllerBase
    {
        /*private readonly IStaffRepository _staffService;
      
        public StaffController (IStaffRepository staffService)
        {
            _staffService = staffService;
        }
        // GET: api/<StaffController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Staff>>> Get()
        {
            var customers = await _staffService.GetAllAsync(false);
            return Ok(customers);
        }

        // GET api/<StaffController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Staff>> Get(int id)
        {
            var customer =await _staffService.GetByConditionAsync(item=>item.Id==id,false);
            return Ok(customer);
        }

        // POST api/<StaffController>
        [HttpPost]
        public ActionResult Post([FromBody]StaffRecord record)
        {
            Staff staff = new()
            {
                FirstName = record.firstName,
                LastName = record.lastName,
                Birthday = record.birthday,
                Gender = record.gender,
                PhoneNo = record.phoneNo,
                Salary = record.salary,
                DateJoined = record.datejoined,
                EmailAddress = record.emailAddress,
                StaffAddress =
                 new StaffAddress()
                 {
                     BuildingNumber = record.buildingNumber,
                     StreetName = record.streetName,
                     AreaLocality = record.areaLocality,
                     Landmark = record.landmark,
                     City = record.city,
                     Zip_PostalCode = record.zipCode,
                     State_Province = record.stateProvince,

                 },
                Guarantor = new Guarantor()
                {
                    FirstName = record.guarantorFirstName,
                    LastName= record.guarantorLastName,
                    Birthday= record.guarantorBirthday,
                    Gender= record.guarantorGender,
                    PhoneNo= record.guarantorPhoneNo,
                    EmailAddress=record.guarantorEmail
                }
            };
            _staffService.Add(staff);
            return CreatedAtAction(nameof(Staff), new { id = staff.Id }, staff);//Ask ChatGPT for better explanation
        }

        // PUT api/<StaffController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Staff staff)
        {
            if(id!=staff.Id)
            {
                return BadRequest();
            }
            _staffService.Update(staff);
            return NoContent();
        }

        // DELETE api/<StaffController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            //_staffService.DeleteById(id); 
            return NoContent();
        }*/
    }
}
