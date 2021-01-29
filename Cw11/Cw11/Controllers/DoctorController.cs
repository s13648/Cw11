using System;
using System.Threading.Tasks;
using Cw11.Dto;
using Cw11.Models;
using Cw11.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Cw11.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DoctorController : ControllerBase
    {
        private readonly IDoctorRepository doctorRepository;

        public DoctorController(IDoctorRepository doctorRepository)
        {
            this.doctorRepository = doctorRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetList()
        {
            return Ok(await doctorRepository.GetAll());
        }

        [HttpPost]
        public async Task<IActionResult> Create(DoctorEditDto doctor)
        {
            await doctorRepository.Create(doctor);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Edit([FromQuery]int id, [FromBody]DoctorEditDto doctor)
        {
            try
            {
                await doctorRepository.Update(id,doctor);
                return Ok();
            }
            catch (Exception e)when(e is NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove([FromQuery] int id)
        {
            try
            {
                await doctorRepository.Remove(id);
                return Ok();
            }
            catch (Exception e)when(e is NullReferenceException)
            {
                return NotFound();
            }
        }
    }
}
