using API_BTN.Data_Context;
using API_BTN.Model;
using Microsoft.VisualBasic;

namespace API_BTN.Repository.InforRepository
{
    public class InforRepositoryImpl : IInforRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public InforRepositoryImpl(ApplicationDbContext applicationDbContext) { 
             this._applicationDbContext = applicationDbContext;  
        }

        public Information_Details GetById(int id)
        {
            try
            {
                Information_Details infors = _applicationDbContext.Information.Where(xx => xx.Id == id).FirstOrDefault();
                return infors;
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi xảy ra khi lấy dữ liệu thông tin." + e); // Cung cấp thông tin về lỗi
            }
        }

        public List<Information_Details> GetInforRepositoryDetails()
        {
            try
            {
                List<Information_Details> list = _applicationDbContext.Information.ToList();    
                return list;
            }
            catch (Exception e)
            {
                throw new Exception("Có lỗi xảy ra khi lấy dữ liệu thông tin." +e); // Cung cấp thông tin về lỗi
            }
        }

        public Information_Details information_Details(string url)
        {
            try
            {
                Information_Details information = _applicationDbContext.Information.Where(infor => infor.linkTitle == url).FirstOrDefault();
                return information;
            }
            catch (Exception e) {
                throw new Exception("Có lỗi xảy ra khi lấy dữ liệu thông tin." + e); // Cung cấp thông tin về lỗi

            }
        }
        public List<Information_Details> GetListInforByUrl(string url)
        {
            try
            {
                List<Information_Details> list = _applicationDbContext.Information.Where(inforxx => inforxx.linkTitle.Contains(url)).ToList();
                if (list == null)
                {
                    return null;
                }
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Có lỗi xảy ra khi lấy dữ liệu thông tin." + ex); // Cung cấp thông tin về lỗi
            }
        }

    }
}
