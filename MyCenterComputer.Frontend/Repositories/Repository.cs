using MyCenter.Frontend.Repositories;
using MyCenter.Shared.Models;

namespace MyCenterComputer.Frontend.Repositories
{
    public class Repository : IRepository
    {
        public  MyCenterComputer<Response<T>> GetAsync<T>(string url);
        {

        }
    }
}
