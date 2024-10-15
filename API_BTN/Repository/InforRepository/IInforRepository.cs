using API_BTN.Model;
using Microsoft.VisualBasic;

namespace API_BTN.Repository.InforRepository
{
    public interface IInforRepository
    {
        List<Information_Details> GetInforRepositoryDetails();
        Information_Details information_Details(string url);
        Information_Details GetById(int id);
    }
}
