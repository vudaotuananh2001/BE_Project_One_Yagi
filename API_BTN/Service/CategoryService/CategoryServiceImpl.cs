using API_BTN.Model;
using API_BTN.Repository.CategoryRepository;

namespace API_BTN.Service.CategoryService
{
    public class CategoryServiceImpl : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryServiceImpl(ICategoryRepository categoryRepository) {
            this._categoryRepository = categoryRepository;
        }

        public List<Category> GetCategories()
        {
            try
            {
                List<Category> list = _categoryRepository.GetAll(); 
                return list;    
            }
            catch (Exception ex) {
                throw new NotImplementedException();
            }
        }

        public Category GetCategory(string url)
        {
            try
            {
                Category category = _categoryRepository.Category(url);
                return category;
            }
            catch (Exception ex) {
                throw new NotImplementedException();
            }
        }

        public List<Information_Details> GetCategoryByUrl(string url)
        {
            try
            {
                List<Information_Details> list = _categoryRepository.GetByUrl(url);
                return list;
            }
            catch (Exception ex) {
                throw new NotImplementedException();
            }
        }

        public Category GetCategoryByUrlCategory(string urlcategory)
        {
            try
            {
                Category category = _categoryRepository.GetCategoryByUrl(urlcategory);
                return category;
            }
            catch (Exception ex) {
                throw new NotImplementedException();
            }
        }

        public List<Information_Details> GetInformationByCateogryId(int id)
        {
          try
            {
                 List<Information_Details>  list = _categoryRepository.GetListByCategoryId(id);
                return list;    
            }catch(Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
