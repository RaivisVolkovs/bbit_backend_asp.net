using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Models;
using WebApplication1.Requests.Maja;
using WebApplication1.Responses;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MajaController : ControllerBase
    {
        private readonly IMajaService _mājaService;


        public MajaController(IMajaService mājaService)
        {
            _mājaService = mājaService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<MajaViewModel>> GetMajas()
        {
            return Ok(_mājaService.GetAll());
        }

        [HttpGet("{Id:guid}")]
        public ActionResult<MajaViewModel> GetMaja([FromRoute] GetMajaRequest request)
        {
            var māja = _mājaService.GetById(request.Id);
            if (māja == null) return NotFound();
            return Ok(māja);
        }

        [HttpPost]
        public IActionResult PostMaja([FromBody] PostMajaRequest request)
        {
            _mājaService.PostMaja(request);
            return Ok();
        }

        [HttpPut("{Id:guid}")]
        public ActionResult<PutMajaResponse> PutMaja([FromBody] PutMajaRequest request)
        {
            _mājaService.PutMaja(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMaja(DeleteMajaRequest request)
        {
            _mājaService.DeleteMaja(request);
            return NoContent();
        }
    }

}
