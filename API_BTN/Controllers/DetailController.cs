using API_BTN.Service.DetailService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_BTN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailController : ControllerBase
    {
        private readonly IDetailsService _detailService;    
        public DetailController(IDetailsService detailService)
        {
            this._detailService = detailService;
        }

        [HttpGet("{url}")]
        public async Task<IActionResult> GetAllByUrl(string url)
        {
            try
            {
                var list = _detailService.list(url);
                return Ok(new {
                    data= list
                });
            }
            catch (Exception ex) {
                return StatusCode(500, new
                {
                    message = "Không thể lấy dữ liệu từ controller.",
                    error = ex.Message
                });
            }
        }
    }
}
