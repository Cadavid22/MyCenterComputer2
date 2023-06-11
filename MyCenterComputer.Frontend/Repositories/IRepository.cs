
using MyCenter.Shared.Models;
using MyCenter.Shared.Entities;

namespace MyCenter.Frontend.Repositories
{
    public class IRepository
    {
        Task<Response<T>> GetAsync<T>(string url);

        Task<Response<T>> PostAsync<T>(string url, T model);

        Task<Response<T>> PutAsync<T>(string url, T model);

        Task<Response<T>> DeleteAsync<T>(string url);

    }
}
