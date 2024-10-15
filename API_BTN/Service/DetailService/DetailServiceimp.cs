using API_BTN.Model;
using API_BTN.Repository.DetailRepository;

namespace API_BTN.Service.DetailService
{
    public class DetailServiceimp : IDetailsService
    {
        private readonly IDetailsRepository _detailsRepository;
        public DetailServiceimp(IDetailsRepository detailsRepository)
        {
           this._detailsRepository = detailsRepository;
        }

        public List<DetailContent> list(string url)
        {
            try
            {
                List<DetailContent> list = _detailsRepository.GetAll(url);
                return list;
            }
            catch(Exception ex)
            {
                throw new NotImplementedException();
            }
        }
    }
}
