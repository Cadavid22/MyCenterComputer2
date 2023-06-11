using MyCenter.Shared.Models;

namespace MyCenter.Frontend.Repositories
{
    public class IRepository
    {
        MyCenter<Response<T>> GetAsync<T>(string url);
    }
}
