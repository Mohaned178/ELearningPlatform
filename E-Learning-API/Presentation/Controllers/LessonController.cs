using E_Learning_API.Business.Interfaces;
using E_Learning_API.Domain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LessonController : ControllerBase
    {
        private readonly ILessonService _lessonService;
        public LessonController(ILessonService lessonService) => _lessonService = lessonService;

        [HttpGet]
        [Authorize]
        public IActionResult GetAll() => Ok(_lessonService.GetAll());

        [HttpGet("byCourse/{courseId}")]
        public IActionResult GetByCourseId(int courseId) => Ok(_lessonService.GetByCourseId(courseId));

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_lessonService.GetById(id));

        [HttpPost]
        public IActionResult Add([FromBody] LessonDto dto)
        {
            _lessonService.Add(dto);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] LessonDto dto)
        {
            _lessonService.Update(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _lessonService.Delete(id);
            return Ok();
        }
    }
}
