using API_BTN.Model;

namespace API_BTN.Service.CategoryService
{
    public interface ICategoryService
    {
        List<Category> GetCategories();
        List<Information_Details> GetCategoryByUrl (string url);
        Category GetCategoryByUrlCategory (string urlcategory);
        List<Information_Details> GetInformationByCateogryId(int id);
        Category GetCategory(string url);
    }
}
