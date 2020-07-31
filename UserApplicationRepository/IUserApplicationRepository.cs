using System.Collections.Generic;
using System.Threading.Tasks;
using UserApplicationDAL.Entities;

namespace UserApplicationService
{
    public interface IUserApplicationRepository
    {
        IEnumerable<User> GetAllUsers();
        Task Insert(User newUser);
        Task Delete(int userId);
        Task<User> Update(int userId, User newUserInfo);
    }
}
