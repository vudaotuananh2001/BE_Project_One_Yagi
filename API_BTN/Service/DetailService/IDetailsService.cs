using API_BTN.Model;

namespace API_BTN.Service.DetailService
{
    public interface IDetailsService
    {
        List<DetailContent> list(string url);
    }
}
