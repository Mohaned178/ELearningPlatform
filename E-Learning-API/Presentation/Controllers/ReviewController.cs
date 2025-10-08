using E_Learning_API.Business.Interfaces;
using E_Learning_API.Domain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Learning_API.Presentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReviewController : ControllerBase
    {
        private readonly IReviewService _reviewService;
        public ReviewController(IReviewService reviewService) => _reviewService = reviewService;

        [HttpGet]
        [Authorize]
        public IActionResult GetAll() => Ok(_reviewService.GetAll());

        [HttpGet("{id}")]
        public IActionResult GetById(int id) => Ok(_reviewService.GetById(id));

        [HttpPost]
        public IActionResult Add([FromBody] ReviewDto dto)
        {
            _reviewService.Add(dto);
            return Ok();
        }

        [HttpPut]
        public IActionResult Update([FromBody] ReviewDto dto)
        {
            _reviewService.Update(dto);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _reviewService.Delete(id);
            return Ok();
        }
    }
}
