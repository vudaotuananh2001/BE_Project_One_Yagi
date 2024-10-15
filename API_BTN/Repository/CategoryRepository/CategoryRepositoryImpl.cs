using API_BTN.Data_Context;
using API_BTN.Model;
using API_BTN.Repository.InforRepository;

namespace API_BTN.Repository.CategoryRepository
{
    public class CategoryRepositoryImpl : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public CategoryRepositoryImpl(ApplicationDbContext applicationDbContext) { 

            this._applicationDbContext = applicationDbContext;
        }

        public Category Category(string url)
        {
            try
            {
                   Category category = _applicationDbContext.Categories.Where(cate => cate.urlCategory == url).FirstOrDefault();
                return category;
            }
            catch (Exception ex) {
                throw new NotImplementedException();
            }
        }

        public  List<Category> GetAll()
        {
            try
            {
                List<Category> list = _applicationDbContext.Categories.ToList();
                return list;
            }
            catch (Exception ex) {
                throw new NotImplementedException();
            }
        }

        public List<Information_Details> GetByUrl(string url)
        {
            try
            {
                Category infor = _applicationDbContext.Categories.Where(i => i.urlCategory == url).FirstOrDefault();
                int id = infor.Id;
                List<Information_Details> list = _applicationDbContext.Information.Where(inforList => inforList.Category_Id == id).ToList();
                return list;
            }
            catch (Exception ex) {
                throw new NotImplementedException();
            }
        }

        public Category GetCategoryByUrl(string url)
        {
            try
            {
                Category category = _applicationDbContext.Categories.Where(cate => cate.urlCategory == url).FirstOrDefault();
                return category;
            }
            catch (Exception ex) {
                throw new NotImplementedException();
            }
        }

        public List<Information_Details> GetListByCategoryId(int categoryId)
        {
           try
            {
                 Category category = _applicationDbContext.Categories.Where(cate =>cate.Id == categoryId).FirstOrDefault(); 
                    int id = category.Id;
                List<Information_Details> list = _applicationDbContext.Information.Where(inforsx => inforsx.Category_Id == id).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
