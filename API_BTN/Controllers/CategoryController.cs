using API_BTN.Service.CategoryService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace API_BTN.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private ICategoryService _categoryService;
        public CategoryController (ICategoryService categoryService)
        {
            this._categoryService = categoryService;
        }
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var list = _categoryService.GetCategories();
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

        [HttpGet("{url}")]
        public async Task<IActionResult> GetByUrlCategory (string url)
        {
            try
            {
                var infor = _categoryService.GetCategoryByUrl(url);
                return Ok(new
                {
                    data = infor
                });
            }catch(Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("by/{url}")]
        public async Task<IActionResult> GetCategoryByUrlCate (string url)
        {
            try { 
                var cate = _categoryService.GetCategoryByUrlCategory(url);
                return Ok(new
                {
                    data = cate
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }

        }

        [HttpGet("id/{id}")]
        public async Task<IActionResult> GetInformationByCategoryId(int id)
        {
            try
            {
                var list = _categoryService.GetInformationByCateogryId(id);
                return Ok(new
                {
                    data = list
                });
            }
            catch(Exception ex)
            {
                return StatusCode(500);
            }
        }

        [HttpGet("urls/{url}")]
        public async Task<IActionResult> GetCategoryUrl (string url)
        {
            try
            {
                var category = _categoryService.GetCategory(url);
                return Ok(new
                {
                    data = category
                });
            }
            catch (Exception ex)
            {
                return StatusCode(500);
            }
        }
    }
}
