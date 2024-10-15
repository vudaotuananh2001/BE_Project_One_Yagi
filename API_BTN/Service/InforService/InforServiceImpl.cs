using API_BTN.Model;
using API_BTN.Repository.InforRepository;

namespace API_BTN.Service.InforService
{
    public class InforServiceImpl : IInforService
    {
        private readonly IInforRepository _inforRepository;
        public InforServiceImpl(IInforRepository inforRepository) { 
            this._inforRepository = inforRepository;    
        }

        public Information_Details GetInforById(int id)
        {
            try
            {
                Information_Details list = _inforRepository.GetById(id);
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Service " + ex);
            }
        }

        public List<Information_Details> GetInformationDetails()
        {
            try
            {
                List<Information_Details>  list = _inforRepository.GetInforRepositoryDetails();
                return list;    
            }
            catch (Exception ex) {
                throw new Exception("Error Service " + ex);
            }
        }

        public Information_Details GetInformationDetails(string url)
        {
            try
            {
                Information_Details list = _inforRepository.information_Details(url);
                return list;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Service " + ex);
            }
            throw new NotImplementedException();
        }
    }
}
