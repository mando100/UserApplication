using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserApplicationDAL.Entities;

namespace UserApplicationService
{
    public class UserApplicationRepository : IUserApplicationRepository
    {
        private readonly UserApplicationDBContext _dbContext;
        public UserApplicationRepository(UserApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Delete(int userId)
        {
            var user = new User { UserId = userId };
            _dbContext.User.Attach(user);
            _dbContext.User.Remove(user);

            await _dbContext.SaveChangesAsync();
        }

        public IEnumerable<User> GetAllUsers() 
        {
            var result = _dbContext.User;
            return result;
        }

        public async Task Insert(User newUser)
        {
            _dbContext.User.Add(newUser);

            await _dbContext.SaveChangesAsync();
        }

        public async Task<User> Update(int userId, User newUserInfo) 
        {
            var user = _dbContext.User.Find(userId);

            if (user != null)
            {
                user.Email = newUserInfo.Email;
                user.Name = newUserInfo.Name;
                user.Phone = newUserInfo.Phone;
                user.UserName = newUserInfo.UserName;
                
                await _dbContext.SaveChangesAsync();
            }

            return _dbContext.User.Find(user.UserId);
        }
    }
}
