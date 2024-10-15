using API_BTN.Model;

namespace API_BTN.Service.InforService
{
    public interface IInforService 
    {
        List<Information_Details> GetInformationDetails();  
        Information_Details GetInformationDetails(string url);
        Information_Details GetInforById(int id);   
    }
}
