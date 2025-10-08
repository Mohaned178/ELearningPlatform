using E_Learning_API.Business.Interfaces;
using E_Learning_API.Domain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;
        public CourseController(ICourseService courseService) => _courseService = courseService;

        [HttpGet]
        [Authorize]
        public IActionResult GetAll() => Ok(_courseService.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_courseService.GetById(id));

        [HttpPost]
        public IActionResult Add([FromBody] CourseDto dto)
        {
            _courseService.Add(dto);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] CourseDto dto)
        {
            _courseService.Update(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _courseService.Delete(id);
            return Ok();
        }
    }

}
