using E_Learning_API.Business.Interfaces;
using E_Learning_API.Domain.DTOs;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EnrollmentController : ControllerBase
    {
        private readonly IEnrollmentService _enrollmentService;
        public EnrollmentController(IEnrollmentService enrollmentService) => _enrollmentService = enrollmentService;

        [HttpGet]
        public IActionResult GetAll() => Ok(_enrollmentService.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_enrollmentService.GetById(id));

        [HttpPost]
        public IActionResult Add([FromBody] EnrollmentDto dto)
        {
            _enrollmentService.Add(dto);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] EnrollmentDto dto)
        {
            _enrollmentService.Update(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _enrollmentService.Delete(id);
            return Ok();
        }
    }

}
