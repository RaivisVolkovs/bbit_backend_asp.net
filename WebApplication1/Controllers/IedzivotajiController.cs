using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Models;
using WebApplication1.Requests.Iedzivotaji;
using WebApplication1.Responses;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IedzivotajiController : ControllerBase
    {
        private readonly IIedzivotajsService _iedzivotajsService;

        public IedzivotajiController(IIedzivotajsService iedzivotajsService)
        {
            _iedzivotajsService = iedzivotajsService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<IedzivotajsViewModel>> GetIedzivotaji()
        {
            return Ok(_iedzivotajsService.GetAll());
        }

        [HttpGet("{Id:guid}")]
        public ActionResult<IedzivotajsViewModel> GetIedzivotajs([FromRoute] GetIedzivotajsRequest request)
        {
            var iedzivotajs = _iedzivotajsService.GetById(request.Id);
            if (iedzivotajs == null) return NotFound();
            return Ok(iedzivotajs);
        }

        [HttpPost]
        public IActionResult PostIedzivotajs([FromBody] PostIedzivotajsRequest request)
        {
            _iedzivotajsService.PostIedzivotajs(request);
            return Ok();
        }

        [HttpPut("{Id:guid}")]
        public IActionResult PutIedzivotajs([FromBody] PutIedzivotajsRequest request)
        {
            _iedzivotajsService.PutIedzivotajs(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteIedzivotajs(DeleteIedzivotajsRequest request)
        {
            _iedzivotajsService.DeleteIedzivotajs(request);
            return NoContent();
        }
    }
}

