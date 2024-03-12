using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Interface;
using WebApplication1.Models;
using WebApplication1.Requests.Dzivokli;
using WebApplication1.Responses;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DzivoklisController : ControllerBase
    {

        private readonly IDzivoklisService _dzivoklisService;

        public DzivoklisController(IDzivoklisService dzivoklisService)
        {
            _dzivoklisService = dzivoklisService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DzivoklisViewModel>> GetDzivokli()
        {
            return Ok(_dzivoklisService.GetAll());
        }

        [HttpGet("{Id:guid}")]
        public ActionResult<DzivoklisViewModel> GetDzivoklis([FromRoute] GetDzivoklisRequest request)
        {
            var dzivoklis = _dzivoklisService.GetById(request.Id);
            if (dzivoklis == null) return NotFound();
            return Ok(dzivoklis);
        }

        [HttpPost]
        public IActionResult PostDzivoklis([FromBody] PostDzivoklisRequest request)
        {   
            _dzivoklisService.PostDzivoklis(request);
            return Ok();
        }

        [HttpPut("{id}")]
        public IActionResult PutDzivoklis([FromBody] PutDzivoklisRequest request)
        {
            _dzivoklisService.PutDzivoklis(request);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDzivoklis(DeleteDzivoklisRequest request)
        {
            _dzivoklisService.DeleteDzivoklis(request);
            return NoContent();
        }

        [HttpGet("{id:guid}/dzivoklisIedzivotaji")]
        public ActionResult<IEnumerable<DzivoklisIedzivotajsViewModel>> GetDzivoklisIedzivotajiDetailsByDzivoklisId([FromRoute] Guid id)
        {
            var dzivoklisIedzivotaji = _dzivoklisService.GetDzivoklisIedzivotajiByDzivoklisId(id);
            if (dzivoklisIedzivotaji == null || !dzivoklisIedzivotaji.Any())
            {
                return NotFound($"No residents found for apartment with ID {id}");
            }

            return Ok(dzivoklisIedzivotaji);
        }
    }
}
