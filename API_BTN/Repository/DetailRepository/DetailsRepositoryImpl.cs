using API_BTN.Data_Context;
using API_BTN.Model;

namespace API_BTN.Repository.DetailRepository
{
    public class DetailsRepositoryImpl : IDetailsRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public DetailsRepositoryImpl(ApplicationDbContext applicationDbContext)
        {
            this._applicationDbContext = applicationDbContext;
        }
        public List<DetailContent> GetAll(string linkUrl)
        {
            try
            {
                Information_Details information_Details = _applicationDbContext.Information.Where(inf => inf.linkTitle == linkUrl).FirstOrDefault();
                int id = information_Details.Id;
                List<DetailContent> list = _applicationDbContext.DetailsContent.Where(detail => detail.Detail_Id == id).ToList();
                return list;
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
           
        }
    }
}
