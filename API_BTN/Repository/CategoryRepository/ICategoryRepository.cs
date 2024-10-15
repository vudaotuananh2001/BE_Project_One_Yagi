using API_BTN.Model;

namespace API_BTN.Repository.CategoryRepository
{
    public interface ICategoryRepository
    {
        List<Category> GetAll();
        List<Information_Details> GetByUrl(string url);
        Category  GetCategoryByUrl(string url);
        List<Information_Details> GetListByCategoryId(int categoryId);
        Category Category(string url);
    }
}
