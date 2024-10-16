using API_BTN.Service.InforService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_BTN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InforController : ControllerBase
    {
        private readonly IInforService _inforService;
        public InforController(IInforService inforService)
        {
            this._inforService = inforService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            try
            {
                var list = _inforService.GetInformationDetails();
                return Ok(new
                {
                    data = list
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new
                {
                    message = "Không thể lấy dữ liệu từ controller.",
                    error = ex.Message
                });
            }
        }

        [HttpGet("{url}")]
        public async Task<IActionResult> GetInformationByUrl(string url)
        {
            try
            {
                var infor = _inforService.GetInformationDetails(url);
                return Ok(new
                {
                    data = infor
                });
            }
            catch (Exception ex)
            {
                {
                    return StatusCode(500, new
                    {
                        message = "Không thể lấy dữ liệu từ controller.",
                        error = ex.Message
                    });
                }
            }
        }

        [HttpGet("by/{id}")]
        public async Task<IActionResult> GetById (int id)
        {
            try
            {
                var inforyy = _inforService.GetInforById(id);
                return Ok(new
                {
                    data = inforyy
                });
            }catch(Exception ex)
            {
                {
                    return StatusCode(500, new
                    {
                        message = "Không thể lấy dữ liệu từ controller.",
                        error = ex.Message
                    });
                }
            }
        }

        [HttpGet("search={url}")]
        public async Task<IActionResult> GetBySearchUrl(string url)
        {
            try
            {
                var list = _inforService.GetInforBySearchUrl(url);
                if (list == null)
                {
                    return NotFound();
                }
                return Ok(new
                {
                    data = list
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
