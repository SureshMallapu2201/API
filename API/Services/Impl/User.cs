using API.Models;
using System.Threading.Tasks;

namespace API.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly TaskDbContext _taskDbContext;
        public UserService(TaskDbContext taskDbContext)
        {
            _taskDbContext = taskDbContext;
        }
        public async Task<int> AddUser(UserCommandModel userDetails)
        {

            var user = new User()
            {
                FirstName= userDetails.FirstName,
                LastName= userDetails.LastName
            };
            _taskDbContext.UserDetails.Add(user);
            int res = _taskDbContext.SaveChanges();
            return res;
        }
    }
}
