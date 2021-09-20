using API.Models;
using System.Threading.Tasks;

namespace API.Services
{
    public interface IUserService
    {
        Task<int> AddUser(UserCommandModel userDetails);
    }
}
