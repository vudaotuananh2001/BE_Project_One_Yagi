using API_BTN.Model;

namespace API_BTN.Repository.DetailRepository
{
    public interface IDetailsRepository
    {
        List<DetailContent> GetAll(string linkUrl);
    }
}
